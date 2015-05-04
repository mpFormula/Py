/*
 * Created by SharpDevelop.
 * User: DH
 * Date: 10/05/2014
 * Time: 08:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HTMLViewer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
	    void OpenToolStripMenuItemClick(object sender, EventArgs e)
	    {
	      openFileDialog1.FileName = "";
	      openFileDialog1.Filter = "Project File (*.html)|*.html|All files (*.*)|*.*";
	      openFileDialog1.Title = "Open HTML";
	      DialogResult result = openFileDialog1.ShowDialog();
	      if (result == DialogResult.OK) // Test result.
	      {
	        string file = openFileDialog1.FileName;
	        try
	        {
	          webBrowser1.Navigate(@"file:///" +file);
	          
	        }
	        catch (IOException)
	        {
	        }
	      }
	    }
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
//		void OpenToolStripMenuItemClick(object sender, EventArgs e)
//		{
//			
//		}
	}
}
