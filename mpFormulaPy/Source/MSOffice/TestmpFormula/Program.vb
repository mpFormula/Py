'
' Created by SharpDevelop.
' User: DH
' Date: 16/04/2014
' Time: 21:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System
Imports System.Console
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Strings
Imports MatrixClass2
Imports MatrixClass2.mp


Module Program
	
	Function Test(x As mpNum) As mpNum
	
		Return 3
	End Function

	Sub Main()
		Console.WriteLine("Hello World!")
		
	    mp.Prec10() = 100 : mp.FloatingPointType() = 3
	    Dim Y1, Y2, Y3, Y4 As New mpNum
	    Y1 = mp.Sqrt(2)
	    Writeline("#Sqrt(12): ")
	    Writeline("@" & Y1)
	    Y2 = Sqrt(2)
	    Writeline("#Sqrt(12): ")
	    Writeline("@" & Y2)
	    Y3 = Y1 - Y2
	    Y4 = Y3 + CNum("1.4")
	    Writeline("#Diff:")
	    Writeline("@" & Y4)
		Dim Result, a, b As Double
		a= 13.0
		b = 14.0

		Result=Hypot(a, b)
		Writeline(Result)
		WriteLine("@" & Test(0))
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
