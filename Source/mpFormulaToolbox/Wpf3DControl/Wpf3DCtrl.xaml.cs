	
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Windows.Interop;

using Microsoft.Win32;

namespace Wpf3DControl
{
    public partial class Wpf3DCtrl : UserControl
    {
        private Model3DGroup MainModel3Dgroup = new Model3DGroup();
        private PerspectiveCamera myPCamera = new PerspectiveCamera();
		private OrthographicCamera myOCamera = new OrthographicCamera();
        private double CameraPhi = Math.PI / 10.0;
        private double CameraTheta = 120 * Math.PI / 180.0;    
        private double CameraRStart = 4.0;
        private double CameraR = 4.0; 
        private Boolean UseOrthographicCamera = false;
      
    	
	public string RootDir32()
	{
		RegistryKey regKey = null;
		string RootPath = "Not set";
		try {
			regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\mpFormulaToolbox", false);
			RootPath = regKey.GetValue("RootPath", "Not set").ToString();
			regKey.Close();
		} catch (Exception ex) {
			MessageBox.Show("RootDir not set", ex.Message);
		}
		return RootPath;
	}
        
        
    	public Wpf3DCtrl()
        {
			InitializeComponent();
			PositionCamera();
			DefineLights();
			ModelVisual3D model_visual = new ModelVisual3D();
			model_visual.Content = MainModel3Dgroup;
			MainViewport.Children.Add(model_visual);
        }
        
        
        public void ClearModel()
        {
        	int n = MainModel3Dgroup.Children.Count-1;
        	for (int i = n; i > 2 ; i--)
        	{
        		MainModel3Dgroup.Children.RemoveAt(i);
        	}
        }
        

        
        public void RemoveLastModel()
        {
        	int n = MainModel3Dgroup.Children.Count - 1;
        	if (n > 2) MainModel3Dgroup.Children.RemoveAt(n);
        }
        
        
        
      
        
      public void MakeModel(int Mode, int CoordinateStyle1, BitmapImage MyBitmapImage, int MaterialType, double[,] xvalues, double[,] yvalues, double[,] zvalues, 
                              double xmin, double zmin, int xResolution, int zResolution, String RenderStyle, String Function3D)
      {

        if (Mode==0)
        {
           MakeModel0(0, CoordinateStyle1, MyBitmapImage, MaterialType, xvalues, yvalues, zvalues, xmin, zmin, xResolution, zResolution, RenderStyle, Function3D);
        }
        else
        {
            MakeModel0(1, CoordinateStyle1, MyBitmapImage, MaterialType, xvalues, yvalues, zvalues, xmin, zmin, xResolution, zResolution, RenderStyle, Function3D);
            MakeModel0(2, CoordinateStyle1, MyBitmapImage, MaterialType, xvalues, yvalues, zvalues, xmin, zmin, xResolution, zResolution, RenderStyle, Function3D);
        }

        if (CoordinateStyle1 > 0) AddAxes();

      }

        
      public void MakeModel0(int Mode, int CoordinateStyle1, BitmapImage MyBitmapImage, int MaterialType, double[,] xvalues, double[,] yvalues, double[,] zvalues, 
                              double xmin, double zmin, int xResolution, int zResolution, String RenderStyle, String Function3D)
      {

      	Dictionary<Point3D, int> PointDictionary = new Dictionary<Point3D, int>();
		MeshGeometry3D mesh = new MeshGeometry3D();
		int izStart = 0;
		int izStop = zResolution;
		if (Mode==1) izStop = (zResolution)/2 -1;
		if (Mode==2) izStart = (zResolution)/2 + 1;

		for (int ix = 0; ix < (xResolution-0); ix++)
		{
			for (int iz = izStart; iz < izStop; iz++)
			{
			  int ix_1 = ix+1;
			  int iz_1 = iz+1;

			  Point3D p00 = new Point3D(xvalues[ix, iz], yvalues[ix, iz], zvalues[ix, iz]);
		      Point3D p10 = new Point3D(xvalues[ix_1, iz], yvalues[ix_1, iz], zvalues[ix_1, iz]);
		      Point3D p01 = new Point3D(xvalues[ix, iz_1], yvalues[ix, iz_1], zvalues[ix, iz_1]);
		      Point3D p11 = new Point3D(xvalues[ix_1, iz_1], yvalues[ix_1, iz_1], zvalues[ix_1, iz_1]);
		      AddTriangle(PointDictionary, mesh, p00, p01, p11, xmin, zmin);
		      AddTriangle(PointDictionary, mesh, p00, p11, p10, xmin, zmin);
			}
		}
		Material surface_material = null;
		ImageBrush texture_brush = new ImageBrush();
		switch (MaterialType)
		{
		    case 0:
		        surface_material = new DiffuseMaterial(Brushes.Silver);
		        break;
		    case 1:
		        surface_material = new DiffuseMaterial(Brushes.Gold);
		        break;
		    case 2:
		        String FName =  RenderStyle;
	            String PngPath = RootDir32() +  @"GUI\" + FName + ".png";
		        texture_brush.ImageSource = new BitmapImage (new Uri(PngPath, UriKind.Absolute));
		        surface_material = new DiffuseMaterial(texture_brush);
		        break;
		    case 3:
		    case 4: 
			case 5:		        
		        texture_brush.ImageSource = MyBitmapImage;
		        surface_material = new DiffuseMaterial(texture_brush);
		        break;
	        case 6:
		        surface_material = ShinySurface(new SolidColorBrush(Colors.Red), new SolidColorBrush(Colors.Yellow));
		        break;
	        case 7:
		        surface_material = ShinySurface(new SolidColorBrush(Colors.Green), new SolidColorBrush(Colors.Yellow));
		        break;
	        case 8:
		        surface_material = ShinySurface(new SolidColorBrush(Colors.Blue), new SolidColorBrush(Colors.Yellow));
		        break;
	        case 9:
		        surface_material = ShinySurface(new SolidColorBrush(Colors.Gold), new SolidColorBrush(Colors.Gold));
		        break;
	        case 10:
		        surface_material = ShinySurface(new SolidColorBrush(Colors.Silver), new SolidColorBrush(Colors.Silver));
		        break;
		    default:
		        surface_material = new DiffuseMaterial(Brushes.Silver);
		        break;
		}          
		
		GeometryModel3D surface_model = new GeometryModel3D(mesh, surface_material);
		surface_model.BackMaterial = surface_material;
		MainModel3Dgroup.Children.Add(surface_model);

      }


        public MaterialGroup ShinySurface(Brush brush1, Brush brush2)
        {
		        Material materialBack = new DiffuseMaterial (brush1);
                Material materialSpec = new SpecularMaterial(brush2, 100);
//		        Material materialEmiss = new EmissiveMaterial(new SolidColorBrush(System.Windows.Media.Colors.Red));

                MaterialGroup materialGroup = new MaterialGroup();
                materialGroup.Children.Add(materialBack);
                materialGroup.Children.Add(materialSpec);
//                materialGroup.Children.Add(materialEmiss);
                return materialGroup;
            
        }
        
        

        private void AddTriangle(Dictionary<Point3D, int> PointDictionary, MeshGeometry3D mesh, Point3D point1, Point3D point2, Point3D point3, double xmin, double zmin)
        {
        	
            int index1 = AddPoint(PointDictionary,mesh.Positions, mesh.TextureCoordinates, point1, xmin, zmin);
            int index2 = AddPoint(PointDictionary,mesh.Positions, mesh.TextureCoordinates, point2, xmin, zmin);
            int index3 = AddPoint(PointDictionary,mesh.Positions, mesh.TextureCoordinates, point3, xmin, zmin);
			mesh.TriangleIndices.Add(index1);
			mesh.TriangleIndices.Add(index2);
			mesh.TriangleIndices.Add(index3);
        }

        
        private int AddPoint(Dictionary<Point3D, int> PointDictionary, Point3DCollection points, PointCollection texture_coords, Point3D point, double xmin, double zmin)
        {
            // If the point is in the point dictionary,
            // return its saved index.
            if (PointDictionary.ContainsKey(point))
                return PointDictionary[point];

            // We didn't find the point. Create it.
            points.Add(point);
            PointDictionary.Add(point, points.Count - 1);

            // Set the point's texture coordinates.
            
            
//          double texture_xscale = (xmax - xmin);
//			double texture_zscale = (zmax - zmin);

            double texture_xscale = 1.0;
			double texture_zscale = 1.0;
			
            texture_coords.Add(
                new Point(
                    (point.X - xmin) * texture_xscale,
                    (point.Z - zmin) * texture_zscale));

            // Return the new point's index.
            return points.Count - 1;
        }

        
// ******************************** Add Axes of Coordinate System ************************************************************

        public void AddAxes()
        {
          double T = 0.01;  // Thickness of cube
       	  double L = 0.5;  // Longest part of cube, also determines distance from main mesh
      	  
       	  AddCube(1, T, L, -L, -L-T, -L-T); // X-Axis Bottom Rear
       	  AddCube(1, T, L, -L, -L-T, L);   // X-Axis Top Rear
       	  AddCube(1, T, L, -L, L, -L-T);   // X-Axis Bottom Front
       	  AddCube(1, T, L, -L, L, L);   // X-Axis Top Front
       	  
       	  AddCube(2, T, L, -L-T, -L, -L-T);   // Z-Axis Bottom Left
       	  AddCube(2, T, L, -L-T, -L, L);   // Z-Axis Top Left
       	  AddCube(2, T, L, L, -L, -L-T);   // Z-Axis Bottom Right
       	  AddCube(2, T, L, L, -L, L);   // Z-Axis Top Right
       	  
       	  AddCube(3, T, L, -L-T, -L-T, -L);   // Y-Axis Left Rear
       	  AddCube(3, T, L, -L-T, L, -L);   // Y-Axis Left Front
       	  AddCube(3, T, L, L, -L-T, -L);   // Y-Axis Right Rear
       	  AddCube(3, T, L, L, L, -L);   // Y-Axis Right Front

       	  AddCube(4, T, L, -L-T, -L-T, -L-T);   // Connector Left Bottom Rear
       	  AddCube(4, T, L, -L-T, -L-T, L);   // Connector Left Top Rear
       	  AddCube(4, T, L, -L-T, L, -L-T);   // Connector Left Bottom Front
       	  AddCube(4, T, L, -L-T, L, L);   // Connector Left Top Front
       	  AddCube(4, T, L, L, -L-T, -L-T);   // Connector Right Bottom Rear
       	  AddCube(4, T, L, L, -L-T, L);   // Connector Right Top Rear
       	  AddCube(4, T, L, L, L, -L-T);   // Connector Right Bottom Front
       	  AddCube(4, T, L, L, L, L);   // Connector Right Top Front
        }

        
             
       public void AddCube(int Axis, double Thickness, double L, double LOffset, double WOffset, double HOffset)
        {
//          double LOffset;   // X-Axis, more positive means moving right
//          double WOffsetL;   // Z-Axis, more positive means moving forward
//          double HOffsetL;   // Y-Axis, more positive means moving up
          
        var mesh = new MeshGeometry3D();
        
        double Length = Thickness;
        double Height = Thickness;
        double Width = Thickness ;
        
        switch (Axis)
        {
        case 1:
            mesh.TextureCoordinates = new PointCollection(new Point[] { new Point(0.5, 0), new Point(0.5, 1), new Point(0.5, 0), new Point(0.5, 1), new Point(0.5, 0), new Point(0.5, 1), new Point(0.5, 0), new Point(0.5, 1) });
            Length = 2 * L;
            break;
        case 2:
        	mesh.TextureCoordinates = new PointCollection(new Point[] { new Point(0, 0.5), new Point(1.0, 0.5), new Point(0, 0.5), new Point(1.0, 0.5) });
            Width = 2 * L;
        	break;
        case 3:
        	mesh.TextureCoordinates = new PointCollection(new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1), new Point(1, 1), new Point(0, 0), new Point(1, 0), new Point(0, 1), new Point(1, 1) });
            Height = 2 * L;
        	break;
        }          
        
        Point3D p0 = new Point3D(LOffset, HOffset, WOffset);
        Point3D p1 = new Point3D(LOffset + Length, HOffset, WOffset);
        Point3D p2 = new Point3D(LOffset, HOffset + Height, WOffset);
        Point3D p3 = new Point3D(LOffset + Length, HOffset + Height, WOffset);
        Point3D p4 = new Point3D(LOffset, HOffset, Width + WOffset);
        Point3D p5 = new Point3D(LOffset + Length, HOffset, Width + WOffset);
        Point3D p6 = new Point3D(LOffset, HOffset + Height, Width + WOffset);
        Point3D p7 = new Point3D(LOffset + Length, HOffset + Height, Width + WOffset);
        
        mesh.Positions = new Point3DCollection { p0, p1, p2, p3, p4,p5, p6, p7 };
        mesh.TriangleIndices = new Int32Collection(new int[] {  2, 7, 3,  2, 6, 7,  0, 1, 5,  0, 5, 4 , 2, 3, 1,  2, 1, 0,  7, 1, 3,  7, 5, 1,  6, 5, 7,  6, 4, 5,  6, 2, 0,  6, 4, 0  });
        DiffuseMaterial surface_material = null;
        if (Axis == 4)   surface_material = new DiffuseMaterial(Brushes.Gray);
        else surface_material = new DiffuseMaterial(GetMyBrush(Axis + 0));

        GeometryModel3D surface_model = new GeometryModel3D(mesh, surface_material);
        surface_model.BackMaterial = surface_material;
        surface_model.Material = surface_material;
        MainModel3Dgroup.Children.Add(surface_model);
    }

        
       
    
    private LinearGradientBrush GetMyBrush(int ColorChoice)
    {
	    LinearGradientBrush LGB = new LinearGradientBrush();
	    LGB.StartPoint = new Point(0.5, 0);
	    LGB.EndPoint = new Point(0.5, 1);
	    GradientStop startGS = new GradientStop();
	    if (ColorChoice != 2) startGS.Color = Colors.LightGray; else startGS.Color = Colors.Red;
	    startGS.Offset = 0.0;
	    LGB.GradientStops.Add(startGS);
	    GradientStop stopGS = new GradientStop();
       	if (ColorChoice == 1) stopGS.Color = Colors.Blue;
	    if (ColorChoice == 2) stopGS.Color = Colors.Gray;
	    if (ColorChoice == 3) stopGS.Color = Colors.Black;
		stopGS.Offset = 1.0;
	    LGB.GradientStops.Add(stopGS);
	    return LGB;
    }
       

        
        
// ********************************** General Routines ***************************************************************        

        
        // Define the lights.
        private void DefineLights()
        {
          AmbientLight ambient_light = new AmbientLight(Colors.Gray);
          DirectionalLight directional_light = new DirectionalLight(Colors.Gray, new Vector3D(-1.0, -3.0, -2.0));
          DirectionalLight directional_light2 = new DirectionalLight(Colors.Gray, new Vector3D(1.0, 3.0, 2.0));

          MainModel3Dgroup.Children.Add(ambient_light);
          MainModel3Dgroup.Children.Add(directional_light);
          MainModel3Dgroup.Children.Add(directional_light2);
        }
        
        
        public void SetCameraType(int CameraType)
        {
        	if (CameraType == 0) UseOrthographicCamera = true; else UseOrthographicCamera = false;
        	PositionCamera();
        }
        
        
        
        public void SetCameraPhi(double NewPhi)
        {
        	CameraPhi = NewPhi;
        	if (CameraPhi > Math.PI / 2.0) CameraPhi = Math.PI / 2.0;
        	if (CameraPhi < -Math.PI / 2.0) CameraPhi = -Math.PI / 2.0;
        	PositionCamera();
        }

        public void SetCameraTheta(double NewTheta)
        {
        	CameraTheta = NewTheta * Math.PI / 180.0;
        	PositionCamera();
        }


        public void SetCameraFactor(double factor)
        {
        	CameraR = CameraRStart * factor;
        	PositionCamera();
        }
        
        

        // Position the camera.
        private void PositionCamera()
        {
          // Calculate the camera's position in Cartesian coordinates.
          double y = CameraR * Math.Sin(CameraPhi);
          double hyp = CameraR * Math.Cos(CameraPhi);
          double x = hyp * Math.Cos(CameraTheta);
          double z = hyp * Math.Sin(CameraTheta);
          
		  if ((bool)UseOrthographicCamera == true)          
			{
	          myOCamera.Position = new Point3D(x, y, z);
	          	// Look toward the origin.
	          myOCamera.LookDirection = new Vector3D(-x , -y, -z);
	          // Set the Up direction.
	          myOCamera.UpDirection = new Vector3D(0, 1, 0);
	          MainViewport.Camera = myOCamera;
			}
          else
          {
	          myPCamera.Position = new Point3D(x, y, z);
	          	// Look toward the origin.
	          myPCamera.LookDirection = new Vector3D(-x , -y, -z);
	          // Set the Up direction.
	          myPCamera.UpDirection = new Vector3D(0, 1, 0);
//	          myPCamera.UpDirection = new Vector3D(0, -1, 0);  //flip upside down 
	          myPCamera.FieldOfView = 30.0;
	          MainViewport.Camera = myPCamera;
          }
        }




        public void Save3DBitmap(String FileName, String Extension, Boolean WhiteBackground)
        {
          //  RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
            
          double scale = 600 / 96;
          
          Rect bounds = VisualTreeHelper.GetDescendantBounds(MainViewport);
          if (bounds.IsEmpty) return;

          RenderTargetBitmap rtb = new RenderTargetBitmap((Int32) (scale * (bounds.Width)), (Int32) (scale * (bounds.Height)), scale * 96, scale * 96, PixelFormats.Pbgra32);
          DrawingVisual dv = new DrawingVisual();
          using (DrawingContext dc = dv.RenderOpen())
          {
              if (WhiteBackground)
              {
                  Size MySize = new Size();
                  MySize.Height = bounds.Height +10;
                  MySize.Width = bounds.Width +10;
                  dc.DrawRectangle(Brushes.White, null, new Rect(new Point(), MySize));
              }
            VisualBrush vb = new VisualBrush(MainViewport);
            dc.DrawRectangle(vb, null, new Rect(new Point(), bounds.Size));
          }
          rtb.Render(dv);
          
          BitmapEncoder Encoder = null;
          if (Extension == "jpg") Encoder = new JpegBitmapEncoder(); 
          else Encoder = new PngBitmapEncoder();
          
          Encoder.Frames.Add(BitmapFrame.Create(rtb));
          using (Stream stm = File.Create(FileName))
          {
            Encoder.Save(stm);
          }
        }


        
        











    }
}
