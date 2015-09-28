Imports System
Imports Microsoft.Scripting
Imports MpMath

'Public Module mpf.Formula

  Public Class mpf_mat_t


    Friend PyPtr As Object = Nothing

    Public Sub New()
      PyPtr = MpAll.GetMatrix(1,1)
    End Sub

    Public Sub New(n As Integer, m As Integer)
      PyPtr = MpAll.GetMatrix(n, m)
    End Sub


    Public Sub New(ByVal x As mpf_mat_t)
      PyPtr = x.PyPtr
    End Sub



  ''' <summary>
  ''' The number of rows in the matrix
  ''' </summary>
  ''' <returns>The number of rows in the matrix</returns>
  Public ReadOnly Property rows() As Integer
    Get
      Return PyPtr.rows
    End Get
  End Property

  ''' <summary>
  ''' The number of columns in the matrix
  ''' </summary>
  ''' <returns>The number of columns in the matrix</returns>
  Public ReadOnly Property cols() As Integer
    Get
      Return PyPtr.cols
    End Get
  End Property

  Public ReadOnly Property size() As Integer
    Get
      Return PyPtr.rows * PyPtr.rows
    End Get
  End Property



  ''' <summary>
  ''' Gets and Sets an Item
  ''' </summary>
  ''' <param name="row_i"></param>
  ''' <param name="col_j"></param>
  Default Public Property item(ByVal row_i As Int32, ByVal col_j As Int32) As mpf_t
    Get
        Dim m1 As New mpf_t
        m1.PyPtr = GetMatrixItem(PyPtr, row_i, col_j)
        Return m1
    End Get

    Set(ByVal m1 As mpf_t)
        PyPtr = SetMatrixItem(PyPtr, row_i, col_j, m1.PyPtr)
    End Set

  End Property

'  ''' <summary>
'  ''' Gets or Sets a block
'  ''' </summary>
'  ''' <param name="i"></param>
'  ''' <param name="j"></param>
'  ''' <param name="p"></param>
'  ''' <param name="q"></param>
'  Public Property block(ByVal i As Int32, ByVal j As Int32, ByVal p As Int32, ByVal q As Int32) As mpfr_mat_t
'    Get
'      Dim m1 As New mpfr_mat_t
'      Lib_Eigen_Mpfr_Get_Block(m1.MpfrMatPtr, i, j, p, q, MpfrMatPtr)
'      Return m1
'
'    End Get
'
'    Set(ByVal m1 As mpfr_mat_t)
'      Lib_Eigen_Mpfr_Put_Block(m1.MpfrMatPtr, i, j, p, q, MpfrMatPtr)
'    End Set
'
'  End Property
'
'
'  
'  Public Overrides Function ToString() As String
'    Return "MpfrMatPtr"
'  End Function
'  
'  
'  Public Function str() As String(,)
'      Dim res(Rows-1, Cols-1) As String
'      Dim m1 As New mpfr_t
'      For i As Integer = 0 To Rows-1
'          For j As Integer = 0 To Cols-1
'            Lib_Eigen_Mpfr_GetCoeff2(m1.MpfrPtr, i, j, MpfrMatPtr)
'            res(i,j) = m1.ToString()
'          Next j
'      Next i
'      Return res
'  End Function
'  
'  
'    
'  Public Function mat() As mpfr_t(,)
'      Dim res(Rows-1, Cols-1) As mpfr_t
'      Dim m1 As New mpfr_t
'      For i As Integer = 0 To Rows-1
'          For j As Integer = 0 To Cols-1
'            res(i,j) = New mpfr_t()
'            Lib_Eigen_Mpfr_GetCoeff2(res(i,j).MpfrPtr, i, j, MpfrMatPtr)
'          Next j
'      Next i
'      Return res
'  End Function
'
'
'  Public Sub print(Title As String)
'      Lib_Eigen_Mpfr_Print(Title, MpfrMatPtr)  
'  End Sub
'  
'
'  Public Sub Random(ByVal n As Int32, ByVal m As Int32)
'      Lib_Eigen_Mpfr_SetRandom(MpfrMatPtr, n, m)  
'  End Sub
'  
'
'  Public Sub RandomSymmetric(ByVal n As Int32, ByVal m As Int32)
'      Lib_Eigen_Mpfr_SetRandomSymmetric(MpfrMatPtr, n, m)  
'  End Sub
'  
'  
'  
'  
'  
'  Public Function solve(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 0)
'    Return x
'  End Function
'
'  
'  Public Function SolveFullPivLU(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 0)
'    Return x
'  End Function
'
'  
'  Public Function SolveLDLT(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 1)
'    Return x
'  End Function
'
'
'  
'  Public Function SolveColPivQR(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 2)
'    Return x
'  End Function
'
'
'
'  Public Function SolveFullPivQR(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 3)
'    Return x
'  End Function
'
'
'
'  Public Function SolveSVD(b As mpfr_mat_t) As mpfr_mat_t
'    Dim x As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Solve2(x.MpfrMatPtr, MpfrMatPtr, b.MpfrMatPtr, 4)
'    Return x
'  End Function
'
'
'
'  Public Function inverse() As mpfr_mat_t
'    Dim m3 As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Inverse(m3.MpfrMatPtr, MpfrMatPtr, 0)
'    Return m3
'  End Function
'  
'  
'  
'  Public Function InverseFullPivLU() As mpfr_mat_t
'    Dim m3 As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Inverse(m3.MpfrMatPtr, MpfrMatPtr, 0)
'    Return m3
'  End Function
'  
'  
'  Public Function InverseColPivQR() As mpfr_mat_t
'    Dim m3 As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Inverse(m3.MpfrMatPtr, MpfrMatPtr, 2)
'    Return m3
'  End Function
'  
'  
'  Public Function InverseFullPivQR() As mpfr_mat_t
'    Dim m3 As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_Inverse(m3.MpfrMatPtr, MpfrMatPtr, 2)
'    Return m3
'  End Function
'  
'  
'  Public Function Det() As mpfr_t
'      Dim m3 As New mpfr_mat_t(1,1)
'      Dim d As New mpfr_t
'      Lib_Eigen_Mpfr_Det(m3.MpfrMatPtr, MpfrMatPtr, 0)
'      d = m3(0,0)
'      Return d
'  End Function
'  
'  
'  Public Function Rank() As Int32
'    Return Lib_Eigen_Mpfr_Rank(MpfrMatPtr, 0)
'  End Function
'  
'  
'  
'  
'  Public Function SymmetricEigenvalues() As mpfr_mat_t
'    Dim m3 As New mpfr_mat_t()
'    Lib_Eigen_Mpfr_SelfAdjointEigenValues(m3.MpfrMatPtr, MpfrMatPtr)
'    Return m3
'  End Function
'  
'  
'  Public Function SubtractFromDiagonal(lambda As mpfr_t) As mpfr_mat_t
'      Dim n As Int32 = rows()
'      Dim m3 As New mpfr_mat_t(n,n)
'      For i As Int32 =0 To n-1
'      For j As Int32 =0 To n-1
'          m3(i,j) = item(i,j)
'      Next
'      Next
'      For i As Int32 =0 To n-1
'          m3(i,i) = m3(i,i) - lambda
'      Next
'    Return m3
'  End Function
'  
'
'
'  Public Sub resize(ByVal rows As Int32, ByVal cols As Int32)
'      Lib_Eigen_Mpfr_Resize(MpfrMatPtr, rows, cols)  
'  End Sub
'  
'  
'  
'  Public Sub conservative_resize(ByVal rows As Int32, ByVal cols As Int32)
'      Lib_Eigen_Mpfr_Conservative_Resize(MpfrMatPtr, rows, cols)  
'  End Sub
'  
'  
'    Public  Function GT_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_GT_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'    
'  Public  Function LT_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_LT_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'  
'  Public  Function LE_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_LE_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'  
'  Public  Function GE_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_GE_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'  
'  Public  Function EQ_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_EQ_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'  
'  Public  Function NE_count(ByVal Y As mpfr_mat_t) As UInt32
'       Return Lib_Eigen_Mpfr_NE_Count(MpfrMatPtr, Y.MpfrMatPtr)
'  End Function
'  
'  
'  
'
'    Public Shared Operator =(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_EQ_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'    Public Shared Operator <>(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_NE_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'    Public Shared Operator <=(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_LE_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'    Public Shared Operator <(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_LT_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'    Public Shared Operator >=(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_GE_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'    Public Shared Operator >(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As Boolean
'        Return (Lib_Eigen_Mpfr_GT_Count(m1.MpfrMatPtr, m2.MpfrMatPtr) = m1.size)
'    End Operator
'
'
'
'
'    Public Shared Operator +(ByVal m1 As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        m3 = m1
'        Return m3
'    End Operator
'
'
'    Public Shared Operator -(ByVal m1 As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
''        mpz.Lib_Mpz_Neg(m3.MpzPtr, m1.MpzPtr)
'        Return m3
'    End Operator
'
'
'
'    '***********************************************************************
'
'
'    Public Shared Operator +(ByVal M1 As mpfr_mat_t, ByVal M2 As mpfr_mat_t) As mpfr_mat_t
'        Dim Res As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_MatAdd(Res.MpfrMatPtr, M1.MpfrMatPtr, M2.MpfrMatPtr)
'        Return Res
'    End Operator
'
'
'    Public Shared Operator +(ByVal M1 As mpfr_mat_t, ByVal m2 As mpfr_t) As mpfr_mat_t
'        Dim Res As New mpfr_mat_t()
'        Dim T As New mpfr_mat_t(m2)
'        Lib_Eigen_Mpfr_Mat_Add_Scalar(Res.MpfrMatPtr, M1.MpfrMatPtr, T.MpfrMatPtr)
'        Return Res
'    End Operator
'    
'    
'    
'
'    Public Shared Operator -(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_MatSub(m3.MpfrMatPtr, m1.MpfrMatPtr, m2.MpfrMatPtr)
'        Return m3
'    End Operator
'
'
'    Public Shared Operator -(ByVal M1 As mpfr_mat_t, ByVal m2 As mpfr_t) As mpfr_mat_t
'        Dim Res As New mpfr_mat_t()
'        Dim T As New mpfr_mat_t(m2)
'        Lib_Eigen_Mpfr_Mat_Sub_Scalar(Res.MpfrMatPtr, M1.MpfrMatPtr, T.MpfrMatPtr)
'        Return Res
'    End Operator
'    
'    
'    
'
'    Public Shared Operator *(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_MatMul(m3.MpfrMatPtr, m1.MpfrMatPtr, m2.MpfrMatPtr)
'        Return m3
'    End Operator
'
'
'    Public Shared Operator *(ByVal M1 As mpfr_mat_t, ByVal m2 As mpfr_t) As mpfr_mat_t
'        Dim Res As New mpfr_mat_t()
'        Dim T As New mpfr_mat_t(m2)
'        Lib_Eigen_Mpfr_Mat_Mul_Scalar(Res.MpfrMatPtr, M1.MpfrMatPtr, T.MpfrMatPtr)
'        Return Res
'    End Operator
'  
'      Public Function cwiseProduct(x As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_Mat_cwiseProduct(m3.MpfrMatPtr, x.MpfrMatPtr, MpfrMatPtr)
'        Return m3
'      End Function
'  
'      Public Function dotProduct(x As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_MatDotProduct(m3.MpfrMatPtr, x.MpfrMatPtr, MpfrMatPtr)
'        Return m3
'      End Function
'
'
'
'    Public Shared Operator /(ByVal m1 As mpfr_mat_t, ByVal m2 As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Dim m4 As New mpfr_mat_t()
'        m4 = m2.inverse()
'        Lib_Eigen_Mpfr_MatMul(m3.MpfrMatPtr, m1.MpfrMatPtr, m4.MpfrMatPtr)
'        Return m3
'    End Operator
'
'
'    Public Shared Operator /(ByVal M1 As mpfr_mat_t, ByVal m2 As mpfr_t) As mpfr_mat_t
'        Dim Res As New mpfr_mat_t()
'        Dim T As New mpfr_mat_t(m2)
'        Lib_Eigen_Mpfr_Mat_Div_Scalar(Res.MpfrMatPtr, M1.MpfrMatPtr, T.MpfrMatPtr)
'        Return Res
'    End Operator
'  
'      Public Function cwiseQuotient(x As mpfr_mat_t) As mpfr_mat_t
'        Dim m3 As New mpfr_mat_t()
'        Lib_Eigen_Mpfr_Mat_cwiseQuotient(m3.MpfrMatPtr, x.MpfrMatPtr, MpfrMatPtr)
'        Return m3
'      End Function
'  
'  

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




  Public Class mpf_mat

    

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
      '	    Dim o1 As mpf_mat_t = CNum(n1)
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
  
  