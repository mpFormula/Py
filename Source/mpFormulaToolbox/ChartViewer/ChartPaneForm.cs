using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace ChartViewer
{

  public partial class ChartPaneForm : Form
  {

//    private CodePaneForm f;

    public ChartPaneForm(String FName)
    {
      InitializeComponent();

//      f = new CodePaneForm("MyText", "XML","1","MyText");
//      f.TopLevel = false;
//      f.MdiParent = null;
//      f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//      f.Dock = DockStyle.Fill;
//      this.splitContainer1.Panel2.Controls.Add(f);
//      f.Show();


//      ChartUpdate(FName);
    }

    public void ChartUpdate(String FName)
    {
      string test = File.ReadAllText(FName);
//      f.CodeText = test;

      // convert string to stream
      byte[] byteArray = Encoding.ASCII.GetBytes(test);

       //GetyBytes method is used to to create a byte array
      MemoryStream stream = new MemoryStream(byteArray);
      this.chart1.Serializer.Load(stream);

      FileName = FName;
      //this.chart1.Serializer.Load(FileName);
    }

    private String FileName = "";

    private void ChartPaneForm_Load(object sender, EventArgs e)
    {

    }

    private void pageSetupToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      chart1.Printing.PageSetup();
    }

    private void previewToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      chart1.Printing.PrintPreview();
    }

    private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      chart1.Printing.Print(true);
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Create a new save file dialog
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();

      // Sets the current file name filter string, which determines 
      // the choices that appear in the "Save as file type" or 
      // "Files of type" box in the dialog box.
      saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
      saveFileDialog1.FilterIndex = 2;
      saveFileDialog1.RestoreDirectory = true;

      // Set image file format
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        ChartImageFormat format = ChartImageFormat.Bmp;

        if (saveFileDialog1.FileName.EndsWith("bmp"))
        {
          format = ChartImageFormat.Bmp;
        }
        else if (saveFileDialog1.FileName.EndsWith("jpg"))
        {
          format = ChartImageFormat.Jpeg;
        }
        else if (saveFileDialog1.FileName.EndsWith("emf"))
        {
          format = ChartImageFormat.EmfDual;
        }
        else if (saveFileDialog1.FileName.EndsWith("gif"))
        {
          format = ChartImageFormat.Gif;
        }
        else if (saveFileDialog1.FileName.EndsWith("png"))
        {
          format = ChartImageFormat.Png;
        }
        else if (saveFileDialog1.FileName.EndsWith("tif"))
        {
          format = ChartImageFormat.Tiff;
        }

        // Save image
        chart1.SaveImage(saveFileDialog1.FileName, format);
      }

    }

    private void copyAsBitmapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // create a memory stream to save the chart image    
      System.IO.MemoryStream stream = new System.IO.MemoryStream();

      // save the chart image to the stream    
      chart1.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp);

      // create a bitmap using the stream    
      Bitmap bmp = new Bitmap(stream);

      // save the bitmap to the clipboard    
      Clipboard.SetDataObject(bmp); 
    }

    private void copyAsEMFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      String FName = FileName+".emf";
      chart1.SaveImage(FName, ChartImageFormat.EmfDual);
      Metafile mf = new Metafile(FName);
      ClipboardMetafileHelper.PutEnhMetafileOnClipboard(this.Handle, mf);
    }

    private void showXMLToolStripMenuItem_Click(object sender, EventArgs e)
    {
      splitContainer1.Panel2Collapsed = !(showXMLToolStripMenuItem.Checked);
    }

    private void showToolbarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //toolStrip1.Visible = true;
    }

    private void chart1_MouseClick(object sender, MouseEventArgs e)
    {
      MessageBox.Show("Click");
      this.Activate();
    }

    private void toolStripButtonShowXML_Click(object sender, EventArgs e)
    {
      splitContainer1.Panel2Collapsed = !(toolStripButtonShowXML.Checked);
    }

    private void toolStripButtonPrintPreview_Click(object sender, EventArgs e)
    {
      chart1.Printing.PrintPreview();
    }

  
 	    void OpenToolStripMenuItemClick(object sender, EventArgs e)
	    {
	      openFileDialog1.FileName = "";
	      openFileDialog1.Filter = "Project File (*.xml)|*.xml|All files (*.*)|*.*";
	      openFileDialog1.Title = "Open XML Chart";
	      DialogResult result = openFileDialog1.ShowDialog();
	      if (result == DialogResult.OK) // Test result.
	      {
	        string file = openFileDialog1.FileName;
	        try
	        {
	          ChartUpdate(file);
	          
	        }
	        catch (IOException)
	        {
	        }
	      }
	    }
		
	
 
  }


  public class ClipboardMetafileHelper
  {
    [DllImport("user32.dll")]
    static extern bool OpenClipboard(IntPtr hWndNewOwner);
    [DllImport("user32.dll")]
    static extern bool EmptyClipboard();
    [DllImport("user32.dll")]
    static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);
    [DllImport("user32.dll")]
    static extern bool CloseClipboard();
    [DllImport("gdi32.dll")]
    static extern IntPtr CopyEnhMetaFile(IntPtr hemfSrc, IntPtr hNULL);
    [DllImport("gdi32.dll")]
    static extern bool DeleteEnhMetaFile(IntPtr hemf);

    // Metafile mf is set to a state that is not valid inside this function.
    static public bool PutEnhMetafileOnClipboard(IntPtr hWnd, Metafile mf)
    {
      bool bResult = false;
      IntPtr hEMF, hEMF2;
      hEMF = mf.GetHenhmetafile(); // invalidates mf
      if (!hEMF.Equals(new IntPtr(0)))
      {
        hEMF2 = CopyEnhMetaFile(hEMF, new IntPtr(0));
        if (!hEMF2.Equals(new IntPtr(0)))
        {
          if (OpenClipboard(hWnd))
          {
            if (EmptyClipboard())
            {
              IntPtr hRes = SetClipboardData(14 /*CF_ENHMETAFILE*/, hEMF2);
              bResult = hRes.Equals(hEMF2);
              CloseClipboard();
            }
          }
        }
        DeleteEnhMetaFile(hEMF);
      }
      return bResult;
    }
  }





}
