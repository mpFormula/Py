namespace ChartViewer
{
  partial class ChartPaneForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
    	this.components = new System.ComponentModel.Container();
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartPaneForm));
    	System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
    	System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
    	System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
    	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
    	this.showXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
    	this.previewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
    	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
    	this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
    	this.copyAsBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.copyAsEMFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
    	this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.showToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
    	this.toolStripButtonShowXML = new System.Windows.Forms.ToolStripButton();
    	this.toolStripButtonPrintPreview = new System.Windows.Forms.ToolStripButton();
    	this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
    	this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
    	this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
    	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
    	this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
    	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
    	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
    	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
    	this.contextMenuStrip1.SuspendLayout();
    	this.toolStrip1.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
    	this.splitContainer1.Panel1.SuspendLayout();
    	this.splitContainer1.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
    	this.menuStrip1.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// contextMenuStrip1
    	// 
    	this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.showXMLToolStripMenuItem,
    	    	    	this.toolStripSeparator5,
    	    	    	this.previewToolStripMenuItem1,
    	    	    	this.toolStripSeparator1,
    	    	    	this.fileToolStripMenuItem,
    	    	    	this.toolStripSeparator2,
    	    	    	this.copyAsBitmapToolStripMenuItem,
    	    	    	this.copyAsEMFToolStripMenuItem,
    	    	    	this.toolStripSeparator3,
    	    	    	this.propertiesToolStripMenuItem,
    	    	    	this.showToolbarToolStripMenuItem});
    	this.contextMenuStrip1.Name = "contextMenuStrip1";
    	this.contextMenuStrip1.Size = new System.Drawing.Size(160, 182);
    	// 
    	// showXMLToolStripMenuItem
    	// 
    	this.showXMLToolStripMenuItem.CheckOnClick = true;
    	this.showXMLToolStripMenuItem.Name = "showXMLToolStripMenuItem";
    	this.showXMLToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.showXMLToolStripMenuItem.Text = "Show XML";
    	this.showXMLToolStripMenuItem.Click += new System.EventHandler(this.showXMLToolStripMenuItem_Click);
    	// 
    	// toolStripSeparator5
    	// 
    	this.toolStripSeparator5.Name = "toolStripSeparator5";
    	this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
    	// 
    	// previewToolStripMenuItem1
    	// 
    	this.previewToolStripMenuItem1.Name = "previewToolStripMenuItem1";
    	this.previewToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
    	this.previewToolStripMenuItem1.Text = "Preview";
    	this.previewToolStripMenuItem1.Click += new System.EventHandler(this.previewToolStripMenuItem_Click_1);
    	// 
    	// toolStripSeparator1
    	// 
    	this.toolStripSeparator1.Name = "toolStripSeparator1";
    	this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
    	// 
    	// fileToolStripMenuItem
    	// 
    	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.saveToolStripMenuItem,
    	    	    	this.saveAsToolStripMenuItem,
    	    	    	this.exportToolStripMenuItem,
    	    	    	this.toolStripSeparator4,
    	    	    	this.previewToolStripMenuItem,
    	    	    	this.pageSetupToolStripMenuItem,
    	    	    	this.printToolStripMenuItem});
    	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
    	this.fileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.fileToolStripMenuItem.Text = "File";
    	// 
    	// saveToolStripMenuItem
    	// 
    	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
    	this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
    	this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.saveToolStripMenuItem.Text = "Save";
    	// 
    	// saveAsToolStripMenuItem
    	// 
    	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
    	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.saveAsToolStripMenuItem.Text = "Save As";
    	// 
    	// exportToolStripMenuItem
    	// 
    	this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
    	this.exportToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.exportToolStripMenuItem.Text = "Export";
    	this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
    	// 
    	// toolStripSeparator4
    	// 
    	this.toolStripSeparator4.Name = "toolStripSeparator4";
    	this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
    	// 
    	// previewToolStripMenuItem
    	// 
    	this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
    	this.previewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.previewToolStripMenuItem.Text = "Preview";
    	this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click_1);
    	// 
    	// pageSetupToolStripMenuItem
    	// 
    	this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
    	this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.pageSetupToolStripMenuItem.Text = "Page Setup";
    	this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click_1);
    	// 
    	// printToolStripMenuItem
    	// 
    	this.printToolStripMenuItem.Name = "printToolStripMenuItem";
    	this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
    	this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
    	this.printToolStripMenuItem.Text = "Print";
    	this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click_1);
    	// 
    	// toolStripSeparator2
    	// 
    	this.toolStripSeparator2.Name = "toolStripSeparator2";
    	this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
    	// 
    	// copyAsBitmapToolStripMenuItem
    	// 
    	this.copyAsBitmapToolStripMenuItem.Name = "copyAsBitmapToolStripMenuItem";
    	this.copyAsBitmapToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.copyAsBitmapToolStripMenuItem.Text = "Copy As Bitmap";
    	this.copyAsBitmapToolStripMenuItem.Click += new System.EventHandler(this.copyAsBitmapToolStripMenuItem_Click);
    	// 
    	// copyAsEMFToolStripMenuItem
    	// 
    	this.copyAsEMFToolStripMenuItem.Name = "copyAsEMFToolStripMenuItem";
    	this.copyAsEMFToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.copyAsEMFToolStripMenuItem.Text = "Copy As EMF";
    	this.copyAsEMFToolStripMenuItem.Click += new System.EventHandler(this.copyAsEMFToolStripMenuItem_Click);
    	// 
    	// toolStripSeparator3
    	// 
    	this.toolStripSeparator3.Name = "toolStripSeparator3";
    	this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
    	// 
    	// propertiesToolStripMenuItem
    	// 
    	this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
    	this.propertiesToolStripMenuItem.ShortcutKeyDisplayString = "F4";
    	this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.propertiesToolStripMenuItem.Text = "Properties";
    	// 
    	// showToolbarToolStripMenuItem
    	// 
    	this.showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
    	this.showToolbarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
    	this.showToolbarToolStripMenuItem.Text = "Show Toolbar";
    	this.showToolbarToolStripMenuItem.Click += new System.EventHandler(this.showToolbarToolStripMenuItem_Click);
    	// 
    	// toolStrip1
    	// 
    	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.toolStripButtonShowXML,
    	    	    	this.toolStripButtonPrintPreview,
    	    	    	this.toolStripButton3,
    	    	    	this.toolStripButton4,
    	    	    	this.toolStripButton5});
    	this.toolStrip1.Location = new System.Drawing.Point(0, 24);
    	this.toolStrip1.Name = "toolStrip1";
    	this.toolStrip1.Size = new System.Drawing.Size(639, 25);
    	this.toolStrip1.TabIndex = 1;
    	this.toolStrip1.Text = "toolStrip1";
    	// 
    	// toolStripButtonShowXML
    	// 
    	this.toolStripButtonShowXML.CheckOnClick = true;
    	this.toolStripButtonShowXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonShowXML.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonShowXML.Name = "toolStripButtonShowXML";
    	this.toolStripButtonShowXML.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonShowXML.Text = "toolStripButton1";
    	this.toolStripButtonShowXML.ToolTipText = "Show XML";
    	this.toolStripButtonShowXML.Click += new System.EventHandler(this.toolStripButtonShowXML_Click);
    	// 
    	// toolStripButtonPrintPreview
    	// 
    	this.toolStripButtonPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonPrintPreview.Name = "toolStripButtonPrintPreview";
    	this.toolStripButtonPrintPreview.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonPrintPreview.Text = "toolStripButton2";
    	this.toolStripButtonPrintPreview.ToolTipText = "Print Preview";
    	this.toolStripButtonPrintPreview.Click += new System.EventHandler(this.toolStripButtonPrintPreview_Click);
    	// 
    	// toolStripButton3
    	// 
    	this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
    	this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButton3.Name = "toolStripButton3";
    	this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButton3.Text = "toolStripButton3";
    	// 
    	// toolStripButton4
    	// 
    	this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
    	this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButton4.Name = "toolStripButton4";
    	this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButton4.Text = "toolStripButton4";
    	// 
    	// toolStripButton5
    	// 
    	this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
    	this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButton5.Name = "toolStripButton5";
    	this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButton5.Text = "toolStripButton5";
    	// 
    	// splitContainer1
    	// 
    	this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.splitContainer1.Location = new System.Drawing.Point(0, 49);
    	this.splitContainer1.Name = "splitContainer1";
    	this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
    	// 
    	// splitContainer1.Panel1
    	// 
    	this.splitContainer1.Panel1.Controls.Add(this.chart1);
    	this.splitContainer1.Panel2Collapsed = true;
    	this.splitContainer1.Size = new System.Drawing.Size(639, 534);
    	this.splitContainer1.SplitterDistance = 288;
    	this.splitContainer1.TabIndex = 2;
    	// 
    	// chart1
    	// 
    	chartArea1.Name = "ChartArea1";
    	this.chart1.ChartAreas.Add(chartArea1);
    	this.chart1.ContextMenuStrip = this.contextMenuStrip1;
    	this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
    	legend1.Name = "Legend1";
    	this.chart1.Legends.Add(legend1);
    	this.chart1.Location = new System.Drawing.Point(0, 0);
    	this.chart1.Name = "chart1";
    	this.chart1.Padding = new System.Windows.Forms.Padding(0, 28, 0, 0);
    	this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
    	series1.ChartArea = "ChartArea1";
    	series1.Legend = "Legend1";
    	series1.Name = "Series1";
    	this.chart1.Series.Add(series1);
    	this.chart1.Size = new System.Drawing.Size(635, 530);
    	this.chart1.TabIndex = 0;
    	this.chart1.Text = "chart1";
    	// 
    	// menuStrip1
    	// 
    	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.fileToolStripMenuItem1,
    	    	    	this.helpToolStripMenuItem});
    	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
    	this.menuStrip1.Name = "menuStrip1";
    	this.menuStrip1.Size = new System.Drawing.Size(639, 24);
    	this.menuStrip1.TabIndex = 3;
    	this.menuStrip1.Text = "menuStrip1";
    	// 
    	// fileToolStripMenuItem1
    	// 
    	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.openToolStripMenuItem});
    	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
    	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
    	this.fileToolStripMenuItem1.Text = "File";
    	// 
    	// openToolStripMenuItem
    	// 
    	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
    	this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.openToolStripMenuItem.Text = "Open";
    	this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
    	// 
    	// helpToolStripMenuItem
    	// 
    	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
    	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
    	this.helpToolStripMenuItem.Text = "Help";
    	// 
    	// openFileDialog1
    	// 
    	this.openFileDialog1.FileName = "openFileDialog1";
    	// 
    	// ChartPaneForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(639, 583);
    	this.Controls.Add(this.splitContainer1);
    	this.Controls.Add(this.toolStrip1);
    	this.Controls.Add(this.menuStrip1);
    	this.MainMenuStrip = this.menuStrip1;
    	this.Name = "ChartPaneForm";
    	this.Text = "ChartPaneForm";
    	this.Load += new System.EventHandler(this.ChartPaneForm_Load);
    	this.contextMenuStrip1.ResumeLayout(false);
    	this.toolStrip1.ResumeLayout(false);
    	this.toolStrip1.PerformLayout();
    	this.splitContainer1.Panel1.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
    	this.splitContainer1.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
    	this.menuStrip1.ResumeLayout(false);
    	this.menuStrip1.PerformLayout();
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem copyAsBitmapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyAsEMFToolStripMenuItem;
    //private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    private System.Windows.Forms.ToolStripMenuItem showXMLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showToolbarToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonShowXML;
    private System.Windows.Forms.ToolStripButton toolStripButtonPrintPreview;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
  }
}