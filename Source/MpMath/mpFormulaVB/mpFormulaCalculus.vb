Imports System
Imports Microsoft.Scripting
Imports MpMath


  Public Class Calculus
      

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

      
    '  	Shared Sub nprint(x1 As Object) 
    '	    GetMp().nprint2(x1)
    '	End Sub
      
      
'    Shared Function mpc(x1 As Object) As Object
'      Return GetFunction01("mpc", x1)
'    End Function

      
      '    Shared Function unitroots(x1 As Object) As Object
'      Return GetFunction01("unitroots", m1)
'    End Function


'    Shared Function frexp(x1 As Object) As Object
'      Return GetFunction01("frexp", x1)
'    End Function



'    Shared Function expj(x1 As Object) As Object
'      Return GetFunction01("expj", m1)
'    End Function
'
'    Shared Function expjpi(x1 As Object) As Object
'      Return GetFunction01("expjpi", m1)
'    End Function




'    Shared Function qfrom(x1 As Object) As Object
'      Return GetFunction01("qfrom", x1)
'    End Function
'
'
'    Shared Function qbarfrom(x1 As Object) As Object
'      Return GetFunction01("qbarfrom", m1)
'    End Function
'
'
'    Shared Function mfrom(x1 As Object) As Object
'      Return GetFunction01("mfrom", m1)
'    End Function
'
'
'    Shared Function kfrom(x1 As Object) As Object
'      Return GetFunction01("kfrom", m1)
'    End Function
'
'
'    Shared Function taufrom(x1 As Object) As Object
'      Return GetFunction01("taufrom", m1)
'    End Function
'
'
'    Shared Function ellipk(x1 As Object) As Object
'      Return GetFunction01("ellipk", m1)
'    End Function


'    Shared Function nzeros(x1 As Object) As Object
'      Return GetFunction01("nzeros", m1)
'    End Function


'    Shared Function bernfrac(x1 As Object) As Object
'      Return GetFunction01("bernfrac", m1)
'    End Function



'    Shared Function identify(x1 As Object) As Object
'      Return GetFunction01("identify", x1)
'    End Function
'
'
'    Shared Function findpoly(x1 As Object) As Object
'      Return GetFunction01("findpoly", x1)
'    End Function
'
'
'    Shared Function richardson(x1 As Object) As Object
'      Return GetFunction01("richardson", x1)
'    End Function
'
'
'    Shared Function shanks(x1 As Object) As Object
'      Return GetFunction01("shanks", x1)
'    End Function
'
'
'    Shared Function diffs_prod(x1 As Object) As Object
'      Return GetFunction01("diffs_prod", x1)
'    End Function
'
'
'    Shared Function diffs_exp(x1 As Object) As Object
'      Return GetFunction01("diffs_exp", x1)
'    End Function
'


    Shared Function GetFunction02Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = MpAll.GetDps()
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
      Return MpMathClass.GetFunction02Kwargs(dps, FunctionEnum, n1, n2, StrArgs)
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
      Dim dps As Integer = MpAll.GetDps()
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
      Return MpMathClass.GetFunction03Kwargs(dps, FunctionEnum, n1, n2, n3, StrArgs)
    End Function



    Shared Function quad2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("quad2d", x1, x2, x3, kwargs)
    End Function



    Shared Function nsum2d(x1 As Object, x2 As Object, x3 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction03Kwargs("nsum2d", x1, x2, x3, kwargs)
    End Function



    Shared Function GetFunction04Kwargs(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object, n4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Dim dps As Integer = MpAll.GetDps()
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
      Return MpMathClass.GetFunction04Kwargs(dps, FunctionEnum, n1, n2, n3, n4, StrArgs)
    End Function



    Shared Function quad3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("quad3d", x1, x2, x3, x4, kwargs)
    End Function



    Shared Function nsum3d(x1 As Object, x2 As Object, x3 As Object, x4 As Object, <ParamDictionary()> kwargs As IDictionary) As Object
      Return GetFunction04Kwargs("nsum3d", x1, x2, x3, x4, kwargs)
    End Function



    Shared Function GetFunction02F(FunctionEnum As String, n1 As Object, n2 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction02(dps, FunctionEnum, n1, n2)
      '        Return CNum(GetMp().GetFunction02(dps, FunctionEnum, n1, n2))
    End Function



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
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction02(dps, FunctionEnum, n1, n2)
    End Function




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



    Shared Function mpc(x1 As Object, x2 As Object) As Object
      Return GetFunction02("mpc", x1, x2)
    End Function
    
    
  
    Shared Function linspace(x1 As Object, x2 As Object) As Object
      Return GetFunction02("linspace", x1, x2)
    End Function
    
    
    
    
    Shared Function ﬁndpoly(x1 As Object, x2 As Object) As Object
      Return GetFunction02("ﬁndpoly", x1, x2)
    End Function


    Shared Function pslq(x1 As Object, x2 As Object) As Object
      Return GetFunction02("pslq", x1, x2)
    End Function



    Shared Function GetFunction03F(FunctionEnum As String, n1 As Object, n2 As Object, n3 As Object) As Object
      Dim dps As Integer = MpAll.GetDps()
      Return MpMathClass.GetFunction03(dps, FunctionEnum, n1, n2, n3)
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


    
    
    

  End Class
  
  
  