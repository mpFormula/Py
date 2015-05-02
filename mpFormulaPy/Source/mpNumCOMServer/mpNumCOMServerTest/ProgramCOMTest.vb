
Module Program
	
	Sub Demo1()
		Dim mp As Object = CreateObject("mpNumCOMServer.mp")

		MsgBox ("The HelloWorld method returns " & mp.HelloWorld)
		
		MsgBox ("Set the FloatProperty property to 1.2")
		mp.FloatProperty = 1.2
		MsgBox ("The FloatProperty property returns " & mp.FloatProperty)

		
		Dim x1 As Object = mp.CNum(0)
		
		MsgBox ("The HelloWorld method from mpNum returns " & x1.HelloWorld)
		
		MsgBox ("Set the mpNum FloatProperty property to 7.2")
		x1.FloatProperty = 7.2
		MsgBox ("The FloatProperty property returns " & x1.FloatProperty)
		
		mp = Nothing
		x1 = Nothing
	End Sub
	
	
	
	Sub Demo2()
		Dim mp As Object = CreateObject("mpNumCOMServer.mp")
		
		Dim Result As Double = 55
		MsgBox ("Result: " & Result.ToString())

    Console.WriteLine("Result: " & Result.ToString())
		
		Result = mp.GammaAmath(15)
		MsgBox ("ResultGamma: " & Result.ToString())
		
    'mp.SetPrecision(40)
    'Dim MatrixA, MatrixB, MatrixC As Object

    'MatrixA = mp.CNum(0)
    'MatrixB = mp.CNum(0)
    'MatrixC = mp.CNum(0)

    'Dim n As Int32 = 4
    'mp.SetRandomMatrix(n,n,MatrixA)
    'mp.PrintMatrix("Here is the matrix A:",MatrixA)

    'mp.GetMatrixInverse(MatrixB, MatrixA, 0)
    'mp.PrintMatrix("Here is the matrix B:",MatrixB)		

    'mp.GetMatrixProduct(MatrixA, MatrixB, MatrixC)
    'mp.PrintMatrix("Here is the product C = A * B:",MatrixC)		
		
		
		mp = Nothing
	End Sub
	
	
	
	Sub Main()
		Console.WriteLine("Hello World!")
		
    Demo2()
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
	
	
End Module
