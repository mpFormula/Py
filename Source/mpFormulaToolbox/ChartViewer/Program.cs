/*
 * Created by SharpDevelop.
 * User: dhadler
 * Date: 07/05/2014
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace ChartViewer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			if (Environment.OSVersion.Version.Major >= 6) {
				SetProcessDPIAware();
			}
			
			
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ChartPaneForm("a"));
		}
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
		
	}
}
