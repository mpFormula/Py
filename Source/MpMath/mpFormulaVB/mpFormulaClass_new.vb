Imports System
Imports MpMath
Imports Microsoft.Scripting
Imports IronPython.Runtime

Imports Office = NetOffice.OfficeApi 
Imports Excel = NetOffice.ExcelApi



Public Module mpFormula

  Public Class mpNum


    ' Should be friend as well  
    Public x1 As Object = Nothing
    Friend mpNumType As Int32 = 4

    Public Sub New()
      x1 = mp.GetMp().Getmpf("0")
    End Sub

    Public Sub New(ByVal s As String)
      x1 = mp.GetMp().Getmpf(s)
    End Sub

    Public Sub New(ByVal d As Double)
      x1 = mp.GetMp().Getmpf(d)
    End Sub

    Public Sub New(ByVal x As Object)
      If TypeOf x Is mpNum Then
        x1 = DirectCast(x, mpNum).x1
      Else
        x1 = mp.GetMp().Getmpf(x)
      End If
    End Sub

    Public Sub New(ByVal x As mpNum)
      x1 = x.x1
    End Sub


    Public Shared Widening Operator CType(ByVal m1 As mpNum) As String
      Return m1.Str()
    End Operator


    'Public Shared Narrowing Operator CType(ByVal s As String) As mpNum
    Public Shared Widening Operator CType(ByVal s As String) As mpNum
      Return New mpNum(s)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpNum) As Decimal
      Return CDec(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpNum
      Return New mpNum(CStr(dec))
    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpNum
    '    Return New mpNum(obj)
    '  End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpNum) As Double
      Return CDbl(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal d As Double) As mpNum
      Return New mpNum(d)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpNum) As Long
      Return CLng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal si As Long) As mpNum
      Return New mpNum(CStr(si))
    End Operator



    Public Shared Narrowing Operator CType(ByVal m1 As mpNum) As ULong
      Return CULng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal ui As ULong) As mpNum
      Return New mpNum(CStr(ui))
    End Operator



    Public Shared Operator =(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 = m2.x1
    End Operator


    Public Shared Operator =(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 = m2.x1
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 = m1.x1
    End Operator



    Public Shared Operator <>(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 <> m2.x1
    End Operator


    Public Shared Operator <>(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 <> m2.x1
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 <> m1.x1
    End Operator



    Public Shared Operator <=(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 <= m2.x1
    End Operator



    Public Shared Operator <=(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 <= m2.x1
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 <= m1.x1
    End Operator




    Public Shared Operator <(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 < m2.x1
    End Operator


    Public Shared Operator <(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 < m2.x1
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 < m1.x1
    End Operator


    Public Shared Operator >=(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 >= m2.x1
    End Operator


    Public Shared Operator >=(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 >= m2.x1
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 >= m1.x1
    End Operator




    Public Shared Operator >(ByVal m1 As mpNum, ByVal m2 As mpNum) As Boolean
      Return m1.x1 > m2.x1
    End Operator



    Public Shared Operator >(ByVal m1 As mpNum, ByVal obj As Object) As Boolean
      Dim m2 As New mpNum(obj)
      Return m1.x1 > m2.x1
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpNum) As Boolean
      Dim m2 As New mpNum(obj)
      Return m2.x1 > m1.x1
    End Operator


    Public Shared Operator +(ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = m1.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = -m1.x1
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      'MsgBox("Plus_mpNum")
      m3.x1 = m1.x1 + m2.x1
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpNum, ByVal obj As Object) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m1.x1 + m3.x1
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m1.x1 + m3.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = m1.x1 - m2.x1
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpNum, ByVal obj As Object) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m1.x1 - m3.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m3.x1 - m1.x1
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = m1.x1 * m2.x1
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpNum, ByVal obj As Object) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m1.x1 * m3.x1
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m3.x1 * m1.x1
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = m1.x1 / m2.x1
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpNum, ByVal obj As Object) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m1.x1 / m3.x1
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpNum) As mpNum
      Dim m3 As New mpNum(obj)
      m3.x1 = m3.x1 / m1.x1
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpNum, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpNum) As String
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

    Public Shared Operator ^(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      m3.x1 = m1.x1 ^ m2.x1
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1. Mod (m2.x1)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1 \ (m2.x1)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpNum, ByVal i As Integer) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpNum, ByVal i As Integer) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpNum) As Boolean
      '    Return m1.x1.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpNum) As Boolean
      '    Return m1.x1.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpNum) As Boolean
      '    If m1.x1.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1.AND(m2.x1)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1.OR(m2.x1)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpNum, ByVal m2 As mpNum) As mpNum
      Dim m3 As New mpNum()
      '    m3.x1 = m1.x1.XOR(m2.x1)
      Return m3
    End Operator


    Public Overrides Function ToString() As String
      Return mp.GetMp().MpMathToString(x1, mp.dps)
    End Function





    Public Function Str() As String
      Return mp.GetMp().MpMathToString(x1, mp.dps)
    End Function

    Public Function __str__() As String
      Return mp.GetMp().MpMathToString(x1, mp.dps)
    End Function



  End Class


  Public Class mp

    Shared FloatingPointType_ As Integer = 3

    Shared Function GetMp() As MpMathClass
      Static PyInstance As MpMathClass = Nothing
      If IsNothing(PyInstance) Then
        Try
          PyInstance = New MpMathClass
        Catch ex As Exception
          '				ReportException(ex)
        End Try
      End If
      Return PyInstance
    End Function


    '    Dim mp2 As New MpMathClass    

    Shared Sub New()
      Dim s As String = GetMp().PiString()
      '	Console.WriteLine(s)
    End Sub



    '  Public Function CNum(x As String) As mpNum
    Shared Function CNum(x As String) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As Object) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As mpNum) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


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


    '  	Shared Sub nprint(x1 As Object) 
    '	    GetMp().nprint2(x1)
    '	End Sub


    Shared Function GetFunction00(FunctionEnum As String) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction00(dps, FunctionEnum)
      '        Return CNum(GetMp().GetFunction00(dps, FunctionEnum))
    End Function



    Shared Function pi() As Object
      Return GetFunction00("pi")
    End Function


    Shared Function degree() As Object
      Return GetFunction00("degree")
    End Function


    Shared Function e() As Object
      Return GetFunction00("e")
    End Function


    Shared Function phi() As Object
      Return GetFunction00("phi")
    End Function


    Shared Function euler() As Object
      Return GetFunction00("euler")
    End Function


    Shared Function catalan() As Object
      Return GetFunction00("catalan")
    End Function


    Shared Function apery() As Object
      Return GetFunction00("apery")
    End Function


    Shared Function khinchin() As Object
      Return GetFunction00("khinchin")
    End Function


    Shared Function glaisher() As Object
      Return GetFunction00("glaisher")
    End Function


    Shared Function mertens() As Object
      Return GetFunction00("mertens")
    End Function


    Shared Function twinprime() As Object
      Return GetFunction00("twinprime")
    End Function


    Shared Function j() As Object
      Return GetFunction00("j")
    End Function


    Shared Function quadgl() As Object
      Return GetFunction00("quadgl")
    End Function


    Shared Function quadts() As Object
      Return GetFunction00("quadts")
    End Function

    Shared Function inf() As Object
      Return GetFunction00("inf")
    End Function


    Shared Function nan() As Object
      Return GetFunction00("nan")
    End Function


    Shared Function rand() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function eps() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function levin() As Object
      Return GetFunction00("levin")
    End Function


    Shared Function cohen_alt() As Object
      Return GetFunction00("cohen_alt")
    End Function




    Shared Function GetFunction01F(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, n1))
    End Function


    Shared Function GetFunction01List(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
    End Function


    Shared Function arange(x1 As Object) As Object
      Return GetFunction01List("arange", x1)
    End Function

    Shared Function matrix(x1 As Object) As Object
      Return GetFunction01List("matrix", x1)
    End Function

    Shared Function eye(x1 As Object) As Object
      Return GetFunction01List("eye", x1)
    End Function


    Shared Function diag(x1 As Object) As Object
      Return GetFunction01List("diag", x1)
    End Function



    Shared Function zeros(x1 As Object) As Object
      Return GetFunction01List("zeros", x1)
    End Function


    Shared Function ones(x1 As Object) As Object
      Return GetFunction01List("ones", x1)
    End Function


    Shared Function hilbert(x1 As Object) As Object
      Return GetFunction01List("hilbert", x1)
    End Function


    Shared Function randmatrix(x1 As Object) As Object
      Return GetFunction01List("randmatrix", x1)
    End Function


    Shared Function lu(x1 As Object) As Object
      Return GetFunction01List("lu", x1)
    End Function

    Shared Function qr(x1 As Object) As Object
      Return GetFunction01List("qr", x1)
    End Function

    Shared Function cholesky(x1 As Object) As Object
      Return GetFunction01List("cholesky", x1)
    End Function



    Shared Function det(x1 As Object) As Object
      Return GetFunction01List("det", x1)
    End Function

    Shared Function cond(x1 As Object) As Object
      Return GetFunction01List("cond", x1)
    End Function

    Shared Function inverse(x1 As Object) As Object
      Return GetFunction01List("inverse", x1)
    End Function



    Shared Function polyroots(x1 As Object) As Object
      Return GetFunction01List("polyroots", x1)
    End Function


    Shared Function GetFunction01(FunctionEnum As String, n1 As Object) As Object
      '	    Dim o1 As mpNum = CNum(n1)
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)

      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, o1.x1))
    End Function


    Shared Function mpf(x1 As Object) As Object
      Return GetFunction01("mpf", x1)
    End Function


    Shared Function mpc(x1 As Object) As Object
      Return GetFunction01("mpc", x1)
    End Function

    Shared Function convert(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function mpmathify(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function nstr(x1 As Object) As Object
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************

    Shared Function fneg(x1 As Object) As Object
      Return GetFunction01("fneg", x1)
    End Function


    Shared Function fsum(x1 As Object) As Object
      Return GetFunction01("fsum", x1)
    End Function


    Shared Function fprod(x1 As Object) As Object
      Return GetFunction01("fprod", x1)
    End Function


    Shared Function fdot(x1 As Object) As Object
      Return GetFunction01("fdot", x1)
    End Function


    Shared Function isinf(x1 As Object) As Object
      Return GetFunction01("isinf", x1)
    End Function


    Shared Function isnan(x1 As Object) As Object
      Return GetFunction01("isnan", x1)
    End Function


    Shared Function isnormal(x1 As Object) As Object
      Return GetFunction01("isnormal", x1)
    End Function


    Shared Function isfinite(x1 As Object) As Object
      Return GetFunction01("isfinite", x1)
    End Function


    Shared Function isint(x1 As Object) As Object
      Return GetFunction01("isint", x1)
    End Function


    Shared Function frexp(x1 As Object) As Object
      Return GetFunction01("frexp", x1)
    End Function


    Shared Function mag(x1 As Object) As Object
      Return GetFunction01("mag", x1)
    End Function


    Shared Function nint_distance(x1 As Object) As Object
      Return GetFunction01("nint_distance", x1)
    End Function

    '	*********************************************

    Shared Function floor(x1 As Object) As Object
      Return GetFunction01("floor", x1)
    End Function


    Shared Function ceil(x1 As Object) As Object
      Return GetFunction01("ceil", x1)
    End Function


    Shared Function nint(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    Shared Function frac(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    '	*********************************************

    Shared Function chop(x1 As Object) As Object
      Return GetFunction01("chop", x1)
    End Function



    Shared Function sqrt(x1 As Object) As Object
      Return GetFunction01("sqrt", x1)
    End Function


    Shared Function cbrt(x1 As Object) As Object
      Return GetFunction01("cbrt", x1)
    End Function

    Shared Function unitroots(x1 As Object) As Object
      Return GetFunction01("unitroots", x1)
    End Function

    Shared Function exp(x1 As Object) As Object
      Return GetFunction01("exp", x1)
    End Function

    Shared Function expj(x1 As Object) As Object
      Return GetFunction01("expj", x1)
    End Function

    Shared Function expjpi(x1 As Object) As Object
      Return GetFunction01("expjpi", x1)
    End Function

    Shared Function expm1(x1 As Object) As Object
      Return GetFunction01("expm1", x1)
    End Function

    Shared Function log(x1 As Object) As Object
      Return GetFunction01("log", x1)
    End Function

    Shared Function ln(x1 As Object) As Object
      Return GetFunction01("ln", x1)
    End Function

    Shared Function ln10(x1 As Object) As Object
      Return GetFunction01("ln10", x1)
    End Function

    Shared Function ln2(x1 As Object) As Object
      Return GetFunction01("ln2", x1)
    End Function


    Shared Function log10(x1 As Object) As Object
      Return GetFunction01("log10", x1)
    End Function

    Shared Function log2(x1 As Object) As Object
      Return GetFunction01("log2", x1)
    End Function

    Shared Function lambertw(x1 As Object) As Object
      Return GetFunction01("lambertw", x1)
    End Function



    Shared Function degrees(x1 As Object) As Object
      Return GetFunction01("degrees", x1)
    End Function

    Shared Function radians(x1 As Object) As Object
      Return GetFunction01("radians", x1)
    End Function

    Shared Function cos(x1 As Object) As Object
      Return GetFunction01("cos", x1)
    End Function

    Shared Function sin(x1 As Object) As Object
      Return GetFunction01("sin", x1)
    End Function

    Shared Function cos_sin(x1 As Object) As Object
      Return GetFunction01("cos_sin", x1)
    End Function


    Shared Function tan(x1 As Object) As Object
      Return GetFunction01("tan", x1)
    End Function

    Shared Function sec(x1 As Object) As Object
      Return GetFunction01("sec", x1)
    End Function

    Shared Function csc(x1 As Object) As Object
      Return GetFunction01("csc", x1)
    End Function

    Shared Function cot(x1 As Object) As Object
      Return GetFunction01("cot", x1)
    End Function

    Shared Function cospi(x1 As Object) As Object
      Return GetFunction01("cospi", x1)
    End Function

    Shared Function sinpi(x1 As Object) As Object
      Return GetFunction01("sinpi", x1)
    End Function


    Shared Function cospi_sinpi(x1 As Object) As Object
      Return GetFunction01("cospi_sinpi", x1)
    End Function


    Shared Function acos(x1 As Object) As Object
      Return GetFunction01("acos", x1)
    End Function

    Shared Function asin(x1 As Object) As Object
      Return GetFunction01("asin", x1)
    End Function

    Shared Function atan(x1 As Object) As Object
      Return GetFunction01("atan", x1)
    End Function

    Shared Function asec(x1 As Object) As Object
      Return GetFunction01("asec", x1)
    End Function

    Shared Function acsc(x1 As Object) As Object
      Return GetFunction01("acsc", x1)
    End Function

    Shared Function acot(x1 As Object) As Object
      Return GetFunction01("acot", x1)
    End Function



    Shared Function sinc(x1 As Object) As Object
      Return GetFunction01("sinc", x1)
    End Function

    Shared Function sincpi(x1 As Object) As Object
      Return GetFunction01("sincpi", x1)
    End Function



    Shared Function cosh(x1 As Object) As Object
      Return GetFunction01("cosh", x1)
    End Function


    Shared Function sinh(x1 As Object) As Object
      Return GetFunction01("sinh", x1)
    End Function


    Shared Function tanh(x1 As Object) As Object
      Return GetFunction01("tanh", x1)
    End Function


    Shared Function sech(x1 As Object) As Object
      Return GetFunction01("sech", x1)
    End Function


    Shared Function csch(x1 As Object) As Object
      Return GetFunction01("csch", x1)
    End Function


    Shared Function coth(x1 As Object) As Object
      Return GetFunction01("coth", x1)
    End Function




    Shared Function acosh(x1 As Object) As Object
      Return GetFunction01("acosh", x1)
    End Function


    Shared Function asinh(x1 As Object) As Object
      Return GetFunction01("asinh", x1)
    End Function


    Shared Function atanh(x1 As Object) As Object
      Return GetFunction01("atanh", x1)
    End Function


    Shared Function asech(x1 As Object) As Object
      Return GetFunction01("asech", x1)
    End Function


    Shared Function acsch(x1 As Object) As Object
      Return GetFunction01("acsch", x1)
    End Function


    Shared Function acoth(x1 As Object) As Object
      Return GetFunction01("acoth", x1)
    End Function



    Shared Function fac(x1 As Object) As Object
      Return GetFunction01("fac", x1)
    End Function


    Shared Function factorial(x1 As Object) As Object
      Return GetFunction01("factorial", x1)
    End Function


    Shared Function fac2(x1 As Object) As Object
      Return GetFunction01("fac2", x1)
    End Function


    Shared Function gamma(x1 As Object) As Object
      Return GetFunction01("gamma", x1)
    End Function


    Shared Function rgamma(x1 As Object) As Object
      Return GetFunction01("rgamma", x1)
    End Function


    Shared Function loggamma(x1 As Object) As Object
      Return GetFunction01("loggamma", x1)
    End Function


    Shared Function superfac(x1 As Object) As Object
      Return GetFunction01("superfac", x1)
    End Function


    Shared Function hyperfac(x1 As Object) As Object
      Return GetFunction01("hyperfac", x1)
    End Function

    Shared Function barnesg(x1 As Object) As Object
      Return GetFunction01("barnesg", x1)
    End Function


    Shared Function digamma(x1 As Object) As Object
      Return GetFunction01("digamma", x1)
    End Function


    Shared Function harmonic(x1 As Object) As Object
      Return GetFunction01("harmonic", x1)
    End Function




    Shared Function ei(x1 As Object) As Object
      Return GetFunction01("ei", x1)
    End Function


    Shared Function e1(x1 As Object) As Object
      Return GetFunction01("e1", x1)
    End Function


    Shared Function li(x1 As Object) As Object
      Return GetFunction01("li", x1)
    End Function


    Shared Function ci(x1 As Object) As Object
      Return GetFunction01("ci", x1)
    End Function


    Shared Function si(x1 As Object) As Object
      Return GetFunction01("si", x1)
    End Function


    Shared Function chi(x1 As Object) As Object
      Return GetFunction01("chi", x1)
    End Function


    Shared Function shi(x1 As Object) As Object
      Return GetFunction01("shi", x1)
    End Function


    Shared Function erf(x1 As Object) As Object
      Return GetFunction01("erf", x1)
    End Function


    Shared Function erfc(x1 As Object) As Object
      Return GetFunction01("erfc", x1)
    End Function


    Shared Function erfi(x1 As Object) As Object
      Return GetFunction01("erfi", x1)
    End Function


    Shared Function erfinv(x1 As Object) As Object
      Return GetFunction01("erfinv", x1)
    End Function


    Shared Function fresnels(x1 As Object) As Object
      Return GetFunction01("fresnels", x1)
    End Function


    Shared Function fresnelc(x1 As Object) As Object
      Return GetFunction01("fresnelc", x1)
    End Function




    Shared Function j0(x1 As Object) As Object
      Return GetFunction01("j0", x1)
    End Function


    Shared Function j1(x1 As Object) As Object
      Return GetFunction01("j1", x1)
    End Function




    Shared Function airyai(x1 As Object) As Object
      Return GetFunction01("airyai", x1)
    End Function


    Shared Function airybi(x1 As Object) As Object
      Return GetFunction01("airybi", x1)
    End Function


    Shared Function airyaizero(x1 As Object) As Object
      Return GetFunction01("airyaizero", x1)
    End Function


    Shared Function airybizero(x1 As Object) As Object
      Return GetFunction01("airybizero", x1)
    End Function



    Shared Function scorergi(x1 As Object) As Object
      Return GetFunction01("scorergi", x1)
    End Function


    Shared Function scorerhi(x1 As Object) As Object
      Return GetFunction01("scorerhi", x1)
    End Function



    Shared Function qfrom(x1 As Object) As Object
      Return GetFunction01("qfrom", x1)
    End Function


    Shared Function qbarfrom(x1 As Object) As Object
      Return GetFunction01("qbarfrom", x1)
    End Function


    Shared Function mfrom(x1 As Object) As Object
      Return GetFunction01("mfrom", x1)
    End Function


    Shared Function kfrom(x1 As Object) As Object
      Return GetFunction01("kfrom", x1)
    End Function


    Shared Function taufrom(x1 As Object) As Object
      Return GetFunction01("taufrom", x1)
    End Function


    Shared Function ellipk(x1 As Object) As Object
      Return GetFunction01("ellipk", x1)
    End Function



    Shared Function kleinj(x1 As Object) As Object
      Return GetFunction01("kleinj", x1)
    End Function




    Shared Function zeta(x1 As Object) As Object
      Return GetFunction01("zeta", x1)
    End Function


    Shared Function altzeta(x1 As Object) As Object
      Return GetFunction01("altzeta", x1)
    End Function


    Shared Function zetazero(x1 As Object) As Object
      Return GetFunction01("zetazero", x1)
    End Function


    Shared Function nzeros(x1 As Object) As Object
      Return GetFunction01("nzeros", x1)
    End Function


    Shared Function siegelz(x1 As Object) As Object
      Return GetFunction01("siegelz", x1)
    End Function


    Shared Function siegeltheta(x1 As Object) As Object
      Return GetFunction01("siegeltheta", x1)
    End Function


    Shared Function grampoint(x1 As Object) As Object
      Return GetFunction01("grampoint", x1)
    End Function


    Shared Function backlunds(x1 As Object) As Object
      Return GetFunction01("backlunds", x1)
    End Function



    Shared Function primezeta(x1 As Object) As Object
      Return GetFunction01("primezeta", x1)
    End Function


    Shared Function secondzeta(x1 As Object) As Object
      Return GetFunction01("secondzeta", x1)
    End Function



    Shared Function fibonacci(x1 As Object) As Object
      Return GetFunction01("fibonacci", x1)
    End Function


    Shared Function fib(x1 As Object) As Object
      Return GetFunction01("fib", x1)
    End Function


    Shared Function bernoulli(x1 As Object) As Object
      Return GetFunction01("bernoulli", x1)
    End Function


    Shared Function bernfrac(x1 As Object) As Object
      Return GetFunction01("bernfrac", x1)
    End Function


    Shared Function eulernum(x1 As Object) As Object
      Return GetFunction01("eulernum", x1)
    End Function



    Shared Function primepi(x1 As Object) As Object
      Return GetFunction01("primepi", x1)
    End Function


    Shared Function primepi2(x1 As Object) As Object
      Return GetFunction01("primepi2", x1)
    End Function


    Shared Function riemannr(x1 As Object) As Object
      Return GetFunction01("riemannr", x1)
    End Function


    Shared Function mangoldt(x1 As Object) As Object
      Return GetFunction01("mangoldt", x1)
    End Function



    Shared Function identify(x1 As Object) As Object
      Return GetFunction01("identify", x1)
    End Function


    Shared Function findpoly(x1 As Object) As Object
      Return GetFunction01("findpoly", x1)
    End Function


    Shared Function richardson(x1 As Object) As Object
      Return GetFunction01("richardson", x1)
    End Function


    Shared Function shanks(x1 As Object) As Object
      Return GetFunction01("shanks", x1)
    End Function


    Shared Function diffs_prod(x1 As Object) As Object
      Return GetFunction01("diffs_prod", x1)
    End Function


    Shared Function diffs_exp(x1 As Object) As Object
      Return GetFunction01("diffs_exp", x1)
    End Function



    Shared Function svd_r(x1 As Object) As Object
      Return GetFunction01("svd_r", x1)
    End Function

    Shared Function svd_c(x1 As Object) As Object
      Return GetFunction01("svd_c", x1)
    End Function

    Shared Function svd(x1 As Object) As Object
      Return GetFunction01("svd", x1)
    End Function


    Shared Function hessenberg(x1 As Object) As Object
      Return GetFunction01("hessenberg", x1)
    End Function

    Shared Function schur(x1 As Object) As Object
      Return GetFunction01("schur", x1)
    End Function


    Shared Function eig(x1 As Object) As Object
      Return GetFunction01("eig", x1)
    End Function

    Shared Function eigsy(x1 As Object) As Object
      Return GetFunction01("eigsy", x1)
    End Function

    Shared Function eighe(x1 As Object) As Object
      Return GetFunction01("eighe", x1)
    End Function

    Shared Function eigh(x1 As Object) As Object
      Return GetFunction01("eigh", x1)
    End Function


    Shared Function expm(x1 As Object) As Object
      Return GetFunction01("expm", x1)
    End Function

    Shared Function sqrtm(x1 As Object) As Object
      Return GetFunction01("sqrtm", x1)
    End Function

    Shared Function logm(x1 As Object) As Object
      Return GetFunction01("logm", x1)
    End Function

    Shared Function sinm(x1 As Object) As Object
      Return GetFunction01("sinm", x1)
    End Function

    Shared Function cosm(x1 As Object) As Object
      Return GetFunction01("cosm", x1)
    End Function




    Private Shared Function GetFunction02StrArgs(FunctionEnum As String, n1 As Object, n2 As Object, StrArgs As String) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function



    Shared Function GetFunction02Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = GetMp().GetDps()
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function


    Shared Function findroot(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("findroot", x1, x2, kwargs)
    End Function


    Shared Function quad(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("quad", x1, x2, kwargs)
    End Function



    Shared Function nsum(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("nsum", x1, x2, kwargs)
    End Function


    Shared Function GetFunction03Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = GetMp().GetDps()
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction03Kwargs(dps, FunctionEnum, n1, n2, n3, StrArgs)
    End Function



    Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("quad2d", x1, x2, x3, kwargs)
    End Function



    Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("nsum2d", x1, x2, x3, kwargs)
    End Function



    Shared Function GetFunction04Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = GetMp().GetDps()
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction04Kwargs(dps, FunctionEnum, n1, n2, n3, n4, StrArgs)
    End Function



    Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("quad3d", x1, x2, x3, x4, kwargs)
    End Function



    Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("nsum3d", x1, x2, x3, x4, kwargs)
    End Function




    Shared Function GetFunction02F(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, n1, n2))
    End Function



    Shared Function unitvector(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("unitvector", x1, x2)
    End Function


    Shared Function powm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("powm", x1, x2)
    End Function


    Shared Function lu_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("lu_solve", x1, x2)
    End Function



    Shared Function qr_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("qr_solve", x1, x2)
    End Function



    Shared Function cholesky_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("cholesky_solve", x1, x2)
    End Function




    Shared Function norm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("norm", x1, x2)
    End Function

    Shared Function mnorm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("mnorm", x1, x2)
    End Function



    '	Shared Function quad(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("quad", x1, x2)
    '	End Function
    '	
    '	
    '	Shared Function nsum(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("nsum", x1, x2)
    '	End Function


    Shared Function sumem(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumem", x1, x2)
    End Function

    Shared Function sumap(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumap", x1, x2)
    End Function



    Shared Function nprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("nprod", x1, x2)
    End Function


    Shared Function limit(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("limit", x1, x2)
    End Function


    Shared Function diff(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diff", x1, x2)
    End Function


    Shared Function diffs(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diffs", x1, x2)
    End Function


    Shared Function differint(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("differint", x1, x2)
    End Function



    Shared Function quadosc(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("quadosc", x1, x2)
    End Function


    Shared Function gammaprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("gammaprod", x1, x2)
    End Function


    '	Shared Function findroot(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("findroot", x1, x2)
    '	End Function


    Shared Function polyval(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("polyval", x1, x2)
    End Function




    Shared Function GetFunction02(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, o1.x1, o2.x1))
    End Function

    '	***********************************************


    Shared Function autoprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("autoprec", x1, x2)
    End Function

    Shared Function workprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workprec", x1, x2)
    End Function

    Shared Function workdps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workdps", x1, x2)
    End Function

    Shared Function extraprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extraprec", x1, x2)
    End Function

    Shared Function extradps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extradps", x1, x2)
    End Function

    Shared Function memoize(x1 As Object, x2 As Object) As Object
      Return GetFunction02("memoize", x1, x2)
    End Function

    Shared Function maxcalls(x1 As Object, x2 As Object) As Object
      Return GetFunction02("maxcalls", x1, x2)
    End Function


    Shared Function monitor(x1 As Object, x2 As Object) As Object
      Return GetFunction02("monitor", x1, x2)
    End Function

    Shared Function timing(x1 As Object, x2 As Object) As Object
      Return GetFunction02("timing", x1, x2)
    End Function

    '	***********************************************

    Shared Function fabs(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fabs", x1, x2)
    End Function

    Shared Function sign(x1 As Object, x2 As Object) As Object
      Return GetFunction02("sign", x1, x2)
    End Function

    Shared Function re(x1 As Object, x2 As Object) As Object
      Return GetFunction02("re", x1, x2)
    End Function

    Shared Function im(x1 As Object, x2 As Object) As Object
      Return GetFunction02("im", x1, x2)
    End Function

    Shared Function arg(x1 As Object, x2 As Object) As Object
      Return GetFunction02("arg", x1, x2)
    End Function

    ' same as arg
    Shared Function phase(x1 As Object, x2 As Object) As Object
      Return GetFunction02("phase", x1, x2)
    End Function


    Shared Function conj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("conj", x1, x2)
    End Function

    Shared Function polar(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polar", x1, x2)
    End Function

    Shared Function rect(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rect", x1, x2)
    End Function









    '	***********************************************

    Shared Function mpc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("mpc", x1, x2)
    End Function


    Shared Function fraction(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fraction", x1, x2)
    End Function


    Shared Function linspace(x1 As Object, x2 As Object) As Object
      Return GetFunction02("linspace", x1, x2)
    End Function


    Shared Function fadd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fadd", x1, x2)
    End Function


    Shared Function fsub(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fsub", x1, x2)
    End Function



    Shared Function fmul(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmul", x1, x2)
    End Function


    Shared Function fdiv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fdiv", x1, x2)
    End Function



    Shared Function fmod(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmod", x1, x2)
    End Function


    Shared Function almosteq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function ldexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function chop(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chop", x1, x2)
    End Function


    Shared Function hypot(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hypot", x1, x2)
    End Function


    Shared Function power(x1 As Object, x2 As Object) As Object
      Return GetFunction02("power", x1, x2)
    End Function


    Shared Function powm1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("powm1", x1, x2)
    End Function


    Shared Function lambertw_k(x1 As Object, x2 As Object) As Object
      Return GetFunction02("lambertw_k", x1, x2)
    End Function


    Shared Function agm(x1 As Object, x2 As Object) As Object
      Return GetFunction02("agm", x1, x2)
    End Function


    Shared Function binomial(x1 As Object, x2 As Object) As Object
      Return GetFunction02("binomial", x1, x2)
    End Function



    Shared Function atan2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("atan2", x1, x2)
    End Function


    Shared Function rf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rf", x1, x2)
    End Function


    Shared Function ff(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ff", x1, x2)
    End Function


    Shared Function beta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("beta", x1, x2)
    End Function


    Shared Function psi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("psi", x1, x2)
    End Function


    Shared Function polygamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polygamma", x1, x2)
    End Function


    Shared Function gammainc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("gammainc", x1, x2)
    End Function


    Shared Function expint(x1 As Object, x2 As Object) As Object
      Return GetFunction02("expint", x1, x2)
    End Function




    Shared Function besselj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselj", x1, x2)
    End Function


    Shared Function bessely(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bessely", x1, x2)
    End Function


    Shared Function besseli(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseli", x1, x2)
    End Function


    Shared Function besselk(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselk", x1, x2)
    End Function


    Shared Function besseljzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseljzero", x1, x2)
    End Function


    Shared Function besselyzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselyzero", x1, x2)
    End Function


    Shared Function hankel1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel1", x1, x2)
    End Function


    Shared Function hankel2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel2", x1, x2)
    End Function


    Shared Function ber(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ber", x1, x2)
    End Function


    Shared Function bei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bei", x1, x2)
    End Function


    Shared Function ker(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ker", x1, x2)
    End Function


    Shared Function kei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("kei", x1, x2)
    End Function




    Shared Function struveh(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struveh", x1, x2)
    End Function


    Shared Function struvel(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struvel", x1, x2)
    End Function


    Shared Function angerj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("angerj", x1, x2)
    End Function


    Shared Function webere(x1 As Object, x2 As Object) As Object
      Return GetFunction02("webere", x1, x2)
    End Function


    Shared Function airyaideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaideriv", x1, x2)
    End Function


    Shared Function airybideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybideriv", x1, x2)
    End Function


    Shared Function airyaiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaiderivzero", x1, x2)
    End Function


    Shared Function airybiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybiderivzero", x1, x2)
    End Function




    Shared Function coulombc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("coulombc", x1, x2)
    End Function


    Shared Function pcfd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfd", x1, x2)
    End Function


    Shared Function pcfu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfu", x1, x2)
    End Function


    Shared Function pcfv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfv", x1, x2)
    End Function


    Shared Function pcfw(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfw", x1, x2)
    End Function



    Shared Function legendre(x1 As Object, x2 As Object) As Object
      Return GetFunction02("legendre", x1, x2)
    End Function


    Shared Function chebyt(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyt", x1, x2)
    End Function


    Shared Function chebyu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyu", x1, x2)
    End Function


    Shared Function hermite(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hermite", x1, x2)
    End Function



    Shared Function hyp0f1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hyp0f1", x1, x2)
    End Function



    Shared Function ellipf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipf", x1, x2)
    End Function


    Shared Function ellipe(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipe", x1, x2)
    End Function


    Shared Function ellippi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellippi", x1, x2)
    End Function


    Shared Function elliprc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("elliprc", x1, x2)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function


    Shared Function hurwitz(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function

    Shared Function dirichlet(x1 As Object, x2 As Object) As Object
      Return GetFunction02("dirichlet", x1, x2)
    End Function


    Shared Function stieltjes(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stieltjes", x1, x2)
    End Function



    Shared Function polylog(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polylog", x1, x2)
    End Function


    Shared Function clsin(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clsin", x1, x2)
    End Function


    Shared Function clcos(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clcos", x1, x2)
    End Function


    Shared Function polyexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polyexp", x1, x2)
    End Function




    Shared Function bernpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bernpoly", x1, x2)
    End Function


    Shared Function eulerpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("eulerpoly", x1, x2)
    End Function


    Shared Function bell(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bell", x1, x2)
    End Function


    Shared Function stirling1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling1", x1, x2)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling2", x1, x2)
    End Function


    Shared Function cyclotomic(x1 As Object, x2 As Object) As Object
      Return GetFunction02("cyclotomic", x1, x2)
    End Function



    Shared Function qgamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qgamma", x1, x2)
    End Function


    Shared Function qfac(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qfac", x1, x2)
    End Function


    Shared Function ﬁndpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ﬁndpoly", x1, x2)
    End Function


    Shared Function pslq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pslq", x1, x2)
    End Function







    Shared Function GetFunction03F(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3)
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
    End Function


    Shared Function eig_sort(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("eig_sort", x1, x2, x3)
    End Function


    Shared Function diff(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("diff", x1, x2, x3)
    End Function


    Shared Function odefun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("odefun", x1, x2, x3)
    End Function


    Shared Function taylor(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("taylor", x1, x2, x3)
    End Function

    Shared Function pade(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("pade", x1, x2, x3)
    End Function

    Shared Function chebyfit(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("chebyfit", x1, x2, x3)
    End Function

    Shared Function fourier(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourier", x1, x2, x3)
    End Function

    Shared Function fourierval(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourierval", x1, x2, x3)
    End Function

    '	*************************



    '	Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("quad2d", x1, x2, x3)
    '	End Function
    '
    '	
    '	Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("nsum2d", x1, x2, x3)
    '	End Function



    Shared Function GetFunction03(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, o1.x1, o2.x1, o3.x1))
    End Function


    Shared Function root(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("root", x1, x2, x3)
    End Function

    Shared Function nthroot(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("nthroot", x1, x2, x3)
    End Function


    Shared Function hypercomb(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hypercomb", x1, x2, x3)
    End Function


    Shared Function betainc(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("betainc", x1, x2, x3)
    End Function


    Shared Function npdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("npdf", x1, x2, x3)
    End Function


    Shared Function ncdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ncdf", x1, x2, x3)
    End Function


    Shared Function besseljderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljderiv", x1, x2, x3)
    End Function


    Shared Function besselyderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyderiv", x1, x2, x3)
    End Function


    Shared Function besselideriv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselideriv", x1, x2, x3)
    End Function


    Shared Function besselkderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselkderiv", x1, x2, x3)
    End Function


    Shared Function besseljzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljzeroderiv", x1, x2, x3)
    End Function


    Shared Function besselyzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyzeroderiv", x1, x2, x3)
    End Function



    Shared Function lommels1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels1", x1, x2, x3)
    End Function


    Shared Function lommels2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels2", x1, x2, x3)
    End Function


    Shared Function coulombf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombf", x1, x2, x3)
    End Function


    Shared Function coulombg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombg", x1, x2, x3)
    End Function


    Shared Function hyperu(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyperu", x1, x2, x3)
    End Function


    Shared Function whitm(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitm", x1, x2, x3)
    End Function


    Shared Function whitw(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitw", x1, x2, x3)
    End Function



    Shared Function legenp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenp", x1, x2, x3)
    End Function


    Shared Function legenq(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenq", x1, x2, x3)
    End Function


    Shared Function gegenbauer(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("gegenbauer", x1, x2, x3)
    End Function


    Shared Function laguerre(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("laguerre", x1, x2, x3)
    End Function



    Shared Function hyp1f1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp1f1", x1, x2, x3)
    End Function


    Shared Function hyp2f0(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp2f0", x1, x2, x3)
    End Function


    Shared Function hyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyper", x1, x2, x3)
    End Function


    Shared Function bihyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("bihyper", x1, x2, x3)
    End Function



    Shared Function ellippi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellippi", x1, x2, x3)
    End Function


    Shared Function elliprf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprf", x1, x2, x3)
    End Function


    Shared Function elliprd(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprd", x1, x2, x3)
    End Function


    Shared Function elliprg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprg", x1, x2, x3)
    End Function



    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("jtheta", x1, x2, x3)
    End Function


    Shared Function ellipfun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellipfun", x1, x2, x3)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("zeta", x1, x2, x3)
    End Function


    Shared Function dirichlet(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("dirichlet", x1, x2, x3)
    End Function


    Shared Function lerchphi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lerchphi", x1, x2, x3)
    End Function



    Shared Function stirling1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling1", x1, x2, x3)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling2", x1, x2, x3)
    End Function


    Shared Function qp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("qp", x1, x2, x3)
    End Function








    Shared Function GetFunction04(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction04(dps, FunctionEnum, n1, n2, n3, n4)
      '        Return CNum(GetMp().GetFunction04(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1))
    End Function



    '	Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("quad3d", x1, x2, x3, x4)
    '	End Function
    '	
    '		
    '	Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("nsum3d", x1, x2, x3, x4)
    '	End Function


    Shared Function jacobi(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jacobi", x1, x2, x3, x4)
    End Function


    Shared Function spherharm(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("spherharm", x1, x2, x3, x4)
    End Function


    Shared Function hyp1f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp1f2", x1, x2, x3, x4)
    End Function


    Shared Function hyp2f1(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp2f1", x1, x2, x3, x4)
    End Function


    Shared Function meijerg(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("meijerg", x1, x2, x3, x4)
    End Function


    Shared Function hyper2d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyper2d", x1, x2, x3, x4)
    End Function


    Shared Function elliprj(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("elliprj", x1, x2, x3, x4)
    End Function


    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jtheta", x1, x2, x3, x4)
    End Function


    Shared Function qhyper(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("qhyper", x1, x2, x3, x4)
    End Function





    Shared Function GetFunction05(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction05(dps, FunctionEnum, n1, n2, n3, n4, n5))
      '        Return CNum(GetMp().GetFunction05(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1))
    End Function



    Shared Function hyp2f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object) As Object
      Return GetFunction05("hyp2f2", x1, x2, x3, x4, x5)
    End Function






    Shared Function GetFunction06(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction06(dps, FunctionEnum, n1, n2, n3, n4, n5, n6))
      '        Return CNum(GetMp().GetFunction06(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1))
    End Function



    Shared Function hyp2f3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp2f3", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function hyp3f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp3f2", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf1(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf1", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf4(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf4", x1, x2, x3, x4, x5, x6)
    End Function



    Shared Function GetFunction07(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object, n7 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      '	    Dim o7 As Object = CNum(n7)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction07(dps, FunctionEnum, n1, n2, n3, n4, n5, n6, n7))
      '        Return CNum(GetMp().GetFunction07(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1, o7.x1))
    End Function



    Shared Function appellf2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf4", x1, x2, x3, x4, x5, x6, x7)
    End Function


    Shared Function appellf3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf3", x1, x2, x3, x4, x5, x6, x7)
    End Function









  End Class



  Public Class fp

    Shared FloatingPointType_ As Integer = 3

    Shared Function GetMp() As FpMathClass
      Static PyInstance As FpMathClass = Nothing
      If IsNothing(PyInstance) Then
        Try
          PyInstance = New FpMathClass
        Catch ex As Exception
          '				ReportException(ex)
        End Try
      End If
      Return PyInstance
    End Function


    '    Dim mp2 As New MpMathClass    

    Shared Sub New()
      Dim s As String = GetMp().PiString()
      '	Console.WriteLine(s)
    End Sub



    '  Public Function CNum(x As String) As mpNum
    Shared Function CNum(x As String) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As Object) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As mpNum) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


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


    '  	Shared Sub nprint(x1 As Object) 
    '	    GetMp().nprint2(x1)
    '	End Sub


    Shared Function GetFunction00(FunctionEnum As String) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction00(dps, FunctionEnum)
      '        Return CNum(GetMp().GetFunction00(dps, FunctionEnum))
    End Function



    Shared Function pi() As Object
      Return GetFunction00("pi")
    End Function


    Shared Function degree() As Object
      Return GetFunction00("degree")
    End Function


    Shared Function e() As Object
      Return GetFunction00("e")
    End Function


    Shared Function phi() As Object
      Return GetFunction00("phi")
    End Function


    Shared Function euler() As Object
      Return GetFunction00("euler")
    End Function


    Shared Function catalan() As Object
      Return GetFunction00("catalan")
    End Function


    Shared Function apery() As Object
      Return GetFunction00("apery")
    End Function


    Shared Function khinchin() As Object
      Return GetFunction00("khinchin")
    End Function


    Shared Function glaisher() As Object
      Return GetFunction00("glaisher")
    End Function


    Shared Function mertens() As Object
      Return GetFunction00("mertens")
    End Function


    Shared Function twinprime() As Object
      Return GetFunction00("twinprime")
    End Function


    Shared Function j() As Object
      Return GetFunction00("j")
    End Function


    Shared Function quadgl() As Object
      Return GetFunction00("quadgl")
    End Function


    Shared Function quadts() As Object
      Return GetFunction00("quadts")
    End Function

    Shared Function inf() As Object
      Return GetFunction00("inf")
    End Function


    Shared Function nan() As Object
      Return GetFunction00("nan")
    End Function


    Shared Function rand() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function eps() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function levin() As Object
      Return GetFunction00("levin")
    End Function


    Shared Function cohen_alt() As Object
      Return GetFunction00("cohen_alt")
    End Function




    Shared Function GetFunction01F(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, n1))
    End Function


    Shared Function GetFunction01List(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
    End Function


    Shared Function arange(x1 As Object) As Object
      Return GetFunction01List("arange", x1)
    End Function

    Shared Function matrix(x1 As Object) As Object
      Return GetFunction01List("matrix", x1)
    End Function

    Shared Function eye(x1 As Object) As Object
      Return GetFunction01List("eye", x1)
    End Function


    Shared Function diag(x1 As Object) As Object
      Return GetFunction01List("diag", x1)
    End Function



    Shared Function zeros(x1 As Object) As Object
      Return GetFunction01List("zeros", x1)
    End Function


    Shared Function ones(x1 As Object) As Object
      Return GetFunction01List("ones", x1)
    End Function


    Shared Function hilbert(x1 As Object) As Object
      Return GetFunction01List("hilbert", x1)
    End Function


    Shared Function randmatrix(x1 As Object) As Object
      Return GetFunction01List("randmatrix", x1)
    End Function


    Shared Function lu(x1 As Object) As Object
      Return GetFunction01List("lu", x1)
    End Function

    Shared Function qr(x1 As Object) As Object
      Return GetFunction01List("qr", x1)
    End Function

    Shared Function cholesky(x1 As Object) As Object
      Return GetFunction01List("cholesky", x1)
    End Function



    Shared Function det(x1 As Object) As Object
      Return GetFunction01List("det", x1)
    End Function

    Shared Function cond(x1 As Object) As Object
      Return GetFunction01List("cond", x1)
    End Function

    Shared Function inverse(x1 As Object) As Object
      Return GetFunction01List("inverse", x1)
    End Function



    Shared Function polyroots(x1 As Object) As Object
      Return GetFunction01List("polyroots", x1)
    End Function


    Shared Function GetFunction01(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)

      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, o1.x1))
    End Function


    Shared Function mpf(x1 As Object) As Object
      Return GetFunction01("mpf", x1)
    End Function


    Shared Function mpc(x1 As Object) As Object
      Return GetFunction01("mpc", x1)
    End Function

    Shared Function convert(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function mpmathify(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function nstr(x1 As Object) As Object
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************

    Shared Function fneg(x1 As Object) As Object
      Return GetFunction01("fneg", x1)
    End Function


    Shared Function fsum(x1 As Object) As Object
      Return GetFunction01("fsum", x1)
    End Function


    Shared Function fprod(x1 As Object) As Object
      Return GetFunction01("fprod", x1)
    End Function


    Shared Function fdot(x1 As Object) As Object
      Return GetFunction01("fdot", x1)
    End Function


    Shared Function isinf(x1 As Object) As Object
      Return GetFunction01("isinf", x1)
    End Function


    Shared Function isnan(x1 As Object) As Object
      Return GetFunction01("isnan", x1)
    End Function


    Shared Function isnormal(x1 As Object) As Object
      Return GetFunction01("isnormal", x1)
    End Function


    Shared Function isfinite(x1 As Object) As Object
      Return GetFunction01("isfinite", x1)
    End Function


    Shared Function isint(x1 As Object) As Object
      Return GetFunction01("isint", x1)
    End Function


    Shared Function frexp(x1 As Object) As Object
      Return GetFunction01("frexp", x1)
    End Function


    Shared Function mag(x1 As Object) As Object
      Return GetFunction01("mag", x1)
    End Function


    Shared Function nint_distance(x1 As Object) As Object
      Return GetFunction01("nint_distance", x1)
    End Function

    '	*********************************************

    Shared Function floor(x1 As Object) As Object
      Return GetFunction01("floor", x1)
    End Function


    Shared Function ceil(x1 As Object) As Object
      Return GetFunction01("ceil", x1)
    End Function


    Shared Function nint(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    Shared Function frac(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    '	*********************************************

    Shared Function chop(x1 As Object) As Object
      Return GetFunction01("chop", x1)
    End Function



    Shared Function sqrt(x1 As Object) As Object
      Return GetFunction01("sqrt", x1)
    End Function


    Shared Function cbrt(x1 As Object) As Object
      Return GetFunction01("cbrt", x1)
    End Function

    Shared Function unitroots(x1 As Object) As Object
      Return GetFunction01("unitroots", x1)
    End Function

    Shared Function exp(x1 As Object) As Object
      Return GetFunction01("exp", x1)
    End Function

    Shared Function expj(x1 As Object) As Object
      Return GetFunction01("expj", x1)
    End Function

    Shared Function expjpi(x1 As Object) As Object
      Return GetFunction01("expjpi", x1)
    End Function

    Shared Function expm1(x1 As Object) As Object
      Return GetFunction01("expm1", x1)
    End Function

    Shared Function log(x1 As Object) As Object
      Return GetFunction01("log", x1)
    End Function

    Shared Function ln(x1 As Object) As Object
      Return GetFunction01("ln", x1)
    End Function

    Shared Function ln10(x1 As Object) As Object
      Return GetFunction01("ln10", x1)
    End Function

    Shared Function ln2(x1 As Object) As Object
      Return GetFunction01("ln2", x1)
    End Function


    Shared Function log10(x1 As Object) As Object
      Return GetFunction01("log10", x1)
    End Function

    Shared Function log2(x1 As Object) As Object
      Return GetFunction01("log2", x1)
    End Function

    Shared Function lambertw(x1 As Object) As Object
      Return GetFunction01("lambertw", x1)
    End Function



    Shared Function degrees(x1 As Object) As Object
      Return GetFunction01("degrees", x1)
    End Function

    Shared Function radians(x1 As Object) As Object
      Return GetFunction01("radians", x1)
    End Function

    Shared Function cos(x1 As Object) As Object
      Return GetFunction01("cos", x1)
    End Function

    Shared Function sin(x1 As Object) As Object
      Return GetFunction01("sin", x1)
    End Function

    Shared Function cos_sin(x1 As Object) As Object
      Return GetFunction01("cos_sin", x1)
    End Function


    Shared Function tan(x1 As Object) As Object
      Return GetFunction01("tan", x1)
    End Function

    Shared Function sec(x1 As Object) As Object
      Return GetFunction01("sec", x1)
    End Function

    Shared Function csc(x1 As Object) As Object
      Return GetFunction01("csc", x1)
    End Function

    Shared Function cot(x1 As Object) As Object
      Return GetFunction01("cot", x1)
    End Function

    Shared Function cospi(x1 As Object) As Object
      Return GetFunction01("cospi", x1)
    End Function

    Shared Function sinpi(x1 As Object) As Object
      Return GetFunction01("sinpi", x1)
    End Function


    Shared Function cospi_sinpi(x1 As Object) As Object
      Return GetFunction01("cospi_sinpi", x1)
    End Function


    Shared Function acos(x1 As Object) As Object
      Return GetFunction01("acos", x1)
    End Function

    Shared Function asin(x1 As Object) As Object
      Return GetFunction01("asin", x1)
    End Function

    Shared Function atan(x1 As Object) As Object
      Return GetFunction01("atan", x1)
    End Function

    Shared Function asec(x1 As Object) As Object
      Return GetFunction01("asec", x1)
    End Function

    Shared Function acsc(x1 As Object) As Object
      Return GetFunction01("acsc", x1)
    End Function

    Shared Function acot(x1 As Object) As Object
      Return GetFunction01("acot", x1)
    End Function



    Shared Function sinc(x1 As Object) As Object
      Return GetFunction01("sinc", x1)
    End Function

    Shared Function sincpi(x1 As Object) As Object
      Return GetFunction01("sincpi", x1)
    End Function



    Shared Function cosh(x1 As Object) As Object
      Return GetFunction01("cosh", x1)
    End Function


    Shared Function sinh(x1 As Object) As Object
      Return GetFunction01("sinh", x1)
    End Function


    Shared Function tanh(x1 As Object) As Object
      Return GetFunction01("tanh", x1)
    End Function


    Shared Function sech(x1 As Object) As Object
      Return GetFunction01("sech", x1)
    End Function


    Shared Function csch(x1 As Object) As Object
      Return GetFunction01("csch", x1)
    End Function


    Shared Function coth(x1 As Object) As Object
      Return GetFunction01("coth", x1)
    End Function




    Shared Function acosh(x1 As Object) As Object
      Return GetFunction01("acosh", x1)
    End Function


    Shared Function asinh(x1 As Object) As Object
      Return GetFunction01("asinh", x1)
    End Function


    Shared Function atanh(x1 As Object) As Object
      Return GetFunction01("atanh", x1)
    End Function


    Shared Function asech(x1 As Object) As Object
      Return GetFunction01("asech", x1)
    End Function


    Shared Function acsch(x1 As Object) As Object
      Return GetFunction01("acsch", x1)
    End Function


    Shared Function acoth(x1 As Object) As Object
      Return GetFunction01("acoth", x1)
    End Function



    Shared Function fac(x1 As Object) As Object
      Return GetFunction01("fac", x1)
    End Function


    Shared Function factorial(x1 As Object) As Object
      Return GetFunction01("factorial", x1)
    End Function


    Shared Function fac2(x1 As Object) As Object
      Return GetFunction01("fac2", x1)
    End Function


    Shared Function gamma(x1 As Object) As Object
      Return GetFunction01("gamma", x1)
    End Function


    Shared Function rgamma(x1 As Object) As Object
      Return GetFunction01("rgamma", x1)
    End Function


    Shared Function loggamma(x1 As Object) As Object
      Return GetFunction01("loggamma", x1)
    End Function


    Shared Function superfac(x1 As Object) As Object
      Return GetFunction01("superfac", x1)
    End Function


    Shared Function hyperfac(x1 As Object) As Object
      Return GetFunction01("hyperfac", x1)
    End Function

    Shared Function barnesg(x1 As Object) As Object
      Return GetFunction01("barnesg", x1)
    End Function


    Shared Function digamma(x1 As Object) As Object
      Return GetFunction01("digamma", x1)
    End Function


    Shared Function harmonic(x1 As Object) As Object
      Return GetFunction01("harmonic", x1)
    End Function




    Shared Function ei(x1 As Object) As Object
      Return GetFunction01("ei", x1)
    End Function


    Shared Function e1(x1 As Object) As Object
      Return GetFunction01("e1", x1)
    End Function


    Shared Function li(x1 As Object) As Object
      Return GetFunction01("li", x1)
    End Function


    Shared Function ci(x1 As Object) As Object
      Return GetFunction01("ci", x1)
    End Function


    Shared Function si(x1 As Object) As Object
      Return GetFunction01("si", x1)
    End Function


    Shared Function chi(x1 As Object) As Object
      Return GetFunction01("chi", x1)
    End Function


    Shared Function shi(x1 As Object) As Object
      Return GetFunction01("shi", x1)
    End Function


    Shared Function erf(x1 As Object) As Object
      Return GetFunction01("erf", x1)
    End Function


    Shared Function erfc(x1 As Object) As Object
      Return GetFunction01("erfc", x1)
    End Function


    Shared Function erfi(x1 As Object) As Object
      Return GetFunction01("erfi", x1)
    End Function


    Shared Function erfinv(x1 As Object) As Object
      Return GetFunction01("erfinv", x1)
    End Function


    Shared Function fresnels(x1 As Object) As Object
      Return GetFunction01("fresnels", x1)
    End Function


    Shared Function fresnelc(x1 As Object) As Object
      Return GetFunction01("fresnelc", x1)
    End Function




    Shared Function j0(x1 As Object) As Object
      Return GetFunction01("j0", x1)
    End Function


    Shared Function j1(x1 As Object) As Object
      Return GetFunction01("j1", x1)
    End Function




    Shared Function airyai(x1 As Object) As Object
      Return GetFunction01("airyai", x1)
    End Function


    Shared Function airybi(x1 As Object) As Object
      Return GetFunction01("airybi", x1)
    End Function


    Shared Function airyaizero(x1 As Object) As Object
      Return GetFunction01("airyaizero", x1)
    End Function


    Shared Function airybizero(x1 As Object) As Object
      Return GetFunction01("airybizero", x1)
    End Function



    Shared Function scorergi(x1 As Object) As Object
      Return GetFunction01("scorergi", x1)
    End Function


    Shared Function scorerhi(x1 As Object) As Object
      Return GetFunction01("scorerhi", x1)
    End Function



    Shared Function qfrom(x1 As Object) As Object
      Return GetFunction01("qfrom", x1)
    End Function


    Shared Function qbarfrom(x1 As Object) As Object
      Return GetFunction01("qbarfrom", x1)
    End Function


    Shared Function mfrom(x1 As Object) As Object
      Return GetFunction01("mfrom", x1)
    End Function


    Shared Function kfrom(x1 As Object) As Object
      Return GetFunction01("kfrom", x1)
    End Function


    Shared Function taufrom(x1 As Object) As Object
      Return GetFunction01("taufrom", x1)
    End Function


    Shared Function ellipk(x1 As Object) As Object
      Return GetFunction01("ellipk", x1)
    End Function



    Shared Function kleinj(x1 As Object) As Object
      Return GetFunction01("kleinj", x1)
    End Function




    Shared Function zeta(x1 As Object) As Object
      Return GetFunction01("zeta", x1)
    End Function


    Shared Function altzeta(x1 As Object) As Object
      Return GetFunction01("altzeta", x1)
    End Function


    Shared Function zetazero(x1 As Object) As Object
      Return GetFunction01("zetazero", x1)
    End Function


    Shared Function nzeros(x1 As Object) As Object
      Return GetFunction01("nzeros", x1)
    End Function


    Shared Function siegelz(x1 As Object) As Object
      Return GetFunction01("siegelz", x1)
    End Function


    Shared Function siegeltheta(x1 As Object) As Object
      Return GetFunction01("siegeltheta", x1)
    End Function


    Shared Function grampoint(x1 As Object) As Object
      Return GetFunction01("grampoint", x1)
    End Function


    Shared Function backlunds(x1 As Object) As Object
      Return GetFunction01("backlunds", x1)
    End Function



    Shared Function primezeta(x1 As Object) As Object
      Return GetFunction01("primezeta", x1)
    End Function


    Shared Function secondzeta(x1 As Object) As Object
      Return GetFunction01("secondzeta", x1)
    End Function



    Shared Function fibonacci(x1 As Object) As Object
      Return GetFunction01("fibonacci", x1)
    End Function


    Shared Function fib(x1 As Object) As Object
      Return GetFunction01("fib", x1)
    End Function


    Shared Function bernoulli(x1 As Object) As Object
      Return GetFunction01("bernoulli", x1)
    End Function


    Shared Function bernfrac(x1 As Object) As Object
      Return GetFunction01("bernfrac", x1)
    End Function


    Shared Function eulernum(x1 As Object) As Object
      Return GetFunction01("eulernum", x1)
    End Function



    Shared Function primepi(x1 As Object) As Object
      Return GetFunction01("primepi", x1)
    End Function


    Shared Function primepi2(x1 As Object) As Object
      Return GetFunction01("primepi2", x1)
    End Function


    Shared Function riemannr(x1 As Object) As Object
      Return GetFunction01("riemannr", x1)
    End Function


    Shared Function mangoldt(x1 As Object) As Object
      Return GetFunction01("mangoldt", x1)
    End Function



    Shared Function identify(x1 As Object) As Object
      Return GetFunction01("identify", x1)
    End Function


    Shared Function findpoly(x1 As Object) As Object
      Return GetFunction01("findpoly", x1)
    End Function


    Shared Function richardson(x1 As Object) As Object
      Return GetFunction01("richardson", x1)
    End Function


    Shared Function shanks(x1 As Object) As Object
      Return GetFunction01("shanks", x1)
    End Function


    Shared Function diffs_prod(x1 As Object) As Object
      Return GetFunction01("diffs_prod", x1)
    End Function


    Shared Function diffs_exp(x1 As Object) As Object
      Return GetFunction01("diffs_exp", x1)
    End Function



    Shared Function svd_r(x1 As Object) As Object
      Return GetFunction01("svd_r", x1)
    End Function

    Shared Function svd_c(x1 As Object) As Object
      Return GetFunction01("svd_c", x1)
    End Function

    Shared Function svd(x1 As Object) As Object
      Return GetFunction01("svd", x1)
    End Function


    Shared Function hessenberg(x1 As Object) As Object
      Return GetFunction01("hessenberg", x1)
    End Function

    Shared Function schur(x1 As Object) As Object
      Return GetFunction01("schur", x1)
    End Function


    Shared Function eig(x1 As Object) As Object
      Return GetFunction01("eig", x1)
    End Function

    Shared Function eigsy(x1 As Object) As Object
      Return GetFunction01("eigsy", x1)
    End Function

    Shared Function eighe(x1 As Object) As Object
      Return GetFunction01("eighe", x1)
    End Function

    Shared Function eigh(x1 As Object) As Object
      Return GetFunction01("eigh", x1)
    End Function


    Shared Function expm(x1 As Object) As Object
      Return GetFunction01("expm", x1)
    End Function

    Shared Function sqrtm(x1 As Object) As Object
      Return GetFunction01("sqrtm", x1)
    End Function

    Shared Function logm(x1 As Object) As Object
      Return GetFunction01("logm", x1)
    End Function

    Shared Function sinm(x1 As Object) As Object
      Return GetFunction01("sinm", x1)
    End Function

    Shared Function cosm(x1 As Object) As Object
      Return GetFunction01("cosm", x1)
    End Function




    Private Shared Function GetFunction02StrArgs(FunctionEnum As String, n1 As Object, n2 As Object, StrArgs As String) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function



    Shared Function GetFunction02Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function


    Shared Function findroot(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("findroot", x1, x2, kwargs)
    End Function


    Shared Function quad(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("quad", x1, x2, kwargs)
    End Function



    Shared Function nsum(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("nsum", x1, x2, kwargs)
    End Function


    Shared Function GetFunction03Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = GetMp().GetDps()
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction03Kwargs(dps, FunctionEnum, n1, n2, n3, StrArgs)
    End Function



    Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("quad2d", x1, x2, x3, kwargs)
    End Function



    Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("nsum2d", x1, x2, x3, kwargs)
    End Function



    Shared Function GetFunction04Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction04Kwargs(dps, FunctionEnum, n1, n2, n3, n4, StrArgs)
    End Function



    Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("quad3d", x1, x2, x3, x4, kwargs)
    End Function



    Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("nsum3d", x1, x2, x3, x4, kwargs)
    End Function




    Shared Function GetFunction02F(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, n1, n2))
    End Function



    Shared Function unitvector(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("unitvector", x1, x2)
    End Function


    Shared Function powm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("powm", x1, x2)
    End Function


    Shared Function lu_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("lu_solve", x1, x2)
    End Function



    Shared Function qr_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("qr_solve", x1, x2)
    End Function



    Shared Function cholesky_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("cholesky_solve", x1, x2)
    End Function




    Shared Function norm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("norm", x1, x2)
    End Function

    Shared Function mnorm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("mnorm", x1, x2)
    End Function



    '	Shared Function quad(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("quad", x1, x2)
    '	End Function
    '	
    '	
    '	Shared Function nsum(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("nsum", x1, x2)
    '	End Function


    Shared Function sumem(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumem", x1, x2)
    End Function

    Shared Function sumap(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumap", x1, x2)
    End Function



    Shared Function nprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("nprod", x1, x2)
    End Function


    Shared Function limit(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("limit", x1, x2)
    End Function


    Shared Function diff(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diff", x1, x2)
    End Function


    Shared Function diffs(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diffs", x1, x2)
    End Function


    Shared Function differint(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("differint", x1, x2)
    End Function



    Shared Function quadosc(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("quadosc", x1, x2)
    End Function


    Shared Function gammaprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("gammaprod", x1, x2)
    End Function


    '	Shared Function findroot(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("findroot", x1, x2)
    '	End Function


    Shared Function polyval(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("polyval", x1, x2)
    End Function




    Shared Function GetFunction02(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, o1.x1, o2.x1))
    End Function

    '	***********************************************


    Shared Function autoprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("autoprec", x1, x2)
    End Function

    Shared Function workprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workprec", x1, x2)
    End Function

    Shared Function workdps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workdps", x1, x2)
    End Function

    Shared Function extraprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extraprec", x1, x2)
    End Function

    Shared Function extradps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extradps", x1, x2)
    End Function

    Shared Function memoize(x1 As Object, x2 As Object) As Object
      Return GetFunction02("memoize", x1, x2)
    End Function

    Shared Function maxcalls(x1 As Object, x2 As Object) As Object
      Return GetFunction02("maxcalls", x1, x2)
    End Function


    Shared Function monitor(x1 As Object, x2 As Object) As Object
      Return GetFunction02("monitor", x1, x2)
    End Function

    Shared Function timing(x1 As Object, x2 As Object) As Object
      Return GetFunction02("timing", x1, x2)
    End Function

    '	***********************************************

    Shared Function fabs(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fabs", x1, x2)
    End Function

    Shared Function sign(x1 As Object, x2 As Object) As Object
      Return GetFunction02("sign", x1, x2)
    End Function

    Shared Function re(x1 As Object, x2 As Object) As Object
      Return GetFunction02("re", x1, x2)
    End Function

    Shared Function im(x1 As Object, x2 As Object) As Object
      Return GetFunction02("im", x1, x2)
    End Function

    Shared Function arg(x1 As Object, x2 As Object) As Object
      Return GetFunction02("arg", x1, x2)
    End Function

    ' same as arg
    Shared Function phase(x1 As Object, x2 As Object) As Object
      Return GetFunction02("phase", x1, x2)
    End Function


    Shared Function conj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("conj", x1, x2)
    End Function

    Shared Function polar(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polar", x1, x2)
    End Function

    Shared Function rect(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rect", x1, x2)
    End Function









    '	***********************************************

    Shared Function mpc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("mpc", x1, x2)
    End Function


    Shared Function fraction(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fraction", x1, x2)
    End Function


    Shared Function linspace(x1 As Object, x2 As Object) As Object
      Return GetFunction02("linspace", x1, x2)
    End Function


    Shared Function fadd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fadd", x1, x2)
    End Function


    Shared Function fsub(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fsub", x1, x2)
    End Function



    Shared Function fmul(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmul", x1, x2)
    End Function


    Shared Function fdiv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fdiv", x1, x2)
    End Function



    Shared Function fmod(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmod", x1, x2)
    End Function


    Shared Function almosteq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function ldexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function chop(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chop", x1, x2)
    End Function


    Shared Function hypot(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hypot", x1, x2)
    End Function


    Shared Function power(x1 As Object, x2 As Object) As Object
      Return GetFunction02("power", x1, x2)
    End Function


    Shared Function powm1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("powm1", x1, x2)
    End Function


    Shared Function lambertw_k(x1 As Object, x2 As Object) As Object
      Return GetFunction02("lambertw_k", x1, x2)
    End Function


    Shared Function agm(x1 As Object, x2 As Object) As Object
      Return GetFunction02("agm", x1, x2)
    End Function


    Shared Function binomial(x1 As Object, x2 As Object) As Object
      Return GetFunction02("binomial", x1, x2)
    End Function



    Shared Function atan2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("atan2", x1, x2)
    End Function


    Shared Function rf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rf", x1, x2)
    End Function


    Shared Function ff(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ff", x1, x2)
    End Function


    Shared Function beta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("beta", x1, x2)
    End Function


    Shared Function psi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("psi", x1, x2)
    End Function


    Shared Function polygamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polygamma", x1, x2)
    End Function


    Shared Function gammainc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("gammainc", x1, x2)
    End Function


    Shared Function expint(x1 As Object, x2 As Object) As Object
      Return GetFunction02("expint", x1, x2)
    End Function




    Shared Function besselj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselj", x1, x2)
    End Function


    Shared Function bessely(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bessely", x1, x2)
    End Function


    Shared Function besseli(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseli", x1, x2)
    End Function


    Shared Function besselk(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselk", x1, x2)
    End Function


    Shared Function besseljzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseljzero", x1, x2)
    End Function


    Shared Function besselyzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselyzero", x1, x2)
    End Function


    Shared Function hankel1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel1", x1, x2)
    End Function


    Shared Function hankel2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel2", x1, x2)
    End Function


    Shared Function ber(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ber", x1, x2)
    End Function


    Shared Function bei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bei", x1, x2)
    End Function


    Shared Function ker(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ker", x1, x2)
    End Function


    Shared Function kei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("kei", x1, x2)
    End Function




    Shared Function struveh(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struveh", x1, x2)
    End Function


    Shared Function struvel(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struvel", x1, x2)
    End Function


    Shared Function angerj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("angerj", x1, x2)
    End Function


    Shared Function webere(x1 As Object, x2 As Object) As Object
      Return GetFunction02("webere", x1, x2)
    End Function


    Shared Function airyaideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaideriv", x1, x2)
    End Function


    Shared Function airybideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybideriv", x1, x2)
    End Function


    Shared Function airyaiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaiderivzero", x1, x2)
    End Function


    Shared Function airybiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybiderivzero", x1, x2)
    End Function




    Shared Function coulombc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("coulombc", x1, x2)
    End Function


    Shared Function pcfd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfd", x1, x2)
    End Function


    Shared Function pcfu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfu", x1, x2)
    End Function


    Shared Function pcfv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfv", x1, x2)
    End Function


    Shared Function pcfw(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfw", x1, x2)
    End Function



    Shared Function legendre(x1 As Object, x2 As Object) As Object
      Return GetFunction02("legendre", x1, x2)
    End Function


    Shared Function chebyt(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyt", x1, x2)
    End Function


    Shared Function chebyu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyu", x1, x2)
    End Function


    Shared Function hermite(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hermite", x1, x2)
    End Function



    Shared Function hyp0f1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hyp0f1", x1, x2)
    End Function



    Shared Function ellipf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipf", x1, x2)
    End Function


    Shared Function ellipe(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipe", x1, x2)
    End Function


    Shared Function ellippi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellippi", x1, x2)
    End Function


    Shared Function elliprc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("elliprc", x1, x2)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function


    Shared Function hurwitz(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function

    Shared Function dirichlet(x1 As Object, x2 As Object) As Object
      Return GetFunction02("dirichlet", x1, x2)
    End Function


    Shared Function stieltjes(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stieltjes", x1, x2)
    End Function



    Shared Function polylog(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polylog", x1, x2)
    End Function


    Shared Function clsin(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clsin", x1, x2)
    End Function


    Shared Function clcos(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clcos", x1, x2)
    End Function


    Shared Function polyexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polyexp", x1, x2)
    End Function




    Shared Function bernpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bernpoly", x1, x2)
    End Function


    Shared Function eulerpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("eulerpoly", x1, x2)
    End Function


    Shared Function bell(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bell", x1, x2)
    End Function


    Shared Function stirling1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling1", x1, x2)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling2", x1, x2)
    End Function


    Shared Function cyclotomic(x1 As Object, x2 As Object) As Object
      Return GetFunction02("cyclotomic", x1, x2)
    End Function



    Shared Function qgamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qgamma", x1, x2)
    End Function


    Shared Function qfac(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qfac", x1, x2)
    End Function


    Shared Function ﬁndpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ﬁndpoly", x1, x2)
    End Function


    Shared Function pslq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pslq", x1, x2)
    End Function







    Shared Function GetFunction03F(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3)
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
    End Function


    Shared Function eig_sort(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("eig_sort", x1, x2, x3)
    End Function


    Shared Function diff(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("diff", x1, x2, x3)
    End Function


    Shared Function odefun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("odefun", x1, x2, x3)
    End Function


    Shared Function taylor(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("taylor", x1, x2, x3)
    End Function

    Shared Function pade(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("pade", x1, x2, x3)
    End Function

    Shared Function chebyfit(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("chebyfit", x1, x2, x3)
    End Function

    Shared Function fourier(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourier", x1, x2, x3)
    End Function

    Shared Function fourierval(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourierval", x1, x2, x3)
    End Function

    '	*************************



    '	Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("quad2d", x1, x2, x3)
    '	End Function
    '
    '	
    '	Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("nsum2d", x1, x2, x3)
    '	End Function



    Shared Function GetFunction03(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, o1.x1, o2.x1, o3.x1))
    End Function


    Shared Function root(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("root", x1, x2, x3)
    End Function

    Shared Function nthroot(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("nthroot", x1, x2, x3)
    End Function


    Shared Function hypercomb(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hypercomb", x1, x2, x3)
    End Function


    Shared Function betainc(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("betainc", x1, x2, x3)
    End Function


    Shared Function npdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("npdf", x1, x2, x3)
    End Function


    Shared Function ncdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ncdf", x1, x2, x3)
    End Function


    Shared Function besseljderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljderiv", x1, x2, x3)
    End Function


    Shared Function besselyderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyderiv", x1, x2, x3)
    End Function


    Shared Function besselideriv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselideriv", x1, x2, x3)
    End Function


    Shared Function besselkderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselkderiv", x1, x2, x3)
    End Function


    Shared Function besseljzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljzeroderiv", x1, x2, x3)
    End Function


    Shared Function besselyzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyzeroderiv", x1, x2, x3)
    End Function



    Shared Function lommels1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels1", x1, x2, x3)
    End Function


    Shared Function lommels2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels2", x1, x2, x3)
    End Function


    Shared Function coulombf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombf", x1, x2, x3)
    End Function


    Shared Function coulombg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombg", x1, x2, x3)
    End Function


    Shared Function hyperu(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyperu", x1, x2, x3)
    End Function


    Shared Function whitm(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitm", x1, x2, x3)
    End Function


    Shared Function whitw(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitw", x1, x2, x3)
    End Function



    Shared Function legenp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenp", x1, x2, x3)
    End Function


    Shared Function legenq(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenq", x1, x2, x3)
    End Function


    Shared Function gegenbauer(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("gegenbauer", x1, x2, x3)
    End Function


    Shared Function laguerre(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("laguerre", x1, x2, x3)
    End Function



    Shared Function hyp1f1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp1f1", x1, x2, x3)
    End Function


    Shared Function hyp2f0(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp2f0", x1, x2, x3)
    End Function


    Shared Function hyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyper", x1, x2, x3)
    End Function


    Shared Function bihyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("bihyper", x1, x2, x3)
    End Function



    Shared Function ellippi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellippi", x1, x2, x3)
    End Function


    Shared Function elliprf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprf", x1, x2, x3)
    End Function


    Shared Function elliprd(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprd", x1, x2, x3)
    End Function


    Shared Function elliprg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprg", x1, x2, x3)
    End Function



    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("jtheta", x1, x2, x3)
    End Function


    Shared Function ellipfun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellipfun", x1, x2, x3)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("zeta", x1, x2, x3)
    End Function


    Shared Function dirichlet(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("dirichlet", x1, x2, x3)
    End Function


    Shared Function lerchphi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lerchphi", x1, x2, x3)
    End Function



    Shared Function stirling1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling1", x1, x2, x3)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling2", x1, x2, x3)
    End Function


    Shared Function qp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("qp", x1, x2, x3)
    End Function








    Shared Function GetFunction04(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction04(dps, FunctionEnum, n1, n2, n3, n4)
      '        Return CNum(GetMp().GetFunction04(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1))
    End Function



    '	Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("quad3d", x1, x2, x3, x4)
    '	End Function
    '	
    '		
    '	Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("nsum3d", x1, x2, x3, x4)
    '	End Function


    Shared Function jacobi(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jacobi", x1, x2, x3, x4)
    End Function


    Shared Function spherharm(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("spherharm", x1, x2, x3, x4)
    End Function


    Shared Function hyp1f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp1f2", x1, x2, x3, x4)
    End Function


    Shared Function hyp2f1(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp2f1", x1, x2, x3, x4)
    End Function


    Shared Function meijerg(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("meijerg", x1, x2, x3, x4)
    End Function


    Shared Function hyper2d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyper2d", x1, x2, x3, x4)
    End Function


    Shared Function elliprj(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("elliprj", x1, x2, x3, x4)
    End Function


    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jtheta", x1, x2, x3, x4)
    End Function


    Shared Function qhyper(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("qhyper", x1, x2, x3, x4)
    End Function





    Shared Function GetFunction05(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction05(dps, FunctionEnum, n1, n2, n3, n4, n5))
      '        Return CNum(GetMp().GetFunction05(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1))
    End Function



    Shared Function hyp2f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object) As Object
      Return GetFunction05("hyp2f2", x1, x2, x3, x4, x5)
    End Function






    Shared Function GetFunction06(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction06(dps, FunctionEnum, n1, n2, n3, n4, n5, n6))
      '        Return CNum(GetMp().GetFunction06(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1))
    End Function



    Shared Function hyp2f3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp2f3", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function hyp3f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp3f2", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf1(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf1", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf4(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf4", x1, x2, x3, x4, x5, x6)
    End Function



    Shared Function GetFunction07(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object, n7 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      '	    Dim o7 As Object = CNum(n7)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction07(dps, FunctionEnum, n1, n2, n3, n4, n5, n6, n7))
      '        Return CNum(GetMp().GetFunction07(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1, o7.x1))
    End Function



    Shared Function appellf2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf4", x1, x2, x3, x4, x5, x6, x7)
    End Function


    Shared Function appellf3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf3", x1, x2, x3, x4, x5, x6, x7)
    End Function









  End Class





  Public Class iv

    Shared FloatingPointType_ As Integer = 3

    Shared Function GetMp() As ivMathClass
      Static PyInstance As ivMathClass = Nothing
      If IsNothing(PyInstance) Then
        Try
          PyInstance = New ivMathClass
        Catch ex As Exception
          '				ReportException(ex)
        End Try
      End If
      Return PyInstance
    End Function


    '    Dim mp2 As New MpMathClass    

    Shared Sub New()
      Dim s As String = GetMp().PiString()
      '	Console.WriteLine(s)
    End Sub



    '  Public Function CNum(x As String) As mpNum
    Shared Function CNum(x As String) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As Object) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


    Shared Function CNum(x As mpNum) As mpNum
      Dim m3 As New mpNum(x)
      Return m3
    End Function


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


    '  	Shared Sub nprint(x1 As Object) 
    '	    GetMp().nprint2(x1)
    '	End Sub


    Shared Function GetFunction00(FunctionEnum As String) As Object
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction00(dps, FunctionEnum)
      '        Return CNum(GetMp().GetFunction00(dps, FunctionEnum))
    End Function



    Shared Function pi() As Object
      Return GetFunction00("pi")
    End Function


    Shared Function degree() As Object
      Return GetFunction00("degree")
    End Function


    Shared Function e() As Object
      Return GetFunction00("e")
    End Function


    Shared Function phi() As Object
      Return GetFunction00("phi")
    End Function


    Shared Function euler() As Object
      Return GetFunction00("euler")
    End Function


    Shared Function catalan() As Object
      Return GetFunction00("catalan")
    End Function


    Shared Function apery() As Object
      Return GetFunction00("apery")
    End Function


    Shared Function khinchin() As Object
      Return GetFunction00("khinchin")
    End Function


    Shared Function glaisher() As Object
      Return GetFunction00("glaisher")
    End Function


    Shared Function mertens() As Object
      Return GetFunction00("mertens")
    End Function


    Shared Function twinprime() As Object
      Return GetFunction00("twinprime")
    End Function


    Shared Function j() As Object
      Return GetFunction00("j")
    End Function


    Shared Function quadgl() As Object
      Return GetFunction00("quadgl")
    End Function


    Shared Function quadts() As Object
      Return GetFunction00("quadts")
    End Function

    Shared Function inf() As Object
      Return GetFunction00("inf")
    End Function


    Shared Function nan() As Object
      Return GetFunction00("nan")
    End Function


    Shared Function rand() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function eps() As Object
      Return GetFunction00("rand")
    End Function


    Shared Function levin() As Object
      Return GetFunction00("levin")
    End Function


    Shared Function cohen_alt() As Object
      Return GetFunction00("cohen_alt")
    End Function




    Shared Function GetFunction01F(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, n1))
    End Function


    Shared Function GetFunction01List(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)
    End Function


    Shared Function arange(x1 As Object) As Object
      Return GetFunction01List("arange", x1)
    End Function

    Shared Function matrix(x1 As Object) As Object
      Return GetFunction01List("matrix", x1)
    End Function

    Shared Function eye(x1 As Object) As Object
      Return GetFunction01List("eye", x1)
    End Function


    Shared Function diag(x1 As Object) As Object
      Return GetFunction01List("diag", x1)
    End Function



    Shared Function zeros(x1 As Object) As Object
      Return GetFunction01List("zeros", x1)
    End Function


    Shared Function ones(x1 As Object) As Object
      Return GetFunction01List("ones", x1)
    End Function


    Shared Function hilbert(x1 As Object) As Object
      Return GetFunction01List("hilbert", x1)
    End Function


    Shared Function randmatrix(x1 As Object) As Object
      Return GetFunction01List("randmatrix", x1)
    End Function


    Shared Function lu(x1 As Object) As Object
      Return GetFunction01List("lu", x1)
    End Function

    Shared Function qr(x1 As Object) As Object
      Return GetFunction01List("qr", x1)
    End Function

    Shared Function cholesky(x1 As Object) As Object
      Return GetFunction01List("cholesky", x1)
    End Function



    Shared Function det(x1 As Object) As Object
      Return GetFunction01List("det", x1)
    End Function

    Shared Function cond(x1 As Object) As Object
      Return GetFunction01List("cond", x1)
    End Function

    Shared Function inverse(x1 As Object) As Object
      Return GetFunction01List("inverse", x1)
    End Function



    Shared Function polyroots(x1 As Object) As Object
      Return GetFunction01List("polyroots", x1)
    End Function


    Shared Function GetFunction01(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction01(dps, FunctionEnum, n1)

      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, o1.x1))
    End Function


    Shared Function mpf(x1 As Object) As Object
      Return GetFunction01("mpf", x1)
    End Function


    Shared Function mpc(x1 As Object) As Object
      Return GetFunction01("mpc", x1)
    End Function

    Shared Function convert(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function mpmathify(x1 As Object) As Object
      Return GetFunction01("convert", x1)
    End Function

    Shared Function nstr(x1 As Object) As Object
      Return GetFunction01("nstr", x1)
    End Function



    '	*********************************************

    Shared Function fneg(x1 As Object) As Object
      Return GetFunction01("fneg", x1)
    End Function


    Shared Function fsum(x1 As Object) As Object
      Return GetFunction01("fsum", x1)
    End Function


    Shared Function fprod(x1 As Object) As Object
      Return GetFunction01("fprod", x1)
    End Function


    Shared Function fdot(x1 As Object) As Object
      Return GetFunction01("fdot", x1)
    End Function


    Shared Function isinf(x1 As Object) As Object
      Return GetFunction01("isinf", x1)
    End Function


    Shared Function isnan(x1 As Object) As Object
      Return GetFunction01("isnan", x1)
    End Function


    Shared Function isnormal(x1 As Object) As Object
      Return GetFunction01("isnormal", x1)
    End Function


    Shared Function isfinite(x1 As Object) As Object
      Return GetFunction01("isfinite", x1)
    End Function


    Shared Function isint(x1 As Object) As Object
      Return GetFunction01("isint", x1)
    End Function


    Shared Function frexp(x1 As Object) As Object
      Return GetFunction01("frexp", x1)
    End Function


    Shared Function mag(x1 As Object) As Object
      Return GetFunction01("mag", x1)
    End Function


    Shared Function nint_distance(x1 As Object) As Object
      Return GetFunction01("nint_distance", x1)
    End Function

    '	*********************************************

    Shared Function floor(x1 As Object) As Object
      Return GetFunction01("floor", x1)
    End Function


    Shared Function ceil(x1 As Object) As Object
      Return GetFunction01("ceil", x1)
    End Function


    Shared Function nint(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    Shared Function frac(x1 As Object) As Object
      Return GetFunction01("nint", x1)
    End Function


    '	*********************************************

    Shared Function chop(x1 As Object) As Object
      Return GetFunction01("chop", x1)
    End Function



    Shared Function sqrt(x1 As Object) As Object
      Return GetFunction01("sqrt", x1)
    End Function


    Shared Function cbrt(x1 As Object) As Object
      Return GetFunction01("cbrt", x1)
    End Function

    Shared Function unitroots(x1 As Object) As Object
      Return GetFunction01("unitroots", x1)
    End Function

    Shared Function exp(x1 As Object) As Object
      Return GetFunction01("exp", x1)
    End Function

    Shared Function expj(x1 As Object) As Object
      Return GetFunction01("expj", x1)
    End Function

    Shared Function expjpi(x1 As Object) As Object
      Return GetFunction01("expjpi", x1)
    End Function

    Shared Function expm1(x1 As Object) As Object
      Return GetFunction01("expm1", x1)
    End Function

    Shared Function log(x1 As Object) As Object
      Return GetFunction01("log", x1)
    End Function

    Shared Function ln(x1 As Object) As Object
      Return GetFunction01("ln", x1)
    End Function

    Shared Function ln10(x1 As Object) As Object
      Return GetFunction01("ln10", x1)
    End Function

    Shared Function ln2(x1 As Object) As Object
      Return GetFunction01("ln2", x1)
    End Function


    Shared Function log10(x1 As Object) As Object
      Return GetFunction01("log10", x1)
    End Function

    Shared Function log2(x1 As Object) As Object
      Return GetFunction01("log2", x1)
    End Function

    Shared Function lambertw(x1 As Object) As Object
      Return GetFunction01("lambertw", x1)
    End Function



    Shared Function degrees(x1 As Object) As Object
      Return GetFunction01("degrees", x1)
    End Function

    Shared Function radians(x1 As Object) As Object
      Return GetFunction01("radians", x1)
    End Function

    Shared Function cos(x1 As Object) As Object
      Return GetFunction01("cos", x1)
    End Function

    Shared Function sin(x1 As Object) As Object
      Return GetFunction01("sin", x1)
    End Function

    Shared Function cos_sin(x1 As Object) As Object
      Return GetFunction01("cos_sin", x1)
    End Function


    Shared Function tan(x1 As Object) As Object
      Return GetFunction01("tan", x1)
    End Function

    Shared Function sec(x1 As Object) As Object
      Return GetFunction01("sec", x1)
    End Function

    Shared Function csc(x1 As Object) As Object
      Return GetFunction01("csc", x1)
    End Function

    Shared Function cot(x1 As Object) As Object
      Return GetFunction01("cot", x1)
    End Function

    Shared Function cospi(x1 As Object) As Object
      Return GetFunction01("cospi", x1)
    End Function

    Shared Function sinpi(x1 As Object) As Object
      Return GetFunction01("sinpi", x1)
    End Function


    Shared Function cospi_sinpi(x1 As Object) As Object
      Return GetFunction01("cospi_sinpi", x1)
    End Function


    Shared Function acos(x1 As Object) As Object
      Return GetFunction01("acos", x1)
    End Function

    Shared Function asin(x1 As Object) As Object
      Return GetFunction01("asin", x1)
    End Function

    Shared Function atan(x1 As Object) As Object
      Return GetFunction01("atan", x1)
    End Function

    Shared Function asec(x1 As Object) As Object
      Return GetFunction01("asec", x1)
    End Function

    Shared Function acsc(x1 As Object) As Object
      Return GetFunction01("acsc", x1)
    End Function

    Shared Function acot(x1 As Object) As Object
      Return GetFunction01("acot", x1)
    End Function



    Shared Function sinc(x1 As Object) As Object
      Return GetFunction01("sinc", x1)
    End Function

    Shared Function sincpi(x1 As Object) As Object
      Return GetFunction01("sincpi", x1)
    End Function



    Shared Function cosh(x1 As Object) As Object
      Return GetFunction01("cosh", x1)
    End Function


    Shared Function sinh(x1 As Object) As Object
      Return GetFunction01("sinh", x1)
    End Function


    Shared Function tanh(x1 As Object) As Object
      Return GetFunction01("tanh", x1)
    End Function


    Shared Function sech(x1 As Object) As Object
      Return GetFunction01("sech", x1)
    End Function


    Shared Function csch(x1 As Object) As Object
      Return GetFunction01("csch", x1)
    End Function


    Shared Function coth(x1 As Object) As Object
      Return GetFunction01("coth", x1)
    End Function




    Shared Function acosh(x1 As Object) As Object
      Return GetFunction01("acosh", x1)
    End Function


    Shared Function asinh(x1 As Object) As Object
      Return GetFunction01("asinh", x1)
    End Function


    Shared Function atanh(x1 As Object) As Object
      Return GetFunction01("atanh", x1)
    End Function


    Shared Function asech(x1 As Object) As Object
      Return GetFunction01("asech", x1)
    End Function


    Shared Function acsch(x1 As Object) As Object
      Return GetFunction01("acsch", x1)
    End Function


    Shared Function acoth(x1 As Object) As Object
      Return GetFunction01("acoth", x1)
    End Function



    Shared Function fac(x1 As Object) As Object
      Return GetFunction01("fac", x1)
    End Function


    Shared Function factorial(x1 As Object) As Object
      Return GetFunction01("factorial", x1)
    End Function


    Shared Function fac2(x1 As Object) As Object
      Return GetFunction01("fac2", x1)
    End Function


    Shared Function gamma(x1 As Object) As Object
      Return GetFunction01("gamma", x1)
    End Function


    Shared Function rgamma(x1 As Object) As Object
      Return GetFunction01("rgamma", x1)
    End Function


    Shared Function loggamma(x1 As Object) As Object
      Return GetFunction01("loggamma", x1)
    End Function


    Shared Function superfac(x1 As Object) As Object
      Return GetFunction01("superfac", x1)
    End Function


    Shared Function hyperfac(x1 As Object) As Object
      Return GetFunction01("hyperfac", x1)
    End Function

    Shared Function barnesg(x1 As Object) As Object
      Return GetFunction01("barnesg", x1)
    End Function


    Shared Function digamma(x1 As Object) As Object
      Return GetFunction01("digamma", x1)
    End Function


    Shared Function harmonic(x1 As Object) As Object
      Return GetFunction01("harmonic", x1)
    End Function




    Shared Function ei(x1 As Object) As Object
      Return GetFunction01("ei", x1)
    End Function


    Shared Function e1(x1 As Object) As Object
      Return GetFunction01("e1", x1)
    End Function


    Shared Function li(x1 As Object) As Object
      Return GetFunction01("li", x1)
    End Function


    Shared Function ci(x1 As Object) As Object
      Return GetFunction01("ci", x1)
    End Function


    Shared Function si(x1 As Object) As Object
      Return GetFunction01("si", x1)
    End Function


    Shared Function chi(x1 As Object) As Object
      Return GetFunction01("chi", x1)
    End Function


    Shared Function shi(x1 As Object) As Object
      Return GetFunction01("shi", x1)
    End Function


    Shared Function erf(x1 As Object) As Object
      Return GetFunction01("erf", x1)
    End Function


    Shared Function erfc(x1 As Object) As Object
      Return GetFunction01("erfc", x1)
    End Function


    Shared Function erfi(x1 As Object) As Object
      Return GetFunction01("erfi", x1)
    End Function


    Shared Function erfinv(x1 As Object) As Object
      Return GetFunction01("erfinv", x1)
    End Function


    Shared Function fresnels(x1 As Object) As Object
      Return GetFunction01("fresnels", x1)
    End Function


    Shared Function fresnelc(x1 As Object) As Object
      Return GetFunction01("fresnelc", x1)
    End Function




    Shared Function j0(x1 As Object) As Object
      Return GetFunction01("j0", x1)
    End Function


    Shared Function j1(x1 As Object) As Object
      Return GetFunction01("j1", x1)
    End Function




    Shared Function airyai(x1 As Object) As Object
      Return GetFunction01("airyai", x1)
    End Function


    Shared Function airybi(x1 As Object) As Object
      Return GetFunction01("airybi", x1)
    End Function


    Shared Function airyaizero(x1 As Object) As Object
      Return GetFunction01("airyaizero", x1)
    End Function


    Shared Function airybizero(x1 As Object) As Object
      Return GetFunction01("airybizero", x1)
    End Function



    Shared Function scorergi(x1 As Object) As Object
      Return GetFunction01("scorergi", x1)
    End Function


    Shared Function scorerhi(x1 As Object) As Object
      Return GetFunction01("scorerhi", x1)
    End Function



    Shared Function qfrom(x1 As Object) As Object
      Return GetFunction01("qfrom", x1)
    End Function


    Shared Function qbarfrom(x1 As Object) As Object
      Return GetFunction01("qbarfrom", x1)
    End Function


    Shared Function mfrom(x1 As Object) As Object
      Return GetFunction01("mfrom", x1)
    End Function


    Shared Function kfrom(x1 As Object) As Object
      Return GetFunction01("kfrom", x1)
    End Function


    Shared Function taufrom(x1 As Object) As Object
      Return GetFunction01("taufrom", x1)
    End Function


    Shared Function ellipk(x1 As Object) As Object
      Return GetFunction01("ellipk", x1)
    End Function



    Shared Function kleinj(x1 As Object) As Object
      Return GetFunction01("kleinj", x1)
    End Function




    Shared Function zeta(x1 As Object) As Object
      Return GetFunction01("zeta", x1)
    End Function


    Shared Function altzeta(x1 As Object) As Object
      Return GetFunction01("altzeta", x1)
    End Function


    Shared Function zetazero(x1 As Object) As Object
      Return GetFunction01("zetazero", x1)
    End Function


    Shared Function nzeros(x1 As Object) As Object
      Return GetFunction01("nzeros", x1)
    End Function


    Shared Function siegelz(x1 As Object) As Object
      Return GetFunction01("siegelz", x1)
    End Function


    Shared Function siegeltheta(x1 As Object) As Object
      Return GetFunction01("siegeltheta", x1)
    End Function


    Shared Function grampoint(x1 As Object) As Object
      Return GetFunction01("grampoint", x1)
    End Function


    Shared Function backlunds(x1 As Object) As Object
      Return GetFunction01("backlunds", x1)
    End Function



    Shared Function primezeta(x1 As Object) As Object
      Return GetFunction01("primezeta", x1)
    End Function


    Shared Function secondzeta(x1 As Object) As Object
      Return GetFunction01("secondzeta", x1)
    End Function



    Shared Function fibonacci(x1 As Object) As Object
      Return GetFunction01("fibonacci", x1)
    End Function


    Shared Function fib(x1 As Object) As Object
      Return GetFunction01("fib", x1)
    End Function


    Shared Function bernoulli(x1 As Object) As Object
      Return GetFunction01("bernoulli", x1)
    End Function


    Shared Function bernfrac(x1 As Object) As Object
      Return GetFunction01("bernfrac", x1)
    End Function


    Shared Function eulernum(x1 As Object) As Object
      Return GetFunction01("eulernum", x1)
    End Function



    Shared Function primepi(x1 As Object) As Object
      Return GetFunction01("primepi", x1)
    End Function


    Shared Function primepi2(x1 As Object) As Object
      Return GetFunction01("primepi2", x1)
    End Function


    Shared Function riemannr(x1 As Object) As Object
      Return GetFunction01("riemannr", x1)
    End Function


    Shared Function mangoldt(x1 As Object) As Object
      Return GetFunction01("mangoldt", x1)
    End Function



    Shared Function identify(x1 As Object) As Object
      Return GetFunction01("identify", x1)
    End Function


    Shared Function findpoly(x1 As Object) As Object
      Return GetFunction01("findpoly", x1)
    End Function


    Shared Function richardson(x1 As Object) As Object
      Return GetFunction01("richardson", x1)
    End Function


    Shared Function shanks(x1 As Object) As Object
      Return GetFunction01("shanks", x1)
    End Function


    Shared Function diffs_prod(x1 As Object) As Object
      Return GetFunction01("diffs_prod", x1)
    End Function


    Shared Function diffs_exp(x1 As Object) As Object
      Return GetFunction01("diffs_exp", x1)
    End Function



    Shared Function svd_r(x1 As Object) As Object
      Return GetFunction01("svd_r", x1)
    End Function

    Shared Function svd_c(x1 As Object) As Object
      Return GetFunction01("svd_c", x1)
    End Function

    Shared Function svd(x1 As Object) As Object
      Return GetFunction01("svd", x1)
    End Function


    Shared Function hessenberg(x1 As Object) As Object
      Return GetFunction01("hessenberg", x1)
    End Function

    Shared Function schur(x1 As Object) As Object
      Return GetFunction01("schur", x1)
    End Function


    Shared Function eig(x1 As Object) As Object
      Return GetFunction01("eig", x1)
    End Function

    Shared Function eigsy(x1 As Object) As Object
      Return GetFunction01("eigsy", x1)
    End Function

    Shared Function eighe(x1 As Object) As Object
      Return GetFunction01("eighe", x1)
    End Function

    Shared Function eigh(x1 As Object) As Object
      Return GetFunction01("eigh", x1)
    End Function


    Shared Function expm(x1 As Object) As Object
      Return GetFunction01("expm", x1)
    End Function

    Shared Function sqrtm(x1 As Object) As Object
      Return GetFunction01("sqrtm", x1)
    End Function

    Shared Function logm(x1 As Object) As Object
      Return GetFunction01("logm", x1)
    End Function

    Shared Function sinm(x1 As Object) As Object
      Return GetFunction01("sinm", x1)
    End Function

    Shared Function cosm(x1 As Object) As Object
      Return GetFunction01("cosm", x1)
    End Function




    Private Shared Function GetFunction02StrArgs(FunctionEnum As String, n1 As Object, n2 As Object, StrArgs As String) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function



    Shared Function GetFunction02Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
    End Function


    Shared Function findroot(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("findroot", x1, x2, kwargs)
    End Function


    Shared Function quad(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("quad", x1, x2, kwargs)
    End Function



    Shared Function nsum(x1 As Object, x2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction02Kwargs("nsum", x1, x2, kwargs)
    End Function


    Shared Function GetFunction03Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = GetMp().GetDps()
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction03Kwargs(dps, FunctionEnum, n1, n2, n3, StrArgs)
    End Function



    Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("quad2d", x1, x2, x3, kwargs)
    End Function



    Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("nsum2d", x1, x2, x3, kwargs)
    End Function



    Shared Function GetFunction04Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Dim StrArgs As String = ""
      For Each key2 In kwargs.Keys
        Dim value As Object = kwargs(key2)
        Dim ValueStr = value.ToString()
        If TypeOf value Is String Then
          ValueStr = "'" + ValueStr + "'"
        End If
        '    	    Console.WriteLine("key: {0}, value: {1} ", key2, ValueStr)
        StrArgs = StrArgs + ", " + key2.ToString() + "=" + ValueStr
      Next
      Return GetMp().GetFunction04Kwargs(dps, FunctionEnum, n1, n2, n3, n4, StrArgs)
    End Function



    Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("quad3d", x1, x2, x3, x4, kwargs)
    End Function



    Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("nsum3d", x1, x2, x3, x4, kwargs)
    End Function




    Shared Function GetFunction02F(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, n1, n2))
    End Function



    Shared Function unitvector(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("unitvector", x1, x2)
    End Function


    Shared Function powm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("powm", x1, x2)
    End Function


    Shared Function lu_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("lu_solve", x1, x2)
    End Function



    Shared Function qr_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("qr_solve", x1, x2)
    End Function



    Shared Function cholesky_solve(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("cholesky_solve", x1, x2)
    End Function




    Shared Function norm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("norm", x1, x2)
    End Function

    Shared Function mnorm(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("mnorm", x1, x2)
    End Function



    '	Shared Function quad(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("quad", x1, x2)
    '	End Function
    '	
    '	
    '	Shared Function nsum(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("nsum", x1, x2)
    '	End Function


    Shared Function sumem(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumem", x1, x2)
    End Function

    Shared Function sumap(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("sumap", x1, x2)
    End Function



    Shared Function nprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("nprod", x1, x2)
    End Function


    Shared Function limit(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("limit", x1, x2)
    End Function


    Shared Function diff(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diff", x1, x2)
    End Function


    Shared Function diffs(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("diffs", x1, x2)
    End Function


    Shared Function differint(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("differint", x1, x2)
    End Function



    Shared Function quadosc(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("quadosc", x1, x2)
    End Function


    Shared Function gammaprod(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("gammaprod", x1, x2)
    End Function


    '	Shared Function findroot(x1 As Object, x2 As Object) As Object
    '	    Return GetFunction02F("findroot", x1, x2)
    '	End Function


    Shared Function polyval(x1 As Object, x2 As Object) As Object
      Return GetFunction02F("polyval", x1, x2)
    End Function




    Shared Function GetFunction02(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      Dim dps As Integer = GetMp().GetDps()
      Return GetMp().GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, o1.x1, o2.x1))
    End Function

    '	***********************************************


    Shared Function autoprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("autoprec", x1, x2)
    End Function

    Shared Function workprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workprec", x1, x2)
    End Function

    Shared Function workdps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("workdps", x1, x2)
    End Function

    Shared Function extraprec(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extraprec", x1, x2)
    End Function

    Shared Function extradps(x1 As Object, x2 As Object) As Object
      Return GetFunction02("extradps", x1, x2)
    End Function

    Shared Function memoize(x1 As Object, x2 As Object) As Object
      Return GetFunction02("memoize", x1, x2)
    End Function

    Shared Function maxcalls(x1 As Object, x2 As Object) As Object
      Return GetFunction02("maxcalls", x1, x2)
    End Function


    Shared Function monitor(x1 As Object, x2 As Object) As Object
      Return GetFunction02("monitor", x1, x2)
    End Function

    Shared Function timing(x1 As Object, x2 As Object) As Object
      Return GetFunction02("timing", x1, x2)
    End Function

    '	***********************************************

    Shared Function fabs(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fabs", x1, x2)
    End Function

    Shared Function sign(x1 As Object, x2 As Object) As Object
      Return GetFunction02("sign", x1, x2)
    End Function

    Shared Function re(x1 As Object, x2 As Object) As Object
      Return GetFunction02("re", x1, x2)
    End Function

    Shared Function im(x1 As Object, x2 As Object) As Object
      Return GetFunction02("im", x1, x2)
    End Function

    Shared Function arg(x1 As Object, x2 As Object) As Object
      Return GetFunction02("arg", x1, x2)
    End Function

    ' same as arg
    Shared Function phase(x1 As Object, x2 As Object) As Object
      Return GetFunction02("phase", x1, x2)
    End Function


    Shared Function conj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("conj", x1, x2)
    End Function

    Shared Function polar(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polar", x1, x2)
    End Function

    Shared Function rect(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rect", x1, x2)
    End Function









    '	***********************************************

    Shared Function mpc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("mpc", x1, x2)
    End Function


    Shared Function fraction(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fraction", x1, x2)
    End Function


    Shared Function linspace(x1 As Object, x2 As Object) As Object
      Return GetFunction02("linspace", x1, x2)
    End Function


    Shared Function fadd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fadd", x1, x2)
    End Function


    Shared Function fsub(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fsub", x1, x2)
    End Function



    Shared Function fmul(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmul", x1, x2)
    End Function


    Shared Function fdiv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fdiv", x1, x2)
    End Function



    Shared Function fmod(x1 As Object, x2 As Object) As Object
      Return GetFunction02("fmod", x1, x2)
    End Function


    Shared Function almosteq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function ldexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("almosteq", x1, x2)
    End Function


    Shared Function chop(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chop", x1, x2)
    End Function


    Shared Function hypot(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hypot", x1, x2)
    End Function


    Shared Function power(x1 As Object, x2 As Object) As Object
      Return GetFunction02("power", x1, x2)
    End Function


    Shared Function powm1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("powm1", x1, x2)
    End Function


    Shared Function lambertw_k(x1 As Object, x2 As Object) As Object
      Return GetFunction02("lambertw_k", x1, x2)
    End Function


    Shared Function agm(x1 As Object, x2 As Object) As Object
      Return GetFunction02("agm", x1, x2)
    End Function


    Shared Function binomial(x1 As Object, x2 As Object) As Object
      Return GetFunction02("binomial", x1, x2)
    End Function



    Shared Function atan2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("atan2", x1, x2)
    End Function


    Shared Function rf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("rf", x1, x2)
    End Function


    Shared Function ff(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ff", x1, x2)
    End Function


    Shared Function beta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("beta", x1, x2)
    End Function


    Shared Function psi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("psi", x1, x2)
    End Function


    Shared Function polygamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polygamma", x1, x2)
    End Function


    Shared Function gammainc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("gammainc", x1, x2)
    End Function


    Shared Function expint(x1 As Object, x2 As Object) As Object
      Return GetFunction02("expint", x1, x2)
    End Function




    Shared Function besselj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselj", x1, x2)
    End Function


    Shared Function bessely(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bessely", x1, x2)
    End Function


    Shared Function besseli(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseli", x1, x2)
    End Function


    Shared Function besselk(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselk", x1, x2)
    End Function


    Shared Function besseljzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besseljzero", x1, x2)
    End Function


    Shared Function besselyzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("besselyzero", x1, x2)
    End Function


    Shared Function hankel1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel1", x1, x2)
    End Function


    Shared Function hankel2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hankel2", x1, x2)
    End Function


    Shared Function ber(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ber", x1, x2)
    End Function


    Shared Function bei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bei", x1, x2)
    End Function


    Shared Function ker(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ker", x1, x2)
    End Function


    Shared Function kei(x1 As Object, x2 As Object) As Object
      Return GetFunction02("kei", x1, x2)
    End Function




    Shared Function struveh(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struveh", x1, x2)
    End Function


    Shared Function struvel(x1 As Object, x2 As Object) As Object
      Return GetFunction02("struvel", x1, x2)
    End Function


    Shared Function angerj(x1 As Object, x2 As Object) As Object
      Return GetFunction02("angerj", x1, x2)
    End Function


    Shared Function webere(x1 As Object, x2 As Object) As Object
      Return GetFunction02("webere", x1, x2)
    End Function


    Shared Function airyaideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaideriv", x1, x2)
    End Function


    Shared Function airybideriv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybideriv", x1, x2)
    End Function


    Shared Function airyaiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airyaiderivzero", x1, x2)
    End Function


    Shared Function airybiderivzero(x1 As Object, x2 As Object) As Object
      Return GetFunction02("airybiderivzero", x1, x2)
    End Function




    Shared Function coulombc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("coulombc", x1, x2)
    End Function


    Shared Function pcfd(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfd", x1, x2)
    End Function


    Shared Function pcfu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfu", x1, x2)
    End Function


    Shared Function pcfv(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfv", x1, x2)
    End Function


    Shared Function pcfw(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pcfw", x1, x2)
    End Function



    Shared Function legendre(x1 As Object, x2 As Object) As Object
      Return GetFunction02("legendre", x1, x2)
    End Function


    Shared Function chebyt(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyt", x1, x2)
    End Function


    Shared Function chebyu(x1 As Object, x2 As Object) As Object
      Return GetFunction02("chebyu", x1, x2)
    End Function


    Shared Function hermite(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hermite", x1, x2)
    End Function



    Shared Function hyp0f1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("hyp0f1", x1, x2)
    End Function



    Shared Function ellipf(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipf", x1, x2)
    End Function


    Shared Function ellipe(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellipe", x1, x2)
    End Function


    Shared Function ellippi(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ellippi", x1, x2)
    End Function


    Shared Function elliprc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("elliprc", x1, x2)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function


    Shared Function hurwitz(x1 As Object, x2 As Object) As Object
      Return GetFunction02("zeta", x1, x2)
    End Function

    Shared Function dirichlet(x1 As Object, x2 As Object) As Object
      Return GetFunction02("dirichlet", x1, x2)
    End Function


    Shared Function stieltjes(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stieltjes", x1, x2)
    End Function



    Shared Function polylog(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polylog", x1, x2)
    End Function


    Shared Function clsin(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clsin", x1, x2)
    End Function


    Shared Function clcos(x1 As Object, x2 As Object) As Object
      Return GetFunction02("clcos", x1, x2)
    End Function


    Shared Function polyexp(x1 As Object, x2 As Object) As Object
      Return GetFunction02("polyexp", x1, x2)
    End Function




    Shared Function bernpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bernpoly", x1, x2)
    End Function


    Shared Function eulerpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("eulerpoly", x1, x2)
    End Function


    Shared Function bell(x1 As Object, x2 As Object) As Object
      Return GetFunction02("bell", x1, x2)
    End Function


    Shared Function stirling1(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling1", x1, x2)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object) As Object
      Return GetFunction02("stirling2", x1, x2)
    End Function


    Shared Function cyclotomic(x1 As Object, x2 As Object) As Object
      Return GetFunction02("cyclotomic", x1, x2)
    End Function



    Shared Function qgamma(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qgamma", x1, x2)
    End Function


    Shared Function qfac(x1 As Object, x2 As Object) As Object
      Return GetFunction02("qfac", x1, x2)
    End Function


    Shared Function ﬁndpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ﬁndpoly", x1, x2)
    End Function


    Shared Function pslq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pslq", x1, x2)
    End Function







    Shared Function GetFunction03F(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3)
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
    End Function


    Shared Function eig_sort(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("eig_sort", x1, x2, x3)
    End Function


    Shared Function diff(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("diff", x1, x2, x3)
    End Function


    Shared Function odefun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("odefun", x1, x2, x3)
    End Function


    Shared Function taylor(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("taylor", x1, x2, x3)
    End Function

    Shared Function pade(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("pade", x1, x2, x3)
    End Function

    Shared Function chebyfit(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("chebyfit", x1, x2, x3)
    End Function

    Shared Function fourier(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourier", x1, x2, x3)
    End Function

    Shared Function fourierval(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03F("fourierval", x1, x2, x3)
    End Function

    '	*************************



    '	Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("quad2d", x1, x2, x3)
    '	End Function
    '
    '	
    '	Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object) As Object
    '	    Return GetFunction03F("nsum2d", x1, x2, x3)
    '	End Function



    Shared Function GetFunction03(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      Dim dps As Integer = GetMp().GetDps()
      Return CNum(GetMp().GetFunction03(dps, FunctionEnum, n1, n2, n3))
      '        Return CNum(GetMp().GetFunction03(dps, FunctionEnum, o1.x1, o2.x1, o3.x1))
    End Function


    Shared Function root(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("root", x1, x2, x3)
    End Function

    Shared Function nthroot(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("nthroot", x1, x2, x3)
    End Function


    Shared Function hypercomb(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hypercomb", x1, x2, x3)
    End Function


    Shared Function betainc(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("betainc", x1, x2, x3)
    End Function


    Shared Function npdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("npdf", x1, x2, x3)
    End Function


    Shared Function ncdf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ncdf", x1, x2, x3)
    End Function


    Shared Function besseljderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljderiv", x1, x2, x3)
    End Function


    Shared Function besselyderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyderiv", x1, x2, x3)
    End Function


    Shared Function besselideriv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselideriv", x1, x2, x3)
    End Function


    Shared Function besselkderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselkderiv", x1, x2, x3)
    End Function


    Shared Function besseljzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besseljzeroderiv", x1, x2, x3)
    End Function


    Shared Function besselyzeroderiv(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("besselyzeroderiv", x1, x2, x3)
    End Function



    Shared Function lommels1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels1", x1, x2, x3)
    End Function


    Shared Function lommels2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lommels2", x1, x2, x3)
    End Function


    Shared Function coulombf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombf", x1, x2, x3)
    End Function


    Shared Function coulombg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("coulombg", x1, x2, x3)
    End Function


    Shared Function hyperu(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyperu", x1, x2, x3)
    End Function


    Shared Function whitm(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitm", x1, x2, x3)
    End Function


    Shared Function whitw(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("whitw", x1, x2, x3)
    End Function



    Shared Function legenp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenp", x1, x2, x3)
    End Function


    Shared Function legenq(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("legenq", x1, x2, x3)
    End Function


    Shared Function gegenbauer(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("gegenbauer", x1, x2, x3)
    End Function


    Shared Function laguerre(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("laguerre", x1, x2, x3)
    End Function



    Shared Function hyp1f1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp1f1", x1, x2, x3)
    End Function


    Shared Function hyp2f0(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyp2f0", x1, x2, x3)
    End Function


    Shared Function hyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("hyper", x1, x2, x3)
    End Function


    Shared Function bihyper(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("bihyper", x1, x2, x3)
    End Function



    Shared Function ellippi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellippi", x1, x2, x3)
    End Function


    Shared Function elliprf(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprf", x1, x2, x3)
    End Function


    Shared Function elliprd(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprd", x1, x2, x3)
    End Function


    Shared Function elliprg(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("elliprg", x1, x2, x3)
    End Function



    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("jtheta", x1, x2, x3)
    End Function


    Shared Function ellipfun(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("ellipfun", x1, x2, x3)
    End Function



    Shared Function zeta(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("zeta", x1, x2, x3)
    End Function


    Shared Function dirichlet(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("dirichlet", x1, x2, x3)
    End Function


    Shared Function lerchphi(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("lerchphi", x1, x2, x3)
    End Function



    Shared Function stirling1(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling1", x1, x2, x3)
    End Function


    Shared Function stirling2(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("stirling2", x1, x2, x3)
    End Function


    Shared Function qp(x1 As Object, x2 As Object, x3 As Object) As Object
      Return GetFunction03("qp", x1, x2, x3)
    End Function








    Shared Function GetFunction04(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return GetMp().GetFunction04(dps, FunctionEnum, n1, n2, n3, n4)
      '        Return CNum(GetMp().GetFunction04(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1))
    End Function



    '	Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("quad3d", x1, x2, x3, x4)
    '	End Function
    '	
    '		
    '	Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
    '	    Return GetFunction04("nsum3d", x1, x2, x3, x4)
    '	End Function


    Shared Function jacobi(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jacobi", x1, x2, x3, x4)
    End Function


    Shared Function spherharm(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("spherharm", x1, x2, x3, x4)
    End Function


    Shared Function hyp1f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp1f2", x1, x2, x3, x4)
    End Function


    Shared Function hyp2f1(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyp2f1", x1, x2, x3, x4)
    End Function


    Shared Function meijerg(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("meijerg", x1, x2, x3, x4)
    End Function


    Shared Function hyper2d(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("hyper2d", x1, x2, x3, x4)
    End Function


    Shared Function elliprj(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("elliprj", x1, x2, x3, x4)
    End Function


    Shared Function jtheta(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("jtheta", x1, x2, x3, x4)
    End Function


    Shared Function qhyper(x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
      Return GetFunction04("qhyper", x1, x2, x3, x4)
    End Function





    Shared Function GetFunction05(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction05(dps, FunctionEnum, n1, n2, n3, n4, n5))
      '        Return CNum(GetMp().GetFunction05(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1))
    End Function



    Shared Function hyp2f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object) As Object
      Return GetFunction05("hyp2f2", x1, x2, x3, x4, x5)
    End Function






    Shared Function GetFunction06(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction06(dps, FunctionEnum, n1, n2, n3, n4, n5, n6))
      '        Return CNum(GetMp().GetFunction06(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1))
    End Function



    Shared Function hyp2f3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp2f3", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function hyp3f2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("hyp3f2", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf1(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf1", x1, x2, x3, x4, x5, x6)
    End Function


    Shared Function appellf4(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
      Return GetFunction06("appellf4", x1, x2, x3, x4, x5, x6)
    End Function



    Shared Function GetFunction07(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, n5 As Object, n6 As Object, n7 As Object) As Object
      '	    Dim o1 As Object = CNum(n1)
      '	    Dim o2 As Object = CNum(n2)
      '	    Dim o3 As Object = CNum(n3)
      '	    Dim o4 As Object = CNum(n4)
      '	    Dim o5 As Object = CNum(n5)
      '	    Dim o6 As Object = CNum(n6)
      '	    Dim o7 As Object = CNum(n7)
      Dim dps As Integer = 15
      '        Dim dps As Integer = GetMp().GetDps()        
      Return CNum(GetMp().GetFunction07(dps, FunctionEnum, n1, n2, n3, n4, n5, n6, n7))
      '        Return CNum(GetMp().GetFunction07(dps, FunctionEnum, o1.x1, o2.x1, o3.x1, o4.x1, o5.x1, o6.x1, o7.x1))
    End Function



    Shared Function appellf2(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf4", x1, x2, x3, x4, x5, x6, x7)
    End Function


    Shared Function appellf3(x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
      Return GetFunction07("appellf3", x1, x2, x3, x4, x5, x6, x7)
    End Function



  End Class


  Public Class xl_old

    Shared Sub New()
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Log10(1.0)
      Catch ex As Exception
        Throw
      End Try
    End Sub


    Protected Overrides Sub Finalize()
      Try
        xlFunc().Dispose()
        getxlApp().Quit()
        getxlApp().Dispose()
      Catch ex As Exception
        Throw
      End Try
      MyBase.Finalize()
    End Sub


    Shared Function getxlApp() As Excel.Application
      Static xlInstance As Excel.Application = Nothing
      If IsNothing(xlInstance) Then
        Try
          xlInstance = New Excel.Application
        Catch ex As Exception
          ReportException(ex)
        End Try
      End If
      Return xlInstance
    End Function


    Shared Function xlFunc() As Excel.WorksheetFunction
      Static wsInstance As Excel.WorksheetFunction = Nothing
      If IsNothing(wsInstance) Then
        Try
          wsInstance = getxlApp().WorksheetFunction
        Catch ex As Exception
          ReportException(ex)
        End Try
      End If
      Return wsInstance
    End Function


    Shared Function ABS(x As Double) As Double
      Dim Result As Double = 0.0
      Dim Results As String = ""
      Try
        Results = xlFunc().ImAbs(x)
        Result = Convert.ToDouble(Results)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function





    Shared Function ACOS(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Acos(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function



    Shared Function ACOSH(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Acosh(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function


    Shared Function ACOT(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Acot(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function


    Shared Function ACOTH(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Acoth(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function


    Shared Function ASIN(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Asin(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function


    Shared Function ARABIC(s As String) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Arabic(s)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function











    Shared Function LOG10(x As Double) As Double
      Dim Result As Double = 0.0
      Try
        Result = xlFunc().Log10(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function






    Shared Function IMLOG10(x As String) As String
      Dim Result As String = "Error"
      Try
        Result = xlFunc().ImLog10(x)
      Catch ex As Exception
        Throw
      End Try
      Return Result
    End Function


  End Class

