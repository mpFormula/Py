Imports System
Imports Microsoft.Scripting
Imports MpMath

'Public Module mpf.Formula

  Public Class mpi_mat_t


    Friend PyPtr As Object = Nothing

    Public Sub New()
      PyPtr = MpAll.GetIvMatrix(1,1)
    End Sub

    Public Sub New(n As Integer, m As Integer)
      PyPtr = MpAll.GetIvMatrix(n, m)
    End Sub

'    Public Sub New(ByVal d As Double)
'      PyPtr = MpAll.Getmpf(d)
'    End Sub
'
'    Public Sub New(ByVal x As Object)
'      If TypeOf x Is mpi_mat_t Then
'        PyPtr = DirectCast(x, mpi_mat_t).PyPtr
'      Else
'        PyPtr = MpAll.Getmpf(x)
'      End If
'    End Sub

    Public Sub New(ByVal x As mpi_mat_t)
      PyPtr = x.PyPtr
    End Sub


'    Public Shared Widening Operator CType(ByVal m1 As mpi_mat_t) As String
'      Return m1.Str()
'    End Operator
'
'
'    'Public Shared Narrowing Operator CType(ByVal s As String) As mpi_mat_t
'    Public Shared Widening Operator CType(ByVal s As String) As mpi_mat_t
'      Return New mpi_mat_t(s)
'    End Operator


'    Public Shared Narrowing Operator CType(ByVal m1 As mpi_mat_t) As Decimal
'      Return CDec(m1.Str())
'    End Operator
'
'    Public Shared Widening Operator CType(ByVal dec As Decimal) As mpi_mat_t
'      Return New mpi_mat_t(CStr(dec))
'    End Operator

    '  Public Shared Widening Operator CType(ByVal obj As Object) As mpi_mat_t
    '    Return New mpi_mat_t(obj)
    '  End Operator


'    Public Shared Narrowing Operator CType(ByVal m1 As mpi_mat_t) As Double
'      Return CDbl(m1.Str())
'    End Operator
'
'    Public Shared Widening Operator CType(ByVal d As Double) As mpi_mat_t
'      Return New mpi_mat_t(d)
'    End Operator


'    Public Shared Narrowing Operator CType(ByVal m1 As mpi_mat_t) As Long
'      Return CLng(m1.Str())
'    End Operator
'
'    Public Shared Widening Operator CType(ByVal si As Long) As mpi_mat_t
'      Return New mpi_mat_t(CStr(si))
'    End Operator



'    Public Shared Narrowing Operator CType(ByVal m1 As mpi_mat_t) As ULong
'      Return CULng(m1.Str())
'    End Operator
'
'    Public Shared Widening Operator CType(ByVal ui As ULong) As mpi_mat_t
'      Return New mpi_mat_t(CStr(ui))
'    End Operator



    Public Shared Operator =(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr = m2.PyPtr
    End Operator


    Public Shared Operator =(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr = m1.PyPtr
    End Operator



    Public Shared Operator <>(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr <> m2.PyPtr
    End Operator


    Public Shared Operator <>(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr <> m1.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr <= m2.PyPtr
    End Operator



    Public Shared Operator <=(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr <= m2.PyPtr
    End Operator


    Public Shared Operator <=(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr <= m1.PyPtr
    End Operator




    Public Shared Operator <(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr < m2.PyPtr
    End Operator


    Public Shared Operator <(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr < m2.PyPtr
    End Operator



    Public Shared Operator <(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr < m1.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr >= m2.PyPtr
    End Operator


    Public Shared Operator >=(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr >= m1.PyPtr
    End Operator




    Public Shared Operator >(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As Boolean
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal m1 As mpi_mat_t, ByVal obj As Object) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m1.PyPtr > m2.PyPtr
    End Operator



    Public Shared Operator >(ByVal obj As Object, ByVal m1 As mpi_mat_t) As Boolean
      Dim m2 As New mpi_mat_t(obj)
      Return m2.PyPtr > m1.PyPtr
    End Operator


    Public Shared Operator +(ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = m1.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = -m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator +(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      'MsgBox("Plus_mpi_mat_t")
      m3.PyPtr = m1.PyPtr + m2.PyPtr
      Return m3
    End Operator

    Public Shared Operator +(ByVal m1 As mpi_mat_t, ByVal obj As Object) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator +(ByVal obj As Object, ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m1.PyPtr + m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = m1.PyPtr - m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator -(ByVal m1 As mpi_mat_t, ByVal obj As Object) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m1.PyPtr - m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator -(ByVal obj As Object, ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m3.PyPtr - m1.PyPtr
      Return m3
    End Operator



    Public Shared Operator *(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = m1.PyPtr * m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal m1 As mpi_mat_t, ByVal obj As Object) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m1.PyPtr * m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator *(ByVal obj As Object, ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m3.PyPtr * m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator /(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = m1.PyPtr / m2.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal m1 As mpi_mat_t, ByVal obj As Object) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m1.PyPtr / m3.PyPtr
      Return m3
    End Operator


    Public Shared Operator /(ByVal obj As Object, ByVal m1 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t(obj)
      m3.PyPtr = m3.PyPtr / m1.PyPtr
      Return m3
    End Operator




    Public Shared Operator &(ByVal m1 As mpi_mat_t, ByVal s As String) As String
      Return m1.Str() & s
    End Operator


    Public Shared Operator &(ByVal s As String, ByVal m1 As mpi_mat_t) As String
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

    Public Shared Operator ^(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      m3.PyPtr = m1.PyPtr ^ m2.PyPtr
      Return m3
    End Operator



    Public Shared Operator Mod(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr. Mod (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator \(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr \ (m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator <<(ByVal m1 As mpi_mat_t, ByVal i As Integer) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr.RSH(i)
      Return m3
    End Operator


    Public Shared Operator >>(ByVal m1 As mpi_mat_t, ByVal i As Integer) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr.LSH(i)
      Return m3
    End Operator


    Public Shared Operator IsTrue(ByVal m1 As mpi_mat_t) As Boolean
      '    Return m1.PyPtr.Is_Zero = 0
      Return True

    End Operator


    Public Shared Operator IsFalse(ByVal m1 As mpi_mat_t) As Boolean
      '    Return m1.PyPtr.Is_Zero <> 0
      Return True
    End Operator


    Public Shared Operator Not(ByVal m1 As mpi_mat_t) As Boolean
      '    If m1.PyPtr.Is_Zero <> 0 Then
      '      Return False
      '    Else
      '      Return True
      '    End If
      Return True
    End Operator


    Public Shared Operator And(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr.AND(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Or(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
      '    m3.PyPtr = m1.PyPtr.OR(m2.PyPtr)
      Return m3
    End Operator


    Public Shared Operator Xor(ByVal m1 As mpi_mat_t, ByVal m2 As mpi_mat_t) As mpi_mat_t
      Dim m3 As New mpi_mat_t()
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




  Public Class mpi_mat

    

    Shared Function GetFunction01List(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)
    End Function


    Shared Function arange(PyPtr As Object) As Object
      Return GetFunction01List("arange", PyPtr)
    End Function

    Shared Function matrix(PyPtr As Object) As Object
      Return GetFunction01List("matrix", PyPtr)
    End Function

    Shared Function eye(PyPtr As Object) As Object
      Return GetFunction01List("eye", PyPtr)
    End Function


    Shared Function diag(PyPtr As Object) As Object
      Return GetFunction01List("diag", PyPtr)
    End Function



    Shared Function zeros(PyPtr As Object) As Object
      Return GetFunction01List("zeros", PyPtr)
    End Function


    Shared Function ones(PyPtr As Object) As Object
      Return GetFunction01List("ones", PyPtr)
    End Function


    Shared Function hilbert(PyPtr As Object) As Object
      Return GetFunction01List("hilbert", PyPtr)
    End Function


    Shared Function randmatrix(PyPtr As Object) As Object
      Return GetFunction01List("randmatrix", PyPtr)
    End Function


    Shared Function lu(PyPtr As Object) As Object
      Return GetFunction01List("lu", PyPtr)
    End Function

    Shared Function qr(PyPtr As Object) As Object
      Return GetFunction01List("qr", PyPtr)
    End Function

    Shared Function cholesky(PyPtr As Object) As Object
      Return GetFunction01List("cholesky", PyPtr)
    End Function



    Shared Function det(PyPtr As Object) As Object
      Return GetFunction01List("det", PyPtr)
    End Function

    Shared Function cond(PyPtr As Object) As Object
      Return GetFunction01List("cond", PyPtr)
    End Function

    Shared Function inverse(PyPtr As Object) As Object
      Return GetFunction01List("inverse", PyPtr)
    End Function



    Shared Function polyroots(PyPtr As Object) As Object
      Return GetFunction01List("polyroots", PyPtr)
    End Function



    Shared Function GetFunction01F(FunctionEnum As String, n1 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)
      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, n1))
    End Function
    Shared Function GetFunction01(FunctionEnum As String, n1 As Object) As Object
      '	    Dim o1 As mpi_mat_t = CNum(n1)
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction01(dps, FunctionEnum, n1)

      '        Return CNum(GetMp().GetFunction01(dps, FunctionEnum, o1.PyPtr))
    End Function



    Shared Function fsum(PyPtr As Object) As Object
      Return GetFunction01("fsum", PyPtr)
    End Function


    Shared Function fprod(PyPtr As Object) As Object
      Return GetFunction01("fprod", PyPtr)
    End Function


    Shared Function fdot(PyPtr As Object) As Object
      Return GetFunction01("fdot", PyPtr)
    End Function

    
    Shared Function svd_r(PyPtr As Object) As Object
      Return GetFunction01("svd_r", PyPtr)
    End Function

    Shared Function svd_c(PyPtr As Object) As Object
      Return GetFunction01("svd_c", PyPtr)
    End Function

    Shared Function svd(PyPtr As Object) As Object
      Return GetFunction01("svd", PyPtr)
    End Function


    Shared Function hessenberg(PyPtr As Object) As Object
      Return GetFunction01("hessenberg", PyPtr)
    End Function

    Shared Function schur(PyPtr As Object) As Object
      Return GetFunction01("schur", PyPtr)
    End Function


    Shared Function eig(PyPtr As Object) As Object
      Return GetFunction01("eig", PyPtr)
    End Function

    Shared Function eigsy(PyPtr As Object) As Object
      Return GetFunction01("eigsy", PyPtr)
    End Function

    Shared Function eighe(PyPtr As Object) As Object
      Return GetFunction01("eighe", PyPtr)
    End Function

    Shared Function eigh(PyPtr As Object) As Object
      Return GetFunction01("eigh", PyPtr)
    End Function


    Shared Function expm(PyPtr As Object) As Object
      Return GetFunction01("expm", PyPtr)
    End Function

    Shared Function sqrtm(PyPtr As Object) As Object
      Return GetFunction01("sqrtm", PyPtr)
    End Function

    Shared Function logm(PyPtr As Object) As Object
      Return GetFunction01("logm", PyPtr)
    End Function

    Shared Function sinm(PyPtr As Object) As Object
      Return GetFunction01("sinm", PyPtr)
    End Function

    Shared Function cosm(PyPtr As Object) As Object
      Return GetFunction01("cosm", PyPtr)
    End Function



    Shared Function GetFunction02F(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, n1, n2))
    End Function




    Shared Function unitvector(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("unitvector", PyPtr, x2)
    End Function


    Shared Function powm(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("powm", PyPtr, x2)
    End Function


    Shared Function lu_solve(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("lu_solve", PyPtr, x2)
    End Function



    Shared Function qr_solve(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("qr_solve", PyPtr, x2)
    End Function



    Shared Function cholesky_solve(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("cholesky_solve", PyPtr, x2)
    End Function




    Shared Function norm(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("norm", PyPtr, x2)
    End Function

    Shared Function mnorm(PyPtr As Object, x2 As Object) As Object
      Return GetFunction02F("mnorm", PyPtr, x2)
    End Function






    

  End Class
  
  