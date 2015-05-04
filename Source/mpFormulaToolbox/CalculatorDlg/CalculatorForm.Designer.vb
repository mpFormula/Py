'
' Created by SharpDevelop.
' User: DH
' Date: 05/05/2014
' Time: 14:59
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class CalculatorForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
	    Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
	    Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.standardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.scientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.programmerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.statisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
	    Me.historyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.digitGroupingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
	    Me.basicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.unitConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.dateCalculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.worksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
	    Me.datasetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.copyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.cancelEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.clearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.setRegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.removeRegistryEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.displayRegistryEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.showDirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.viewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.aboutCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
	    Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
	    Me.button1 = New System.Windows.Forms.Button()
	    Me.button2 = New System.Windows.Forms.Button()
	    Me.button3 = New System.Windows.Forms.Button()
	    Me.btnEqual = New System.Windows.Forms.Button()
	    Me.button5 = New System.Windows.Forms.Button()
	    Me.button6 = New System.Windows.Forms.Button()
	    Me.button7 = New System.Windows.Forms.Button()
	    Me.button8 = New System.Windows.Forms.Button()
	    Me.button9 = New System.Windows.Forms.Button()
	    Me.button10 = New System.Windows.Forms.Button()
	    Me.button11 = New System.Windows.Forms.Button()
	    Me.button12 = New System.Windows.Forms.Button()
	    Me.button13 = New System.Windows.Forms.Button()
	    Me.button14 = New System.Windows.Forms.Button()
	    Me.button15 = New System.Windows.Forms.Button()
	    Me.button16 = New System.Windows.Forms.Button()
	    Me.button17 = New System.Windows.Forms.Button()
	    Me.button18 = New System.Windows.Forms.Button()
	    Me.button19 = New System.Windows.Forms.Button()
	    Me.button20 = New System.Windows.Forms.Button()
	    Me.button21 = New System.Windows.Forms.Button()
	    Me.button22 = New System.Windows.Forms.Button()
	    Me.button23 = New System.Windows.Forms.Button()
	    Me.button24 = New System.Windows.Forms.Button()
	    Me.button25 = New System.Windows.Forms.Button()
	    Me.button26 = New System.Windows.Forms.Button()
	    Me.button27 = New System.Windows.Forms.Button()
	    Me.button28 = New System.Windows.Forms.Button()
	    Me.richTextBoxInput = New System.Windows.Forms.RichTextBox()
	    Me.richTextBoxOutput = New System.Windows.Forms.RichTextBox()
	    Me.menuStrip1.SuspendLayout
	    Me.tableLayoutPanel1.SuspendLayout
	    Me.SuspendLayout
	    '
	    'menuStrip1
	    '
	    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewToolStripMenuItem, Me.editToolStripMenuItem, Me.toolStripMenuItem1, Me.helpToolStripMenuItem})
	    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
	    Me.menuStrip1.Name = "menuStrip1"
	    Me.menuStrip1.Size = New System.Drawing.Size(210, 24)
	    Me.menuStrip1.TabIndex = 0
	    Me.menuStrip1.Text = "menuStrip1"
	    AddHandler Me.menuStrip1.ItemClicked, AddressOf Me.MenuStrip1ItemClicked
	    '
	    'viewToolStripMenuItem
	    '
	    Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.standardToolStripMenuItem, Me.scientificToolStripMenuItem, Me.programmerToolStripMenuItem, Me.statisticsToolStripMenuItem, Me.toolStripSeparator1, Me.historyToolStripMenuItem, Me.digitGroupingToolStripMenuItem, Me.toolStripSeparator2, Me.basicToolStripMenuItem, Me.unitConversionToolStripMenuItem, Me.dateCalculationToolStripMenuItem, Me.worksheetsToolStripMenuItem})
	    Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
	    Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
	    Me.viewToolStripMenuItem.Text = "View"
	    '
	    'standardToolStripMenuItem
	    '
	    Me.standardToolStripMenuItem.Name = "standardToolStripMenuItem"
	    Me.standardToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.standardToolStripMenuItem.Text = "Standard"
	    '
	    'scientificToolStripMenuItem
	    '
	    Me.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem"
	    Me.scientificToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.scientificToolStripMenuItem.Text = "Scientific"
	    '
	    'programmerToolStripMenuItem
	    '
	    Me.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem"
	    Me.programmerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.programmerToolStripMenuItem.Text = "Programmer"
	    '
	    'statisticsToolStripMenuItem
	    '
	    Me.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem"
	    Me.statisticsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.statisticsToolStripMenuItem.Text = "Statistics"
	    AddHandler Me.statisticsToolStripMenuItem.Click, AddressOf Me.StatisticsToolStripMenuItemClick
	    '
	    'toolStripSeparator1
	    '
	    Me.toolStripSeparator1.Name = "toolStripSeparator1"
	    Me.toolStripSeparator1.Size = New System.Drawing.Size(158, 6)
	    '
	    'historyToolStripMenuItem
	    '
	    Me.historyToolStripMenuItem.Name = "historyToolStripMenuItem"
	    Me.historyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.historyToolStripMenuItem.Text = "History"
	    '
	    'digitGroupingToolStripMenuItem
	    '
	    Me.digitGroupingToolStripMenuItem.Name = "digitGroupingToolStripMenuItem"
	    Me.digitGroupingToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.digitGroupingToolStripMenuItem.Text = "Digit Grouping"
	    '
	    'toolStripSeparator2
	    '
	    Me.toolStripSeparator2.Name = "toolStripSeparator2"
	    Me.toolStripSeparator2.Size = New System.Drawing.Size(158, 6)
	    '
	    'basicToolStripMenuItem
	    '
	    Me.basicToolStripMenuItem.Name = "basicToolStripMenuItem"
	    Me.basicToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.basicToolStripMenuItem.Text = "Basic"
	    '
	    'unitConversionToolStripMenuItem
	    '
	    Me.unitConversionToolStripMenuItem.Name = "unitConversionToolStripMenuItem"
	    Me.unitConversionToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.unitConversionToolStripMenuItem.Text = "Unit conversion"
	    '
	    'dateCalculationToolStripMenuItem
	    '
	    Me.dateCalculationToolStripMenuItem.Name = "dateCalculationToolStripMenuItem"
	    Me.dateCalculationToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.dateCalculationToolStripMenuItem.Text = "Date Calculation"
	    '
	    'worksheetsToolStripMenuItem
	    '
	    Me.worksheetsToolStripMenuItem.Name = "worksheetsToolStripMenuItem"
	    Me.worksheetsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
	    Me.worksheetsToolStripMenuItem.Text = "Worksheets"
	    '
	    'editToolStripMenuItem
	    '
	    Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator3, Me.datasetToolStripMenuItem})
	    Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
	    Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
	    Me.editToolStripMenuItem.Text = "Edit"
	    '
	    'copyToolStripMenuItem
	    '
	    Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
	    Me.copyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.copyToolStripMenuItem.Text = "Copy"
	    '
	    'pasteToolStripMenuItem
	    '
	    Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
	    Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.pasteToolStripMenuItem.Text = "Paste"
	    '
	    'toolStripSeparator3
	    '
	    Me.toolStripSeparator3.Name = "toolStripSeparator3"
	    Me.toolStripSeparator3.Size = New System.Drawing.Size(149, 6)
	    '
	    'datasetToolStripMenuItem
	    '
	    Me.datasetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem1, Me.editToolStripMenuItem1, Me.cancelEditToolStripMenuItem, Me.clearToolStripMenuItem})
	    Me.datasetToolStripMenuItem.Name = "datasetToolStripMenuItem"
	    Me.datasetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.datasetToolStripMenuItem.Text = "Dataset"
	    '
	    'copyToolStripMenuItem1
	    '
	    Me.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1"
	    Me.copyToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
	    Me.copyToolStripMenuItem1.Text = "Copy dataset"
	    '
	    'editToolStripMenuItem1
	    '
	    Me.editToolStripMenuItem1.Name = "editToolStripMenuItem1"
	    Me.editToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
	    Me.editToolStripMenuItem1.Text = "Edit"
	    '
	    'cancelEditToolStripMenuItem
	    '
	    Me.cancelEditToolStripMenuItem.Name = "cancelEditToolStripMenuItem"
	    Me.cancelEditToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
	    Me.cancelEditToolStripMenuItem.Text = "Cancel edit"
	    '
	    'clearToolStripMenuItem
	    '
	    Me.clearToolStripMenuItem.Name = "clearToolStripMenuItem"
	    Me.clearToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
	    Me.clearToolStripMenuItem.Text = "Clear"
	    '
	    'toolStripMenuItem1
	    '
	    Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setRegistryToolStripMenuItem, Me.removeRegistryEntryToolStripMenuItem, Me.displayRegistryEntryToolStripMenuItem, Me.showDirToolStripMenuItem})
	    Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
	    Me.toolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
	    Me.toolStripMenuItem1.Text = "Tools"
	    AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
	    '
	    'setRegistryToolStripMenuItem
	    '
	    Me.setRegistryToolStripMenuItem.Name = "setRegistryToolStripMenuItem"
	    Me.setRegistryToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
	    Me.setRegistryToolStripMenuItem.Text = "Set Registry Entry"
	    AddHandler Me.setRegistryToolStripMenuItem.Click, AddressOf Me.SetRegistryToolStripMenuItemClick
	    '
	    'removeRegistryEntryToolStripMenuItem
	    '
	    Me.removeRegistryEntryToolStripMenuItem.Name = "removeRegistryEntryToolStripMenuItem"
	    Me.removeRegistryEntryToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
	    Me.removeRegistryEntryToolStripMenuItem.Text = "Remove Registry Entry"
	    AddHandler Me.removeRegistryEntryToolStripMenuItem.Click, AddressOf Me.RemoveRegistryEntryToolStripMenuItemClick
	    '
	    'displayRegistryEntryToolStripMenuItem
	    '
	    Me.displayRegistryEntryToolStripMenuItem.Name = "displayRegistryEntryToolStripMenuItem"
	    Me.displayRegistryEntryToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
	    Me.displayRegistryEntryToolStripMenuItem.Text = "Display Registry Entry"
	    AddHandler Me.displayRegistryEntryToolStripMenuItem.Click, AddressOf Me.DisplayRegistryEntryToolStripMenuItemClick
	    '
	    'showDirToolStripMenuItem
	    '
	    Me.showDirToolStripMenuItem.Name = "showDirToolStripMenuItem"
	    Me.showDirToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
	    Me.showDirToolStripMenuItem.Text = "Show Dir"
	    AddHandler Me.showDirToolStripMenuItem.Click, AddressOf Me.ShowDirToolStripMenuItemClick
	    '
	    'helpToolStripMenuItem
	    '
	    Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewHelpToolStripMenuItem, Me.aboutCalculatorToolStripMenuItem, Me.toolStripSeparator4})
	    Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
	    Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
	    Me.helpToolStripMenuItem.Text = "Help"
	    '
	    'viewHelpToolStripMenuItem
	    '
	    Me.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem"
	    Me.viewHelpToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
	    Me.viewHelpToolStripMenuItem.Text = "View Help"
	    '
	    'aboutCalculatorToolStripMenuItem
	    '
	    Me.aboutCalculatorToolStripMenuItem.Name = "aboutCalculatorToolStripMenuItem"
	    Me.aboutCalculatorToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
	    Me.aboutCalculatorToolStripMenuItem.Text = "About calculator"
	    '
	    'toolStripSeparator4
	    '
	    Me.toolStripSeparator4.Name = "toolStripSeparator4"
	    Me.toolStripSeparator4.Size = New System.Drawing.Size(159, 6)
	    '
	    'tableLayoutPanel1
	    '
	    Me.tableLayoutPanel1.ColumnCount = 5
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42!))
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42!))
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42!))
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42!))
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42!))
	    Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 7)
	    Me.tableLayoutPanel1.Controls.Add(Me.button2, 2, 7)
	    Me.tableLayoutPanel1.Controls.Add(Me.button3, 3, 7)
	    Me.tableLayoutPanel1.Controls.Add(Me.btnEqual, 4, 6)
	    Me.tableLayoutPanel1.Controls.Add(Me.button5, 3, 6)
	    Me.tableLayoutPanel1.Controls.Add(Me.button6, 2, 6)
	    Me.tableLayoutPanel1.Controls.Add(Me.button7, 1, 6)
	    Me.tableLayoutPanel1.Controls.Add(Me.button8, 0, 6)
	    Me.tableLayoutPanel1.Controls.Add(Me.button9, 0, 5)
	    Me.tableLayoutPanel1.Controls.Add(Me.button10, 1, 5)
	    Me.tableLayoutPanel1.Controls.Add(Me.button11, 2, 5)
	    Me.tableLayoutPanel1.Controls.Add(Me.button12, 3, 5)
	    Me.tableLayoutPanel1.Controls.Add(Me.button13, 4, 5)
	    Me.tableLayoutPanel1.Controls.Add(Me.button14, 0, 4)
	    Me.tableLayoutPanel1.Controls.Add(Me.button15, 1, 4)
	    Me.tableLayoutPanel1.Controls.Add(Me.button16, 2, 4)
	    Me.tableLayoutPanel1.Controls.Add(Me.button17, 3, 4)
	    Me.tableLayoutPanel1.Controls.Add(Me.button18, 4, 4)
	    Me.tableLayoutPanel1.Controls.Add(Me.button19, 0, 3)
	    Me.tableLayoutPanel1.Controls.Add(Me.button20, 1, 3)
	    Me.tableLayoutPanel1.Controls.Add(Me.button21, 2, 3)
	    Me.tableLayoutPanel1.Controls.Add(Me.button22, 3, 3)
	    Me.tableLayoutPanel1.Controls.Add(Me.button23, 4, 3)
	    Me.tableLayoutPanel1.Controls.Add(Me.button24, 0, 2)
	    Me.tableLayoutPanel1.Controls.Add(Me.button25, 1, 2)
	    Me.tableLayoutPanel1.Controls.Add(Me.button26, 2, 2)
	    Me.tableLayoutPanel1.Controls.Add(Me.button27, 3, 2)
	    Me.tableLayoutPanel1.Controls.Add(Me.button28, 4, 2)
	    Me.tableLayoutPanel1.Controls.Add(Me.richTextBoxInput, 0, 1)
	    Me.tableLayoutPanel1.Controls.Add(Me.richTextBoxOutput, 0, 0)
	    Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
	    Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
	    Me.tableLayoutPanel1.RowCount = 8
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36!))
	    Me.tableLayoutPanel1.Size = New System.Drawing.Size(210, 368)
	    Me.tableLayoutPanel1.TabIndex = 1
	    '
	    'button1
	    '
	    Me.tableLayoutPanel1.SetColumnSpan(Me.button1, 2)
	    Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button1.Location = New System.Drawing.Point(3, 335)
	    Me.button1.Name = "button1"
	    Me.button1.Size = New System.Drawing.Size(78, 30)
	    Me.button1.TabIndex = 0
	    Me.button1.Text = "0"
	    Me.button1.UseVisualStyleBackColor = true
	    '
	    'button2
	    '
	    Me.button2.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button2.Location = New System.Drawing.Point(87, 335)
	    Me.button2.Name = "button2"
	    Me.button2.Size = New System.Drawing.Size(36, 30)
	    Me.button2.TabIndex = 1
	    Me.button2.Text = "."
	    Me.button2.UseVisualStyleBackColor = true
	    '
	    'button3
	    '
	    Me.button3.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button3.Location = New System.Drawing.Point(129, 335)
	    Me.button3.Name = "button3"
	    Me.button3.Size = New System.Drawing.Size(36, 30)
	    Me.button3.TabIndex = 2
	    Me.button3.Text = "+"
	    Me.button3.UseVisualStyleBackColor = true
	    '
	    'btnEqual
	    '
	    Me.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.btnEqual.Location = New System.Drawing.Point(171, 299)
	    Me.btnEqual.Name = "btnEqual"
	    Me.tableLayoutPanel1.SetRowSpan(Me.btnEqual, 2)
	    Me.btnEqual.Size = New System.Drawing.Size(36, 66)
	    Me.btnEqual.TabIndex = 3
	    Me.btnEqual.Text = "="
	    Me.btnEqual.UseVisualStyleBackColor = true
	    AddHandler Me.btnEqual.Click, AddressOf Me.BtnEqualClick
	    '
	    'button5
	    '
	    Me.button5.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button5.Location = New System.Drawing.Point(129, 299)
	    Me.button5.Name = "button5"
	    Me.button5.Size = New System.Drawing.Size(36, 30)
	    Me.button5.TabIndex = 4
	    Me.button5.Text = "-"
	    Me.button5.UseVisualStyleBackColor = true
	    '
	    'button6
	    '
	    Me.button6.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button6.Location = New System.Drawing.Point(87, 299)
	    Me.button6.Name = "button6"
	    Me.button6.Size = New System.Drawing.Size(36, 30)
	    Me.button6.TabIndex = 5
	    Me.button6.Text = "3"
	    Me.button6.UseVisualStyleBackColor = true
	    '
	    'button7
	    '
	    Me.button7.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button7.Location = New System.Drawing.Point(45, 299)
	    Me.button7.Name = "button7"
	    Me.button7.Size = New System.Drawing.Size(36, 30)
	    Me.button7.TabIndex = 6
	    Me.button7.Text = "2"
	    Me.button7.UseVisualStyleBackColor = true
	    '
	    'button8
	    '
	    Me.button8.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button8.Location = New System.Drawing.Point(3, 299)
	    Me.button8.Name = "button8"
	    Me.button8.Size = New System.Drawing.Size(36, 30)
	    Me.button8.TabIndex = 7
	    Me.button8.Text = "1"
	    Me.button8.UseVisualStyleBackColor = true
	    '
	    'button9
	    '
	    Me.button9.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button9.Location = New System.Drawing.Point(3, 263)
	    Me.button9.Name = "button9"
	    Me.button9.Size = New System.Drawing.Size(36, 30)
	    Me.button9.TabIndex = 8
	    Me.button9.Text = "4"
	    Me.button9.UseVisualStyleBackColor = true
	    '
	    'button10
	    '
	    Me.button10.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button10.Location = New System.Drawing.Point(45, 263)
	    Me.button10.Name = "button10"
	    Me.button10.Size = New System.Drawing.Size(36, 30)
	    Me.button10.TabIndex = 9
	    Me.button10.Text = "5"
	    Me.button10.UseVisualStyleBackColor = true
	    '
	    'button11
	    '
	    Me.button11.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button11.Location = New System.Drawing.Point(87, 263)
	    Me.button11.Name = "button11"
	    Me.button11.Size = New System.Drawing.Size(36, 30)
	    Me.button11.TabIndex = 10
	    Me.button11.Text = "6"
	    Me.button11.UseVisualStyleBackColor = true
	    '
	    'button12
	    '
	    Me.button12.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button12.Location = New System.Drawing.Point(129, 263)
	    Me.button12.Name = "button12"
	    Me.button12.Size = New System.Drawing.Size(36, 30)
	    Me.button12.TabIndex = 11
	    Me.button12.Text = "*"
	    Me.button12.UseVisualStyleBackColor = true
	    '
	    'button13
	    '
	    Me.button13.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button13.Location = New System.Drawing.Point(171, 263)
	    Me.button13.Name = "button13"
	    Me.button13.Size = New System.Drawing.Size(36, 30)
	    Me.button13.TabIndex = 12
	    Me.button13.Text = "1/x"
	    Me.button13.UseVisualStyleBackColor = true
	    '
	    'button14
	    '
	    Me.button14.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button14.Location = New System.Drawing.Point(3, 227)
	    Me.button14.Name = "button14"
	    Me.button14.Size = New System.Drawing.Size(36, 30)
	    Me.button14.TabIndex = 13
	    Me.button14.Text = "7"
	    Me.button14.UseVisualStyleBackColor = true
	    '
	    'button15
	    '
	    Me.button15.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button15.Location = New System.Drawing.Point(45, 227)
	    Me.button15.Name = "button15"
	    Me.button15.Size = New System.Drawing.Size(36, 30)
	    Me.button15.TabIndex = 14
	    Me.button15.Text = "8"
	    Me.button15.UseVisualStyleBackColor = true
	    '
	    'button16
	    '
	    Me.button16.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button16.Location = New System.Drawing.Point(87, 227)
	    Me.button16.Name = "button16"
	    Me.button16.Size = New System.Drawing.Size(36, 30)
	    Me.button16.TabIndex = 15
	    Me.button16.Text = "9"
	    Me.button16.UseVisualStyleBackColor = true
	    '
	    'button17
	    '
	    Me.button17.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button17.Location = New System.Drawing.Point(129, 227)
	    Me.button17.Name = "button17"
	    Me.button17.Size = New System.Drawing.Size(36, 30)
	    Me.button17.TabIndex = 16
	    Me.button17.Text = "/"
	    Me.button17.UseVisualStyleBackColor = true
	    '
	    'button18
	    '
	    Me.button18.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button18.Location = New System.Drawing.Point(171, 227)
	    Me.button18.Name = "button18"
	    Me.button18.Size = New System.Drawing.Size(36, 30)
	    Me.button18.TabIndex = 17
	    Me.button18.Text = "%"
	    Me.button18.UseVisualStyleBackColor = true
	    '
	    'button19
	    '
	    Me.button19.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button19.Location = New System.Drawing.Point(3, 191)
	    Me.button19.Name = "button19"
	    Me.button19.Size = New System.Drawing.Size(36, 30)
	    Me.button19.TabIndex = 18
	    Me.button19.Text = "<-"
	    Me.button19.UseVisualStyleBackColor = true
	    '
	    'button20
	    '
	    Me.button20.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button20.Location = New System.Drawing.Point(45, 191)
	    Me.button20.Name = "button20"
	    Me.button20.Size = New System.Drawing.Size(36, 30)
	    Me.button20.TabIndex = 19
	    Me.button20.Text = "CE"
	    Me.button20.UseVisualStyleBackColor = true
	    '
	    'button21
	    '
	    Me.button21.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button21.Location = New System.Drawing.Point(87, 191)
	    Me.button21.Name = "button21"
	    Me.button21.Size = New System.Drawing.Size(36, 30)
	    Me.button21.TabIndex = 20
	    Me.button21.Text = "C"
	    Me.button21.UseVisualStyleBackColor = true
	    '
	    'button22
	    '
	    Me.button22.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button22.Location = New System.Drawing.Point(129, 191)
	    Me.button22.Name = "button22"
	    Me.button22.Size = New System.Drawing.Size(36, 30)
	    Me.button22.TabIndex = 21
	    Me.button22.Text = "+/-"
	    Me.button22.UseVisualStyleBackColor = true
	    '
	    'button23
	    '
	    Me.button23.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button23.Location = New System.Drawing.Point(171, 191)
	    Me.button23.Name = "button23"
	    Me.button23.Size = New System.Drawing.Size(36, 30)
	    Me.button23.TabIndex = 22
	    Me.button23.Text = "sqrt"
	    Me.button23.UseVisualStyleBackColor = true
	    '
	    'button24
	    '
	    Me.button24.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button24.Location = New System.Drawing.Point(3, 155)
	    Me.button24.Name = "button24"
	    Me.button24.Size = New System.Drawing.Size(36, 30)
	    Me.button24.TabIndex = 23
	    Me.button24.Text = "MC"
	    Me.button24.UseVisualStyleBackColor = true
	    '
	    'button25
	    '
	    Me.button25.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button25.Location = New System.Drawing.Point(45, 155)
	    Me.button25.Name = "button25"
	    Me.button25.Size = New System.Drawing.Size(36, 30)
	    Me.button25.TabIndex = 24
	    Me.button25.Text = "MR"
	    Me.button25.UseVisualStyleBackColor = true
	    '
	    'button26
	    '
	    Me.button26.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button26.Location = New System.Drawing.Point(87, 155)
	    Me.button26.Name = "button26"
	    Me.button26.Size = New System.Drawing.Size(36, 30)
	    Me.button26.TabIndex = 25
	    Me.button26.Text = "MS"
	    Me.button26.UseVisualStyleBackColor = true
	    '
	    'button27
	    '
	    Me.button27.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button27.Location = New System.Drawing.Point(129, 155)
	    Me.button27.Name = "button27"
	    Me.button27.Size = New System.Drawing.Size(36, 30)
	    Me.button27.TabIndex = 26
	    Me.button27.Text = "M+"
	    Me.button27.UseVisualStyleBackColor = true
	    '
	    'button28
	    '
	    Me.button28.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.button28.Location = New System.Drawing.Point(171, 155)
	    Me.button28.Name = "button28"
	    Me.button28.Size = New System.Drawing.Size(36, 30)
	    Me.button28.TabIndex = 27
	    Me.button28.Text = "M-"
	    Me.button28.UseVisualStyleBackColor = true
	    '
	    'richTextBoxInput
	    '
	    Me.richTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None
	    Me.tableLayoutPanel1.SetColumnSpan(Me.richTextBoxInput, 5)
	    Me.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.richTextBoxInput.Location = New System.Drawing.Point(3, 115)
	    Me.richTextBoxInput.Multiline = false
	    Me.richTextBoxInput.Name = "richTextBoxInput"
	    Me.richTextBoxInput.Size = New System.Drawing.Size(204, 34)
	    Me.richTextBoxInput.TabIndex = 28
	    Me.richTextBoxInput.Text = ""
	    Me.richTextBoxInput.ZoomFactor = 2!
	    '
	    'richTextBoxOutput
	    '
	    Me.richTextBoxOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
	    Me.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
	    Me.tableLayoutPanel1.SetColumnSpan(Me.richTextBoxOutput, 5)
	    Me.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.richTextBoxOutput.Enabled = false
	    Me.richTextBoxOutput.Location = New System.Drawing.Point(3, 3)
	    Me.richTextBoxOutput.Name = "richTextBoxOutput"
	    Me.richTextBoxOutput.ReadOnly = true
	    Me.richTextBoxOutput.Size = New System.Drawing.Size(204, 106)
	    Me.richTextBoxOutput.TabIndex = 29
	    Me.richTextBoxOutput.Text = "3.1345345345"
	    Me.richTextBoxOutput.ZoomFactor = 2!
	    '
	    'CalculatorForm
	    '
	    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
	    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	    Me.ClientSize = New System.Drawing.Size(210, 392)
	    Me.Controls.Add(Me.tableLayoutPanel1)
	    Me.Controls.Add(Me.menuStrip1)
	    Me.MainMenuStrip = Me.menuStrip1
	    Me.MaximumSize = New System.Drawing.Size(226, 430)
	    Me.MinimumSize = New System.Drawing.Size(226, 430)
	    Me.Name = "CalculatorForm"
	    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	    Me.Text = "mpCalculator"
	    Me.menuStrip1.ResumeLayout(false)
	    Me.menuStrip1.PerformLayout
	    Me.tableLayoutPanel1.ResumeLayout(false)
	    Me.ResumeLayout(false)
	    Me.PerformLayout
	End Sub
	Private showDirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private displayRegistryEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private removeRegistryEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private setRegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private aboutCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private viewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private clearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private cancelEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private copyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private datasetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private worksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private dateCalculationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private unitConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private basicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private digitGroupingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private historyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private statisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private programmerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private scientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private standardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private richTextBoxOutput As System.Windows.Forms.RichTextBox
	Private richTextBoxInput As System.Windows.Forms.RichTextBox
	Private button28 As System.Windows.Forms.Button
	Private button27 As System.Windows.Forms.Button
	Private button26 As System.Windows.Forms.Button
	Private button25 As System.Windows.Forms.Button
	Private button24 As System.Windows.Forms.Button
	Private button23 As System.Windows.Forms.Button
	Private button22 As System.Windows.Forms.Button
	Private button21 As System.Windows.Forms.Button
	Private button20 As System.Windows.Forms.Button
	Private button19 As System.Windows.Forms.Button
	Private button18 As System.Windows.Forms.Button
	Private button17 As System.Windows.Forms.Button
	Private button16 As System.Windows.Forms.Button
	Private button15 As System.Windows.Forms.Button
	Private button14 As System.Windows.Forms.Button
	Private button13 As System.Windows.Forms.Button
	Private button12 As System.Windows.Forms.Button
	Private button11 As System.Windows.Forms.Button
	Private button10 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button8 As System.Windows.Forms.Button
	Private button7 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private btnEqual As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private viewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
