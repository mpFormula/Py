/*
 * Created by SharpDevelop.
 * User: hadldi00
 * Date: 29/05/2015
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace StartNumExp
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
