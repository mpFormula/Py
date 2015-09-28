Imports System
Imports Microsoft.Scripting
Imports MpMath

'Public Module mpf.Formula

  Public Class mpc_mat_t


    ' Should be friend as well  
    Public x1 As Object = Nothing
    Friend mpc_mat_tType As Int32 = 4

    Public Sub New()
      x1 = MpAll.Getmpc("0", "0")
    End Sub

    Public Sub New(ByVal s_re As String, ByVal s_im As String)
      x1 = MpAll.Getmpc(s_re, s_im)
    End Sub

    Public Sub New(ByVal d_re As Double, ByVal d_im As Double)
      x1 = MpAll.Getmpc(d_re, d_im)
    End Sub

    Public Sub New(ByVal x As Object)
      If TypeOf x Is mpc_mat_t Then
        x1 = DirectCast(x, mpc_mat_t).x1
      Else
        x1 = MpAll.Getmpc(x, x)
      End If
    End Sub

    Public Sub New(ByVal x As mpc_mat_t)
      x1 = x.x1
    End Sub


    Public Shared Widening Operator CType(ByVal m1 As mpc_mat_t) As String
      Return m1.Str()
    End Operator


    'Public Shared Narrowing Operator CType(ByVal s As String) As mpc_mat_t
    Public Shared Widening Operator CType(ByVal s As String) As mpc_mat_t
      Return New mpc_mat_t(s, s)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_mat_t) As Decimal
      Return CDec(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpc_mat_t
      Return New mpc_mat_t(CStr(dec))
    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpc_mat_t
    '    Return New mpc_mat_t(obj)
    '  End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_mat_t) As Double
      Return CDbl(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal d As Double) As mpc_mat_t
      Return New mpc_mat_t(d, d)
    End Operator


    Public Shared Narrowing Operator CType(ByVal m1 As mpc_mat_t) As Long
      Return CLng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal si As Long) As mpc_mat_t
      Return New mpc_mat_t(CStr(si))
    End Operator



    Public Shared Narrowing Operator CType(ByVal m1 As mpc_mat_t) As ULong
      Return CULng(m1.Str())
    End Operator

    Public Shared Widening Operator CType(ByVal ui As ULong) As mpc_mat_t
      Return New mpc_mat_t(CStr(ui))
    End Operator



    Public Shared Operator =(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 = m2.x1
    End Operator


    Public Shared Operator =(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 = m2.x1
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 = m1.x1
    End Operator



    Public Shared Operator <>(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 <> m2.x1
    End Operator


    Public Shared Operator <>(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 <> m2.x1
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 <> m1.x1
    End Operator



    Public Shared Operator <=(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 <= m2.x1
    End Operator



    Public Shared Operator <=(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 <= m2.x1
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 <= m1.x1
    End Operator




    Public Shared Operator <(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 < m2.x1
    End Operator


    Public Shared Operator <(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 < m2.x1
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 < m1.x1
    End Operator


    Public Shared Operator >=(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 >= m2.x1
    End Operator


    Public Shared Operator >=(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 >= m2.x1
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 >= m1.x1
    End Operator




    Public Shared Operator >(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As Boolean
      Return m1.x1 > m2.x1
    End Operator



    Public Shared Operator >(ByVal m1 As mpc_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m1.x1 > m2.x1
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpc_mat_t) As Boolean
      Dim m2 As New mpc_mat_t(obj)
      Return m2.x1 > m1.x1
    End Operator


    Public Shared Operator +(ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = m1.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = -m1.x1
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      'MsgBox("Plus_mpc_mat_t")
      m3.x1 = m1.x1 + m2.x1
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpc_mat_t, ByVal obj As Object) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m1.x1 + m3.x1
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m1.x1 + m3.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = m1.x1 - m2.x1
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpc_mat_t, ByVal obj As Object) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m1.x1 - m3.x1
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m3.x1 - m1.x1
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = m1.x1 * m2.x1
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpc_mat_t, ByVal obj As Object) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m1.x1 * m3.x1
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m3.x1 * m1.x1
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = m1.x1 / m2.x1
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpc_mat_t, ByVal obj As Object) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m1.x1 / m3.x1
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t(obj)
      m3.x1 = m3.x1 / m1.x1
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpc_mat_t, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpc_mat_t) As String
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

    Public Shared Operator ^(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      m3.x1 = m1.x1 ^ m2.x1
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1. Mod (m2.x1)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1 \ (m2.x1)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpc_mat_t, ByVal i As Integer) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpc_mat_t, ByVal i As Integer) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpc_mat_t) As Boolean
      '    Return m1.x1.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpc_mat_t) As Boolean
      '    Return m1.x1.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpc_mat_t) As Boolean
      '    If m1.x1.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1.AND(m2.x1)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1.OR(m2.x1)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpc_mat_t, ByVal m2 As mpc_mat_t) As mpc_mat_t
      Dim m3 As New mpc_mat_t()
      '    m3.x1 = m1.x1.XOR(m2.x1)
      Return m3
    End Operator


    Public Overrides Function ToString() As String
      Return MpAll.MpMathToString(x1, mpf.dps)
    End Function





    Public Function Str() As String
      Return MpAll.MpMathToString(x1, mpf.dps)
    End Function

    Public Function __str__() As String
      Return MpAll.MpMathToString(x1, mpf.dps)
    End Function



  End Class



  Public Class mpc_mat


    Shared Function GetFunction00(FunctionEnum As String) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction00(dps, FunctionEnum)
      '        Return CNum(GetMp().GetFunction00(dps, FunctionEnum))
    End Function
    
    
    
     

    Shared Function quadgl() As Object
      Return GetFunction00("quadgl")
    End Function


    Shared Function quadts() As Object
      Return GetFunction00("quadts")
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
    
    

    Shared Function GetFunction01List(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetMp().GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)
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



    Shared Function GetFunction01F(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)
      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, n1))
    End Function
    Shared Function GetFunction01(FunctionEnum As String, n1 As Object) As Object
      '	    Dim o1 As mpc_mat_t = CNum(n1)
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)

      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, o1.x1))
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


    
    

  End Class
