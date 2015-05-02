Imports MpMath

Module Program
	
	Dim mp As New MpMathClass
	
	Sub Main()
        
		'mp.DemoMain()
		
		Dim Result As Object
		Dim dps  As UInteger = 20
		
	
		Result = mp.GetFunction00(dps, "pi")
		Console.WriteLine("00: " + mp.MpMathToString(Result, dps))


		Result = mp.GetFunction01(dps, "sqrt", "0.5")
		Console.WriteLine(mp.MpMathToString(Result, dps))
		
		Result = mp.GetFunction02(dps, "hypot", "0.5", "1.5")
		Console.WriteLine("02: " + mp.MpMathToString(Result, dps))
		
		Result = mp.GetFunction03(dps, "npdf", "0.5", "1.5", "2.5")
		Console.WriteLine("03: " + mp.MpMathToString(Result, dps))
		
		Result = mp.GetFunction04(dps, "hyp2f1", "0.5", "1.5", "2.5", "3.5")
		Console.WriteLine("04: " + mp.MpMathToString(Result, dps))
		
		Result = mp.GetFunction05(dps, "hyp2f2", "0.5", "1.5", "2.5", "3.5", "4.5")
		Console.WriteLine("05: " + mp.MpMathToString(Result, dps))
		
'		mp.DemoMpf()
'		mp.DemoMpfi()
'		mp.DemoMpc()
'		mp.DemoMpci()
'		
'		mp.DemoDecimal()
'		mp.DemoFraction()
'		mp.DemoLong()
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
	
	
End Module
