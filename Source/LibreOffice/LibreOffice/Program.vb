
Module Program

    Sub CallLO()
        Dim objServiceManager As Object = CreateObject("com.sun.star.ServiceManager")
        Dim objDesktop As Object = objServiceManager.createInstance("com.sun.star.frame.Desktop")
        
        Dim objSvc As Object = objServiceManager.createInstance("com.sun.star.sheet.FunctionAccess")
        Dim x As Double = 3.0
        Dim arr1 As Double() = {x}
        Dim Result As Double = objSvc.callFunction("ERFC", arr1)
        
        Dim arrEmpty As Object() = {}
        Dim objCalcDoc As Object = objDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, arrEmpty)
        'Set objCalcDoc = objDesktop.loadComponentFromURL("file:///C:/file.ods", "_blank", 0, Array())
        
        Dim objSheet As Object = objCalcDoc.getSheets().getByIndex(0)
        objSheet.getCellByPosition(0, 0).SetString("Result: " + Result.ToString())
        objSheet.getCellByPosition(0, 0).charWeight = 150        
    End Sub
    
    Sub Main()
        CallLO()
    End Sub
    
End Module
