Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.CodeDom.Compiler
Imports System.Reflection
Imports System.IO
Imports Microsoft.Win32


Public Class EvalProvider
	
    Public Function Eval(ByVal vbCode As String) As Object
        Dim provider As CodeDomProvider = CodeDomProvider.CreateProvider("VisualBasic")
		Dim cp As CompilerParameters = New CompilerParameters
        
        cp.ReferencedAssemblies.Add("system.dll")
        cp.ReferencedAssemblies.Add("system.xml.dll")
        cp.ReferencedAssemblies.Add("system.data.dll")
        ' Sample code for adding your own referenced assemblies
        'cp.ReferencedAssemblies.Add("c:\yourProjectDir\bin\YourBaseClass.dll")
        'cp.ReferencedAssemblies.Add("YourBaseclass.dll")
        cp.CompilerOptions = "/t:library"
        cp.GenerateInMemory = True
        Dim sb As StringBuilder = New StringBuilder("")
        sb.Append("Imports System" & vbCrLf)
        sb.Append("Imports System.Xml" & vbCrLf)
        sb.Append("Imports System.Data" & vbCrLf)
        sb.Append("Imports System.Data.SqlClient" & vbCrLf)
        sb.Append("Namespace PAB  " & vbCrLf)
        sb.Append("Class PABLib " & vbCrLf)
        
      
        sb.Append("public function  EvalCode() as Object " & vbCrLf)
        'sb.Append("YourNamespace.YourBaseClass thisObject = New YourNamespace.YourBaseClass()")
        sb.Append(vbCode & vbCrLf)
        sb.Append("End Function " & vbCrLf)
        sb.Append("End Class " & vbCrLf)
        sb.Append("End Namespace" & vbCrLf)
        Debug.WriteLine(sb.ToString()) ' look at this to debug your eval string
        Dim cr As CompilerResults = provider.CompileAssemblyFromSource(cp, sb.ToString())
        Dim a As System.Reflection.Assembly = cr.CompiledAssembly
        Dim o As Object
        Dim mi As MethodInfo
        o = a.CreateInstance("PAB.PABLib")
        Dim t As Type = o.GetType()
        mi = t.GetMethod("EvalCode")
        Dim s As Object = Nothing
        For i As Int64  = 1 To 1
        	s = mi.Invoke(o, Nothing)
        Next i	
        Return s
    End Function
    
End Class




Public Partial Class CalculatorForm
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	
	
	Function RootDir() As String
		Dim regKey As RegistryKey
		Dim RootPath As String = "Not set"
		Try
		  regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
		  RootPath = regKey.GetValue("RootPath", "Not set").ToString()
		  regKey.Close()
		Catch ex As Exception
			MsgBox("RootDir not set")
		End Try
		Return RootPath
	End Function



    Function ShowDir() As String
        Dim Dir As String = My.Application.Info.DirectoryPath
        Dim L As Integer = Dir.Length
        Dir = Dir.Substring(0, L-3)
        MsgBox(Dir)
        Return Dir
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
		Dim RootPath As String = ShowDir()
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
	
	
	
	Sub BtnEqualClick(sender As Object, e As EventArgs)
		Dim InputText As String = richTextBoxInput.Text
		Dim eval As EvalProvider = New EvalProvider()
		Dim Code As String = "Dim x As Double = " & InputText & ": Return x"
		Dim Result As Object = eval.Eval(Code)
		Dim OutputText As String = Result.ToString()
		richTextBoxOutput.Text = OutputText
	End Sub
	
	Sub StatisticsToolStripMenuItemClick(sender As Object, e As EventArgs)
	End Sub
	
	Sub MenuStrip1ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
	    
	End Sub
	
	Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
	    
	End Sub
	
	Sub ShowDirToolStripMenuItemClick(sender As Object, e As EventArgs)
	    ShowDir()
	End Sub
	
	Sub SetRegistryToolStripMenuItemClick(sender As Object, e As EventArgs)
	   MakeRootPath() 
	End Sub
	
	Sub RemoveRegistryEntryToolStripMenuItemClick(sender As Object, e As EventArgs)
	    DeleteRootPath()
	End Sub
	
	Sub DisplayRegistryEntryToolStripMenuItemClick(sender As Object, e As EventArgs)
	    ReadRootPath
	End Sub
End Class
