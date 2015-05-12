Imports System
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Reflection
Imports System.IO
Imports System.Xml

Imports System.Text.RegularExpressions

	Public Partial Class FunctionsForm
		Inherits Form
		Public Property ReturnString() As String
			Get
				Return m_ReturnString
			End Get
			Set
				m_ReturnString = Value
			End Set
		End Property
		Private m_ReturnString As String
		' In .NET 3.0 or newer 
		Private ParamCount As Integer = 0
		Private IsLocal As Integer = 1
		Private ShowHelp As Boolean = False
		Private HelpKeywordString As [String] = ""

		'***********************************************************************

		Private PDFHELPVIEWER_WINDOWTITLE As String = "PDFHelpViewerMessageHandler0001"

		Public Const WM_COPYDATA As Integer = &H4a
		Public Structure COPYDATASTRUCT
			Public dwData As IntPtr
			Public cbData As Integer
			<MarshalAs(UnmanagedType.LPStr)> _
			Public lpData As String
		End Structure

		<DllImport("user32.dll")> _
		Public Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
		End Function

		<DllImport("User32.dll", EntryPoint := "SendMessage")> _
		Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, ByRef lParam As COPYDATASTRUCT) As Integer
		End Function

		Public Function SendWindowsStringMessage(hWnd As IntPtr, wParam As Integer, msg As String) As Integer
			Dim result As Integer = 0
			If hWnd <> Nothing Then
				Dim sarr As Byte() = System.Text.Encoding.[Default].GetBytes(msg)
				Dim len As Integer = sarr.Length
				Dim cds As COPYDATASTRUCT
				cds.dwData = CType(100, IntPtr)
				cds.lpData = msg
				cds.cbData = len + 1
				result = SendMessage(hWnd, WM_COPYDATA, wParam, cds)
			End If
			Return result
		End Function


		Public Sub SendStringMessageToPDFViewer(MyString As String)
			Dim hwndTarget As IntPtr = FindWindow(Nothing, PDFHELPVIEWER_WINDOWTITLE)

			If Not System.IntPtr.Zero.Equals(hwndTarget) Then
				SendWindowsStringMessage(hwndTarget, 0, MyString)
			Else
				If MyString <> "@CLOSEPDFVIEWER@" Then
					Dim Pgm As [String] = RootDir32() & "GUI\TestAcro.exe"
					Dim Args As [String] = MyString
					Dim startInfo As New ProcessStartInfo()
					startInfo.FileName = Pgm
					startInfo.Arguments = Args
					Process.Start(startInfo)
				End If
			End If
		End Sub


		'***********************************************************************


		''' <summary>
		''' Summary description for TreeViewSerializer.
		''' </summary>
		Public Class TreeViewSerializer

			' Xml tag for node, e.g. 'node' in case of <node></node>
			Private Const XmlNodeTag As String = "node"

			' Xml attributes for node e.g. <node text="Asia" tag="" imageindex="1"></node>
			Private Const XmlNodeTextAtt As String = "text"
			Private Const XmlNodeTagAtt As String = "tag"
			Private Const XmlNodeImageIndexAtt As String = "imageindex"

					'
					' TODO: Add constructor logic here
					'
			Public Sub New()
			End Sub



			Public Sub DeserializeTreeView(treeView As TreeView, fileName As String)
				Dim reader As XmlTextReader = Nothing
				Try
					' disabling re-drawing of treeview till all nodes are added
					treeView.BeginUpdate()
					reader = New XmlTextReader(fileName)

					Dim parentNode As TreeNode = Nothing

					While reader.Read()
						If reader.NodeType = XmlNodeType.Element Then
							If reader.Name = XmlNodeTag Then
								Dim newNode As New TreeNode()
								Dim isEmptyElement As Boolean = reader.IsEmptyElement

								' loading node attributes
								Dim attributeCount As Integer = reader.AttributeCount
								If attributeCount > 0 Then
									For i As Integer = 0 To attributeCount - 1
										reader.MoveToAttribute(i)

										SetAttributeValue(newNode, reader.Name, reader.Value)
									Next
								End If

								' add new node to Parent Node or TreeView
								If parentNode IsNot Nothing Then
									parentNode.Nodes.Add(newNode)
								Else
									treeView.Nodes.Add(newNode)
								End If

								' making current node 'ParentNode' if its not empty
								If Not isEmptyElement Then
									parentNode = newNode

								End If
							End If
						' moving up to in TreeView if end tag is encountered
						ElseIf reader.NodeType = XmlNodeType.EndElement Then
							If reader.Name = XmlNodeTag Then
								parentNode = parentNode.Parent
							End If
								'Ignore Xml Declaration                    
						ElseIf reader.NodeType = XmlNodeType.XmlDeclaration Then
						ElseIf reader.NodeType = XmlNodeType.None Then
							Return
						ElseIf reader.NodeType = XmlNodeType.Text Then
							parentNode.Nodes.Add(reader.Value)

						End If
					End While
				Finally
					' enabling redrawing of treeview after all nodes are added
					treeView.EndUpdate()
					reader.Close()
				End Try
			End Sub

			''' <summary>
			''' Used by Deserialize method for setting properties of TreeNode from xml node attributes
			''' </summary>
			''' <param name="node"></param>
			''' <param name="propertyName"></param>
			''' <param name="value"></param>
			Private Sub SetAttributeValue(node As TreeNode, propertyName As String, value As String)
				If propertyName = XmlNodeTextAtt Then
					node.Text = value
				ElseIf propertyName = XmlNodeImageIndexAtt Then
					node.ImageIndex = Integer.Parse(value)
				ElseIf propertyName = XmlNodeTagAtt Then
					node.Tag = value
				End If
			End Sub

		End Class


		'***********************************************************************


		Public Sub New()
			IsLocal = 1
			InitializeComponent()
			ReturnString = ""
'			Start()
		End Sub
		
		 Public Sub New(FAction As String, FString As String)
			IsLocal = 1
			InitializeComponent()
			ReturnString = ""
'			Start()
		End Sub		
		
		Public Sub New(mode As Integer)
			IsLocal = 0
			InitializeComponent()
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.TopMost = True
			ReturnString = ""
'			Start()
		End Sub


		Public Shared ReadOnly Property AssemblyDirectory() As String
			Get
				Dim codeBase As String = Assembly.GetExecutingAssembly().CodeBase
				Dim uri__1 As New UriBuilder(codeBase)
				Dim path__2 As String = Uri.UnescapeDataString(uri__1.Path)
				Return Path.GetDirectoryName(path__2)
			End Get
		End Property

	
		Private Function RootDir32() As String
			Dim RootPath As String = AssemblyDirectory() + "\..\"
			Return RootPath
		End Function




		Private Sub FunctionsForm_Load(sender As Object, e As EventArgs)
			Dim serializer As New TreeViewSerializer()
			Dim FName As [String] = RootDir32() & "Manual\mpFormulaFunctionsMenu.xml"
			serializer.DeserializeTreeView(Me.treeView1, FName)
		End Sub




		Private Sub FunctionsForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim MyString As String = "@CLOSEPDFVIEWER@"
			SendStringMessageToPDFViewer(MyString)
		End Sub

		Private Sub cbShowManual_CheckedChanged(sender As Object, e As EventArgs)
			ShowHelp = Not ShowHelp
			If ShowHelp = True Then
				SendStringMessageToPDFViewer(HelpKeywordString)
			Else
				Dim MyString As String = "@CLOSEPDFVIEWER@"
				SendStringMessageToPDFViewer(MyString)
			End If
		End Sub



		Private Sub treeView1_AfterSelect_1(sender As Object, e As TreeViewEventArgs)
			Dim input As [String] = e.Node.Tag.ToString()
			Dim pattern As String = "\{([^}]*)\}"
			Dim result As String() = Regex.Split(input, pattern, RegexOptions.IgnoreCase)
			richTextBox1.Text = input
			If result.Length > 1 Then
				Dim source As [String] = result(1)
				Dim stringSeparators As String() = New String() {"?"}
				Dim result2 As String() = source.Split(stringSeparators, StringSplitOptions.None)


				HelpKeywordString = result2(0) & ".HT"
			End If
			If ShowHelp = True Then
				SendStringMessageToPDFViewer(HelpKeywordString)
			End If
		End Sub

		
		Sub ShowManualToolStripMenuItemClick(sender As Object, e As EventArgs)
			ShowHelp = Not ShowHelp
			showManualToolStripMenuItem.Checked = Not(showManualToolStripMenuItem.Checked) 
			If ShowHelp = True Then
				SendStringMessageToPDFViewer(HelpKeywordString)
			Else
				Dim MyString As String = "@CLOSEPDFVIEWER@"
				SendStringMessageToPDFViewer(MyString)
			End If
		End Sub
		
		Sub DirToolStripMenuItemClick(sender As Object, e As EventArgs)
		    MessageBox.Show(AssemblyDirectory())
		End Sub
	End Class

