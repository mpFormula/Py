Imports System
Imports System.Data
Imports System.Transactions
Imports System.Data.SQLite

Namespace mpFormula
	Public Class DataContext
		Public Event ErrorEncountered As EventHandler(Of ErrorEncounteredEventArgs)

		Public Property CombinedDataSet() As DataSet
			Get
				Return m_CombinedDataSet
			End Get
			Private Set
				m_CombinedDataSet = Value
			End Set
		End Property
		Private m_CombinedDataSet As DataSet
		Public Property ContactsTable() As DataTable
			Get
				Return m_ContactsTable
			End Get
			Private Set
				m_ContactsTable = Value
			End Set
		End Property
		Private m_ContactsTable As DataTable
		'public DataTable FoodTable { get; private set; }

		Private m_contactsDataAdapter As SQLiteDataAdapter
		Private MyTableName As [String]

		Public Sub New(TableName As [String], sql As [String])
			MyTableName = TableName
			' Create the dataset where data will be held
			CombinedDataSet = New DataSet()
			ContactsTable = CombinedDataSet.Tables.Add(TableName)
			'FoodTable = CombinedDataSet.Tables.Add("food");

			' Get an open connection to the database
			Dim connection As SQLiteConnection = DatabaseManagement.GetConnection()

			' Create a new command to get data
			Dim command As SQLiteCommand = connection.CreateCommand()

			If sql = "" Then
				sql = "select * from " & TableName & ";"
			End If
			command.CommandText = sql

			' Create the data adapter using our select command
			m_contactsDataAdapter = New SQLiteDataAdapter(command)

			' The command builder will take care of our update, insert, deletion commands
			Dim commandBuilder As New SQLiteCommandBuilder(m_contactsDataAdapter)

			' Create a dataset and fill it with our records
			m_contactsDataAdapter.Fill(ContactsTable)
		End Sub


		''' <summary>
		''' Save changes
		''' </summary>
		Public Function SaveContactsChanges() As [Boolean]
			Try
				Using tScope As New TransactionScope()
					m_contactsDataAdapter.Update(ContactsTable)
					tScope.Complete()
					Return True
				End Using
			Catch ex As Exception
				RaiseEvent ErrorEncountered(Me, New ErrorEncounteredEventArgs(ex.Message))

				Return False
			End Try
		End Function

		''' <summary>
		'''  Abandon changes
		''' </summary>
		Public Sub RejectContactsChanges()
			ContactsTable.RejectChanges()
		End Sub

		Public Sub Dispose()
			If CombinedDataSet IsNot Nothing Then
				CombinedDataSet.Dispose()
			End If
		End Sub
	End Class
End Namespace
