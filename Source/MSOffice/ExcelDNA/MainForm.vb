Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Threading

Imports ExcelDna.Integration
Imports ExcelDna.Integration.CustomUI
Imports MpMathClientDLL

Public Module MyFunctions
    
    Dim np As New MpMathClientClass()    
    
    
	<ComVisible(False)> _
	Public Class MyAddIn
        Implements IExcelAddIn

    Public Sub AutoOpen() Implements IExcelAddIn.AutoOpen
        Const  ContextPopups As String = vbCr & vbLf & _ 
            "    <commandBars xmlns='http://schemas.excel-dna.net/office/2003/01/commandbars' >" & vbCr & vbLf & _ 
            "        <commandBar name='Cell'>" & vbCr & vbLf & _ 
            "        <button before='1' caption='mpFormula Navigator' enabled='true'  ShortcutText='SHIFT+F1' onAction='ShowMainDialog'  faceId='283'/>" & vbCr & vbLf & _ 
            "        </commandBar>" & vbCr & vbLf & "    </commandBars>"
    	ExcelCommandBarUtil.LoadCommandBars(ContextPopups, Nothing)
        XlCall.Excel(XlCall.xlcOnKey, "+{F1}", "ShowMainDialog")
        System.Windows.Forms.Application.EnableVisualStyles()
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US")
    End Sub
    
    
    Public Sub AutoClose() Implements IExcelAddIn.AutoClose
            XlCall.Excel(XlCall.xlcOnKey, "+{F1}")
        End Sub
    End Class




    Public Sub ShowMainDialog()
        Dim FAction As String = ""
        Dim FString As String = ExcelDna.Integration.ExcelDnaUtil.Application.activecell.formula
    	Dim theForm2 As New FunctionsForm(FAction, FString)
        If theForm2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ExcelDna.Integration.ExcelDnaUtil.Application.activecell.formula = theForm2.ReturnFormulaString
        End If
        theForm2.Dispose()
    End Sub




    Const FunctionNameDesc = "specifies the function name (which is case sensitive)."
    Const ParamGeneralDesc = " parameter of this function (see manual for details)."
    Const Parameter1Desc = "the first" + ParamGeneralDesc
    Const Parameter2Desc = "the second" + ParamGeneralDesc
    Const Parameter3Desc = "the third" + ParamGeneralDesc
    Const Parameter4Desc = "the fourth" + ParamGeneralDesc
    Const Parameter5Desc = "the fifth" + ParamGeneralDesc
    Const Parameter6Desc = "the sixth" + ParamGeneralDesc
    Const Parameter7Desc = "the seventh" + ParamGeneralDesc
    Const Parameter8Desc = "the eigth" + ParamGeneralDesc
    Const Parameter9Desc = "the ninth" + ParamGeneralDesc
    Const KeyWordsDesc = "Optional: specifies keywords for this function (if any)."
    Const RefNameDesc = "Optional: specifies the reference name (if any)."
    Const OptionsDesc = "Optional: specifies the options which are used for this function (if any)."




    <ExcelFunction(Description:="Functions without parameters.")>
        Public Function mpFunc0( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
        Dim Result As String = ""
        Try
            Result = np.Function00XL(FunctionName, KeyWords.ToString(), RefName.ToString(), Options.ToString())
        Catch ex As Exception
            
            Throw
        End Try
		Return Result
    End Function




    <ExcelFunction(Description:="Functions with 1 parameter.")>
        Public Function mpFunc1( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function01XL(FunctionName, Parameter1.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




    <ExcelFunction(Description:="Functions with 2 parameters.")>
        Public Function mpFunc2( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function02XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




    <ExcelFunction(Description:="Functions with 3 parameters.")>
        Public Function mpFunc3( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function03XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 4 parameters.")>
        Public Function mpFunc4( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function04XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 5 parameters.")>
        Public Function mpFunc5( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=Parameter5Desc)> ByVal Parameter5 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function05XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), Parameter5.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 6 parameters.")>
        Public Function mpFunc6( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=Parameter5Desc)> ByVal Parameter5 As Object, _        
        <ExcelArgument(Description:=Parameter6Desc)> ByVal Parameter6 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function06XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), Parameter5.ToString(), Parameter6.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 7 parameters.")>
        Public Function mpFunc7( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=Parameter5Desc)> ByVal Parameter5 As Object, _        
        <ExcelArgument(Description:=Parameter6Desc)> ByVal Parameter6 As Object, _        
        <ExcelArgument(Description:=Parameter7Desc)> ByVal Parameter7 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function07XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), Parameter5.ToString(), Parameter6.ToString(), Parameter7.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 8 parameters.")>
        Public Function mpFunc8( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=Parameter5Desc)> ByVal Parameter5 As Object, _        
        <ExcelArgument(Description:=Parameter6Desc)> ByVal Parameter6 As Object, _        
        <ExcelArgument(Description:=Parameter7Desc)> ByVal Parameter7 As Object, _        
        <ExcelArgument(Description:=Parameter8Desc)> ByVal Parameter8 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function08XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), Parameter5.ToString(), Parameter6.ToString(), Parameter7.ToString(), Parameter8.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function




<ExcelFunction(Description:="Functions with 9 parameters.")>
        Public Function mpFunc9( _ 
        <ExcelArgument(Description:=FunctionNameDesc)> ByVal FunctionName As String, _
        <ExcelArgument(Description:=Parameter1Desc)> ByVal Parameter1 As Object, _        
        <ExcelArgument(Description:=Parameter2Desc)> ByVal Parameter2 As Object, _        
        <ExcelArgument(Description:=Parameter3Desc)> ByVal Parameter3 As Object, _        
        <ExcelArgument(Description:=Parameter4Desc)> ByVal Parameter4 As Object, _        
        <ExcelArgument(Description:=Parameter5Desc)> ByVal Parameter5 As Object, _        
        <ExcelArgument(Description:=Parameter6Desc)> ByVal Parameter6 As Object, _        
        <ExcelArgument(Description:=Parameter7Desc)> ByVal Parameter7 As Object, _        
        <ExcelArgument(Description:=Parameter8Desc)> ByVal Parameter8 As Object, _        
        <ExcelArgument(Description:=Parameter9Desc)> ByVal Parameter9 As Object, _        
        <ExcelArgument(Description:=KeyWordsDesc)> Optional ByVal KeyWords As Object = "", _
        <ExcelArgument(Description:=RefNameDesc)> Optional ByVal RefName As Object = "", _
        <ExcelArgument(Description:=OptionsDesc)> Optional ByVal Options As Object = ""
    ) As Object
		Dim Result As String = ""
		Result = np.Function09XL(FunctionName, Parameter1.ToString(), Parameter2.ToString(), Parameter3.ToString(), Parameter4.ToString(), Parameter5.ToString(), Parameter6.ToString(), Parameter7.ToString(), Parameter8.ToString(), Parameter9.ToString(), KeyWords.ToString(), RefName.ToString(), Options.ToString())
		Return Result
    End Function



    '  <ExcelFunction(Description:="Functions with a variable number of parameters.")>
    '  Public Function mpFuncAny(ByVal Options As String, ByVal FunctionName As String, ByVal X1 As Object, Optional ByVal X2 As Object = "", Optional ByVal X3 As Object = "", Optional ByVal X4 As Object = "", Optional ByVal X5 As Object = "") As Object

    '    Return 1
    '  End Function

End Module