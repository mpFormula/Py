
Imports mpFormulaVB
    

Module TestMpci
    
    Sub DemoMpciBasic()
        mpi.dps = 30
        Dim a As New mpci_t("542.0", "12.0")
        Dim b As New mpci_t("11.3425", "1.3425")
        Dim c As New mpci_t()
        Dim d As New mpci_t("6.6786", "64.6786")
        Dim e As New mpci_t("11.56751", "1.56751")
        Console.WriteLine(a)
        Console.WriteLine(b)
        
        c = mpci.pi()
        Console.WriteLine(c)
        
        c = a - b
        Console.WriteLine(c)
        c = a * b
        Console.WriteLine(c)
        c = a / b
        Console.WriteLine(c)
        
        Console.WriteLine("e")
        Console.WriteLine(e)
        
        Console.WriteLine("sin(e)")
        c = mpci.sin1(e)
        Console.WriteLine(c)
        
        
    End Sub
    
    Sub MpciMain()
        DemoMpciBasic()
    End Sub
    
End Module
