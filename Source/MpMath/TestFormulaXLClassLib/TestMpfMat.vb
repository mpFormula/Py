
Imports mpFormulaVB
    

Module TestMpfMat
    
    Sub DemoMpfMatBasic()
        mpf.dps = 30
        Dim A As New mpf_mat_t(10,10)
        Dim B As New mpf_mat_t(12,2)
        Dim x As New mpf_t()
        Console.WriteLine("Matrix A")
        Console.WriteLine("Matrix A.rows: " & A.rows & ", Matrix A.cols: " & A.cols)
        
        Console.WriteLine(A)

        
        x = "34"
        A(1,1) = x        
        Console.WriteLine("Matrix A")        
        Console.WriteLine(A)
        
        
'        Console.WriteLine("Matrix B")
'        Console.WriteLine("Matrix B.rows: " & B.rows & ", Matrix B.cols: " & B.cols)
'        
'        
'        Console.WriteLine(B)
        
    End Sub
    
    Sub MpfMatMain()
        DemoMpfMatBasic()
    End Sub
    
End Module
