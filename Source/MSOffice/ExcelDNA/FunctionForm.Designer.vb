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
		    Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		    Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		    Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
		    Me.treeView1 = New System.Windows.Forms.TreeView()
		    Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		    Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.showManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.remeberLastPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.findItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		    Me.splitContainerFunctions = New System.Windows.Forms.SplitContainer()
		    Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		    Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		    Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		    Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		    Me.btnCancel = New System.Windows.Forms.Button()
		    Me.btnOK = New System.Windows.Forms.Button()
		    Me.menuStrip1.SuspendLayout
		    CType(Me.splitContainerFunctions,System.ComponentModel.ISupportInitialize).BeginInit
		    Me.splitContainerFunctions.Panel1.SuspendLayout
		    Me.splitContainerFunctions.Panel2.SuspendLayout
		    Me.splitContainerFunctions.SuspendLayout
		    CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
		    Me.splitContainer1.Panel1.SuspendLayout
		    Me.splitContainer1.Panel2.SuspendLayout
		    Me.splitContainer1.SuspendLayout
		    CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		    Me.tableLayoutPanel1.SuspendLayout
		    Me.tableLayoutPanel2.SuspendLayout
		    Me.SuspendLayout
		    '
		    'richTextBox1
		    '
		    Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
		    Me.richTextBox1.Name = "richTextBox1"
		    Me.richTextBox1.ReadOnly = true
		    Me.richTextBox1.Size = New System.Drawing.Size(408, 131)
		    Me.richTextBox1.TabIndex = 1
		    Me.richTextBox1.TabStop = false
		    Me.richTextBox1.Text = ""
		    '
		    'treeView1
		    '
		    Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.treeView1.HideSelection = false
		    Me.treeView1.Location = New System.Drawing.Point(0, 0)
		    Me.treeView1.Name = "treeView1"
		    Me.treeView1.Size = New System.Drawing.Size(408, 284)
		    Me.treeView1.TabIndex = 0
		    AddHandler Me.treeView1.AfterSelect, AddressOf Me.treeView1_AfterSelect_1
		    '
		    'menuStrip1
		    '
		    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewToolStripMenuItem})
		    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		    Me.menuStrip1.Name = "menuStrip1"
		    Me.menuStrip1.Size = New System.Drawing.Size(414, 24)
		    Me.menuStrip1.TabIndex = 1
		    Me.menuStrip1.Text = "menuStrip1"
		    '
		    'viewToolStripMenuItem
		    '
		    Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showManualToolStripMenuItem, Me.remeberLastPositionToolStripMenuItem, Me.findItemToolStripMenuItem})
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
		    'findItemToolStripMenuItem
		    '
		    Me.findItemToolStripMenuItem.Name = "findItemToolStripMenuItem"
		    Me.findItemToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
		    Me.findItemToolStripMenuItem.Text = "FindItem"
		    AddHandler Me.findItemToolStripMenuItem.Click, AddressOf Me.FindItemToolStripMenuItemClick
		    '
		    'splitContainerFunctions
		    '
		    Me.splitContainerFunctions.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.splitContainerFunctions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		    Me.splitContainerFunctions.Location = New System.Drawing.Point(3, 3)
		    Me.splitContainerFunctions.Name = "splitContainerFunctions"
		    Me.splitContainerFunctions.Orientation = System.Windows.Forms.Orientation.Horizontal
		    '
		    'splitContainerFunctions.Panel1
		    '
		    Me.splitContainerFunctions.Panel1.Controls.Add(Me.treeView1)
		    '
		    'splitContainerFunctions.Panel2
		    '
		    Me.splitContainerFunctions.Panel2.Controls.Add(Me.splitContainer1)
		    Me.splitContainerFunctions.Size = New System.Drawing.Size(408, 564)
		    Me.splitContainerFunctions.SplitterDistance = 284
		    Me.splitContainerFunctions.TabIndex = 2
		    Me.splitContainerFunctions.TabStop = false
		    '
		    'splitContainer1
		    '
		    Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
		    Me.splitContainer1.Name = "splitContainer1"
		    Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		    '
		    'splitContainer1.Panel1
		    '
		    Me.splitContainer1.Panel1.Controls.Add(Me.richTextBox1)
		    '
		    'splitContainer1.Panel2
		    '
		    Me.splitContainer1.Panel2.Controls.Add(Me.dataGridView1)
		    Me.splitContainer1.Size = New System.Drawing.Size(408, 276)
		    Me.splitContainer1.SplitterDistance = 131
		    Me.splitContainer1.TabIndex = 3
		    Me.splitContainer1.TabStop = false
		    '
		    'dataGridView1
		    '
		    Me.dataGridView1.AllowUserToAddRows = false
		    Me.dataGridView1.AllowUserToDeleteRows = false
		    Me.dataGridView1.AllowUserToResizeRows = false
		    Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
		    dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		    dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		    dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		    dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		    dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		    dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		    dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		    Me.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		    Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		    Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
		    dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		    dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		    dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		    dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		    dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		    dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		    dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		    Me.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2
		    Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
		    Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
		    Me.dataGridView1.MultiSelect = false
		    Me.dataGridView1.Name = "dataGridView1"
		    dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		    dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		    dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		    dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		    dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		    dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		    dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		    Me.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
		    Me.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
		    Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		    Me.dataGridView1.Size = New System.Drawing.Size(408, 141)
		    Me.dataGridView1.StandardTab = true
		    Me.dataGridView1.TabIndex = 2
		    '
		    'Column1
		    '
		    Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		    Me.Column1.HeaderText = "Column1"
		    Me.Column1.Name = "Column1"
		    '
		    'tableLayoutPanel1
		    '
		    Me.tableLayoutPanel1.ColumnCount = 1
		    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
		    Me.tableLayoutPanel1.Controls.Add(Me.splitContainerFunctions, 0, 0)
		    Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 1)
		    Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
		    Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		    Me.tableLayoutPanel1.RowCount = 2
		    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
		    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
		    Me.tableLayoutPanel1.Size = New System.Drawing.Size(414, 605)
		    Me.tableLayoutPanel1.TabIndex = 3
		    '
		    'tableLayoutPanel2
		    '
		    Me.tableLayoutPanel2.ColumnCount = 5
		    Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		    Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
		    Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
		    Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
		    Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
		    Me.tableLayoutPanel2.Controls.Add(Me.btnCancel, 4, 0)
		    Me.tableLayoutPanel2.Controls.Add(Me.btnOK, 3, 0)
		    Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		    Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 573)
		    Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
		    Me.tableLayoutPanel2.RowCount = 1
		    Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
		    Me.tableLayoutPanel2.Size = New System.Drawing.Size(408, 29)
		    Me.tableLayoutPanel2.TabIndex = 1
		    '
		    'btnCancel
		    '
		    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		    Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
		    Me.btnCancel.Location = New System.Drawing.Point(330, 3)
		    Me.btnCancel.Name = "btnCancel"
		    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		    Me.btnCancel.TabIndex = 4
		    Me.btnCancel.Text = "Cancel"
		    Me.btnCancel.UseVisualStyleBackColor = true
		    '
		    'btnOK
		    '
		    Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
		    Me.btnOK.Location = New System.Drawing.Point(240, 3)
		    Me.btnOK.Name = "btnOK"
		    Me.btnOK.Size = New System.Drawing.Size(75, 23)
		    Me.btnOK.TabIndex = 3
		    Me.btnOK.Text = "OK"
		    Me.btnOK.UseVisualStyleBackColor = true
		    AddHandler Me.btnOK.Click, AddressOf Me.BtnOKClick
		    '
		    'FunctionsForm
		    '
		    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		    Me.ClientSize = New System.Drawing.Size(414, 629)
		    Me.Controls.Add(Me.tableLayoutPanel1)
		    Me.Controls.Add(Me.menuStrip1)
		    Me.DoubleBuffered = true
		    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		    Me.MainMenuStrip = Me.menuStrip1
		    Me.MaximizeBox = false
		    Me.MinimizeBox = false
		    Me.MinimumSize = New System.Drawing.Size(300, 500)
		    Me.Name = "FunctionsForm"
		    Me.ShowInTaskbar = false
		    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		    Me.Text = "Function Navigator"
		    AddHandler FormClosing, AddressOf Me.FunctionsForm_FormClosing
		    AddHandler Load, AddressOf Me.FunctionsForm_Load
		    Me.menuStrip1.ResumeLayout(false)
		    Me.menuStrip1.PerformLayout
		    Me.splitContainerFunctions.Panel1.ResumeLayout(false)
		    Me.splitContainerFunctions.Panel2.ResumeLayout(false)
		    CType(Me.splitContainerFunctions,System.ComponentModel.ISupportInitialize).EndInit
		    Me.splitContainerFunctions.ResumeLayout(false)
		    Me.splitContainer1.Panel1.ResumeLayout(false)
		    Me.splitContainer1.Panel2.ResumeLayout(false)
		    CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
		    Me.splitContainer1.ResumeLayout(false)
		    CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		    Me.tableLayoutPanel1.ResumeLayout(false)
		    Me.tableLayoutPanel2.ResumeLayout(false)
		    Me.ResumeLayout(false)
		    Me.PerformLayout
		End Sub
		Private btnOK As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private findItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private splitContainerFunctions As System.Windows.Forms.SplitContainer
		Private remeberLastPositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private showManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private viewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private menuStrip1 As System.Windows.Forms.MenuStrip

		#End Region

		Private treeView1 As System.Windows.Forms.TreeView
		Private richTextBox1 As System.Windows.Forms.RichTextBox
	End Class
