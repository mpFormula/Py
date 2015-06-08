
Imports Excel.FinancialFunctions



Module Program
    Sub Main()
        Console.WriteLine("Hello World!")
        
        ' TODO: Implement Functionality Here
        Dim  cost As Double = 1.0
        Dim salvage As Double = 2.0
        Dim life As Double = 3.0
        Dim Result As Double = Financial.Sln(cost, salvage, life)
        Console.WriteLine("Result: " + Result.ToString())
        Console.Write("Press any key to continue . . . ")
        Console.ReadKey(True)
    End Sub
End Module
