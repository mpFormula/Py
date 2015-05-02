Imports System
Imports System.Console
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Strings
Imports Microsoft.Win32



Public Class InstallAddins


  Private Declare Function GetBinaryType Lib "kernel32" Alias "GetBinaryTypeA" ( _
    ByVal lpApplicationName As String, ByRef lpBinaryType As UInteger) As Boolean

  Dim xlAddinIsInstalled As Boolean, xlAddinIsInList As Boolean, CalcAddinIsInstalled As Boolean


  Const SCS_32BIT_BINARY As Long = 0 'A 32-bit Windows-based application
  Const SCS_64BIT_BINARY As Long = 6 'A 64-bit Windows-based application.
  Const SCS_DOS_BINARY As Long = 1 'An MS-DOS – based application
  Const SCS_OS216_BINARY As Long = 5 'A 16-bit OS/2-based application
  Const SCS_PIF_BINARY As Long = 3 'A PIF file that executes an MS-DOS – based application
  Const SCS_POSIX_BINARY As Long = 4 'A POSIX – based application
  Const SCS_WOW_BINARY As Long = 2 'A 16-bit Windows-based application
  
  
	
	Function RootDir32() As String
		Dim regKey As RegistryKey
		Dim RootPath As String = "Not set"
		Try
		  regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
		  RootPath =  regKey.GetValue("RootPath", "Not set")
		  regKey.Close()
		Catch ex As Exception
			MsgBox("RootDir not set")
		End Try
		Return RootPath
	End Function



  Private Function PlatFormLibInstallDir(Bits As Integer) As String
    Dim DirName As String = RootDir32()
    If Bits = 64 Then
      DirName = DirName + "mpNum\Win64\bin\"
    Else
      DirName = DirName + "mpNum\Win32\bin\"
    End If
    Return DirName
  End Function
  
  
  
  Sub DetectExcel()
    Dim objExcel As Object
    Dim xlPath As String, Bitness As UInteger, Result As Boolean
    Dim xlInfo As String
    'Dim xlAddinIsInstalled As Boolean, xlAddinIsInList As Boolean
    Try
      objExcel = CreateObject("Excel.Application")
      cbInstall_xlAddin.Enabled = True
      xlPath = objExcel.Path + "\Excel.exe"
      'WriteLine(xlPath)
      Result = GetBinaryType(xlPath, Bitness)
      Dim xlVersion As String = objExcel.Version


      Dim xlBitness As String = " (32 bit)"
      Dim AddinName As String = "mpFormula32"
      If Bitness = 6 Then
        xlBitness = " (64 bit)"
        AddinName = "mpFormula64"
      End If
      xlAddinIsInList = True
      Try
        xlAddinIsInstalled = (objExcel.AddIns(AddinName).Installed = True)
      Catch ex As Exception
        xlAddinIsInList = False
      End Try
      Dim Info2 As String
      If xlAddinIsInList = False Then
        Info2 = "NOT in list of Add-ins"
        cbInstall_xlAddin.Text = "Install Add-in"
        cbInstall_xlAddin.Checked = True
      Else
        If xlAddinIsInstalled = False Then
          Info2 = "Add-in is NOT installed"
          cbInstall_xlAddin.Text = "Install Add-in"
          cbInstall_xlAddin.Checked = False
        Else
          Info2 = "Add-in is installed"
          cbInstall_xlAddin.Text = "Uninstall Add-in"
          cbInstall_xlAddin.Checked = False
        End If
      End If

      xlInfo = "Detected Excel " + xlVersion + xlBitness + ", mpFormula " + Info2
    Catch
      xlInfo = "Could not detect any version of Excel "
      cbInstall_xlAddin.Text = "Install Add-in"
      cbInstall_xlAddin.Enabled = False
    End Try
    cbInstall_xlAddin.Visible = True
    lbl_xlInfo.Text = xlInfo
  End Sub

  Sub LoadAndInstallExcelAddin()
    Dim objExcel As Object
    Dim xlPath As String, Bitness As UInteger, Result As Boolean
    Dim AddinPath As String, AddinName As String
    Try
      objExcel = CreateObject("Excel.Application")
      xlPath = objExcel.Path + "\Excel.exe"
      Result = GetBinaryType(xlPath, Bitness)
      If Bitness = 6 Then
        AddinName = "mpFormula64"
'        AddinPath = PlatFormLibInstallDir(64) + "GUI\" + AddinName + ".xll"
		AddinPath = PlatFormLibInstallDir(64) + AddinName + ".xll"        
      Else
        AddinName = "mpFormula32"
'        AddinPath = PlatFormLibInstallDir(32) + "GUI\" + AddinName + ".xll"
        AddinPath = PlatFormLibInstallDir(32) + AddinName + ".xll"    
      End If
      objExcel.Workbooks.Add()
      objExcel.WindowState = -4140 ' xlMinimized
      objExcel.Visible = True
      objExcel.AddIns.Add(AddinPath)
      objExcel.AddIns(AddinName).Installed = True
      'objExcel.Quit()
      objExcel = Nothing
    Catch
      MsgBox("Error during installation")
    End Try
  End Sub



  Sub UninstallExcelAddin(Mode As Boolean)
    Dim objExcel As Object 'As Excel.Application
    Dim xlPath As String, Bitness As UInteger, Result As Boolean
    Dim AddinName As String
    objExcel = CreateObject("Excel.Application")
    xlPath = objExcel.Path + "\Excel.exe"
    Result = GetBinaryType(xlPath, Bitness)
    If Bitness = 6 Then
      AddinName = "mpFormula64"
    Else
      AddinName = "mpFormula32"
    End If
    objExcel.Workbooks.Add()
    objExcel.WindowState = -4140 ' xlMinimized
    objExcel.Visible = True
    objExcel.AddIns(AddinName).Installed = Mode
    'objExcel.Quit()
    objExcel = Nothing
  End Sub


  Sub InstallCalcFunctions()
    Dim oSM As Object = CreateObject("com.sun.star.ServiceManager")
    Dim oLibCont As Object = oSM.createInstance("com.sun.star.script.ApplicationScriptLibraryContainer")
    oLibCont.loadLibrary("mpFormula")
    Dim ompFunctions As Object = oLibCont.getByName("mpFormula")
    Dim oModule As Object = ompFunctions.getByName("mpFormula_Function")
    oLibCont.loadLibrary("Standard")
    Dim oStandard As Object = oLibCont.getByName("Standard")
    oStandard.insertByName("mpFormula_Function", oModule)
  End Sub


  Sub DetectCalc()
    Dim CalcInfo As String, Info2 As String
    Try
      Dim oSM As Object = CreateObject("com.sun.star.ServiceManager")
      Dim ps As Object = oSM.createInstance("com.sun.star.util.PathSubstitution")
      Dim s As String = ps.getSubstituteVariableValue("$(prog)")
      Dim u As New Uri(s)
      Dim OOoPath As String = u.LocalPath
      CalcInfo = OOoPath
      Dim listStr As String() = CalcInfo.Split("\")
      CalcInfo = "Detected " + listStr(listStr.Length - 2)
      cbInstall_CalcAddin.Enabled = True
      CalcAddinIsInstalled = False
      Try
        Dim oLibCont As Object = oSM.createInstance("com.sun.star.script.ApplicationScriptLibraryContainer")
        oLibCont.loadLibrary("Standard")
        Dim oStandard As Object = oLibCont.getByName("Standard")
        Dim oModule As Object = oStandard.getByName("mpFormula_Function")
        Info2 = ", mpFormula Add-in is installed"
        cbInstall_CalcAddin.Text = "Uninstall add-in"
        cbInstall_CalcAddin.Checked = False
        CalcAddinIsInstalled = True
      Catch ex As Exception
        Info2 = ", mpFormula Add-in is NOT installed"
        cbInstall_CalcAddin.Text = "Install add-in"
        cbInstall_CalcAddin.Checked = True
      End Try

    Catch
      CalcInfo = "Could not detect any version of Calc "
      Info2 = ""
      cbInstall_CalcAddin.Checked = False
      cbInstall_CalcAddin.Enabled = False
    End Try
    lbl_CalcInfo.Text = CalcInfo + Info2
	cbInstall_CalcAddin.Visible = True
  End Sub
  
  
  Sub InstallCalcAddin()
    Dim oSM As Object = CreateObject("com.sun.star.ServiceManager")
    Dim ps As Object = oSM.createInstance("com.sun.star.util.PathSubstitution")
    Dim s As String = ps.getSubstituteVariableValue("$(prog)")
    Dim u As New Uri(s)
    Dim OOoPath As String = u.LocalPath + "\unopkg.exe"
    OOoPath = OOoPath.ToUpper()
    OOoPath = OOoPath.Replace("\BASIS\PROGRAM\UNOPKG.EXE", "\PROGRAM\UNOPKG.EXE")
    Writeline(OOoPath)
'    Dim AddinPath As String = """" + PlatFormLibInstallDir(32) + "GUI\mpFormula.oxt" + """"
	Dim AddinPath As String = """" + PlatFormLibInstallDir(32) + "mpFormula.oxt" + """"    
    Writeline(AddinPath)
    Dim objProcess As System.Diagnostics.Process
    Try
      objProcess = New System.Diagnostics.Process()
      objProcess.StartInfo.FileName = OOoPath
      objProcess.StartInfo.Arguments = " add " + AddinPath
      objProcess.Start()
      objProcess.WaitForExit()
      objProcess.Close()
    Catch
      'MessageBox.Show("Could not start process " & OOoPath, "Error")
    End Try
    InstallCalcFunctions()
  End Sub



  Sub UnInstallCalcFunctions()
    Dim oSM As Object = CreateObject("com.sun.star.ServiceManager")
    Dim oLibCont As Object = oSM.createInstance("com.sun.star.script.ApplicationScriptLibraryContainer")
    Dim oStandard As Object = oLibCont.getByName("Standard")
    oStandard.removeByName("mpFormula_Function")
  End Sub




  Sub UnInstallCalcAddin()
    UnInstallCalcFunctions()
    Dim objServiceManager As Object = CreateObject("com.sun.star.ServiceManager")
    Dim ps As Object = objServiceManager.createInstance("com.sun.star.util.PathSubstitution")
    Dim s As String = ps.getSubstituteVariableValue("$(prog)")
    Dim u As New Uri(s)
    Dim OOoPath As String = u.LocalPath + "\unopkg.exe"
    OOoPath = OOoPath.ToUpper()
    OOoPath = OOoPath.Replace("\BASIS\PROGRAM\UNOPKG.EXE", "\PROGRAM\UNOPKG.EXE")
    Writeline(OOoPath)
    Dim AddinPath As String = "mpFormula.oxt"
    Writeline(AddinPath)
    Dim objProcess As System.Diagnostics.Process
    Try
      objProcess = New System.Diagnostics.Process()
      objProcess.StartInfo.FileName = OOoPath
      objProcess.StartInfo.Arguments = " remove " + AddinPath
      objProcess.Start()
      objProcess.WaitForExit()
      objProcess.Close()
    Catch
      'MessageBox.Show("Could not start process " & OOoPath, "Error")
    End Try
  End Sub


Sub UpdateInfo()
	lbl_xlInfo.Text="Checking...."
	lbl_CalcInfo.Text="Checking...."
		DetectExcel()
    	DetectCalc()

	End Sub
	
 

 Sub BtnMakeCalcClick(sender As Object, e As EventArgs)
  	UpdateInfo()
  End Sub

Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub

Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
	Me.Close()
    'Application.Exit()
  End Sub

  Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
    If ((xlAddinIsInList = False) And (cbInstall_xlAddin.Checked = True)) Then
      LoadAndInstallExcelAddin()
    End If
    If ((xlAddinIsInList = True) And (cbInstall_xlAddin.Checked = True)) Then
      UninstallExcelAddin(Not (xlAddinIsInstalled))
    End If
    If ((CalcAddinIsInstalled = True) And (cbInstall_CalcAddin.Checked = True)) Then
      UnInstallCalcAddin()
    End If
    If ((CalcAddinIsInstalled = False) And (cbInstall_CalcAddin.Checked = True)) Then
      InstallCalcAddin()
    End If

	Me.Close()
    'Application.Exit()
  End Sub
  

End Class
