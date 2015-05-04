
Imports System
Imports System.Diagnostics
Imports System.ServiceModel

Imports Microsoft.Win32

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


Public Class MpMathClientClass
	
	Private pipeFactory As ChannelFactory(Of IMpMathNamedPipes)
	Private pipeProxy As IMpMathNamedPipes
	
	
	Public Sub New()
		ResetConnection()
	End Sub
	
	
	
	Public Function Function00XL(FunctionName As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function00XL(FunctionName, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function01XL(FunctionName As String, Parameter1 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function01XL(FunctionName, Parameter1, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function02XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function02XL(FunctionName, Parameter1, Parameter2, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function03XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function03XL(FunctionName, Parameter1, Parameter2, Parameter3, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function04XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function04XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function05XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function05XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function06XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function06XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function07XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function07XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function08XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function08XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Parameter8, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function09XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Parameter9 As String, Keywords As String, RefName As String, Options As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function09XL(FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7, Parameter8, Parameter9, Keywords, RefName, Options)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	
	
	
	
	
	Public Function Function00(dps As UInt32, FunctionEnum As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function00(dps, FunctionEnum)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
		
	Public Function Function01(dps As UInt32, FunctionEnum As String, x1 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function01(dps, FunctionEnum, x1)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function

	
	Public Function Function02(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function02(dps, FunctionEnum, x1, x2)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function03(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function03(dps, FunctionEnum, x1, x2, x3)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function04(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function04(dps, FunctionEnum, x1, x2, x3, x4)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
		
	
	Public Function Function05(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function05(dps, FunctionEnum, x1, x2, x3, x4, x5)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
		
		
	Public Function Function06(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function06(dps, FunctionEnum, x1, x2, x3, x4, x5, x6)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function
	
	
	Public Function Function07(dps As UInt32, FunctionEnum As String, x1 As String, x2 As String, x3 As String, x4 As String, x5 As String, x6 As String, x7 As String) As String
		While True
			Try
				Dim Result As String = pipeProxy.Function07(dps, FunctionEnum, x1, x2, x3, x4, x5, x6, x7)
				Return Result
			Catch E As System.ServiceModel.EndpointNotFoundException
				ResetConnection()
			End Try
		End While
	End Function

		
	Private Sub ResetConnection()
	    Dim NotWaitingForServer As Boolean = True
	    
'	    Console.WriteLine("ResetConnection")
	    
		While True
			pipeFactory = New ChannelFactory(Of IMpMathNamedPipes)(New NetNamedPipeBinding(), New EndpointAddress("net.pipe://localhost/MpMathServer"))
			pipeProxy = pipeFactory.CreateChannel()
			Try
				Dim Result As String = pipeProxy.Ping()
				Exit Sub
			Catch E As System.ServiceModel.EndpointNotFoundException
				If NotWaitingForServer Then
					StartApp("mpNum\MpMathServer.exe")
					NotWaitingForServer = False
				End If
			Catch e As Exception
			End Try
		End While
	End Sub
	
	
	Private Function RootDir() As String
		Dim regKey As RegistryKey = Nothing
		Dim RootPath As String = "Not set"
		Try
			regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
			RootPath = regKey.GetValue("RootPath", "Not set").ToString()
			regKey.Close()
		Catch generatedExceptionName As Exception
'				Console.WriteLine("RootDir not set")
		End Try
		Return RootPath
	End Function


	Private Sub StartApp(FName As String)
	    Dim directory As String = RootDir() & FName
'	    Console.WriteLine(directory)
		Dim p As New ProcessStartInfo()
		p.FileName = directory
		'		p.WindowStyle = ProcessWindowStyle.Hidden;
		'		p.WindowStyle = ProcessWindowStyle.Minimized;
		Process.Start(p)
	End Sub
	

	
	
	
End Class