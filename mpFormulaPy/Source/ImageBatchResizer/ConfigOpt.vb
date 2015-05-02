Imports System.IO

' Class for managing configuration persistence
Public Class ConfigOpt

  ' This DataSet is used as a memory data structure to hold config key/value pairs
  ' Inside this DataSet, a single DataTable named ConfigValues is created
  Private Shared DSoptions As DataSet
  ' This is the filename for the DataSet XML serialization
  Private Shared mConfigFileName As String

  ' This property is read-only, because it is set through Initialize or Store methods
  Public Shared ReadOnly Property ConfigFileName() As String
    Get
      Return mConfigFileName
    End Get
  End Property

  ' This method has to be invoked before using any other method of ConfigOpt class
  ' ConfigFile parameter is the name of the config file to be read
  ' (if that file doesn't exists, the method simply initialize the data structure
  ' and the ConfigFileName property)
  Public Shared Sub Initialize(ByVal ConfigFile As String)
    mConfigFileName = ConfigFile
    DSoptions = New DataSet("ConfigOpt")
    If File.Exists(ConfigFile) Then
      ' If the specified config file exists, it is read to populate the DataSet
      DSoptions.ReadXml(ConfigFile)
    Else
      ' If the specified config file doesn't exists, 
      ' the DataSet is simply initialized (and left empty):
      ' the ConfigValues DataTable is created with two fields (to hold key/values pairs)
      Dim dt As New DataTable("ConfigValues")
      dt.Columns.Add("OptionName", System.Type.GetType("System.String"))
      dt.Columns.Add("OptionValue", System.Type.GetType("System.String"))
      DSoptions.Tables.Add(dt)
    End If
  End Sub

  ' This method serializes the memory data structure holding the config parameters
  ' The filename used is the one defined calling Initialize method
  Public Shared Sub Store()
    Store(mConfigFileName)
  End Sub

  ' Same as Store() method, but with the ability to serialize on a different filename
  Public Shared Sub Store(ByVal ConfigFile As String)
    mConfigFileName = ConfigFile
    DSoptions.WriteXml(ConfigFile)
  End Sub

  ' Read a configuration Value (aka OptionValue), given its Key (aka OptionName)
  ' If the Key is not defined, an empty string is returned
  Public Shared Function GetOption(ByVal OptionName As String) As String
    Dim dv As DataView = DSoptions.Tables("ConfigValues").DefaultView
    dv.RowFilter = "OptionName='" & OptionName & "'"
    If dv.Count > 0 Then
      Return CStr(dv.Item(0).Item("OptionValue"))
    Else
      Return ""
    End If
  End Function

  ' Write in the memory data structure a Key/Value pair for a configuration setting
  ' If the Key already exists, the Value is simply updated, else the Key/Value pair is added
  ' Warning: to update the written Key/Value pair on the config file, you need to call Store
  Public Shared Sub SetOption(ByVal OptionName As String, ByVal OptionValue As String)
    Dim dv As DataView = DSoptions.Tables("ConfigValues").DefaultView
    dv.RowFilter = "OptionName='" & OptionName & "'"
    If dv.Count > 0 Then
      dv.Item(0).Item("OptionValue") = OptionValue
    Else
      Dim dr As DataRow = DSoptions.Tables("ConfigValues").NewRow()
      dr("OptionName") = OptionName
      dr("OptionValue") = OptionValue
      DSoptions.Tables("ConfigValues").Rows.Add(dr)
    End If
  End Sub

End Class
