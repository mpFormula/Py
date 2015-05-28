
Imports Office = NetOffice.OfficeApi 
Imports Excel = NetOffice.ExcelApi


Module Program
    
    Sub ws()
        Dim xlApp As New Excel.Application() 
        Dim xl As Excel.WorksheetFunction = xlApp.WorksheetFunction 
        Dim x As Double
        Dim xs As String = "Error"
        Try
        x = xl.Log10(30.0)
        xs = xl.ImLog10("30.0+3j")
        Catch ex As Exception
            'Throw
        End Try
        
        Console.WriteLine("Ln(10) = " + x.ToString())
        Console.WriteLine("ImLog10(10) = " + xs.ToString())
        xl.Dispose()
        xlApp.Quit() 
        xlApp.Dispose()        
        
        
    End Sub
    
    Sub Main()
        
        ws()
        Console.WriteLine("Hello World!")
        
        Dim xlApp As New Excel.Application() 
        
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add()
        
        For Each xlSheet As Excel.Worksheet In xlBook.Worksheets
            Console.WriteLine(xlSheet.Name)
        Next
        
        
        
        xlBook.Dispose()
        xlApp.Quit() 
        xlApp.Dispose()        
        
        Console.Write("Press any key to continue . . . ")
        Console.ReadKey(True)
    End Sub
End Module


