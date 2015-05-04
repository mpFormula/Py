'
' Created by SharpDevelop.
' User: DH
' Date: 04/05/2014
' Time: 14:59
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Imports Microsoft.Win32

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Dim MC As Int32 = My.Application.CommandLineArgs.Count
		If (MC = 0) Then
			MakeRootPath()
		End If
	End Sub
	
	
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
	
		
	Sub ReadRootPathToolStripMenuItemClick(sender As Object, e As EventArgs)
		ReadRootPath()	
	End Sub
	
	Sub CreateRootPathToolStripMenuItemClick(sender As Object, e As EventArgs)
		MakeRootPath()
	End Sub
	
	Sub DeleteRootPathToolStripMenuItemClick(sender As Object, e As EventArgs)
		DeleteRootPath()
	End Sub
	
	
	
	
	
	
	
	
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

	
	
	
	Sub ShowFileDlg()
	Dim FileType As String ="Excel"
      openFileDialog1.Title = "Import File"
      openFileDialog1.FileName = ""
      openFileDialog1.Filter = "All files (*.*)|*.*"
      openFileDialog1.Filter = "Excel 2003- (*.xls)|*.xls|Excel 2007+ (*.xlsx)|*.xlsx|Access 2003- (*.mdb)|*.mdb|Access 2007+ (*.accdb)|*.accdb|All files (*.*)|*.*"
      If (openFileDialog1.ShowDialog() = DialogResult.OK) Then
		Dim FName As String = openFileDialog1.FileName.ToString()
		Dim Ext As String = System.IO.Path.GetExtension(FName)
		If ((Ext = ".xls") Or (Ext = ".xlsx")) Then
			FileType = "Excel"
		ElseIf	((Ext = ".mdb") Or (Ext = ".accdb")) Then
			FileType = "Access"
		Else
			MsgBox(Ext,,"Unsupported file extension" )
		End If
		openFileDialog1.Dispose()
		SwitchToFileViewer(FName)
      End If
	End Sub
	
	
	
	Sub StartAppAsAdministrator(FName As String)
	    Dim directory = RootDir() + FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.Verb = "runas"
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
	
	
	
	
	Sub StartExternalApp(FName As String)
	    Dim directory = FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.WindowStyle = ProcessWindowStyle.Normal
	    Process.Start(p)
	    Me.Close()		
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
	
	

	
	Sub StartAppNoClose(FName As String)
	    Dim directory = RootDir() + FName
	    Dim p As New ProcessStartInfo
	    p.FileName = directory
	    p.WindowStyle = ProcessWindowStyle.Normal
	    Process.Start(p)
'	    Me.Close()		
	End Sub	
	
	
	
	Sub MsysToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools\msys64\mingw64_shell.bat")	
	End Sub
	
	
	Sub MsysOpenFolderToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppNoClose("..\ExternalTools\msys64\mingw64_shell.bat")	
		StartExternalApp(RootDir() + "..\ExternalTools\msys64")
	End Sub
	
	
	Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools\msys32\mingw32_shell.bat")	
	End Sub
	
	Sub ToolStripMenuItem2Click(sender As Object, e As EventArgs)
		StartAppNoClose("..\ExternalTools\msys32\mingw32_shell.bat")	
		StartExternalApp(RootDir() + "..\ExternalTools\msys32")
	End Sub
	
	
	
	Sub SwitchToCodeBlocks()	
		StartApp("..\ExternalTools\Codeblocks_13\codeblocks.exe")	
	End Sub
	

		
	Sub PDFViewerToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\TestAcro.exe")	
	End Sub

	
	
	Sub RootDirToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartExternalApp(RootDir())
	End Sub
	
	Sub StartAsAdministratorSharpDevelop()
		StartAppAsAdministrator("mpNum\bin\SharpDevelop.exe")
	End Sub
	
	
	
	Sub SwitchToSharpDevelop()
		StartApp("mpNum\bin\SharpDevelop.exe")	
	End Sub
	
	

	
	
	Sub SwitchToExcel()
		StartApp("Workbooks\Test_XLL.xls")	
	End Sub
	
	
	
	
	
	
	Sub SwitchToManual()
		StartApp("Manual\mpFormula.pdf")	
	End Sub
	
	
	Sub EditManual()
		StartApp("Source\Manual\mpFormula.tcp")	
	End Sub
	
	
	
	Sub SwitchToExtendedManual()
		StartApp("..\mpFormulaC\Manual\mpFormulaC.pdf")	
	End Sub
	
	
	Sub EditExtendedManual()
		StartApp("..\mpFormulaC\Source\Manual\mpFormulaC.tcp")	
	End Sub
		
	
	
	Sub SwitchToCalculator()
		StartApp("GUI\CalculatorDlg.exe")	
	End Sub
	


	
	
	Sub ShowFunctionsDlg()
		StartApp("GUI\FunctionNavigator.exe")	
	End Sub
	
	
	
	Sub ShowOptionsDlg()
		StartApp("GUI\OptionsEditor.exe")			
	End Sub
	
	

	
	
	
	Sub SwitchToFileViewer(FName As String)
		StartAppWithArgs("GUI\FileViewer.exe", FName)			
	End Sub
	
	
	
	Sub SwitchToHTMLViewer(FName As String)
		StartAppWithArgs("GUI\HTMLViewer.exe", FName)			
	End Sub
	
	
	
	
	Sub SwitchToChartViewer(FName As String)
		StartAppWithArgs("GUI\ChartViewer.exe", FName)			
	End Sub
	
	
	
	Sub SwitchToPictureViewer(FName As String)
		StartAppWithArgs("GUI\PictureViewer.exe", FName)			
	End Sub
	
	
	
	Sub SwitchTo3DChartViewer(FName As String)
		StartAppWithArgs("GUI\WPFChart.exe", FName)			
	End Sub
	
	
	

	
	
	

	
	Sub ContentPanelLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	
	
	Sub ImportExcelToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFileDlg()
	End Sub
	
	Sub ImportAccessToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFileDlg()
	End Sub
		
	Sub ExitToolStripMenuItemClick(sender As Object, e As EventArgs)
		Me.Close()
	End Sub	
	
	
	
	
	Sub SwitchToReogridToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToExcel()
	End Sub
	
	
	
	
	Sub IDEStartertoolStripSplitButtonButtonClick(sender As Object, e As EventArgs)
		SwitchToSharpDevelop()
	End Sub
	
	Sub NormalStarttoolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToSharpDevelop()
	End Sub
	
	Sub StartAsAdministratorToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAsAdministratorSharpDevelop()
	End Sub
	
	
		
	Sub CodeblocksToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToCodeBlocks()
	End Sub
	
	
	Sub SwitchToDevelopToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToSharpDevelop()
	End Sub
	
	Sub FunctionsToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFunctionsDlg()
	End Sub
	
	Sub OptionsToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowOptionsDlg()
	End Sub
	
	
	Sub ManualStripSplitButtonButtonClick(sender As Object, e As EventArgs)
		SwitchToManual()
	End Sub
	
	
	
	Sub ShowManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToManual()
	End Sub
	
	Sub EditManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		EditManual()
	End Sub
	
	
		
	
	Sub ShowExtendedManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToExtendedManual()
	End Sub
	
	Sub EditExtendedManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		EditExtendedManual()
	End Sub
	
	
	Sub SwitchToManualToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToManual()
	End Sub
	
	Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowAboutDlg()
	End Sub
	
	
	
	


	
	Sub ImportExcelToolStripButtonClick(sender As Object, e As EventArgs)
		ShowFileDlg()
	End Sub
	
	Sub ImportAccessToolStripButtonClick(sender As Object, e As EventArgs)
'		SwitchToCalculator()
	End Sub
	
	Sub SwitchToReogridToolStripButtonClick(sender As Object, e As EventArgs)
		SwitchToExcel()
	End Sub
	
	Sub SwitchToDevelopToolStripButtonClick(sender As Object, e As EventArgs)
		SwitchToSharpDevelop()
	End Sub
	
	Sub FunctionsToolStripButtonClick(sender As Object, e As EventArgs)
		ShowFunctionsDlg()
	End Sub
	
	Sub OptionsToolStripButtonClick(sender As Object, e As EventArgs)
		ShowOptionsDlg()
	End Sub
	
	Sub SwitchToManualToolStripButtonClick(sender As Object, e As EventArgs)
		SwitchToManual()
	End Sub
	
	Sub AboutToolStripButtonClick(sender As Object, e As EventArgs)
		ShowAboutDlg()
	End Sub
	
	Sub HTMLViewerToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToHTMLViewer("")
	End Sub
	

	
	Sub ChartViewerToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToChartViewer("")
	End Sub
	
	Sub PictureViewerToolStripMenuItemClick(sender As Object, e As EventArgs)
		SwitchToPictureViewer("")
	End Sub
	
	

	
	
	
	
	Sub ShowAboutDlg()
	    Dim testDialog As New AboutForm()
	    If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
	    End If
	    testDialog.Dispose()
	End Sub
	
	
	
	
	
	Sub DSurfacePlotsToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("GUI\WpfInWinForms.exe")
	End Sub
	
	
	Sub CalculatorStripSplitButtonButtonClick(sender As Object, e As EventArgs)
	    SwitchToCalculator()
	End Sub

	
	
	Sub CalculatorStripSplitButtonClick(sender As Object, e As EventArgs)
	    SwitchToCalculator()
	End Sub
	
	Sub CalculatorToolStripMenuItemClick(sender As Object, e As EventArgs)
	    SwitchToCalculator()
	End Sub
	
	
	
	
		
	Sub IronpythonmpMath32BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("mpNum\AddIns\BackendBindings\PythonBinding\ipy.exe", " -X:Frames -X:ColorfulConsole")
	End Sub
	
	
	Sub IronpythonmpMath64BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartAppWithArgs("mpNum\AddIns\BackendBindings\PythonBinding\ipy64.exe", " -X:Frames -X:ColorfulConsole")
	End Sub
	
	
	
	
	
	
	Sub PythonmpMath32BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools2\CPython\Win32\Bin\Python.exe")
	End Sub
	
	
	
	Sub PythonmpMath64BitToolStripMenuItemClick(sender As Object, e As EventArgs)
		StartApp("..\ExternalTools2\CPython\Win64\Bin\Python.exe")
	End Sub

	
	
	
	Sub SharpDevelopPythonConsoleToolStripMenuItemClick(sender As Object, e As EventArgs)
	    Dim FName As String = "Source\PythonConsole\PythonConsole.sln"
	  	StartAppWithArgs("mpNum\bin\SharpDevelop.exe", RootDir() + FName)	
	End Sub
	
	
	
	
	Sub FunctionNavigatorToolStripMenuItemClick(sender As Object, e As EventArgs)
		ShowFunctionsDlg()
	End Sub
	
	
	
'	
'	Sub ShowChartsAndTablesManualToolStripMenuItemClick(sender As Object, e As EventArgs)
''	    StartApp("Manual\TablesAndChartsToolbox.pdf")
'	End Sub
'	
'	Sub EditChartsAndTablesManualToolStripMenuItem1Click(sender As Object, e As EventArgs)
''	    StartApp("Source\Manual\TablesAndChartsToolbox.tcp")
'	End Sub
'	
	
	
	
	Sub ViewPgfPlotsToolStripMenuItem1Click(sender As Object, e As EventArgs)
	    StartExternalApp(RootDir() + "Manual\figures")
	End Sub
	
	Sub EditPgpPlotsToolStripMenuItemClick(sender As Object, e As EventArgs)
	    StartApp("Source\Manual\mpFormulaWork.tcp")
	End Sub
	
	
	Sub EditWithTexStudioToolStripMenuItemClick(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "Source\Manual\mpFormula.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")			
	End Sub
	
	
	Sub EditWithTexStudioToolStripMenuItem1Click(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "..\mpFormulaC\Source\Manual\mpFormulaC.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")			
	End Sub
	
	
	
	Sub EditWithTexStudioToolStripMenuItem3Click(sender As Object, e As EventArgs)
	    Dim FName As String = RootDir() + "Source\Manual\mpFormulaWork.tex"
	    StartAppWithArgs("..\ExternalTools\texstudio2.8.8\texstudio.exe", FName + " --master --start-always")			
	End Sub
End Class




