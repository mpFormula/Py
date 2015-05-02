namespace WpfInWinForms
{
    partial class FrmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbTrunc = new System.Windows.Forms.TextBox();
            this.lblTrunc = new System.Windows.Forms.Label();
            this.tbSplit = new System.Windows.Forms.TextBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.cbCoordinates = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbZMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbXMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbComplexType = new System.Windows.Forms.ComboBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            this.cbBrush = new System.Windows.Forms.ComboBox();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remove1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printViaGDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBar1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.hScrollBar1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBar2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.hScrollBar2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 653);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1Paint);
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Format = "F";
            chartArea1.AxisX.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.Maximum = 4D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.LabelStyle.Format = "F";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(803, 53);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(211, 144);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.Chart1Click);
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 2);
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(183, 53);
            this.elementHost1.Name = "elementHost1";
            this.tableLayoutPanel1.SetRowSpan(this.elementHost1, 3);
            this.elementHost1.Size = new System.Drawing.Size(594, 444);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(780, 50);
            this.vScrollBar1.Name = "vScrollBar1";
            this.tableLayoutPanel1.SetRowSpan(this.vScrollBar1, 3);
            this.vScrollBar1.Size = new System.Drawing.Size(20, 450);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Value = 60;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1Scroll);
            // 
            // hScrollBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.hScrollBar1, 2);
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBar1.LargeChange = 5;
            this.hScrollBar1.Location = new System.Drawing.Point(180, 500);
            this.hScrollBar1.Maximum = 364;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(600, 20);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.Value = 120;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl1, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(154, 647);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbTrunc);
            this.tabPage1.Controls.Add(this.lblTrunc);
            this.tabPage1.Controls.Add(this.tbSplit);
            this.tabPage1.Controls.Add(this.lblSplit);
            this.tabPage1.Controls.Add(this.cbCoordinates);
            this.tabPage1.Controls.Add(this.btnApply);
            this.tabPage1.Controls.Add(this.tbZMax);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbZMin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbXMax);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbXmin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbComplexType);
            this.tabPage1.Controls.Add(this.cbCamera);
            this.tabPage1.Controls.Add(this.cbResolution);
            this.tabPage1.Controls.Add(this.cbBrush);
            this.tabPage1.Controls.Add(this.cbFunction);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(146, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
            // 
            // tbTrunc
            // 
            this.tbTrunc.Location = new System.Drawing.Point(58, 505);
            this.tbTrunc.Name = "tbTrunc";
            this.tbTrunc.Size = new System.Drawing.Size(69, 20);
            this.tbTrunc.TabIndex = 19;
            this.tbTrunc.Text = "10";
            // 
            // lblTrunc
            // 
            this.lblTrunc.Location = new System.Drawing.Point(3, 505);
            this.lblTrunc.Name = "lblTrunc";
            this.lblTrunc.Size = new System.Drawing.Size(52, 23);
            this.lblTrunc.TabIndex = 18;
            this.lblTrunc.Text = "Truncate";
            // 
            // tbSplit
            // 
            this.tbSplit.Location = new System.Drawing.Point(58, 471);
            this.tbSplit.Name = "tbSplit";
            this.tbSplit.Size = new System.Drawing.Size(69, 20);
            this.tbSplit.TabIndex = 17;
            // 
            // lblSplit
            // 
            this.lblSplit.Location = new System.Drawing.Point(14, 471);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(37, 23);
            this.lblSplit.TabIndex = 16;
            this.lblSplit.Text = "Split";
            // 
            // cbCoordinates
            // 
            this.cbCoordinates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoordinates.FormattingEnabled = true;
            this.cbCoordinates.Items.AddRange(new object[] {
                                    "No Coordinates",
                                    "Cage Only",
                                    "Main Labels Only",
                                    "All Labels"});
            this.cbCoordinates.Location = new System.Drawing.Point(0, 270);
            this.cbCoordinates.Name = "cbCoordinates";
            this.cbCoordinates.Size = new System.Drawing.Size(121, 21);
            this.cbCoordinates.TabIndex = 14;
            this.cbCoordinates.SelectedIndexChanged += new System.EventHandler(this.CbCoordinatesSelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(14, 543);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApplyClick);
            // 
            // tbZMax
            // 
            this.tbZMax.Location = new System.Drawing.Point(58, 435);
            this.tbZMax.Name = "tbZMax";
            this.tbZMax.Size = new System.Drawing.Size(69, 20);
            this.tbZMax.TabIndex = 12;
            this.tbZMax.Text = "10";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "ZMax:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbZMin
            // 
            this.tbZMin.Location = new System.Drawing.Point(58, 399);
            this.tbZMin.Name = "tbZMin";
            this.tbZMin.Size = new System.Drawing.Size(69, 20);
            this.tbZMin.TabIndex = 10;
            this.tbZMin.Text = "-10";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "ZMin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbXMax
            // 
            this.tbXMax.Location = new System.Drawing.Point(58, 349);
            this.tbXMax.Name = "tbXMax";
            this.tbXMax.Size = new System.Drawing.Size(69, 20);
            this.tbXMax.TabIndex = 8;
            this.tbXMax.Text = "10";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "XMax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbXmin
            // 
            this.tbXmin.Location = new System.Drawing.Point(58, 316);
            this.tbXmin.Name = "tbXmin";
            this.tbXmin.Size = new System.Drawing.Size(69, 20);
            this.tbXmin.TabIndex = 6;
            this.tbXmin.Text = "-10";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "XMin:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbComplexType
            // 
            this.cbComplexType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComplexType.FormattingEnabled = true;
            this.cbComplexType.Items.AddRange(new object[] {
                                    "REAL",
                                    "IMAGINARY",
                                    "REAL & IMAGINARY",
                                    "MAGNITUDE",
                                    "PHASE"});
            this.cbComplexType.Location = new System.Drawing.Point(3, 125);
            this.cbComplexType.Name = "cbComplexType";
            this.cbComplexType.Size = new System.Drawing.Size(121, 21);
            this.cbComplexType.TabIndex = 4;
            this.cbComplexType.SelectedIndexChanged += new System.EventHandler(this.CbComplexTypeSelectedIndexChanged);
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Items.AddRange(new object[] {
                                    "Orthographic Camera",
                                    "Perspective Camera"});
            this.cbCamera.Location = new System.Drawing.Point(3, 28);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(121, 21);
            this.cbCamera.TabIndex = 3;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.CbCameraSelectedIndexChanged);
            // 
            // cbResolution
            // 
            this.cbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Items.AddRange(new object[] {
                                    "32",
                                    "64",
                                    "128",
                                    "256",
                                    "512"});
            this.cbResolution.Location = new System.Drawing.Point(3, 229);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(121, 21);
            this.cbResolution.TabIndex = 2;
            this.cbResolution.SelectedIndexChanged += new System.EventHandler(this.CbResolutionSelectedIndexChanged);
            // 
            // cbBrush
            // 
            this.cbBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrush.FormattingEnabled = true;
            this.cbBrush.Items.AddRange(new object[] {
                                    "LightGray",
                                    "Gold",
                                    "Grid",
                                    "ALTITUDEMAP",
                                    "ALTITUDEMAP2",
                                    "ARGUMENTMAP",
                                    "Red (Shiny)",
                                    "Green(Shiny)",
                                    "Blue(Shiny)",
                                    "Gold(Shiny)",
                                    "Silver(Shiny)"});
            this.cbBrush.Location = new System.Drawing.Point(3, 180);
            this.cbBrush.Name = "cbBrush";
            this.cbBrush.Size = new System.Drawing.Size(121, 21);
            this.cbBrush.TabIndex = 1;
            this.cbBrush.SelectedIndexChanged += new System.EventHandler(this.CbBrushSelectedIndexChanged);
            // 
            // cbFunction
            // 
            this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
                                    "Surface1",
                                    "Surface2",
                                    "BIVARIATENORMAL",
                                    "_COMPLEX_LOG",
                                    "_COMPLEX_EXP",
                                    "_COMPLEX_SQRT",
                                    "_COMPLEX_SQUARE",
                                    "_COMPLEX_CUBE",
                                    "_COMPLEX_SIN",
                                    "_COMPLEX_COS",
                                    "_COMPLEX_TAN",
                                    "_COMPLEX_ASIN",
                                    "_COMPLEX_ACOS",
                                    "_COMPLEX_ATAN",
                                    "_COMPLEX_CSC",
                                    "_COMPLEX_SEC",
                                    "_COMPLEX_COT",
                                    "_COMPLEX_ACSC",
                                    "_COMPLEX_ASEC",
                                    "_COMPLEX_ACOT",
                                    "_COMPLEX_SINH",
                                    "_COMPLEX_COSH",
                                    "_COMPLEX_TANH",
                                    "_COMPLEX_ASINH",
                                    "_COMPLEX_ACOSH",
                                    "_COMPLEX_ATANH",
                                    "_COMPLEX_CSCH",
                                    "_COMPLEX_SECH",
                                    "_COMPLEX_COTH",
                                    "_COMPLEX_ACSCH",
                                    "_COMPLEX_ASECH",
                                    "_COMPLEX_ACOTH",
                                    "_PARAMETRIC_HELICOID",
                                    "_PARAMETRIC_SPHERE",
                                    "_PARAMETRIC_TORUS",
                                    "_PARAMETRIC_SEASHELL",
                                    "_PARAMETRIC_MOEBIUS",
                                    "_PARAMETRIC_KUEN",
                                    "_PARAMETRIC_KLEINBAGEL",
                                    "_PARAMETRIC_KLEINBOTTEL"});
            this.cbFunction.Location = new System.Drawing.Point(3, 77);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(121, 21);
            this.cbFunction.TabIndex = 0;
            this.cbFunction.SelectedIndexChanged += new System.EventHandler(this.CbFunctionSelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(146, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 4);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(183, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(831, 30);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart2
            // 
            chartArea2.AxisX.LabelStyle.Format = "F";
            chartArea2.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.Maximum = 4D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.LabelStyle.Format = "F";
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.Maximum = 15D;
            chartArea2.AxisY.Minimum = -15D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(803, 203);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(211, 144);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title2.DockedToChartArea = "ChartArea1";
            title2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title1";
            this.chart2.Titles.Add(title2);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(803, 353);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 144);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar2.LargeChange = 5;
            this.vScrollBar2.Location = new System.Drawing.Point(160, 50);
            this.vScrollBar2.Maximum = 50;
            this.vScrollBar2.Minimum = -50;
            this.vScrollBar2.Name = "vScrollBar2";
            this.tableLayoutPanel1.SetRowSpan(this.vScrollBar2, 3);
            this.vScrollBar2.Size = new System.Drawing.Size(20, 450);
            this.vScrollBar2.TabIndex = 17;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar2Scroll);
            // 
            // hScrollBar2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.hScrollBar2, 2);
            this.hScrollBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBar2.Location = new System.Drawing.Point(180, 30);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(600, 20);
            this.hScrollBar2.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.editToolStripMenuItem,
                                    this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.openToolStripMenuItem,
                                    this.newToolStripMenuItem,
                                    this.new2ToolStripMenuItem,
                                    this.remove1ToolStripMenuItem,
                                    this.toolStripSeparator1,
                                    this.saveToolStripMenuItem,
                                    this.saveAsJPGToolStripMenuItem,
                                    this.saveAsHTMLToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.pageSetupToolStripMenuItem,
                                    this.printPreviewToolStripMenuItem,
                                    this.printViaGDIToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newToolStripMenuItem.Text = "New Model";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
            // 
            // new2ToolStripMenuItem
            // 
            this.new2ToolStripMenuItem.Name = "new2ToolStripMenuItem";
            this.new2ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.new2ToolStripMenuItem.Text = "Add Model";
            this.new2ToolStripMenuItem.Click += new System.EventHandler(this.New2ToolStripMenuItemClick);
            // 
            // remove1ToolStripMenuItem
            // 
            this.remove1ToolStripMenuItem.Name = "remove1ToolStripMenuItem";
            this.remove1ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.remove1ToolStripMenuItem.Text = "Remove Last Model";
            this.remove1ToolStripMenuItem.Click += new System.EventHandler(this.Remove1ToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "Save As PNG";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsJPGToolStripMenuItem
            // 
            this.saveAsJPGToolStripMenuItem.Name = "saveAsJPGToolStripMenuItem";
            this.saveAsJPGToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveAsJPGToolStripMenuItem.Text = "Save As JPG";
            this.saveAsJPGToolStripMenuItem.Click += new System.EventHandler(this.SaveAsJPGToolStripMenuItemClick);
            // 
            // saveAsHTMLToolStripMenuItem
            // 
            this.saveAsHTMLToolStripMenuItem.Name = "saveAsHTMLToolStripMenuItem";
            this.saveAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveAsHTMLToolStripMenuItem.Text = "Save As HTML";
            this.saveAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.SaveAsHTMLToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.PageSetupToolStripMenuItemClick);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItemClick);
            // 
            // printViaGDIToolStripMenuItem
            // 
            this.printViaGDIToolStripMenuItem.Name = "printViaGDIToolStripMenuItem";
            this.printViaGDIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printViaGDIToolStripMenuItem.Text = "Print via GDI";
            this.printViaGDIToolStripMenuItem.Click += new System.EventHandler(this.PrintViaGDIToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.rightPanelToolStripMenuItem,
                                    this.bottomPanelToolStripMenuItem,
                                    this.updatePanelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // rightPanelToolStripMenuItem
            // 
            this.rightPanelToolStripMenuItem.Checked = true;
            this.rightPanelToolStripMenuItem.CheckOnClick = true;
            this.rightPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightPanelToolStripMenuItem.Name = "rightPanelToolStripMenuItem";
            this.rightPanelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.rightPanelToolStripMenuItem.Text = "RightPanel";
            this.rightPanelToolStripMenuItem.Click += new System.EventHandler(this.RightPanelToolStripMenuItemClick);
            // 
            // bottomPanelToolStripMenuItem
            // 
            this.bottomPanelToolStripMenuItem.Name = "bottomPanelToolStripMenuItem";
            this.bottomPanelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bottomPanelToolStripMenuItem.Text = "BottomPanel";
            this.bottomPanelToolStripMenuItem.Click += new System.EventHandler(this.BottomPanelToolStripMenuItemClick);
            // 
            // updatePanelToolStripMenuItem
            // 
            this.updatePanelToolStripMenuItem.Name = "updatePanelToolStripMenuItem";
            this.updatePanelToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.updatePanelToolStripMenuItem.Text = "UpdatePanel";
            this.updatePanelToolStripMenuItem.Click += new System.EventHandler(this.UpdatePanelToolStripMenuItemClick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.clearToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItemClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wpf in Winform sample";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FrmMainSizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTrunc;
        private System.Windows.Forms.TextBox tbTrunc;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem updatePanelToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem bottomPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightPanelToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem printViaGDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveAsJPGToolStripMenuItem;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.TextBox tbSplit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbCoordinates;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbZMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbXmin;
        private System.Windows.Forms.ComboBox cbComplexType;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.ComboBox cbResolution;
        private System.Windows.Forms.ComboBox cbBrush;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.ToolStripMenuItem remove1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new2ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        
        #endregion

//        private System.Windows.Forms.Integration.ElementHost elementHost1;
        
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;

        
  
    }
}

