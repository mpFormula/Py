
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfInWinForms
{
    // A class to represent WriteableBitmap pixels in Bgra32 format.
    public class BitmapPixelMaker
    {
        // The bitmap's size.
        private int Width, Height;

        // The pixel array.
        private byte[] Pixels;

        // The number of bytes per row.
        private int Stride;

        // Constructor. Width and height required.
        public BitmapPixelMaker(int width, int height)
        {
            // Save the width and height.
            Width = width;
            Height = height;

            // Create the pixel array.
            Pixels = new byte[width * height * 4];

            // Calculate the stride.
            Stride = width * 4;
        }

        // Get a pixel's value.
        public void GetPixel(int x, int y, out byte red, out byte green, out byte blue, out byte alpha)
        {
            int index = y * Stride + x * 4;
            blue = Pixels[index++];
            green = Pixels[index++];
            red = Pixels[index++];
            alpha = Pixels[index];
        }
        public byte GetBlue(int x, int y)
        {
            return Pixels[y * Stride + x * 4];
        }
        public byte GetGreen(int x, int y)
        {
            return Pixels[y * Stride + x * 4 + 1];
        }
        public byte GetRed(int x, int y)
        {
            return Pixels[y * Stride + x * 4 + 2];
        }
        public byte GetAlpha(int x, int y)
        {
            return Pixels[y * Stride + x * 4 + 3];
        }

        // Set a pixel's value.
        public void SetPixel(int x, int y, byte red, byte green, byte blue, byte alpha)
        {
            int index = y * Stride + x * 4;
            Pixels[index++] = blue;
            Pixels[index++] = green;
            Pixels[index++] = red;
            Pixels[index++] = alpha;
        }
        public void SetBlue(int x, int y, byte blue)
        {
            Pixels[y * Stride + x * 4] = blue;
        }
        public void SetGreen(int x, int y, byte green)
        {
            Pixels[y * Stride + x * 4 + 1] = green;
        }
        public void SetRed(int x, int y, byte red)
        {
            Pixels[y * Stride + x * 4 + 2] = red;
        }
        public void SetAlpha(int x, int y, byte alpha)
        {
            Pixels[y * Stride + x * 4 + 3] = alpha;
        }

        // Set all pixels to a specific color.
        public void SetColor(byte red, byte green, byte blue, byte alpha)
        {
            int num_bytes = Width * Height * 4;
            int index = 0;
            while (index < num_bytes)
            {
                Pixels[index++] = blue;
                Pixels[index++] = green;
                Pixels[index++] = red;
                Pixels[index++] = alpha;
            }
        }

        // Set all pixels to a specific opaque color.
        public void SetColor(byte red, byte green, byte blue)
        {
            SetColor(red, green, blue, 255);
        }

        // Use the pixel data to create a WriteableBitmap.
        public WriteableBitmap MakeBitmap(double dpiX, double dpiY)
        {
            // Create the WriteableBitmap.
            WriteableBitmap wbitmap = new WriteableBitmap(
                Width, Height, dpiX, dpiY,
                PixelFormats.Bgra32, null);

            // Load the pixel data.
            Int32Rect rect = new Int32Rect(0, 0, Width, Height);
            wbitmap.WritePixels(rect, Pixels, Stride, 0);

            // Return the bitmap.
            return wbitmap;
        }
        
        
        
        
        
        
    }
}
