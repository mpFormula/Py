Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Text

Imports IronPython.Hosting
Imports Microsoft.Scripting
Imports Microsoft.Scripting.Hosting



Public Module MpAll

		Public ReadOnly Property AssemblyDirectory() As String
			Get
				Dim codeBase As String = Assembly.GetExecutingAssembly().CodeBase
				Dim uri__1 As New UriBuilder(codeBase)
				Dim path__2 As String = Uri.UnescapeDataString(uri__1.Path)
				
				Return Path.GetDirectoryName(path__2)
			End Get
		End Property

	
		Public Function RootDir() As String
			Dim RootPath As String = AssemblyDirectory() + "\..\"
			Return RootPath
		End Function

	
'	Public Function RootDir() As String
'		Dim regKey As RegistryKey = Nothing
'		Dim RootPath As String = "Not set"
'		Try
'			regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
'			RootPath = regKey.GetValue("RootPath", "Not set").ToString()
'			regKey.Close()
'		Catch generatedExceptionName As Exception
'			Console.WriteLine("RootDir not set")
'		End Try
'		Return RootPath
'	End Function
	
	
	
	
	
	Public Sub ReportException(e As Exception)
		Dim s As [String] = e.ToString()
		Dim l As Integer = s.Length
		If l > 1000 Then
			s = s.Substring(1, 1000)
		End If
		Console.WriteLine(s)
	End Sub


	Public Function GetPyEngine() As ScriptEngine
		Static PyEngine As ScriptEngine = Nothing
		If  IsNothing(PyEngine) Then
			Try
'				Console.WriteLine("Setting up engine")
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
	
	
	Public Function GetPyScope() As ScriptScope
		Static PyScope As ScriptScope = Nothing
		If  IsNothing(PyScope) Then
			Try
				Dim PyEngine As ScriptEngine = GetPyEngine()
	
				Dim Rd As [String] = RootDir() & "mpNum\AddIns\BackendBindings\PythonBinding"
'				Console.WriteLine(Rd)
				
				Dim argv = New List(Of String)()
				argv.Add(Rd)
				argv.Add(Rd & "\Lib")
				argv.Add(Rd & "\DLL")
				PyEngine.Runtime.GetSysModule().SetVariable("argv", argv)
	
'				Console.WriteLine("Loading assembly")
				Dim PyAssembly As Assembly = Assembly.LoadFile(RootDir() & "mpNum\MpMathPythonLib.dll")
				PyEngine.Runtime.LoadAssembly(PyAssembly)
				Console.WriteLine("Importing mpmath")
				PyScope = PyEngine.Runtime.ImportModule("MyModule")
				
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyScope
	End Function
	
	
	
	Public Function GetPyInstance() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				Dim PyScope As ScriptScope = GetPyScope()
'				Console.WriteLine("Defining Scope")
				Dim PyClass As Object = PyScope.GetVariable("MyClass")
				PyInstance = PyClass()
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	

	Public  Sub CompileSourceAndExecute(code As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromString(code, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
		
	End Sub
	
	

	Public  Sub CompileSourceFromFileAndExecute(FName As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromFile(FName, Encoding.ASCII, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
	End Sub
	
	
	
	Public Function GetMp() As Object
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
	
	
	Public Function GetIv() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				PyInstance = GetPyInstance().pygetiv()
			Catch ex As Exception
				ReportException(ex)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	
	
	
	Public Function GetMatrix(n As Integer, m As Integer) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pygetmatrix(n, m)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetRandMatrix(n As Integer, m As Integer) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pygetrandmatrix(n, m)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function GetMatrixItem(A As Object, n As Integer, m As Integer) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pygetmatrixitem(A, n, m)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function SetMatrixItem(A As Object, n As Integer, m As Integer, x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pysetmatrixitem(A, n, m, x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
'	Public Sub SetMatrixItem(A As Object, n As Integer, m As Integer, x As Object)
'		Try
'			GetPyInstance().pysetmatrixitem(A, n, m, x)
'		Catch ex As Exception
'			ReportException(ex)
'		End Try
'	End Sub
	
	
	
	Public Function GetIvMatrix(n As Integer, m As Integer) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pygetivmatrix(n, m)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetIvRandMatrix(n As Integer, m As Integer) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pygetivrandmatrix(n, m)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function Getmpf(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympf(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpi(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympfi(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpc(x As Object, y As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympc(x, y)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpci(x As Object, y As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympci(x, y)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetDecimal(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyDecimal(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function GetFraction(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyFraction(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function GetLong(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyLong(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Public Function GetEval(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyeval(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Public Function GetExec(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Public Function GetExec2(s1 As String, s2 As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec2(s1, s2)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Public Sub GetExec2(s As String) 
		Try
			GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	
'	Public Sub nprint2(obj As Object) 
'		Try
'			GetMp().nprint(obj)
'		Catch ex As Exception
'			ReportException(ex)
'		End Try
'	End Sub
	
	

'	Public Function MpMathToString(p As Object, n As Integer) As String
	Public Function MpMathToString(p As Object, n As Integer) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().mpmathToString(p, n), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function  DecimalToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyDecimalString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function  FractionToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyFractionString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function  LongToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyLongString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function

	
	Public Sub SetDecimalPrec(n As Integer)
		Try
			GetPyInstance().pySetDecimalPrec(n)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	
	
	Public Sub SetDps(n As Integer)
		Try
			GetMp().dps = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	
	Public Sub SetPrec(n As Integer)
		Try
			GetMp().prec = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	Public Function GetDps() As Integer
	    Dim n As Integer = 0
		Try
			n = GetMp().dps
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	Public Function GetPrec() As Integer
	    Dim n As Integer = 0
		Try
			n = GetMp().prec
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub SetPretty(n As Boolean)
		Try
			GetMp().pretty = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	Public Function GetPretty() As Boolean
	    Dim n As Boolean = False
		Try
			n = GetMp().pretty
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub Set_trap_complex(n As Boolean)
		Try
			GetMp().trap_complex = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	
	Public Function Get_trap_complex() As Boolean
	    Dim n As Boolean = False
		Try
			n = GetMp().trap_complex
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub SetIvDps(n As Integer)
		Try
			GetPyInstance().pyMpfiPrec(n)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	
    
    
    
End Module






Public Module MpMathClass
	

    Public Function GetFunction00XL(FunctionName As String,  Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction00(dps, FunctionName)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction01XL(FunctionName As String, Parameter1 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction01(dps, FunctionName, Parameter1)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction02XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction02(dps, FunctionName, Parameter1, Parameter2)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction03XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction03(dps, FunctionName, Parameter1, Parameter2, Parameter3)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction04XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction04(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction05XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction05(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction06XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction06(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction07XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction08XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction09XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Parameter9 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpAll.MpMathToString(Result, dps)
        Return s
	End Function
	
	
	
	
	
	
	
	Public Function GetFunction00(dps As Uint32, FunctionEnum As String) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
'		    Dim f As Object = GetMp().Operator.methodcaller(FunctionEnum)
'		    f(GetMp())
		    Select Case FunctionEnum
		        Case "pi": Result = MpAll.GetMp().pi()
		        Case "degree": Result = MpAll.GetMp().degree()
		        Case "e": Result = MpAll.GetMp().e()
		        Case "phi": Result = MpAll.GetMp().phi()
		        Case "euler": Result = MpAll.GetMp().euler()
		        Case "catalan": Result = MpAll.GetMp().catalan()
		        Case "apery": Result = MpAll.GetMp().apery()
		        Case "khinchin": Result = MpAll.GetMp().khinchin()
		        Case "glaisher": Result = MpAll.GetMp().glaisher()
		        Case "mertens": Result = MpAll.GetMp().mertens()
		        Case "twinprime": Result = MpAll.GetMp().twinprime()
		        Case "j": Result = MpAll.GetMp().j
		        Case "quadgl": Result = MpAll.GetMp().quadgl
		        Case "quadts": Result = MpAll.GetMp().quadts
		        Case "inf": Result = MpAll.GetMp().inf
		        Case "nan": Result = MpAll.GetMp().nan
		        Case "rand": Result = MpAll.GetMp().rand()
		        Case "eps": Result = MpAll.GetMp().eps()
		        Case "levin": Result = MpAll.GetMp().levin()
		        Case "cohen_alt": Result = MpAll.GetMp().cohen_alt()
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetFunction01(dps As Uint32, FunctionEnum As String, x1 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
	'	*********************************************
		            
		        Case "Options": Result = "mp.Options(BaseOptions, Modifiers)"
		        Case "Table": Result = "X[i,j]"
		        Case "Chart": Result = "ChartResult"
		        Case "Eval": Result = "EvalResult"
		            
		        Case "autoprec": Result = MpAll.GetMp().autoprec(x1)
		        Case "workprec": Result = MpAll.GetMp().workprec(x1)
		        Case "workdps": Result = MpAll.GetMp().workdps(x1)
		        Case "extraprec": Result = MpAll.GetMp().extraprec(x1)
		        Case "extradps": Result = MpAll.GetMp().extradps(x1)
		        Case "memoize": Result = MpAll.GetMp().memoize(x1)
		        Case "maxcalls": Result = MpAll.GetMp().maxcalls(x1)
		        Case "monitor": Result = MpAll.GetMp().monitor(x1)
		        Case "timing": Result = MpAll.GetMp().timing(x1)
	'	*********************************************
		            
		        Case "matrix": Result = MpAll.GetMp().matrix(x1)
		        Case "eye": Result = MpAll.GetMp().eye(x1)		            
		        Case "diag": Result = MpAll.GetMp().diag(x1)		            
		        Case "zeros": Result = MpAll.GetMp().zeros(x1)
		        Case "ones": Result = MpAll.GetMp().ones(x1)		            
		        Case "hilbert": Result = MpAll.GetMp().hilbert(x1)		            
		        Case "randmatrix": Result = MpAll.GetMp().randmatrix(x1)		            
		            
		        Case "lu": Result = MpAll.GetMp().lu(x1)		            
		        Case "qr": Result = MpAll.GetMp().qr(x1)		            
		        Case "cholesky": Result = MpAll.GetMp().cholesky(x1)		            
		            
		            
		        Case "det": Result = MpAll.GetMp().det(x1)		            
		        Case "cond": Result = MpAll.GetMp().cond(x1)		            
		        Case "inverse": Result = MpAll.GetMp().inverse(x1)		            
		            
		            
		        Case "mpf": Result = MpAll.GetMp().mpf(x1)
		        Case "mpc": Result = MpAll.GetMp().mpc(x1)
		        Case "convert": Result = MpAll.GetMp().convert(x1)
		        Case "chop": Result = MpAll.GetMp().chop(x1)
		        Case "nstr": Result = MpAll.GetMp().nstr(x1)
		        Case "arange": Result = MpAll.GetMp().arange(x1)
	'	*********************************************
		        Case "fabs": Result = MpAll.GetMp().fabs(x1)
		        Case "sign": Result = MpAll.GetMp().sign(x1)
		        Case "re": Result = MpAll.GetMp().re(x1)
		        Case "im": Result = MpAll.GetMp().im(x1)
		        Case "arg": Result = MpAll.GetMp().arg(x1)
		        Case "phase": Result = MpAll.GetMp().phase(x1)
		        Case "conj": Result = MpAll.GetMp().conj(x1)
		        Case "polar": Result = MpAll.GetMp().polar(x1)
		        Case "rect": Result = MpAll.GetMp().rect(x1)
	
	'	*********************************************
	
		        Case "floor": Result = MpAll.GetMp().floor(x1)
		        Case "ceil": Result = MpAll.GetMp().ceil(x1)
		        Case "nint": Result = MpAll.GetMp().nint(x1)
		        Case "frac": Result = MpAll.GetMp().frac(x1)
	
	'	*********************************************
	
		        Case "fneg": Result = MpAll.GetMp().fneg(x1)
		        Case "fsum": Result = MpAll.GetMp().fsum(x1)
		        Case "fprod": Result = MpAll.GetMp().fprod(x1)
		        Case "fdot": Result = MpAll.GetMp().fdot(x1)
		        Case "isinf": Result = MpAll.GetMp().isinf(x1)
		        Case "isnan": Result = MpAll.GetMp().isnan(x1)
		        Case "isnormal": Result = MpAll.GetMp().isnormal(x1)
		        Case "isfinite": Result = MpAll.GetMp().isfinite(x1)
		        Case "isint": Result = MpAll.GetMp().isint(x1)
		        Case "frexp": Result = MpAll.GetMp().frexp(x1)
		        Case "mag": Result = MpAll.GetMp().mag(x1)
		        Case "nint_distance": Result = MpAll.GetMp().nint_distance(x1)
	'	*********************************************
		            
		        Case "sqrt": Result = MpAll.GetMp().sqrt(x1)
		        Case "cbrt": Result = MpAll.GetMp().cbrt(x1)
		        Case "unitroots": Result = MpAll.GetMp().unitroots(x1, "primitive=False")
		        Case "exp": Result = MpAll.GetMp().exp(x1)
		        Case "expj": Result = MpAll.GetMp().expj(x1)
		        Case "expjpi": Result = MpAll.GetMp().expjpi(x1)
		        Case "expm1": Result = MpAll.GetMp().expm1(x1)
		        Case "log": Result = MpAll.GetMp().log(x1)
		        Case "ln": Result = MpAll.GetMp().ln(x1)
		        Case "ln2": Result = MpAll.GetMp().log(x1,2)
		        Case "ln10": Result = MpAll.GetMp().log10(x1)
		        Case "log10": Result = MpAll.GetMp().log10(x1)
		        Case "log2": Result = MpAll.GetMp().log(x1,2)
		        Case "lambertw": Result = MpAll.GetMp().lambertw(x1)
		            
		        Case "degrees": Result = MpAll.GetMp().degrees(x1)
		        Case "radians": Result = MpAll.GetMp().radians(x1)
		        Case "cos": Result = MpAll.GetMp().cos(x1)
		        Case "sin": Result = MpAll.GetMp().sin(x1)
		        Case "cos_sin": Result = MpAll.GetMp().cos_sin(x1)
		        Case "tan": Result = MpAll.GetMp().tan(x1)
		        Case "sec": Result = MpAll.GetMp().sec(x1)
		        Case "csc": Result = MpAll.GetMp().csc(x1)
		        Case "cot": Result = MpAll.GetMp().cot(x1)
		        Case "cospi": Result = MpAll.GetMp().cospi(x1)
		        Case "sinpi": Result = MpAll.GetMp().sinpi(x1)
		        Case "cospi_sinpi": Result = MpAll.GetMp().cospi_sinpi(x1)
		            
		            
		        Case "acos": Result = MpAll.GetMp().acos(x1)
		        Case "asin": Result = MpAll.GetMp().asin(x1)
		        Case "atan": Result = MpAll.GetMp().atan(x1)
		        Case "asec": Result = MpAll.GetMp().asec(x1)
		        Case "acsc": Result = MpAll.GetMp().acsc(x1)
		        Case "acot": Result = MpAll.GetMp().acot(x1)
		            
		        Case "sinc": Result = MpAll.GetMp().sinc(x1)
		        Case "sincpi": Result = MpAll.GetMp().sincpi(x1)
		            
		        Case "cosh": Result = MpAll.GetMp().cosh(x1)
		        Case "sinh": Result = MpAll.GetMp().sinh(x1)
		        Case "tanh": Result = MpAll.GetMp().tanh(x1)
		        Case "sech": Result = MpAll.GetMp().sech(x1)
		        Case "csch": Result = MpAll.GetMp().csch(x1)
		        Case "coth": Result = MpAll.GetMp().coth(x1)
		            
		        Case "acosh": Result = MpAll.GetMp().acosh(x1)
		        Case "asinh": Result = MpAll.GetMp().asinh(x1)
		        Case "atanh": Result = MpAll.GetMp().atanh(x1)
		        Case "asech": Result = MpAll.GetMp().asech(x1)
		        Case "acsch": Result = MpAll.GetMp().acsch(x1)
		        Case "acoth": Result = MpAll.GetMp().acoth(x1)
		            
		        Case "fac": Result = MpAll.GetMp().fac(x1)
		        Case "factorial": Result = MpAll.GetMp().factorial(x1)
		        Case "fac2": Result = MpAll.GetMp().fac2(x1)
		        Case "gamma": Result = MpAll.GetMp().gamma(x1)
		        Case "rgamma": Result = MpAll.GetMp().rgamma(x1)
		        Case "loggamma": Result = MpAll.GetMp().loggamma(x1)
		        Case "superfac": Result = MpAll.GetMp().superfac(x1)
		        Case "hyperfac": Result = MpAll.GetMp().hyperfac(x1)
		        Case "barnesg": Result = MpAll.GetMp().barnesg(x1)
		        Case "digamma": Result = MpAll.GetMp().digamma(x1)
		        Case "harmonic": Result = MpAll.GetMp().harmonic(x1)
		            
		        Case "ei": Result = MpAll.GetMp().ei(x1)
		        Case "e1": Result = MpAll.GetMp().e1(x1)
		        Case "li": Result = MpAll.GetMp().li(x1)
		        Case "ci": Result = MpAll.GetMp().ci(x1)
		        Case "si": Result = MpAll.GetMp().si(x1)
		        Case "chi": Result = MpAll.GetMp().chi(x1)
		        Case "shi": Result = MpAll.GetMp().shi(x1)
		        Case "erf": Result = MpAll.GetMp().erf(x1)
		        Case "erfc": Result = MpAll.GetMp().erfc(x1)
		        Case "erfi": Result = MpAll.GetMp().erfi(x1)
		        Case "erfinv": Result = MpAll.GetMp().erfinv(x1)
		        Case "fresnels": Result = MpAll.GetMp().fresnels(x1)
		        Case "fresnelc": Result = MpAll.GetMp().fresnelc(x1)
		            
		        Case "j0": Result = MpAll.GetMp().j0(x1)
		        Case "j1": Result = MpAll.GetMp().j1(x1)
		            
		        Case "airyai": Result = MpAll.GetMp().airyai(x1)
		        Case "airybi": Result = MpAll.GetMp().airybi(x1)
		        Case "airyaizero": Result = MpAll.GetMp().airyaizero(x1)
		        Case "airybizero": Result = MpAll.GetMp().airybizero(x1)
		            
		        Case "scorergi": Result = MpAll.GetMp().scorergi(x1)
		        Case "scorerhi": Result = MpAll.GetMp().scorerhi(x1)
		            
		        Case "qfrom": Result = MpAll.GetMp().qfrom(x1)
		        Case "qbarfrom": Result = MpAll.GetMp().qbarfrom(x1)
		        Case "mfrom": Result = MpAll.GetMp().mfrom(x1)
		        Case "kfrom": Result = MpAll.GetMp().kfrom(x1)
		        Case "taufrom": Result = MpAll.GetMp().taufrom(x1)
		        Case "ellipk": Result = MpAll.GetMp().ellipk(x1)
		        Case "ellipe": Result = MpAll.GetMp().ellipe(x1)
		            
		        Case "kleinj": Result = MpAll.GetMp().kleinj(x1)
		            
		        Case "zeta": Result = MpAll.GetMp().zeta(x1)
		        Case "altzeta": Result = MpAll.GetMp().altzeta(x1)
		        Case "stieltjes": Result = MpAll.GetMp().stieltjes(x1)
		        Case "zetazero": Result = MpAll.GetMp().zetazero(x1)
		        Case "nzeros": Result = MpAll.GetMp().nzeros(x1)
		        Case "siegelz": Result = MpAll.GetMp().siegelz(x1)
		        Case "siegeltheta": Result = MpAll.GetMp().siegeltheta(x1)
		        Case "grampoint": Result = MpAll.GetMp().grampoint(x1)
		        Case "backlunds": Result = MpAll.GetMp().backlunds(x1)
		            
		        Case "primezeta": Result = MpAll.GetMp().primezeta(x1)
		        Case "secondzeta": Result = MpAll.GetMp().secondzeta(x1)
		            
		        Case "fibonacci": Result = MpAll.GetMp().fibonacci(x1)
		        Case "fib": Result = MpAll.GetMp().fib(x1)
		        Case "bernoulli": Result = MpAll.GetMp().bernoulli(x1)
		        Case "bernfrac": Result = MpAll.GetMp().bernfrac(x1)
		        Case "eulernum": Result = MpAll.GetMp().eulernum(x1)
		            
		        Case "primepi": Result = MpAll.GetMp().primepi(x1)
		        Case "primepi2": Result = MpAll.GetMp().primepi2(x1)
		        Case "riemannr": Result = MpAll.GetMp().riemannr(x1)
		        Case "mangoldt": Result = MpAll.GetMp().mangoldt(x1)
		            
		        Case "identify": Result = MpAll.GetMp().identify(x1)
		        Case "findpoly": Result = MpAll.GetMp().findpoly(x1)
		            
		        Case "polyroots": Result = MpAll.GetMp().polyroots(x1)
		            
		        Case "richardson": Result = MpAll.GetMp().richardson(x1)
		        Case "shanks": Result = MpAll.GetMp().shanks(x1)
		            
		        Case "diffs_prod": Result = MpAll.GetMp().diffs_prod(x1)
		        Case "diffs_exp": Result = MpAll.GetMp().diffs_exp(x1)
		            
		        Case "svd_r": Result = MpAll.GetMp().svd_r(x1)
		        Case "svd_c": Result = MpAll.GetMp().svd_c(x1)
		        Case "svd": Result = MpAll.GetMp().svd(x1)
		            
		        Case "hessenberg": Result = MpAll.GetMp().hessenberg(x1)
		        Case "schur": Result = MpAll.GetMp().schur(x1)
		            
		        Case "eig": Result = MpAll.GetMp().eig(x1)
		        Case "eigsy": Result = MpAll.GetMp().eigsy(x1)
		        Case "eighe": Result = MpAll.GetMp().eighe(x1)
		        Case "eigh": Result = MpAll.GetMp().eigh(x1)
		            
		        Case "expm": Result = MpAll.GetMp().expm(x1)
		        Case "sqrtm": Result = MpAll.GetMp().sqrtm(x1)
		        Case "logm": Result = MpAll.GetMp().logm(x1)
		        Case "sinm": Result = MpAll.GetMp().sinm(x1)
		        Case "cosm": Result = MpAll.GetMp().cosm(x1)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


		Public Sub bar(x As Integer, <ParamDictionary> kwargs As IDictionary )
			For Each key In kwargs
				Console.WriteLine("key: {0}, value: {1} ", key, kwargs(key))
			Next
		End Sub




	Public Function GetFunction02Kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, StrArgs As String) As Object
	    Dim Result As Object = Nothing
	    
	    
'	    GetPyInstance().pyeval(s)
	    
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		            
		        Case "findroot": Result = MpAll.GetPyInstance().findroot1d(x1, x2, StrArgs)
		        Case "quad": Result = MpAll.GetPyInstance().quad1d(x1, x2, StrArgs)
		        Case "nsum": Result = MpAll.GetPyInstance().nsum1d(x1, x2, StrArgs)

		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	
	
	
	
	
	Public Function GetFunction02(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object) As Object
	    Dim Result As Object = Nothing
	    
	    
'	    GetPyInstance().pyeval(s)
	    
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "mpc": Result = MpAll.GetMp().mpc(x1, x2)
		        Case "matrix": Result = MpAll.GetMp().matrix(x1, x2)
		        Case "norm": Result = MpAll.GetMp().norm(x1, x2)
		        Case "mnorm": Result = MpAll.GetMp().mnorm(x1, x2)
		            
		        Case "lu_solve": Result = MpAll.GetMp().lu_solve(x1, x2)
		        Case "qr_solve": Result = MpAll.GetMp().qr_solve(x1, x2)
		        Case "cholesky_solve": Result = MpAll.GetMp().cholesky_solve(x1, x2)
		            
		        Case "powm": Result = MpAll.GetMp().powm(x1, x2)
		            
		        Case "unitvector": Result = MpAll.GetMp().unitvector(x1, x2)
	'	*********************************************
		        Case "fadd": Result = MpAll.GetMp().fadd(x1, x2)
		        Case "fsub": Result = MpAll.GetMp().fsub(x1, x2)
		        Case "fmul": Result = MpAll.GetMp().fmul(x1, x2)
		        Case "fdiv": Result = MpAll.GetMp().fdiv(x1, x2)
		        Case "fmod": Result = MpAll.GetMp().fmod(x1, x2)
		        Case "almosteq": Result = MpAll.GetMp().almosteq(x1, x2)
		        Case "ldexp": Result = MpAll.GetMp().ldexp(x1, x2)
		        Case "chop": Result = MpAll.GetMp().chop(x1, x2)
		        Case "fraction": Result = MpAll.GetMp().fraction(x1, x2)
		        Case "linspace": Result = MpAll.GetMp().linspace(x1, x2)
	'	*********************************************
'		        Case "nsum": Result = GetPyInstance().nsum1(x1, x2)
		        Case "sumem": Result = MpAll.GetPyInstance().sumem(x1, x2)
		        Case "sumap": Result = MpAll.GetPyInstance().sumap(x1, x2)
		            
		            
		        Case "nprod": Result = MpAll.GetPyInstance().nprod(x1, x2)
		        Case "limit": Result = MpAll.GetPyInstance().limit(x1, x2)
		            
		        Case "diff": Result = MpAll.GetPyInstance().diff2(x1, x2)
		        Case "diffs": Result = MpAll.GetPyInstance().diffs(x1, x2)
		        Case "diﬀerint": Result = MpAll.GetPyInstance().diﬀerint(x1, x2)
		            
		        Case "quadosc": Result = MpAll.GetPyInstance().quadosc(x1, x2)
		            
		            
		        Case "hypot": Result = MpAll.GetMp().hypot(x1, x2)
		        Case "power": Result = MpAll.GetMp().power(x1, x2)
		        Case "powm1": Result = MpAll.GetMp().powm1(x1, x2)
		        Case "logb": Result = MpAll.GetMp().log(x1, x2)
		        Case "lambertw_k": Result = MpAll.GetMp().lambertw(x1, x2)
		        Case "agm": Result = MpAll.GetMp().agm(x1, x2)
		        Case "atan2": Result = MpAll.GetMp().atan2(x1, x2)
		        Case "binomial": Result = MpAll.GetMp().binomial(x1, x2)
		        Case "rf": Result = MpAll.GetMp().rf(x1, x2)
		        Case "ff": Result = MpAll.GetMp().ff(x1, x2)
		        Case "gammaprod": Result = MpAll.GetMp().gammaprod(x1, x2)
		        Case "hypercomb": Result = MpAll.GetMp().hypercomb(x1, x2)
		        Case "beta": Result = MpAll.GetMp().beta(x1, x2)
		        Case "psi": Result = MpAll.GetMp().psi(x1, x2)
		        Case "polygamma": Result = MpAll.GetMp().polygamma(x1, x2)
		            
		        Case "gammainc": Result = MpAll.GetMp().gammainc(x1, 0, x2, True)
		        Case "expint": Result = MpAll.GetMp().expint(x1, x2)
		            
		        Case "besselj": Result = MpAll.GetMp().besselj(x1, x2)
		        Case "bessely": Result = MpAll.GetMp().bessely(x1, x2)
		        Case "besseli": Result = MpAll.GetMp().besseli(x1, x2)
		        Case "besselk": Result = MpAll.GetMp().besselk(x1, x2)
		        Case "besseljzero": Result = MpAll.GetMp().besseljzero(x1, x2)
		        Case "besselyzero": Result = MpAll.GetMp().besselyzero(x1, x2)
		        Case "hankel1": Result = MpAll.GetMp().hankel1(x1, x2)
		        Case "hankel2": Result = MpAll.GetMp().hankel2(x1, x2)
		            
		        Case "ber": Result = MpAll.GetMp().ber(x1, x2)
		        Case "bei": Result = MpAll.GetMp().bei(x1, x2)
		        Case "ker": Result = MpAll.GetMp().ker(x1, x2)
		        Case "kei": Result = MpAll.GetMp().kei(x1, x2)
		            
		        Case "struveh": Result = MpAll.GetMp().struveh(x1, x2)
		        Case "struvel": Result = MpAll.GetMp().struvel(x1, x2)
		        Case "angerj": Result = MpAll.GetMp().angerj(x1, x2)
		        Case "webere": Result = MpAll.GetMp().webere(x1, x2)
		            
		        Case "airyaideriv": Result = MpAll.GetMp().airyaideriv(x1, x2)
		        Case "airybideriv": Result = MpAll.GetMp().airybideriv(x1, x2)
		        Case "airyaiderivzero": Result = MpAll.GetMp().airyaiderivzero(x1, x2)
		        Case "airybiderivzero": Result = MpAll.GetMp().airybiderivzero(x1, x2)
		            
		        Case "coulombc": Result = MpAll.GetMp().coulombc(x1, x2)
		        Case "pcfd": Result = MpAll.GetMp().pcfd(x1, x2)
		        Case "pcfu": Result = MpAll.GetMp().pcfu(x1, x2)
		        Case "pcfv": Result = MpAll.GetMp().pcfv(x1, x2)
		        Case "pcfw": Result = MpAll.GetMp().pcfw(x1, x2)
		            
		        Case "legendre": Result = MpAll.GetMp().legendre(x1, x2)
		        Case "chebyt": Result = MpAll.GetMp().chebyt(x1, x2)
		        Case "chebyu": Result = MpAll.GetMp().chebyu(x1, x2)
		        Case "hermite": Result = MpAll.GetMp().hermite(x1, x2)
		            
		        Case "hyp0f1": Result = MpAll.GetMp().hyp0f1(x1, x2)
		            
		        Case "ellipf": Result = MpAll.GetMp().ellipf(x1, x2)
		        Case "ellipe": Result = MpAll.GetMp().ellipe(x1, x2)
		        Case "ellippi": Result = MpAll.GetMp().ellippi(x1, x2)
		        Case "elliprc": Result = MpAll.GetMp().elliprc(x1, x2)
		            
		        Case "zeta": Result = MpAll.GetMp().zeta(x1, x2)
		        Case "hurwitz": Result = MpAll.GetMp().hurwitz(x1, x2)
		            
		        Case "dirichlet": Result = MpAll.GetMp().dirichlet(x1, x2)
		        Case "stieltjes": Result = MpAll.GetMp().stieltjes(x1, x2)
		            
		        Case "polylog": Result = MpAll.GetMp().polylog(x1, x2)
		        Case "clsin": Result = MpAll.GetMp().clsin(x1, x2)
		        Case "clcos": Result = MpAll.GetMp().clcos(x1, x2)
		        Case "polyexp": Result = MpAll.GetMp().polyexp(x1, x2)
		            
		        Case "bernpoly": Result = MpAll.GetMp().bernpoly(x1, x2)
		        Case "eulerpoly": Result = MpAll.GetMp().eulerpoly(x1, x2)
		        Case "bell": Result = MpAll.GetMp().bell(x1, x2)
		        Case "stirling1": Result = MpAll.GetMp().stirling1(x1, x2)
		        Case "stirling2": Result = MpAll.GetMp().stirling2(x1, x2)
		        Case "cyclotomic": Result = MpAll.GetMp().cyclotomic(x1, x2)
		            
		        Case "qgamma": Result = MpAll.GetMp().qgamma(x1, x2)
		        Case "qfac": Result = MpAll.GetMp().qfac(x1, x2)
		        Case "ﬁndpoly": Result = MpAll.GetMp().ﬁndpoly(x1, x2)
		        Case "pslq": Result = MpAll.GetMp().pslq(x1, x2)
		            
		        Case "polyval": Result = MpAll.GetMp().polyval(x1, x2)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction03(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "diff": Result = MpAll.GetPyInstance().diff3(x1, x2, x3)
		            
		        Case "odefun": Result = MpAll.GetPyInstance().odefun(x1, x2, x3)
		            
		            
		        Case "taylor": Result = MpAll.GetPyInstance().taylor(x1, x2, x3)
		            
		        Case "pade": Result = MpAll.GetPyInstance().pade(x1, x2, x3)
		            
		        Case "chebyfit": Result = MpAll.GetPyInstance().chebyfit(x1, x2, x3)
		            
		        Case "fourier": Result = MpAll.GetPyInstance().fourier(x1, x2, x3)
		            
		        Case "fourierval": Result = MpAll.GetPyInstance().fourierval(x1, x2, x3)
		            
		            
		            
		            
		        Case "nthroot": Result = MpAll.GetMp().nthroot(x1, x2, x3)
		        Case "root": Result = MpAll.GetMp().root(x1, x2, x3)
		            
		        Case "betainc": Result = MpAll.GetMp().betainc(x1, x2, 0, x3, True)
		        Case "npdf": Result = MpAll.GetMp().npdf(x1, x2, x3)
		        Case "ncdf": Result = MpAll.GetMp().ncdf(x1, x2, x3)
		            
		        Case "besseljderiv": Result = MpAll.GetMp().besselj(x1, x2, x3)
		        Case "besselyderiv": Result = MpAll.GetMp().bessely(x1, x2, x3)
		        Case "besselideriv": Result = MpAll.GetMp().besseli(x1, x2, x3)
		        Case "besselkderiv": Result = MpAll.GetMp().besselk(x1, x2, x3)
		        Case "besseljzeroderiv": Result = MpAll.GetMp().besseljzero(x1, x2, x3)
		        Case "besselyzeroderiv": Result = MpAll.GetMp().besselyzero(x1, x2, x3)
		            
		        Case "lommels1": Result = MpAll.GetMp().lommels1(x1, x2, x3)
		        Case "lommels2": Result = MpAll.GetMp().lommels2(x1, x2, x3)
		            
		        Case "coulombf": Result = MpAll.GetMp().coulombf(x1, x2, x3)
		        Case "coulombg": Result = MpAll.GetMp().coulombg(x1, x2, x3)
		            
		        Case "hyperu": Result = MpAll.GetMp().hyperu(x1, x2, x3)
		        Case "whitm": Result = MpAll.GetMp().whitm(x1, x2, x3)
		        Case "whitw": Result = MpAll.GetMp().whitw(x1, x2, x3)
		            
		        Case "legenp": Result = MpAll.GetMp().legenp(x1, x2, x3)
		        Case "legenq": Result = MpAll.GetMp().legenq(x1, x2, x3)
		        Case "gegenbauer": Result = MpAll.GetMp().gegenbauer(x1, x2, x3)
		        Case "laguerre": Result = MpAll.GetMp().laguerre(x1, x2, x3)
		            
		        Case "hyp1f1": Result = MpAll.GetMp().hyp1f1(x1, x2, x3)
		        Case "hyp2f0": Result = MpAll.GetMp().hyp2f0(x1, x2, x3)
		        Case "hyper": Result = MpAll.GetMp().hyper(x1, x2, x3)
		        Case "bihyper": Result = MpAll.GetMp().bihyper(x1, x2, x3)
		            
		        Case "ellippi": Result = MpAll.GetMp().ellippi(x1, x2, x3)
		        Case "elliprf": Result = MpAll.GetMp().elliprf(x1, x2, x3)
		        Case "elliprd": Result = MpAll.GetMp().elliprd(x1, x2, x3)
		        Case "elliprg": Result = MpAll.GetMp().elliprg(x1, x2, x3)
		            
		        Case "jtheta": Result = MpAll.GetMp().jtheta(x1, x2, x3)
		        Case "ellipfun": Result = MpAll.GetMp().ellipfun(x1, x2, x3)
		            
		        Case "zeta": Result = MpAll.GetMp().zeta(x1, x2, x3)
		        Case "dirichlet": Result = MpAll.GetMp().dirichlet(x1, x2, x3)
		        Case "lerchphi": Result = MpAll.GetMp().lerchphi(x1, x2, x3)
		            
		        Case "stirling1": Result = MpAll.GetMp().stirling1(x1, x2, x3)
		        Case "stirling2": Result = MpAll.GetMp().stirling2(x1, x2, x3)
		            
		        Case "qp": Result = MpAll.GetMp().qp(x1, x2, x3)
		            
		        Case "eig_sort": Result = MpAll.GetMp().eig_sort(x1, x2, x3)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	



	Public Function GetFunction03kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, StrArgs As String) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
'		        Case "diff": Result = GetPyInstance().diff3(x1, x2, x3)
		        Case "nsum2d": Result = MpAll.GetPyInstance().nsum2d(x1, x2, x3, StrArgs)
		        Case "quad2d": Result = MpAll.GetPyInstance().quad2d(x1, x2, x3, StrArgs)
		            
		            
		        Case Else: Result = "GetFunction03kwargs: Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	




	Public Function GetFunction04(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "jacobi": Result = MpAll.GetMp().jacobi(x1, x2, x3, x4)
		        Case "spherharm": Result = MpAll.GetMp().spherharm(x1, x2, x3, x4)
		        Case "hyp1f2": Result = MpAll.GetMp().hyp1f2(x1, x2, x3, x4)
		        Case "hyp2f1": Result = MpAll.GetMp().hyp2f1(x1, x2, x3, x4)
		            
		        Case "meijerg": Result = MpAll.GetMp().meijerg(x1, x2, x3, x4)
		        Case "hyper2d": Result = MpAll.GetMp().hyper2d(x1, x2, x3, x4)
		            
		        Case "elliprj": Result = MpAll.GetMp().elliprj(x1, x2, x3, x4)
		        Case "jtheta": Result = MpAll.GetMp().jtheta(x1, x2, x3, x4)
		            
		        Case "qhyper": Result = MpAll.GetMp().qhyper(x1, x2, x3, x4)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction04kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, StrArgs As String) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "nsum3d": Result = MpAll.GetPyInstance().nsum3d(x1, x2, x3, x4, StrArgs)
		        Case "quad3d": Result = MpAll.GetPyInstance().quad3d(x1, x2, x3, x4, StrArgs)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction05(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "hyp2f2": Result = MpAll.GetMp().hyp2f2(x1, x2, x3, x4, x5)
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction06(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "hyp2f3": Result = MpAll.GetMp().hyp2f3(x1, x2, x3, x4, x5, x6)
		        Case "hyp3f2": Result = MpAll.GetMp().hyp3f2(x1, x2, x3, x4, x5, x6)
		        Case "appellf1": Result = MpAll.GetMp().appellf1(x1, x2, x3, x4, x5, x6)
		        Case "appellf4": Result = MpAll.GetMp().appellf4(x1, x2, x3, x4, x5, x6)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	
	
	
	Public Function GetFunction07(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "appellf2": Result = MpAll.GetMp().appellf2(x1, x2, x3, x4, x5, x6, 7)
		        Case "appellf3": Result = MpAll.GetMp().appellf3(x1, x2, x3, x4, x5, x6, 7)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	

	
	'***************************************************************************************************************
	

	Public Function GetPi() As Object
		Dim Result As Object = Nothing
		Try
			Result = MpAll.GetMp().pi()			
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function
	
	



	Public Function GetSqrt(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = MpAll.GetMp().sqrt(x)			
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function
	

	Function GetMp2Func(a As String, b As String) As String
		Dim Result As String = ""
		Try
			Result = MpAll.GetPyInstance().mp2func(a, b)			
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function


	Public Sub SomeMethod()
		Try
			MpAll.GetPyInstance().somemethod()
		Catch e As Exception
			MpAll.ReportException(e)
		End Try
	End Sub


	Public Function IsOdd(i As Integer) As Boolean
		Dim Result As Boolean = False
		Try
			Result = CType(MpAll.GetPyInstance().isodd(i), Boolean)
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	

	
	
	Public Sub TestOdd()
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


	Public Function PiString() As String
		Dim n As Integer = 25	
		Dim p As Object = Nothing
			MpAll.SetDps(n)
			p = GetPi()
			Dim s As String
			s=(MpAll.MpMathToString(p, n))
		Return s
	End Function


    Public Sub DemoMpf()
        Dim n As Integer = 1000
        MpAll.SetDps(n)
		Dim a As Object = MpAll.Getmpf("123E+300")
		Dim b As Object = MpAll.Getmpf("456E-300")
		Console.WriteLine("Start Mpf")
		Dim c = a + b
		Dim s = MpAll.MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpfi()
        Dim n As Integer = 1000
        MpAll.SetIvDps(n)
		Dim a As Object = MpAll.Getmpi("123E+300")
		Dim b As Object = MpAll.Getmpi("456E-300")
		Console.WriteLine("Start Mpfi")
		Dim c = a + b
		Dim s = MpAll.MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpc()
        Dim n As Integer = 1000
        MpAll.SetDps(n)
		Dim a As Object = MpAll.Getmpc("123E+300", "8.123E+300")
		Dim b As Object = MpAll.Getmpc("4.56E-300", "87854.123E-230")
		Console.WriteLine("Start Mpc")
		Dim c = a + b
		Dim s = MpAll.MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpci()
        Dim n As Integer = 30
        MpAll.SetIvDps(n)
		Dim a As Object = MpAll.Getmpci("123E+30", "78.9")
		Dim b As Object = MpAll.Getmpci("456E+30",  "78.9")
		Console.WriteLine("Start Mpci")
'		Dim c = GetPyInstance().pyMpciAdd(a, b)
		Dim c As Object = a + b
		Dim s = MpAll.MpMathToString(c, n)
		Console.WriteLine("c = a + b")
		Console.WriteLine(s)
		Dim d As Object = MpAll.GetIv().sin(c)	
		Dim s1 = MpAll.MpMathToString(d, n)
		Console.WriteLine("d = sin(c)")
		Console.WriteLine(s1)
	End Sub
	
	
    Public Sub DemoDecimal()
        Dim n As Integer = 1000
        MpAll.SetDecimalPrec(n)
		Dim a As Object = MpAll.GetDecimal("123E+300")
		Dim b As Object = MpAll.GetDecimal("456E-300")
		Console.WriteLine("Start Decimal")
		Dim c = a + b
		Dim s = MpAll.DecimalToString(c)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoFraction()
		Dim a As Object = MpAll.GetFraction("3/7000")
		Dim b As Object = MpAll.GetFraction("7000/3")
		Console.WriteLine("Start Fraction")
		Dim c = a + b
		Dim s = MpAll.FractionToString(c)
		Console.WriteLine(s)
	End Sub
	
	
	
    Public Sub DemoLong()
		Dim a As Object = MpAll.GetLong("2345234234252454")
		Dim b As Object = MpAll.GetLong("6574565635434523423423")
		Console.WriteLine("Start Long")
		Dim c = a * b
		Dim s = MpAll.LongToString(c)
		Console.WriteLine(s)
	End Sub
	

	Public Sub DemoMain()
		Dim n As Integer = 25
		Dim p As Object = Nothing
		
		
		MpAll.SetDps(n)
		Dim Code As String = CreateCode()
		
		MpAll.CompileSourceAndExecute(Code)
		
'		Dim FName As String = RootDir() & "Projects\PythonFromCSharp\PythonFromVB\MyModule2.py"
'		CompileSourceFromFileAndExecute(FName)
		
'		p = GetExec(Code)
'		Console.WriteLine(MpMathToString(p, n))

        For i=1 To 100		
    		n = 100
    		MpAll.SetDps(n)
    		p = GetPi()
    		Console.WriteLine(MpAll.MpMathToString(p, n))
        next		
'		n = 200
'		SetDps(n)
'		p = GetPi()
'		Console.WriteLine(MpMathToString(p, n))
'		
'		p = GetSqrt("2 + 1j")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		
		Dim a As Object = MpAll.Getmpf("44545.345345")
		Dim b As Object = MpAll.Getmpf("345344.345345")
		
		p = a + b
		Console.WriteLine(MpAll.MpMathToString(p, n))
		
		p = a - b
		Console.WriteLine(MpAll.MpMathToString(p, n))
		
		
		p = a * b
		Console.WriteLine(MpAll.MpMathToString(p, n))
		
		
		p = a / b
		Console.WriteLine(MpAll.MpMathToString(p, n))
'		
'		
'		Console.WriteLine(p.ToString())
		
		n=15
		MpAll.SetDps(n)
		p = MpAll.GetEval("findroot(lambda x: x**3 + 2*x + 1, j)")
		Console.WriteLine(MpAll.MpMathToString(p, n))
		
'		p = GetEval("a = 2; b = 3; a + b")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		Dim s As String = ""
		
'		s = "Result = quad(sin, [0, pi])"
'		s = "f = lambda x, y: cos(x+y/2); Result = quad(f, [-pi/2, pi/2], [0, pi])"
'		p = GetExec(s)
'		Console.WriteLine(MpMathToString(p, n))
		
		Dim s1 As String = "def f(x): one=mpf(1); return sqrt((one + 2*x)/(one + x))"
		Dim s2 As String  = "Result = f(22.3)"
		p = MpAll.GetExec2(s1, s2)
		Console.WriteLine(MpAll.MpMathToString(p, n))
		
'		SomeMethod()
'		TestOdd()
'		
'		s = GetMp2Func("32.47","12.41")
'		Console.WriteLine(s)
	End Sub
	
	
	
	
End Module







Public Module ivMathClass
	
	
	
	Public Function GetFunction00(dps As Uint32, FunctionEnum As String) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
'		    Dim f As Object = GetMp().Operator.methodcaller(FunctionEnum)
'		    f(GetMp())
		    Select Case FunctionEnum
		        Case "pi": Result = MpAll.GetIv().pi()
		        Case "degree": Result = MpAll.GetIv().degree()
		        Case "e": Result = MpAll.GetIv().e()
		        Case "phi": Result = MpAll.GetIv().phi()
		        Case "euler": Result = MpAll.GetIv().euler()
		        Case "catalan": Result = MpAll.GetIv().catalan()
		        Case "apery": Result = MpAll.GetIv().apery()
		        Case "khinchin": Result = MpAll.GetIv().khinchin()
		        Case "glaisher": Result = MpAll.GetIv().glaisher()
		        Case "mertens": Result = MpAll.GetIv().mertens()
		        Case "twinprime": Result = MpAll.GetIv().twinprime()
		        Case "j": Result = MpAll.GetIv().j
		        Case "quadgl": Result = MpAll.GetIv().quadgl
		        Case "quadts": Result = MpAll.GetIv().quadts
		        Case "inf": Result = MpAll.GetIv().inf
		        Case "nan": Result = MpAll.GetIv().nan
		        Case "rand": Result = MpAll.GetIv().rand()
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetFunction01(dps As Uint32, FunctionEnum As String, x1 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
	'	*********************************************
		            
		        Case "matrix": Result = MpAll.GetIv().matrix(x1)
		        Case "eye": Result = MpAll.GetIv().eye(x1)		            
		        Case "diag": Result = MpAll.GetIv().diag(x1)		            
		        Case "zeros": Result = MpAll.GetIv().zeros(x1)
		        Case "ones": Result = MpAll.GetIv().ones(x1)		            
		        Case "hilbert": Result = MpAll.GetIv().hilbert(x1)		            
		        Case "randmatrix": Result = MpAll.GetIv().randmatrix(x1)		            
		            
		        Case "lu": Result = MpAll.GetIv().lu(x1)		            
		        Case "qr": Result = MpAll.GetIv().qr(x1)		            
		        Case "cholesky": Result = MpAll.GetIv().cholesky(x1)		            
		            
		            
		        Case "det": Result = MpAll.GetIv().det(x1)		            
		        Case "cond": Result = MpAll.GetIv().cond(x1)		            
		        Case "inverse": Result = MpAll.GetIv().inverse(x1)		            
		            
		            
		        Case "mpf": Result = MpAll.GetIv().mpf(x1)
		        Case "mpc": Result = MpAll.GetIv().mpc(x1)
		        Case "convert": Result = MpAll.GetIv().convert(x1)
		        Case "chop": Result = MpAll.GetIv().chop(x1)
		        Case "nstr": Result = MpAll.GetIv().nstr(x1)
		        Case "arange": Result = MpAll.GetIv().arange(x1)
	'	*********************************************
		        Case "fabs": Result = MpAll.GetIv().fabs(x1)
		        Case "sign": Result = MpAll.GetIv().sign(x1)
		        Case "re": Result = MpAll.GetIv().re(x1)
		        Case "im": Result = MpAll.GetIv().im(x1)
		        Case "arg": Result = MpAll.GetIv().arg(x1)
		        Case "phase": Result = MpAll.GetIv().phase(x1)
		        Case "conj": Result = MpAll.GetIv().conj(x1)
		        Case "polar": Result = MpAll.GetIv().polar(x1)
		        Case "rect": Result = MpAll.GetIv().rect(x1)
	
	'	*********************************************
	
		        Case "floor": Result = MpAll.GetIv().floor(x1)
		        Case "ceil": Result = MpAll.GetIv().ceil(x1)
		        Case "nint": Result = MpAll.GetIv().nint(x1)
		        Case "frac": Result = MpAll.GetIv().frac(x1)
	
	'	*********************************************
	
		        Case "fneg": Result = MpAll.GetIv().fneg(x1)
		        Case "fsum": Result = MpAll.GetIv().fsum(x1)
		        Case "fprod": Result = MpAll.GetIv().fprod(x1)
		        Case "fdot": Result = MpAll.GetIv().fdot(x1)
		        Case "isinf": Result = MpAll.GetIv().isinf(x1)
		        Case "isnan": Result = MpAll.GetIv().isnan(x1)
		        Case "isnormal": Result = MpAll.GetIv().isnormal(x1)
		        Case "isfinite": Result = MpAll.GetIv().isfinite(x1)
		        Case "isint": Result = MpAll.GetIv().isint(x1)
		        Case "frexp": Result = MpAll.GetIv().frexp(x1)
		        Case "mag": Result = MpAll.GetIv().mag(x1)
		        Case "nint_distance": Result = MpAll.GetIv().nint_distance(x1)
	'	*********************************************
		            
		        Case "sqrt": Result = MpAll.GetIv().sqrt(x1)
		        Case "cbrt": Result = MpAll.GetIv().cbrt(x1)
		        Case "unitroots": Result = MpAll.GetIv().unitroots(x1, "primitive=False")
		        Case "exp": Result = MpAll.GetIv().exp(x1)
		        Case "expj": Result = MpAll.GetIv().expj(x1)
		        Case "expjpi": Result = MpAll.GetIv().expjpi(x1)
		        Case "expm1": Result = MpAll.GetIv().expm1(x1)
		        Case "log": Result = MpAll.GetIv().log(x1)
		        Case "ln": Result = MpAll.GetIv().ln(x1)
		        Case "ln2": Result = MpAll.GetIv().log(x1,2)
		        Case "ln10": Result = MpAll.GetIv().log10(x1)
		        Case "log10": Result = MpAll.GetIv().log10(x1)
		        Case "log2": Result = MpAll.GetIv().log(x1,2)
'		        Case "lambertw": Result = MpAll.GetIv().lambertw(x1)
		            
		        Case "degrees": Result = MpAll.GetIv().degrees(x1)
		        Case "radians": Result = MpAll.GetIv().radians(x1)
		        Case "cos": Result = MpAll.GetIv().cos(x1)
		        Case "sin": Result = MpAll.GetIv().sin(x1)
		        Case "cos_sin": Result = MpAll.GetIv().cos_sin(x1)
		        Case "tan": Result = MpAll.GetIv().tan(x1)
		        Case "sec": Result = MpAll.GetIv().sec(x1)
		        Case "csc": Result = MpAll.GetIv().csc(x1)
		        Case "cot": Result = MpAll.GetIv().cot(x1)
		        Case "cospi": Result = MpAll.GetIv().cospi(x1)
		        Case "sinpi": Result = MpAll.GetIv().sinpi(x1)
		        Case "cospi_sinpi": Result = MpAll.GetIv().cospi_sinpi(x1)
		            
		            
		        Case "acos": Result = MpAll.GetIv().acos(x1)
		        Case "asin": Result = MpAll.GetIv().asin(x1)
		        Case "atan": Result = MpAll.GetIv().atan(x1)
		        Case "asec": Result = MpAll.GetIv().asec(x1)
		        Case "acsc": Result = MpAll.GetIv().acsc(x1)
		        Case "acot": Result = MpAll.GetIv().acot(x1)
		            
		        Case "sinc": Result = MpAll.GetIv().sinc(x1)
		        Case "sincpi": Result = MpAll.GetIv().sincpi(x1)
		            
		        Case "cosh": Result = MpAll.GetIv().cosh(x1)
		        Case "sinh": Result = MpAll.GetIv().sinh(x1)
		        Case "tanh": Result = MpAll.GetIv().tanh(x1)
		        Case "sech": Result = MpAll.GetIv().sech(x1)
		        Case "csch": Result = MpAll.GetIv().csch(x1)
		        Case "coth": Result = MpAll.GetIv().coth(x1)
		            
		        Case "acosh": Result = MpAll.GetIv().acosh(x1)
		        Case "asinh": Result = MpAll.GetIv().asinh(x1)
		        Case "atanh": Result = MpAll.GetIv().atanh(x1)
		        Case "asech": Result = MpAll.GetIv().asech(x1)
		        Case "acsch": Result = MpAll.GetIv().acsch(x1)
		        Case "acoth": Result = MpAll.GetIv().acoth(x1)
		            
		        Case "fac": Result = MpAll.GetIv().fac(x1)
		        Case "factorial": Result = MpAll.GetIv().factorial(x1)
		        Case "fac2": Result = MpAll.GetIv().fac2(x1)
		        Case "gamma": Result = MpAll.GetIv().gamma(x1)
		        Case "rgamma": Result = MpAll.GetIv().rgamma(x1)
		        Case "loggamma": Result = MpAll.GetIv().loggamma(x1)
		            
		        Case "svd_r": Result = MpAll.GetIv().svd_r(x1)
		        Case "svd_c": Result = MpAll.GetIv().svd_c(x1)
		        Case "svd": Result = MpAll.GetIv().svd(x1)
		            
		        Case "hessenberg": Result = MpAll.GetIv().hessenberg(x1)
		        Case "schur": Result = MpAll.GetIv().schur(x1)
		            
		        Case "eig": Result = MpAll.GetIv().eig(x1)
		        Case "eigsy": Result = MpAll.GetIv().eigsy(x1)
		        Case "eighe": Result = MpAll.GetIv().eighe(x1)
		        Case "eigh": Result = MpAll.GetIv().eigh(x1)
		            
		        Case "expm": Result = MpAll.GetIv().expm(x1)
		        Case "sqrtm": Result = MpAll.GetIv().sqrtm(x1)
		        Case "logm": Result = MpAll.GetIv().logm(x1)
		        Case "sinm": Result = MpAll.GetIv().sinm(x1)
		        Case "cosm": Result = MpAll.GetIv().cosm(x1)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	


		Public Sub bar(x As Integer, <ParamDictionary> kwargs As IDictionary )
			For Each key In kwargs
				Console.WriteLine("key: {0}, value: {1} ", key, kwargs(key))
			Next
		End Sub


	
	
	Public Function GetFunction02(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object) As Object
	    Dim Result As Object = Nothing
	    
	    
'	    GetPyInstance().pyeval(s)
	    
		Try
		    MpAll.SetDps(dps)
		    Select Case FunctionEnum
		        Case "mpc": Result = MpAll.GetMp().mpc(x1, x2)
		        Case "matrix": Result = MpAll.GetMp().matrix(x1, x2)
		        Case "norm": Result = MpAll.GetMp().norm(x1, x2)
		        Case "mnorm": Result = MpAll.GetMp().mnorm(x1, x2)
		            
		        Case "lu_solve": Result = MpAll.GetMp().lu_solve(x1, x2)
		        Case "qr_solve": Result = MpAll.GetMp().qr_solve(x1, x2)
		        Case "cholesky_solve": Result = MpAll.GetMp().cholesky_solve(x1, x2)
		            
		        Case "powm": Result = MpAll.GetMp().powm(x1, x2)
		            
		        Case "unitvector": Result = MpAll.GetMp().unitvector(x1, x2)
	'	*********************************************
		        Case "fadd": Result = MpAll.GetMp().fadd(x1, x2)
		        Case "fsub": Result = MpAll.GetMp().fsub(x1, x2)
		        Case "fmul": Result = MpAll.GetMp().fmul(x1, x2)
		        Case "fdiv": Result = MpAll.GetMp().fdiv(x1, x2)
		        Case "fmod": Result = MpAll.GetMp().fmod(x1, x2)
		        Case "almosteq": Result = MpAll.GetMp().almosteq(x1, x2)
		        Case "ldexp": Result = MpAll.GetMp().ldexp(x1, x2)
		        Case "chop": Result = MpAll.GetMp().chop(x1, x2)
		        Case "fraction": Result = MpAll.GetMp().fraction(x1, x2)
		        Case "linspace": Result = MpAll.GetMp().linspace(x1, x2)
	'	*********************************************
		            
		        Case "hypot": Result = MpAll.GetMp().hypot(x1, x2)
		        Case "power": Result = MpAll.GetMp().power(x1, x2)
		        Case "powm1": Result = MpAll.GetMp().powm1(x1, x2)
		        Case "logb": Result = MpAll.GetMp().log(x1, x2)
		        Case "lambertw_k": Result = MpAll.GetMp().lambertw(x1, x2)
		        Case "agm": Result = MpAll.GetMp().agm(x1, x2)
		        Case "atan2": Result = MpAll.GetMp().atan2(x1, x2)
		        Case "binomial": Result = MpAll.GetMp().binomial(x1, x2)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			MpAll.ReportException(ex)
		End Try
		Return Result
	End Function	

	
End Module


