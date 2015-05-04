<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallAddins
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
  	Me.lbl_xlInfo = New System.Windows.Forms.Label()
  	Me.cbInstall_xlAddin = New System.Windows.Forms.CheckBox()
  	Me.lbl_CalcInfo = New System.Windows.Forms.Label()
  	Me.cbInstall_CalcAddin = New System.Windows.Forms.CheckBox()
  	Me.Label3 = New System.Windows.Forms.Label()
  	Me.GroupBox1 = New System.Windows.Forms.GroupBox()
  	Me.GroupBox2 = New System.Windows.Forms.GroupBox()
  	Me.btnCancel = New System.Windows.Forms.Button()
  	Me.btnApply = New System.Windows.Forms.Button()
  	Me.btnMakeCalc = New System.Windows.Forms.Button()
  	Me.GroupBox1.SuspendLayout
  	Me.GroupBox2.SuspendLayout
  	Me.SuspendLayout
  	'
  	'lbl_xlInfo
  	'
  	Me.lbl_xlInfo.AutoSize = true
  	Me.lbl_xlInfo.Location = New System.Drawing.Point(17, 27)
  	Me.lbl_xlInfo.Name = "lbl_xlInfo"
  	Me.lbl_xlInfo.Size = New System.Drawing.Size(102, 15)
  	Me.lbl_xlInfo.TabIndex = 0
  	Me.lbl_xlInfo.Text = "Not yet checked..."
  	'
  	'cbInstall_xlAddin
  	'
  	Me.cbInstall_xlAddin.AutoSize = true
  	Me.cbInstall_xlAddin.Location = New System.Drawing.Point(20, 58)
  	Me.cbInstall_xlAddin.Name = "cbInstall_xlAddin"
  	Me.cbInstall_xlAddin.Size = New System.Drawing.Size(144, 19)
  	Me.cbInstall_xlAddin.TabIndex = 1
  	Me.cbInstall_xlAddin.Text = "Addin not yet checked"
  	Me.cbInstall_xlAddin.UseVisualStyleBackColor = true
  	Me.cbInstall_xlAddin.Visible = false
  	'
  	'lbl_CalcInfo
  	'
  	Me.lbl_CalcInfo.AutoSize = true
  	Me.lbl_CalcInfo.Location = New System.Drawing.Point(17, 30)
  	Me.lbl_CalcInfo.Name = "lbl_CalcInfo"
  	Me.lbl_CalcInfo.Size = New System.Drawing.Size(102, 15)
  	Me.lbl_CalcInfo.TabIndex = 3
  	Me.lbl_CalcInfo.Text = "Not yet checked..."
  	'
  	'cbInstall_CalcAddin
  	'
  	Me.cbInstall_CalcAddin.AutoSize = true
  	Me.cbInstall_CalcAddin.Location = New System.Drawing.Point(20, 62)
  	Me.cbInstall_CalcAddin.Name = "cbInstall_CalcAddin"
  	Me.cbInstall_CalcAddin.Size = New System.Drawing.Size(144, 19)
  	Me.cbInstall_CalcAddin.TabIndex = 4
  	Me.cbInstall_CalcAddin.Text = "Addin not yet checked"
  	Me.cbInstall_CalcAddin.UseVisualStyleBackColor = true
  	Me.cbInstall_CalcAddin.Visible = false
  	'
  	'Label3
  	'
  	Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
  	Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
  	Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
  	Me.Label3.Location = New System.Drawing.Point(-4, -114)
  	Me.Label3.Name = "Label3"
  	Me.Label3.Size = New System.Drawing.Size(410, 55)
  	Me.Label3.TabIndex = 5
  	Me.Label3.Text = "Spreadsheet Add-ins"
  	Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
  	'
  	'GroupBox1
  	'
  	Me.GroupBox1.Controls.Add(Me.cbInstall_xlAddin)
  	Me.GroupBox1.Controls.Add(Me.lbl_xlInfo)
  	Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
  	Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
  	Me.GroupBox1.Name = "GroupBox1"
  	Me.GroupBox1.Size = New System.Drawing.Size(377, 97)
  	Me.GroupBox1.TabIndex = 6
  	Me.GroupBox1.TabStop = false
  	Me.GroupBox1.Text = "Microsoft Excel"
  	'
  	'GroupBox2
  	'
  	Me.GroupBox2.Controls.Add(Me.cbInstall_CalcAddin)
  	Me.GroupBox2.Controls.Add(Me.lbl_CalcInfo)
  	Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
  	Me.GroupBox2.Location = New System.Drawing.Point(12, 182)
  	Me.GroupBox2.Name = "GroupBox2"
  	Me.GroupBox2.Size = New System.Drawing.Size(377, 93)
  	Me.GroupBox2.TabIndex = 7
  	Me.GroupBox2.TabStop = false
  	Me.GroupBox2.Text = "OpenOffice.org Calc / LibreOffice Calc"
  	'
  	'btnCancel
  	'
  	Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
  	Me.btnCancel.Location = New System.Drawing.Point(314, 307)
  	Me.btnCancel.Name = "btnCancel"
  	Me.btnCancel.Size = New System.Drawing.Size(75, 23)
  	Me.btnCancel.TabIndex = 8
  	Me.btnCancel.Text = "Cancel"
  	Me.btnCancel.UseVisualStyleBackColor = true
  	'
  	'btnApply
  	'
  	Me.btnApply.Location = New System.Drawing.Point(212, 307)
  	Me.btnApply.Name = "btnApply"
  	Me.btnApply.Size = New System.Drawing.Size(75, 23)
  	Me.btnApply.TabIndex = 9
  	Me.btnApply.Text = "Apply"
  	Me.btnApply.UseVisualStyleBackColor = true
  	'
  	'btnMakeCalc
  	'
  	Me.btnMakeCalc.Location = New System.Drawing.Point(13, 307)
  	Me.btnMakeCalc.Name = "btnMakeCalc"
  	Me.btnMakeCalc.Size = New System.Drawing.Size(75, 23)
  	Me.btnMakeCalc.TabIndex = 10
  	Me.btnMakeCalc.Text = "Check"
  	Me.btnMakeCalc.UseVisualStyleBackColor = true
  	AddHandler Me.btnMakeCalc.Click, AddressOf Me.BtnMakeCalcClick
  	'
  	'InstallAddins
  	'
  	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
  	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  	Me.ClientSize = New System.Drawing.Size(404, 352)
  	Me.Controls.Add(Me.btnMakeCalc)
  	Me.Controls.Add(Me.btnApply)
  	Me.Controls.Add(Me.btnCancel)
  	Me.Controls.Add(Me.GroupBox2)
  	Me.Controls.Add(Me.GroupBox1)
  	Me.Controls.Add(Me.Label3)
  	Me.MaximumSize = New System.Drawing.Size(420, 390)
  	Me.MinimumSize = New System.Drawing.Size(420, 390)
  	Me.Name = "InstallAddins"
  	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
  	Me.Text = "mpFormula Add-in Manager for Spreadsheets"
  	Me.TopMost = true
  	Me.GroupBox1.ResumeLayout(false)
  	Me.GroupBox1.PerformLayout
  	Me.GroupBox2.ResumeLayout(false)
  	Me.GroupBox2.PerformLayout
  	Me.ResumeLayout(false)
  End Sub
  Private btnMakeCalc As System.Windows.Forms.Button
  Friend WithEvents lbl_xlInfo As System.Windows.Forms.Label
  Friend WithEvents cbInstall_xlAddin As System.Windows.Forms.CheckBox
  Friend WithEvents lbl_CalcInfo As System.Windows.Forms.Label
  Friend WithEvents cbInstall_CalcAddin As System.Windows.Forms.CheckBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnApply As System.Windows.Forms.Button

  
 
End Class
