Public Class frmMain
  Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents btnGo As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtINpath As System.Windows.Forms.TextBox
  Friend WithEvents txtOUTpath As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblCurrentSize As System.Windows.Forms.Label
  Friend WithEvents btnINpath As System.Windows.Forms.Button
  Friend WithEvents btnOUTpath As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtRedFactor As System.Windows.Forms.TextBox
  Friend WithEvents chkBatchProc As System.Windows.Forms.CheckBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.picPhoto = New System.Windows.Forms.PictureBox()
    Me.btnGo = New System.Windows.Forms.Button()
    Me.lblName = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtINpath = New System.Windows.Forms.TextBox()
    Me.txtOUTpath = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblCurrentSize = New System.Windows.Forms.Label()
    Me.btnINpath = New System.Windows.Forms.Button()
    Me.btnOUTpath = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtRedFactor = New System.Windows.Forms.TextBox()
    Me.chkBatchProc = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'picPhoto
    '
    Me.picPhoto.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right)
    Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picPhoto.Location = New System.Drawing.Point(16, 64)
    Me.picPhoto.Name = "picPhoto"
    Me.picPhoto.Size = New System.Drawing.Size(368, 284)
    Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picPhoto.TabIndex = 3
    Me.picPhoto.TabStop = False
    '
    'btnGo
    '
    Me.btnGo.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.btnGo.Location = New System.Drawing.Point(408, 112)
    Me.btnGo.Name = "btnGo"
    Me.btnGo.Size = New System.Drawing.Size(128, 20)
    Me.btnGo.TabIndex = 10
    Me.btnGo.Text = "GO"
    '
    'lblName
    '
    Me.lblName.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right)
    Me.lblName.Location = New System.Drawing.Point(16, 352)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(532, 23)
    Me.lblName.TabIndex = 20
    Me.lblName.Text = "<name>"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(16, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.TabIndex = 23
    Me.Label2.Text = "Input path:"
    '
    'txtINpath
    '
    Me.txtINpath.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right)
    Me.txtINpath.Location = New System.Drawing.Point(84, 12)
    Me.txtINpath.Name = "txtINpath"
    Me.txtINpath.Size = New System.Drawing.Size(424, 20)
    Me.txtINpath.TabIndex = 24
    Me.txtINpath.Text = ""
    '
    'txtOUTpath
    '
    Me.txtOUTpath.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right)
    Me.txtOUTpath.Location = New System.Drawing.Point(84, 36)
    Me.txtOUTpath.Name = "txtOUTpath"
    Me.txtOUTpath.Size = New System.Drawing.Size(424, 20)
    Me.txtOUTpath.TabIndex = 26
    Me.txtOUTpath.Text = ""
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(16, 40)
    Me.Label3.Name = "Label3"
    Me.Label3.TabIndex = 25
    Me.Label3.Text = "Output path:"
    '
    'lblCurrentSize
    '
    Me.lblCurrentSize.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right)
    Me.lblCurrentSize.Location = New System.Drawing.Point(16, 372)
    Me.lblCurrentSize.Name = "lblCurrentSize"
    Me.lblCurrentSize.Size = New System.Drawing.Size(532, 20)
    Me.lblCurrentSize.TabIndex = 27
    Me.lblCurrentSize.Text = "<size>"
    '
    'btnINpath
    '
    Me.btnINpath.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.btnINpath.Location = New System.Drawing.Point(512, 12)
    Me.btnINpath.Name = "btnINpath"
    Me.btnINpath.Size = New System.Drawing.Size(24, 20)
    Me.btnINpath.TabIndex = 28
    Me.btnINpath.Text = "..."
    '
    'btnOUTpath
    '
    Me.btnOUTpath.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.btnOUTpath.Location = New System.Drawing.Point(512, 36)
    Me.btnOUTpath.Name = "btnOUTpath"
    Me.btnOUTpath.Size = New System.Drawing.Size(24, 20)
    Me.btnOUTpath.TabIndex = 29
    Me.btnOUTpath.Text = "..."
    '
    'Label1
    '
    Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.Label1.Location = New System.Drawing.Point(408, 64)
    Me.Label1.Name = "Label1"
    Me.Label1.TabIndex = 30
    Me.Label1.Text = "Reducing factor:"
    '
    'txtRedFactor
    '
    Me.txtRedFactor.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.txtRedFactor.Location = New System.Drawing.Point(504, 60)
    Me.txtRedFactor.Name = "txtRedFactor"
    Me.txtRedFactor.Size = New System.Drawing.Size(32, 20)
    Me.txtRedFactor.TabIndex = 31
    Me.txtRedFactor.Text = "0.6"
    Me.txtRedFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'chkBatchProc
    '
    Me.chkBatchProc.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
    Me.chkBatchProc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.chkBatchProc.Location = New System.Drawing.Point(408, 84)
    Me.chkBatchProc.Name = "chkBatchProc"
    Me.chkBatchProc.Size = New System.Drawing.Size(128, 24)
    Me.chkBatchProc.TabIndex = 32
    Me.chkBatchProc.Text = "Batch processing:"
    '
    'frmMain
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(552, 397)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkBatchProc, Me.txtRedFactor, Me.Label1, Me.btnOUTpath, Me.btnINpath, Me.lblCurrentSize, Me.txtOUTpath, Me.Label3, Me.txtINpath, Me.Label2, Me.btnGo, Me.picPhoto, Me.lblName})
    Me.KeyPreview = True
    Me.Name = "frmMain"
    Me.Text = "Batch Image Resizer"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Dim img As Bitmap
  Dim imgFormat As Imaging.ImageFormat

  Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ConfigOpt.Initialize("ImageBatchResizer.cfg")
    txtINpath.Text = ConfigOpt.GetOption("InputPath")
    txtOUTpath.Text = ConfigOpt.GetOption("OutputPath")
    txtRedFactor.Text = ConfigOpt.GetOption("RedFactor")
    chkBatchProc.Checked = Boolean.Parse(ConfigOpt.GetOption("BatchProc"))
  End Sub

  Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    ConfigOpt.SetOption("InputPath", txtINpath.Text)
    ConfigOpt.SetOption("OutputPath", txtOUTpath.Text)
    ConfigOpt.SetOption("RedFactor", txtRedFactor.Text)
    ConfigOpt.SetOption("BatchProc", chkBatchProc.Checked.ToString())
    ConfigOpt.Store()
  End Sub

  Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
    If Not Directory.Exists(txtINpath.Text) Or Not Directory.Exists(txtOUTpath.Text) Then
      MessageBox.Show("The folder you specified as input and/or output path does not exist. Please, check it and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If
    Dim fs As String() = Directory.GetFiles(txtINpath.Text, "*.jpg")
    Dim Ffull, Fshort As String
    For Each Ffull In fs
      FromFile(Ffull)
      Application.DoEvents()
      Fshort = Ffull.Substring(Ffull.LastIndexOf("\") + 1)
      lblName.Text = Fshort
      Application.DoEvents()
      Dim dr As DialogResult
      If chkBatchProc.Checked Then
        dr = DialogResult.Yes
      Else
        dr = MessageBox.Show("Convert?", Fshort, MessageBoxButtons.YesNoCancel)
      End If
      If dr = DialogResult.Cancel Then
        Exit For
      ElseIf dr = DialogResult.Yes Then
        Reduce(Double.Parse(txtRedFactor.Text, New System.Globalization.CultureInfo("EN-us")))
        Application.DoEvents()
        ToFile(txtOUTpath.Text & "\" & Fshort)
      End If
    Next
  End Sub

  Private Sub Reduce(ByVal factor As Double)
    img = New Bitmap(img, New Size(img.Size.Width * factor, img.Size.Height * factor))
    picPhoto.Image = img

    Dim SizeKb As String
    ' To compute: size in Kb
    Dim ms As New MemoryStream()
    img.Save(ms, Imaging.ImageFormat.Jpeg)
    SizeKb = (ms.Length \ 1024).ToString() & "Kb "

    lblCurrentSize.Text = "Current Size: " & SizeKb & "(" & img.Width & "x" & img.Height & ") [" & img.Width / img.Height & "]"
  End Sub

  Private Sub ToFile(ByVal filename As String)
    Dim ms As New MemoryStream()
    img.Save(ms, Imaging.ImageFormat.Jpeg)
    Dim imgData(ms.Length - 1) As Byte
    ms.Position = 0
    ms.Read(imgData, 0, ms.Length)
    Dim fs As New FileStream(filename, FileMode.Create, FileAccess.Write)
    fs.Write(imgData, 0, UBound(imgData))
    fs.Close()
  End Sub

  Private Sub FromFile(ByVal filename As String)
    Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
    Dim imgData(fs.Length) As Byte
    fs.Read(imgData, 0, fs.Length)
    fs.Close()

    Try
      img = Image.FromStream(New MemoryStream(imgData))
      imgFormat = img.RawFormat
      picPhoto.Image = img
      lblCurrentSize.Text = "Current Size: " & UBound(imgData) \ 1024 & "Kb (" & img.Width & "x" & img.Height & ") [" & img.Width / img.Height & "]"
    Catch
      lblCurrentSize.Text = "Error"
    End Try
  End Sub

  Private Sub btnINpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINpath.Click
    Dim fBFF As New BrowseForFolder()
    fBFF.Description = "Select the folder containing the pictures to be reduced (input folder):"
    If fBFF.ShowDialog() = DialogResult.OK Then
      txtINpath.Text = fBFF.Path
    End If
  End Sub

  Private Sub btnOUTpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOUTpath.Click
    Dim fBFF As New BrowseForFolder()
    fBFF.Description = "Select the target folder for the reduced pictured (output folder):"
    If fBFF.ShowDialog() = DialogResult.OK Then
      txtOUTpath.Text = fBFF.Path
    End If
  End Sub

End Class
