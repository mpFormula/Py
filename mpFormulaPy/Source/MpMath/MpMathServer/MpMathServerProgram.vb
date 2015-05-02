
Imports System
Imports System.ServiceModel
Imports MpMath

Module Program
	
	Dim mp As New MpMathClass
	
	
	<ServiceContract> _
	Public Interface IMpMathNamedPipes
			
		<OperationContract> _
		Function Function00XL(FunctionName As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function01XL(FunctionName As String, Parameter1 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function02XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function03XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function04XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function05XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function06XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Keywords As String, RefName As String, Options As String) As String
			
		<OperationContract> _
		Function Function07XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Keywords As String, RefName As String, Options As String) As String	
			
		<OperationContract> _
		Function Function08XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Keywords As String, RefName As String, Options As String) As String	
			
		<OperationContract> _
		Function Function09XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Parameter9 As String, Keywords As String, RefName As String, Options As String) As String	
			
			
			
			
			
		<OperationContract> _
		Function Function00(dps As UInt32, FunctionEnum As String) As String
		
		<OperationContract> _
		Function Function01(dps As UInt32, FunctionEnum As String, x1 As String) As String
		
		<OperationContract> _
		Function Function02(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String) As String
		
		<OperationContract> _
		Function Function03(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String) As String
		
		<OperationContract> _
		Function Function04(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String) As String
		
		<OperationContract> _
		Function Function05(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String) As String
		
		<OperationContract> _
		Function Function06(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String) As String
		
		<OperationContract> _
		Function Function07(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String, x7 As String) As String
		
		<OperationContract> _
		Function Ping() As String
		
	End Interface
	
	
	Public Class MpMathNamedPipes
		Implements IMpMathNamedPipes
		
		Public Function Function00XL(FunctionName As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function00XL
			Return mp.GetFunction00XL(FunctionName, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function01XL(FunctionName As String, Parameter1 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function01XL
			Return mp.GetFunction01XL(FunctionName, Parameter1, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function02XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function02XL
			Return mp.GetFunction02XL(FunctionName, Parameter1, Parameter2, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function03XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function03XL
			Return mp.GetFunction03XL(FunctionName, Parameter1, Parameter2, Parameter3, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function04XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function04XL
			Return mp.GetFunction04XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function05XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function05XL
			Return mp.GetFunction05XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function06XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function06XL
			Return mp.GetFunction06XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function07XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function07XL
			Return mp.GetFunction07XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function08XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function08XL
			Return mp.GetFunction08XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Parameter8, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function09XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Parameter9 As String, Keywords As String, RefName As String, Options As String) As String Implements IMpMathNamedPipes.Function09XL
			Return mp.GetFunction09XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Parameter8, Parameter9, Keywords, RefName, Options)
		End Function
		
		
		Public Function Function00(dps As UInt32, FunctionEnum As String) As String Implements IMpMathNamedPipes.Function00
			Dim Result As Object = mp.GetFunction00(dps, FunctionEnum)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		
		Public Function Function01(dps As UInt32, FunctionEnum As String, x1 As String) As String Implements IMpMathNamedPipes.Function01
			Dim Result As Object = mp.GetFunction01(dps, FunctionEnum, x1)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function02(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String) As String Implements IMpMathNamedPipes.Function02
			Dim Result As Object = mp.GetFunction02(dps, FunctionEnum, x1, x2)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function03(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String) As String Implements IMpMathNamedPipes.Function03
			Dim Result As Object = mp.GetFunction03(dps, FunctionEnum, x1, x2, x3)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function04(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String) As String Implements IMpMathNamedPipes.Function04
			Dim Result As Object = mp.GetFunction04(dps, FunctionEnum, x1, x2, x3, x4)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function05(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String) As String Implements IMpMathNamedPipes.Function05
			Dim Result As Object = mp.GetFunction05(dps, FunctionEnum, x1, x2, x3, x4, x5)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function06(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String) As String Implements IMpMathNamedPipes.Function06
			Dim Result As Object = mp.GetFunction06(dps, FunctionEnum, x1, x2, x3, x4, x5, x6)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Function07(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String, x7 As String) As String Implements IMpMathNamedPipes.Function07
			Dim Result As Object = mp.GetFunction07(dps, FunctionEnum, x1, x2, x3, x4, x5, x6, x7)
			Dim s As String = mp.MpMathToString(Result, dps)
			Return s
		End Function
		
		Public Function Ping() As String Implements IMpMathNamedPipes.Ping
			Dim s As String = "Ping"
			Return s
		End Function

	End Class

	
	
	Sub Main(args As String())
		
		Static objMutex as System.Threading.Mutex​​
		Dim bInitialOwner as Boolean = False
		
		objMutex = New System.Threading.Mutex(True, "MyMutexDH3.14159", bInitialOwner)
		
		If Not bInitialOwner Then
'		     Console.WriteLine("Application is currently running. Exiting program.")
		     Exit Sub 'Or set a flag or something
		End If
		
		
		
		Dim s As String = mp.PiString()
		Console.WriteLine(s)
		
		Using host As New ServiceHost(GetType(MpMathNamedPipes), New Uri() {New Uri("net.pipe://localhost")})
			host.AddServiceEndpoint(GetType(IMpMathNamedPipes), New NetNamedPipeBinding(), "MpMathServer")
			host.Open()
			Console.WriteLine("Service is available. " & "Press <ENTER> to exit.")
			Console.ReadLine()
			host.Close()
		End Using
	End Sub
	
	
	
	
End Module
