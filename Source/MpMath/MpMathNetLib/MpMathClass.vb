Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Text
Imports System.IO

Imports IronPython.Hosting
Imports Microsoft.Scripting
Imports Microsoft.Scripting.Hosting
Imports Microsoft.Win32
Imports IronPython.Runtime


Public Class MpMathClass
	

    Public Function GetFunction00XL(FunctionName As String,  Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction00(dps, FunctionName)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction01XL(FunctionName As String, Parameter1 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction01(dps, FunctionName, Parameter1)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction02XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction02(dps, FunctionName, Parameter1, Parameter2)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction03XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction03(dps, FunctionName, Parameter1, Parameter2, Parameter3)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction04XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction04(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction05XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction05(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction06XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction06(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction07XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction08XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
    Public Function GetFunction09XL(FunctionName As String, Parameter1 As String, Parameter2 As String, Parameter3 As String, Parameter4 As String, Parameter5 As String, Parameter6 As String, Parameter7 As String, Parameter8 As String, Parameter9 As String, Keywords As String, RefName As String, Options As String) As String	
        Dim dps As Uint32 = 20
        Dim Result As Object =  GetFunction07(dps, FunctionName, Parameter1, Parameter2, Parameter3, Parameter4, Parameter5, Parameter6, Parameter7)
        Dim s As String = MpMathToString(Result, dps)
        Return s
	End Function
	
	
	
	
	
	
	
	Public Function GetFunction00(dps As Uint32, FunctionEnum As String) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
'		    Dim f As Object = GetMp().Operator.methodcaller(FunctionEnum)
'		    f(GetMp())
		    Select Case FunctionEnum
		        Case "pi": Result = GetMp().pi()
		        Case "degree": Result = GetMp().degree()
		        Case "e": Result = GetMp().e()
		        Case "phi": Result = GetMp().phi()
		        Case "euler": Result = GetMp().euler()
		        Case "catalan": Result = GetMp().catalan()
		        Case "apery": Result = GetMp().apery()
		        Case "khinchin": Result = GetMp().khinchin()
		        Case "glaisher": Result = GetMp().glaisher()
		        Case "mertens": Result = GetMp().mertens()
		        Case "twinprime": Result = GetMp().twinprime()
		        Case "j": Result = GetMp().j
		        Case "quadgl": Result = GetMp().quadgl
		        Case "quadts": Result = GetMp().quadts
		        Case "inf": Result = GetMp().inf
		        Case "nan": Result = GetMp().nan
		        Case "rand": Result = GetMp().rand()
		        Case "eps": Result = GetMp().eps()
		        Case "levin": Result = GetMp().levin()
		        Case "cohen_alt": Result = GetMp().cohen_alt()
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetFunction01(dps As Uint32, FunctionEnum As String, x1 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
	'	*********************************************
		            
		        Case "Options": Result = "mp.Options(BaseOptions, Modifiers)"
		        Case "Table": Result = "X[i,j]"
		        Case "Chart": Result = "ChartResult"
		        Case "Eval": Result = "EvalResult"
		            
		        Case "autoprec": Result = GetMp().autoprec(x1)
		        Case "workprec": Result = GetMp().workprec(x1)
		        Case "workdps": Result = GetMp().workdps(x1)
		        Case "extraprec": Result = GetMp().extraprec(x1)
		        Case "extradps": Result = GetMp().extradps(x1)
		        Case "memoize": Result = GetMp().memoize(x1)
		        Case "maxcalls": Result = GetMp().maxcalls(x1)
		        Case "monitor": Result = GetMp().monitor(x1)
		        Case "timing": Result = GetMp().timing(x1)
	'	*********************************************
		            
		        Case "matrix": Result = GetMp().matrix(x1)
		        Case "eye": Result = GetMp().eye(x1)		            
		        Case "diag": Result = GetMp().diag(x1)		            
		        Case "zeros": Result = GetMp().zeros(x1)
		        Case "ones": Result = GetMp().ones(x1)		            
		        Case "hilbert": Result = GetMp().hilbert(x1)		            
		        Case "randmatrix": Result = GetMp().randmatrix(x1)		            
		            
		        Case "lu": Result = GetMp().lu(x1)		            
		        Case "qr": Result = GetMp().qr(x1)		            
		        Case "cholesky": Result = GetMp().cholesky(x1)		            
		            
		            
		        Case "det": Result = GetMp().det(x1)		            
		        Case "cond": Result = GetMp().cond(x1)		            
		        Case "inverse": Result = GetMp().inverse(x1)		            
		            
		            
		        Case "mpf": Result = GetMp().mpf(x1)
		        Case "mpc": Result = GetMp().mpc(x1)
		        Case "convert": Result = GetMp().convert(x1)
		        Case "chop": Result = GetMp().chop(x1)
		        Case "nstr": Result = GetMp().nstr(x1)
		        Case "arange": Result = GetMp().arange(x1)
	'	*********************************************
		        Case "fabs": Result = GetMp().fabs(x1)
		        Case "sign": Result = GetMp().sign(x1)
		        Case "re": Result = GetMp().re(x1)
		        Case "im": Result = GetMp().im(x1)
		        Case "arg": Result = GetMp().arg(x1)
		        Case "phase": Result = GetMp().phase(x1)
		        Case "conj": Result = GetMp().conj(x1)
		        Case "polar": Result = GetMp().polar(x1)
		        Case "rect": Result = GetMp().rect(x1)
	
	'	*********************************************
	
		        Case "floor": Result = GetMp().floor(x1)
		        Case "ceil": Result = GetMp().ceil(x1)
		        Case "nint": Result = GetMp().nint(x1)
		        Case "frac": Result = GetMp().frac(x1)
	
	'	*********************************************
	
		        Case "fneg": Result = GetMp().fneg(x1)
		        Case "fsum": Result = GetMp().fsum(x1)
		        Case "fprod": Result = GetMp().fprod(x1)
		        Case "fdot": Result = GetMp().fdot(x1)
		        Case "isinf": Result = GetMp().isinf(x1)
		        Case "isnan": Result = GetMp().isnan(x1)
		        Case "isnormal": Result = GetMp().isnormal(x1)
		        Case "isfinite": Result = GetMp().isfinite(x1)
		        Case "isint": Result = GetMp().isint(x1)
		        Case "frexp": Result = GetMp().frexp(x1)
		        Case "mag": Result = GetMp().mag(x1)
		        Case "nint_distance": Result = GetMp().nint_distance(x1)
	'	*********************************************
		            
		        Case "sqrt": Result = GetMp().sqrt(x1)
		        Case "cbrt": Result = GetMp().cbrt(x1)
		        Case "unitroots": Result = GetMp().unitroots(x1, "primitive=False")
		        Case "exp": Result = GetMp().exp(x1)
		        Case "expj": Result = GetMp().expj(x1)
		        Case "expjpi": Result = GetMp().expjpi(x1)
		        Case "expm1": Result = GetMp().expm1(x1)
		        Case "log": Result = GetMp().log(x1)
		        Case "ln": Result = GetMp().ln(x1)
		        Case "ln2": Result = GetMp().log(x1,2)
		        Case "ln10": Result = GetMp().log10(x1)
		        Case "log10": Result = GetMp().log10(x1)
		        Case "log2": Result = GetMp().log(x1,2)
		        Case "lambertw": Result = GetMp().lambertw(x1)
		            
		        Case "degrees": Result = GetMp().degrees(x1)
		        Case "radians": Result = GetMp().radians(x1)
		        Case "cos": Result = GetMp().cos(x1)
		        Case "sin": Result = GetMp().sin(x1)
		        Case "cos_sin": Result = GetMp().cos_sin(x1)
		        Case "tan": Result = GetMp().tan(x1)
		        Case "sec": Result = GetMp().sec(x1)
		        Case "csc": Result = GetMp().csc(x1)
		        Case "cot": Result = GetMp().cot(x1)
		        Case "cospi": Result = GetMp().cospi(x1)
		        Case "sinpi": Result = GetMp().sinpi(x1)
		        Case "cospi_sinpi": Result = GetMp().cospi_sinpi(x1)
		            
		            
		        Case "acos": Result = GetMp().acos(x1)
		        Case "asin": Result = GetMp().asin(x1)
		        Case "atan": Result = GetMp().atan(x1)
		        Case "asec": Result = GetMp().asec(x1)
		        Case "acsc": Result = GetMp().acsc(x1)
		        Case "acot": Result = GetMp().acot(x1)
		            
		        Case "sinc": Result = GetMp().sinc(x1)
		        Case "sincpi": Result = GetMp().sincpi(x1)
		            
		        Case "cosh": Result = GetMp().cosh(x1)
		        Case "sinh": Result = GetMp().sinh(x1)
		        Case "tanh": Result = GetMp().tanh(x1)
		        Case "sech": Result = GetMp().sech(x1)
		        Case "csch": Result = GetMp().csch(x1)
		        Case "coth": Result = GetMp().coth(x1)
		            
		        Case "acosh": Result = GetMp().acosh(x1)
		        Case "asinh": Result = GetMp().asinh(x1)
		        Case "atanh": Result = GetMp().atanh(x1)
		        Case "asech": Result = GetMp().asech(x1)
		        Case "acsch": Result = GetMp().acsch(x1)
		        Case "acoth": Result = GetMp().acoth(x1)
		            
		        Case "fac": Result = GetMp().fac(x1)
		        Case "factorial": Result = GetMp().factorial(x1)
		        Case "fac2": Result = GetMp().fac2(x1)
		        Case "gamma": Result = GetMp().gamma(x1)
		        Case "rgamma": Result = GetMp().rgamma(x1)
		        Case "loggamma": Result = GetMp().loggamma(x1)
		        Case "superfac": Result = GetMp().superfac(x1)
		        Case "hyperfac": Result = GetMp().hyperfac(x1)
		        Case "barnesg": Result = GetMp().barnesg(x1)
		        Case "digamma": Result = GetMp().digamma(x1)
		        Case "harmonic": Result = GetMp().harmonic(x1)
		            
		        Case "ei": Result = GetMp().ei(x1)
		        Case "e1": Result = GetMp().e1(x1)
		        Case "li": Result = GetMp().li(x1)
		        Case "ci": Result = GetMp().ci(x1)
		        Case "si": Result = GetMp().si(x1)
		        Case "chi": Result = GetMp().chi(x1)
		        Case "shi": Result = GetMp().shi(x1)
		        Case "erf": Result = GetMp().erf(x1)
		        Case "erfc": Result = GetMp().erfc(x1)
		        Case "erfi": Result = GetMp().erfi(x1)
		        Case "erfinv": Result = GetMp().erfinv(x1)
		        Case "fresnels": Result = GetMp().fresnels(x1)
		        Case "fresnelc": Result = GetMp().fresnelc(x1)
		            
		        Case "j0": Result = GetMp().j0(x1)
		        Case "j1": Result = GetMp().j1(x1)
		            
		        Case "airyai": Result = GetMp().airyai(x1)
		        Case "airybi": Result = GetMp().airybi(x1)
		        Case "airyaizero": Result = GetMp().airyaizero(x1)
		        Case "airybizero": Result = GetMp().airybizero(x1)
		            
		        Case "scorergi": Result = GetMp().scorergi(x1)
		        Case "scorerhi": Result = GetMp().scorerhi(x1)
		            
		        Case "qfrom": Result = GetMp().qfrom(x1)
		        Case "qbarfrom": Result = GetMp().qbarfrom(x1)
		        Case "mfrom": Result = GetMp().mfrom(x1)
		        Case "kfrom": Result = GetMp().kfrom(x1)
		        Case "taufrom": Result = GetMp().taufrom(x1)
		        Case "ellipk": Result = GetMp().ellipk(x1)
		        Case "ellipe": Result = GetMp().ellipe(x1)
		            
		        Case "kleinj": Result = GetMp().kleinj(x1)
		            
		        Case "zeta": Result = GetMp().zeta(x1)
		        Case "altzeta": Result = GetMp().altzeta(x1)
		        Case "stieltjes": Result = GetMp().stieltjes(x1)
		        Case "zetazero": Result = GetMp().zetazero(x1)
		        Case "nzeros": Result = GetMp().nzeros(x1)
		        Case "siegelz": Result = GetMp().siegelz(x1)
		        Case "siegeltheta": Result = GetMp().siegeltheta(x1)
		        Case "grampoint": Result = GetMp().grampoint(x1)
		        Case "backlunds": Result = GetMp().backlunds(x1)
		            
		        Case "primezeta": Result = GetMp().primezeta(x1)
		        Case "secondzeta": Result = GetMp().secondzeta(x1)
		            
		        Case "fibonacci": Result = GetMp().fibonacci(x1)
		        Case "fib": Result = GetMp().fib(x1)
		        Case "bernoulli": Result = GetMp().bernoulli(x1)
		        Case "bernfrac": Result = GetMp().bernfrac(x1)
		        Case "eulernum": Result = GetMp().eulernum(x1)
		            
		        Case "primepi": Result = GetMp().primepi(x1)
		        Case "primepi2": Result = GetMp().primepi2(x1)
		        Case "riemannr": Result = GetMp().riemannr(x1)
		        Case "mangoldt": Result = GetMp().mangoldt(x1)
		            
		        Case "identify": Result = GetMp().identify(x1)
		        Case "findpoly": Result = GetMp().findpoly(x1)
		            
		        Case "polyroots": Result = GetMp().polyroots(x1)
		            
		        Case "richardson": Result = GetMp().richardson(x1)
		        Case "shanks": Result = GetMp().shanks(x1)
		            
		        Case "diffs_prod": Result = GetMp().diffs_prod(x1)
		        Case "diffs_exp": Result = GetMp().diffs_exp(x1)
		            
		        Case "svd_r": Result = GetMp().svd_r(x1)
		        Case "svd_c": Result = GetMp().svd_c(x1)
		        Case "svd": Result = GetMp().svd(x1)
		            
		        Case "hessenberg": Result = GetMp().hessenberg(x1)
		        Case "schur": Result = GetMp().schur(x1)
		            
		        Case "eig": Result = GetMp().eig(x1)
		        Case "eigsy": Result = GetMp().eigsy(x1)
		        Case "eighe": Result = GetMp().eighe(x1)
		        Case "eigh": Result = GetMp().eigh(x1)
		            
		        Case "expm": Result = GetMp().expm(x1)
		        Case "sqrtm": Result = GetMp().sqrtm(x1)
		        Case "logm": Result = GetMp().logm(x1)
		        Case "sinm": Result = GetMp().sinm(x1)
		        Case "cosm": Result = GetMp().cosm(x1)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	


		Public Sub bar(x As Integer, <ParamDictionary> kwargs As IDictionary )
			For Each key In kwargs
				Console.WriteLine("key: {0}, value: {1} ", key, kwargs(key))
			Next
		End Sub




	Public Function GetFunction02Kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, StrArgs As String) As Object
	    Dim Result As Object = Nothing
	    
	    
'	    GetPyInstance().pyeval(s)
	    
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		            
		        Case "findroot": Result = GetPyInstance().findroot1d(x1, x2, StrArgs)
		        Case "quad": Result = GetPyInstance().quad1d(x1, x2, StrArgs)
		        Case "nsum": Result = GetPyInstance().nsum1d(x1, x2, StrArgs)

		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	
	
	
	
	
	Public Function GetFunction02(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object) As Object
	    Dim Result As Object = Nothing
	    
	    
'	    GetPyInstance().pyeval(s)
	    
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "mpc": Result = GetMp().mpc(x1, x2)
		        Case "matrix": Result = GetMp().matrix(x1, x2)
		        Case "norm": Result = GetMp().norm(x1, x2)
		        Case "mnorm": Result = GetMp().mnorm(x1, x2)
		            
		        Case "lu_solve": Result = GetMp().lu_solve(x1, x2)
		        Case "qr_solve": Result = GetMp().qr_solve(x1, x2)
		        Case "cholesky_solve": Result = GetMp().cholesky_solve(x1, x2)
		            
		        Case "powm": Result = GetMp().powm(x1, x2)
		            
		        Case "unitvector": Result = GetMp().unitvector(x1, x2)
	'	*********************************************
		        Case "fadd": Result = GetMp().fadd(x1, x2)
		        Case "fsub": Result = GetMp().fsub(x1, x2)
		        Case "fmul": Result = GetMp().fmul(x1, x2)
		        Case "fdiv": Result = GetMp().fdiv(x1, x2)
		        Case "fmod": Result = GetMp().fmod(x1, x2)
		        Case "almosteq": Result = GetMp().almosteq(x1, x2)
		        Case "ldexp": Result = GetMp().ldexp(x1, x2)
		        Case "chop": Result = GetMp().chop(x1, x2)
		        Case "fraction": Result = GetMp().fraction(x1, x2)
		        Case "linspace": Result = GetMp().linspace(x1, x2)
	'	*********************************************
'		        Case "nsum": Result = GetPyInstance().nsum1(x1, x2)
		        Case "sumem": Result = GetPyInstance().sumem(x1, x2)
		        Case "sumap": Result = GetPyInstance().sumap(x1, x2)
		            
		            
		        Case "nprod": Result = GetPyInstance().nprod(x1, x2)
		        Case "limit": Result = GetPyInstance().limit(x1, x2)
		            
		        Case "diff": Result = GetPyInstance().diff2(x1, x2)
		        Case "diffs": Result = GetPyInstance().diffs(x1, x2)
		        Case "diﬀerint": Result = GetPyInstance().diﬀerint(x1, x2)
		            
		        Case "quadosc": Result = GetPyInstance().quadosc(x1, x2)
		            
		            
		        Case "hypot": Result = GetMp().hypot(x1, x2)
		        Case "power": Result = GetMp().power(x1, x2)
		        Case "powm1": Result = GetMp().powm1(x1, x2)
		        Case "logb": Result = GetMp().log(x1, x2)
		        Case "lambertw_k": Result = GetMp().lambertw(x1, x2)
		        Case "agm": Result = GetMp().agm(x1, x2)
		        Case "atan2": Result = GetMp().atan2(x1, x2)
		        Case "binomial": Result = GetMp().binomial(x1, x2)
		        Case "rf": Result = GetMp().rf(x1, x2)
		        Case "ff": Result = GetMp().ff(x1, x2)
		        Case "gammaprod": Result = GetMp().gammaprod(x1, x2)
		        Case "hypercomb": Result = GetMp().hypercomb(x1, x2)
		        Case "beta": Result = GetMp().beta(x1, x2)
		        Case "psi": Result = GetMp().psi(x1, x2)
		        Case "polygamma": Result = GetMp().polygamma(x1, x2)
		            
		        Case "gammainc": Result = GetMp().gammainc(x1, 0, x2, True)
		        Case "expint": Result = GetMp().expint(x1, x2)
		            
		        Case "besselj": Result = GetMp().besselj(x1, x2)
		        Case "bessely": Result = GetMp().bessely(x1, x2)
		        Case "besseli": Result = GetMp().besseli(x1, x2)
		        Case "besselk": Result = GetMp().besselk(x1, x2)
		        Case "besseljzero": Result = GetMp().besseljzero(x1, x2)
		        Case "besselyzero": Result = GetMp().besselyzero(x1, x2)
		        Case "hankel1": Result = GetMp().hankel1(x1, x2)
		        Case "hankel2": Result = GetMp().hankel2(x1, x2)
		            
		        Case "ber": Result = GetMp().ber(x1, x2)
		        Case "bei": Result = GetMp().bei(x1, x2)
		        Case "ker": Result = GetMp().ker(x1, x2)
		        Case "kei": Result = GetMp().kei(x1, x2)
		            
		        Case "struveh": Result = GetMp().struveh(x1, x2)
		        Case "struvel": Result = GetMp().struvel(x1, x2)
		        Case "angerj": Result = GetMp().angerj(x1, x2)
		        Case "webere": Result = GetMp().webere(x1, x2)
		            
		        Case "airyaideriv": Result = GetMp().airyaideriv(x1, x2)
		        Case "airybideriv": Result = GetMp().airybideriv(x1, x2)
		        Case "airyaiderivzero": Result = GetMp().airyaiderivzero(x1, x2)
		        Case "airybiderivzero": Result = GetMp().airybiderivzero(x1, x2)
		            
		        Case "coulombc": Result = GetMp().coulombc(x1, x2)
		        Case "pcfd": Result = GetMp().pcfd(x1, x2)
		        Case "pcfu": Result = GetMp().pcfu(x1, x2)
		        Case "pcfv": Result = GetMp().pcfv(x1, x2)
		        Case "pcfw": Result = GetMp().pcfw(x1, x2)
		            
		        Case "legendre": Result = GetMp().legendre(x1, x2)
		        Case "chebyt": Result = GetMp().chebyt(x1, x2)
		        Case "chebyu": Result = GetMp().chebyu(x1, x2)
		        Case "hermite": Result = GetMp().hermite(x1, x2)
		            
		        Case "hyp0f1": Result = GetMp().hyp0f1(x1, x2)
		            
		        Case "ellipf": Result = GetMp().ellipf(x1, x2)
		        Case "ellipe": Result = GetMp().ellipe(x1, x2)
		        Case "ellippi": Result = GetMp().ellippi(x1, x2)
		        Case "elliprc": Result = GetMp().elliprc(x1, x2)
		            
		        Case "zeta": Result = GetMp().zeta(x1, x2)
		        Case "hurwitz": Result = GetMp().hurwitz(x1, x2)
		            
		        Case "dirichlet": Result = GetMp().dirichlet(x1, x2)
		        Case "stieltjes": Result = GetMp().stieltjes(x1, x2)
		            
		        Case "polylog": Result = GetMp().polylog(x1, x2)
		        Case "clsin": Result = GetMp().clsin(x1, x2)
		        Case "clcos": Result = GetMp().clcos(x1, x2)
		        Case "polyexp": Result = GetMp().polyexp(x1, x2)
		            
		        Case "bernpoly": Result = GetMp().bernpoly(x1, x2)
		        Case "eulerpoly": Result = GetMp().eulerpoly(x1, x2)
		        Case "bell": Result = GetMp().bell(x1, x2)
		        Case "stirling1": Result = GetMp().stirling1(x1, x2)
		        Case "stirling2": Result = GetMp().stirling2(x1, x2)
		        Case "cyclotomic": Result = GetMp().cyclotomic(x1, x2)
		            
		        Case "qgamma": Result = GetMp().qgamma(x1, x2)
		        Case "qfac": Result = GetMp().qfac(x1, x2)
		        Case "ﬁndpoly": Result = GetMp().ﬁndpoly(x1, x2)
		        Case "pslq": Result = GetMp().pslq(x1, x2)
		            
		        Case "polyval": Result = GetMp().polyval(x1, x2)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction03(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "diff": Result = GetPyInstance().diff3(x1, x2, x3)
		            
		        Case "odefun": Result = GetPyInstance().odefun(x1, x2, x3)
		            
		            
		        Case "taylor": Result = GetPyInstance().taylor(x1, x2, x3)
		            
		        Case "pade": Result = GetPyInstance().pade(x1, x2, x3)
		            
		        Case "chebyfit": Result = GetPyInstance().chebyfit(x1, x2, x3)
		            
		        Case "fourier": Result = GetPyInstance().fourier(x1, x2, x3)
		            
		        Case "fourierval": Result = GetPyInstance().fourierval(x1, x2, x3)
		            
		            
		            
		            
		        Case "nthroot": Result = GetMp().nthroot(x1, x2, x3)
		        Case "root": Result = GetMp().root(x1, x2, x3)
		            
		        Case "betainc": Result = GetMp().betainc(x1, x2, 0, x3, True)
		        Case "npdf": Result = GetMp().npdf(x1, x2, x3)
		        Case "ncdf": Result = GetMp().ncdf(x1, x2, x3)
		            
		        Case "besseljderiv": Result = GetMp().besselj(x1, x2, x3)
		        Case "besselyderiv": Result = GetMp().bessely(x1, x2, x3)
		        Case "besselideriv": Result = GetMp().besseli(x1, x2, x3)
		        Case "besselkderiv": Result = GetMp().besselk(x1, x2, x3)
		        Case "besseljzeroderiv": Result = GetMp().besseljzero(x1, x2, x3)
		        Case "besselyzeroderiv": Result = GetMp().besselyzero(x1, x2, x3)
		            
		        Case "lommels1": Result = GetMp().lommels1(x1, x2, x3)
		        Case "lommels2": Result = GetMp().lommels2(x1, x2, x3)
		            
		        Case "coulombf": Result = GetMp().coulombf(x1, x2, x3)
		        Case "coulombg": Result = GetMp().coulombg(x1, x2, x3)
		            
		        Case "hyperu": Result = GetMp().hyperu(x1, x2, x3)
		        Case "whitm": Result = GetMp().whitm(x1, x2, x3)
		        Case "whitw": Result = GetMp().whitw(x1, x2, x3)
		            
		        Case "legenp": Result = GetMp().legenp(x1, x2, x3)
		        Case "legenq": Result = GetMp().legenq(x1, x2, x3)
		        Case "gegenbauer": Result = GetMp().gegenbauer(x1, x2, x3)
		        Case "laguerre": Result = GetMp().laguerre(x1, x2, x3)
		            
		        Case "hyp1f1": Result = GetMp().hyp1f1(x1, x2, x3)
		        Case "hyp2f0": Result = GetMp().hyp2f0(x1, x2, x3)
		        Case "hyper": Result = GetMp().hyper(x1, x2, x3)
		        Case "bihyper": Result = GetMp().bihyper(x1, x2, x3)
		            
		        Case "ellippi": Result = GetMp().ellippi(x1, x2, x3)
		        Case "elliprf": Result = GetMp().elliprf(x1, x2, x3)
		        Case "elliprd": Result = GetMp().elliprd(x1, x2, x3)
		        Case "elliprg": Result = GetMp().elliprg(x1, x2, x3)
		            
		        Case "jtheta": Result = GetMp().jtheta(x1, x2, x3)
		        Case "ellipfun": Result = GetMp().ellipfun(x1, x2, x3)
		            
		        Case "zeta": Result = GetMp().zeta(x1, x2, x3)
		        Case "dirichlet": Result = GetMp().dirichlet(x1, x2, x3)
		        Case "lerchphi": Result = GetMp().lerchphi(x1, x2, x3)
		            
		        Case "stirling1": Result = GetMp().stirling1(x1, x2, x3)
		        Case "stirling2": Result = GetMp().stirling2(x1, x2, x3)
		            
		        Case "qp": Result = GetMp().qp(x1, x2, x3)
		            
		        Case "eig_sort": Result = GetMp().eig_sort(x1, x2, x3)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	



	Public Function GetFunction03kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, StrArgs As String) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
'		        Case "diff": Result = GetPyInstance().diff3(x1, x2, x3)
		        Case "nsum2d": Result = GetPyInstance().nsum2d(x1, x2, x3, StrArgs)
		        Case "quad2d": Result = GetPyInstance().quad2d(x1, x2, x3, StrArgs)
		            
		            
		        Case Else: Result = "GetFunction03kwargs: Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	




	Public Function GetFunction04(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "jacobi": Result = GetMp().jacobi(x1, x2, x3, x4)
		        Case "spherharm": Result = GetMp().spherharm(x1, x2, x3, x4)
		        Case "hyp1f2": Result = GetMp().hyp1f2(x1, x2, x3, x4)
		        Case "hyp2f1": Result = GetMp().hyp2f1(x1, x2, x3, x4)
		            
		        Case "meijerg": Result = GetMp().meijerg(x1, x2, x3, x4)
		        Case "hyper2d": Result = GetMp().hyper2d(x1, x2, x3, x4)
		            
		        Case "elliprj": Result = GetMp().elliprj(x1, x2, x3, x4)
		        Case "jtheta": Result = GetMp().jtheta(x1, x2, x3, x4)
		            
		        Case "qhyper": Result = GetMp().qhyper(x1, x2, x3, x4)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction04kwargs(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, StrArgs As String) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "nsum3d": Result = GetPyInstance().nsum3d(x1, x2, x3, x4, StrArgs)
		        Case "quad3d": Result = GetPyInstance().quad3d(x1, x2, x3, x4, StrArgs)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction05(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "hyp2f2": Result = GetMp().hyp2f2(x1, x2, x3, x4, x5)
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	


	Public Function GetFunction06(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "hyp2f3": Result = GetMp().hyp2f3(x1, x2, x3, x4, x5, x6)
		        Case "hyp3f2": Result = GetMp().hyp3f2(x1, x2, x3, x4, x5, x6)
		        Case "appellf1": Result = GetMp().appellf1(x1, x2, x3, x4, x5, x6)
		        Case "appellf4": Result = GetMp().appellf4(x1, x2, x3, x4, x5, x6)
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	
	
	
	Public Function GetFunction07(dps As Uint32, FunctionEnum As String, x1 As Object, x2 As Object, x3 As Object, x4 As Object, x5 As Object, x6 As Object, x7 As Object) As Object
		Dim Result As Object = Nothing
		Try
		    SetDps(dps)
		    Select Case FunctionEnum
		        Case "appellf2": Result = GetMp().appellf2(x1, x2, x3, x4, x5, x6, 7)
		        Case "appellf3": Result = GetMp().appellf3(x1, x2, x3, x4, x5, x6, 7)
		            
		            
		        Case Else: Result = "Function not found"
		    End Select
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function	

	
	'***************************************************************************************************************
	
	
	
		

		Public Shared ReadOnly Property AssemblyDirectory() As String
			Get
				Dim codeBase As String = Assembly.GetExecutingAssembly().CodeBase
				Dim uri__1 As New UriBuilder(codeBase)
				Dim path__2 As String = Uri.UnescapeDataString(uri__1.Path)
				
				Return Path.GetDirectoryName(path__2)
			End Get
		End Property

	
		Private Function RootDir() As String
			Dim RootPath As String = AssemblyDirectory() + "\..\"
			Return RootPath
		End Function

	
'	Public Function RootDir() As String
'		Dim regKey As RegistryKey = Nothing
'		Dim RootPath As String = "Not set"
'		Try
'			regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
'			RootPath = regKey.GetValue("RootPath", "Not set").ToString()
'			regKey.Close()
'		Catch generatedExceptionName As Exception
'			Console.WriteLine("RootDir not set")
'		End Try
'		Return RootPath
'	End Function
	
	
	
	
	
	Sub ReportException(e As Exception)
		Dim s As [String] = e.ToString()
		Dim l As Integer = s.Length
		If l > 1000 Then
			s = s.Substring(1, 1000)
		End If
		Console.WriteLine(s)
	End Sub


	Function GetPyEngine() As ScriptEngine
		Static PyEngine As ScriptEngine = Nothing
		If  IsNothing(PyEngine) Then
			Try
				Console.WriteLine("Setting up engine")
				Dim options = New Dictionary(Of String, Object)()
				options("Frames") = True
				options("FullFrames") = False
				PyEngine = Python.CreateEngine(options)
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyEngine
	End Function
	
	
	Function GetPyScope() As ScriptScope
		Static PyScope As ScriptScope = Nothing
		If  IsNothing(PyScope) Then
			Try
				Dim PyEngine As ScriptEngine = GetPyEngine()
	
				Dim Rd As [String] = RootDir() & "mpNum\AddIns\BackendBindings\PythonBinding"
				Console.WriteLine(Rd)
				
				Dim argv = New List(Of String)()
				argv.Add(Rd)
				argv.Add(Rd & "\Lib")
				argv.Add(Rd & "\DLL")
				PyEngine.Runtime.GetSysModule().SetVariable("argv", argv)
	
				Console.WriteLine("Loading assembly")
				Dim PyAssembly As Assembly = Assembly.LoadFile(RootDir() & "mpNum\MpMathPythonLib.dll")
				PyEngine.Runtime.LoadAssembly(PyAssembly)
				Console.WriteLine("Importing module")
				PyScope = PyEngine.Runtime.ImportModule("MyModule")
				
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyScope
	End Function
	
	
	
	Function GetPyInstance() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				Dim PyScope As ScriptScope = GetPyScope()
				Console.WriteLine("Defining Scope")
				Dim PyClass As Object = PyScope.GetVariable("MyClass")
				PyInstance = PyClass()
			Catch e As Exception
				ReportException(e)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	

	Public  Sub CompileSourceAndExecute(code As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromString(code, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
		
	End Sub
	
	

	Public  Sub CompileSourceFromFileAndExecute(FName As String)
		Dim PyEngine As ScriptEngine = GetPyEngine()
		Dim source As ScriptSource = PyEngine.CreateScriptSourceFromFile(FName, Encoding.ASCII, SourceCodeKind.Statements)
		Dim compiled As CompiledCode = source.Compile()
		Dim PyScope As ScriptScope = GetPyScope()
		' Executes in the scope of Python
		compiled.Execute(PyScope)
	End Sub
	
	
	
	Function GetMp() As Object
		Static PyInstance As Object = Nothing
		If  IsNothing(PyInstance) Then
			Try
				PyInstance = GetPyInstance().pygetmp()
			Catch ex As Exception
				ReportException(ex)
			End Try
		End If
		Return PyInstance
	End Function
	
	
	Public Function Getmpf(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympf(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpfi(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympfi(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpc(z As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pympc(z)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function Getmpci(x As Object, y As Object) As Object
	    Dim ResultX As Object = Nothing
	    Dim ResultY As Object = Nothing
		Dim Result As Object = Nothing
		Try
		    ResultX = GetPyInstance().pympfi(x)
		    ResultY = GetPyInstance().pympfi(y)
			Result = GetPyInstance().pympci(x, y)		    
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Public Function GetDecimal(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyDecimal(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function GetFraction(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyFraction(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	
	Public Function GetLong(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyLong(x)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Public Function GetEval(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyeval(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Public Function GetExec(s As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Public Function GetExec2(s1 As String, s2 As String) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetPyInstance().pyexec2(s1, s2)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Sub GetExec2(s As String) 
		Try
			GetPyInstance().pyexec(s)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	
'	Public Sub nprint2(obj As Object) 
'		Try
'			GetMp().nprint(obj)
'		Catch ex As Exception
'			ReportException(ex)
'		End Try
'	End Sub
	
	

'	Public Function MpMathToString(p As Object, n As Integer) As String
	Public Function MpMathToString(p As Object, n As Integer) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().mpmathToString(p, n), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Function DecimalToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyDecimalString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Function FractionToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyFractionString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	Function LongToString(p As Object) As String
		Dim Result As String = ""
		Try
			Result = CType(GetPyInstance().pyLongString(p), String)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function

	
	Public Sub SetDecimalPrec(n As Integer)
		Try
			GetPyInstance().pySetDecimalPrec(n)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	
	
	Public Sub SetDps(n As Integer)
		Try
			GetMp().dps = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	
	Public Sub SetPrec(n As Integer)
		Try
			GetMp().prec = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	Public Function GetDps() As Integer
	    Dim n As Integer = 0
		Try
			n = GetMp().dps
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	Public Function GetPrec() As Integer
	    Dim n As Integer = 0
		Try
			n = GetMp().prec
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub SetPretty(n As Boolean)
		Try
			GetMp().pretty = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	Public Function GetPretty() As Boolean
	    Dim n As Boolean = False
		Try
			n = GetMp().pretty
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub Set_trap_complex(n As Boolean)
		Try
			GetMp().trap_complex = n
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub
	
	
	
	Public Function Get_trap_complex() As Boolean
	    Dim n As Boolean = False
		Try
			n = GetMp().trap_complex
		Catch e As Exception
			ReportException(e)
		End Try
		Return n
	End Function
	
	
	
	Public Sub SetIvDps(n As Integer)
		Try
			GetPyInstance().pyMpfiPrec(n)
		Catch ex As Exception
			ReportException(ex)
		End Try
	End Sub
	
	

	Public Function GetPi() As Object
		Dim Result As Object = Nothing
		Try
			Result = GetMp().pi()			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	



	Public Function GetSqrt(x As Object) As Object
		Dim Result As Object = Nothing
		Try
			Result = GetMp().sqrt(x)			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	

	Function GetMp2Func(a As String, b As String) As String
		Dim Result As String = ""
		Try
			Result = GetPyInstance().mp2func(a, b)			
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function


	Public Sub SomeMethod()
		Try
			GetPyInstance().somemethod()
		Catch e As Exception
			ReportException(e)
		End Try
	End Sub


	Public Function IsOdd(i As Integer) As Boolean
		Dim Result As Boolean = False
		Try
			Result = CType(GetPyInstance().isodd(i), Boolean)
		Catch ex As Exception
			ReportException(ex)
		End Try
		Return Result
	End Function
	
	
	

	
	
	Public Sub TestOdd()
		Dim Result2 = True
		For i As Integer = 0 To 100000
			Result2 = IsOdd(i)
		Next
		Console.WriteLine(Result2)
	End Sub
	
	
	


	Function CreateCode() As String
		Dim lines As String() = { _
			"def f(x): one=mpf(1); return sqrt((one + 2*x)/(one + x))", _
			"print f(22.3)"
		}
		Return [String].Join(vbCr, lines)
	End Function


	Public Function PiString() As String
		Dim n As Integer = 25	
		Dim p As Object = Nothing
			SetDps(n)
			p = GetPi()
			Dim s As String
			s=(MpMathToString(p, n))
		Return s
	End Function


    Public Sub DemoMpf()
        Dim n As Integer = 1000
        SetDps(n)
		Dim a As Object = Getmpf("123E+300")
		Dim b As Object = Getmpf("456E-300")
		Console.WriteLine("Start Mpf")
		Dim c = a + b
		Dim s = MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpfi()
        Dim n As Integer = 1000
        SetIvDps(n)
		Dim a As Object = Getmpfi("123E+300")
		Dim b As Object = Getmpfi("456E-300")
		Console.WriteLine("Start Mpfi")
		Dim c = a + b
		Dim s = MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpc()
        Dim n As Integer = 1000
        SetDps(n)
		Dim a As Object = Getmpc("123E+300+789j")
		Dim b As Object = Getmpc("456E-300+789j")
		Console.WriteLine("Start Mpc")
		Dim c = a + b
		Dim s = MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoMpci()
        Dim n As Integer = 100
        SetIvDps(n)
		Dim a As Object = Getmpci("123E+30", "78.9")
		Dim b As Object = Getmpci("456E-30", "78.9")
		Console.WriteLine("Start Mpci")
'		Dim c = GetPyInstance().pyMpciAdd(a, b)
		Dim c = a + b
		
		Dim s = MpMathToString(c, n)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoDecimal()
        Dim n As Integer = 1000
        SetDecimalPrec(n)
		Dim a As Object = GetDecimal("123E+300")
		Dim b As Object = GetDecimal("456E-300")
		Console.WriteLine("Start Decimal")
		Dim c = a + b
		Dim s = DecimalToString(c)
		Console.WriteLine(s)
	End Sub
	
	
    Public Sub DemoFraction()
		Dim a As Object = GetFraction("3/7000")
		Dim b As Object = GetFraction("7000/3")
		Console.WriteLine("Start Fraction")
		Dim c = a + b
		Dim s = FractionToString(c)
		Console.WriteLine(s)
	End Sub
	
	
	
    Public Sub DemoLong()
		Dim a As Object = GetLong("2345234234252454")
		Dim b As Object = GetLong("6574565635434523423423")
		Console.WriteLine("Start Long")
		Dim c = a * b
		Dim s = LongToString(c)
		Console.WriteLine(s)
	End Sub
	

	Public Sub DemoMain()
		Dim n As Integer = 25
		Dim p As Object = Nothing
		
		
		SetDps(n)
		Dim Code As String = CreateCode()
		
		CompileSourceAndExecute(Code)
		
'		Dim FName As String = RootDir() & "Projects\PythonFromCSharp\PythonFromVB\MyModule2.py"
'		CompileSourceFromFileAndExecute(FName)
		
'		p = GetExec(Code)
'		Console.WriteLine(MpMathToString(p, n))

        For i=1 To 100		
    		n = 100
    		SetDps(n)
    		p = GetPi()
    		Console.WriteLine(MpMathToString(p, n))
        next		
'		n = 200
'		SetDps(n)
'		p = GetPi()
'		Console.WriteLine(MpMathToString(p, n))
'		
'		p = GetSqrt("2 + 1j")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		
		Dim a As Object = Getmpf("44545.345345")
		Dim b As Object = Getmpf("345344.345345")
		
		p = a + b
		Console.WriteLine(MpMathToString(p, n))
		
		p = a - b
		Console.WriteLine(MpMathToString(p, n))
		
		
		p = a * b
		Console.WriteLine(MpMathToString(p, n))
		
		
		p = a / b
		Console.WriteLine(MpMathToString(p, n))
'		
'		
'		Console.WriteLine(p.ToString())
		
		n=15
		SetDps(n)
		p = GetEval("findroot(lambda x: x**3 + 2*x + 1, j)")
		Console.WriteLine(MpMathToString(p, n))
		
'		p = GetEval("a = 2; b = 3; a + b")
'		Console.WriteLine(MpMathToString(p, n))
		
		
		Dim s As String = ""
		
'		s = "Result = quad(sin, [0, pi])"
'		s = "f = lambda x, y: cos(x+y/2); Result = quad(f, [-pi/2, pi/2], [0, pi])"
'		p = GetExec(s)
'		Console.WriteLine(MpMathToString(p, n))
		
		Dim s1 As String = "def f(x): one=mpf(1); return sqrt((one + 2*x)/(one + x))"
		Dim s2 As String  = "Result = f(22.3)"
		p = GetExec2(s1, s2)
		Console.WriteLine(MpMathToString(p, n))
		
'		SomeMethod()
'		TestOdd()
'		
'		s = GetMp2Func("32.47","12.41")
'		Console.WriteLine(s)
	End Sub
	
	
	
	
End Class


