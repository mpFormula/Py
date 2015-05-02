'
' Created by SharpDevelop.
' User: dhadler
' Date: 06/05/2014
' Time: 14:13
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports Microsoft.Win32
'Imports System.Data.SQLite
Imports System.Reflection



Module ExtensionMethods
	<System.Runtime.CompilerServices.Extension> _
	Public Sub DoubleBuffered(dgv As DataGridView, setting As Boolean)
		Dim dgvType As Type = dgv.[GetType]()
		Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
		pi.SetValue(dgv, setting, Nothing)
	End Sub
End Module



Public Partial Class MainForm
		
	Sub ShowFileDlg()
	Dim FileType As String ="Excel"
      openFileDialog1.Title = "Import File"
      openFileDialog1.FileName = ""
      openFileDialog1.Filter = "All files (*.*)|*.*"
      openFileDialog1.Filter = "Excel 2003- (*.xls)|*.xls|Excel 2007+ (*.xlsx)|*.xlsx|Access 2003- (*.mdb)|*.mdb|Access 2007+ (*.accdb)|*.accdb|SQLite 3 (*.db)|*.db|SQLite 3 (*.sqlite)|*.sqlite|All files (*.*)|*.*"
      If (openFileDialog1.ShowDialog() = DialogResult.OK) Then
			Dim FName As String = openFileDialog1.FileName.ToString()
			LoadFile(FName)
      End If

	End Sub
	
	
	
	Public Sub New()
		Me.InitializeComponent()
		dataGridView1.DoubleBuffered(true)
		Dim n As Int32 = My.Application.CommandLineArgs.Count
		If n>0 Then
			Dim FName As String = My.Application.CommandLineArgs(0)
			LoadFile(FName)
		End If
	End Sub
	
	
	
		Public Property MyString() As String
			Get
				Return m_MyString
			End Get
			Set
				m_MyString = Value
			End Set
		End Property
		Private m_MyString As String
		' In .NET 3.0 or newer 
		Private MyFileType As String = ""
		Private MyFName As String = ""


		
		Public Sub LoadFile(FName As String)
			Dim FileType As String = "" 
			Dim Ext As String = System.IO.Path.GetExtension(FName)
			If ((Ext = ".xls") Or (Ext = ".xlsx")) Then
				FileType = "Excel"
			ElseIf	((Ext = ".mdb") Or (Ext = ".accdb")) Then
				FileType = "Access"
			ElseIf	((Ext = ".db") Or (Ext = ".sqlite")) Then
				FileType = "SQLite"				
			Else
				MsgBox(Ext,,"Unsupported file extension" )
			End If
			
			MyFileType = FileType
			MyFName = FName
			MyString = "Form3 MyString"
			Me.Text = "Opened: " & FName
			If FileType = "Excel" Then
				LoadExcelDbByName(FName)
			End If
			If FileType = "Access" Then
				LoadAccesDbByName(FName)
			End If
			If FileType = "SQLite" Then
				LoadSQLiteDbByName(FName)
			End If
		End Sub
		
		
		Private UseACE As Integer = 0
		Private IsExcel As Integer = 1


		Private Function WorkingDir() As String
			Dim key As RegistryKey = Registry.CurrentUser
			Dim key2 As RegistryKey = key.OpenSubKey("SOFTWARE\THF")
			Dim DirName As String = key2.GetValue("WorkingDir").ToString()
			Return DirName & "mpFormula\"
		End Function
		
		
		
		
		Private Sub LoadSQLiteDbByName(FName As String)
			MsgBox("SQLite")
			
			Dim nwindConn As OdbcConnection = New OdbcConnection("Driver={SQLite3 ODBC Driver};Database=" & FName)
			nwindConn.Open()
			
			MsgBox("SQLite2")
			
		End Sub
		
		Public Function GetDataSetFromAdapter( _
		    ByVal dataSet As DataSet, ByVal connectionString As String, _
		    ByVal queryString As String) As DataSet
		
		    Using connection As New OdbcConnection(connectionString)
		        Dim adapter As New OdbcDataAdapter(queryString, connection)
		
		        ' Open the connection and fill the DataSet.
		        Try
		            connection.Open()
		            adapter.Fill(dataSet)
		        Catch ex As Exception
		            Console.WriteLine(ex.Message)
		        End Try
		        ' The connection is automatically closed when the
		        ' code exits the Using block.
		    End Using
		
		    Return dataSet
		End Function
	
	
		Public Function SelectOdbcSrvRows( _
		    ByVal connectionString As String, ByVal queryString As String, _
		    ByVal tableName As String) As DataSet
		
		    Dim dataSet As DataSet = New DataSet
		
		    Using connection As New OdbcConnection(connectionString)
		        Dim adapter As New OdbcDataAdapter()
		        adapter.SelectCommand = _
		            New OdbcCommand(queryString, connection)
		        Dim builder As OdbcCommandBuilder = _
		            New OdbcCommandBuilder(adapter)
		
		        connection.Open()
		
		        adapter.Fill(dataSet, tableName)
		
		        ' Code to modify data in DataSet here 
		
		        ' Without the OdbcCommandBuilder this line would fail.
		        adapter.Update(dataSet, tableName)
		    End Using
		
		    Return dataSet
		End Function


	
	
	
		
		
		Private Sub LoadExcelDb2(connString As String, query As String)
			Dim dAdapter As New OleDbDataAdapter(query, connString)
			Dim cBuilder As New OleDbCommandBuilder(dAdapter)
			Dim dTable As New DataTable()
			dAdapter.Fill(dTable)
			Dim bSource As New BindingSource()
			bSource.DataSource = dTable
			dataGridView1.DataSource = bSource
		End Sub

		Private Function MSProvider() As String
			If UseACE = 0 Then
				Return "Provider=Microsoft.Jet.OLEDB.4.0;"
			Else
				Return "Provider=Microsoft.ACE.OLEDB.12.0;"
			End If
		End Function



		Private Sub LoadExcelDbByName(FName As String)
			IsExcel = 1
			Dim connString As String = MSProvider() & "Data Source=" & FName & ";Extended Properties=""Excel 8.0;IMEX=1;HDR=YES;"""
			GetExcelTables(connString)
			Dim worksheetName As String = checkedListBox1.Items(0).ToString()
			Dim query As String = "select * from [" & worksheetName & "$]"
			LoadExcelDb2(connString, query)
		End Sub

		Private Sub LoadAccesDbByName(FName As String)
			IsExcel = 0
			Dim connString As String = MSProvider() & "Data Source=" & FName
			GetExcelTables(connString)
			Dim worksheetName As String = checkedListBox1.Items(0).ToString()
			Dim query As String = "select * from " & worksheetName
			LoadExcelDb2(connString, query)
		End Sub


		Private Sub GetExcelTables(connectionString As String)
			Dim con As OleDbConnection
			con = New OleDbConnection(connectionString)
			con.Open()
			'get all the available sheets
			Dim dataSet As System.Data.DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
			'get the number of sheets in the file
			Dim workSheetNames As [String]() = New [String](dataSet.Rows.Count - 1) {}
			Dim i As Integer = 0
			'this.richTextBox1.Text = "GetExcelTables" + Environment.NewLine;
			checkedListBox1.Items.Clear()
			Dim TName As [String] = ""
			Dim TName2 As [String] = ""
			For Each row As DataRow In dataSet.Rows
				TName = row("TABLE_NAME").ToString().Trim("$")
				TName2 = TName.ToUpper()
				TName2 = TName2.Substring(0, 4)
				Me.richTextBox1.Text += TName & Environment.NewLine
				Me.richTextBox1.Text += TName2 & Environment.NewLine
				If TName2 <> "MSYS" Then
					'workSheetNames[i] = row["TABLE_NAME"].ToString().Trim(new[] { '$' });
					workSheetNames(i) = TName
					Me.richTextBox1.Text += workSheetNames(i) & Environment.NewLine
					i += 1
				End If
			Next
			Array.Resize(workSheetNames, i)
			Me.checkedListBox1.Items.AddRange(workSheetNames)
			If con IsNot Nothing Then
				con.Close()
				con.Dispose()
			End If

			If dataSet IsNot Nothing Then
				dataSet.Dispose()
			End If
		End Sub

	Sub CheckedListBox1SelectedIndexChanged(sender As Object, e As EventArgs)
					Dim worksheetName As String = checkedListBox1.SelectedItem.ToString()
			Me.richTextBox1.AppendText(worksheetName & Environment.NewLine)
			Dim FName As String = ""
			Dim connString As String = ""
			Dim query As String = ""
			'string worksheetName = "Customers2";
			If IsExcel = 1 Then
				'FName = WorkingDir() + @"Temp\Customers.xls";
				FName = MyFName
				connString = MSProvider() & "Data Source=" & FName & ";Extended Properties=""Excel 8.0;IMEX=1;HDR=YES;"""
				query = "select * from [" & worksheetName & "$]"
			Else
				'FName = WorkingDir() + @"Temp\Customers2000.mdb";
				FName = MyFName
				connString = MSProvider() & "Data Source=" & FName
				query = "select * from " & worksheetName
			End If

			LoadExcelDb2(connString, query)
	End Sub
	
'		Private Sub checkedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
'
'		End Sub


		'Note: The program must determine on its own
		Private Sub checkBoxUseACE_CheckedChanged_1(sender As Object, e As EventArgs)
			If UseACE = 0 Then
				UseACE = 1
			Else
				UseACE = 0
			End If
		End Sub


	
	
	
	
	
	
	
	
	Sub ImportExcelToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFileDlg()
	End Sub
	
'	Sub TopToolStripPanelClick(sender As Object, e As EventArgs)
'		
'	End Sub
'	
'	Sub ToolStrip1ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
'		
'	End Sub
	

'	
'	Sub ImportSQLiteToolStripMenuItemClick(sender As Object, e As EventArgs)
''		MsgBox ("SQLite")	
'		ShowFileDlg()
'	End Sub


	
	Function RootDir() As String
		Dim regKey As RegistryKey
		Dim RootPath As String = "Not set"
		Try
		  regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
		  RootPath = regKey.GetValue("RootPath", "Not set")
		  regKey.Close()
		Catch ex As Exception
			MsgBox("RootDir not set")
		End Try
		Return RootPath
	End Function
	
	
	Sub MakeRootPath()
		Dim regKey As RegistryKey
		Dim regKey2 As RegistryKey
		regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
		Try
			regKey.DeleteSubKey("mpFormulaToolbox", True)
		Catch ex As Exception
'			Throw
		End Try
		regKey.CreateSubKey("mpFormulaToolbox")
		Dim RootPath As String = My.Application.Info.DirectoryPath +"\"
		regKey2 = Registry.CurrentUser.OpenSubKey("Software\mpFormulaToolbox", True)
		regKey2.SetValue("RootPath", RootPath)
		regKey.Close()
	End Sub	


	Sub DeleteRootPath()
		Dim regKey As RegistryKey
		regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
		Try
			regKey.DeleteSubKey("mpFormulaToolbox", True)
		Catch ex As Exception
'			Throw
		End Try		
		regKey.Close()
	End Sub
	
	
	Sub ReadRootPath()	
		MsgBox(RootDir())
	End Sub
	
	
	
	Sub StartAppWithArgs(FName As String, Args As String)
	    Dim directory = RootDir() + FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.Arguments = Args
	    p.WindowStyle = ProcessWindowStyle.Normal
	    Process.Start(p)
	    Me.Close()		
	End Sub	
	
	
	
	Sub StartExternalApp(FName As String)
	    Dim directory = FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.WindowStyle = ProcessWindowStyle.Normal
	    Process.Start(p)
	    Me.Close()		
	End Sub	
	
	
	Sub StartApp(FName As String)
	    Dim directory = RootDir() + FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.WindowStyle = ProcessWindowStyle.Normal
	    Process.Start(p)
	    Me.Close()		
	End Sub	
	
	

	Sub ImportAccessToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFileDlg()
	End Sub
	
	Sub HTMLFilesToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("GUI\HTMLViewer.exe", "")			
	End Sub
	
	Sub ChartFilesToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("GUI\ChartViewer.exe", "")		    
	End Sub
	
	Sub CalculatorToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\CalculatorDlg.exe")		    
	End Sub
	
	
	
	
	
	Sub SharpDevelopToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("mpNum\bin\SharpDevelop.exe")		    
	End Sub
	
	Sub CodeblocksToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools\Codeblocks_13\codeblocks.exe")	    
	End Sub
	
	Sub MSYS20ToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools\msys32\mingw32_shell.bat")		    
	End Sub
	
	Sub FunctionNavigatorToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\FunctionNavigator.exe")	    
	End Sub
	
	Sub PythonConsoleToolStripMenuItemClick(sender As Object, e As EventArgs)
	    Dim FName As String = "Source\PythonConsole\PythonConsole.sln"
	  	StartAppWithArgs("mpNum\bin\SharpDevelop.exe", RootDir() + FName)		    
	End Sub
	
	Sub IronPython32BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("mpNum\AddIns\BackendBindings\PythonBinding\ipy.exe", " -X:Frames -X:ColorfulConsole")	    
	End Sub
	
	Sub IronPython64BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("mpNum\AddIns\BackendBindings\PythonBinding\ipy64.exe", " -X:Frames -X:ColorfulConsole")
	End Sub
	
	Sub DInteractiveChartsToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\WpfInWinForms.exe")	    
	End Sub
	
	Sub SetupToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\OptionsEditor.exe")			
	End Sub
	
	Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("Manual\mpFormula.pdf")	
	End Sub
	
	Sub EditWithTexStudioToolStripMenuItemClick(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "Source\Manual\mpFormula.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")			
	End Sub
	
	Sub EditWithToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("Source\Manual\mpFormula.tcp")	
	End Sub
	
	Sub ShowMpFormulaCManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\mpFormulaC\Manual\mpFormulaC.pdf")		    
	End Sub
	
	Sub EditWithTexStudioToolStripMenuItem1Click(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "..\mpFormulaC\Source\Manual\mpFormulaC.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")				    
	End Sub
	
	Sub EditWithTexnicCenterToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\mpFormulaC\Source\Manual\mpFormulaC.tcp")	
	End Sub
	
	
	Sub EditWithTexStudioToolStripMenuItem2Click(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "Source\Manual\mpFormulaWork.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")				    
	End Sub
	
	
	
	Sub OpenToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartExternalApp(RootDir())	    
	End Sub
	
	Sub ShowToolStripMenuItemClick(sender As Object, e As EventArgs)
		ReadRootPath()		    
	End Sub
	
	Sub CreateToolStripMenuItemClick(sender As Object, e As EventArgs)
		MakeRootPath()
	End Sub
	
	Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs)
	    DeleteRootPath()	
	End Sub
End Class
