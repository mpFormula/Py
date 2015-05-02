Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection

Imports IronPython.Hosting
Imports Microsoft.Scripting

Imports Microsoft.Scripting.Hosting
Imports Microsoft.Win32
Imports System.Text


Module Program
	
	Function RootDir() As String
		Dim regKey As RegistryKey = Nothing
		Dim RootPath As String = "Not set"
		Try
			regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
			RootPath = regKey.GetValue("RootPath", "Not set").ToString()
			regKey.Close()
		Catch generatedExceptionName As Exception
			Console.WriteLine("RootDir not set")
		End Try
		Return RootPath
	End Function
	
	Sub ReportException(e As Exception)
		Dim s As [String] = e.ToString()
		Dim l As Integer = s.Length
		If l > 1000 Then
			s = s.Substring(1, 1000)
		End If
		Console.WriteLine(s)
	End Sub


	Function GetPyEngine() As ScriptEngine
		Static PyEngine As ScriptEngine = Nothing
		If  IsNothing(PyEngine) Then
			Try
				Console.WriteLine("Setting up engine")
				Dim options = New Dictionary(Of String, Object)()
				options("Frames") = True
				options("FullFrames") = False
				PyEngine = Python.CreateEngine(options)
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyEngine
	End Function
	
	
	Function GetPyScope() As ScriptScope
		Static PyScope As ScriptScope = Nothing
		If  IsNothing(PyScope) Then
			Try
				Dim PyEngine As ScriptEngine = GetPyEngine()
	
				Dim Rd As [String] = RootDir() & "SharpDevelop\4.4\AddIns\BackendBindings\PythonBinding"
				Console.WriteLine(Rd)
				
				Dim argv = New List(Of String)()
				argv.Add(Rd)
				argv.Add(Rd & "\Lib")
				argv.Add(Rd & "\DLL")
				PyEngine.Runtime.GetSysModule().SetVariable("argv", argv)
	
				Console.WriteLine("Loading assembly")
				Dim PyAssembly As Assembly = Assembly.LoadFile(Path.GetFullPath("PythonLib1.dll"))
				PyEngine.Runtime.LoadAssembly(PyAssembly)
				Console.WriteLine("Importing module")
				PyScope = PyEngine.Runtime.ImportModule("MyModule")
				
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyScope
	End Function
	
	
	
	Function GetPyInstance() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				Dim PyScope As ScriptScope = GetPyScope()
				Console.WriteLine("Defining Scope")
				Dim PyClass As Object = PyScope.GetVariable("MyClass")
				PyInstance = PyClass()
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	

	Private Sub CompileSourceAndExecute(code As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromString(code, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
		
	End Sub
	
	

	Private Sub CompileSourceFromFileAndExecute(FName As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromFile(FName, Encoding.ASCII, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
	End Sub
	
	
	
	Function GetMp() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				PyInstance = GetPyInstance().pygetmp()
			Catch ex As Exception
				ReportException(ex)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	Function Getmpf(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympf(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Function Getmpc(z As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympf(z)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Function GetEval(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyeval(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Function GetExec(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Function GetExec2(s1 As String, s2 As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec2(s1, s2)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Sub GetExec2(s As String) 
		Try
			GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub


	Function MpMathToString(p As Object, n As Integer) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().mpmathToString(p, n), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	
	
	
	Sub SetDps(n As Integer)
		Try
			GetMp().dps = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub





	Function GetPi() As Object
		Dim Result As Object = Nothing
		Try
			Result = GetMp().pi()			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function



	Function GetSqrt(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetMp().sqrt(x)			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Function GetMp2Func(a As String, b As String) As String
		Dim Result As String = ""
		Try
			Result = GetPyInstance().mp2func(a, b)			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Sub SomeMethod()
		Try
			GetPyInstance().somemethod()
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub


	Function IsOdd(i As Integer) As Boolean
		Dim Result As Boolean = False
		Try
			Result = CType(GetPyInstance().isodd(i), Boolean)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	

	
	
	Sub TestOdd()
		Dim Result2 = True
		For i As Integer = 0 To 100000
			Result2 = IsOdd(i)
		Next
		Console.WriteLine(Result2)
	End Sub



	Function CreateCode() As String
		Dim lines As String() = { _
			"def f(x): one=mpf(1); return sqrt((one + 2*x)/(one + x))", _
			"print f(22.3)"
		}
		Return [String].Join(vbCr, lines)
	End Function

	
	Sub Main()
		Dim n As Integer = 25		
		Dim p As Object = Nothing
		SetDps(n)
		Dim Code As String = CreateCode()
		
		CompileSourceAndExecute(Code)
		
		Dim FName As String = RootDir() & "Projects\PythonFromCSharp\PythonFromVB\bin\Debug\MyModule2.py"
		CompileSourceFromFileAndExecute(FName)
		
'		p = GetExec(Code)
'		Console.WriteLine(MpMathToString(p, n))

For i=1 To 100		

		n = 100
		SetDps(n)
		p = GetPi()
		Console.WriteLine(MpMathToString(p, n))
		
next		
'		n = 200
'		SetDps(n)
'		p = GetPi()
'		Console.WriteLine(MpMathToString(p, n))
'		
'		p = GetSqrt("2 + 1j")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		
		Dim a As Object = Getmpf("44545.345345")
		Dim b As Object = Getmpf("345344.345345")
		
'		p = a + b
'		Console.WriteLine(MpMathToString(p, n))
'		
'		p = a - b
'		Console.WriteLine(MpMathToString(p, n))
'		
'		
'		p = a * b
'		Console.WriteLine(MpMathToString(p, n))
'		
'		
'		p = a / b
'		Console.WriteLine(MpMathToString(p, n))
'		
'		
'		Console.WriteLine(p.ToString())
		
		n=15
		SetDps(n)
		p = GetEval("findroot(lambda x: x**3 + 2*x + 1, j)")
		Console.WriteLine(MpMathToString(p, n))
		
'		p = GetEval("a = 2; b = 3; a + b")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		Dim s As String = ""
		
'		s = "Result = quad(sin, [0, pi])"
'		s = "f = lambda x, y: cos(x+y/2); Result = quad(f, [-pi/2, pi/2], [0, pi])"
'		p = GetExec(s)
'		Console.WriteLine(MpMathToString(p, n))
		
		Dim s1 As String = "def f(x): one=mpf(1); return sqrt((one + 2*x)/(one + x))"
		Dim s2 As String  = "Result = f(22.3)"
		p = GetExec2(s1, s2)
		Console.WriteLine(MpMathToString(p, n))
		
'		SomeMethod()
'		TestOdd()
'		
'		s = GetMp2Func("32.47","12.41")
'		Console.WriteLine(s)



		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
