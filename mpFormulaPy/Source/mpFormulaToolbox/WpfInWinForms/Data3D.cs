
using System;
using System.IO;
using System.Numerics;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace WpfInWinForms
{
	public class Data3D
	{
		public double[,] yvalues = null; 
		public double[,] y2values = null; 
		public double[,] xvalues = null; 
		public double[,] zvalues = null; 
		public BitmapImage MyBitmapImage = null;
        public int xResolution = 0;
        public int zResolution = 0;
        public double ScaledXmin = 0;
		public double ScaledZmin = 0;
		
		private double xmin = 0;
	    private double xmax = 0;
	    private double zmin = 0;
	    private double zmax = 0;
	    private double ytruncate = 0;

		
		
		private String RenderStyle = "";
		private Boolean IsComplex = false;
		private Boolean IsParametric = false;
		private int CplxResultType = 0;



		
		
		public Data3D(String Function3D, int xResolution2, int zResolution2, String NewRenderStyle, int NewCplxResultType, 
		              double xmin1, double xmax1, double zmin1, double zmax1, double ytruncate1, out double ymin, out double ymax)
		{
			RenderStyle = NewRenderStyle;
			CplxResultType = NewCplxResultType;
			xResolution = xResolution2;
			zResolution = zResolution2;
			xmin = xmin1; xmax = xmax1; zmin = zmin1; zmax = zmax1; ytruncate = ytruncate1;
			yvalues = new double[xResolution+1, zResolution+1];
			y2values = new double[xResolution+1, zResolution+1];
			xvalues = new double[xResolution+1, zResolution+1];
			zvalues = new double[xResolution+1, zResolution+1];
			CreateMap(Function3D, out ymin, out ymax);
		}

		
		private Complex cplxAsinh(Complex x)
		{
		    return Complex.Log(x + Complex.Sqrt(1 + (x * x)));
		}

		
		private Complex cplxAcosh(Complex x)
		{
		    return Complex.Log(x + Complex.Sqrt(x + 1) * Complex.Sqrt(x - 1));
		}



		private Complex cplxAtanh(Complex x)
		{
		    return (Complex.Log(1 + x) - Complex.Log(1 - x)) / 2;
		}
		
		private double Square(double x)
		{
		    return x * x;
		}
		    
		
		private Point3D ParametricF(String Function3D, double u, double v)
		{
		    double x = 0.0;
		    double y = 0;
		    double z = 0;
		    
		    if (Function3D == "_PARAMETRIC_HELICOID") 
		    {
                x = u * Math.Cos(v);
                z = u * Math.Sin(v);
                y = v;		        
		    }
		    if (Function3D == "_PARAMETRIC_SPHERE") 
		    {
                x = Math.Cos(v)* Math.Cos(u);
                z = Math.Cos(v)* Math.Sin(u);
                y = Math.Sin(v);		        
		    }
		    if (Function3D == "_PARAMETRIC_TORUS") 
		    {
                x = (1 + 0.3 * Math.Cos(v)) * Math.Cos(u);
                z = (1 + 0.3 * Math.Cos(v)) * Math.Sin(u);
                y = 0.3 * Math.Sin(v);		        
		    }

		    
		    
		    if (Function3D == "_PARAMETRIC_SEASHELL") 
		    {
		        double a = Math.Exp(u / (6.0 * Math.PI));
		        double b = Math.Cos(v / 2.0);
		        
                x = 2.0 * (1.0 - a) * Math.Cos(u) * b * b;
                z = 2.0 * (-1.0 + a) * Math.Sin(u) * b * b;
                y = 1.0 - a * a - Math.Sin(v) * (1.0 - a);

		    }

		    
		    
//		    http://en.wikipedia.org/wiki/M%C3%B6bius_strip
		    
		    if (Function3D == "_PARAMETRIC_MOEBIUS") 
		    {
		        x = (1 + (v/2) * Math.Cos(u/2)) * Math.Cos(u);
                z = (1 + (v/2) * Math.Cos(u/2)) * Math.Sin(u);
                y = (v/2) * Math.Sin(u/2);		        
		    }
		    
		    
//          http://en.wikipedia.org/wiki/Klein_bottle		    
		    
		    if (Function3D == "_PARAMETRIC_KLEINBAGEL") 
		    {
		        double r = 2.1;
		        x = (r + Math.Cos(u/2) * Math.Sin(v) - Math.Sin(u/2) * Math.Sin(2*v)) * Math.Cos(u);
                z = (r + Math.Cos(u/2) * Math.Sin(v) - Math.Sin(u/2) * Math.Sin(2*v)) * Math.Sin(u);
                y =  Math.Sin(u/2) * Math.Sin(v) + Math.Cos(u/2) * Math.Sin(2*v);		        
		    }

		    
//          http://www.mapleprimes.com/maplesoftblog/95570-Klein-Bottle-Plot
//          http://www.chebfun.org/examples/geom/ParametricSurfaces.html

		    if (Function3D == "_PARAMETRIC_KLEINBOTTEL") 
		    {
		        double a = Math.Cos(u);
		        double b = Math.Sin(u);
		        double c = Math.Cos(v);
		        double a2 = a * a;
		        double a4 = a2 * a2;
                
                x = -(2.0/15.0) * a * (3*c + b*(-30 + a4*(90 - 60*a2) + 5*a*c));
                z = -(1.0/15.0) * b*b * (c*b* (3 - 48*a4  + 5*a*b*(1 - 16*a4)) - 60);
                y = (2.0/15.0) * (3 + 5*a*b) * Math.Sin(v);
		    }

		    if (Function3D == "_PARAMETRIC_KUEN")
		    {
		        double a = 1.0 * Math.Sin(v);
		        double b = 1.0 + u * u * a * a;

		        x = 2.0 * a * (Math.Cos(u) + u * Math.Sin(u)) / b;
                z = 2.0 * a * (Math.Sin(u) - u * Math.Cos(u)) / b;
                y = Math.Log(Math.Tan(v/2.0)) + 2.0 * Math.Cos(v) / b;
		    }
		    return new Point3D(x, y, z);
		}

		    
		

		
		private Complex cplxF(String Function3D, double x, double z)
		{
			Complex cplxResult = new Complex(0.0, 0.0);
			Complex c1 = new Complex(x, z);
			Complex c2 = Complex.Reciprocal(c1);
			
			if (Function3D == "_COMPLEX_LOG") cplxResult = Complex.Log(c1);
			if (Function3D == "_COMPLEX_EXP") cplxResult = Complex.Exp(c1);
			if (Function3D == "_COMPLEX_SQRT") cplxResult = Complex.Sqrt(c1); 
			if (Function3D == "_COMPLEX_SQUARE") cplxResult = c1 * c1; 
			if (Function3D == "_COMPLEX_CUBE") cplxResult = c1 * c1 * c1; 

			
			if (Function3D == "_COMPLEX_SIN") cplxResult = Complex.Sin(c1);
			if (Function3D == "_COMPLEX_COS") cplxResult = Complex.Cos(c1);
			if (Function3D == "_COMPLEX_TAN") cplxResult = Complex.Tan(c1);
			
			if (Function3D == "_COMPLEX_ASIN") cplxResult = Complex.Asin(c1);
			if (Function3D == "_COMPLEX_ACOS") cplxResult = Complex.Acos(c1);
			if (Function3D == "_COMPLEX_ATAN") cplxResult = Complex.Atan(c1);  
			

			if (Function3D == "_COMPLEX_CSC") cplxResult = 1.0 / Complex.Sin(c1);
			if (Function3D == "_COMPLEX_SEC") cplxResult = 1.0 / Complex.Cos(c1);
			if (Function3D == "_COMPLEX_COT") cplxResult = 1.0 / Complex.Tan(c1);

			if (Function3D == "_COMPLEX_ACSC") cplxResult = Complex.Asin(c2);
			if (Function3D == "_COMPLEX_ASEC") cplxResult = Complex.Acos(c2);
			if (Function3D == "_COMPLEX_ACOT") cplxResult = Complex.Atan(c2);
			
			
			if (Function3D == "_COMPLEX_SINH") cplxResult = Complex.Sinh(c1);
			if (Function3D == "_COMPLEX_COSH") cplxResult = Complex.Cosh(c1);
			if (Function3D == "_COMPLEX_TANH") cplxResult = Complex.Tanh(c1);
						
			if (Function3D == "_COMPLEX_ASINH") cplxResult = cplxAsinh(c1);
			if (Function3D == "_COMPLEX_ACOSH") cplxResult = cplxAcosh(c1);
			if (Function3D == "_COMPLEX_ATANH") cplxResult = cplxAtanh(c1);

			
			if (Function3D == "_COMPLEX_CSCH") cplxResult = 1.0 / Complex.Sinh(c1);
			if (Function3D == "_COMPLEX_SECH") cplxResult = 1.0 / Complex.Cosh(c1);
			if (Function3D == "_COMPLEX_COTH") cplxResult = 1.0 / Complex.Tanh(c1);
			
			if (Function3D == "_COMPLEX_ACSCH") cplxResult = cplxAsinh(c2);
			if (Function3D == "_COMPLEX_ASECH") cplxResult = cplxAcosh(c2);
			if (Function3D == "_COMPLEX_ACOTH") cplxResult = cplxAtanh(c2);
			
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
			if (Math.Abs(Result) > ytruncate) {Result = ytruncate* Math.Sign(Result);}
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
				const double two_pi = 2 * Math.PI;
				double r2 = x * x + z * z;
				double r = Math.Sqrt(r2);
				double theta = Math.Atan2(z, x);
				result = Math.Exp(-r2) * Math.Sin(two_pi * r) * Math.Cos(3 * theta);
	         }

	         if (Function3D == "BIVARIATENORMAL")
	         {
				const double two_pi = 2 * Math.PI;
				double rho = -0.5;
				double r2 = 1.0 - rho*rho;
				double f = 1 / (two_pi * Math.Sqrt(r2));
				double e = -(x*x - 2*rho*x*z + z*z)/(2*r2);
				result = f * Math.Exp(e);
	         }
	         return result;
        }

        

        private void CreateMap(String Function3D, out double ymin_out, out double ymax_out)
        {
        	
	         double dx = 0;
	         double dz = 0;
	
	         double xRange = 0;
	         double zRange = 0;
	        
	        
			 double ymin = 0;
	         double ymax = 0;

             
            if  (Function3D.StartsWith("_COMPLEX")) 	IsComplex = true;
            if  (Function3D.StartsWith("_PARAMETRIC")) 	IsParametric = true;
	             
	         
 		xRange = (xmax - xmin);
        dx = xRange / xResolution;
 		zRange = (zmax - zmin);
        dz = zRange / zResolution;
        Complex cplxTemp;


        double xminP = 0.0, yminP = 0.0, zminP = 0.0, xmaxP = 0.0, ymaxP = 0.0, zmaxP = 0.0;

        Point3D ParamTemp;
        	
        if (IsComplex) 
        {   cplxTemp = cplxF(Function3D, xmin, zmin);
        	ymin = cplx2double(cplxTemp, CplxResultType);
        }
        else if (IsParametric) 
        {   ParamTemp = ParametricF(Function3D, xmin, zmin);
        	xminP = ParamTemp.X;
        	yminP = ParamTemp.Y;
        	zminP = ParamTemp.Z;
        	xmaxP = xminP;
        	ymaxP = yminP;
        	zmaxP = zminP;
        }

        else {ymin = F(Function3D, xmin, zmin);}
        
        	ymax = ymin;
            for (int ix = 0; ix < xResolution+1; ix++)
            {
                
                double x = xmin + ix * dx;
                for (int iz = 0; iz < zResolution+1; iz++)
                {
                    double z = zmin + iz * dz;
                    double temp = 0, temp2 = 0;
                    if (IsParametric) 
                    {
                        double u = x;
                        double v = z;
                        ParamTemp = ParametricF(Function3D, u, v);
                        temp = ParamTemp.X;
    					if (xmaxP < temp) xmaxP = temp;
                    	if (xminP > temp) xminP = temp;
                        xvalues[ix, iz] = temp;

                        temp = ParamTemp.Z;
    					if (zmaxP < temp) zmaxP = temp;
                    	if (zminP > temp) zminP = temp;
                        zvalues[ix, iz] = temp;

                        temp = ParamTemp.Y;
                    }
                    else
                    {
                        xvalues[ix, iz] = x;
                        zvalues[ix, iz] = z;
                    	
                    	if (IsComplex) 
    			        {   cplxTemp = cplxF(Function3D, x, z);
    			        	temp = cplx2double(cplxTemp, CplxResultType);
    			        	y2values[ix, iz] = cplx2double(cplxTemp, 4);
    			        	if ((CplxResultType==0) || (CplxResultType==1) || (CplxResultType==2) )
    			        	{
    			        	    if (CplxResultType==0) temp2 = cplx2double(cplxTemp, 1); else temp2 = cplx2double(cplxTemp, 0);
    			        	    if (ymax < temp2) ymax = temp2;
                    	        if (ymin > temp2) ymin = temp2;
    			        	}
    	        		}
        				else 
        				{
        					temp = F(Function3D, x, z);
        				}
                    }
					if (ymax < temp) ymax = temp;
                	if (ymin > temp) ymin = temp;
                	yvalues[ix, iz] = temp;


                }
            }

            if (IsParametric) 
            {
                xmin = xminP;
                xmax = xmaxP;
                xRange = (xmax - xmin);

                zmin = zminP;
                zmax = zmaxP;
                zRange = (zmax - zmin);
            }

            
            
            
            double xFactor = 1/xRange;
            double zFactor = 1/zRange;
            double yFactor = 1/(ymax - ymin);
            double xmean = (xmin + xmax) / 2;
            double zmean = (zmin + zmax) / 2;
            double ymean = (ymin + ymax) / 2;
            for (int ix = 0; ix < xResolution+1; ix++)
            {
                for (int iz = 0; iz < zResolution+1; iz++)
                {
                    xvalues[ix, iz] = (xvalues[ix, iz] - xmean) * xFactor;
                	zvalues[ix, iz] = (zvalues[ix, iz] - zmean) * zFactor;
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
//	                    bm_maker.SetPixel(ix, iz, red, green, blue, 55);
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
