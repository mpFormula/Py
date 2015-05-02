
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace TestAcro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		AxAcroPDFLib.AxAcroPDF axAcroPdf;
		private clsWindowMessaging mWindowMessagingClass;
		


		private void MainForm_Load(object sender, System.EventArgs e)
		{
//	      string PDFHELPVIEWER_WINDOWTITLE = "PDFHelpViewerMessageHandler0001";
//	      mWindowMessagingClass = new clsWindowMessaging(this, PDFHELPVIEWER_WINDOWTITLE);
		}


		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.mWindowMessagingClass.Dispose();
		}
		
		
	    public void UpdateDocument(String s)
	    {
	      if (s == "@CLOSEPDFVIEWER@")
	      {
	        Application.Exit();
	      }
	      else
	      {
//	        label1.Text = s;
	        axAcroPdf.setNamedDest(s);
	      }
	    }
		
	    

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

	    
//		public MainForm()
    	public MainForm(string[] args)			
		{
			InitializeComponent();
			string PDFHELPVIEWER_WINDOWTITLE = "PDFHelpViewerMessageHandler0001";
	        mWindowMessagingClass = new clsWindowMessaging(this, PDFHELPVIEWER_WINDOWTITLE);

			String FName = RootDir32() + @"Manual\mpFormula.pdf";
			axAcroPdf = new AxAcroPDFLib.AxAcroPDF();
			((System.ComponentModel.ISupportInitialize)(axAcroPdf)).BeginInit();
			
//			this.Controls.Add(axAcroPdf);
			
			this.toolStripContainer1.ContentPanel.Controls.Add(axAcroPdf);
			axAcroPdf.Dock= DockStyle.Fill;
			((System.ComponentModel.ISupportInitialize)(axAcroPdf)).EndInit();
			
			
		      axAcroPdf.setLayoutMode("SinglePage");
		      axAcroPdf.setPageMode("none");
		      axAcroPdf.setView("fitH");
		      axAcroPdf.LoadFile(FName);
		      if (args.Length > 0) { UpdateDocument(args[0]); }
			
//			axAcroPdf.LoadFile("C:\\test.pdf");
			axAcroPdf.Show();			
//			pdf.setView("Fit");
//			pdf.Visible = true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			
	      openFileDialog1.FileName = "";
	      openFileDialog1.Filter = "Project File (*.pdf)|*.pdf|All files (*.*)|*.*";
	      openFileDialog1.Title = "Open PDF";
	      DialogResult result = openFileDialog1.ShowDialog();
	      if (result == DialogResult.OK) // Test result.
	      {
	        string file = openFileDialog1.FileName;
	        try
	        {
	          axAcroPdf.LoadFile(file);
	          
	        }
	        catch (IOException)
	        {
	        }
	      }
			
			
			
			
		}
	}
}
