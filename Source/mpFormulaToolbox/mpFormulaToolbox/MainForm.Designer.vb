'
' Created by SharpDevelop.
' User: DH
' Date: 04/05/2014
' Time: 14:59
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
	    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
	    Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
	    Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.importExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.importAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.switchToReogridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.switchToDevelopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.functionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.outputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.hTMLViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.chartViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.pictureViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.dSurfacePlotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.switchToManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.registryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.createRootPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.deleteRootPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.readRootPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.testToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.foldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.rootDirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
	    Me.listView1 = New System.Windows.Forms.ListView()
	    Me.colName = New System.Windows.Forms.ColumnHeader()
	    Me.colDate = New System.Windows.Forms.ColumnHeader()
	    Me.colType = New System.Windows.Forms.ColumnHeader()
	    Me.colSize = New System.Windows.Forms.ColumnHeader()
	    Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
	    Me.importExcelToolStripButton = New System.Windows.Forms.ToolStripButton()
	    Me.CalculatorStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
	    Me.calculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.functionNavigatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
	    Me.sharpDevelopPythonConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
	    Me.ironpythonmpMath32BitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.ironpythonmpMath64BitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
	    Me.switchToReogridToolStripButton = New System.Windows.Forms.ToolStripButton()
	    Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
	    Me.IDEStartertoolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
	    Me.NormalStarttoolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.startAsAdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
	    Me.codeblocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
	    Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
	    Me.ManualStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
	    Me.showManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
	    Me.showExtendedManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexStudioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editExtendedManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
	    Me.viewPgfPlotsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editWithTexStudioToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
	    Me.editPgpPlotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	    Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
	    Me.optionsToolStripButton = New System.Windows.Forms.ToolStripButton()
	    Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
	    Me.aboutToolStripButton = New System.Windows.Forms.ToolStripButton()
	    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
	    Me.menuStrip1.SuspendLayout
	    Me.toolStripContainer1.ContentPanel.SuspendLayout
	    Me.toolStripContainer1.TopToolStripPanel.SuspendLayout
	    Me.toolStripContainer1.SuspendLayout
	    Me.toolStrip1.SuspendLayout
	    Me.SuspendLayout
	    '
	    'menuStrip1
	    '
	    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem, Me.outputToolStripMenuItem, Me.helpToolStripMenuItem, Me.registryToolStripMenuItem, Me.foldersToolStripMenuItem})
	    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
	    Me.menuStrip1.Name = "menuStrip1"
	    Me.menuStrip1.Size = New System.Drawing.Size(455, 24)
	    Me.menuStrip1.TabIndex = 0
	    Me.menuStrip1.Text = "menuStrip1"
	    '
	    'fileToolStripMenuItem
	    '
	    Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.importExcelToolStripMenuItem, Me.importAccessToolStripMenuItem, Me.exitToolStripMenuItem})
	    Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
	    Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
	    Me.fileToolStripMenuItem.Text = "File"
	    '
	    'importExcelToolStripMenuItem
	    '
	    Me.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem"
	    Me.importExcelToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
	    Me.importExcelToolStripMenuItem.Text = "Import Excel"
	    AddHandler Me.importExcelToolStripMenuItem.Click, AddressOf Me.ImportExcelToolStripMenuItemClick
	    '
	    'importAccessToolStripMenuItem
	    '
	    Me.importAccessToolStripMenuItem.Name = "importAccessToolStripMenuItem"
	    Me.importAccessToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
	    Me.importAccessToolStripMenuItem.Text = "Import Access"
	    AddHandler Me.importAccessToolStripMenuItem.Click, AddressOf Me.ImportAccessToolStripMenuItemClick
	    '
	    'exitToolStripMenuItem
	    '
	    Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
	    Me.exitToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
	    Me.exitToolStripMenuItem.Text = "Exit"
	    AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItemClick
	    '
	    'toolsToolStripMenuItem
	    '
	    Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.switchToReogridToolStripMenuItem, Me.switchToDevelopToolStripMenuItem, Me.functionsToolStripMenuItem, Me.optionsToolStripMenuItem})
	    Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
	    Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
	    Me.toolsToolStripMenuItem.Text = "Tools"
	    '
	    'switchToReogridToolStripMenuItem
	    '
	    Me.switchToReogridToolStripMenuItem.Name = "switchToReogridToolStripMenuItem"
	    Me.switchToReogridToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
	    Me.switchToReogridToolStripMenuItem.Text = "Switch to Excel"
	    AddHandler Me.switchToReogridToolStripMenuItem.Click, AddressOf Me.SwitchToReogridToolStripMenuItemClick
	    '
	    'switchToDevelopToolStripMenuItem
	    '
	    Me.switchToDevelopToolStripMenuItem.Name = "switchToDevelopToolStripMenuItem"
	    Me.switchToDevelopToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
	    Me.switchToDevelopToolStripMenuItem.Text = "Switch to #Develop"
	    AddHandler Me.switchToDevelopToolStripMenuItem.Click, AddressOf Me.SwitchToDevelopToolStripMenuItemClick
	    '
	    'functionsToolStripMenuItem
	    '
	    Me.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem"
	    Me.functionsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
	    Me.functionsToolStripMenuItem.Text = "Functions..."
	    AddHandler Me.functionsToolStripMenuItem.Click, AddressOf Me.FunctionsToolStripMenuItemClick
	    '
	    'optionsToolStripMenuItem
	    '
	    Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
	    Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
	    Me.optionsToolStripMenuItem.Text = "Options..."
	    AddHandler Me.optionsToolStripMenuItem.Click, AddressOf Me.OptionsToolStripMenuItemClick
	    '
	    'outputToolStripMenuItem
	    '
	    Me.outputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hTMLViewerToolStripMenuItem, Me.chartViewerToolStripMenuItem, Me.pictureViewerToolStripMenuItem, Me.dSurfacePlotsToolStripMenuItem})
	    Me.outputToolStripMenuItem.Name = "outputToolStripMenuItem"
	    Me.outputToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
	    Me.outputToolStripMenuItem.Text = "Output"
	    '
	    'hTMLViewerToolStripMenuItem
	    '
	    Me.hTMLViewerToolStripMenuItem.Name = "hTMLViewerToolStripMenuItem"
	    Me.hTMLViewerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
	    Me.hTMLViewerToolStripMenuItem.Text = "HTML Viewer"
	    AddHandler Me.hTMLViewerToolStripMenuItem.Click, AddressOf Me.HTMLViewerToolStripMenuItemClick
	    '
	    'chartViewerToolStripMenuItem
	    '
	    Me.chartViewerToolStripMenuItem.Name = "chartViewerToolStripMenuItem"
	    Me.chartViewerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
	    Me.chartViewerToolStripMenuItem.Text = "Chart Viewer"
	    AddHandler Me.chartViewerToolStripMenuItem.Click, AddressOf Me.ChartViewerToolStripMenuItemClick
	    '
	    'pictureViewerToolStripMenuItem
	    '
	    Me.pictureViewerToolStripMenuItem.Name = "pictureViewerToolStripMenuItem"
	    Me.pictureViewerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
	    Me.pictureViewerToolStripMenuItem.Text = "Picture Viewer"
	    AddHandler Me.pictureViewerToolStripMenuItem.Click, AddressOf Me.PictureViewerToolStripMenuItemClick
	    '
	    'dSurfacePlotsToolStripMenuItem
	    '
	    Me.dSurfacePlotsToolStripMenuItem.Name = "dSurfacePlotsToolStripMenuItem"
	    Me.dSurfacePlotsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
	    Me.dSurfacePlotsToolStripMenuItem.Text = "3D WpfInWinForms"
	    AddHandler Me.dSurfacePlotsToolStripMenuItem.Click, AddressOf Me.DSurfacePlotsToolStripMenuItemClick
	    '
	    'helpToolStripMenuItem
	    '
	    Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.switchToManualToolStripMenuItem, Me.aboutToolStripMenuItem})
	    Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
	    Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
	    Me.helpToolStripMenuItem.Text = "Help"
	    '
	    'switchToManualToolStripMenuItem
	    '
	    Me.switchToManualToolStripMenuItem.Name = "switchToManualToolStripMenuItem"
	    Me.switchToManualToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
	    Me.switchToManualToolStripMenuItem.Text = "Switch to Manual"
	    AddHandler Me.switchToManualToolStripMenuItem.Click, AddressOf Me.SwitchToManualToolStripMenuItemClick
	    '
	    'aboutToolStripMenuItem
	    '
	    Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
	    Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
	    Me.aboutToolStripMenuItem.Text = "About..."
	    AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
	    '
	    'registryToolStripMenuItem
	    '
	    Me.registryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.createRootPathToolStripMenuItem, Me.deleteRootPathToolStripMenuItem, Me.readRootPathToolStripMenuItem, Me.testToolStripMenuItem})
	    Me.registryToolStripMenuItem.Name = "registryToolStripMenuItem"
	    Me.registryToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
	    Me.registryToolStripMenuItem.Text = "Registry"
	    '
	    'createRootPathToolStripMenuItem
	    '
	    Me.createRootPathToolStripMenuItem.Name = "createRootPathToolStripMenuItem"
	    Me.createRootPathToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
	    Me.createRootPathToolStripMenuItem.Text = "Create RootPath"
	    AddHandler Me.createRootPathToolStripMenuItem.Click, AddressOf Me.CreateRootPathToolStripMenuItemClick
	    '
	    'deleteRootPathToolStripMenuItem
	    '
	    Me.deleteRootPathToolStripMenuItem.Name = "deleteRootPathToolStripMenuItem"
	    Me.deleteRootPathToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
	    Me.deleteRootPathToolStripMenuItem.Text = "Delete RootPath"
	    AddHandler Me.deleteRootPathToolStripMenuItem.Click, AddressOf Me.DeleteRootPathToolStripMenuItemClick
	    '
	    'readRootPathToolStripMenuItem
	    '
	    Me.readRootPathToolStripMenuItem.Name = "readRootPathToolStripMenuItem"
	    Me.readRootPathToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
	    Me.readRootPathToolStripMenuItem.Text = "Read RootPath"
	    AddHandler Me.readRootPathToolStripMenuItem.Click, AddressOf Me.ReadRootPathToolStripMenuItemClick
	    '
	    'testToolStripMenuItem
	    '
	    Me.testToolStripMenuItem.Name = "testToolStripMenuItem"
	    Me.testToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
	    Me.testToolStripMenuItem.Text = "Test"
	    '
	    'foldersToolStripMenuItem
	    '
	    Me.foldersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rootDirToolStripMenuItem})
	    Me.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem"
	    Me.foldersToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
	    Me.foldersToolStripMenuItem.Text = "Folders"
	    '
	    'rootDirToolStripMenuItem
	    '
	    Me.rootDirToolStripMenuItem.Name = "rootDirToolStripMenuItem"
	    Me.rootDirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
	    Me.rootDirToolStripMenuItem.Text = "Root Dir"
	    AddHandler Me.rootDirToolStripMenuItem.Click, AddressOf Me.RootDirToolStripMenuItemClick
	    '
	    'toolStripContainer1
	    '
	    '
	    'toolStripContainer1.ContentPanel
	    '
	    Me.toolStripContainer1.ContentPanel.Controls.Add(Me.listView1)
	    Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(455, 373)
	    AddHandler Me.toolStripContainer1.ContentPanel.Load, AddressOf Me.ContentPanelLoad
	    Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.toolStripContainer1.Location = New System.Drawing.Point(0, 24)
	    Me.toolStripContainer1.Name = "toolStripContainer1"
	    Me.toolStripContainer1.Size = New System.Drawing.Size(455, 412)
	    Me.toolStripContainer1.TabIndex = 1
	    Me.toolStripContainer1.Text = "toolStripContainer1"
	    '
	    'toolStripContainer1.TopToolStripPanel
	    '
	    Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
	    '
	    'listView1
	    '
	    Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colDate, Me.colType, Me.colSize})
	    Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.listView1.Location = New System.Drawing.Point(0, 0)
	    Me.listView1.Name = "listView1"
	    Me.listView1.Size = New System.Drawing.Size(455, 373)
	    Me.listView1.TabIndex = 0
	    Me.listView1.UseCompatibleStateImageBehavior = false
	    Me.listView1.View = System.Windows.Forms.View.Details
	    '
	    'colName
	    '
	    Me.colName.Text = "Name"
	    '
	    'colDate
	    '
	    Me.colDate.Text = "Date modified"
	    '
	    'colType
	    '
	    Me.colType.Text = "Type"
	    '
	    'colSize
	    '
	    Me.colSize.Text = "Size"
	    '
	    'toolStrip1
	    '
	    Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
	    Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.importExcelToolStripButton, Me.CalculatorStripSplitButton, Me.toolStripSeparator1, Me.switchToReogridToolStripButton, Me.toolStripSeparator4, Me.IDEStartertoolStripSplitButton, Me.toolStripSeparator3, Me.ManualStripSplitButton, Me.toolStripSeparator2, Me.optionsToolStripButton, Me.toolStripSeparator5, Me.aboutToolStripButton})
	    Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
	    Me.toolStrip1.Name = "toolStrip1"
	    Me.toolStrip1.Size = New System.Drawing.Size(455, 39)
	    Me.toolStrip1.Stretch = true
	    Me.toolStrip1.TabIndex = 0
	    '
	    'importExcelToolStripButton
	    '
	    Me.importExcelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.importExcelToolStripButton.Image = CType(resources.GetObject("importExcelToolStripButton.Image"),System.Drawing.Image)
	    Me.importExcelToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.importExcelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.importExcelToolStripButton.Name = "importExcelToolStripButton"
	    Me.importExcelToolStripButton.Size = New System.Drawing.Size(36, 36)
	    Me.importExcelToolStripButton.Text = "Imports data from a Microsoft Excel Workbook"
	    AddHandler Me.importExcelToolStripButton.Click, AddressOf Me.ImportExcelToolStripButtonClick
	    '
	    'CalculatorStripSplitButton
	    '
	    Me.CalculatorStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.CalculatorStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.calculatorToolStripMenuItem, Me.functionNavigatorToolStripMenuItem, Me.toolStripSeparator11, Me.sharpDevelopPythonConsoleToolStripMenuItem, Me.toolStripSeparator12, Me.ironpythonmpMath32BitToolStripMenuItem, Me.ironpythonmpMath64BitToolStripMenuItem})
	    Me.CalculatorStripSplitButton.Image = CType(resources.GetObject("CalculatorStripSplitButton.Image"),System.Drawing.Image)
	    Me.CalculatorStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.CalculatorStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.CalculatorStripSplitButton.Name = "CalculatorStripSplitButton"
	    Me.CalculatorStripSplitButton.Size = New System.Drawing.Size(48, 36)
	    Me.CalculatorStripSplitButton.Text = "toolStripDropDownButton1"
	    AddHandler Me.CalculatorStripSplitButton.ButtonClick, AddressOf Me.CalculatorStripSplitButtonButtonClick
	    '
	    'calculatorToolStripMenuItem
	    '
	    Me.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem"
	    Me.calculatorToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.calculatorToolStripMenuItem.Text = "Calculator"
	    AddHandler Me.calculatorToolStripMenuItem.Click, AddressOf Me.CalculatorToolStripMenuItemClick
	    '
	    'functionNavigatorToolStripMenuItem
	    '
	    Me.functionNavigatorToolStripMenuItem.Name = "functionNavigatorToolStripMenuItem"
	    Me.functionNavigatorToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.functionNavigatorToolStripMenuItem.Text = "Function Navigator"
	    AddHandler Me.functionNavigatorToolStripMenuItem.Click, AddressOf Me.FunctionNavigatorToolStripMenuItemClick
	    '
	    'toolStripSeparator11
	    '
	    Me.toolStripSeparator11.Name = "toolStripSeparator11"
	    Me.toolStripSeparator11.Size = New System.Drawing.Size(265, 6)
	    '
	    'sharpDevelopPythonConsoleToolStripMenuItem
	    '
	    Me.sharpDevelopPythonConsoleToolStripMenuItem.Name = "sharpDevelopPythonConsoleToolStripMenuItem"
	    Me.sharpDevelopPythonConsoleToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.sharpDevelopPythonConsoleToolStripMenuItem.Text = "SharpDevelop Python Console"
	    AddHandler Me.sharpDevelopPythonConsoleToolStripMenuItem.Click, AddressOf Me.SharpDevelopPythonConsoleToolStripMenuItemClick
	    '
	    'toolStripSeparator12
	    '
	    Me.toolStripSeparator12.Name = "toolStripSeparator12"
	    Me.toolStripSeparator12.Size = New System.Drawing.Size(265, 6)
	    '
	    'ironpythonmpMath32BitToolStripMenuItem
	    '
	    Me.ironpythonmpMath32BitToolStripMenuItem.Name = "ironpythonmpMath32BitToolStripMenuItem"
	    Me.ironpythonmpMath32BitToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.ironpythonmpMath32BitToolStripMenuItem.Text = "Ironpython Console (mpMath) 32 bit"
	    AddHandler Me.ironpythonmpMath32BitToolStripMenuItem.Click, AddressOf Me.IronpythonmpMath32BitToolStripMenuItemClick
	    '
	    'ironpythonmpMath64BitToolStripMenuItem
	    '
	    Me.ironpythonmpMath64BitToolStripMenuItem.Name = "ironpythonmpMath64BitToolStripMenuItem"
	    Me.ironpythonmpMath64BitToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.ironpythonmpMath64BitToolStripMenuItem.Text = "Ironpython Console (mpMath) 64 bit"
	    AddHandler Me.ironpythonmpMath64BitToolStripMenuItem.Click, AddressOf Me.IronpythonmpMath64BitToolStripMenuItemClick
	    '
	    'toolStripSeparator1
	    '
	    Me.toolStripSeparator1.Name = "toolStripSeparator1"
	    Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 39)
	    '
	    'switchToReogridToolStripButton
	    '
	    Me.switchToReogridToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.switchToReogridToolStripButton.Image = CType(resources.GetObject("switchToReogridToolStripButton.Image"),System.Drawing.Image)
	    Me.switchToReogridToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.switchToReogridToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.switchToReogridToolStripButton.Name = "switchToReogridToolStripButton"
	    Me.switchToReogridToolStripButton.Size = New System.Drawing.Size(36, 36)
	    Me.switchToReogridToolStripButton.Text = "Switches to MS Excel with an empty mpFormula project"
	    AddHandler Me.switchToReogridToolStripButton.Click, AddressOf Me.SwitchToReogridToolStripButtonClick
	    '
	    'toolStripSeparator4
	    '
	    Me.toolStripSeparator4.Name = "toolStripSeparator4"
	    Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 39)
	    '
	    'IDEStartertoolStripSplitButton
	    '
	    Me.IDEStartertoolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.IDEStartertoolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalStarttoolStripMenuItem, Me.startAsAdministratorToolStripMenuItem, Me.toolStripSeparator10, Me.codeblocksToolStripMenuItem, Me.toolStripSeparator7, Me.toolStripMenuItem1, Me.toolStripMenuItem2})
	    Me.IDEStartertoolStripSplitButton.Image = CType(resources.GetObject("IDEStartertoolStripSplitButton.Image"),System.Drawing.Image)
	    Me.IDEStartertoolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.IDEStartertoolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.IDEStartertoolStripSplitButton.Name = "IDEStartertoolStripSplitButton"
	    Me.IDEStartertoolStripSplitButton.Size = New System.Drawing.Size(48, 36)
	    Me.IDEStartertoolStripSplitButton.Text = "Start #Develop "
	    AddHandler Me.IDEStartertoolStripSplitButton.ButtonClick, AddressOf Me.IDEStartertoolStripSplitButtonButtonClick
	    '
	    'NormalStarttoolStripMenuItem
	    '
	    Me.NormalStarttoolStripMenuItem.Name = "NormalStarttoolStripMenuItem"
	    Me.NormalStarttoolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.NormalStarttoolStripMenuItem.Text = "Sharp Develop: Normal start"
	    AddHandler Me.NormalStarttoolStripMenuItem.Click, AddressOf Me.NormalStarttoolStripMenuItemClick
	    '
	    'startAsAdministratorToolStripMenuItem
	    '
	    Me.startAsAdministratorToolStripMenuItem.Name = "startAsAdministratorToolStripMenuItem"
	    Me.startAsAdministratorToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.startAsAdministratorToolStripMenuItem.Text = "Sharp Develop: Start as administrator"
	    AddHandler Me.startAsAdministratorToolStripMenuItem.Click, AddressOf Me.StartAsAdministratorToolStripMenuItemClick
	    '
	    'toolStripSeparator10
	    '
	    Me.toolStripSeparator10.Name = "toolStripSeparator10"
	    Me.toolStripSeparator10.Size = New System.Drawing.Size(265, 6)
	    '
	    'codeblocksToolStripMenuItem
	    '
	    Me.codeblocksToolStripMenuItem.Name = "codeblocksToolStripMenuItem"
	    Me.codeblocksToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
	    Me.codeblocksToolStripMenuItem.Text = "Codeblocks"
	    AddHandler Me.codeblocksToolStripMenuItem.Click, AddressOf Me.CodeblocksToolStripMenuItemClick
	    '
	    'toolStripSeparator7
	    '
	    Me.toolStripSeparator7.Name = "toolStripSeparator7"
	    Me.toolStripSeparator7.Size = New System.Drawing.Size(265, 6)
	    '
	    'toolStripMenuItem1
	    '
	    Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
	    Me.toolStripMenuItem1.Size = New System.Drawing.Size(268, 22)
	    Me.toolStripMenuItem1.Text = "Start Msys 32 bit"
	    AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
	    '
	    'toolStripMenuItem2
	    '
	    Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
	    Me.toolStripMenuItem2.Size = New System.Drawing.Size(268, 22)
	    Me.toolStripMenuItem2.Text = "Start Msys 32 bit and Open folder"
	    AddHandler Me.toolStripMenuItem2.Click, AddressOf Me.ToolStripMenuItem2Click
	    '
	    'toolStripSeparator3
	    '
	    Me.toolStripSeparator3.Name = "toolStripSeparator3"
	    Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 39)
	    '
	    'ManualStripSplitButton
	    '
	    Me.ManualStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.ManualStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showManualToolStripMenuItem, Me.editWithTexStudioToolStripMenuItem, Me.editManualToolStripMenuItem, Me.toolStripSeparator6, Me.showExtendedManualToolStripMenuItem, Me.editWithTexStudioToolStripMenuItem1, Me.editExtendedManualToolStripMenuItem, Me.toolStripSeparator14, Me.viewPgfPlotsToolStripMenuItem1, Me.editWithTexStudioToolStripMenuItem3, Me.editPgpPlotsToolStripMenuItem})
	    Me.ManualStripSplitButton.Image = CType(resources.GetObject("ManualStripSplitButton.Image"),System.Drawing.Image)
	    Me.ManualStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.ManualStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.ManualStripSplitButton.Name = "ManualStripSplitButton"
	    Me.ManualStripSplitButton.Size = New System.Drawing.Size(48, 36)
	    Me.ManualStripSplitButton.Text = "mpFormula Manual"
	    AddHandler Me.ManualStripSplitButton.ButtonClick, AddressOf Me.ManualStripSplitButtonButtonClick
	    '
	    'showManualToolStripMenuItem
	    '
	    Me.showManualToolStripMenuItem.Name = "showManualToolStripMenuItem"
	    Me.showManualToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.showManualToolStripMenuItem.Text = "Show ""mpFormula"" Manual"
	    AddHandler Me.showManualToolStripMenuItem.Click, AddressOf Me.ShowManualToolStripMenuItemClick
	    '
	    'editWithTexStudioToolStripMenuItem
	    '
	    Me.editWithTexStudioToolStripMenuItem.Name = "editWithTexStudioToolStripMenuItem"
	    Me.editWithTexStudioToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.editWithTexStudioToolStripMenuItem.Text = "Edit with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem.Click, AddressOf Me.EditWithTexStudioToolStripMenuItemClick
	    '
	    'editManualToolStripMenuItem
	    '
	    Me.editManualToolStripMenuItem.Name = "editManualToolStripMenuItem"
	    Me.editManualToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.editManualToolStripMenuItem.Text = "Edit ""mpFormula"" Manual"
	    AddHandler Me.editManualToolStripMenuItem.Click, AddressOf Me.EditManualToolStripMenuItemClick
	    '
	    'toolStripSeparator6
	    '
	    Me.toolStripSeparator6.Name = "toolStripSeparator6"
	    Me.toolStripSeparator6.Size = New System.Drawing.Size(226, 6)
	    '
	    'showExtendedManualToolStripMenuItem
	    '
	    Me.showExtendedManualToolStripMenuItem.Name = "showExtendedManualToolStripMenuItem"
	    Me.showExtendedManualToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.showExtendedManualToolStripMenuItem.Text = "Show ""mpFormulaC"" Manual"
	    AddHandler Me.showExtendedManualToolStripMenuItem.Click, AddressOf Me.ShowExtendedManualToolStripMenuItemClick
	    '
	    'editWithTexStudioToolStripMenuItem1
	    '
	    Me.editWithTexStudioToolStripMenuItem1.Name = "editWithTexStudioToolStripMenuItem1"
	    Me.editWithTexStudioToolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
	    Me.editWithTexStudioToolStripMenuItem1.Text = "Edit with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem1.Click, AddressOf Me.EditWithTexStudioToolStripMenuItem1Click
	    '
	    'editExtendedManualToolStripMenuItem
	    '
	    Me.editExtendedManualToolStripMenuItem.Name = "editExtendedManualToolStripMenuItem"
	    Me.editExtendedManualToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.editExtendedManualToolStripMenuItem.Text = "Edit ""mpFormulaC"" Manual"
	    AddHandler Me.editExtendedManualToolStripMenuItem.Click, AddressOf Me.EditExtendedManualToolStripMenuItemClick
	    '
	    'toolStripSeparator14
	    '
	    Me.toolStripSeparator14.Name = "toolStripSeparator14"
	    Me.toolStripSeparator14.Size = New System.Drawing.Size(226, 6)
	    '
	    'viewPgfPlotsToolStripMenuItem1
	    '
	    Me.viewPgfPlotsToolStripMenuItem1.Name = "viewPgfPlotsToolStripMenuItem1"
	    Me.viewPgfPlotsToolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
	    Me.viewPgfPlotsToolStripMenuItem1.Text = "View PgfPlots Output"
	    AddHandler Me.viewPgfPlotsToolStripMenuItem1.Click, AddressOf Me.ViewPgfPlotsToolStripMenuItem1Click
	    '
	    'editWithTexStudioToolStripMenuItem3
	    '
	    Me.editWithTexStudioToolStripMenuItem3.Name = "editWithTexStudioToolStripMenuItem3"
	    Me.editWithTexStudioToolStripMenuItem3.Size = New System.Drawing.Size(229, 22)
	    Me.editWithTexStudioToolStripMenuItem3.Text = "Edit with TexStudio"
	    AddHandler Me.editWithTexStudioToolStripMenuItem3.Click, AddressOf Me.EditWithTexStudioToolStripMenuItem3Click
	    '
	    'editPgpPlotsToolStripMenuItem
	    '
	    Me.editPgpPlotsToolStripMenuItem.Name = "editPgpPlotsToolStripMenuItem"
	    Me.editPgpPlotsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
	    Me.editPgpPlotsToolStripMenuItem.Text = "Edit PgfPlots Source"
	    AddHandler Me.editPgpPlotsToolStripMenuItem.Click, AddressOf Me.EditPgpPlotsToolStripMenuItemClick
	    '
	    'toolStripSeparator2
	    '
	    Me.toolStripSeparator2.Name = "toolStripSeparator2"
	    Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 39)
	    '
	    'optionsToolStripButton
	    '
	    Me.optionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.optionsToolStripButton.Image = CType(resources.GetObject("optionsToolStripButton.Image"),System.Drawing.Image)
	    Me.optionsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.optionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.optionsToolStripButton.Name = "optionsToolStripButton"
	    Me.optionsToolStripButton.Size = New System.Drawing.Size(36, 36)
	    Me.optionsToolStripButton.Text = "Displays the Options Dialogue"
	    AddHandler Me.optionsToolStripButton.Click, AddressOf Me.OptionsToolStripButtonClick
	    '
	    'toolStripSeparator5
	    '
	    Me.toolStripSeparator5.Name = "toolStripSeparator5"
	    Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 39)
	    '
	    'aboutToolStripButton
	    '
	    Me.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.aboutToolStripButton.Image = CType(resources.GetObject("aboutToolStripButton.Image"),System.Drawing.Image)
	    Me.aboutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
	    Me.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
	    Me.aboutToolStripButton.Name = "aboutToolStripButton"
	    Me.aboutToolStripButton.Size = New System.Drawing.Size(36, 36)
	    Me.aboutToolStripButton.Text = "Displays the About Dialogue"
	    AddHandler Me.aboutToolStripButton.Click, AddressOf Me.AboutToolStripButtonClick
	    '
	    'openFileDialog1
	    '
	    Me.openFileDialog1.FileName = "openFileDialog1"
	    '
	    'MainForm
	    '
	    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
	    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	    Me.ClientSize = New System.Drawing.Size(455, 436)
	    Me.Controls.Add(Me.toolStripContainer1)
	    Me.Controls.Add(Me.menuStrip1)
	    Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
	    Me.MainMenuStrip = Me.menuStrip1
	    Me.Name = "MainForm"
	    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	    Me.Text = "mpFormula Toolbox 4.0"
	    Me.menuStrip1.ResumeLayout(false)
	    Me.menuStrip1.PerformLayout
	    Me.toolStripContainer1.ContentPanel.ResumeLayout(false)
	    Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(false)
	    Me.toolStripContainer1.TopToolStripPanel.PerformLayout
	    Me.toolStripContainer1.ResumeLayout(false)
	    Me.toolStripContainer1.PerformLayout
	    Me.toolStrip1.ResumeLayout(false)
	    Me.toolStrip1.PerformLayout
	    Me.ResumeLayout(false)
	    Me.PerformLayout
	End Sub
	Private editWithTexStudioToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
	Private editWithTexStudioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private editWithTexStudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private testToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private editPgpPlotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private viewPgfPlotsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private functionNavigatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private sharpDevelopPythonConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private calculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private CalculatorStripSplitButton As System.Windows.Forms.ToolStripSplitButton
	Private dSurfacePlotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private ironpythonmpMath64BitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ironpythonmpMath32BitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private editExtendedManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showExtendedManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private rootDirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private foldersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private codeblocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private readRootPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private deleteRootPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private createRootPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private registryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private editManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ManualStripSplitButton As System.Windows.Forms.ToolStripSplitButton
	Private startAsAdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private NormalStarttoolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private IDEStartertoolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
	Private pictureViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private chartViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private hTMLViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private outputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private colSize As System.Windows.Forms.ColumnHeader
	Private colType As System.Windows.Forms.ColumnHeader
	Private colDate As System.Windows.Forms.ColumnHeader
	Private colName As System.Windows.Forms.ColumnHeader
	Private listView1 As System.Windows.Forms.ListView
	Private aboutToolStripButton As System.Windows.Forms.ToolStripButton
	Private optionsToolStripButton As System.Windows.Forms.ToolStripButton
	Private switchToReogridToolStripButton As System.Windows.Forms.ToolStripButton
	Private importExcelToolStripButton As System.Windows.Forms.ToolStripButton
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private switchToManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private functionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private switchToDevelopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private switchToReogridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private importAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private importExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	

	
End Class
