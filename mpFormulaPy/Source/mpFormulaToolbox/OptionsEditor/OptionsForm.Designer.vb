'Namespace OptionsEditor
	Partial Class OptionsForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visual Basic 2010")
			Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C# 4.0")
			Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JScript 2010")
			Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VBScript (WSH)")
			Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JScript (WSH)")
			Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SQLite3 Module")
			Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Batch")
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
			Me.btnOK = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnLoad = New System.Windows.Forms.Button()
			Me.btnAddins = New System.Windows.Forms.Button()
			Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
			Me.treeView1 = New System.Windows.Forms.TreeView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.tableLayoutPanel1.SuspendLayout
			Me.tableLayoutPanel2.SuspendLayout
			Me.tableLayoutPanel3.SuspendLayout
			Me.SuspendLayout
			'
			'btnOK
			'
			Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnOK.Location = New System.Drawing.Point(446, 3)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New System.Drawing.Size(75, 23)
			Me.btnOK.TabIndex = 0
			Me.btnOK.Text = "OK"
			Me.btnOK.UseVisualStyleBackColor = true
			AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
			'
			'btnCancel
			'
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(536, 3)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(75, 23)
			Me.btnCancel.TabIndex = 1
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = true
			AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
			'
			'propertyGrid1
			'
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.Location = New System.Drawing.Point(174, 3)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(446, 406)
			Me.propertyGrid1.TabIndex = 2
			'
			'tableLayoutPanel1
			'
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel3, 0, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.07049!))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.929515!))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(629, 454)
			Me.tableLayoutPanel1.TabIndex = 3
			'
			'tableLayoutPanel2
			'
			Me.tableLayoutPanel2.ColumnCount = 5
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
			Me.tableLayoutPanel2.Controls.Add(Me.btnCancel, 4, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.btnOK, 3, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.btnSave, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.btnLoad, 1, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.btnAddins, 2, 0)
			Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 421)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 1
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
			Me.tableLayoutPanel2.Size = New System.Drawing.Size(623, 30)
			Me.tableLayoutPanel2.TabIndex = 0
			'
			'btnSave
			'
			Me.btnSave.Location = New System.Drawing.Point(3, 3)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(69, 23)
			Me.btnSave.TabIndex = 2
			Me.btnSave.Text = "Save"
			Me.btnSave.UseVisualStyleBackColor = true
			AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
			'
			'btnLoad
			'
			Me.btnLoad.Location = New System.Drawing.Point(93, 3)
			Me.btnLoad.Name = "btnLoad"
			Me.btnLoad.Size = New System.Drawing.Size(71, 23)
			Me.btnLoad.TabIndex = 3
			Me.btnLoad.Text = "Load"
			Me.btnLoad.UseVisualStyleBackColor = true
			AddHandler Me.btnLoad.Click, AddressOf Me.btnLoad_Click
			'
			'btnAddins
			'
			Me.btnAddins.Location = New System.Drawing.Point(183, 3)
			Me.btnAddins.Name = "btnAddins"
			Me.btnAddins.Size = New System.Drawing.Size(134, 23)
			Me.btnAddins.TabIndex = 4
			Me.btnAddins.Text = "Spreadsheet Addins"
			Me.btnAddins.UseVisualStyleBackColor = true
			AddHandler Me.btnAddins.Click, AddressOf Me.BtnAddinsClick
			'
			'tableLayoutPanel3
			'
			Me.tableLayoutPanel3.ColumnCount = 2
			Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.58621!))
			Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.4138!))
			Me.tableLayoutPanel3.Controls.Add(Me.propertyGrid1, 1, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.treeView1, 0, 0)
			Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 1
			Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
			Me.tableLayoutPanel3.Size = New System.Drawing.Size(623, 412)
			Me.tableLayoutPanel3.TabIndex = 1
			'
			'treeView1
			'
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.HideSelection = false
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.imageList1
			Me.treeView1.ItemHeight = 20
			Me.treeView1.Location = New System.Drawing.Point(3, 3)
			Me.treeView1.Name = "treeView1"
			treeNode1.ImageKey = "DataVB_NET_Node.png"
			treeNode1.Name = "Visual_Basic_Node"
			treeNode1.SelectedImageKey = "DataVB_NET_Node.png"
			treeNode1.Tag = "Visual_Basic_Tag"
			treeNode1.Text = "Visual Basic 2010"
			treeNode2.ImageKey = "DataCPP_Native_Node.png"
			treeNode2.Name = "CSharp_Node"
			treeNode2.SelectedImageKey = "DataCPP_Native_Node.png"
			treeNode2.Tag = "CSharp_Tag"
			treeNode2.Text = "C# 4.0"
			treeNode3.ImageKey = "DataJScript10_Node.png"
			treeNode3.Name = "JScript_2010_Node"
			treeNode3.SelectedImageKey = "DataJScript10_Node.png"
			treeNode3.Tag = "JScript_2010_Tag"
			treeNode3.Text = "JScript 2010"
			treeNode4.ImageKey = "DataVBScript_Node.png"
			treeNode4.Name = "VBScript_Node"
			treeNode4.SelectedImageKey = "DataVBScript_Node.png"
			treeNode4.Tag = "VBScript_WSH_Tag"
			treeNode4.Text = "VBScript (WSH)"
			treeNode5.ImageKey = "DataJScript_Node.png"
			treeNode5.Name = "JScript_WSH_Node"
			treeNode5.SelectedImageKey = "DataJScript_Node.png"
			treeNode5.Tag = "JScript_WSH_Tag"
			treeNode5.Text = "JScript (WSH)"
			treeNode6.ImageKey = "DataSQL_Node.png"
			treeNode6.Name = "SQLite3_Module_Node"
			treeNode6.SelectedImageKey = "DataSQL_Node.png"
			treeNode6.Tag = "SQLite3_Module_Tag"
			treeNode6.Text = "SQLite3 Module"
			treeNode7.ImageKey = "DataBatch_Node.png"
			treeNode7.Name = "Batch_Node"
			treeNode7.SelectedImageKey = "DataBatch_Node.png"
			treeNode7.Tag = "Batch_Tag"
			treeNode7.Text = "Batch"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.Size = New System.Drawing.Size(165, 406)
			Me.treeView1.TabIndex = 3
			AddHandler Me.treeView1.AfterSelect, AddressOf Me.treeView1_AfterSelect
			'
			'imageList1
			'
			Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "DataCSharp_Node.png")
			Me.imageList1.Images.SetKeyName(1, "DataGnuplot_Node.png")
			Me.imageList1.Images.SetKeyName(2, "DataNETCharts_Node.png")
			Me.imageList1.Images.SetKeyName(3, "DataIndexes_Node.png")
			Me.imageList1.Images.SetKeyName(4, "DataTables_Node.png")
			Me.imageList1.Images.SetKeyName(5, "DataTriggers_Node.png")
			Me.imageList1.Images.SetKeyName(6, "DataViews_Node.png")
			Me.imageList1.Images.SetKeyName(7, "folder_database.png")
			Me.imageList1.Images.SetKeyName(8, "folder_page.png")
			Me.imageList1.Images.SetKeyName(9, "folder.png")
			Me.imageList1.Images.SetKeyName(10, "DataHTML_Node.png")
			Me.imageList1.Images.SetKeyName(11, "DataXML_Node.png")
			Me.imageList1.Images.SetKeyName(12, "DataCSS_Node.png")
			Me.imageList1.Images.SetKeyName(13, "folder_page_white.png")
			Me.imageList1.Images.SetKeyName(14, "DataBatch_Node.png")
			Me.imageList1.Images.SetKeyName(15, "DataR_Node.png")
			Me.imageList1.Images.SetKeyName(16, "DataVBScript_Node.png")
			Me.imageList1.Images.SetKeyName(17, "DataJScript_Node.png")
			Me.imageList1.Images.SetKeyName(18, "DataCPP_Node.png")
			Me.imageList1.Images.SetKeyName(19, "DataJava_Node.png")
			Me.imageList1.Images.SetKeyName(20, "DataRuby_Node.png")
			Me.imageList1.Images.SetKeyName(21, "DataPython_Node.png")
			Me.imageList1.Images.SetKeyName(22, "DataLua_Node.png")
			Me.imageList1.Images.SetKeyName(23, "DataPerl_Node.png")
			Me.imageList1.Images.SetKeyName(24, "DataPHP_Node.png")
			Me.imageList1.Images.SetKeyName(25, "DataMatlab_Node.png")
			Me.imageList1.Images.SetKeyName(26, "DataSQL_Node.png")
			Me.imageList1.Images.SetKeyName(27, "DataVB_NET_Node.png")
			Me.imageList1.Images.SetKeyName(28, "DataSystemTables_Node.png")
			Me.imageList1.Images.SetKeyName(29, "DataPictures_Node.png")
			Me.imageList1.Images.SetKeyName(30, "")
			Me.imageList1.Images.SetKeyName(31, "DataCPP_Native_Node.png")
			Me.imageList1.Images.SetKeyName(32, "DataGCC_CPP_Node.png")
			Me.imageList1.Images.SetKeyName(33, "DataIronPython_Node.png")
			Me.imageList1.Images.SetKeyName(34, "DataJScript10_Node.png")
			'
			'OptionsForm
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(629, 454)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "OptionsForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "mpFormula Options"
			AddHandler Load, AddressOf Me.Form2_Load
			Me.tableLayoutPanel1.ResumeLayout(false)
			Me.tableLayoutPanel2.ResumeLayout(false)
			Me.tableLayoutPanel3.ResumeLayout(false)
			Me.ResumeLayout(false)
		End Sub
		Private btnAddins As System.Windows.Forms.Button

		#End Region

		Private btnOK As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
		Private treeView1 As System.Windows.Forms.TreeView
		Private imageList1 As System.Windows.Forms.ImageList
		Private btnSave As System.Windows.Forms.Button
		Private btnLoad As System.Windows.Forms.Button
	End Class
'End Namespace
