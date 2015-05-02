Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms

Namespace mpFormula
	Public Partial Class ProjectPaneForm
		Inherits Form

		Public Property ProjectFileName() As String
			Get
				Return MyFName
			End Get
			Set
				MyFName = value
			End Set
		End Property

		Public Sub SelectRootNode()
			treeViewDatabase.SelectedNode = treeViewDatabase.Nodes(0)
			treeViewDatabase.Focus()
		End Sub



		Private MyFName As String = ""

		Public Sub New(filename As String)
			InitializeComponent()
			AddHandler treeViewDatabase.NodeMouseClick, Function(sender, args) InlineAssignHelper(treeViewDatabase.SelectedNode, args.Node)
			MyFName = filename
			If MyFName.Substring(0, 2) = "\\" Then
				MyFName = "\\" & MyFName

				'MessageBox.Show(MyFName);
			End If
		End Sub




		Private Sub LoadTablePane(Click As Integer, filename As [String], TableName As [String], sql As [String], Title2 As [String], FileType As [String])
			Program.ActiveMainForm.UpdateAndActivateTableBrowser(Click, TableName, sql, Title2, FileType)
		End Sub


		Private Sub treeViewDatabase_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			treeViewDatabase_HandleMouseClick(2, e.Node)
		End Sub



		Private Sub treeViewDatabase_AfterSelect_1(sender As Object, e As TreeViewEventArgs)
			treeViewDatabase_HandleMouseClick(1, e.Node)
		End Sub



		Private Sub openInNewInputTabToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			treeViewDatabase_HandleMouseClick(2, MyNode)
		End Sub



		Private Sub treeViewDatabase_HandleMouseClick(Click As Integer, Node As TreeNode)
			Dim Code As [String] = Node.Tag.ToString()
			Dim Code2 As [String] = ""

			'if (Code == "WorkBook_")
			'{
			'  String Table = Node.Text;
			'  Program.ActiveMainForm.UpdateAndActivateWorkBook(Click, Table, "Section");
			'  return;
			'}

			If Code = "Pictures_" Then
				Dim Table As [String] = Node.Text
				'String SQL = "select * from " + Node.Text + ";";
				'LoadTablePane(Click, MyFName, Table, SQL, Node.Text, "TABLE");
				'UpdateAndActivatePictureBrowser
				Program.ActiveMainForm.UpdateAndActivatePictureBrowser(Click, Table, "Section")
				'Program.ActiveMainForm.UpdateAndActivateWorkBook(1, Table, "Section");
				Return
			End If


			If Code = "table_" Then
				Dim Table As [String] = Node.Text
				Dim SQL__1 As [String] = "select * from " & Node.Text & ";"
				LoadTablePane(Click, MyFName, Table, SQL__1, Node.Text, "TABLE")
				Return
			End If
			If Code = "view_" Then
				Dim Table As [String] = Node.Text
				Dim SQL__1 As [String] = "select * from " & Node.Text & ";"
				LoadTablePane(Click, MyFName, Table, SQL__1, Node.Text, "VIEW")
				Return
			End If

			If Code.Length >= 5 Then
				Code2 = Code.Substring(0, 5)
			End If
			If Code2 = "Code_" Then
				Dim sql__2 As String = "Select Index1, Code From " & Code & " Where Description='" & Node.Text & "';"
				'Program.ActiveMainForm.WriteInfo(Code);
				If Code = "Code_HTML" Then
					LoadWebPane(Click, sql__2, Code, Node.Text)
					Return
				ElseIf Code = "Code_XML" Then
					LoadXLMPane(Click, sql__2, Code, Node.Text)
					Return
				Else
					LoadCodePane(Click, sql__2, Code, Node.Text)
					Return
				End If
			Else
				'Program.ActiveMainForm.UpdateAndActivateWebBrowser(1, Code, "Section");
				Program.ActiveMainForm.UpdateAndActivateStartScreen(1, Code, "Section")
				Return
			End If

		End Sub



		Private Sub LoadWebPane(Click As Integer, sql As String, CodeType As [String], Title2 As [String])
			Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
			Try
				conn.Open()
				Dim ds As New DataSet()
				Dim da As New SQLiteDataAdapter(sql, conn)
				da.Fill(ds)
				For Each row As DataRow In ds.Tables(0).Rows
					Dim Code As [String] = row("Code").ToString()
					Program.ActiveMainForm.UpdateAndActivateWebBrowser(Click, Code, Title2)
				Next
				If ds IsNot Nothing Then
					ds.Dispose()
				End If
			Catch generatedExceptionName As Exception
				Throw
			End Try
		End Sub


		Private Sub LoadXLMPane(Click As Integer, sql As String, CodeType As [String], Title2 As [String])
			Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
			Try
				conn.Open()
				Dim ds As New DataSet()
				Dim da As New SQLiteDataAdapter(sql, conn)
				da.Fill(ds)
				For Each row As DataRow In ds.Tables(0).Rows
					Dim Code As [String] = row("Code").ToString()
					Program.ActiveMainForm.UpdateAndActivateXMLBrowser(Click, Code, Title2)
				Next
				If ds IsNot Nothing Then
					ds.Dispose()
				End If
			Catch generatedExceptionName As Exception
				Throw
			End Try
		End Sub



		Private Sub LoadCodePane(Click As Integer, sql As String, CodeType As [String], Title2 As [String])
			Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
			Try
				conn.Open()
				Dim ds As New DataSet()
				Dim da As New SQLiteDataAdapter(sql, conn)
				da.Fill(ds)
				For Each row As DataRow In ds.Tables(0).Rows
					Dim Code As [String] = row("Code").ToString()
					Dim Index As [String] = row("Index1").ToString()
					'String Index = "1";
					Program.ActiveMainForm.UpdateAndActivateCodeBrowser(Click, Index, Code, CodeType, Title2)
				Next
				If ds IsNot Nothing Then
					ds.Dispose()
				End If
			Catch generatedExceptionName As Exception
				Throw
			End Try
		End Sub



		Private Sub treeViewDatabase_BeforeExpand_1(sender As Object, e As TreeViewCancelEventArgs)
			Dim Name As [String] = e.Node.Name
			Dim NamePng As [String] = Name & "_Node.png"
			Dim sql As String = ""
			If (Name = "DataTables") OrElse (Name = "DataViews") Then
				sql = "Select name From sqlite_master where type='" & e.Node.Tag.ToString() & "' ORDER BY name;"
				If Name = "DataTables" Then
					sql = "Select name From sqlite_master where ((type='table') AND (substr(name,1,7)!='sqlite_') AND (substr(name,1,5)!='Code_') AND (substr(name,1,4)!='Cat_') AND (substr(name,1,5)!='Func_')) ORDER BY name;"
				End If
				Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
				Try
					'MessageBox.Show("Before Open");
					conn.Open()
					'MessageBox.Show("After Open Open");
					Dim dataSet As New DataSet()
					Dim da As New SQLiteDataAdapter(sql, conn)
					da.Fill(dataSet)
					Dim TName As [String] = ""
					e.Node.Nodes.Clear()
					For Each row As DataRow In dataSet.Tables(0).Rows
						TName = row("name").ToString()
						Dim tNode As TreeNode = e.Node.Nodes.Add(TName)
						tNode.Tag = e.Node.Tag.ToString() & "_"
						tNode.ImageKey = NamePng
						tNode.SelectedImageKey = NamePng
					Next
				Catch generatedExceptionName As Exception
					'MessageBox.Show("Catch : Data Source=" + MyFName + ";Version=3;");
					Throw
				End Try
			End If

			If (Name = "DataPictures") OrElse (Name = "DataWorkBook") Then
				sql = "Select imageFileName From ImageStore ORDER BY imageFileName;"

				Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
				Try
					conn.Open()
					Dim dataSet As New DataSet()
					Dim da As New SQLiteDataAdapter(sql, conn)
					da.Fill(dataSet)
					Dim TName As [String] = ""
					e.Node.Nodes.Clear()
					For Each row As DataRow In dataSet.Tables(0).Rows
						TName = row("imageFileName").ToString()
						Dim tNode As TreeNode = e.Node.Nodes.Add(TName)
						tNode.Tag = e.Node.Tag.ToString() & "_"
						tNode.ImageKey = NamePng
						tNode.SelectedImageKey = NamePng
					Next
				Catch generatedExceptionName As Exception
					'MessageBox.Show("Catch : Data Source=" + MyFName + ";Version=3;");
					Throw
				End Try
			End If



			If (Name = "DataSystemTables") Then
				sql = "Select name From sqlite_master where ((type='table') AND (substr(name,1,7)='sqlite_') OR (substr(name,1,5)='Code_') OR (substr(name,1,4)='Cat_') OR (substr(name,1,5)='Func_')) ORDER BY name;"
				Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
				Try
					conn.Open()
					Dim dataSet As New DataSet()
					Dim da As New SQLiteDataAdapter(sql, conn)
					da.Fill(dataSet)
					Dim TName As [String] = ""
					e.Node.Nodes.Clear()
					Dim tNode As TreeNode
					For Each row As DataRow In dataSet.Tables(0).Rows
						TName = row("name").ToString()
						tNode = e.Node.Nodes.Add(TName)
						tNode.Tag = e.Node.Tag.ToString() & "_"
						tNode.ImageKey = NamePng
						tNode.SelectedImageKey = NamePng
					Next
					TName = "sqlite_master"
					tNode = e.Node.Nodes.Add(TName)
					tNode.Tag = e.Node.Tag.ToString() & "_"
					tNode.ImageKey = NamePng


					tNode.SelectedImageKey = NamePng
				Catch generatedExceptionName As Exception
					Throw
				End Try
			End If

			If (Name = "DataCalculator") OrElse (Name = "DataVB_NET") OrElse (Name = "DataCSharp") OrElse (Name = "DataJScript") OrElse (Name = "DataVBScript") OrElse (Name = "DataLua") OrElse (Name = "DataPerl") OrElse (Name = "DataPHP") OrElse (Name = "DataSQL") OrElse (Name = "DataNETCharts") OrElse (Name = "DataGnuplot") OrElse (Name = "DataCPP") OrElse (Name = "DataJava") OrElse (Name = "DataR") OrElse (Name = "DataBatch") OrElse (Name = "DataHTML") OrElse (Name = "DataCSS") OrElse (Name = "DataXML") OrElse (Name = "DataPython") OrElse (Name = "DataMatlab") OrElse (Name = "DataRuby") OrElse (Name = "DataJScript10") OrElse (Name = "DataIronPython") OrElse (Name = "DataCPP_Native") OrElse (Name = "DataGCC_CPP") Then
				sql = "Select Index1, Description From Code_" & e.Node.Tag.ToString() & " ORDER BY Description;"
				Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
				Try

					'MessageBox.Show("Before Open");
					conn.Open()
					'MessageBox.Show("After Open Open");

					'conn.Open();
					Dim dataSet As New DataSet()
					Dim da As New SQLiteDataAdapter(sql, conn)
					da.Fill(dataSet)
					e.Node.Nodes.Clear()
					For Each row As DataRow In dataSet.Tables(0).Rows
						Dim TName As [String] = row("Description").ToString()
						Dim TIndex As [String] = row("Index1").ToString()
						Dim tNode As TreeNode = e.Node.Nodes.Add(TName)
						tNode.Tag = "Code_" & e.Node.Tag.ToString()
						tNode.ToolTipText = TIndex
						tNode.ImageKey = NamePng
						tNode.SelectedImageKey = NamePng
					Next
				Catch generatedExceptionName As Exception
					Throw
				End Try
			End If


		End Sub



		Private Sub contextMenuStripDatabase_Opening_1(sender As Object, e As CancelEventArgs)
			Dim MyTag As [String] = treeViewDatabase.SelectedNode.Tag.ToString()
			contextMenuStripDatabase.Items.Clear()
			If MyTag = "table" Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemCreateTable, Me.insertSampleTableToolStripMenuItem, Me.toolStripSeparator1, Me.importExcelTablesToolStripMenuItem, Me.importAccessTablesToolStripMenuItem, Me.importTableToolStripMenuItem})
				Return
			End If
			If MyTag = "table_" Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openInNewInputTabToolStripMenuItem, Me.openInNewOutputTabToolStripMenuItem, Me.toolStripSeparator4, Me.toolStripMenuItemRenameTable, Me.toolStripMenuItemCopyTable, Me.toolStripMenuItemExportTable, _
					Me.reIndexTableToolStripMenuItem, Me.toolStripSeparator1, Me.toolStripMenuItemDropTable, Me.toolStripMenuItemEmptyTable})
				Return
			End If

			If MyTag = "view" Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemCreateView})
				Return
			End If
			If MyTag = "view_" Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openInNewInputTabToolStripMenuItem, Me.openInNewOutputTabToolStripMenuItem, Me.toolStripSeparator4, Me.toolStripMenuItemRenameView, Me.duplicateViewToolStripMenuItem, Me.toolStripMenuItemExportView, _
					Me.toolStripSeparator1, Me.toolStripMenuItemDropView})
				Return
			End If

			If (MyTag = "Calculator") OrElse (MyTag = "VBNET") OrElse (MyTag = "ChartsNET") OrElse (MyTag = "CSharp") OrElse (MyTag = "VBScript") OrElse (MyTag = "Lua") OrElse (MyTag = "Perl") OrElse (MyTag = "PHP") OrElse (MyTag = "JScript") OrElse (MyTag = "SQL") OrElse (MyTag = "SQL") OrElse (MyTag = "Gnuplot") OrElse (MyTag = "R") OrElse (MyTag = "CPP") OrElse (MyTag = "Java") OrElse (MyTag = "Batch") OrElse (MyTag = "HTML") OrElse (MyTag = "CSS") OrElse (MyTag = "XML") OrElse (MyTag = "Python") OrElse (MyTag = "Matlab") OrElse (MyTag = "Ruby") OrElse (MyTag = "JScript10") OrElse (MyTag = "IronPython") OrElse (MyTag = "CPP_Native") OrElse (MyTag = "GCC_CPP") Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertSampleModuleToolStripMenuItem, Me.importModuleToolStripMenuItem, Me.toolStripSeparator1, Me.defineCategoriesToolStripMenuItem, Me.groupByCategoryToolStripMenuItem})
				Return
			End If



			If (MyTag = "Code_Calculator") OrElse (MyTag = "Code_VBNET") OrElse (MyTag = "Code_ChartsNET") OrElse (MyTag = "Code_CSharp") OrElse (MyTag = "Code_VBScript") OrElse (MyTag = "Code_Python") OrElse (MyTag = "Code_Ruby") OrElse (MyTag = "Code_Lua") OrElse (MyTag = "Code_Perl") OrElse (MyTag = "Code_PHP") OrElse (MyTag = "Code_Matlab") OrElse (MyTag = "Code_JScript") OrElse (MyTag = "Code_SQL") OrElse (MyTag = "Code_SQL") OrElse (MyTag = "Code_Gnuplot") OrElse (MyTag = "Code_R") OrElse (MyTag = "Code_CPP") OrElse (MyTag = "Code_Java") OrElse (MyTag = "Code_Batch") OrElse (MyTag = "Code_JScript10") OrElse (MyTag = "Code_IronPython") OrElse (MyTag = "Code_CPP_Native") OrElse (MyTag = "Code_GCC_CPP") Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.runModuleToolStripMenuItem, Me.toolStripSeparator1, Me.openInNewInputTabToolStripMenuItem, Me.toolStripSeparator4, Me.renameModuleToolStripMenuItem, Me.assignToCategoryToolStripMenuItem, _
					Me.toolStripSeparator2, Me.duplicateModuleToolStripMenuItem, Me.exportModuleToolStripMenuItem, Me.toolStripSeparator3, Me.dropModuleToolStripMenuItem})
				Return
			End If


			If (MyTag = "Code_HTML") OrElse (MyTag = "Code_CSS") OrElse (MyTag = "Code_XML") Then
				Me.contextMenuStripDatabase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openInNewInputTabToolStripMenuItem, Me.openInNewOutputTabToolStripMenuItem, Me.toolStripSeparator4, Me.renameModuleToolStripMenuItem, Me.assignToCategoryToolStripMenuItem, Me.toolStripSeparator2, _
					Me.duplicateModuleToolStripMenuItem, Me.exportModuleToolStripMenuItem, Me.toolStripSeparator3, Me.dropModuleToolStripMenuItem})
				Return
			End If
		End Sub



		Private Sub ProjectPaneForm_Load(sender As Object, e As EventArgs)

		End Sub

		Private Sub ProjectPaneForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			Program.ActiveMainForm.CheckTabPages(0)
		End Sub



		' Interactive Rightclick menues

		' Modules

		Private Sub dropModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim ModuleName As [String] = MyNode.Text
			Dim message As String = "Do you want to permanently delete the Module " & ModuleName & "?"
			Dim caption As String = "Confirmation of Deletion"
			Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
			Dim result As DialogResult = MessageBox.Show(message, caption, buttons)
			If result = System.Windows.Forms.DialogResult.Yes Then
				'MessageBox.Show(MyNode.Tag.ToString(), MyNode.ToolTipText.ToString());
				DatabaseManagement.DropCodeModule(MyNode.Tag.ToString(), MyNode.ToolTipText.ToString())
				MyNode.Remove()
					'need to close Editor Window
				treeViewDatabase.Refresh()
			End If
		End Sub

		Private Sub renameModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			treeViewDatabase.LabelEdit = True
			treeViewDatabase.SelectedNode.BeginEdit()
		End Sub




		Private Sub ReReadModuleNode(ParentNode As TreeNode, NewModuleName As [String])
			Dim Name As [String] = ParentNode.Name
			Dim NamePng As [String] = Name & "_Node.png"
			Dim sql As String = "Select Index1, Description From Code_" & ParentNode.Tag.ToString() & " ORDER BY Description;"
			'string sql = "Select Index1, Description From Code_" + e.Node.Tag.ToString() + ";";
			Dim conn = New SQLiteConnection("Data Source=" & MyFName & ";Version=3;", True)
			Try
				conn.Open()
				Dim dataSet As New DataSet()
				Dim da As New SQLiteDataAdapter(sql, conn)
				da.Fill(dataSet)
				ParentNode.Nodes.Clear()
				For Each row As DataRow In dataSet.Tables(0).Rows
					Dim TName As [String] = row("Description").ToString()
					Dim TIndex As [String] = row("Index1").ToString()
					Dim tNode As TreeNode = ParentNode.Nodes.Add(TName)
					tNode.Tag = "Code_" & ParentNode.Tag.ToString()
					tNode.ToolTipText = TIndex
					tNode.ImageKey = NamePng
					tNode.SelectedImageKey = NamePng
					If NewModuleName = TName Then
						treeViewDatabase.SelectedNode = tNode
					End If
				Next
			Catch generatedExceptionName As Exception
				Throw
			End Try
		End Sub


		Private Sub insertSampleModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim ParentNode As TreeNode = treeViewDatabase.SelectedNode
			ParentNode.Expand()
			Dim ModuleName As [String] = ParentNode.Tag.ToString()
			Dim NewModuleName As [String] = Program.ActiveMainForm.CallExamplesDialogue(ModuleName)

			ReReadModuleNode(ParentNode, NewModuleName)
		End Sub


		Private Sub importModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim ParentNode As TreeNode = treeViewDatabase.SelectedNode
			ParentNode.Expand()
			Dim ModuleName As [String] = ParentNode.Tag.ToString()
			Dim NewModuleName As [String] = Program.ActiveMainForm.ImportModule(ModuleName)
			'treeViewDatabase.SuspendLayout();
			ReReadModuleNode(ParentNode, NewModuleName)
			'treeViewDatabase.ResumeLayout();
		End Sub


		Private Sub duplicateModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim FileType As [String] = MyNode.Tag.ToString()
			Dim Index As [String] = MyNode.ToolTipText.ToString()
			Dim OldModuleName As [String] = MyNode.Text
			Dim ParentNode As TreeNode = MyNode.Parent
			Dim NewModuleName As [String] = Program.ActiveMainForm.SaveAsModule(FileType, Index, OldModuleName)
			ReReadModuleNode(ParentNode, NewModuleName)
		End Sub


		Private Sub runModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Program.ActiveMainForm.SetupProcess()
		End Sub


		Private Sub exportModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Program.ActiveMainForm.ExportModuleFromMainMenu()
		End Sub





		' Tables


		Private Sub toolStripMenuItemCreateTable_Click(sender As Object, e As EventArgs)
			'DatabaseManagement.CreateNewTables();
			Program.ActiveMainForm.CreateTable()
		End Sub


		Private Sub importExcelTablesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Program.ActiveMainForm.ImportTables("Excel")
		End Sub

		Private Sub importAccessTablesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Program.ActiveMainForm.ImportTables("Access")
		End Sub




		Private Sub toolStripMenuItemDuplicateTable_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim OldTableName As [String] = MyNode.Text
			Dim testDialog As New InputBoxForm(OldTableName)
			If testDialog.ShowDialog(Me) = DialogResult.OK Then
				Dim NewTableName As [String] = testDialog.Text2
				DatabaseManagement.DuplicateTable(OldTableName, NewTableName)
			End If
			testDialog.Dispose()
		End Sub

		Private Sub toolStripMenuItemEmptyTable_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim TableName As [String] = MyNode.Text
			Dim message As String = "Do you want to permanently delete all data from table '" & TableName & "'?"
			Dim caption As String = "Confirmation"
			Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
			Dim result As DialogResult = MessageBox.Show(message, caption, buttons)
			If result = System.Windows.Forms.DialogResult.Yes Then
					' Need to re-read Table
				DatabaseManagement.EmptyTable(TableName)
			End If
		End Sub


		Private Sub toolStripMenuItemDropTable_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim TableName As [String] = MyNode.Text
			Dim message As String = "Do you want to permanently delete the Table " & TableName & "?"
			Dim caption As String = "Confirmation of Deletion"
			Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
			Dim result As DialogResult = MessageBox.Show(message, caption, buttons)
			If result = System.Windows.Forms.DialogResult.Yes Then
				DatabaseManagement.DropTable(TableName)
				MyNode.Remove()
					'need to close Editor Window
				treeViewDatabase.Refresh()
			End If
		End Sub


		Private Sub reIndexTableToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
			Dim TableName As [String] = MyNode.Text
			DatabaseManagement.ReIndexTable(TableName)
		End Sub

		Private Sub toolStripMenuItemRenameTable_Click(sender As Object, e As EventArgs)
			treeViewDatabase.LabelEdit = True
			treeViewDatabase.SelectedNode.BeginEdit()
		End Sub



		' General (Modules and Tables)

		Private Sub treeViewDatabase_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs)
			Dim NewLabel As [String] = e.Label
			If NewLabel IsNot Nothing Then
				Dim MyNode As TreeNode = treeViewDatabase.SelectedNode
				Dim MyTag As [String] = MyNode.Tag.ToString()
				Dim MyIndex As [String] = MyNode.ToolTipText.ToString()
				Dim OldLabel As [String] = MyNode.Text
				If MyTag = "table_" Then
						'need to rename Table Window if open
					DatabaseManagement.RenameTable(OldLabel, NewLabel)
				End If

				Dim Code2 As [String] = ""
				If MyTag.Length >= 5 Then
					Code2 = MyTag.Substring(0, 5)
				End If
				If Code2 = "Code_" Then
						'need to rename Editor Window if open
					DatabaseManagement.RenameModule(MyTag, MyIndex, NewLabel)
				End If
			End If
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function





	End Class
End Namespace
