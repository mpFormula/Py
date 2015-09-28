Imports MpMath

Module Program
	
'	Dim mp As New MpMathClass
	
	Sub Main()
        
		'mp.DemoMain()
		
'		Dim Result As Object
		Dim dps  As UInteger = 20
		
	
'		Result = MpMathClass.GetFunction00(dps, "pi")
'		Console.WriteLine("00: " + MpAll.MpMathToString(Result, dps))
'
'
'		Result = MpMathClass.GetFunction01(dps, "sqrt", "0.5")
'		Console.WriteLine(MpAll.MpMathToString(Result, dps))
'		
'		Result = MpMathClass.GetFunction02(dps, "hypot", "0.5", "1.5")
'		Console.WriteLine("02: " + MpAll.MpMathToString(Result, dps))
'		
'		Result = MpMathClass.GetFunction03(dps, "npdf", "0.5", "1.5", "2.5")
'		Console.WriteLine("03: " + MpAll.MpMathToString(Result, dps))
'		
'		Result = MpMathClass.GetFunction04(dps, "hyp2f1", "0.5", "1.5", "2.5", "3.5")
'		Console.WriteLine("04: " + MpAll.MpMathToString(Result, dps))
'		
'		Result = MpMathClass.GetFunction05(dps, "hyp2f2", "0.5", "1.5", "2.5", "3.5", "4.5")
'		Console.WriteLine("05: " + MpAll.MpMathToString(Result, dps))
		
'		mp.DemoMpf()
'		mp.DemoMpfi()
'		MpMathClass.DemoMpc()
		MpMathClass.DemoMpci()
'		
'		mp.DemoDecimal()
'		mp.DemoFraction()
'		mp.DemoLong()
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
	
	
End Module
