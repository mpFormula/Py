'
' Created by SharpDevelop.
' User: dhadler
' Date: 07/05/2014
' Time: 11:50
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			If Environment.OSVersion.Version.Major >= 6 Then
				SetProcessDPIAware()
			End If
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		<System.Runtime.InteropServices.DllImport("user32.dll")> _
		Private Shared Function SetProcessDPIAware() As Boolean
		End Function		
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.FunctionsForm
		End Sub
	End Class
End Namespace
