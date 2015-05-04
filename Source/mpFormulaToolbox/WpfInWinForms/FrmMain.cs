using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms.DataVisualization.Charting;

using Wpf3DControl;

namespace WpfInWinForms
{
    public partial class FrmMain : Form
    {
    	private Wpf3DCtrl Wpf3DCtrl1 = new  Wpf3DCtrl();
    	private Data3D Data3D1 = null;
    	private Boolean IsInitializing = true;


    	public FrmMain()
        {
            InitializeComponent();
            cbFunction.SelectedIndex = 0;
            cbComplexType.SelectedIndex = 0;
            cbBrush.SelectedIndex = 0;
            cbResolution.SelectedIndex = 2;
            cbCamera.SelectedIndex = 1;
            cbCoordinates.SelectedIndex = 1;
			this.elementHost1.Child = Wpf3DCtrl1;
			printDocument1.PrinterSettings.DefaultPageSettings.Landscape = false;
			IsInitializing = false;
        }
    	
    	
    	private void Set2DChartFrom3D(string Mode, Chart chart, double[,] xValues, double[,] yValues, double[,] zValues, double xmin, double xmax,  double ymin,  double ymax, double zmin,  double zmax, int xResolution, int zResolution)
    	{
    	    chart.ChartAreas[0].AxisX.Maximum = xmax;
            chart.ChartAreas[0].AxisX.Minimum = xmin;
            chart.ChartAreas[0].AxisX.Interval = (xmax-xmin)/4.0;
           
            double ymin1 = Math.Round(ymin,4);
    	    double yInterval = Math.Round((ymax-ymin)/4.0, 4);
    	    double ymax1 = ymin1 +  yInterval * 4.0;

            chart.ChartAreas[0].AxisY.Maximum = ymax1;
            chart.ChartAreas[0].AxisY.Minimum = ymin1;
            chart.ChartAreas[0].AxisY.Interval = yInterval;
            
            double yrange = (ymax - ymin);
            double ymean = (ymin + ymax) / 2;
            double xrange = (xmax - xmin);
            double xmean = (xmin + xmax) / 2;
            double zrange = (zmax - zmin);
            double zmean = (zmin + zmax) / 2;
            double t1 = 0.0;
            double t2 = 0.0;
            
            chart.Series.Clear();
            int iz = 0;
            for (int ic = 0; ic < 3; ic++)
            {
                switch (ic)
                {
                    case 0: iz = zResolution/2; break;
        		    case 1: iz = 0; break;
        		    case 2: iz = zResolution; break;
                }
                chart.Series.Add(new Series());
                chart.Series[ic].ChartArea = "ChartArea1";
                chart.Series[ic].ChartType = SeriesChartType.Line;
                chart.Series[ic].Legend = "Legend1";
                if (Mode=="y") {t1 = zValues[0,iz]; chart.Titles[0].Text="Real";} else {t1 = zValues[iz, 0]; chart.Titles[0].Text="Imaginary";}
                chart.Series[ic].Name = Mode + " = " + (t1 * zrange  + zmean).ToString("F");
        	    for (int ix = 0; ix < xResolution+1; ix++)
                {
        	        if (Mode=="y") {t1 = xValues[ix,iz]; t2 = yValues[ix,iz];} else {t1 = xValues[iz,ix]; t2 = yValues[iz,ix];}
        	        double xvalues2 = t1  * xrange  + xmean;
        	        double yvalues2 = t2  * yrange  + ymean;
                    chart.Series[ic].Points.AddXY(xvalues2, yvalues2);
        	    }
            }
    	}
    	

    	

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (openFileDialog1.ShowDialog() == DialogResult.OK)
          {
            try
            {
              string FName = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
          }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          saveFileDialog1.Filter = "Bitmap File (*.png)|*.png|All files (*.*)|*.*";
          if (saveFileDialog1.ShowDialog() == DialogResult.OK)
          {
            Wpf3DCtrl1.Save3DBitmap(saveFileDialog1.FileName, "png", false);
          }
        }
        
        void NewToolStripMenuItemClick(object sender, EventArgs e)
        {
//        	int Resolution = 128;
//        	Data3D1 = new Data3D("COMPLEXSINE", Resolution, Resolution, "", 0,3,3,3,3);
//        	Wpf3DCtrl1.MakeModel(null, 1, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues,  Data3D1.ScaledXmin, Data3D1.ScaledZmin, Resolution, Resolution, "", "");
        }
        
        void New2ToolStripMenuItemClick(object sender, EventArgs e)
        {
//        	int Resolution = 128;
//        	Data3D1 = new Data3D("COMPLEXSINE_IMAG", Resolution, Resolution, "", 0,3,3,3,3);
//        	Wpf3DCtrl1.MakeModel(null, 0, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues,  Data3D1.ScaledXmin, Data3D1.ScaledZmin, Resolution, Resolution, "", "");
        	
        }
        
        
		private void GetRanges(String Function3D, out double xmin1, out double xmax1, out double zmin1, out double zmax1, out double ytruncate1, out String HasSplit1)
		{
			double xmin = -6, xmax = 6, zmin= -6, zmax = 6, ytruncate = 10;
			String HasSplit = "None";
		        	
	         if (Function3D == "SURFACE1")
	         {xmin = -5; xmax = 5; zmin = -5; zmax = 5; }
	         
	         if (Function3D == "SURFACE2")
	         {xmin = -1; xmax = 1; zmin = -1; zmax = 1; }

	         if (Function3D == "_PARAMETRIC_SEASHELL")
	         {xmin = 0; xmax = 6*Math.PI; zmin = 0; zmax = 6*Math.PI; }
	         
	         
	         if (Function3D == "_PARAMETRIC_MOEBIUS")
	         {xmin = 0; xmax = 6.4; zmin = -1; zmax = 1; }
	         

	         if (Function3D == "_PARAMETRIC_KUEN")
	         {xmin = -4.5; xmax = 4.5; zmin = 0.01; zmax = 3.14; }


	         if (Function3D == "_PARAMETRIC_KLEINBAGEL")
	         {xmin = 0.0; xmax = 6.28; zmin = 0.0; zmax = 6.28; }
	         


	         if (Function3D == "_PARAMETRIC_KLEINBOTTEL")
	         {xmin = 0.0; xmax = 3.14; zmin = 0.0; zmax = 6.28; }

	         
	         if (Function3D == "_COMPLEX_SQUARE")
	         {xmin = -2; xmax = 2; zmin = -2; zmax = 2; }
	         

	         if (Function3D == "_COMPLEX_CUBE")
	         {xmin = -1.8; xmax = 1.8; zmin = -1.8; zmax = 1.8; }

	         
	         if (Function3D == "_COMPLEX_SIN" || Function3D == "_COMPLEX_COS" || Function3D == "_COMPLEX_TAN")
	         {xmin = -6; xmax = 6; zmin = -2.5; zmax = 2.5; }


	         if (Function3D == "_COMPLEX_ASIN" || Function3D == "_COMPLEX_ACOS" || Function3D == "_COMPLEX_ATAN")
	         {xmin = -6; xmax = 6; zmin = -2.5; zmax = 2.5; }

	         
	         if (Function3D == "_COMPLEX_SINH" || Function3D == "_COMPLEX_COSH"|| Function3D == "_COMPLEX_TANH")
	         {xmin = -6; xmax = 6; zmin = -2.5; zmax = 2.5; }
	         
	         
	         if (Function3D == "_COMPLEX_LOG" || Function3D == "_COMPLEX_EXP"|| Function3D == "_COMPLEX_SQRT")
	         {xmin = -2.5; xmax = 2.5; zmin = -2.5; zmax = 2.5; }
	         
	         
	         if (Function3D == "_COMPLEX_ASIN" || Function3D == "_COMPLEX_ACOS" || Function3D == "_COMPLEX_SQRT" || Function3D == "_COMPLEX_LOG2")
	         {HasSplit = "0.0";}

	         if (Function3D == "_COMPLEX_LOG")
	         {ytruncate = 5.0;}

	         
            xmin1 = xmin; xmax1 = xmax; zmin1 = zmin; zmax1 = zmax; HasSplit1 = HasSplit; ytruncate1 = ytruncate;
		}
        
        

        void NewModel()
        {

        	double xmin =  Convert.ToDouble(tbXmin.Text);
			double xmax = Convert.ToDouble(tbXMax.Text);
			double zmin = Convert.ToDouble(tbZMin.Text);
			double zmax = Convert.ToDouble(tbZMax.Text);
			double ytruncate = Convert.ToDouble(tbTrunc.Text);

			double ymin;
			double ymax;

			int Mode = 0;
			if (tbSplit.Text!="None") Mode = 1;
        	String Function3D = cbFunction.SelectedItem.ToString().ToUpper();
        	int MaterialType = cbBrush.SelectedIndex;
        	int ComplexType = cbComplexType.SelectedIndex;
        	int Resolution = Int32.Parse(cbResolution.SelectedItem.ToString());
        	int CoordinateStyle = cbCoordinates.SelectedIndex;
        	String RenderStyle = cbBrush.SelectedItem.ToString().ToUpper();

        	if (ComplexType ==2)
        	{
        	    Wpf3DCtrl1.ClearModel();

        	    Data3D1 = new Data3D(Function3D, Resolution, Resolution, "LIGHTGRAY", 0, xmin, xmax, zmin, zmax, ytruncate, out ymin, out ymax);
            	Wpf3DCtrl1.MakeModel(Mode, CoordinateStyle, Data3D1.MyBitmapImage , 0, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues, Data3D1.ScaledXmin, Data3D1.ScaledZmin, Resolution, Resolution, "LIGHTGRAY", Function3D);

        	    Data3D1 = new Data3D(Function3D, Resolution, Resolution, "GOLD", 1, xmin, xmax, zmin, zmax, ytruncate, out ymin, out ymax);
            	Wpf3DCtrl1.MakeModel(Mode, CoordinateStyle, Data3D1.MyBitmapImage , 1, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues, Data3D1.ScaledXmin, Data3D1.ScaledZmin, Resolution, Resolution, "GOLD", Function3D);
        	}
        	else
        	{
            	Data3D1 = new Data3D(Function3D, Resolution, Resolution, RenderStyle, ComplexType, xmin, xmax, zmin, zmax, ytruncate, out ymin, out ymax);
            	
            	Wpf3DCtrl1.ClearModel();
            	
            	Wpf3DCtrl1.MakeModel(Mode, CoordinateStyle, Data3D1.MyBitmapImage , MaterialType, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues, Data3D1.ScaledXmin, Data3D1.ScaledZmin, Resolution, Resolution, RenderStyle, Function3D);
            	
            	if  (Function3D.StartsWith("_PARAMETRIC")==false)
            	{
            	Set2DChartFrom3D("y", chart1, Data3D1.xvalues, Data3D1.yvalues, Data3D1.zvalues, xmin, xmax, ymin, ymax, zmin, zmax, Resolution, Resolution);
            	Set2DChartFrom3D("x",chart2, Data3D1.zvalues, Data3D1.yvalues, Data3D1.xvalues, zmin, zmax, ymin, ymax, xmin, xmax, Resolution, Resolution);
            	}
        	}
        	lblTitle.Text = Function3D;
        	string s = "ymin: " + ymin.ToString() + Environment.NewLine;
        	s = s + "ymax: " + ymax.ToString() + Environment.NewLine;
        	richTextBox1.Text = s;
        }
        
        
       void CbFunctionSelectedIndexChanged(object sender, EventArgs e)
        {
			double xmin = 0;
			double xmax = 0;
			double zmin = 0;
			double zmax = 0;
			double ytruncate = 0;
			String HasSplit = "";
			String Function3D = cbFunction.SelectedItem.ToString().ToUpper();
			GetRanges(Function3D, out xmin, out xmax, out zmin, out zmax, out ytruncate, out HasSplit);
			tbXmin.Text = xmin.ToString();
			tbXMax.Text = xmax.ToString();
			tbZMin.Text = zmin.ToString();
			tbZMax.Text = zmax.ToString();
			tbTrunc.Text = ytruncate.ToString();
			tbSplit.Text = HasSplit;
			
			
			
       		if (!IsInitializing) NewModel();
        }

       
        void BtnApplyClick(object sender, EventArgs e)
        {
        	if (!IsInitializing) NewModel();
        }
       
       
        void CbBrushSelectedIndexChanged(object sender, EventArgs e)
        {
       		if (!IsInitializing) NewModel();
        }

        void CbResolutionSelectedIndexChanged(object sender, EventArgs e)
        {
       		if (!IsInitializing) NewModel();
        }
        
        void CbComplexTypeSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (!IsInitializing) NewModel();
        }


        void CbCoordinatesSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (!IsInitializing) NewModel();
        }        
        
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
        }
        
        
        void HScrollBar1Scroll(object sender, ScrollEventArgs e)
        {
        	double value = (double) e.NewValue;
			Wpf3DCtrl1.SetCameraTheta(value/1.0);
			toolTip1.SetToolTip(hScrollBar1, "x-Axis: " + hScrollBar1.Value.ToString());

        }
        
        
        void VScrollBar1Scroll(object sender, ScrollEventArgs e)
        {
        	double value = (double) e.NewValue;
        	value = (value-50.0) * Math.PI / 100.0;
			Wpf3DCtrl1.SetCameraPhi(value);
			toolTip1.SetToolTip(vScrollBar1, "y-Axis: " + vScrollBar1.Value.ToString());
        }
        
        
        
        void VScrollBar2Scroll(object sender, ScrollEventArgs e)
        {
        	double factor = 1.0;
        	double value = (double) e.NewValue;
        	if (value < 0) factor = 10 / (Math.Abs(value) + 10);
        	if (value > 0) factor = (value + 10) / 10;
        	Wpf3DCtrl1.SetCameraFactor(1/factor);
        	toolTip1.SetToolTip(vScrollBar2, "Radius: " + (4/factor).ToString("F"));
            
        }
        
        
        
        void Remove1ToolStripMenuItemClick(object sender, EventArgs e)
        {
        	Wpf3DCtrl1.RemoveLastModel();
        }
        
        
        
        
        
        void CbCameraSelectedIndexChanged(object sender, EventArgs e)
        {
        	Wpf3DCtrl1.SetCameraType(cbCamera.SelectedIndex);
        }
        
        
        

        
        void TabPage1Click(object sender, EventArgs e)
        {
            
        }
        
        void SaveAsHTMLToolStripMenuItemClick(object sender, EventArgs e)
        {
          saveFileDialog1.Filter = "Bitmap File (*.png)|*.png|All files (*.*)|*.*";
          if (saveFileDialog1.ShowDialog() == DialogResult.OK)
          {
//            Wpf3DCtrl1.TestBitmap(saveFileDialog1.FileName);
          }

        }
        
        void SaveAsJPGToolStripMenuItemClick(object sender, EventArgs e)
        {
          saveFileDialog1.Filter = "Bitmap File (*.jpg)|*.jpg|All files (*.*)|*.*";
          if (saveFileDialog1.ShowDialog() == DialogResult.OK)
          {
            Wpf3DCtrl1.Save3DBitmap(saveFileDialog1.FileName, "jpg", true);
          }

        }
        
        void PageSetupToolStripMenuItemClick(object sender, EventArgs e)
        {
            pageSetupDialog1.Document=printDocument1;
            System.Windows.Forms.DialogResult result = pageSetupDialog1.ShowDialog();
            if (result  == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
                printDocument1.PrinterSettings = pageSetupDialog1.PrinterSettings;
            }
            
        }
        
        void PrintPreviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();            
        }
        
        void PrintViaGDIToolStripMenuItemClick(object sender, EventArgs e)
        {
          PrintDialog printDlg = new PrintDialog();
          printDlg.Document = printDocument1;
          DialogResult result = printDlg.ShowDialog();
          if (result == DialogResult.OK)
          {  
              printDocument1.PrinterSettings = printDlg.PrinterSettings;
              
              printDocument1.Print();
          
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

        
        
        void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Boolean IsLandscape = printDocument1.DefaultPageSettings.Landscape;
            
            Wpf3DCtrl1.Save3DBitmap(RootDir32() + @"Manual\document.jpg", "jpg", true);
            
            // Calculate title string position
            Rectangle    titlePosition = new Rectangle(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height);
            Font        fontTitle = new Font("Times New Roman", 16);
            string        chartTitle = cbFunction.SelectedItem.ToString().ToUpper();
            SizeF        titleSize = e.Graphics.MeasureString(chartTitle, fontTitle);
            titlePosition.Height = (int)titleSize.Height;
        
            // Draw charts title
            StringFormat    format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format);
            
            // Calculate bitmap position
            int MyWidth = e.MarginBounds.Width;
            int MyHeight = e.MarginBounds.Height - titlePosition.Height;
            int MySize = Math.Min(MyWidth, MyHeight) ;
            int MyTop = titlePosition.Bottom ;
            int MyLeft = e.MarginBounds.Left ;
            
            // Draw bitmap
            Bitmap bm = new Bitmap(RootDir32() + @"Manual\document.jpg");
            e.Graphics.DrawImage(bm, MyLeft, MyTop, MySize, MySize);

            using (Pen the_pen2 = new Pen(Color.Gray, 1))
            {
                // Draw recangle around bitmap
                e.Graphics.DrawRectangle(the_pen2, MyLeft, MyTop, MySize, MySize);
                
                // Draw chart with recangle around it 
                Rectangle chartPosition1;
                if (IsLandscape) chartPosition1 = new Rectangle(MyLeft + MySize + 10, MyTop, MyWidth - MySize - 10, MySize/2);
                else chartPosition1 = new Rectangle(MyLeft, MyTop + MySize + 10, MySize/2, MyHeight - MySize - 10);
                e.Graphics.DrawRectangle(the_pen2, chartPosition1);
                chart1.Printing.PrintPaint(e.Graphics, chartPosition1);

                Rectangle chartPosition2;
                if (IsLandscape) chartPosition2 = new Rectangle(MyLeft + MySize + 10, MyTop +  MySize/2, MyWidth - MySize - 10, MySize/2);
                else chartPosition2 = new Rectangle(MyLeft + MySize/2, MyTop + MySize + 10, MySize/2, MyHeight - MySize - 10);
                e.Graphics.DrawRectangle(the_pen2, chartPosition2);
                chart2.Printing.PrintPaint(e.Graphics, chartPosition2);


            }

            e.HasMorePages = false;
        }
        
        
        void UpdatePanelContent()
        {
//            string s1 = tableLayoutPanel1.ColumnStyles[1].Width.ToString();
//            string s2 = tableLayoutPanel1.RowStyles[0].Height.ToString();
//
//            string s3 = (this.Height-80).ToString();
//            string s4 = (Width-200).ToString();
//            string s = "Column 1 Width: " + s1 +  Environment.NewLine;
//            s = s + "Row 0 Height: " + s2 +  Environment.NewLine;
//            s = s + "Form Height -80: " + s3 +  Environment.NewLine;
//            s = s + "Form Width -200: " + s4 +  Environment.NewLine;
//            richTextBox1.Text = s;

        }
           
                               

                
        void ClearToolStripMenuItemClick(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.RowStyles[1].Height = 0 ;
            tableLayoutPanel1.RowStyles[3].Height = 100 ;
            TableLayoutPanelCellPosition MyPos = new TableLayoutPanelCellPosition(1,3);
            tableLayoutPanel1.SetCellPosition(richTextBox1, MyPos);
            tableLayoutPanel1.SetRowSpan(chart1, 5);    
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 3);            
//        	Wpf3DCtrl1.ClearModel();
        }
        
        
        
        void UseRightPanel()
        {
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.SetColumnSpan(lblTitle, 4);

            TableLayoutPanelCellPosition MyPos = new TableLayoutPanelCellPosition(5,4);
            tableLayoutPanel1.SetCellPosition(richTextBox1, MyPos);
            TableLayoutPanelCellPosition MyPos2 = new TableLayoutPanelCellPosition(5,2);
            tableLayoutPanel1.SetCellPosition(chart1, MyPos2);
            TableLayoutPanelCellPosition MyPos3 = new TableLayoutPanelCellPosition(5,3);
            tableLayoutPanel1.SetCellPosition(chart2, MyPos3);

            tableLayoutPanel1.SetColumnSpan(chart1, 1);
            tableLayoutPanel1.SetRowSpan(chart1, 1);
            
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 1);
            tableLayoutPanel1.SetRowSpan(richTextBox1, 2);
            tableLayoutPanel1.RowStyles[5].Height = 40;
            tableLayoutPanel1.RowStyles[6].Height = 0;
            tableLayoutPanel1.RowStyles[7].Height = 0;
            tableLayoutPanel1.ColumnStyles[2].Width = (this.Height-80)/2 ;
            tableLayoutPanel1.ColumnStyles[3].Width = (this.Height-80)/2 ;
            
            
            int a = 320;

//            int a = 140;

            tableLayoutPanel1.RowStyles[2].Height = (this.Height-a)/2 ;
            tableLayoutPanel1.RowStyles[3].Height = (this.Height-a)/2 ;
            tableLayoutPanel1.RowStyles[4].Height = 60 ;

//            tableLayoutPanel1.RowStyles[2].Height = (this.Height-a)/3 ;
//            tableLayoutPanel1.RowStyles[3].Height = (this.Height-a)/3 ;
//            tableLayoutPanel1.RowStyles[4].Height = (this.Height-a)/3 ;

            
            UpdatePanelContent();
            tableLayoutPanel1.ResumeLayout();

        }

        
        void RightPanelToolStripMenuItemClick(object sender, EventArgs e)
        {
            UseRightPanel();        
        }
        
        void UseBottomPanel()
        {
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.SetColumnSpan(lblTitle, 3);
            TableLayoutPanelCellPosition MyPos = new TableLayoutPanelCellPosition(2,7);
            tableLayoutPanel1.SetCellPosition(richTextBox1, MyPos);
            TableLayoutPanelCellPosition MyPos2 = new TableLayoutPanelCellPosition(2,6);
            tableLayoutPanel1.SetCellPosition(chart1, MyPos2);
            TableLayoutPanelCellPosition MyPos3 = new TableLayoutPanelCellPosition(3,6);
            tableLayoutPanel1.SetCellPosition(chart2, MyPos3);


            tableLayoutPanel1.SetColumnSpan(richTextBox1, 2);
            tableLayoutPanel1.SetRowSpan(richTextBox1, 1);
            tableLayoutPanel1.ColumnStyles[5].Width = 0;
            
            int b = 215;
            tableLayoutPanel1.ColumnStyles[2].Width = (this.Width-b)/2 ;
            tableLayoutPanel1.ColumnStyles[3].Width = (this.Width-b)/2 ;
            
            int a = 200;
            tableLayoutPanel1.RowStyles[2].Height = (this.Width-a)/3 ;
            tableLayoutPanel1.RowStyles[3].Height = (this.Width-a)/3 ;
            tableLayoutPanel1.RowStyles[4].Height = (this.Width-a)/3 ;
            
            tableLayoutPanel1.RowStyles[5].Height = 20;
            tableLayoutPanel1.RowStyles[6].Height = 70 ;
            tableLayoutPanel1.RowStyles[7].Height = 30 ;
            UpdatePanelContent();
            tableLayoutPanel1.ResumeLayout();

        }

        void BottomPanelToolStripMenuItemClick(object sender, EventArgs e)
        {
            UseBottomPanel();
        }

        
        void UpdateLayoutPanel()
        {
            if ((this.Height-80) > (this.Width-200)) UseBottomPanel(); else UseRightPanel(); 
        }
        
        void UpdatePanelToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateLayoutPanel();
        }
        
        void FrmMainSizeChanged(object sender, EventArgs e)
        {
            if ((this.Height > 200) || (this.Width > 200))
            UpdateLayoutPanel();
        }
        

        
        
        
        
        void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        
        void Chart1Click(object sender, EventArgs e)
        {
            
        }
    }
}
