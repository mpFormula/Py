'
' Created by SharpDevelop.
' User: dhadler
' Date: 18/09/2014
' Time: 11:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
	    Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
	    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
	    Me.tableLayoutPanel1.SuspendLayout
	    Me.SuspendLayout
	    '
	    'tableLayoutPanel1
	    '
	    Me.tableLayoutPanel1.ColumnCount = 1
	    Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
	    Me.tableLayoutPanel1.Controls.Add(Me.richTextBox1, 0, 1)
	    Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
	    Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
	    Me.tableLayoutPanel1.RowCount = 3
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51786!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.48214!))
	    Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37!))
	    Me.tableLayoutPanel1.Size = New System.Drawing.Size(455, 262)
	    Me.tableLayoutPanel1.TabIndex = 0
	    '
	    'richTextBox1
	    '
	    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
	    Me.richTextBox1.Location = New System.Drawing.Point(3, 40)
	    Me.richTextBox1.Name = "richTextBox1"
	    Me.richTextBox1.Size = New System.Drawing.Size(449, 181)
	    Me.richTextBox1.TabIndex = 0
	    Me.richTextBox1.Text = ""
	    AddHandler Me.richTextBox1.TextChanged, AddressOf Me.RichTextBox1TextChanged
	    '
	    'MainForm
	    '
	    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
	    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	    Me.ClientSize = New System.Drawing.Size(455, 262)
	    Me.Controls.Add(Me.tableLayoutPanel1)
	    Me.Name = "MainForm"
	    Me.Text = "MpMathClientForm"
	    Me.tableLayoutPanel1.ResumeLayout(false)
	    Me.ResumeLayout(false)
	End Sub
	Private richTextBox1 As System.Windows.Forms.RichTextBox
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	
	Sub RichTextBox1TextChanged(sender As Object, e As EventArgs)
		
	End Sub
End Class
