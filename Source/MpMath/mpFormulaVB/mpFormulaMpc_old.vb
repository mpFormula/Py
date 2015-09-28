Imports System
Imports Microsoft.Scripting
Imports MpMath



'  Public Class mpc_t
'
'
'    ' Should be friend as well  
'    Public x1 As Object = Nothing
'    Friend mpc_tType As Int32 = 4
'
'    Public Sub New()
'      x1 = mpc.GetMp().Getmpc("0")
'    End Sub
'
'    Public Sub New(ByVal s As String)
'      x1 = mpc.GetMp().Getmpc(s)
'    End Sub
'
'    Public Sub New(ByVal d As Double)
'      x1 = mpc.GetMp().Getmpc(d)
'    End Sub
'
'    Public Sub New(ByVal x As Object)
'      If TypeOf x Is mpc_t Then
'        x1 = DirectCast(x, mpc_t).x1
'      Else
'        x1 = mpc.GetMp().Getmpc(x)
'      End If
'    End Sub
'
'    Public Sub New(ByVal x As mpc_t)
'      x1 = x.x1
'    End Sub
'



Public Class mpc_t


    Friend PyPtr As Object = Nothing
    Friend mpc_tType As Int32 = 4

    Public Sub New()
      PyPtr = MpAll.Getmpc("0")
    End Sub

    Public Sub New(ByVal s As String)
      PyPtr = MpAll.Getmpc(s)
    End Sub

    Public Sub New(ByVal d As Double)
      PyPtr = MpAll.Getmpc(d)
    End Sub

    Public Sub New(ByVal x As Object)
      If TypeOf x Is mpc_t Then
        PyPtr = DirectCast(x, mpc_t).PyPtr
      Else
        PyPtr = MpAll.Getmpc(x)
      End If
    End Sub

    Public Sub New(ByVal x As mpc_t)
      PyPtr = x.PyPtr
    End Sub


    Public Shared Widening Operator CType(ByVal m1 As mpc_t) As String
      Return m1.Str()
    End Operator


    'Public Shared Narrowing Operator CType(ByVal s As String) As mpc_t
    Public Shared Widening Operator CType(ByVal s As String) As mpc_t
      Return New mpc_t(s)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_t) As Decimal
      Return CDec(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpc_t
      Return New mpc_t(CStr(dec))
    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpc_t
    '    Return New mpc_t(obj)
    '  End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_t) As Double
      Return CDbl(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal d As Double) As mpc_t
      Return New mpc_t(d)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_t) As Long
      Return CLng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal si As Long) As mpc_t
      Return New mpc_t(CStr(si))
    End Operator



    Public Shared Narrowing Operator CType(ByVal m1 As mpc_t) As ULong
      Return CULng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal ui As ULong) As mpc_t
      Return New mpc_t(CStr(ui))
    End Operator



    Public Shared Operator =(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr = m1.PyPtr
    End Operator



    Public Shared Operator <>(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr <> m1.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr <= m2.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr <= m2.PyPtr
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr <= m1.PyPtr
    End Operator




    Public Shared Operator <(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr < m2.PyPtr
    End Operator


    Public Shared Operator <(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr < m2.PyPtr
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr < m1.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr >= m1.PyPtr
    End Operator




    Public Shared Operator >(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As Boolean
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal m1 As mpc_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpc_t) As Boolean
      Dim m2 As New mpc_t(obj)
      Return m2.PyPtr > m1.PyPtr
    End Operator


    Public Shared Operator +(ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = m1.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = -m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      'MsgBox("Plus_mpc_t")
      m3.PyPtr = m1.PyPtr + m2.PyPtr
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpc_t, ByVal obj As Object) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = m1.PyPtr - m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpc_t, ByVal obj As Object) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m1.PyPtr - m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m3.PyPtr - m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = m1.PyPtr * m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpc_t, ByVal obj As Object) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m1.PyPtr * m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m3.PyPtr * m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = m1.PyPtr / m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpc_t, ByVal obj As Object) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m1.PyPtr / m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpc_t) As mpc_t
      Dim m3 As New mpc_t(obj)
      m3.PyPtr = m3.PyPtr / m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpc_t, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpc_t) As String
      Return s & m1.Str()
    End Operator



    ' New operators for COM:
    ' Pow, Mod, IntDiv, LSh, Rsh, AND, OR, XOR
    ' New Functions for COM:
    ' IsTrue, IsFalse, NOT

    '>>
    '<<
    'AND
    'OR
    'XOR
    'IsTrue
    'IsFalse
    'NOT

    Public Shared Operator ^(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      m3.PyPtr = m1.PyPtr ^ m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr. Mod (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr \ (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpc_t, ByVal i As Integer) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpc_t, ByVal i As Integer) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpc_t) As Boolean
      '    Return m1.PyPtr.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpc_t) As Boolean
      '    Return m1.PyPtr.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpc_t) As Boolean
      '    If m1.PyPtr.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr.AND(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr.OR(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpc_t, ByVal m2 As mpc_t) As mpc_t
      Dim m3 As New mpc_t()
      '    m3.PyPtr = m1.PyPtr.XOR(m2.PyPtr)
      Return m3
    End Operator


    Public Overrides Function ToString() As String
      Return MpAll.MpMathToString(PyPtr, mpc.dps)
    End Function





    Public Function Str() As String
      Return MpAll.MpMathToString(PyPtr, mpc.dps)
    End Function

    Public Function __str__() As String
      Return MpAll.MpMathToString(PyPtr, mpc.dps)
    End Function



  End Class


  Public Class mpc

    Shared FloatingPointType_ As Integer = 3

'    Shared Function GetMp() As MpMathClass
'      Static PyInstance As MpMathClass = Nothing
'      If IsNothing(PyInstance) Then
'        Try
'          PyInstance = New MpMathClass
'        Catch ex As Exception
'          '				ReportException(ex)
'        End Try
'      End If
'      Return PyInstance
'    End Function



    Public Shared ReadOnly Property mpmath() As Object
        Get
          Static mpMathInstance As Object = Nothing
          If IsNothing(mpMathInstance) Then mpMathInstance = GetMp().GetMp()
          Return mpMathInstance
      End Get
    End Property


    Shared Sub New()
      Dim s As String = GetMp().PiString()
      '	Console.WriteLine(s)
    End Sub




    Public Shared Property dps() As Integer
      Get
        Return GetMp().GetDps()
      End Get

      Set(ByVal Value As Integer)
        GetMp().SetDps(Value)
      End Set
    End Property


    Public Shared Property prec() As Integer
      Get
        Return GetMp().GetPrec()
      End Get

      Set(ByVal Value As Integer)
        GetMp().SetPrec(Value)
      End Set
    End Property


    Public Shared Property pretty() As Boolean
      Get
        Return GetMp().GetPretty()
      End Get

      Set(ByVal Value As Boolean)
        GetMp().SetPretty(Value)
      End Set
    End Property


    Public Shared Property trap_complex() As Boolean
      Get
        Return GetMp().Get_trap_complex()
      End Get

      Set(ByVal Value As Boolean)
        GetMp().Set_trap_complex(Value)
      End Set
    End Property




    Public Shared Property FloatingPointType() As Integer
      Get
        Return FloatingPointType_
      End Get

      Set(ByVal Value As Integer)
        FloatingPointType_ = Value
      End Set
    End Property



    Shared Function GetFunction00(FunctionEnum As String) As mpc_t
        Dim dps As Integer = GetMp().GetDps()
        Return New mpc_t(GetMp().GetFunction00(dps, FunctionEnum))
    End Function




'
'    Shared Function pi() As mpc_t
'      Return GetFunction00("pi")
'    End Function


    Shared Function pi() As mpc_t
      Return New mpc_t(mpmath.pi())
    End Function





    Shared Function degree() As mpc_t
      Return GetFunction00("degree")
    End Function


    Shared Function e() As mpc_t
      Return GetFunction00("e")
    End Function


    Shared Function phi() As mpc_t
      Return GetFunction00("phi")
    End Function


    Shared Function euler() As mpc_t
      Return GetFunction00("euler")
    End Function


    Shared Function catalan() As mpc_t
      Return GetFunction00("catalan")
    End Function


    Shared Function apery() As mpc_t
      Return GetFunction00("apery")
    End Function


    Shared Function khinchin() As mpc_t
      Return GetFunction00("khinchin")
    End Function


    Shared Function glaisher() As mpc_t
      Return GetFunction00("glaisher")
    End Function


    Shared Function mertens() As mpc_t
      Return GetFunction00("mertens")
    End Function


    Shared Function twinprime() As mpc_t
      Return GetFunction00("twinprime")
    End Function


    Shared Function j() As mpc_t
      Return GetFunction00("j")
    End Function
    

    Shared Function inf() As mpc_t
      Return GetFunction00("inf")
    End Function


    Shared Function nan() As mpc_t
      Return GetFunction00("nan")
    End Function


    Shared Function rand() As mpc_t
      Return GetFunction00("rand")
    End Function



    

    Shared Function GetFunction01B(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
    End Function




    Shared Function isinf(m1 As mpc_t) As Boolean
      Return GetFunction01B("isinf", m1.PyPtr)
    End Function


    Shared Function isnan(m1 As mpc_t) As Boolean
      Return GetFunction01B("isnan", m1.PyPtr)
    End Function


    Shared Function isnormal(m1 As mpc_t) As Boolean
      Return GetFunction01B("isnormal", m1.PyPtr)
    End Function


    Shared Function isfinite(m1 As mpc_t) As Boolean
      Return GetFunction01B("isfinite", m1.PyPtr)
    End Function


    Shared Function isint(m1 As mpc_t) As Boolean
      Return GetFunction01B("isint", m1.PyPtr)
    End Function


    

    '	*********************************************
    
    
    Shared Function GetFunction01(FunctionEnum As String, m1 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
       Return New mpc_t(GetMp().GetFunction01(dps, FunctionEnum, m1.PyPtr))
    End Function


    Shared Function mpc(x1 As Object) As mpc_t
      Return GetFunction01("mpc", x1)
    End Function


    Shared Function convert(x1 As Object) As mpc_t
      Return GetFunction01("convert", x1)
    End Function

    Shared Function mpmathify(x1 As Object) As mpc_t
      Return GetFunction01("convert", x1)
    End Function

    Shared Function nstr(x1 As Object) As mpc_t
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************
    


    Shared Function mag(m1 As mpc_t) As mpc_t
      Return GetFunction01("mag", m1.PyPtr)
    End Function


    Shared Function nint_distance(m1 As mpc_t) As mpc_t
      Return GetFunction01("nint_distance", m1.PyPtr)
    End Function
    
    
        
    Shared Function fneg(m1 As mpc_t) As mpc_t
      Return GetFunction01("fneg", m1.PyPtr)
    End Function

     
    Shared Function fabs(m1 As mpc_t) As mpc_t
      Return GetFunction01("fabs", m1.PyPtr)
    End Function
   

    Shared Function sign(m1 As mpc_t) As mpc_t
      Return GetFunction01("sign", m1.PyPtr)
    End Function

    Shared Function re(m1 As mpc_t) As mpc_t
      Return GetFunction01("re", m1.PyPtr)
    End Function

    Shared Function im(m1 As mpc_t) As mpc_t
      Return GetFunction01("im", m1.PyPtr)
    End Function

    Shared Function arg(m1 As mpc_t) As mpc_t
      Return GetFunction01("arg", m1.PyPtr)
    End Function

    ' same as arg
    Shared Function phase(m1 As mpc_t) As mpc_t
      Return GetFunction01("phase", m1.PyPtr)
    End Function


    Shared Function conj (m1 As mpc_t) As mpc_t
      Return GetFunction01("conj", m1.PyPtr)
    End Function

    Shared Function polar(m1 As mpc_t) As mpc_t
      Return GetFunction01("polar",  m1.PyPtr)
    End Function

    Shared Function rect(m1 As mpc_t, m2 As mpc_t) As Object
      Return GetFunction02("rect", m1.PyPtr, m2.PyPtr)
    End Function




    
    
    
    
    
    '	*********************************************

    Shared Function floor(m1 As mpc_t) As mpc_t
      Return GetFunction01("floor", m1.PyPtr)
    End Function


    Shared Function ceil(m1 As mpc_t) As mpc_t
      Return GetFunction01("ceil", m1)
    End Function


    Shared Function nint(m1 As mpc_t) As mpc_t
      Return GetFunction01("nint", m1)
    End Function


    Shared Function frac(m1 As mpc_t) As mpc_t
      Return GetFunction01("nint", m1)
    End Function


    '	*********************************************

    Shared Function chop(m1 As mpc_t) As mpc_t
      Return GetFunction01("chop", m1)
    End Function



    Shared Function sqrt(m1 As mpc_t) As mpc_t
      Return GetFunction01("sqrt", m1)
    End Function


    Shared Function cbrt(m1 As mpc_t) As mpc_t
      Return GetFunction01("cbrt", m1)
    End Function


    Shared Function exp(m1 As mpc_t) As mpc_t
      Return GetFunction01("exp", m1)
    End Function

    Shared Function expm1(m1 As mpc_t) As mpc_t
      Return GetFunction01("expm1", m1)
    End Function

    Shared Function log(m1 As mpc_t) As mpc_t
      Return GetFunction01("log", m1)
    End Function

    Shared Function ln(m1 As mpc_t) As mpc_t
      Return GetFunction01("ln", m1)
    End Function

    Shared Function ln10(m1 As mpc_t) As mpc_t
      Return GetFunction01("ln10", m1)
    End Function

    Shared Function ln2(m1 As mpc_t) As mpc_t
      Return GetFunction01("ln2", m1)
    End Function


    Shared Function log10(m1 As mpc_t) As mpc_t
      Return GetFunction01("log10", m1)
    End Function

    Shared Function log2(m1 As mpc_t) As mpc_t
      Return GetFunction01("log2", m1)
    End Function

    Shared Function lambertw(m1 As mpc_t) As mpc_t
      Return GetFunction01("lambertw", m1)
    End Function



    Shared Function degrees(m1 As mpc_t) As mpc_t
      Return GetFunction01("degrees", m1)
    End Function

    Shared Function radians(m1 As mpc_t) As mpc_t
      Return GetFunction01("radians", m1)
    End Function

    Shared Function cos(m1 As mpc_t) As mpc_t
      Return GetFunction01("cos", m1)
    End Function

    Shared Function sin(m1 As mpc_t) As mpc_t
      Return GetFunction01("sin", m1)
    End Function

    Shared Function cos_sin(m1 As mpc_t) As mpc_t
      Return GetFunction01("cos_sin", m1)
    End Function


    Shared Function tan(m1 As mpc_t) As mpc_t
      Return GetFunction01("tan", m1)
    End Function

    Shared Function sec(m1 As mpc_t) As mpc_t
      Return GetFunction01("sec", m1)
    End Function

    Shared Function csc(m1 As mpc_t) As mpc_t
      Return GetFunction01("csc", m1)
    End Function

    Shared Function cot(m1 As mpc_t) As mpc_t
      Return GetFunction01("cot", m1)
    End Function

    Shared Function cospi(m1 As mpc_t) As mpc_t
      Return GetFunction01("cospi", m1)
    End Function

    Shared Function sinpi(m1 As mpc_t) As mpc_t
      Return GetFunction01("sinpi", m1)
    End Function


    Shared Function cospi_sinpi(m1 As mpc_t) As mpc_t
      Return GetFunction01("cospi_sinpi", m1)
    End Function


    Shared Function acos(m1 As mpc_t) As mpc_t
      Return GetFunction01("acos", m1)
    End Function

    Shared Function asin(m1 As mpc_t) As mpc_t
      Return GetFunction01("asin", m1)
    End Function

    Shared Function atan(m1 As mpc_t) As mpc_t
      Return GetFunction01("atan", m1)
    End Function

    Shared Function asec(m1 As mpc_t) As mpc_t
      Return GetFunction01("asec", m1)
    End Function

    Shared Function acsc(m1 As mpc_t) As mpc_t
      Return GetFunction01("acsc", m1)
    End Function

    Shared Function acot(m1 As mpc_t) As mpc_t
      Return GetFunction01("acot", m1)
    End Function



    Shared Function sinc(m1 As mpc_t) As mpc_t
      Return GetFunction01("sinc", m1)
    End Function

    Shared Function sincpi(m1 As mpc_t) As mpc_t
      Return GetFunction01("sincpi", m1)
    End Function



    Shared Function cosh(m1 As mpc_t) As mpc_t
      Return GetFunction01("cosh", m1)
    End Function


    Shared Function sinh(m1 As mpc_t) As mpc_t
      Return GetFunction01("sinh", m1)
    End Function


    Shared Function tanh(m1 As mpc_t) As mpc_t
      Return GetFunction01("tanh", m1)
    End Function


    Shared Function sech(m1 As mpc_t) As mpc_t
      Return GetFunction01("sech", m1)
    End Function


    Shared Function csch(m1 As mpc_t) As mpc_t
      Return GetFunction01("csch", m1)
    End Function


    Shared Function coth(m1 As mpc_t) As mpc_t
      Return GetFunction01("coth", m1)
    End Function




    Shared Function acosh(m1 As mpc_t) As mpc_t
      Return GetFunction01("acosh", m1)
    End Function


    Shared Function asinh(m1 As mpc_t) As mpc_t
      Return GetFunction01("asinh", m1)
    End Function


    Shared Function atanh(m1 As mpc_t) As mpc_t
      Return GetFunction01("atanh", m1)
    End Function


    Shared Function asech(m1 As mpc_t) As mpc_t
      Return GetFunction01("asech", m1)
    End Function


    Shared Function acsch(m1 As mpc_t) As mpc_t
      Return GetFunction01("acsch", m1)
    End Function


    Shared Function acoth(m1 As mpc_t) As mpc_t
      Return GetFunction01("acoth", m1)
    End Function



    Shared Function fac(m1 As mpc_t) As mpc_t
      Return GetFunction01("fac", m1)
    End Function


    Shared Function factorial(m1 As mpc_t) As mpc_t
      Return GetFunction01("factorial", m1)
    End Function


    Shared Function fac2(m1 As mpc_t) As mpc_t
      Return GetFunction01("fac2", m1)
    End Function


    Shared Function gamma(m1 As mpc_t) As mpc_t
      Return GetFunction01("gamma", m1)
    End Function


    Shared Function rgamma(m1 As mpc_t) As mpc_t
      Return GetFunction01("rgamma", m1)
    End Function


    Shared Function loggamma(m1 As mpc_t) As mpc_t
      Return GetFunction01("loggamma", m1)
    End Function


    Shared Function superfac(m1 As mpc_t) As mpc_t
      Return GetFunction01("superfac", m1)
    End Function


    Shared Function hyperfac(m1 As mpc_t) As mpc_t
      Return GetFunction01("hyperfac", m1)
    End Function

    Shared Function barnesg(m1 As mpc_t) As mpc_t
      Return GetFunction01("barnesg", m1)
    End Function


    Shared Function digamma(m1 As mpc_t) As mpc_t
      Return GetFunction01("digamma", m1)
    End Function


    Shared Function harmonic(m1 As mpc_t) As mpc_t
      Return GetFunction01("harmonic", m1)
    End Function




    Shared Function ei(m1 As mpc_t) As mpc_t
      Return GetFunction01("ei", m1)
    End Function


    Shared Function e1(m1 As mpc_t) As mpc_t
      Return GetFunction01("e1", m1)
    End Function


    Shared Function li(m1 As mpc_t) As mpc_t
      Return GetFunction01("li", m1)
    End Function


    Shared Function ci(m1 As mpc_t) As mpc_t
      Return GetFunction01("ci", m1)
    End Function


    Shared Function si(m1 As mpc_t) As mpc_t
      Return GetFunction01("si", m1)
    End Function


    Shared Function chi(m1 As mpc_t) As mpc_t
      Return GetFunction01("chi", m1)
    End Function


    Shared Function shi(m1 As mpc_t) As mpc_t
      Return GetFunction01("shi", m1)
    End Function


    Shared Function erf(m1 As mpc_t) As mpc_t
      Return GetFunction01("erf", m1)
    End Function


    Shared Function erfc(m1 As mpc_t) As mpc_t
      Return GetFunction01("erfc", m1)
    End Function


    Shared Function erfi(m1 As mpc_t) As mpc_t
      Return GetFunction01("erfi", m1)
    End Function


    Shared Function erfinv(m1 As mpc_t) As mpc_t
      Return GetFunction01("erfinv", m1)
    End Function


    Shared Function fresnels(m1 As mpc_t) As mpc_t
      Return GetFunction01("fresnels", m1)
    End Function


    Shared Function fresnelc(m1 As mpc_t) As mpc_t
      Return GetFunction01("fresnelc", m1)
    End Function




    Shared Function j0(m1 As mpc_t) As mpc_t
      Return GetFunction01("j0", m1)
    End Function


    Shared Function j1(m1 As mpc_t) As mpc_t
      Return GetFunction01("j1", m1)
    End Function




    Shared Function airyai(m1 As mpc_t) As mpc_t
      Return GetFunction01("airyai", m1)
    End Function


    Shared Function airybi(m1 As mpc_t) As mpc_t
      Return GetFunction01("airybi", m1)
    End Function


    Shared Function airyaizero(m1 As mpc_t) As mpc_t
      Return GetFunction01("airyaizero", m1)
    End Function


    Shared Function airybizero(m1 As mpc_t) As mpc_t
      Return GetFunction01("airybizero", m1)
    End Function



    Shared Function scorergi(m1 As mpc_t) As mpc_t
      Return GetFunction01("scorergi", m1)
    End Function


    Shared Function scorerhi(m1 As mpc_t) As mpc_t
      Return GetFunction01("scorerhi", m1)
    End Function



    Shared Function kleinj(m1 As mpc_t) As mpc_t
      Return GetFunction01("kleinj", m1)
    End Function




    Shared Function zeta(m1 As mpc_t) As mpc_t
      Return GetFunction01("zeta", m1)
    End Function


    Shared Function altzeta(m1 As mpc_t) As mpc_t
      Return GetFunction01("altzeta", m1)
    End Function


    Shared Function zetazero(m1 As mpc_t) As mpc_t
      Return GetFunction01("zetazero", m1)
    End Function




    Shared Function siegelz(m1 As mpc_t) As mpc_t
      Return GetFunction01("siegelz", m1)
    End Function


    Shared Function siegeltheta(m1 As mpc_t) As mpc_t
      Return GetFunction01("siegeltheta", m1)
    End Function


    Shared Function grampoint(m1 As mpc_t) As mpc_t
      Return GetFunction01("grampoint", m1)
    End Function


    Shared Function backlunds(m1 As mpc_t) As mpc_t
      Return GetFunction01("backlunds", m1)
    End Function



    Shared Function primezeta(m1 As mpc_t) As mpc_t
      Return GetFunction01("primezeta", m1)
    End Function


    Shared Function secondzeta(m1 As mpc_t) As mpc_t
      Return GetFunction01("secondzeta", m1)
    End Function



    Shared Function fibonacci(m1 As mpc_t) As mpc_t
      Return GetFunction01("fibonacci", m1)
    End Function


    Shared Function fib(m1 As mpc_t) As mpc_t
      Return GetFunction01("fib", m1)
    End Function


    Shared Function bernoulli(m1 As mpc_t) As mpc_t
      Return GetFunction01("bernoulli", m1)
    End Function



    Shared Function eulernum(m1 As mpc_t) As mpc_t
      Return GetFunction01("eulernum", m1)
    End Function



    Shared Function primepi(m1 As mpc_t) As mpc_t
      Return GetFunction01("primepi", m1)
    End Function


    Shared Function primepi2(m1 As mpc_t) As mpc_t
      Return GetFunction01("primepi2", m1)
    End Function


    Shared Function riemannr(m1 As mpc_t) As mpc_t
      Return GetFunction01("riemannr", m1)
    End Function


    Shared Function mangoldt(m1 As mpc_t) As mpc_t
      Return GetFunction01("mangoldt", m1)
    End Function





    '	***********************************************


    Shared Function GetFunction02(FunctionEnum As String, m1 As mpc_t, m2 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
      Return New mpc_t(GetMp().GetFunction02(dps, FunctionEnum, m1.PyPtr, m2.PyPtr))
    End Function
    




    Shared Function fraction(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fraction", m1, m2)
    End Function



    Shared Function fadd(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fadd", m1, m2)
    End Function


    Shared Function fsub(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fsub", m1, m2)
    End Function



    Shared Function fmul(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fmul", m1, m2)
    End Function


    Shared Function fdiv(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fdiv", m1, m2)
    End Function



    Shared Function fmod(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("fmod", m1, m2)
    End Function


    Shared Function almosteq(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Shared Function ldexp(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Shared Function chop(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("chop", m1, m2)
    End Function


    Shared Function hypot(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("hypot", m1, m2)
    End Function


    Shared Function power(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("power", m1, m2)
    End Function


    Shared Function powm1(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("powm1", m1, m2)
    End Function


    Shared Function lambertw_k(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("lambertw_k", m1, m2)
    End Function


    Shared Function agm(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("agm", m1, m2)
    End Function


    Shared Function binomial(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("binomial", m1, m2)
    End Function



    Shared Function atan2(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("atan2", m1, m2)
    End Function


    Shared Function rf(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("rf", m1, m2)
    End Function


    Shared Function ff(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ff", m1, m2)
    End Function


    Shared Function beta(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("beta", m1, m2)
    End Function


    Shared Function psi(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("psi", m1, m2)
    End Function


    Shared Function polygamma(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("polygamma", m1, m2)
    End Function


    Shared Function gammainc(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("gammainc", m1, m2)
    End Function


    Shared Function expint(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("expint", m1, m2)
    End Function




    Shared Function besselj(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("besselj", m1, m2)
    End Function


    Shared Function bessely(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("bessely", m1, m2)
    End Function


    Shared Function besseli(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("besseli", m1, m2)
    End Function


    Shared Function besselk(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("besselk", m1, m2)
    End Function


    Shared Function besseljzero(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("besseljzero", m1, m2)
    End Function


    Shared Function besselyzero(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("besselyzero", m1, m2)
    End Function


    Shared Function hankel1(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("hankel1", m1, m2)
    End Function


    Shared Function hankel2(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("hankel2", m1, m2)
    End Function


    Shared Function ber(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ber", m1, m2)
    End Function


    Shared Function bei(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("bei", m1, m2)
    End Function


    Shared Function ker(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ker", m1, m2)
    End Function


    Shared Function kei(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("kei", m1, m2)
    End Function




    Shared Function struveh(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("struveh", m1, m2)
    End Function


    Shared Function struvel(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("struvel", m1, m2)
    End Function


    Shared Function angerj(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("angerj", m1, m2)
    End Function


    Shared Function webere(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("webere", m1, m2)
    End Function


    Shared Function airyaideriv(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("airyaideriv", m1, m2)
    End Function


    Shared Function airybideriv(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("airybideriv", m1, m2)
    End Function


    Shared Function airyaiderivzero(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("airyaiderivzero", m1, m2)
    End Function


    Shared Function airybiderivzero(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("airybiderivzero", m1, m2)
    End Function




    Shared Function coulombc(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("coulombc", m1, m2)
    End Function


    Shared Function pcfd(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("pcfd", m1, m2)
    End Function


    Shared Function pcfu(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("pcfu", m1, m2)
    End Function


    Shared Function pcfv(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("pcfv", m1, m2)
    End Function


    Shared Function pcfw(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("pcfw", m1, m2)
    End Function



    Shared Function legendre(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("legendre", m1, m2)
    End Function


    Shared Function chebyt(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("chebyt", m1, m2)
    End Function


    Shared Function chebyu(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("chebyu", m1, m2)
    End Function


    Shared Function hermite(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("hermite", m1, m2)
    End Function



    Shared Function hyp0f1(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("hyp0f1", m1, m2)
    End Function



    Shared Function ellipf(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ellipf", m1, m2)
    End Function


    Shared Function ellipe(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ellipe", m1, m2)
    End Function


    Shared Function ellippi(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("ellippi", m1, m2)
    End Function


    Shared Function elliprc(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("elliprc", m1, m2)
    End Function



    Shared Function zeta(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("zeta", m1, m2)
    End Function


    Shared Function hurwitz(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("zeta", m1, m2)
    End Function

    Shared Function dirichlet(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("dirichlet", m1, m2)
    End Function


    Shared Function stieltjes(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("stieltjes", m1, m2)
    End Function



    Shared Function polylog(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("polylog", m1, m2)
    End Function


    Shared Function clsin(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("clsin", m1, m2)
    End Function


    Shared Function clcos(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("clcos", m1, m2)
    End Function


    Shared Function polyexp(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("polyexp", m1, m2)
    End Function




    Shared Function bernpoly(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("bernpoly", m1, m2)
    End Function


    Shared Function eulerpoly(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("eulerpoly", m1, m2)
    End Function


    Shared Function bell(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("bell", m1, m2)
    End Function


    Shared Function stirling1(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("stirling1", m1, m2)
    End Function


    Shared Function stirling2(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("stirling2", m1, m2)
    End Function


    Shared Function cyclotomic(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("cyclotomic", m1, m2)
    End Function



    Shared Function qgamma(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("qgamma", m1, m2)
    End Function


    Shared Function qfac(m1 As mpc_t, m2 As mpc_t) As mpc_t
      Return GetFunction02("qfac", m1, m2)
    End Function






    Shared Function GetFunction03(FunctionEnum As String, m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
      Return New mpc_t(GetMp().GetFunction03(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr))
    End Function


    Shared Function root(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("root", m1, m2, m3)
    End Function
    
    
    Shared Function nthroot(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("nthroot", m1, m2, m3)
    End Function


    Shared Function hypercomb(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("hypercomb", m1, m2, m3)
    End Function


    Shared Function betainc(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("betainc", m1, m2, m3)
    End Function


    Shared Function npdf(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("npdf", m1, m2, m3)
    End Function


    Shared Function ncdf(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("ncdf", m1, m2, m3)
    End Function


    Shared Function besseljderiv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besseljderiv", m1, m2, m3)
    End Function


    Shared Function besselyderiv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besselyderiv", m1, m2, m3)
    End Function


    Shared Function besselideriv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besselideriv", m1, m2, m3)
    End Function


    Shared Function besselkderiv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besselkderiv", m1, m2, m3)
    End Function


    Shared Function besseljzeroderiv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besseljzeroderiv", m1, m2, m3)
    End Function


    Shared Function besselyzeroderiv(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("besselyzeroderiv", m1, m2, m3)
    End Function



    Shared Function lommels1(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("lommels1", m1, m2, m3)
    End Function


    Shared Function lommels2(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("lommels2", m1, m2, m3)
    End Function


    Shared Function coulombf(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("coulombf", m1, m2, m3)
    End Function


    Shared Function coulombg(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("coulombg", m1, m2, m3)
    End Function


    Shared Function hyperu(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("hyperu", m1, m2, m3)
    End Function


    Shared Function whitm(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("whitm", m1, m2, m3)
    End Function


    Shared Function whitw(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("whitw", m1, m2, m3)
    End Function



    Shared Function legenp(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("legenp", m1, m2, m3)
    End Function


    Shared Function legenq(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("legenq", m1, m2, m3)
    End Function


    Shared Function gegenbauer(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("gegenbauer", m1, m2, m3)
    End Function


    Shared Function laguerre(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("laguerre", m1, m2, m3)
    End Function



    Shared Function hyp1f1(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("hyp1f1", m1, m2, m3)
    End Function


    Shared Function hyp2f0(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("hyp2f0", m1, m2, m3)
    End Function


    Shared Function hyper(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("hyper", m1, m2, m3)
    End Function


    Shared Function bihyper(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("bihyper", m1, m2, m3)
    End Function



    Shared Function ellippi(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("ellippi", m1, m2, m3)
    End Function


    Shared Function elliprf(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("elliprf", m1, m2, m3)
    End Function


    Shared Function elliprd(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("elliprd", m1, m2, m3)
    End Function


    Shared Function elliprg(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("elliprg", m1, m2, m3)
    End Function



    Shared Function jtheta(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("jtheta", m1, m2, m3)
    End Function


    Shared Function ellipfun(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("ellipfun", m1, m2, m3)
    End Function



    Shared Function zeta(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("zeta", m1, m2, m3)
    End Function


    Shared Function dirichlet(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("dirichlet", m1, m2, m3)
    End Function


    Shared Function lerchphi(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("lerchphi", m1, m2, m3)
    End Function



    Shared Function stirling1(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("stirling1", m1, m2, m3)
    End Function


    Shared Function stirling2(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("stirling2", m1, m2, m3)
    End Function


    Shared Function qp(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t) As mpc_t
      Return GetFunction03("qp", m1, m2, m3)
    End Function









    Shared Function GetFunction04(FunctionEnum As String, m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
              Return New mpc_t(GetMp().GetFunction04(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr))
    End Function




    Shared Function jacobi(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("jacobi", m1, m2, m3, m4)
    End Function


    Shared Function spherharm(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("spherharm", m1, m2, m3, m4)
    End Function


    Shared Function hyp1f2(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("hyp1f2", m1, m2, m3, m4)
    End Function


    Shared Function hyp2f1(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("hyp2f1", m1, m2, m3, m4)
    End Function


    Shared Function meijerg(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("meijerg", m1, m2, m3, m4)
    End Function


    Shared Function hyper2d(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("hyper2d", m1, m2, m3, m4)
    End Function


    Shared Function elliprj(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("elliprj", m1, m2, m3, m4)
    End Function


    Shared Function jtheta(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("jtheta", m1, m2, m3, m4)
    End Function


    Shared Function qhyper(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t) As mpc_t
      Return GetFunction04("qhyper", m1, m2, m3, m4)
    End Function





    Shared Function GetFunction05(FunctionEnum As String, m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
      Return New mpc_t(GetMp().GetFunction05(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr))
    End Function



    Shared Function hyp2f2(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t) As mpc_t
      Return GetFunction05("hyp2f2", m1, m2, m3, m4, m5)
    End Function






    Shared Function GetFunction06(FunctionEnum As String, m1  As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
      Return New mpc_t(GetMp().GetFunction06(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr, m6.PyPtr))
    End Function



    Shared Function hyp2f3( m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t) As mpc_t
      Return GetFunction06("hyp2f3", m1, m2, m3, m4, m5, m6)
    End Function


    Shared Function hyp3f2( m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t) As mpc_t
      Return GetFunction06("hyp3f2", m1, m2, m3, m4, m5, m6)
    End Function


    Shared Function appellf1( m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t) As mpc_t
      Return GetFunction06("appellf1", m1, m2, m3, m4, m5, m6)
    End Function


    Shared Function appellf4( m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t) As mpc_t
      Return GetFunction06("appellf4", m1, m2, m3, m4, m5, m6)
    End Function





    Shared Function GetFunction07(FunctionEnum As String, m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t, m7 As mpc_t) As mpc_t
      Dim dps As Integer = GetMp().GetDps()
      Return New mpc_t(GetMp().GetFunction07(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr, m6.PyPtr, m7.PyPtr))
    End Function



    Shared Function appellf2(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t, m7 As mpc_t) As mpc_t
      Return GetFunction07("appellf4", m1, m2, m3, m4, m5, m6, m7)
    End Function


    Shared Function appellf3(m1 As mpc_t, m2 As mpc_t, m3 As mpc_t, m4 As mpc_t, m5 As mpc_t, m6 As mpc_t, m7 As mpc_t) As mpc_t
      Return GetFunction07("appellf3", m1, m2, m3, m4, m5, m6, m7)
    End Function



  End Class

