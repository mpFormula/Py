
using System.IO;
using System.Windows.Media.Imaging;

namespace WpfInWinForms
{
    public static class WriteableBitmapExtentions
    {
        // Save the WriteableBitmap into a PNG file.
        public static void Save(this WriteableBitmap wbitmap, string filename)
        {
            // Save the bitmap into a file.
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(wbitmap));
                encoder.Save(stream);
            }
        }
    }
}
