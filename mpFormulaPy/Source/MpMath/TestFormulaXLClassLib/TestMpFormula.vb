
Imports mpFormulaNET

Module Program
    Sub Main()
        Console.WriteLine("Hello World!")
        
        mp.dps = 100
        Dim a As New mpNum("2")
        Dim b As New mpNum("11")
        Dim d As New mpNum("66")
        Dim e As New mpNum("11")
        Console.WriteLine(a.Str())
        Console.WriteLine(b.Str())
        
        Dim c As New mpNum()
        c = mp.CNum(mp.pi())
'        c = mp.pi()
        Console.WriteLine(c.Str())
        
        
        
'         c = a - b
'        Console.WriteLine(c.Str())
'        c = a * b
'        Console.WriteLine(c.Str())
'        c = a / b
'        Console.WriteLine(c.Str())
'        c = mp.pi()
'        Console.WriteLine(c.Str())
'        
'        c = mp.sqrt(a)
'        Console.WriteLine(c.Str())
'        
'        c = mp.hypot(a, b)
'        Console.WriteLine(c.Str())
'        
'        
'        c = mp.npdf(a, b, d)
'        Console.WriteLine(c.Str())
'        
'        d=c
'        
'        Dim Cmp As Boolean = (d <> c)
'        Console.WriteLine(Cmp.ToString())
'        c = mp.hyp2f1(2, 0.5, 4, 0.75)
'        Console.WriteLine(c.Str())

        Console.Write("Press any key to continue . . . ")
        Console.ReadKey(True)
    End Sub
End Module
