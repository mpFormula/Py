Imports System
Imports Microsoft.Scripting
Imports MpMath


Public Class mpf_t


    Friend PyPtr As Object = Nothing

    Public Sub New()
      PyPtr = MpAll.Getmpf("0")
    End Sub

    Public Sub New(ByVal s As String)
      PyPtr = MpAll.Getmpf(s)
    End Sub

    Public Sub New(ByVal d As Double)
      PyPtr = MpAll.Getmpf(d)
    End Sub

    Public Sub New(ByVal x As Object)
      If TypeOf x Is mpf_t Then
        PyPtr = DirectCast(x, mpf_t).PyPtr
      Else
        PyPtr = MpAll.Getmpf(x)
      End If
    End Sub

    Public Sub New(ByVal x As mpf_t)
      PyPtr = x.PyPtr
    End Sub


    Public Shared Widening Operator CType(ByVal m1 As mpf_t) As String
      Return m1.Str()
    End Operator


    'Public Shared Narrowing Operator CType(ByVal s As String) As mpf_t
    Public Shared Widening Operator CType(ByVal s As String) As mpf_t
      Return New mpf_t(s)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpf_t) As Decimal
      Return CDec(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpf_t
      Return New mpf_t(CStr(dec))
    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpf_t
    '    Return New mpf_t(obj)
    '  End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpf_t) As Double
      Return CDbl(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal d As Double) As mpf_t
      Return New mpf_t(d)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpf_t) As Long
      Return CLng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal si As Long) As mpf_t
      Return New mpf_t(CStr(si))
    End Operator



    Public Shared Narrowing Operator CType(ByVal m1 As mpf_t) As ULong
      Return CULng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal ui As ULong) As mpf_t
      Return New mpf_t(CStr(ui))
    End Operator



    Public Shared Operator =(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr = m1.PyPtr
    End Operator



    Public Shared Operator <>(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr <> m1.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr <= m2.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr <= m2.PyPtr
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr <= m1.PyPtr
    End Operator




    Public Shared Operator <(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr < m2.PyPtr
    End Operator


    Public Shared Operator <(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr < m2.PyPtr
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr < m1.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr >= m1.PyPtr
    End Operator




    Public Shared Operator >(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As Boolean
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal m1 As mpf_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpf_t) As Boolean
      Dim m2 As New mpf_t(obj)
      Return m2.PyPtr > m1.PyPtr
    End Operator


    Public Shared Operator +(ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = m1.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = -m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      'MsgBox("Plus_mpf_t")
      m3.PyPtr = m1.PyPtr + m2.PyPtr
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpf_t, ByVal obj As Object) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = m1.PyPtr - m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpf_t, ByVal obj As Object) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m1.PyPtr - m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m3.PyPtr - m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = m1.PyPtr * m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpf_t, ByVal obj As Object) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m1.PyPtr * m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m3.PyPtr * m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = m1.PyPtr / m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpf_t, ByVal obj As Object) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m1.PyPtr / m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpf_t) As mpf_t
      Dim m3 As New mpf_t(obj)
      m3.PyPtr = m3.PyPtr / m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpf_t, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpf_t) As String
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

    Public Shared Operator ^(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      m3.PyPtr = m1.PyPtr ^ m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr. Mod (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr \ (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpf_t, ByVal i As Integer) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpf_t, ByVal i As Integer) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpf_t) As Boolean
      '    Return m1.PyPtr.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpf_t) As Boolean
      '    Return m1.PyPtr.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpf_t) As Boolean
      '    If m1.PyPtr.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr.AND(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr.OR(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpf_t, ByVal m2 As mpf_t) As mpf_t
      Dim m3 As New mpf_t()
      '    m3.PyPtr = m1.PyPtr.XOR(m2.PyPtr)
      Return m3
    End Operator


    Public Overrides Function ToString() As String
      Return MpAll.MpMathToString(PyPtr, mpf.dps)
    End Function





    Public Function Str() As String
      Return MpAll.MpMathToString(PyPtr, mpf.dps)
    End Function

    Public Function __str__() As String
      Return MpAll.MpMathToString(PyPtr, mpf.dps)
    End Function



  End Class


  Public Module mpf


    Private ReadOnly Property mpf_() As Object
        Get
          Static mpMathInstance As Object = Nothing
          If IsNothing(mpMathInstance) Then mpMathInstance = MpAll.GetMp()
          Return mpMathInstance
      End Get
    End Property




    Public Property dps() As Integer
      Get
        Return MpAll.GetDps()
      End Get

      Set(ByVal Value As Integer)
        MpAll.SetDps(Value)
      End Set
    End Property


    Public Property prec() As Integer
      Get
        Return MpAll.GetPrec()
      End Get

      Set(ByVal Value As Integer)
        MpAll.SetPrec(Value)
      End Set
    End Property


    Public Property pretty() As Boolean
      Get
        Return MpAll.GetPretty()
      End Get

      Set(ByVal Value As Boolean)
        MpAll.SetPretty(Value)
      End Set
    End Property


    Public Property trap_complex() As Boolean
      Get
        Return MpAll.Get_trap_complex()
      End Get

      Set(ByVal Value As Boolean)
        MpAll.Set_trap_complex(Value)
      End Set
    End Property



    Public Function GetFunction00(FunctionEnum As String) As mpf_t
        Dim dps As Integer = MpAll.GetDps()
        Return New mpf_t(MpMathClass.GetFunction00(dps, FunctionEnum))
    End Function




'
'    Public Function pi() As mpf_t
'      Return GetFunction00("pi")
'    End Function


    Public Function pi() As mpf_t
		Try
			Return New mpf_t(mpf_.pi())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function





    Public Function degree() As mpf_t
		Try
			Return New mpf_t(mpf_.degree())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function


    Public Function e() As mpf_t
		Try
			Return New mpf_t(mpf_.e())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function


    Public Function phi() As mpf_t
      Return GetFunction00("phi")
    End Function


    Public Function euler() As mpf_t
      Return GetFunction00("euler")
    End Function


    Public Function catalan() As mpf_t
      Return GetFunction00("catalan")
    End Function


    Public Function apery() As mpf_t
      Return GetFunction00("apery")
    End Function


    Public Function khinchin() As mpf_t
      Return GetFunction00("khinchin")
    End Function


    Public Function glaisher() As mpf_t
      Return GetFunction00("glaisher")
    End Function


    Public Function mertens() As mpf_t
      Return GetFunction00("mertens")
    End Function


    Public Function twinprime() As mpf_t
      Return GetFunction00("twinprime")
    End Function


    Public Function j() As mpf_t
      Return GetFunction00("j")
    End Function
    

    Public Function inf() As mpf_t
      Return GetFunction00("inf")
    End Function


    Public Function nan() As mpf_t
      Return GetFunction00("nan")
    End Function


    Public Function rand() As mpf_t
      Return GetFunction00("rand")
    End Function



    

    Public Function GetFunction01B(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)
    End Function




    Public Function isinf(m1 As mpf_t) As Boolean
      Return GetFunction01B("isinf", m1.PyPtr)
    End Function


    Public Function isnan(m1 As mpf_t) As Boolean
      Return GetFunction01B("isnan", m1.PyPtr)
    End Function


    Public Function isnormal(m1 As mpf_t) As Boolean
      Return GetFunction01B("isnormal", m1.PyPtr)
    End Function


    Public Function isfinite(m1 As mpf_t) As Boolean
      Return GetFunction01B("isfinite", m1.PyPtr)
    End Function


    Public Function isint(m1 As mpf_t) As Boolean
      Return GetFunction01B("isint", m1.PyPtr)
    End Function


    

    '	*********************************************
    
    
    Public Function GetFunction01(FunctionEnum As String, m1 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
       Return New mpf_t(MpMathClass.GetFunction01(dps, FunctionEnum, m1.PyPtr))
    End Function


    Public Function mpf(x1 As Object) As mpf_t
      Return GetFunction01("mpf", x1)
    End Function


    Public Function convert(x1 As Object) As mpf_t
      Return GetFunction01("convert", x1)
    End Function

    Public Function mpmathify(x1 As Object) As mpf_t
      Return GetFunction01("convert", x1)
    End Function

    Public Function nstr(x1 As Object) As mpf_t
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************
    


    Public Function mag(m1 As mpf_t) As mpf_t
      Return GetFunction01("mag", m1.PyPtr)
    End Function


    Public Function nint_distance(m1 As mpf_t) As mpf_t
      Return GetFunction01("nint_distance", m1.PyPtr)
    End Function
    
    
        
    Public Function fneg(m1 As mpf_t) As mpf_t
      Return GetFunction01("fneg", m1.PyPtr)
    End Function

     
    Public Function fabs(m1 As mpf_t) As mpf_t
      Return GetFunction01("fabs", m1.PyPtr)
    End Function
   

    Public Function sign(m1 As mpf_t) As mpf_t
      Return GetFunction01("sign", m1.PyPtr)
    End Function

    Public Function re(m1 As mpf_t) As mpf_t
      Return GetFunction01("re", m1.PyPtr)
    End Function

    Public Function im(m1 As mpf_t) As mpf_t
      Return GetFunction01("im", m1.PyPtr)
    End Function

    Public Function arg(m1 As mpf_t) As mpf_t
      Return GetFunction01("arg", m1.PyPtr)
    End Function

    ' same as arg
    Public Function phase(m1 As mpf_t) As mpf_t
      Return GetFunction01("phase", m1.PyPtr)
    End Function


    Public Function conj (m1 As mpf_t) As mpf_t
      Return GetFunction01("conj", m1.PyPtr)
    End Function

    Public Function polar(m1 As mpf_t) As mpf_t
      Return GetFunction01("polar",  m1.PyPtr)
    End Function

    Public Function rect(m1 As mpf_t, m2 As mpf_t) As Object
      Return GetFunction02("rect", m1.PyPtr, m2.PyPtr)
    End Function




    
    
    
    
    
    '	*********************************************

    Public Function floor(m1 As mpf_t) As mpf_t
      Return GetFunction01("floor", m1.PyPtr)
    End Function


    Public Function ceil(m1 As mpf_t) As mpf_t
      Return GetFunction01("ceil", m1)
    End Function


    Public Function nint(m1 As mpf_t) As mpf_t
      Return GetFunction01("nint", m1)
    End Function


    Public Function frac(m1 As mpf_t) As mpf_t
      Return GetFunction01("nint", m1)
    End Function


    '	*********************************************

    Public Function chop(m1 As mpf_t) As mpf_t
      Return GetFunction01("chop", m1)
    End Function



    Public Function sqrt(m1 As mpf_t) As mpf_t
      Return GetFunction01("sqrt", m1)
    End Function


    Public Function cbrt(m1 As mpf_t) As mpf_t
      Return GetFunction01("cbrt", m1)
    End Function


    Public Function exp(m1 As mpf_t) As mpf_t
      Return GetFunction01("exp", m1)
    End Function

    Public Function expm1(m1 As mpf_t) As mpf_t
      Return GetFunction01("expm1", m1)
    End Function

    Public Function log(m1 As mpf_t) As mpf_t
      Return GetFunction01("log", m1)
    End Function

    Public Function ln(m1 As mpf_t) As mpf_t
      Return GetFunction01("ln", m1)
    End Function

    Public Function ln10(m1 As mpf_t) As mpf_t
      Return GetFunction01("ln10", m1)
    End Function

    Public Function ln2(m1 As mpf_t) As mpf_t
      Return GetFunction01("ln2", m1)
    End Function


    Public Function log10(m1 As mpf_t) As mpf_t
      Return GetFunction01("log10", m1)
    End Function

    Public Function log2(m1 As mpf_t) As mpf_t
      Return GetFunction01("log2", m1)
    End Function

    Public Function lambertw(m1 As mpf_t) As mpf_t
      Return GetFunction01("lambertw", m1)
    End Function



    Public Function degrees(m1 As mpf_t) As mpf_t
      Return GetFunction01("degrees", m1)
    End Function

    Public Function radians(m1 As mpf_t) As mpf_t
      Return GetFunction01("radians", m1)
    End Function

    Public Function cos(m1 As mpf_t) As mpf_t
      Return GetFunction01("cos", m1)
    End Function

    Public Function sin(m1 As mpf_t) As mpf_t
      Return GetFunction01("sin", m1)
    End Function

    Public Function cos_sin(m1 As mpf_t) As mpf_t
      Return GetFunction01("cos_sin", m1)
    End Function


    Public Function tan(m1 As mpf_t) As mpf_t
      Return GetFunction01("tan", m1)
    End Function

    Public Function sec(m1 As mpf_t) As mpf_t
      Return GetFunction01("sec", m1)
    End Function

    Public Function csc(m1 As mpf_t) As mpf_t
      Return GetFunction01("csc", m1)
    End Function

    Public Function cot(m1 As mpf_t) As mpf_t
      Return GetFunction01("cot", m1)
    End Function

    Public Function cospi(m1 As mpf_t) As mpf_t
      Return GetFunction01("cospi", m1)
    End Function

    Public Function sinpi(m1 As mpf_t) As mpf_t
      Return GetFunction01("sinpi", m1)
    End Function


    Public Function cospi_sinpi(m1 As mpf_t) As mpf_t
      Return GetFunction01("cospi_sinpi", m1)
    End Function


    Public Function acos(m1 As mpf_t) As mpf_t
      Return GetFunction01("acos", m1)
    End Function

    Public Function asin(m1 As mpf_t) As mpf_t
      Return GetFunction01("asin", m1)
    End Function

    Public Function atan(m1 As mpf_t) As mpf_t
      Return GetFunction01("atan", m1)
    End Function

    Public Function asec(m1 As mpf_t) As mpf_t
      Return GetFunction01("asec", m1)
    End Function

    Public Function acsc(m1 As mpf_t) As mpf_t
      Return GetFunction01("acsc", m1)
    End Function

    Public Function acot(m1 As mpf_t) As mpf_t
      Return GetFunction01("acot", m1)
    End Function



    Public Function sinc(m1 As mpf_t) As mpf_t
      Return GetFunction01("sinc", m1)
    End Function

    Public Function sincpi(m1 As mpf_t) As mpf_t
      Return GetFunction01("sincpi", m1)
    End Function



    Public Function cosh(m1 As mpf_t) As mpf_t
      Return GetFunction01("cosh", m1)
    End Function


    Public Function sinh(m1 As mpf_t) As mpf_t
      Return GetFunction01("sinh", m1)
    End Function


    Public Function tanh(m1 As mpf_t) As mpf_t
      Return GetFunction01("tanh", m1)
    End Function


    Public Function sech(m1 As mpf_t) As mpf_t
      Return GetFunction01("sech", m1)
    End Function


    Public Function csch(m1 As mpf_t) As mpf_t
      Return GetFunction01("csch", m1)
    End Function


    Public Function coth(m1 As mpf_t) As mpf_t
      Return GetFunction01("coth", m1)
    End Function




    Public Function acosh(m1 As mpf_t) As mpf_t
      Return GetFunction01("acosh", m1)
    End Function


    Public Function asinh(m1 As mpf_t) As mpf_t
      Return GetFunction01("asinh", m1)
    End Function


    Public Function atanh(m1 As mpf_t) As mpf_t
      Return GetFunction01("atanh", m1)
    End Function


    Public Function asech(m1 As mpf_t) As mpf_t
      Return GetFunction01("asech", m1)
    End Function


    Public Function acsch(m1 As mpf_t) As mpf_t
      Return GetFunction01("acsch", m1)
    End Function


    Public Function acoth(m1 As mpf_t) As mpf_t
      Return GetFunction01("acoth", m1)
    End Function



    Public Function fac(m1 As mpf_t) As mpf_t
      Return GetFunction01("fac", m1)
    End Function


    Public Function factorial(m1 As mpf_t) As mpf_t
      Return GetFunction01("factorial", m1)
    End Function


    Public Function fac2(m1 As mpf_t) As mpf_t
      Return GetFunction01("fac2", m1)
    End Function


    Public Function gamma(m1 As mpf_t) As mpf_t
      Return GetFunction01("gamma", m1)
    End Function


    Public Function rgamma(m1 As mpf_t) As mpf_t
      Return GetFunction01("rgamma", m1)
    End Function


    Public Function loggamma(m1 As mpf_t) As mpf_t
      Return GetFunction01("loggamma", m1)
    End Function


    Public Function superfac(m1 As mpf_t) As mpf_t
      Return GetFunction01("superfac", m1)
    End Function


    Public Function hyperfac(m1 As mpf_t) As mpf_t
      Return GetFunction01("hyperfac", m1)
    End Function

    Public Function barnesg(m1 As mpf_t) As mpf_t
      Return GetFunction01("barnesg", m1)
    End Function


    Public Function digamma(m1 As mpf_t) As mpf_t
      Return GetFunction01("digamma", m1)
    End Function


    Public Function harmonic(m1 As mpf_t) As mpf_t
      Return GetFunction01("harmonic", m1)
    End Function




    Public Function ei(m1 As mpf_t) As mpf_t
      Return GetFunction01("ei", m1)
    End Function


    Public Function e1(m1 As mpf_t) As mpf_t
      Return GetFunction01("e1", m1)
    End Function


    Public Function li(m1 As mpf_t) As mpf_t
      Return GetFunction01("li", m1)
    End Function


    Public Function ci(m1 As mpf_t) As mpf_t
      Return GetFunction01("ci", m1)
    End Function


    Public Function si(m1 As mpf_t) As mpf_t
      Return GetFunction01("si", m1)
    End Function


    Public Function chi(m1 As mpf_t) As mpf_t
      Return GetFunction01("chi", m1)
    End Function


    Public Function shi(m1 As mpf_t) As mpf_t
      Return GetFunction01("shi", m1)
    End Function


    Public Function erf(m1 As mpf_t) As mpf_t
      Return GetFunction01("erf", m1)
    End Function


    Public Function erfc(m1 As mpf_t) As mpf_t
      Return GetFunction01("erfc", m1)
    End Function


    Public Function erfi(m1 As mpf_t) As mpf_t
      Return GetFunction01("erfi", m1)
    End Function


    Public Function erfinv(m1 As mpf_t) As mpf_t
      Return GetFunction01("erfinv", m1)
    End Function


    Public Function fresnels(m1 As mpf_t) As mpf_t
      Return GetFunction01("fresnels", m1)
    End Function


    Public Function fresnelc(m1 As mpf_t) As mpf_t
      Return GetFunction01("fresnelc", m1)
    End Function




    Public Function j0(m1 As mpf_t) As mpf_t
      Return GetFunction01("j0", m1)
    End Function


    Public Function j1(m1 As mpf_t) As mpf_t
      Return GetFunction01("j1", m1)
    End Function




    Public Function airyai(m1 As mpf_t) As mpf_t
      Return GetFunction01("airyai", m1)
    End Function


    Public Function airybi(m1 As mpf_t) As mpf_t
      Return GetFunction01("airybi", m1)
    End Function


    Public Function airyaizero(m1 As mpf_t) As mpf_t
      Return GetFunction01("airyaizero", m1)
    End Function


    Public Function airybizero(m1 As mpf_t) As mpf_t
      Return GetFunction01("airybizero", m1)
    End Function



    Public Function scorergi(m1 As mpf_t) As mpf_t
      Return GetFunction01("scorergi", m1)
    End Function


    Public Function scorerhi(m1 As mpf_t) As mpf_t
      Return GetFunction01("scorerhi", m1)
    End Function



    Public Function kleinj(m1 As mpf_t) As mpf_t
      Return GetFunction01("kleinj", m1)
    End Function




    Public Function zeta(m1 As mpf_t) As mpf_t
      Return GetFunction01("zeta", m1)
    End Function


    Public Function altzeta(m1 As mpf_t) As mpf_t
      Return GetFunction01("altzeta", m1)
    End Function


    Public Function zetazero(m1 As mpf_t) As mpf_t
      Return GetFunction01("zetazero", m1)
    End Function




    Public Function siegelz(m1 As mpf_t) As mpf_t
      Return GetFunction01("siegelz", m1)
    End Function


    Public Function siegeltheta(m1 As mpf_t) As mpf_t
      Return GetFunction01("siegeltheta", m1)
    End Function


    Public Function grampoint(m1 As mpf_t) As mpf_t
      Return GetFunction01("grampoint", m1)
    End Function


    Public Function backlunds(m1 As mpf_t) As mpf_t
      Return GetFunction01("backlunds", m1)
    End Function



    Public Function primezeta(m1 As mpf_t) As mpf_t
      Return GetFunction01("primezeta", m1)
    End Function


    Public Function secondzeta(m1 As mpf_t) As mpf_t
      Return GetFunction01("secondzeta", m1)
    End Function



    Public Function fibonacci(m1 As mpf_t) As mpf_t
      Return GetFunction01("fibonacci", m1)
    End Function


    Public Function fib(m1 As mpf_t) As mpf_t
      Return GetFunction01("fib", m1)
    End Function


    Public Function bernoulli(m1 As mpf_t) As mpf_t
      Return GetFunction01("bernoulli", m1)
    End Function



    Public Function eulernum(m1 As mpf_t) As mpf_t
      Return GetFunction01("eulernum", m1)
    End Function



    Public Function primepi(m1 As mpf_t) As mpf_t
      Return GetFunction01("primepi", m1)
    End Function


    Public Function primepi2(m1 As mpf_t) As mpf_t
      Return GetFunction01("primepi2", m1)
    End Function


    Public Function riemannr(m1 As mpf_t) As mpf_t
      Return GetFunction01("riemannr", m1)
    End Function


    Public Function mangoldt(m1 As mpf_t) As mpf_t
      Return GetFunction01("mangoldt", m1)
    End Function





    '	***********************************************


    Public Function GetFunction02(FunctionEnum As String, m1 As mpf_t, m2 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpf_t(MpMathClass.GetFunction02(dps, FunctionEnum, m1.PyPtr, m2.PyPtr))
    End Function
    




    Public Function fraction(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fraction", m1, m2)
    End Function



    Public Function fadd(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fadd", m1, m2)
    End Function


    Public Function fsub(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fsub", m1, m2)
    End Function



    Public Function fmul(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fmul", m1, m2)
    End Function


    Public Function fdiv(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fdiv", m1, m2)
    End Function



    Public Function fmod(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("fmod", m1, m2)
    End Function


    Public Function almosteq(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Public Function ldexp(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Public Function chop(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("chop", m1, m2)
    End Function


    Public Function hypot(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("hypot", m1, m2)
    End Function


    Public Function power(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("power", m1, m2)
    End Function


    Public Function powm1(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("powm1", m1, m2)
    End Function


    Public Function lambertw_k(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("lambertw_k", m1, m2)
    End Function


    Public Function agm(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("agm", m1, m2)
    End Function


    Public Function binomial(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("binomial", m1, m2)
    End Function



    Public Function atan2(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("atan2", m1, m2)
    End Function


    Public Function rf(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("rf", m1, m2)
    End Function


    Public Function ff(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ff", m1, m2)
    End Function


    Public Function beta(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("beta", m1, m2)
    End Function


    Public Function psi(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("psi", m1, m2)
    End Function


    Public Function polygamma(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("polygamma", m1, m2)
    End Function


    Public Function gammainc(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("gammainc", m1, m2)
    End Function


    Public Function expint(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("expint", m1, m2)
    End Function




    Public Function besselj(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("besselj", m1, m2)
    End Function


    Public Function bessely(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("bessely", m1, m2)
    End Function


    Public Function besseli(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("besseli", m1, m2)
    End Function


    Public Function besselk(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("besselk", m1, m2)
    End Function


    Public Function besseljzero(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("besseljzero", m1, m2)
    End Function


    Public Function besselyzero(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("besselyzero", m1, m2)
    End Function


    Public Function hankel1(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("hankel1", m1, m2)
    End Function


    Public Function hankel2(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("hankel2", m1, m2)
    End Function


    Public Function ber(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ber", m1, m2)
    End Function


    Public Function bei(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("bei", m1, m2)
    End Function


    Public Function ker(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ker", m1, m2)
    End Function


    Public Function kei(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("kei", m1, m2)
    End Function




    Public Function struveh(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("struveh", m1, m2)
    End Function


    Public Function struvel(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("struvel", m1, m2)
    End Function


    Public Function angerj(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("angerj", m1, m2)
    End Function


    Public Function webere(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("webere", m1, m2)
    End Function


    Public Function airyaideriv(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("airyaideriv", m1, m2)
    End Function


    Public Function airybideriv(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("airybideriv", m1, m2)
    End Function


    Public Function airyaiderivzero(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("airyaiderivzero", m1, m2)
    End Function


    Public Function airybiderivzero(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("airybiderivzero", m1, m2)
    End Function




    Public Function coulombc(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("coulombc", m1, m2)
    End Function


    Public Function pcfd(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("pcfd", m1, m2)
    End Function


    Public Function pcfu(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("pcfu", m1, m2)
    End Function


    Public Function pcfv(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("pcfv", m1, m2)
    End Function


    Public Function pcfw(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("pcfw", m1, m2)
    End Function



    Public Function legendre(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("legendre", m1, m2)
    End Function


    Public Function chebyt(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("chebyt", m1, m2)
    End Function


    Public Function chebyu(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("chebyu", m1, m2)
    End Function


    Public Function hermite(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("hermite", m1, m2)
    End Function



    Public Function hyp0f1(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("hyp0f1", m1, m2)
    End Function



    Public Function ellipf(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ellipf", m1, m2)
    End Function


    Public Function ellipe(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ellipe", m1, m2)
    End Function


    Public Function ellippi(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("ellippi", m1, m2)
    End Function


    Public Function elliprc(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("elliprc", m1, m2)
    End Function



    Public Function zeta(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("zeta", m1, m2)
    End Function


    Public Function hurwitz(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("zeta", m1, m2)
    End Function

    Public Function dirichlet(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("dirichlet", m1, m2)
    End Function


    Public Function stieltjes(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("stieltjes", m1, m2)
    End Function



    Public Function polylog(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("polylog", m1, m2)
    End Function


    Public Function clsin(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("clsin", m1, m2)
    End Function


    Public Function clcos(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("clcos", m1, m2)
    End Function


    Public Function polyexp(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("polyexp", m1, m2)
    End Function




    Public Function bernpoly(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("bernpoly", m1, m2)
    End Function


    Public Function eulerpoly(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("eulerpoly", m1, m2)
    End Function


    Public Function bell(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("bell", m1, m2)
    End Function


    Public Function stirling1(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("stirling1", m1, m2)
    End Function


    Public Function stirling2(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("stirling2", m1, m2)
    End Function


    Public Function cyclotomic(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("cyclotomic", m1, m2)
    End Function



    Public Function qgamma(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("qgamma", m1, m2)
    End Function


    Public Function qfac(m1 As mpf_t, m2 As mpf_t) As mpf_t
      Return GetFunction02("qfac", m1, m2)
    End Function






    Public Function GetFunction03(FunctionEnum As String, m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpf_t(MpMathClass.GetFunction03(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr))
    End Function


    Public Function root(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("root", m1, m2, m3)
    End Function
    
    
    Public Function nthroot(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("nthroot", m1, m2, m3)
    End Function


    Public Function hypercomb(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("hypercomb", m1, m2, m3)
    End Function


    Public Function betainc(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("betainc", m1, m2, m3)
    End Function


    Public Function npdf(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("npdf", m1, m2, m3)
    End Function


    Public Function ncdf(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("ncdf", m1, m2, m3)
    End Function


    Public Function besseljderiv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besseljderiv", m1, m2, m3)
    End Function


    Public Function besselyderiv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besselyderiv", m1, m2, m3)
    End Function


    Public Function besselideriv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besselideriv", m1, m2, m3)
    End Function


    Public Function besselkderiv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besselkderiv", m1, m2, m3)
    End Function


    Public Function besseljzeroderiv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besseljzeroderiv", m1, m2, m3)
    End Function


    Public Function besselyzeroderiv(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("besselyzeroderiv", m1, m2, m3)
    End Function



    Public Function lommels1(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("lommels1", m1, m2, m3)
    End Function


    Public Function lommels2(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("lommels2", m1, m2, m3)
    End Function


    Public Function coulombf(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("coulombf", m1, m2, m3)
    End Function


    Public Function coulombg(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("coulombg", m1, m2, m3)
    End Function


    Public Function hyperu(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("hyperu", m1, m2, m3)
    End Function


    Public Function whitm(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("whitm", m1, m2, m3)
    End Function


    Public Function whitw(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("whitw", m1, m2, m3)
    End Function



    Public Function legenp(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("legenp", m1, m2, m3)
    End Function


    Public Function legenq(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("legenq", m1, m2, m3)
    End Function


    Public Function gegenbauer(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("gegenbauer", m1, m2, m3)
    End Function


    Public Function laguerre(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("laguerre", m1, m2, m3)
    End Function



    Public Function hyp1f1(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("hyp1f1", m1, m2, m3)
    End Function


    Public Function hyp2f0(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("hyp2f0", m1, m2, m3)
    End Function


    Public Function hyper(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("hyper", m1, m2, m3)
    End Function


    Public Function bihyper(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("bihyper", m1, m2, m3)
    End Function



    Public Function ellippi(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("ellippi", m1, m2, m3)
    End Function


    Public Function elliprf(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("elliprf", m1, m2, m3)
    End Function


    Public Function elliprd(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("elliprd", m1, m2, m3)
    End Function


    Public Function elliprg(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("elliprg", m1, m2, m3)
    End Function



    Public Function jtheta(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("jtheta", m1, m2, m3)
    End Function


    Public Function ellipfun(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("ellipfun", m1, m2, m3)
    End Function



    Public Function zeta(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("zeta", m1, m2, m3)
    End Function


    Public Function dirichlet(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("dirichlet", m1, m2, m3)
    End Function


    Public Function lerchphi(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("lerchphi", m1, m2, m3)
    End Function



    Public Function stirling1(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("stirling1", m1, m2, m3)
    End Function


    Public Function stirling2(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("stirling2", m1, m2, m3)
    End Function


    Public Function qp(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t) As mpf_t
      Return GetFunction03("qp", m1, m2, m3)
    End Function









    Public Function GetFunction04(FunctionEnum As String, m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
              Return New mpf_t(MpMathClass.GetFunction04(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr))
    End Function




    Public Function jacobi(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("jacobi", m1, m2, m3, m4)
    End Function


    Public Function spherharm(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("spherharm", m1, m2, m3, m4)
    End Function


    Public Function hyp1f2(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("hyp1f2", m1, m2, m3, m4)
    End Function


    Public Function hyp2f1(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("hyp2f1", m1, m2, m3, m4)
    End Function


    Public Function meijerg(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("meijerg", m1, m2, m3, m4)
    End Function


    Public Function hyper2d(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("hyper2d", m1, m2, m3, m4)
    End Function


    Public Function elliprj(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("elliprj", m1, m2, m3, m4)
    End Function


    Public Function jtheta(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("jtheta", m1, m2, m3, m4)
    End Function


    Public Function qhyper(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t) As mpf_t
      Return GetFunction04("qhyper", m1, m2, m3, m4)
    End Function





    Public Function GetFunction05(FunctionEnum As String, m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpf_t(MpMathClass.GetFunction05(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr))
    End Function



    Public Function hyp2f2(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t) As mpf_t
      Return GetFunction05("hyp2f2", m1, m2, m3, m4, m5)
    End Function






    Public Function GetFunction06(FunctionEnum As String, m1  As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpf_t(MpMathClass.GetFunction06(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr, m6.PyPtr))
    End Function



    Public Function hyp2f3( m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t) As mpf_t
      Return GetFunction06("hyp2f3", m1, m2, m3, m4, m5, m6)
    End Function


    Public Function hyp3f2( m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t) As mpf_t
      Return GetFunction06("hyp3f2", m1, m2, m3, m4, m5, m6)
    End Function


    Public Function appellf1( m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t) As mpf_t
      Return GetFunction06("appellf1", m1, m2, m3, m4, m5, m6)
    End Function


    Public Function appellf4( m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t) As mpf_t
      Return GetFunction06("appellf4", m1, m2, m3, m4, m5, m6)
    End Function





    Public Function GetFunction07(FunctionEnum As String, m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t, m7 As mpf_t) As mpf_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpf_t(MpMathClass.GetFunction07(dps, FunctionEnum, m1.PyPtr, m2.PyPtr, m3.PyPtr, m4.PyPtr, m5.PyPtr, m6.PyPtr, m7.PyPtr))
    End Function



    Public Function appellf2(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t, m7 As mpf_t) As mpf_t
      Return GetFunction07("appellf4", m1, m2, m3, m4, m5, m6, m7)
    End Function


    Public Function appellf3(m1 As mpf_t, m2 As mpf_t, m3 As mpf_t, m4 As mpf_t, m5 As mpf_t, m6 As mpf_t, m7 As mpf_t) As mpf_t
      Return GetFunction07("appellf3", m1, m2, m3, m4, m5, m6, m7)
    End Function



  End Module

