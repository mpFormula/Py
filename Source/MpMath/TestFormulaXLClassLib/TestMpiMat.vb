
Imports mpFormulaVB
    

Module TestMpiMat
    
    Sub DemoMpiMatBasic()
        mpf.dps = 30
        Dim a As New mpi_mat_t(10,10)
        Dim b As New mpi_mat_t(12,2)
        Dim c As New mpi_mat_t(3,3)
        Dim d As New mpi_mat_t(4,4)
        Dim e As New mpi_mat_t(5,5)
        Console.WriteLine("Matrix A")
        Console.WriteLine(a)
        
        Console.WriteLine("Matrix B")
        Console.WriteLine(b)
        
    End Sub
    
    Sub MpiMatMain()
        DemoMpiMatBasic()
    End Sub
    
End Module
