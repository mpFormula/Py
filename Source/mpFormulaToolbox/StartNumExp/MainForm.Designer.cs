/*
 * Created by SharpDevelop.
 * User: hadldi00
 * Date: 29/05/2015
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StartNumExp
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "MainForm";
            this.Text = "StartNumExp";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
        }
        
        void MainFormLoad(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://duhadler.wordpress.com/");
            System.Windows.Forms.Application.Exit();
            
        }
    }
}
