Imports System
Imports Microsoft.Scripting
Imports MpMath


Public Class mpi_t


    Friend PyPtr As Object = Nothing

    Public Sub New()
      PyPtr = MpAll.Getmpi("0")
    End Sub

    Public Sub New(ByVal s As String)
      PyPtr = MpAll.Getmpi(s)
    End Sub

    Public Sub New(ByVal d As Double)
      PyPtr = MpAll.Getmpi(d)
    End Sub

    Public Sub New(ByVal x As Object)
      If TypeOf x Is mpi_t Then
        PyPtr = DirectCast(x, mpi_t).PyPtr
      Else
        PyPtr = MpAll.Getmpi(x)
      End If
    End Sub

    Public Sub New(ByVal x As mpi_t)
      PyPtr = x.PyPtr
    End Sub


    Public Shared Widening Operator CType(ByVal m1 As mpi_t) As String
      Return m1.Str()
    End Operator


    'Public Shared Narrowing Operator CType(ByVal s As String) As mpi_t
    Public Shared Widening Operator CType(ByVal s As String) As mpi_t
      Return New mpi_t(s)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpi_t) As Decimal
      Return CDec(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpi_t
      Return New mpi_t(CStr(dec))
    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpi_t
    '    Return New mpi_t(obj)
    '  End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpi_t) As Double
      Return CDbl(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal d As Double) As mpi_t
      Return New mpi_t(d)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpi_t) As Long
      Return CLng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal si As Long) As mpi_t
      Return New mpi_t(CStr(si))
    End Operator



    Public Shared Narrowing Operator CType(ByVal m1 As mpi_t) As ULong
      Return CULng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal ui As ULong) As mpi_t
      Return New mpi_t(CStr(ui))
    End Operator



    Public Shared Operator =(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr = m1.PyPtr
    End Operator



    Public Shared Operator <>(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr <> m1.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr <= m2.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr <= m2.PyPtr
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr <= m1.PyPtr
    End Operator




    Public Shared Operator <(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr < m2.PyPtr
    End Operator


    Public Shared Operator <(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr < m2.PyPtr
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr < m1.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr >= m1.PyPtr
    End Operator




    Public Shared Operator >(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As Boolean
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal m1 As mpi_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpi_t) As Boolean
      Dim m2 As New mpi_t(obj)
      Return m2.PyPtr > m1.PyPtr
    End Operator


    Public Shared Operator +(ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = m1.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = -m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      'MsgBox("Plus_mpi_t")
      m3.PyPtr = m1.PyPtr + m2.PyPtr
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpi_t, ByVal obj As Object) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = m1.PyPtr - m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpi_t, ByVal obj As Object) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m1.PyPtr - m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m3.PyPtr - m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = m1.PyPtr * m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpi_t, ByVal obj As Object) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m1.PyPtr * m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m3.PyPtr * m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = m1.PyPtr / m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpi_t, ByVal obj As Object) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m1.PyPtr / m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpi_t) As mpi_t
      Dim m3 As New mpi_t(obj)
      m3.PyPtr = m3.PyPtr / m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpi_t, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpi_t) As String
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

    Public Shared Operator ^(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      m3.PyPtr = m1.PyPtr ^ m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr. Mod (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr \ (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpi_t, ByVal i As Integer) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpi_t, ByVal i As Integer) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpi_t) As Boolean
      '    Return m1.PyPtr.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpi_t) As Boolean
      '    Return m1.PyPtr.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpi_t) As Boolean
      '    If m1.PyPtr.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr.AND(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr.OR(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpi_t, ByVal m2 As mpi_t) As mpi_t
      Dim m3 As New mpi_t()
      '    m3.PyPtr = m1.PyPtr.XOR(m2.PyPtr)
      Return m3
    End Operator


    Public Overrides Function ToString() As String
      Return MpAll.MpMathToString(PyPtr, mpi.dps)
    End Function





    Public Function Str() As String
      Return MpAll.MpMathToString(PyPtr, mpi.dps)
    End Function

    Public Function __str__() As String
      Return MpAll.MpMathToString(PyPtr, mpi.dps)
    End Function



  End Class


  Public Module mpi


    Private ReadOnly Property mpi_() As Object
        Get
          Static mpMathInstance As Object = Nothing
          If IsNothing(mpMathInstance) Then mpMathInstance = MpAll.GetIv()
          Return mpMathInstance
      End Get
    End Property




    Public Property dps() As Integer
      Get
        Return MpAll.GetDps()
      End Get

      Set(ByVal Value As Integer)
        MpAll.SetIvDps(Value)
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



    Public Function GetFunction00(FunctionEnum As String) As mpi_t
        Dim dps As Integer = MpAll.GetDps()
        Return New mpi_t(ivMathClass.GetFunction00(dps, FunctionEnum))
    End Function




'
'    Public Function pi() As mpi_t
'      Return GetFunction00("pi")
'    End Function


    Public Function pi() As mpi_t
		Try
			Return New mpi_t(mpi_.pi())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function





    Public Function degree() As mpi_t
		Try
			Return New mpi_t(mpi_.degree())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function


    Public Function e() As mpi_t
		Try
			Return New mpi_t(mpi_.e())		
		Catch ex As Exception
		    MpAll.ReportException(ex)
		    Return Nothing
		End Try
    End Function


    Public Function phi() As mpi_t
      Return GetFunction00("phi")
    End Function


    Public Function euler() As mpi_t
      Return GetFunction00("euler")
    End Function


    Public Function catalan() As mpi_t
      Return GetFunction00("catalan")
    End Function


    Public Function apery() As mpi_t
      Return GetFunction00("apery")
    End Function


    Public Function khinchin() As mpi_t
      Return GetFunction00("khinchin")
    End Function


    Public Function glaisher() As mpi_t
      Return GetFunction00("glaisher")
    End Function


    Public Function mertens() As mpi_t
      Return GetFunction00("mertens")
    End Function


    Public Function twinprime() As mpi_t
      Return GetFunction00("twinprime")
    End Function


    Public Function j() As mpi_t
      Return GetFunction00("j")
    End Function
    

    Public Function inf() As mpi_t
      Return GetFunction00("inf")
    End Function


    Public Function nan() As mpi_t
      Return GetFunction00("nan")
    End Function


    Public Function rand() As mpi_t
      Return GetFunction00("rand")
    End Function



    

    Public Function GetFunction01B(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return ivMathClass.GetFunction01(dps, FunctionEnum, n1)
    End Function




    Public Function isinf(m1 As mpi_t) As Boolean
      Return GetFunction01B("isinf", m1.PyPtr)
    End Function


    Public Function isnan(m1 As mpi_t) As Boolean
      Return GetFunction01B("isnan", m1.PyPtr)
    End Function


    Public Function isnormal(m1 As mpi_t) As Boolean
      Return GetFunction01B("isnormal", m1.PyPtr)
    End Function


    Public Function isfinite(m1 As mpi_t) As Boolean
      Return GetFunction01B("isfinite", m1.PyPtr)
    End Function


    Public Function isint(m1 As mpi_t) As Boolean
      Return GetFunction01B("isint", m1.PyPtr)
    End Function


    

    '	*********************************************
    
    
    Public Function GetFunction01(FunctionEnum As String, m1 As mpi_t) As mpi_t
      Dim dps As Integer = MpAll.GetDps()
       Return New mpi_t(ivMathClass.GetFunction01(dps, FunctionEnum, m1.PyPtr))
    End Function


    Public Function mpi(x1 As Object) As mpi_t
      Return GetFunction01("mpi", x1)
    End Function


    Public Function convert(x1 As Object) As mpi_t
      Return GetFunction01("convert", x1)
    End Function

    Public Function mpmathify(x1 As Object) As mpi_t
      Return GetFunction01("convert", x1)
    End Function

    Public Function nstr(x1 As Object) As mpi_t
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************
    


    Public Function mag(m1 As mpi_t) As mpi_t
      Return GetFunction01("mag", m1.PyPtr)
    End Function


    Public Function nint_distance(m1 As mpi_t) As mpi_t
      Return GetFunction01("nint_distance", m1.PyPtr)
    End Function
    
    
        
    Public Function fneg(m1 As mpi_t) As mpi_t
      Return GetFunction01("fneg", m1.PyPtr)
    End Function

     
    Public Function fabs(m1 As mpi_t) As mpi_t
      Return GetFunction01("fabs", m1.PyPtr)
    End Function
   

    Public Function sign(m1 As mpi_t) As mpi_t
      Return GetFunction01("sign", m1.PyPtr)
    End Function

    Public Function re(m1 As mpi_t) As mpi_t
      Return GetFunction01("re", m1.PyPtr)
    End Function

    Public Function im(m1 As mpi_t) As mpi_t
      Return GetFunction01("im", m1.PyPtr)
    End Function

    Public Function arg(m1 As mpi_t) As mpi_t
      Return GetFunction01("arg", m1.PyPtr)
    End Function

    ' same as arg
    Public Function phase(m1 As mpi_t) As mpi_t
      Return GetFunction01("phase", m1.PyPtr)
    End Function


    Public Function conj (m1 As mpi_t) As mpi_t
      Return GetFunction01("conj", m1.PyPtr)
    End Function

    Public Function polar(m1 As mpi_t) As mpi_t
      Return GetFunction01("polar",  m1.PyPtr)
    End Function

    Public Function rect(m1 As mpi_t, m2 As mpi_t) As Object
      Return GetFunction02("rect", m1.PyPtr, m2.PyPtr)
    End Function




    
    
    
    
    
    '	*********************************************

    Public Function floor(m1 As mpi_t) As mpi_t
      Return GetFunction01("floor", m1.PyPtr)
    End Function


    Public Function ceil(m1 As mpi_t) As mpi_t
      Return GetFunction01("ceil", m1)
    End Function


    Public Function nint(m1 As mpi_t) As mpi_t
      Return GetFunction01("nint", m1)
    End Function


    Public Function frac(m1 As mpi_t) As mpi_t
      Return GetFunction01("nint", m1)
    End Function


    '	*********************************************

    Public Function chop(m1 As mpi_t) As mpi_t
      Return GetFunction01("chop", m1)
    End Function



    Public Function sqrt(m1 As mpi_t) As mpi_t
      Return GetFunction01("sqrt", m1)
    End Function


    Public Function cbrt(m1 As mpi_t) As mpi_t
      Return GetFunction01("cbrt", m1)
    End Function


    Public Function exp(m1 As mpi_t) As mpi_t
      Return GetFunction01("exp", m1)
    End Function

    Public Function expm1(m1 As mpi_t) As mpi_t
      Return GetFunction01("expm1", m1)
    End Function

    Public Function log(m1 As mpi_t) As mpi_t
      Return GetFunction01("log", m1)
    End Function

    Public Function ln(m1 As mpi_t) As mpi_t
      Return GetFunction01("ln", m1)
    End Function

    Public Function ln10(m1 As mpi_t) As mpi_t
      Return GetFunction01("ln10", m1)
    End Function

    Public Function ln2(m1 As mpi_t) As mpi_t
      Return GetFunction01("ln2", m1)
    End Function


    Public Function log10(m1 As mpi_t) As mpi_t
      Return GetFunction01("log10", m1)
    End Function

    Public Function log2(m1 As mpi_t) As mpi_t
      Return GetFunction01("log2", m1)
    End Function

    Public Function lambertw(m1 As mpi_t) As mpi_t
      Return GetFunction01("lambertw", m1)
    End Function



    Public Function degrees(m1 As mpi_t) As mpi_t
      Return GetFunction01("degrees", m1)
    End Function

    Public Function radians(m1 As mpi_t) As mpi_t
      Return GetFunction01("radians", m1)
    End Function

    Public Function cos(m1 As mpi_t) As mpi_t
      Return GetFunction01("cos", m1)
    End Function

    Public Function sin(m1 As mpi_t) As mpi_t
      Return GetFunction01("sin", m1)
    End Function

    Public Function cos_sin(m1 As mpi_t) As mpi_t
      Return GetFunction01("cos_sin", m1)
    End Function


    Public Function tan(m1 As mpi_t) As mpi_t
      Return GetFunction01("tan", m1)
    End Function

    Public Function sec(m1 As mpi_t) As mpi_t
      Return GetFunction01("sec", m1)
    End Function

    Public Function csc(m1 As mpi_t) As mpi_t
      Return GetFunction01("csc", m1)
    End Function

    Public Function cot(m1 As mpi_t) As mpi_t
      Return GetFunction01("cot", m1)
    End Function

    Public Function cospi(m1 As mpi_t) As mpi_t
      Return GetFunction01("cospi", m1)
    End Function

    Public Function sinpi(m1 As mpi_t) As mpi_t
      Return GetFunction01("sinpi", m1)
    End Function


    Public Function cospi_sinpi(m1 As mpi_t) As mpi_t
      Return GetFunction01("cospi_sinpi", m1)
    End Function


    Public Function acos(m1 As mpi_t) As mpi_t
      Return GetFunction01("acos", m1)
    End Function

    Public Function asin(m1 As mpi_t) As mpi_t
      Return GetFunction01("asin", m1)
    End Function

    Public Function atan(m1 As mpi_t) As mpi_t
      Return GetFunction01("atan", m1)
    End Function

    Public Function asec(m1 As mpi_t) As mpi_t
      Return GetFunction01("asec", m1)
    End Function

    Public Function acsc(m1 As mpi_t) As mpi_t
      Return GetFunction01("acsc", m1)
    End Function

    Public Function acot(m1 As mpi_t) As mpi_t
      Return GetFunction01("acot", m1)
    End Function



    Public Function sinc(m1 As mpi_t) As mpi_t
      Return GetFunction01("sinc", m1)
    End Function

    Public Function sincpi(m1 As mpi_t) As mpi_t
      Return GetFunction01("sincpi", m1)
    End Function



    Public Function cosh(m1 As mpi_t) As mpi_t
      Return GetFunction01("cosh", m1)
    End Function


    Public Function sinh(m1 As mpi_t) As mpi_t
      Return GetFunction01("sinh", m1)
    End Function


    Public Function tanh(m1 As mpi_t) As mpi_t
      Return GetFunction01("tanh", m1)
    End Function


    Public Function sech(m1 As mpi_t) As mpi_t
      Return GetFunction01("sech", m1)
    End Function


    Public Function csch(m1 As mpi_t) As mpi_t
      Return GetFunction01("csch", m1)
    End Function


    Public Function coth(m1 As mpi_t) As mpi_t
      Return GetFunction01("coth", m1)
    End Function




    Public Function acosh(m1 As mpi_t) As mpi_t
      Return GetFunction01("acosh", m1)
    End Function


    Public Function asinh(m1 As mpi_t) As mpi_t
      Return GetFunction01("asinh", m1)
    End Function


    Public Function atanh(m1 As mpi_t) As mpi_t
      Return GetFunction01("atanh", m1)
    End Function


    Public Function asech(m1 As mpi_t) As mpi_t
      Return GetFunction01("asech", m1)
    End Function


    Public Function acsch(m1 As mpi_t) As mpi_t
      Return GetFunction01("acsch", m1)
    End Function


    Public Function acoth(m1 As mpi_t) As mpi_t
      Return GetFunction01("acoth", m1)
    End Function



    Public Function fac(m1 As mpi_t) As mpi_t
      Return GetFunction01("fac", m1)
    End Function


    Public Function factorial(m1 As mpi_t) As mpi_t
      Return GetFunction01("factorial", m1)
    End Function


    Public Function fac2(m1 As mpi_t) As mpi_t
      Return GetFunction01("fac2", m1)
    End Function


    Public Function gamma(m1 As mpi_t) As mpi_t
      Return GetFunction01("gamma", m1)
    End Function


    Public Function rgamma(m1 As mpi_t) As mpi_t
      Return GetFunction01("rgamma", m1)
    End Function


    Public Function loggamma(m1 As mpi_t) As mpi_t
      Return GetFunction01("loggamma", m1)
    End Function





    '	***********************************************


    Public Function GetFunction02(FunctionEnum As String, m1 As mpi_t, m2 As mpi_t) As mpi_t
      Dim dps As Integer = MpAll.GetDps()
      Return New mpi_t(ivMathClass.GetFunction02(dps, FunctionEnum, m1.PyPtr, m2.PyPtr))
    End Function
    




    Public Function fraction(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fraction", m1, m2)
    End Function



    Public Function fadd(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fadd", m1, m2)
    End Function


    Public Function fsub(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fsub", m1, m2)
    End Function



    Public Function fmul(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fmul", m1, m2)
    End Function


    Public Function fdiv(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fdiv", m1, m2)
    End Function



    Public Function fmod(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("fmod", m1, m2)
    End Function


    Public Function almosteq(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Public Function ldexp(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("almosteq", m1, m2)
    End Function


    Public Function chop(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("chop", m1, m2)
    End Function


    Public Function hypot(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("hypot", m1, m2)
    End Function


    Public Function power(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("power", m1, m2)
    End Function


    Public Function powm1(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("powm1", m1, m2)
    End Function


    Public Function atan2(m1 As mpi_t, m2 As mpi_t) As mpi_t
      Return GetFunction02("atan2", m1, m2)
    End Function






  End Module

