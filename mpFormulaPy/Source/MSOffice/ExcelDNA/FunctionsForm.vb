Imports System
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Xml
Imports System.Text.RegularExpressions

	Public Partial Class FunctionsForm
	    Inherits Form
	    

  Public Property ReturnString() As String
    Get
      Return m_ReturnString
    End Get
    Set(value As String)
      m_ReturnString = value
    End Set
  End Property

  Public Property ReturnFormulaString() As String
    Get
      Return GetFormula()
    End Get
    Set(value As String)
      m_ReturnFormulaString = value
    End Set
  End Property

  Private m_ReturnString As String
  Private m_ReturnFormulaString As String

  Private FunctionName As String = ""
  Private ParamCount As Integer = 0
  Private FString As String = ""
  
'  Private IsLocal As Integer = 1
  
  Private ShowHelp As Boolean = False
  
  Private HelpKeywordString As String = ""

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
			Private Const XmlNodeTextAtt As String = "text"
			Private Const XmlNodeTagAtt As String = "tag"
			Private Const XmlNodeImageIndexAtt As String = "imageindex"
			
			Public Sub New()
			End Sub



			Public Sub DeserializeTreeView(treeView As TreeView, fileName As String)
				Dim reader As XmlTextReader = Nothing
				Try
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
					treeView.EndUpdate()
					reader.Close()
				End Try
			End Sub

			Private Sub SetAttributeValue(node As TreeNode, propertyName As String, value As String)
			    If propertyName = XmlNodeTextAtt Then
			        Dim str As String = value
			        Dim index As Integer = str.IndexOf("?")
			        If index>1 Then
			            str = str.Substring(0,index) 
			            
			        End If
			        node.Text = str
			        
			        
				ElseIf propertyName = XmlNodeImageIndexAtt Then
					node.ImageIndex = Integer.Parse(value)
				ElseIf propertyName = XmlNodeTagAtt Then
					node.Tag = value
				End If
			End Sub

		End Class


		'***********************************************************************
		
		

		Public Sub New()
'			IsLocal = 1
			InitializeComponent()
			ReturnString = ""
'			Start()
		End Sub
		
		 Public Sub New(FAction As String, InputFString As String)
'			IsLocal = 1
			InitializeComponent()
			ReturnString = ""
			
			
			FString = InputFString.Trim()
			
		End Sub		
		
		Public Sub New(mode As Integer)
'			IsLocal = 0
			InitializeComponent()
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.TopMost = True
			ReturnString = ""
'			Start()
		End Sub

	
	
		Private Function RootDir32() As String
			Dim regKey As RegistryKey
			Dim RootPath As String = "Not set"
			Try
			  regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\mpFormulaToolbox", False)
			  RootPath = regKey.GetValue("RootPath", "Not set")
			  regKey.Close()
			Catch ex As Exception
				MsgBox("RootDir not set")
			End Try
			Return RootPath
		End Function
		
		


		Private Sub FunctionsForm_Load(sender As Object, e As EventArgs)
			Dim serializer As New TreeViewSerializer()
			Dim FName As [String] = RootDir32() & "Manual\mpFormulaFunctionsMenu.xml"
			serializer.DeserializeTreeView(Me.treeView1, FName)
			
			datagridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            datagridView1.Columns(0).HeaderCell.Value = "Name of Function"
            datagridView1.Columns(0).Width = 300
            datagridView1.Rows.Add(4)
            datagridView1.RowHeadersWidthSizeMode =  AutoSize
            datagridView1.RowHeadersWidth = 100
			datagridView1.Rows(0).Cells(0).Value = "FOO"
			datagridView1.Rows(0).HeaderCell.Value = "Parameter 1"
			datagridView1.Visible = False
			
			If (FString <> "") Then
                FString = FString.Replace(" ", "")
    '            MsgBox(FString)
                Dim ParamCountS As String = FString.Substring(7, 1)
                ParamCount = System.Convert.ToInt32(ParamCountS)
                Dim FSplit As String() = FString.Split(",")
                FunctionName = FSplit(0)
                Dim L As Integer = FunctionName.Length
                FunctionName = FunctionName.Substring(9, L-9)
'                MsgBox(FunctionName)
                FunctionName = FunctionName.Replace("""", "")
                L = FSplit.Length-1
    			FSplit(L) = FSplit(L).Replace(")", "")
    			TraverseTree(treeView1.Nodes, FunctionName)
    			For i As Integer = 1 To ParamCount
                    datagridView1.Rows(i - 1).Cells(0).Value = FSplit(0+i)
    			Next i
    			datagridView1.Visible = True
    			datagridView1.Focus()
			Else
			  TraverseTree(treeView1.Nodes, "Eval")  
			End If
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
			
			
			Try
			    Dim s1 As String = richTextBox1.Lines(1)
			    Dim RowNumber As Integer = 1
			    Select Case s1
			        Case "\mpWorksheetFunctionOne": RowNumber = 1
			        Case "\mpWorksheetFunctionTwo": RowNumber = 2
			        Case "\mpWorksheetFunctionThree": RowNumber = 3
			        Case "\mpWorksheetFunctionFour": RowNumber = 4
			        Case "\mpWorksheetFunctionFive": RowNumber = 5
			        Case "\mpWorksheetFunctionSix": RowNumber = 6
			        Case "\mpWorksheetFunctionSeven": RowNumber = 7
			        Case "\mpWorksheetFunctionEight": RowNumber = 8
			            
			        Case "\mpFunctionOne": RowNumber = 1
			        Case "\mpFunctionTwo": RowNumber = 2
			        Case "\mpFunctionThree": RowNumber = 3
			        Case "\mpFunctionFour": RowNumber = 4
			        Case "\mpFunctionFive": RowNumber = 5
			        Case "\mpFunctionSix": RowNumber = 6
			        Case "\mpFunctionSeven": RowNumber = 7
			        Case "\mpFunctionEight": RowNumber = 8
			            
			        Case Else: RowNumber = 1
			            
			    End Select
			    ParamCount = RowNumber
			    datagridView1.Rows.Clear()
			    datagridView1.Rows.Add(RowNumber)
			    datagridView1.Visible = True
                datagridView1.Refresh()
			    
			    
			    Dim str As String = richTextBox1.Lines(2)
		        Dim index As Integer = str.IndexOf("?")
		        If index>1 Then
		            str = str.Substring(1,index - 1) 
		        End If
		        datagridView1.Columns(0).HeaderCell.Value = str
		        FunctionName=str
		        For i = 1 To RowNumber
		            str = richTextBox1.Lines(i + 2)
		            index = str.IndexOf("?")
    		        If index>1 Then
    		            str = str.Substring(1,index - 1) 
    		        End If
		            datagridView1.Rows(i - 1).HeaderCell.Value = str
		        Next
			Catch 
			End Try
			
			
			
		End Sub
		
		

        Private Function GetFormula() As String
            
'            Dim Code As [String] = "=MPFUNC" & ParamCount.ToString() & "(" & """" & "Options" & """" & ", " & """" & "RefName" & """" & ", " & """" & FunctionName & """"
            
            Dim Code As [String] = "=MPFUNC" & ParamCount.ToString() & "(" & """" & FunctionName & """"
            
            
            For i As Integer = 1 To ParamCount
                Code = Code & ", " & datagridView1.Rows(i - 1).Cells(0).Value.ToString()
            Next i
            Code = Code & ")"
            GetFormula = Code
        End Function
          
		
		Sub BtnOKClick(sender As Object, e As EventArgs)
		    ReturnFormulaString=GetFormula()
'		    MsgBox(ReturnFormulaString)
		    Me.DialogResult = DialogResult.OK
            ReturnString = "OK       "
            Me.Close()
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
		
		
		
		
		Private Sub TraverseTree(nodes As TreeNodeCollection, FindStr As String)
		    For Each child As TreeNode In nodes
		        If (child.Text  = FindStr) Then
		            treeView1.SelectedNode = child
		            Exit Sub
				End If
				TraverseTree(child.Nodes, FindStr)
		    Next
		End Sub
		
		
		
		
		
		Sub FindItemToolStripMenuItemClick(sender As Object, e As EventArgs)
		    TraverseTree(treeView1.Nodes, "PRICE")
		End Sub
	End Class

