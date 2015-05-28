Imports System.Runtime.InteropServices
Imports System.Text
 
 Module Module1
     
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function GetComputerName( _
        <[In]()> <[Out]()> <MarshalAs(UnmanagedType.LPWStr)> ByVal Name As StringBuilder, _
        <[In]()> ByRef CharCount As Integer) _
    As Boolean
    End Function
 
    Sub Test1()
        Const MAX_COMPUTERNAME_LENGTH As Integer = 15
        Dim Buffer As New StringBuilder(MAX_COMPUTERNAME_LENGTH)
        Dim bRes As Boolean
        Dim iLen As Integer
 
        iLen = MAX_COMPUTERNAME_LENGTH
 
        bRes = GetComputerName(Buffer, iLen)
        Buffer.Length = iLen
        If bRes Then
            System.Console.WriteLine("Computername: " & Chr(34) & Buffer.ToString() & Chr(34))
        End If
    End Sub
    
    
    <DllImport("CallPython.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function SetSpecialValue_Double(a As Double, b As Double, c As Double) As Double
    End Function
    
    Sub Test2()
        Dim a As Double = 3.3450
        Dim b As Double = 13.56780
        Dim c As Double = 23.453450
        Dim Result As Double = SetSpecialValue_Double(a, b, c)
        System.Console.WriteLine("Result: " & Result.ToString() )
    End Sub
    
    
    
    <DllImport("CallPython.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function MyPythonFunctionStringReturn00( _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal FuncName As String, _
        <[In]()> <[Out]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Result As StringBuilder, _
        <[In]()> ByVal BufferSize As Integer) _
    As Integer
    End Function
    
    
    Sub Test4()
        Const BufferSize As Integer = 1500
        Dim Buffer As New StringBuilder(BufferSize)
        Dim iLen As Integer = MyPythonFunctionStringReturn00("TestStringMpf0", Buffer, BufferSize)
        Buffer.Length = iLen
        System.Console.WriteLine("Result00 in .NET: " & Buffer.ToString())
    End Sub
    
    
    <DllImport("CallPython.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function MyPythonFunctionStringReturn01( _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal FuncName As String, _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Arg01 As String, _
        <[In]()> <[Out]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Result As StringBuilder, _
        <[In]()> ByVal BufferSize As Integer) _
    As Integer
    End Function
    
    
    Sub Test5()
        Const BufferSize As Integer = 1500
        Dim Buffer As New StringBuilder(BufferSize)
        Dim iLen As Integer = MyPythonFunctionStringReturn01("TestStringMpf1", "3", Buffer, BufferSize)
        Buffer.Length = iLen
        System.Console.WriteLine("Result01 in .NET: " & Buffer.ToString())
    End Sub
    
    
    
    <DllImport("CallPython.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function MyPythonFunctionStringReturn02( _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal FuncName As String, _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Arg01 As String, _
        <[In]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Arg02 As String, _    
        <[In]()> <[Out]()> <MarshalAs(UnmanagedType.LPStr)> ByVal Result As StringBuilder, _
        <[In]()> ByVal BufferSize As Integer) _
    As Integer
    End Function
    
    
    Sub Test6()
        Const BufferSize As Integer = 1500
        Dim Buffer As New StringBuilder(BufferSize)
        Dim iLen As Integer = MyPythonFunctionStringReturn02("TestStringMpf2", "3", "3", Buffer, BufferSize)
        Buffer.Length = iLen
        System.Console.WriteLine("Result02 in .NET: " & Buffer.ToString())
    End Sub
    
    
    Sub Main()
        Test4()
        Test5()
        Test6()
        
        Console.Write("Press any key to continue . . . ")
        Console.ReadKey(True)
    End Sub
    
    
    
 End Module