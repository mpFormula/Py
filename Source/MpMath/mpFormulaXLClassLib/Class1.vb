Imports System
Imports MpMath
Imports Microsoft.Scripting
Imports IronPython.Runtime

Imports Office = NetOffice.OfficeApi 
Imports Excel = NetOffice.ExcelApi






Public Class xl
    
  Shared Sub New()
      Dim Result As Double = 0.0
      Try        
        Result = xlFunc().Log10(1.0)
      Catch ex As Exception
        'Throw
      End Try
  End Sub
  
  
  Protected Overrides Sub Finalize()
      Try        
        xlFunc().Dispose()
        getxlApp().Quit() 
        getxlApp().Dispose()        
      Catch ex As Exception
        'Throw
      End Try
      MyBase.Finalize()
  End Sub

    
    Shared Function getxlApp() As Excel.Application
		Static xlInstance As Excel.Application = Nothing
		If  IsNothing(xlInstance) Then
			Try
				xlInstance = New Excel.Application
			Catch ex As Exception
'				ReportException(ex)
			End Try
		End If
		Return xlInstance
    End Function
    
    
	Shared Function xlFunc() As Excel.WorksheetFunction
		Static wsInstance As Excel.WorksheetFunction = Nothing
		If  IsNothing(wsInstance) Then
			Try
				wsInstance = getxlApp().WorksheetFunction
			Catch ex As Exception
'				ReportException(ex)
			End Try
		End If
		Return wsInstance
	End Function
	
	
	
	
'No MATCH
    Shared Function INT(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = Math.Truncate(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MOD_(x As Double, y As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = x Mod y
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SIGN(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = Math.Sign(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function TRUNC(Number As Double, Digits As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = Math.Truncate(Number)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    

	
	
' Real from complex   
    Shared Function ABS(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImAbs(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COS(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImCos(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EXP(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImExp(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SIN(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImSin(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SQRT(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImSqrt(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function TAN(x As Double) As Double
        Dim Result As Double = 0.0
        Dim Results As String = ""
        Try
            Results = xlFunc().ImTan(x)
            Result = Convert.ToDouble(Results)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    
    
'    Original call
    Shared Function ACOS(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Acos(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    Shared Function ACOSH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Acosh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ACOT(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Acot(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ACOTH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Acoth(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ASIN(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Asin(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ARABIC(s As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Arabic(s)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ASINH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Asinh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ATAN(x As Double) As Double
        Dim Result As Double = 0.0
        Dim y As Double = x / Math.Sqrt(1 + x * x)
        Try        
            Result = xlFunc().Asin(y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ATAN2(x As Double, y As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Atan2(x, y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ATANH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Atanh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BASE(Number As Double, Radix As Double, MinLength As Integer) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Base(Number, Radix, MinLength)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CEILING(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Ceiling(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CEILING_PRECISE(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Ceiling_Precise(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CEILING_MATH(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Ceiling_Math(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COMBIN(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Combin(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COMBINA(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Combina(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COSH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Cosh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COT(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Cot(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CSC(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Csc(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CSCH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Csch(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DECIMAL_(Text As String, Radix As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Decimal(Text, Radix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function    
    
    
    Shared Function DEGREES(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Degrees(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EVEN(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Even(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FACT(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Fact(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FACTDOUBLE(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().FactDouble(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FLOOR(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Floor(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FLOOR_PRECISE(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Floor_Precise(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FLOOR_MATH(Number As Double, Signiﬁcance As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Floor_Math(Number, Signiﬁcance)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GCD(n1 As Double, n2 As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Gcd(n1, n2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LCM(n1 As Double, n2 As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Lcm(n1, n2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LN(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Ln(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOG(x As Double, Base As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Log(x, Base)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOG10(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Log10(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MDETERM(Matrix As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().MDeterm(Matrix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MINVERSE(Matrix As Object) As Object
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().MInverse(Matrix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MMULT(MatrixA As Object, MatrixB As Object) As Object
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().MMult(MatrixA, MatrixB)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MUNIT(Matrix As Object) As Object
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Munit(Matrix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MROUND(Number As Double, Multiple As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().MRound(Number, Multiple)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MULTINOMIAL(Matrix As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().MultiNomial(Matrix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ODD(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().odd(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PI() As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Pi()
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function POWER(x As Double, y As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Power(x, y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PRODUCT(Matrix As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Product(Matrix)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function QUOTIENT(x As Double, y As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Quotient(x, y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RADIANS(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Radians(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RAND() As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().RandBetween(0.0, 1.0)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RANDBETWEEN(Bottom As Double, Top As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().RandBetween(Bottom, Top)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ROMAN(Number As Double, Form As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Roman(Number, Form)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ROUND(Number As Double, Digits As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Round(Number, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ROUNDDOWN(Number As Double, Digits As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().RoundDown(Number, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ROUNDUP(Number As Double, Digits As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().RoundUp(Number, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SERIESSUM(x As Double, n As Integer, m As Integer, a As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SeriesSum(x, n, m, a)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SEC(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Sec(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SECH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Sech(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SINH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Sinh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SQRTPI(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SqrtPi(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMPRODUCT(x As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumProduct(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMSQ(x As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumSq(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMX2MY2(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumX2MY2(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMX2PY2(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumX2PY2(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMXMY2(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumXMY2(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function TANH(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Tanh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    
    
    
    Shared Function BESSELJ(x As Double, nu As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().BesselJ(x, nu)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BESSELY(x As Double, nu As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().BesselY(x, nu)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BESSELI(x As Double, nu As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().BesselI(x, nu)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BESSELK(x As Double, nu As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().BesselK(x, nu)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    Shared Function BIN2DEC(Number As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bin2Dec(Number)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BIN2HEX(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bin2Hex(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BIN2OCT(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bin2Oct(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DEC2BIN(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Dec2Bin(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DEC2HEX(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Dec2Hex(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DEC2OCT(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Dec2Oct(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function HEX2BIN(Number As Double, Places As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Hex2Bin(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function HEX2DEC(Number As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Hex2Dec(Number)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function HEX2OCT(Number As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Hex2Dec(Number)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function OCT2BIN(Number As Double, Places As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Oct2Bin(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function OCT2DEC(Number As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Oct2Dec(Number)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function OCT2HEX(Number As Double, Places As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Oct2Hex(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BITAND(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bitand(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BITLSHIFT(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bitlshift(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BITOR(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bitor(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BITRSHIFT(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bitrshift(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BITXOR(Number As Double, Places As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Bitxor(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function COMPLEX(Number As Double, Places As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Complex(Number, Places)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function DELTA(Number1 As Double, Number2 As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Delta(Number1, Number2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function GESTEP(Number As Double, Step1 As Double) As String
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().GeStep(Number, Step1)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ERF(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Erf(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ERFC(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ErfC(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GAMMA(x As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Gamma(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    
    
    
    
    
    Shared Function IMABS(x As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ImAbs(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function IMARGUMENT(x As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ImArgument(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
        
    Shared Function IMREAL(x As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ImReal(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function IMAGINARY(x As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ImAbs(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCONJUGATE(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImConjugate(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCOS(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImCos(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCOSH(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImCosh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCOT(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImCot(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCSC(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImCsc(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMCSCH(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImCsch(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMDIV(x1 As String, x2 As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImDiv(x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    Shared Function IMEXP(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImExp(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMLN(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImLn(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMLOG10(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImLog10(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMLOG2(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImLog2(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMPOWER(x1 As String, x2 As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImPower(x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    Shared Function IMPRODUCT(x1 As String, x2 As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImProduct(x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMSEC(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSec(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMSECH(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSech(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMSIN(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSin(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMSINH(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSinh(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function IMSQRT(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSqrt(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function IMSUB(x1 As String, x2 As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSub(x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

    
    Shared Function IMSUM(x1 As String, x2 As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImSum(x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function IMTAN(x As String) As String
        Dim Result As String = "Error"
        Try        
            Result = xlFunc().ImTan(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
'  Statistical Functions    
    
    
    Shared Function BETADIST(x As Double, a As Double, b As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().BetaDist(x, a, b)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BETA_DIST(x As Double, a As Double, b As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Beta_Dist(x, a, b, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BETAINV(Prob As Double, a As Double, b As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().BetaInv(Prob, a, b)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function BETA_INV(Prob As Double, a As Double, b As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Beta_Inv(Prob, a, b)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

    
    Shared Function BINOMDIST(x As Double, n As Double, p As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().BinomDist(x, n, p, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BINOM_DIST(x As Double, n As Double, p As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Binom_Dist(x, n, p, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BINOM_DIST_RANGE(n As Double, p As Double, x1 As Double, x2 As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Binom_Dist_Range(n, p, x1, x2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CRITBINOM(n As Double, p As Double, Alpha As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().CritBinom(n, p, Alpha)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function BINOM_INV(n As Double, p As Double, Alpha As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Binom_Inv(n, p, Alpha)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CHIDIST(x As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiDist(x, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function CHISQDIST(x As Double, deg_freedom As Double, Tails As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiSq_Dist(x, deg_freedom, Tails)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function CHISQ_DIST(x As Double, deg_freedom As Double, Tails As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiSq_Dist(x, deg_freedom, Tails)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

    
    Shared Function CHISQ_DIST_RT(x As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiSq_Dist_RT(x, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CHIINV(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiInv(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CHISQ_INV(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiSq_Inv(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CHISQ_INV_RT(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ChiSq_Inv_RT(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EXPONDIST(x As Double, lambda As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().ExponDist(x, lambda, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EXPON_DIST(x As Double, lambda As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Expon_Dist(x, lambda, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FDIST(x As Double, m As Double, n As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().FDist(x, m, n)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function F_DIST(x As Double, m As Double, n As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().F_Dist(x, m, n, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function F_DIST_RT(x As Double, m As Double, n As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().F_Dist_RT(x, m, n)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FINV(Prob As Double, m As Double, n As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().FInv(Prob, m, n)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function F_INV(Prob As Double, m As Double, n As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().F_Inv(Prob, m, n)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function F_INV_RT(Prob As Double, m As Double, n As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().F_Inv_RT(Prob, m, n)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GAMMADIST(x As Double, a As Double, b As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().GammaDist(x, a, b, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GAMMA_DIST(x As Double, a As Double, b As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Gamma_Dist(x, a, b, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GAMMAINV(Prob As Double, a As Double, b As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().GammaInv(Prob, a, b)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GAMMA_INV(Prob As Double, a As Double, b As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Gamma_Inv(Prob, a, b)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function HYPGEOMDIST(x As Double, n As Double, M As Double, NN As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().HypGeomDist(x, n, M, NN)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    Shared Function HYPGEOM_DIST(x As Double, n As Double, M As Double, NN As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().HypGeom_Dist(x, n, M, NN, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOGNORMDIST(x As Double, mean As Double, stdev As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().LogNormDist(x, mean, stdev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOGNORM_DIST(x As Double, mean As Double, stdev As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().LogNorm_Dist(x, mean, stdev, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOGINV(Prob As Double, mean As Double, stdev As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().LogInv(Prob, mean, stdev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LOGNORM_INV(Prob As Double, mean As Double, stdev As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().LogNorm_Inv(Prob, mean, stdev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    Shared Function NEGBINOMDIST(x As Double, r As Double, p As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NegBinomDist(x, r, p)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    Shared Function NEGBINOM_DIST(x As Double, r As Double, p As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NegBinom_Dist(x, r, p, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORMDIST(x As Double, mean As Double, stdev As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NormDist(x, mean, stdev, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORM_DIST(x As Double, mean As Double, stdev As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Norm_Dist(x, mean, stdev, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORMSDIST(x As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NormSDist(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    

    Shared Function NORM_S_DIST(x As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Norm_S_Dist(x, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORMINV(Prob As Double, mean As Double, stdev As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NormInv(Prob, mean, stdev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORM_INV(Prob As Double, mean As Double, stdev As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Norm_Inv(Prob, mean, stdev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORMSINV(x As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().NormSInv(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NORM_S_INV(x As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Norm_S_Inv(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function POISSON(x As Double, deg_freedom As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Poisson(x, deg_freedom, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function POISSON_DIST(x As Double, deg_freedom As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Poisson_Dist(x, deg_freedom, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function TDIST(x As Double, deg_freedom As Double, Tails As Integer) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().TDist(x, deg_freedom, Tails)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function T_DIST(x As Double, deg_freedom As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().T_Dist(x, deg_freedom, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    

        
    Shared Function T_DIST_RT(x As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().T_Dist_RT(x, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function T_DIST_2T(x As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().T_Dist_2T(x, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function TINV(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().TInv(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function T_INV(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().T_Inv(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function T_INV_2T(Prob As Double, deg_freedom As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().T_Inv_2T(Prob, deg_freedom)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function WEIBULL(x As Double, a As Double, b As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Weibull(x, a, b, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function WEIBULL_DIST(x As Double, a As Double, b As Double, Cumulative As Boolean) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Weibull_Dist(x, a, b, Cumulative)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    
    
    
    
    
    
    '   Statistical Functions 
    
    
    
    
    Shared Function COUNT(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Count(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUNTA(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().CountA(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUNTBLANK(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().CountBlank(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUNTIF(x As Object, Criteria As String) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().CountIf(x, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUNTIFS(x As Object, Criteria As String) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().CountIfs(x, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FREQUENCY(DataArray As Object, BinsArray As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Frequency(DataArray, BinsArray)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CONVERT_(Number As Double, FromUnit As String, ToUnit As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Convert(Number, FromUnit, ToUnit)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STANDARDIZE(Number As Double, Mean As Double, StDev As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Standardize(Number, Mean, StDev)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function TRIMMEAN(Data As Object, Percent As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().TrimMean(Data, Percent)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUM(x As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Sum(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMA(x As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Sum(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMIF(x As Object, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumIf(x, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUMIFS(x As Object, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().SumIf(x, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AVERAGE(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Average(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AVERAGEA(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Average(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AVERAGEIF(x As Object, Criteria As String) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().AverageIf(x, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AVERAGEIFS(x As Object, CriteriaRange As Object, Criteria2 As String) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().AverageIfs(x, CriteriaRange, Criteria2)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function GEOMEAN(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().GeoMean(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function HARMEAN(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().HarMean(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VAR(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VAR_S(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var_S(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VARA(x As Object) As Double
' This needs pre-processing to convert text and boolean        
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VARP(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VAR_P(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function VARPA(x As Object) As Double
' This needs pre-processing to convert text and boolean
        
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Var_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEV(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEV_S(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev_S(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEVA(x As Object) As Double
' This needs pre-processing to convert text and boolean        
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEVP(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEV_P(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STDEVPA(x As Object) As Double
' This needs pre-processing to convert text and boolean
        
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Stdev_P(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AVEDEV(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().AveDev(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DEVSQ(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().DevSq(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SKEW(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Skew(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SKEW_P(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Skew_p(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function KURT(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Skew(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MIN(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Min(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MINA(x As Object) As Double
' This needs pre-processing to convert text and boolean
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Min(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MAX(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Max(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MAXA(x As Object) As Double
' This needs pre-processing to convert text and boolean
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Max(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MEDIAN(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Median(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MODE(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Mode(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MODE_SNGL(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Mode_Sngl(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MODE_MULT(x As Object) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Mode_Mult(x)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function LARGE(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Large(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SMALL(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Small(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTILE(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Percentile(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTILE_INC(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Percentile_Inc(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTILE_EXC(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Percentile_Exc(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTRANK(Data As Object, x As Double, Digits As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().PercentRank(Data, x, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTRANK_INC(Data As Object, x As Double, Digits As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().PercentRank_Inc(Data, x, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PERCENTRANK_EXC(Data As Object, x As Double, Digits As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().PercentRank_Exc(Data, x, Digits)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function QUARTILE(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Quartile(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function QUARTILE_INC(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Quartile_Inc(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function QUARTILE_EXC(x As Object, k As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Quartile_Exc(x, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RANK(x As Double, Data As Object, order As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Rank(x, Data, order)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RANK_EQ(x As Double, Data As Object, order As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Rank_Eq(x, Data, order)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RANK_AVG(x As Double, Data As Object, order As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Rank_Avg(x, Data, order)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PROB(XRange As Object, ProbRange As Object, LowerLimit As Double, UpperLimit As Double) As Double
        Dim Result As Double = Double.NaN
        Try        
            Result = xlFunc().Prob(XRange, ProbRange, LowerLimit, UpperLimit)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SUBTOTAL(FunctionNum As Integer, Data As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Subtotal(FunctionNum, Data)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function AGGREGATE(FunctionNum As Integer, Options As Integer, Data As Object, k As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Aggregate(FunctionNum, Options, Data, k)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CONFIDENCE(Alpha As Double, StDev As Double, N As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Confidence(Alpha, StDev, N)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CONFIDENCE_NORM(Alpha As Double, StDev As Double, N As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Confidence_Norm(Alpha, StDev, N)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CONFIDENCE_T(Alpha As Double, StDev As Double, N As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Confidence_T(Alpha, StDev, N)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ZTEST(Data As Object, Mean As Double, Sigma As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ZTest(Data, Mean, Sigma)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function Z_TEST(Data As Object, Mean As Double, Sigma As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Z_Test(Data, Mean, Sigma)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function TTEST(X As Object, Y As Object, Tails As Double, Type As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().TTest(X, Y, Tails, Type)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function T_TEST(X As Object, Y As Object, Tails As Double, Type As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().T_Test(X, Y, Tails, Type)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FTEST(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().FTest(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function F_TEST(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().F_Test(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function CHITEST(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ChiTest(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CHISQ_TEST(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().ChiSq_Test(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COVAR(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Covar(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COVARIANCE_S(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Covariance_S(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COVARIANCE_P(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Covariance_P(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function CORREL(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Correl(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function PEARSON(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Pearson(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function RSQ(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().RSq(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FISHER(X As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Fisher(X)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FISHERINV(X As Double) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().FisherInv(X)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function INTERCEPT(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Intercept(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function SLOPE(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Slope(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function FORECAST(x1 As Double, X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Forecast(x1, X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function STEYX(X As Object, Y As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().StEyx(X, Y)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DGET(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DGet(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DPRODUCT(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DProduct(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DCOUNT(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DCount(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DCOUNTA(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DCountA(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DSUM(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DSum(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DAVERAGE(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DAverage(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function DVAR(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DVar(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function

        
    Shared Function DSTDEV(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DStDev(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function DSTDEVP(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DStDevP(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function DMIN(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DMin(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
        
    Shared Function DMAX(Table As Object, Field As String, Criteria As String) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().DMax(Table, Field, Criteria)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    
    
    
'    Date, Time and Financial Functions
    
    
    '    Missing: SECOND, MINUTE, HOUR, DAY, MONTH, YEAR, DATE, DATEVALUE, NOW, TIME, TIMEVALUE, TODAY
    
'    Only Calc :EASTERSUNDAY
    
    Shared Function DAYS(EndDatevalue As Object, StartDatevalue As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Days(EndDatevalue, StartDatevalue)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function WEEKDAY(Datevalue As Object, ReturnType As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Weekday(Datevalue, ReturnType)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function WEEKNUM(Datevalue As Object, ReturnType As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().WeekNum(Datevalue, ReturnType)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function ISOWEEKNUM(Datevalue As Object, ReturnType As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().IsoWeekNum(Datevalue, ReturnType)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EDATE(StartDate As Object, Months As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().EDate(StartDate, Months)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function EOMONTH(StartDate As Object, Months As Integer) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().EoMonth(StartDate, Months)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function WORKDAY(StartDate As Object, Days As Integer, Holidays As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().WorkDay(StartDate, Days, Holidays)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function WORKDAY_INTL(StartDate As Object, Days As Integer, Weekend As Integer, Holidays As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().WorkDay_Intl(StartDate, Days, Weekend, Holidays)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DAYS360(StartDate As Object, EndDate As Object, Method As Boolean) As Double
        ' Note: Should have 3 arguments
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().Days360(StartDate, EndDate)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NETWORKDAYS(StartDate As Object, EndDate As Object, Holidays As Object) As Double
        ' Note: Should have 3 arguments
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().NetworkDays(StartDate, EndDate, Holidays)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function NETWORKDAYS_INTL(StartDate As Object, EndDate As Object, Weekend As Object) As Double
        Dim Result As Double = 0.0
        Try        
            Result = xlFunc().NetworkDays_Intl(StartDate, EndDate, Weekend)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function YEARFRAC(StartDate As Object, EndDate As Object, Basis As Object) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().YearFrac(StartDate, EndDate, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPDAYBS(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupDayBs(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPDAYS(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupDays(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPDAYSNC(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupDaysNc(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPNCD(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupNcd(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPNUM(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupNum(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function COUPPCD(SettlementDate As Object, MaturityDate As Object, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().CoupPcd(SettlementDate, MaturityDate, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function DURATION(SettlementDate As Object, MaturityDate As Object, Coupon As Integer, Yield As Integer, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().Duration(SettlementDate, MaturityDate, Coupon, Yield, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    
    
    Shared Function MDURATION(SettlementDate As Object, MaturityDate As Object, Coupon As Integer, Yield As Integer, Frequency As Object, Basis As Integer) As Double
        Dim Result As Double = 0.0
        Try
            Result = xlFunc().MDuration(SettlementDate, MaturityDate, Coupon, Yield, Frequency, Basis)
        Catch ex As Exception
            'Throw
        End Try
        Return Result
    End Function
    

  Shared Function ACCRINT(Issue As Object, FirstInterest As Object,
                          Settlement As Integer, Rate As Integer, Par As Double, Frequency As Integer,
                          Basis As Integer, CalcMethod As Boolean) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().AccrInt(Issue, FirstInterest, Settlement, Rate, Par, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function ACCRINTM(Issue As Object, Settlement As Integer, Rate As Integer, Par As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().AccrIntM(Issue, Settlement, Rate, Par, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function DISC(Settlement As Object, Maturity As Integer, Price As Integer, Redemption As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Disc(Settlement, Maturity, Price, Redemption, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function INTRATE(Settlement As Object, Maturity As Integer, Investment As Integer, Redemption As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().IntRate(Settlement, Maturity, Investment, Redemption, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function ODDFPRICE(Settlement As Object, Maturity As Object, Issue As Object,
                          FirstCoupon As Object, Rate As Double, Yld As Double, Redemption As Double,
                          Frequency As Integer, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().OddFPrice(Settlement, Maturity, Issue, FirstCoupon, Rate, Yld, Redemption, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function ODDFYIELD(Settlement As Object, Maturity As Object, Issue As Object,
                          FirstCoupon As Object, Rate As Double, Pr As Double, Redemption As Double,
                          Frequency As Integer, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().OddFYield(Settlement, Maturity, Issue, FirstCoupon, Rate, Pr, Redemption, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function ODDLPRICE(Settlement As Object, Maturity As Object,
                          LastInterest As Object, Rate As Double, Yld As Double, Redemption As Double,
                          Frequency As Integer, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().OddLPrice(Settlement, Maturity, LastInterest, Rate, Yld, Redemption, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function ODDLYIELD(Settlement As Object, Maturity As Object,
                          LastInterest As Object, Rate As Double, Pr As Double, Redemption As Double,
                          Frequency As Integer, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().OddLYield(Settlement, Maturity, LastInterest, Rate, Pr, Redemption, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function PRICE(Settlement As Object, Maturity As Object,
                          Rate As Double, Yld As Double, Redemption As Double,
                          Frequency As Integer, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Price(Settlement, Maturity, Rate, Yld, Redemption, Frequency, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function PRICEDISC(Settlement As Object, Maturity As Object,
                          Discount As Double, Redemption As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().PriceDisc(Settlement, Maturity, Discount, Redemption, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function PRICEMAT(Settlement As Object, Maturity As Object, Issue As Object,
                          Rate As Double, Yld As Double, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().PriceMat(Settlement, Maturity, Issue, Rate, Yld, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function RECEIVED(Settlement As Object, Maturity As Object,
                          Investment As Double, Discount As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Received(Settlement, Maturity, Investment, Discount, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function YIELDDISC(Settlement As Object, Maturity As Object,
                          Pr As Double, Redemption As Double,
                          Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().YieldDisc(Settlement, Maturity, Pr, Redemption, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function YIELDMAT(Settlement As Object, Maturity As Object, Issue As Object, Rate As Double,
                          Pr As Double, Basis As Integer) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().YieldMat(Settlement, Maturity, Issue, Rate, Pr, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function TBILLEQ(Settlement As Object, Maturity As Object, Discount As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().TBillEq(Settlement, Maturity, Discount)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function TBILLPRICE(Settlement As Object, Maturity As Object, Discount As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().TBillPrice(Settlement, Maturity, Discount)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function TBILLYIELD(Settlement As Object, Maturity As Object, Pr As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().TBillYield(Settlement, Maturity, Pr)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function DDB(Cost As Double, Salvage As Double, Life As Double, Period As Double, Factor As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Ddb(Cost, Salvage, Life, Period, Factor)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function SLN(Cost As Double, Salvage As Double, Life As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Sln(Cost, Salvage, Life)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function SYD(Cost As Double, Salvage As Double, Life As Double, Period As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Syd(Cost, Salvage, Life, Period)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function DB(Cost As Double, Salvage As Double, Life As Double, Period As Double, Month As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Db(Cost, Salvage, Life, Period, Month)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function VDB(Cost As Double, Salvage As Double, Life As Double, StartPeriod As Double,
                      EndPeriod As Double, Factor As Double, NoSwitch As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Vdb(Cost, Salvage, Life, StartPeriod, EndPeriod, Factor, NoSwitch)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function AMORLINC(Cost As Double, DatePurchased As Object, FirstPeriod As Object,
                           Salvage As Double, Period As Double, Rate As Double, Basis As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().AmorLinc(Cost, DatePurchased, FirstPeriod, Salvage, Period, Rate, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function AMORDEGRC(Cost As Double, DatePurchased As Object, FirstPeriod As Object,
                           Salvage As Double, Period As Double, Rate As Double, Basis As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().AmorDegrc(Cost, DatePurchased, FirstPeriod, Salvage, Period, Rate, Basis)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function FV(Rate As Double, Nper As Double, Pmt As Double, PV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Fv(Rate, Nper, Pmt, PV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function PV(Rate As Double, Nper As Double, Pmt As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Pv(Rate, Nper, Pmt, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function PMT(Rate As Double, Nper As Double, PV As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Pmt(Rate, Nper, PV, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function NPER(Rate As Double, Pmt As Double, PV As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().NPer(Rate, Pmt, PV, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function PDURATION(Rate As Double, PV As Double, FV As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().PDuration(Rate, PV, FV)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function RATE(Nper As Double, Pmt As Double, PV As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Rate(Nper, Pmt, PV, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function IPMT(Rate As Double, Per As Double, Nper As Double, Pmt As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Ipmt(Nper, Per, Nper, Pmt, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function PPMT(Rate As Double, Per As Double, Nper As Double, PV As Double, FV As Double, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Ppmt(Rate, Per, Nper, PV, FV, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function CUMIPMT(Rate As Double, Nper As Double, PV As Double, StartPeriod As Object,
                          EndPeriod As Object, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().CumIPmt(Rate, Nper, PV, StartPeriod, EndPeriod, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function CUMPRINC(Rate As Double, Nper As Double, PV As Double, StartPeriod As Object,
                          EndPeriod As Object, Type As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().CumPrinc(Rate, Nper, PV, StartPeriod, EndPeriod, Type)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function EFFECT(NominalRate As Double, Npery As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Effect(NominalRate, Npery)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function NOMINAL(EﬀectiveRate As Double, Npery As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Nominal(EﬀectiveRate, Npery)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function FVSCHEDULE(Principal As Double, Schedule As Object) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().FVSchedule(Principal, Schedule)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function ISPMT(Rate As Double, Per As Double, Nper As Double, PV As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Ispmt(Rate, Per, Nper, PV)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function IRR(Values As Object, Guess As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Irr(Values, Guess)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function RRI(Nper As Double, PV As Double, FV As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Rri(Nper, PV, FV)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function



  Shared Function MIRR(Values As Object, FinanceRate As Double, ReinvestRate As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().MIrr(Values, FinanceRate, ReinvestRate)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function NPV(Rate As Double, Values As Object) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Npv(Rate, Values)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function XIRR(Values As Object, Dates As Object, Guess As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Xirr(Values, Dates, Guess)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function XNPV(Rate As Double, Values As Object) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().Xnpv(Rate, Values)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function DOLLARDE(FractionalDollar As Double, Fraction As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().DollarDe(FractionalDollar, Fraction)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function


  Shared Function DOLLARFR(DecimalDollar As Double, Fraction As Double) As Double
    Dim Result As Double = 0.0
    Try
      Result = xlFunc().DollarFr(DecimalDollar, Fraction)
    Catch ex As Exception
      'Throw
    End Try
    Return Result
  End Function






End Class
  
