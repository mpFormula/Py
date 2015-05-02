'
' Created by SharpDevelop.
' User: DH
' Date: 28/07/2013
' Time: 11:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AboutForm
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
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
		Me.btnClose = New System.Windows.Forms.Button
		Me.tableLayoutPanel1.SuspendLayout
		Me.SuspendLayout
		'
		'tableLayoutPanel1
		'
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
		Me.tableLayoutPanel1.Controls.Add(Me.btnClose, 1, 1)
		Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38!))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(418, 362)
		Me.tableLayoutPanel1.TabIndex = 0
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(331, 327)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 0
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = true
		AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
		'
		'AboutForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(418, 362)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Name = "AboutForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "About mpFormula"
		Me.tableLayoutPanel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private btnClose As System.Windows.Forms.Button
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
