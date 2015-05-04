'
' Created by SharpDevelop.
' User: dhadler
' Date: 06/05/2014
' Time: 14:13
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Partial Class MainForm
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
	    Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.importExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.importAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
	    Me.hTMLFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
	    Me.openRootDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.showToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.createToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
	    Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.calculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.functionNavigatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
	    Me.pythonConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
	    Me.ironPython32BitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.ironPython64BitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
	    Me.dInteractiveChartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
	    Me.setupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.compilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.sharpDevelopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
	    Me.codeblocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
	    Me.mSYS20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
	    Me.showMpFormulaCManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexStudioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexnicCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
	    Me.editWithTexStudioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
	    Me.aboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
	    Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
	    Me.dataGridView1 = New System.Windows.Forms.DataGridView()
	    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
	    Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
	    Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
	    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
	    Me.menuStrip1.SuspendLayout
	    Me.toolStripContainer1.ContentPanel.SuspendLayout
	    Me.toolStripContainer1.SuspendLayout
	    Me.tableLayoutPanel1.SuspendLayout
	    CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
	    Me.SuspendLayout
	    '
	    'menuStrip1
	    '
	    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem, Me.compilerToolStripMenuItem, Me.helpToolStripMenuItem})
	    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
	    Me.menuStrip1.Name = "menuStrip1"
	    Me.menuStrip1.Size = New System.Drawing.Size(668, 24)
	    Me.menuStrip1.TabIndex = 1
	    Me.menuStrip1.Text = "menuStrip1"
	    '
	    'fileToolStripMenuItem
	    '
	    Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.importExcelToolStripMenuItem, Me.importAccessToolStripMenuItem, Me.toolStripSeparator4, Me.hTMLFilesToolStripMenuItem, Me.toolStripSeparator3, Me.openRootDirectoryToolStripMenuItem, Me.toolStripSeparator5, Me.exitToolStripMenuItem})
	    Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
	    Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
	    Me.fileToolStripMenuItem.Text = "File"
	    '
	    'importExcelToolStripMenuItem
	    '
	    Me.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem"
	    Me.importExcelToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	    Me.importExcelToolStripMenuItem.Text = "Open Excel Files"
	    AddHandler Me.importExcelToolStripMenuItem.Click, AddressOf Me.ImportExcelToolStripMenuItemClick
	    '
	    'importAccessToolStripMenuItem
	    '
	    Me.importAccessToolStripMenuItem.Name = "importAccessToolStripMenuItem"
	    Me.importAccessToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	    Me.importAccessToolStripMenuItem.Text = "Open Access Files"
	    AddHandler Me.importAccessToolStripMenuItem.Click, AddressOf Me.ImportAccessToolStripMenuItemClick
	    '
	    'toolStripSeparator4
	    '
	    Me.toolStripSeparator4.Name = "toolStripSeparator4"
	    Me.toolStripSeparator4.Size = New System.Drawing.Size(165, 6)
	    '
	    'hTMLFilesToolStripMenuItem
	    '
	    Me.hTMLFilesToolStripMenuItem.Name = "hTMLFilesToolStripMenuItem"
	    Me.hTMLFilesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	    Me.hTMLFilesToolStripMenuItem.Text = "Open HTML Files"
	    AddHandler Me.hTMLFilesToolStripMenuItem.Click, AddressOf Me.HTMLFilesToolStripMenuItemClick
	    '
	    'toolStripSeparator3
	    '
	    Me.toolStripSeparator3.Name = "toolStripSeparator3"
	    Me.toolStripSeparator3.Size = New System.Drawing.Size(165, 6)
	    '
	    'openRootDirectoryToolStripMenuItem
	    '
	    Me.openRootDirectoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.showToolStripMenuItem, Me.createToolStripMenuItem, Me.deleteToolStripMenuItem})
	    Me.openRootDirectoryToolStripMenuItem.Name = "openRootDirectoryToolStripMenuItem"
	    Me.openRootDirectoryToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	    Me.openRootDirectoryToolStripMenuItem.Text = "Root Directory"
	    '
	    'openToolStripMenuItem
	    '
	    Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
	    Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.openToolStripMenuItem.Text = "Open"
	    AddHandler Me.openToolStripMenuItem.Click, AddressOf Me.OpenToolStripMenuItemClick
	    '
	    'showToolStripMenuItem
	    '
	    Me.showToolStripMenuItem.Name = "showToolStripMenuItem"
	    Me.showToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.showToolStripMenuItem.Text = "Show"
	    AddHandler Me.showToolStripMenuItem.Click, AddressOf Me.ShowToolStripMenuItemClick
	    '
	    'createToolStripMenuItem
	    '
	    Me.createToolStripMenuItem.Name = "createToolStripMenuItem"
	    Me.createToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.createToolStripMenuItem.Text = "Create"
	    AddHandler Me.createToolStripMenuItem.Click, AddressOf Me.CreateToolStripMenuItemClick
	    '
	    'deleteToolStripMenuItem
	    '
	    Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
	    Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
	    Me.deleteToolStripMenuItem.Text = "Delete"
	    AddHandler Me.deleteToolStripMenuItem.Click, AddressOf Me.DeleteToolStripMenuItemClick
	    '
	    'toolStripSeparator5
	    '
	    Me.toolStripSeparator5.Name = "toolStripSeparator5"
	    Me.toolStripSeparator5.Size = New System.Drawing.Size(165, 6)
	    '
	    'exitToolStripMenuItem
	    '
	    Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
	    Me.exitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	    Me.exitToolStripMenuItem.Text = "Exit"
	    '
	    'toolsToolStripMenuItem
	    '
	    Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.calculatorToolStripMenuItem, Me.functionNavigatorToolStripMenuItem, Me.toolStripSeparator1, Me.pythonConsoleToolStripMenuItem, Me.toolStripSeparator2, Me.ironPython32BitToolStripMenuItem, Me.ironPython64BitToolStripMenuItem, Me.toolStripSeparator6, Me.dInteractiveChartsToolStripMenuItem, Me.toolStripSeparator7, Me.setupToolStripMenuItem})
	    Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
	    Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
	    Me.toolsToolStripMenuItem.Text = "Tools"
	    '
	    'calculatorToolStripMenuItem
	    '
	    Me.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem"
	    Me.calculatorToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.calculatorToolStripMenuItem.Text = "Calculator"
	    AddHandler Me.calculatorToolStripMenuItem.Click, AddressOf Me.CalculatorToolStripMenuItemClick
	    '
	    'functionNavigatorToolStripMenuItem
	    '
	    Me.functionNavigatorToolStripMenuItem.Name = "functionNavigatorToolStripMenuItem"
	    Me.functionNavigatorToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.functionNavigatorToolStripMenuItem.Text = "Function Navigator"
	    AddHandler Me.functionNavigatorToolStripMenuItem.Click, AddressOf Me.FunctionNavigatorToolStripMenuItemClick
	    '
	    'toolStripSeparator1
	    '
	    Me.toolStripSeparator1.Name = "toolStripSeparator1"
	    Me.toolStripSeparator1.Size = New System.Drawing.Size(230, 6)
	    '
	    'pythonConsoleToolStripMenuItem
	    '
	    Me.pythonConsoleToolStripMenuItem.Name = "pythonConsoleToolStripMenuItem"
	    Me.pythonConsoleToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.pythonConsoleToolStripMenuItem.Text = "Sharpdevelop Python Console"
	    AddHandler Me.pythonConsoleToolStripMenuItem.Click, AddressOf Me.PythonConsoleToolStripMenuItemClick
	    '
	    'toolStripSeparator2
	    '
	    Me.toolStripSeparator2.Name = "toolStripSeparator2"
	    Me.toolStripSeparator2.Size = New System.Drawing.Size(230, 6)
	    '
	    'ironPython32BitToolStripMenuItem
	    '
	    Me.ironPython32BitToolStripMenuItem.Name = "ironPython32BitToolStripMenuItem"
	    Me.ironPython32BitToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.ironPython32BitToolStripMenuItem.Text = "IronPython Console 32 bit"
	    AddHandler Me.ironPython32BitToolStripMenuItem.Click, AddressOf Me.IronPython32BitToolStripMenuItemClick
	    '
	    'ironPython64BitToolStripMenuItem
	    '
	    Me.ironPython64BitToolStripMenuItem.Name = "ironPython64BitToolStripMenuItem"
	    Me.ironPython64BitToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.ironPython64BitToolStripMenuItem.Text = "IronPython Console 64 bit"
	    AddHandler Me.ironPython64BitToolStripMenuItem.Click, AddressOf Me.IronPython64BitToolStripMenuItemClick
	    '
	    'toolStripSeparator6
	    '
	    Me.toolStripSeparator6.Name = "toolStripSeparator6"
	    Me.toolStripSeparator6.Size = New System.Drawing.Size(230, 6)
	    '
	    'dInteractiveChartsToolStripMenuItem
	    '
	    Me.dInteractiveChartsToolStripMenuItem.Name = "dInteractiveChartsToolStripMenuItem"
	    Me.dInteractiveChartsToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.dInteractiveChartsToolStripMenuItem.Text = "3D Interactive Charts"
	    AddHandler Me.dInteractiveChartsToolStripMenuItem.Click, AddressOf Me.DInteractiveChartsToolStripMenuItemClick
	    '
	    'toolStripSeparator7
	    '
	    Me.toolStripSeparator7.Name = "toolStripSeparator7"
	    Me.toolStripSeparator7.Size = New System.Drawing.Size(230, 6)
	    '
	    'setupToolStripMenuItem
	    '
	    Me.setupToolStripMenuItem.Name = "setupToolStripMenuItem"
	    Me.setupToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
	    Me.setupToolStripMenuItem.Text = "Setup ..."
	    AddHandler Me.setupToolStripMenuItem.Click, AddressOf Me.SetupToolStripMenuItemClick
	    '
	    'compilerToolStripMenuItem
	    '
	    Me.compilerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sharpDevelopToolStripMenuItem, Me.toolStripSeparator8, Me.codeblocksToolStripMenuItem, Me.toolStripSeparator9, Me.mSYS20ToolStripMenuItem})
	    Me.compilerToolStripMenuItem.Name = "compilerToolStripMenuItem"
	    Me.compilerToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
	    Me.compilerToolStripMenuItem.Text = "Compiler"
	    '
	    'sharpDevelopToolStripMenuItem
	    '
	    Me.sharpDevelopToolStripMenuItem.Name = "sharpDevelopToolStripMenuItem"
	    Me.sharpDevelopToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
	    Me.sharpDevelopToolStripMenuItem.Text = "SharpDevelop"
	    AddHandler Me.sharpDevelopToolStripMenuItem.Click, AddressOf Me.SharpDevelopToolStripMenuItemClick
	    '
	    'toolStripSeparator8
	    '
	    Me.toolStripSeparator8.Name = "toolStripSeparator8"
	    Me.toolStripSeparator8.Size = New System.Drawing.Size(144, 6)
	    '
	    'codeblocksToolStripMenuItem
	    '
	    Me.codeblocksToolStripMenuItem.Name = "codeblocksToolStripMenuItem"
	    Me.codeblocksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
	    Me.codeblocksToolStripMenuItem.Text = "Codeblocks"
	    AddHandler Me.codeblocksToolStripMenuItem.Click, AddressOf Me.CodeblocksToolStripMenuItemClick
	    '
	    'toolStripSeparator9
	    '
	    Me.toolStripSeparator9.Name = "toolStripSeparator9"
	    Me.toolStripSeparator9.Size = New System.Drawing.Size(144, 6)
	    '
	    'mSYS20ToolStripMenuItem
	    '
	    Me.mSYS20ToolStripMenuItem.Name = "mSYS20ToolStripMenuItem"
	    Me.mSYS20ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
	    Me.mSYS20ToolStripMenuItem.Text = "MSYS 2.0"
	    AddHandler Me.mSYS20ToolStripMenuItem.Click, AddressOf Me.MSYS20ToolStripMenuItemClick
	    '
	    'helpToolStripMenuItem
	    '
	    Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.editWithTexStudioToolStripMenuItem, Me.editWithToolStripMenuItem, Me.toolStripSeparator10, Me.showMpFormulaCManualToolStripMenuItem, Me.editWithTexStudioToolStripMenuItem1, Me.editWithTexnicCenterToolStripMenuItem, Me.toolStripSeparator11, Me.editWithTexStudioToolStripMenuItem2, Me.toolStripSeparator12, Me.aboutToolStripMenuItem1})
	    Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
	    Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
	    Me.helpToolStripMenuItem.Text = "Help"
	    '
	    'aboutToolStripMenuItem
	    '
	    Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
	    Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
	    Me.aboutToolStripMenuItem.Text = "Show mpFormula Manual"
	    AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
	    '
	    'editWithTexStudioToolStripMenuItem
	    '
	    Me.editWithTexStudioToolStripMenuItem.Name = "editWithTexStudioToolStripMenuItem"
	    Me.editWithTexStudioToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
	    Me.editWithTexStudioToolStripMenuItem.Text = "Edit with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem.Click, AddressOf Me.EditWithTexStudioToolStripMenuItemClick
	    '
	    'editWithToolStripMenuItem
	    '
	    Me.editWithToolStripMenuItem.Name = "editWithToolStripMenuItem"
	    Me.editWithToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
	    Me.editWithToolStripMenuItem.Text = "Edit with TexnicCenter"
	    AddHandler Me.editWithToolStripMenuItem.Click, AddressOf Me.EditWithToolStripMenuItemClick
	    '
	    'toolStripSeparator10
	    '
	    Me.toolStripSeparator10.Name = "toolStripSeparator10"
	    Me.toolStripSeparator10.Size = New System.Drawing.Size(219, 6)
	    '
	    'showMpFormulaCManualToolStripMenuItem
	    '
	    Me.showMpFormulaCManualToolStripMenuItem.Name = "showMpFormulaCManualToolStripMenuItem"
	    Me.showMpFormulaCManualToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
	    Me.showMpFormulaCManualToolStripMenuItem.Text = "Show mpFormulaC Manual"
	    AddHandler Me.showMpFormulaCManualToolStripMenuItem.Click, AddressOf Me.ShowMpFormulaCManualToolStripMenuItemClick
	    '
	    'editWithTexStudioToolStripMenuItem1
	    '
	    Me.editWithTexStudioToolStripMenuItem1.Name = "editWithTexStudioToolStripMenuItem1"
	    Me.editWithTexStudioToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
	    Me.editWithTexStudioToolStripMenuItem1.Text = "Edit with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem1.Click, AddressOf Me.EditWithTexStudioToolStripMenuItem1Click
	    '
	    'editWithTexnicCenterToolStripMenuItem
	    '
	    Me.editWithTexnicCenterToolStripMenuItem.Name = "editWithTexnicCenterToolStripMenuItem"
	    Me.editWithTexnicCenterToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
	    Me.editWithTexnicCenterToolStripMenuItem.Text = "Edit with TexnicCenter"
	    AddHandler Me.editWithTexnicCenterToolStripMenuItem.Click, AddressOf Me.EditWithTexnicCenterToolStripMenuItemClick
	    '
	    'toolStripSeparator11
	    '
	    Me.toolStripSeparator11.Name = "toolStripSeparator11"
	    Me.toolStripSeparator11.Size = New System.Drawing.Size(219, 6)
	    '
	    'editWithTexStudioToolStripMenuItem2
	    '
	    Me.editWithTexStudioToolStripMenuItem2.Name = "editWithTexStudioToolStripMenuItem2"
	    Me.editWithTexStudioToolStripMenuItem2.Size = New System.Drawing.Size(222, 22)
	    Me.editWithTexStudioToolStripMenuItem2.Text = "Edit PgfPlots with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem2.Click, AddressOf Me.EditWithTexStudioToolStripMenuItem2Click
	    '
	    'toolStripSeparator12
	    '
	    Me.toolStripSeparator12.Name = "toolStripSeparator12"
	    Me.toolStripSeparator12.Size = New System.Drawing.Size(219, 6)
	    '
	    'aboutToolStripMenuItem1
	    '
	    Me.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1"
	    Me.aboutToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
	    Me.aboutToolStripMenuItem1.Text = "About"
	    '
	    'toolStripContainer1
	    '
	    '
	    'toolStripContainer1.ContentPanel
	    '
	    Me.toolStripContainer1.ContentPanel.Controls.Add(Me.tableLayoutPanel1)
	    Me.toolStripContainer1.ContentPanel.Controls.Add(Me.statusStrip1)
	    Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(668, 475)
	    Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.toolStripContainer1.Location = New System.Drawing.Point(0, 24)
	    Me.toolStripContainer1.Name = "toolStripContainer1"
	    Me.toolStripContainer1.Size = New System.Drawing.Size(668, 500)
	    Me.toolStripContainer1.TabIndex = 2
	    Me.toolStripContainer1.Text = "toolStripContainer1"
	    '
	    'tableLayoutPanel1
	    '
	    Me.tableLayoutPanel1.ColumnCount = 2
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
	    Me.tableLayoutPanel1.Controls.Add(Me.dataGridView1, 1, 0)
	    Me.tableLayoutPanel1.Controls.Add(Me.richTextBox1, 1, 1)
	    Me.tableLayoutPanel1.Controls.Add(Me.checkedListBox1, 0, 0)
	    Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
	    Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
	    Me.tableLayoutPanel1.RowCount = 2
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0!))
	    Me.tableLayoutPanel1.Size = New System.Drawing.Size(668, 453)
	    Me.tableLayoutPanel1.TabIndex = 2
	    '
	    'dataGridView1
	    '
	    Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	    Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.dataGridView1.Location = New System.Drawing.Point(123, 3)
	    Me.dataGridView1.Name = "dataGridView1"
	    Me.dataGridView1.Size = New System.Drawing.Size(542, 447)
	    Me.dataGridView1.TabIndex = 1
	    '
	    'richTextBox1
	    '
	    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.richTextBox1.Location = New System.Drawing.Point(123, 456)
	    Me.richTextBox1.Name = "richTextBox1"
	    Me.richTextBox1.Size = New System.Drawing.Size(542, 1)
	    Me.richTextBox1.TabIndex = 2
	    Me.richTextBox1.Text = ""
	    '
	    'checkedListBox1
	    '
	    Me.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.checkedListBox1.FormattingEnabled = true
	    Me.checkedListBox1.Location = New System.Drawing.Point(3, 3)
	    Me.checkedListBox1.Name = "checkedListBox1"
	    Me.checkedListBox1.Size = New System.Drawing.Size(114, 447)
	    Me.checkedListBox1.TabIndex = 3
	    AddHandler Me.checkedListBox1.SelectedIndexChanged, AddressOf Me.CheckedListBox1SelectedIndexChanged
	    '
	    'statusStrip1
	    '
	    Me.statusStrip1.Location = New System.Drawing.Point(0, 453)
	    Me.statusStrip1.Name = "statusStrip1"
	    Me.statusStrip1.Size = New System.Drawing.Size(668, 22)
	    Me.statusStrip1.TabIndex = 0
	    Me.statusStrip1.Text = "statusStrip1"
	    '
	    'openFileDialog1
	    '
	    Me.openFileDialog1.FileName = "openFileDialog1"
	    '
	    'MainForm
	    '
	    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
	    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	    Me.ClientSize = New System.Drawing.Size(668, 524)
	    Me.Controls.Add(Me.toolStripContainer1)
	    Me.Controls.Add(Me.menuStrip1)
	    Me.MainMenuStrip = Me.menuStrip1
	    Me.Name = "MainForm"
	    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	    Me.Text = "FileViewer"
	    Me.menuStrip1.ResumeLayout(false)
	    Me.menuStrip1.PerformLayout
	    Me.toolStripContainer1.ContentPanel.ResumeLayout(false)
	    Me.toolStripContainer1.ContentPanel.PerformLayout
	    Me.toolStripContainer1.ResumeLayout(false)
	    Me.toolStripContainer1.PerformLayout
	    Me.tableLayoutPanel1.ResumeLayout(false)
	    CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
	    Me.ResumeLayout(false)
	    Me.PerformLayout
	End Sub
	Private deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private createToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private aboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private editWithTexStudioToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private editWithTexnicCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editWithTexStudioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private showMpFormulaCManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private editWithToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editWithTexStudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mSYS20ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private codeblocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private sharpDevelopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private setupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private dInteractiveChartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private openRootDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private ironPython64BitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ironPython32BitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private pythonConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private functionNavigatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private calculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private hTMLFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private compilerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private checkedListBox1 As System.Windows.Forms.CheckedListBox
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private richTextBox1 As System.Windows.Forms.RichTextBox
	Friend dataGridView1 As System.Windows.Forms.DataGridView
	Friend tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private importAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private importExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	
End Class
