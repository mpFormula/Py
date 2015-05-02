Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports System.IO

Namespace mpFormula
	Class dBFunctions
		Public Shared ReadOnly Property ConnectionStringSQLite() As String
			Get
				Dim database As String = Program.ActiveMainForm.ProjectFileName
				'AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Database\\ImageLib.s3db";
				'AppDomain.CurrentDomain.BaseDirectory + "\\Database\\ImageLib.s3db";
				Dim connectionString As String = "Data Source=" & Path.GetFullPath(database)
				Return connectionString
			End Get
		End Property
	End Class
End Namespace
