Imports System
Imports MpMathClientDLL

Module Program
	
	Dim np As New MpMathClientClass()
	
	Sub Main()
		Console.WriteLine("Hello World!")
		
		Dim Result As String
		Dim dps  As UInt32 = 20
		
		
		Result = np.Function00(dps, "pi")
		Console.WriteLine("00: " + Result)
		
		Result = np.Function01(dps, "sqrt", "0.5")
		Console.WriteLine("01: " + Result)
		
		Result = np.Function02(dps, "hypot", "0.5", "1.5")
		Console.WriteLine("02: " + Result)
		
		Result = np.Function03(dps, "npdf", "0.5", "1.5", "2.5")
		Console.WriteLine("03: " + Result)
		
		Result = np.Function04(dps, "hyp2f1", "0.5", "1.5", "2.5", "3.5")
		Console.WriteLine("04: " + Result)
		
		Result = np.Function05(dps, "hyp2f2", "0.5", "1.5", "2.5", "3.5", "4.5")
		Console.WriteLine("05: " + Result)
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
	
End Module
