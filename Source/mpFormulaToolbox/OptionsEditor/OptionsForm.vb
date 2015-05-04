Imports System
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.IO
Imports System.Xml.Serialization
Imports System.Collections.Generic

'Namespace OptionsEditor
	Public Partial Class OptionsForm
		Inherits Form

		Private IsLocal As Integer = 1

		Public Sub New()
			InitializeComponent()
			StartForm()
		End Sub

		Public Sub New(mode As Integer)
			InitializeComponent()
			IsLocal = mode
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.TopMost = True
			StartForm()
		End Sub

		Private VisualBasic2010 As New LanguageOptions()
		Private CSharp As New LanguageOptions()
		Private JScript_2010 As New LanguageOptions()
		Private VBScript_WSH As New LanguageOptions()
		Private JScript_WSH As New LanguageOptions()
		Private SQLite3_Module As New LanguageOptions()
		Private Batch As New LanguageOptions()

		Private LanguageOptionsList As New List(Of LanguageOptions)()





		Private Sub Init_VisualBasic2010()
			VisualBasic2010.Age = 50
			VisualBasic2010.Address = " 114 Maple Drive "
			VisualBasic2010.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			VisualBasic2010.SSN = "123-345-3566"
			VisualBasic2010.Email = "bill@aol.com"
			VisualBasic2010.Name = "VisualBasic2010"
		End Sub

		Private Sub Init_CSharp()
			CSharp.Age = 50
			CSharp.Address = " 114 Maple Drive "
			CSharp.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			CSharp.SSN = "123-345-3566"
			CSharp.Email = "bill@aol.com"
			CSharp.Name = "CSharp"
		End Sub

		Private Sub Init_JScript_2010()
			JScript_2010.Age = 50
			JScript_2010.Address = " 114 Maple Drive "
			JScript_2010.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			JScript_2010.SSN = "123-345-3566"
			JScript_2010.Email = "bill@aol.com"
			JScript_2010.Name = "JScript_2010"
		End Sub

		Private Sub Init_VBScript_WSH()
			VBScript_WSH.Age = 50
			VBScript_WSH.Address = " 114 Maple Drive "
			VBScript_WSH.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			VBScript_WSH.SSN = "123-345-3566"
			VBScript_WSH.Email = "bill@aol.com"
			VBScript_WSH.Name = "VBScript_WSH"
		End Sub

		Private Sub Init_JScript_WSH()
			JScript_WSH.Age = 50
			JScript_WSH.Address = " 114 Maple Drive "
			JScript_WSH.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			JScript_WSH.SSN = "123-345-3566"
			JScript_WSH.Email = "bill@aol.com"
			JScript_WSH.Name = "JScript_WSH"
		End Sub

		Private Sub Init_SQLite3_Module()
			SQLite3_Module.Age = 50
			SQLite3_Module.Address = " 114 Maple Drive "
			SQLite3_Module.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			SQLite3_Module.SSN = "123-345-3566"
			SQLite3_Module.Email = "bill@aol.com"
			SQLite3_Module.Name = "SQLite3_Module"
		End Sub

		Private Sub Init_Batch()
			Batch.Age = 50
			Batch.Address = " 114 Maple Drive "
			Batch.DateOfBirth = Convert.ToDateTime(" 9/4/78")
			Batch.SSN = "123-345-3566"
			Batch.Email = "bill@aol.com"
			Batch.Name = "Batch"
		End Sub

		Private Sub StartForm()
			Init_VisualBasic2010()
			Init_CSharp()
			Init_JScript_2010()
			Init_VBScript_WSH()
			Init_JScript_WSH()
			Init_SQLite3_Module()
			Init_Batch()


			LanguageOptionsList.Add(VisualBasic2010)
			LanguageOptionsList.Add(CSharp)
			LanguageOptionsList.Add(JScript_2010)
			LanguageOptionsList.Add(VBScript_WSH)
			LanguageOptionsList.Add(JScript_WSH)
			LanguageOptionsList.Add(SQLite3_Module)
			LanguageOptionsList.Add(Batch)





			treeView1.SelectedNode = treeView1.Nodes(1)
			propertyGrid1.SelectedObject = VisualBasic2010
		End Sub

		Private Sub Form2_Load(sender As Object, e As EventArgs)

		End Sub

		Private Function WorkingDir() As String
			Dim key As RegistryKey = Registry.CurrentUser
			Dim key2 As RegistryKey = key.OpenSubKey("SOFTWARE\THF")
			Dim DirName As String = key2.GetValue("WorkingDir").ToString()
			Return DirName & "mpFormula\"
		End Function


		Private Sub btnOK_Click(sender As Object, e As EventArgs)
'			If IsLocal = 0 Then
'				Dim TempDir As [String] = WorkingDir() & "Temp\"
'				Dim Pgm As [String] = TempDir & "mpOptionsTemp01.txt"
'				File.WriteAllText(Pgm, "Cancel")
'				Application.[Exit]()
				Application.Exit()
'			End If
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
'			If IsLocal = 0 Then
'				Dim TempDir As [String] = WorkingDir() & "Temp\"
'				Dim Pgm As [String] = TempDir & "mpOptionsTemp01.txt"
'				File.WriteAllText(Pgm, "Cancel")
'				Application.[Exit]()
				Application.Exit()
'			End If
		End Sub

		Private Sub treeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)
			If e.Node.Tag.ToString() = "Visual_Basic_Tag" Then
				'  propertyGrid1.SelectedObject = VisualBasic2010;
				propertyGrid1.SelectedObject = LanguageOptionsList(0)
			End If

			If e.Node.Tag.ToString() = "CSharp_Tag" Then
				' propertyGrid1.SelectedObject = CSharp;
				propertyGrid1.SelectedObject = LanguageOptionsList(1)
			End If

			If e.Node.Tag.ToString() = "JScript_2010_Tag" Then
				' propertyGrid1.SelectedObject = JScript_2010;
				propertyGrid1.SelectedObject = LanguageOptionsList(2)
			End If

			If e.Node.Tag.ToString() = "VBScript_WSH_Tag" Then
				'  propertyGrid1.SelectedObject = VBScript_WSH;
				propertyGrid1.SelectedObject = LanguageOptionsList(3)
			End If

			If e.Node.Tag.ToString() = "JScript_WSH_Tag" Then
				'  propertyGrid1.SelectedObject = JScript_WSH;
				propertyGrid1.SelectedObject = LanguageOptionsList(4)
			End If

			If e.Node.Tag.ToString() = "SQLite3_Module_Tag" Then
				' propertyGrid1.SelectedObject = SQLite3_Module;
				propertyGrid1.SelectedObject = LanguageOptionsList(5)
			End If

			If e.Node.Tag.ToString() = "Batch_Tag" Then
				'        propertyGrid1.SelectedObject = Batch;
				propertyGrid1.SelectedObject = LanguageOptionsList(6)
			End If


		End Sub

		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Dim path = "C:\Extra\myserializationtest.xml"
			Using fs As New FileStream(path, FileMode.Create)
				'        XmlSerializer xSer = new XmlSerializer(typeof(LanguageOptions));
				Dim xSer As New XmlSerializer(GetType(List(Of LanguageOptions)))
					'xSer.Serialize(fs, Batch);
				xSer.Serialize(fs, LanguageOptionsList)
			End Using
		End Sub

		Private Sub btnLoad_Click(sender As Object, e As EventArgs)
			Dim path = "C:\Extra\myserializationtest.xml"
			Using fs As New FileStream(path, FileMode.Open)
				'        XmlSerializer xSer = new XmlSerializer(typeof(LanguageOptions));
				Dim xSer As New XmlSerializer(GetType(List(Of LanguageOptions)))
				LanguageOptionsList = DirectCast(xSer.Deserialize(fs), List(Of LanguageOptions))
			End Using
		End Sub








		
		Sub BtnAddinsClick(sender As Object, e As EventArgs)
	    Dim testDialog As New InstallAddins()
	    ' Show testDialog as a modal dialog and determine if DialogResult = OK. 
	    If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
	      ' Read the contents of testDialog's TextBox.
	      '        txtResult.Text = testDialog.TextBox1.Text
	    Else
	      '        txtResult.Text = "Cancelled" 
	    End If
	    testDialog.Dispose()			
		End Sub
	End Class
'End Namespace
