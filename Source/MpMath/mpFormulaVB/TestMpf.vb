
Imports mpFormulaVB
    

Module TestMpf
    
    Sub DemoMpfBasic()
        mpf.dps = 30
        Dim a As New mpf_t("2.0")
        Dim b As New mpf_t("11.3425")
        Dim c As New mpf_t()
        Dim d As New mpf_t("66.6786")
        Dim e As New mpf_t("1.56751")
        Console.WriteLine(a)
        Console.WriteLine(b)
        
        c = mpf.pi()
        Console.WriteLine(c)
        
        c = a - b
        Console.WriteLine(c)
        c = a * b
        Console.WriteLine(c)
        c = a / b
        Console.WriteLine(c)
        
        c = mpf.sqrt(a)
        Console.WriteLine(c)
        
        c = mpf.hypot(a, b)
        Console.WriteLine(c)
        
        c = mpf.npdf(a, b, d)
        Console.WriteLine(c)
        
        d=c
        
        Dim Cmp As Boolean = (d <> c)
        Console.WriteLine(Cmp.ToString())
        c = mpf.hyp2f1(2, 0.5, 4, 0.75)
        Console.WriteLine(c)
        
    End Sub
    
    Sub MpfMain()
        DemoMpfBasic()
    End Sub
    
End Module
