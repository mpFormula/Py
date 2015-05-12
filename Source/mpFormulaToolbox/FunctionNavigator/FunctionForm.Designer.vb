	Partial Class FunctionsForm
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
		    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
		    Me.treeView1 = New System.Windows.Forms.TreeView()
		    Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		    Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.showManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.remeberLastPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.splitContainerFunctions = New System.Windows.Forms.SplitContainer()
		    Me.dirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.menuStrip1.SuspendLayout
		    CType(Me.splitContainerFunctions,System.ComponentModel.ISupportInitialize).BeginInit
		    Me.splitContainerFunctions.Panel1.SuspendLayout
		    Me.splitContainerFunctions.Panel2.SuspendLayout
		    Me.splitContainerFunctions.SuspendLayout
		    Me.SuspendLayout
		    '
		    'richTextBox1
		    '
		    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
		    Me.richTextBox1.Name = "richTextBox1"
		    Me.richTextBox1.Size = New System.Drawing.Size(316, 127)
		    Me.richTextBox1.TabIndex = 2
		    Me.richTextBox1.Text = ""
		    '
		    'treeView1
		    '
		    Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.treeView1.Location = New System.Drawing.Point(0, 0)
		    Me.treeView1.Name = "treeView1"
		    Me.treeView1.Size = New System.Drawing.Size(316, 359)
		    Me.treeView1.TabIndex = 1
		    AddHandler Me.treeView1.AfterSelect, AddressOf Me.treeView1_AfterSelect_1
		    '
		    'menuStrip1
		    '
		    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewToolStripMenuItem})
		    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		    Me.menuStrip1.Name = "menuStrip1"
		    Me.menuStrip1.Size = New System.Drawing.Size(316, 24)
		    Me.menuStrip1.TabIndex = 1
		    Me.menuStrip1.Text = "menuStrip1"
		    '
		    'viewToolStripMenuItem
		    '
		    Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showManualToolStripMenuItem, Me.remeberLastPositionToolStripMenuItem, Me.dirToolStripMenuItem})
		    Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
		    Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		    Me.viewToolStripMenuItem.Text = "View"
		    '
		    'showManualToolStripMenuItem
		    '
		    Me.showManualToolStripMenuItem.Name = "showManualToolStripMenuItem"
		    Me.showManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
		    Me.showManualToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
		    Me.showManualToolStripMenuItem.Text = "Show Manual"
		    AddHandler Me.showManualToolStripMenuItem.Click, AddressOf Me.ShowManualToolStripMenuItemClick
		    '
		    'remeberLastPositionToolStripMenuItem
		    '
		    Me.remeberLastPositionToolStripMenuItem.Checked = true
		    Me.remeberLastPositionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		    Me.remeberLastPositionToolStripMenuItem.Name = "remeberLastPositionToolStripMenuItem"
		    Me.remeberLastPositionToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
		    Me.remeberLastPositionToolStripMenuItem.Text = "Remember last position"
		    '
		    'splitContainerFunctions
		    '
		    Me.splitContainerFunctions.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.splitContainerFunctions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		    Me.splitContainerFunctions.Location = New System.Drawing.Point(0, 24)
		    Me.splitContainerFunctions.Name = "splitContainerFunctions"
		    Me.splitContainerFunctions.Orientation = System.Windows.Forms.Orientation.Horizontal
		    '
		    'splitContainerFunctions.Panel1
		    '
		    Me.splitContainerFunctions.Panel1.Controls.Add(Me.treeView1)
		    '
		    'splitContainerFunctions.Panel2
		    '
		    Me.splitContainerFunctions.Panel2.Controls.Add(Me.richTextBox1)
		    Me.splitContainerFunctions.Size = New System.Drawing.Size(316, 490)
		    Me.splitContainerFunctions.SplitterDistance = 359
		    Me.splitContainerFunctions.TabIndex = 2
		    '
		    'dirToolStripMenuItem
		    '
		    Me.dirToolStripMenuItem.Name = "dirToolStripMenuItem"
		    Me.dirToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
		    Me.dirToolStripMenuItem.Text = "Dir"
		    AddHandler Me.dirToolStripMenuItem.Click, AddressOf Me.DirToolStripMenuItemClick
		    '
		    'FunctionsForm
		    '
		    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		    Me.ClientSize = New System.Drawing.Size(316, 514)
		    Me.Controls.Add(Me.splitContainerFunctions)
		    Me.Controls.Add(Me.menuStrip1)
		    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		    Me.MainMenuStrip = Me.menuStrip1
		    Me.Name = "FunctionsForm"
		    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		    Me.Text = "Function Navigator"
		    AddHandler FormClosing, AddressOf Me.FunctionsForm_FormClosing
		    AddHandler Load, AddressOf Me.FunctionsForm_Load
		    Me.menuStrip1.ResumeLayout(false)
		    Me.menuStrip1.PerformLayout
		    Me.splitContainerFunctions.Panel1.ResumeLayout(false)
		    Me.splitContainerFunctions.Panel2.ResumeLayout(false)
		    CType(Me.splitContainerFunctions,System.ComponentModel.ISupportInitialize).EndInit
		    Me.splitContainerFunctions.ResumeLayout(false)
		    Me.ResumeLayout(false)
		    Me.PerformLayout
		End Sub
		Private dirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private splitContainerFunctions As System.Windows.Forms.SplitContainer
		Private remeberLastPositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private showManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private viewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private menuStrip1 As System.Windows.Forms.MenuStrip

		#End Region

		Private treeView1 As System.Windows.Forms.TreeView
		Private richTextBox1 As System.Windows.Forms.RichTextBox
	End Class
