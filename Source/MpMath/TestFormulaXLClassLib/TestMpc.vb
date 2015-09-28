
Imports mpFormulaVB
    

Module Testmpc
    
    Sub DemoMpcBasic()
        mpc.dps = 30
        Dim a As New mpc_t("542.0", "12.0")
        Dim b As New mpc_t("11.3425", "1.3425")
        Dim c As New mpc_t()
        Dim d As New mpc_t("6.6786", "64.6786")
        Dim e As New mpc_t("11.56751", "1.56751")
        Console.WriteLine(a)
        Console.WriteLine(b)
        
        c = mpc.pi()
        Console.WriteLine(c)
        
        c = a - b
        Console.WriteLine(c)
        c = a * b
        Console.WriteLine(c)
        c = a / b
        Console.WriteLine(c)
        
        Console.WriteLine("Sqrt")
        c = mpc.sqrt(a)
        Console.WriteLine(c)
        
        Console.WriteLine("Power")        
        c = mpc.power(a, b)
        Console.WriteLine(c)
        
        
    End Sub
    
    Sub MpcMain()
        DemompcBasic()
    End Sub
    
End Module
