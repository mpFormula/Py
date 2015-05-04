
Imports Office = NetOffice.OfficeApi 
Imports Excel = NetOffice.ExcelApi


Module Program
    Sub Main()
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


