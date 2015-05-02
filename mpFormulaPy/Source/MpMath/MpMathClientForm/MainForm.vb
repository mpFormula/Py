
Imports MpMathClientDLL


Public Partial Class MainForm
	
	Public Sub New()
		Dim np As New MpMathClientClass()
		Me.InitializeComponent()
		
		richTextBox1.Text = "Started... " + Environment.NewLine()
		Dim Result As String
		Dim dps  As UInt32 = 20
		
		Result = np.Function00(dps, "pi")
		richTextBox1.Text = richTextBox1.Text + "01: " + Result + Environment.NewLine()
		
		Result = np.Function01(dps, "sqrt", "0.5")
		richTextBox1.Text = richTextBox1.Text + "02: " + Result + Environment.NewLine()
		
		Result = np.Function02(dps, "hypot", "0.5", "1.5")
		richTextBox1.Text = richTextBox1.Text + "02: " + Result + Environment.NewLine()
		
		Result = np.Function03(dps, "npdf", "0.5", "1.5", "2.5")
		richTextBox1.Text = richTextBox1.Text + "03: " + Result + Environment.NewLine()
		
		Result = np.Function04(dps, "hyp2f1", "0.5", "1.5", "2.5", "3.5")
		richTextBox1.Text = richTextBox1.Text + "04: " + Result + Environment.NewLine()
		
		Result = np.Function05(dps, "hyp2f2", "0.5", "1.5", "2.5", "3.5", "4.5")
		richTextBox1.Text = richTextBox1.Text + "05: " + Result + Environment.NewLine()
		

	End Sub
	
End Class
