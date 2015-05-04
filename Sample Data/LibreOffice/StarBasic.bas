
Sub Main

End Sub

Function Multiply(a As Double, b as Double) As Double
	Multiply = a * b
End Function


REM Keep a global reference to the ScriptProvider, since this stuff may be called many times: 
Global g_MasterScriptProvider 

REM Specify location of Python script, providing cell functions: 
Const URL_Main = "vnd.sun.star.script:sheetFunction.py$" 
Const URL_Args = "?language=Python&location=share" 

Function getDoubleOf(data)
	sURL = URL_Main & "getDoubleOf" & URL_Args
	oMSP = getMasterScriptProvider()
	oScript = oMSP.getScript(sURL)
	x = oScript.invoke(Array(data),Array(),Array())
	getDoubleOf = x
End Function

Function getMPF(data2)
	sURL = URL_Main & "getMPF" & URL_Args
	oMSP = getMasterScriptProvider()
	oScript = oMSP.getScript(sURL)
	x = oScript.invoke(Array(data2),Array(),Array())
	getMPF = x
End Function

Function getMasterScriptProvider()
	If NOT isObject(g_MasterScriptProvider) Then
		oMasterScriptProviderFactory  =createUnoService ("com.sun.star.script.provider.MasterScriptProviderFactory")
		g_MasterScriptProvider = oMasterScriptProviderFactory.createScriptProvider("")
	End If
	getMasterScriptProvider = g_MasterScriptProvider 
End Function