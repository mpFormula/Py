Imports System
Imports System.ComponentModel

'Namespace OptionsEditor
	''' <summary>
	' Customer class to be displayed in the property grid
	''' </summary>
	'''
	<DefaultPropertyAttribute("Name")> _
	Public Class LanguageOptions
		Private _name As String
		Private _age As Integer
		Private _dateOfBirth As DateTime
		Private _SSN As String
		Private _address As String
		Private _email As String
		Private _frequentBuyer As Boolean
		' Name property with category attribute and
		' description attribute added
		<CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the customer")> _
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set
				_name = value
			End Set
		End Property
		<CategoryAttribute("ID Settings"), DescriptionAttribute("Social Security Number of the customer")> _
		Public Property SSN() As String
			Get
				Return _SSN
			End Get
			Set
				_SSN = value
			End Set
		End Property
		<CategoryAttribute("ID Settings"), DescriptionAttribute("Address of the customer")> _
		Public Property Address() As String
			Get
				Return _address
			End Get
			Set
				_address = value
			End Set
		End Property
		<CategoryAttribute("ID Settings"), DescriptionAttribute("Date of Birth of the Customer (optional)")> _
		Public Property DateOfBirth() As DateTime
			Get
				Return _dateOfBirth
			End Get
			Set
				_dateOfBirth = value
			End Set
		End Property
		<CategoryAttribute("ID Settings"), DescriptionAttribute("Age of the customer")> _
		Public Property Age() As Integer
			Get
				Return _age
			End Get
			Set
				_age = value
			End Set
		End Property
		<CategoryAttribute("Marketting Settings"), DescriptionAttribute("If the customer as bought more than 10 times, this is set to true")> _
		Public Property FrequentBuyer() As Boolean
			Get
				Return _frequentBuyer
			End Get
			Set
				_frequentBuyer = value
			End Set
		End Property
		<CategoryAttribute("Marketting Settings"), DescriptionAttribute("Most current e-mail of the customer")> _
		Public Property Email() As String
			Get
				Return _email
			End Get
			Set
				_email = value
			End Set
		End Property
		Public Sub New()
		End Sub
	End Class
'End Namespace
