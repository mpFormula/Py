Option Strict On
Option Explicit On 

'N.B. aggiungere nelle Reference System.Design

Public Class BrowseForFolder

#Region " Variables "
	Dim m_Path As String = ""
	Dim m_Description As String = ""
	Dim m_StartPath As eLocations = eLocations.No_Locations
	Dim m_Style As eStyles = eStyles.No_Styles
#End Region

#Region " Enumerations "
	Public Enum eLocations
		No_Locations
		Desktop
		Favorites
		MyComputer
		MyDocuments
		MyPictures
		NetAndDialUpConnections
		NetworkNeighborhood
		Printers
		Recent
		SendTo
		StartMenu
		Templates
	End Enum

	Public Enum eStyles
		No_Styles
		BrowseForComputer
		BrowseForEverything
		BrowseForPrinter
		RestrictToDomain
		RestrictToFilesystem
		RestrictToSubfolders
		ShowTextBox
	End Enum
#End Region

#Region " Properties "
	Public Property Path() As String
		Get
			Return m_Path
		End Get
		Set(ByVal Value As String)
			m_Path = Value
		End Set
	End Property

	Public Property Description() As String
		Get
			Return m_Description
		End Get
		Set(ByVal Value As String)
			m_Description = Value
		End Set
	End Property

	Public Property StartPath() As eLocations
		Get
			Return m_StartPath
		End Get
		Set(ByVal Value As eLocations)
			m_StartPath = Value
		End Set
	End Property

	Public Property Style() As eStyles
		Get
			Return m_Style
		End Get
		Set(ByVal Value As eStyles)
			m_Style = Value
		End Set
	End Property
#End Region

	Public Function ShowDialog() As System.Windows.Forms.DialogResult
		Dim f As New FDialog(Me)
		Return f.ShowDialog()
	End Function

	Private Class FDialog

		Inherits System.Windows.Forms.Design.FolderNameEditor

		Private rParentClass As BrowseForFolder

		Public Sub New(ByVal r As BrowseForFolder)
			rParentClass = r
		End Sub

		Public Function ShowDialog() As System.Windows.Forms.DialogResult
			Dim fBFF As New System.Windows.Forms.Design.FolderNameEditor.FolderBrowser(), r As System.Windows.Forms.DialogResult

      fBFF.Description = rParentClass.Description

      Select Case rParentClass.StartPath
        Case eLocations.Desktop
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Desktop
        Case eLocations.Favorites
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Favorites
        Case eLocations.MyComputer
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.MyComputer
        Case eLocations.MyDocuments
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.MyDocuments
        Case eLocations.MyPictures
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.MyPictures
        Case eLocations.NetAndDialUpConnections
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.NetAndDialUpConnections
        Case eLocations.NetworkNeighborhood
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.NetworkNeighborhood
        Case eLocations.Printers
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Printers
        Case eLocations.Recent
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Recent
        Case eLocations.SendTo
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.SendTo
        Case eLocations.StartMenu
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.StartMenu
        Case eLocations.Templates
          fBFF.StartLocation = Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Templates
      End Select

      Select Case rParentClass.Style
        Case eStyles.BrowseForComputer
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.BrowseForComputer
        Case eStyles.BrowseForEverything
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.BrowseForEverything
        Case eStyles.BrowseForPrinter
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.BrowseForPrinter
        Case eStyles.RestrictToDomain
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.RestrictToDomain
        Case eStyles.RestrictToFilesystem
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.RestrictToFilesystem
        Case eStyles.RestrictToSubfolders
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.RestrictToSubfolders
        Case eStyles.ShowTextBox
          fBFF.Style = Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.ShowTextBox
      End Select

      r = fBFF.ShowDialog()

      If r = Windows.Forms.DialogResult.OK Then
        rParentClass.Path = fBFF.DirectoryPath
      End If

      Return r

		End Function

	End Class

End Class
