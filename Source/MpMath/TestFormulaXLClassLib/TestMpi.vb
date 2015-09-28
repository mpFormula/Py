
Imports mpFormulaVB
    

Module TestMpi
    
    Sub DemoMpiBasic()
        mpi.dps = 30
        Dim a As New mpi_t("2.0")
        Dim b As New mpi_t("11.3425")
        Dim c As New mpi_t()
        Dim d As New mpi_t("66.6786")
        Dim e As New mpi_t("1.56751")
        Console.WriteLine(a)
        Console.WriteLine(b)
        
        c = mpi.pi()
        Console.WriteLine(c)
        
        c = a - b
        Console.WriteLine(c)
        c = a * b
        Console.WriteLine(c)
        c = a / b
        Console.WriteLine(c)
        
        c = mpi.sin(a)
        Console.WriteLine(c)
        
        
    End Sub
    
    Sub MpiMain()
        DemompiBasic()
    End Sub
    
End Module
