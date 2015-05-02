
using System;
using System.IO;
using System.Numerics;
using System.Windows.Media.Imaging;

namespace WpfInWinForms
{
	public class Data3D
	{
		public double[,] yvalues = null; 
		public double[,] y2values = null; 
		public double[] xvalues = null; 
		public double[] zvalues = null; 
		public BitmapImage MyBitmapImage = null;
        public int xResolution = 0;
        public int zResolution = 0;
        public double ScaledXmin = 0;
		public double ScaledZmin = 0;
		
		private double xmin = 0;
	    private double xmax = 0;
	    private double zmin = 0;
	    private double zmax = 0;
	    
	    private double ymin = 0;
	    private double ymax = 0;


		
		
		private String RenderStyle = "";
		private Boolean IsComplex = false;
		private int CplxResultType = 0;



//		public Data3D LowerImag()
//		{
//		    Data3D Data3D1 = new Data3D("LowerImag", xResolution, (zResolution / 2), "LIGHTGRAY", 1, xmin, xmax, zmin, 0, out ymin, out ymax);
//		    
//		   for (int ix = 0; ix < Data3D1.xResolution; ix++)
//           {
//                Data3D1.xvalues[ix] = xvalues[ix];
//                for (int iz = 0; iz < Data3D1.zResolution; iz++)
//                {
//                    Data3D1.yvalues[ix, iz] = yvalues[ix, iz];
//                }
// 		   }
//            for (int iz = 0; iz < Data3D1.zResolution; iz++)
//            {
//                Data3D1.zvalues[iz] = zvalues[iz];
//            }
//
//		   
//		   ymin = ymin * 1;
//		   ymax = ymax * 1;
//		   return Data3D1;
//		}
		
		public Data3D(String Function3D, int xResolution2, int zResolution2, String NewRenderStyle, int NewCplxResultType, 
		              double xmin1, double xmax1, double zmin1, double zmax1, out double ymin1, out double ymax1)
		{
			RenderStyle = NewRenderStyle;
			CplxResultType = NewCplxResultType;
			xResolution = xResolution2;
			zResolution = zResolution2;
			xmin = xmin1; xmax = xmax1; zmin = zmin1; zmax = zmax1;
			yvalues = new double[xResolution, zResolution];
			y2values = new double[xResolution, zResolution];
			xvalues = new double[xResolution];
			zvalues = new double[zResolution];
			if (Function3D != "LowerImag") CreateMap(Function3D, out ymin, out ymax);
			ymin1 = ymin;
			ymax1 = ymax;
		}

		
		private Complex cplxF(String Function3D, double x, double z)
		{
			Complex cplxResult = new Complex(0.0, 0.0);
			if (Function3D == "_COMPLEXSINE")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Sin(c1);
	         }
			
			if (Function3D == "_COMPLEXCOSINE")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Cos(c1);
	         }

			if (Function3D == "_COMPLEXTAN")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Tan(c1);
	         }
			
			if (Function3D == "_COMPLEXASIN")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Asin(c1);
	         }
			
			if (Function3D == "_COMPLEXACOS")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Acos(c1);
	         }

			if (Function3D == "_COMPLEXATAN")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Atan(c1);
	         }


			
			if (Function3D == "_COMPLEXSINH")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Sinh(c1);
	         }
			
			if (Function3D == "_COMPLEXCOSH")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Cosh(c1);
	         }
			
			if (Function3D == "_COMPLEXTANH")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Tanh(c1);
	         }
			


			
			if (Function3D == "_COMPLEXLOG")
	         {
//				if (Math.Abs(x) < 0.1) {x = 0.1 * Math.Sign(x);}
//				if (Math.Abs(z) < 0.1) {z = 0.1 * Math.Sign(z);}
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Log(c1);
	         }

			if (Function3D == "_COMPLEXEXP")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Exp(c1);
	         }
			
			if (Function3D == "_COMPLEXSQRT")
	         {
				Complex c1 = new Complex(x, z);
				cplxResult = Complex.Sqrt(c1);
	         }

			
			return cplxResult;
		}


		
		private double cplx2double(Complex cplxResult, int CplxResultType)
		{
			double Result = 0.0;
			switch (CplxResultType)
			{
				case 0: Result = cplxResult.Real; break;
				case 1: Result = cplxResult.Imaginary; break;
				case 3: Result = cplxResult.Magnitude; break;
				case 4: Result = cplxResult.Phase; break;
				default: Result = 0; break;
			}          
//			Result = Math.Atan(Result);
			if (Math.Abs(Result) > 10) {Result = 10* Math.Sign(Result);}
			return Result;
		}

		
		
        private double F(String Function3D, double x, double z)
        {
			double result = 0;
	         if (Function3D == "SURFACE1")
	         {
	            double r2 = x * x + z * z;
	            result = 8 * Math.Cos(r2 / 2) / (2 + r2);
	         }

	         if (Function3D == "SURFACE2")
	         {
				const double two_pi = 2 * 3.14159265;
				double r2 = x * x + z * z;
				double r = Math.Sqrt(r2);
				double theta = Math.Atan2(z, x);
				result = Math.Exp(-r2) * Math.Sin(two_pi * r) * Math.Cos(3 * theta);
	         }
	         return result;

	         

        }

        

        private void CreateMap(String Function3D, out double ymin_out, out double ymax_out)
        {
        	
	         double dx = 0;
	         double dz = 0;
	
	         double xRange = 0;
	         double zRange = 0;
	        
	        

	         if (Function3D == "_COMPLEXSINE" || Function3D == "_COMPLEXCOSINE" || Function3D == "_COMPLEXTAN" || Function3D == "_COMPLEXSINH" || Function3D == "_COMPLEXCOSH" || Function3D == "_COMPLEXTANH" 
	             || Function3D == "_COMPLEXASIN" || Function3D == "_COMPLEXACOS" || Function3D == "_COMPLEXATAN" 
	             ||  Function3D == "_COMPLEXLOG" || Function3D == "_COMPLEXEXP"|| Function3D == "_COMPLEXSQRT")
	         {
	         	IsComplex = true;
	         }
	         
//	         GetRanges(Function3D, out xmin, out xmax, out zmin, out zmax);
	         
 		xRange = (xmax - xmin);
        dx = xRange / xResolution;
 		zRange = (zmax - zmin);
        dz = zRange / zResolution;
        Complex cplxTemp;
        	
        if (IsComplex) 
        {   cplxTemp = cplxF(Function3D, xmin, zmin);
        	ymin = cplx2double(cplxTemp, CplxResultType);
        }
        else {ymin = F(Function3D, xmin, zmin);}
        
        	ymax = ymin;
            for (int ix = 0; ix < xResolution; ix++)
            {
                double x = xmin + ix * dx;
                xvalues[ix] = x;
                for (int iz = 0; iz < zResolution; iz++)
                {
                    double z = zmin + iz * dz;
                    if (ix == 0) zvalues[iz] = z;
                    {	
                    	double temp;
                    	if (IsComplex) 
				        {   cplxTemp = cplxF(Function3D, x, z);
				        	temp = cplx2double(cplxTemp, CplxResultType);
				        	y2values[ix, iz] = cplx2double(cplxTemp, 3);
				        	
				        }
        				else 
        				{
        					temp = F(Function3D, x, z);
        				}
						if (ymax < temp) ymax = temp;
                    	if (ymin > temp) ymin = temp;
                    	yvalues[ix, iz] = temp;
                    }
                }
            }
            double xFactor = 1/xRange;
            double zFactor = 1/zRange;
            double yFactor = 1/(ymax - ymin);
            double ymean = (ymin + ymax) / 2;
            for (int ix = 0; ix < xResolution; ix++)
            {
            	xvalues[ix] = xvalues[ix] * xFactor;
                for (int iz = 0; iz < zResolution; iz++)
                {
                	if (ix == 0) zvalues[iz] = zvalues[iz] * zFactor;
                	yvalues[ix, iz] = (yvalues[ix, iz] - ymean) * yFactor;
                }
            }
            
            ymin_out = ymin;
            ymax_out = ymax;


            ymin = (ymin - ymean) * yFactor;
            ymax = (ymax - ymean) * yFactor;
            
            ScaledXmin= xmin * xFactor;
			ScaledZmin= zmin * zFactor;

			
			
			if ((RenderStyle == "ALTITUDEMAP") || (RenderStyle == "ALTITUDEMAP2") || (RenderStyle == "ARGUMENTMAP"))
			{
	            BitmapPixelMaker bm_maker = new BitmapPixelMaker(xResolution, zResolution);
	            for (int ix = 0; ix < xResolution; ix++)
	            {
	                for (int iz = 0; iz < zResolution; iz++)
	                {
	                    byte red, green, blue;
	                    if (RenderStyle == "ARGUMENTMAP")
	                    {
	                    	MapColorWheel(y2values[ix, iz], -3.14159, 3.14159, out red, out green, out blue);
	                    }
	                    else
	                    {
	                    	MapRainbowColor(yvalues[ix, iz], ymin, ymax, out red, out green, out blue);
	                    }
	                    bm_maker.SetPixel(ix, iz, red, green, blue, 255);
	                }
	            }
				WriteableBitmap wbitmap = bm_maker.MakeBitmap(96, 96);
				MyBitmapImage = ConvertWriteableBitmapToBitmapImage(wbitmap);
//				String PngPath = RootDir32() +  @"Projects\WPF3DSurfaceDLL\WpfInWinForms\bin\Release\" + "FName" + ".png";
//	            wbitmap.Save(PngPath);
			}
       }
		
        
		public BitmapImage ConvertWriteableBitmapToBitmapImage(WriteableBitmap wbm)
		{
		    BitmapImage bmImage = new BitmapImage();
		    using (MemoryStream stream = new MemoryStream())
		    {
		        PngBitmapEncoder encoder = new PngBitmapEncoder();
		        encoder.Frames.Add(BitmapFrame.Create(wbm));
		        encoder.Save(stream);
		        bmImage.BeginInit();
		        bmImage.CacheOption = BitmapCacheOption.OnLoad;
		        bmImage.StreamSource = stream;
		        bmImage.EndInit();
		        bmImage.Freeze();
		    }
		    return bmImage;
		}        
		

        // Map a value to a rainbow color.
        private void MapRainbowColor(double value, double min_value, double max_value,
            out byte red, out byte green, out byte blue)
        {
            // Convert into a value between 0 and 1023.
            int int_value = (int)(1023 * (value - min_value) / (max_value - min_value));
			if (RenderStyle == "ALTITUDEMAP")
			{
			            int_value = Math.Abs(int_value - 1023);
			}
            // Map different color bands.
            if (int_value < 256)
            {
                // Red to yellow. (255, 0, 0) to (255, 255, 0).
                red = 255;
                green = (byte)int_value;
                blue = 0;
            }
            else if (int_value < 512)
            {
                // Yellow to green. (255, 255, 0) to (0, 255, 0).
                int_value -= 256;
                red = (byte)(255 - int_value);
                green = 255;
                blue = 0;
            }
            else if (int_value < 768)
            {
                // Green to aqua. (0, 255, 0) to (0, 255, 255).
                int_value -= 512;
                red = 0;
                green = 255;
                blue = (byte)int_value;
            }
            else
            {
                // Aqua to blue. (0, 255, 255) to (0, 0, 255).
                int_value -= 768;
                red = 0;
                green = (byte)(255 - int_value);
                blue = 255;
            }
        }

        
        // Map a value to a rainbow color.
        private void MapColorWheel(double value, double min_value, double max_value,
            out byte red, out byte green, out byte blue)
        {
            // Convert into a value between 0 and 1023.
            int int_value = (int)((1023 + 512) * (value - min_value) / (max_value - min_value));
            int_value = Math.Abs(int_value - (1023 + 512));

            // Map different color bands.
            if (int_value < 256)
            {
                // Red to yellow. (255, 0, 0) to (255, 255, 0).
                red = 255;
                green = (byte)int_value;
                blue = 0;
            }
            else if (int_value < 512)
            {
                // Yellow to green. (255, 255, 0) to (0, 255, 0).
                int_value -= 256;
                red = (byte)(255 - int_value);
                green = 255;
                blue = 0;
            }
            else if (int_value < 768)
            {
                // Green to aqua. (0, 255, 0) to (0, 255, 255).
                int_value -= 512;
                red = 0;
                green = 255;
                blue = (byte)int_value;
            }
            else if (int_value < 1024)
            {
                // Aqua to blue. (0, 255, 255) to (0, 0, 255).
                int_value -= 768;
                red = 0;
                green = (byte)(255 - int_value);
                blue = 255;
            }
            else if (int_value < 1280)
            {
                // Blue  to violet. (0, 0, 255) to (255, 0, 255).
                int_value -= 1024;
                red = (byte)int_value;
                green = 0;
                blue = 255;
            }
            else
            {
                // Blue  to violet. (255, 0, 255) to (255, 0, 0).
                int_value -= 1280;
                red = 255;
                green = 0;
                blue = (byte)(255 - int_value);
            }
        }
        
        
		
		
		
		
	}
}
