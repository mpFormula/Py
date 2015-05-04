
'This Module needs To be compiled from SD With "Run As Administrator" because of registration.
	
'To test, run I:\Data\mpFormula40\Toolbox\COM\VBDllCOMServer\bin\x86\Release\Test32bitModuleOnWin64.bat

'In project options, Build events\postbuild event commandline, the whole path to regasm is needed: C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\regasm VBDllCOMServer.dll /tlb:VBDllCOMServer.tlb

'New registration requres some change in text, so that a re-compile does occur.



<ComClass(mpLibObject.ClassId, mpLibObject.InterfaceId, mpLibObject.EventsId)> _
Public Class mpLibObject

#Region "COM Registration"

    Public Const ClassId As String _
    = "C1900F76-05AC-4306-BB9F-20BF0C35D38F"
    Public Const InterfaceId As String _
    = "0281989A-DFCC-4D6A-BE8E-C73690CD57B7"
    Public Const EventsId As String _
    = "DC02527F-EA4F-42CB-BB0B-3221A12C7EE2"

#End Region



#Region "Properties"

    Private fField As Single = 0

    Public Property FloatProperty() As Single
        Get
            Return Me.fField
        End Get
        Set(ByVal value As Single)
            Me.fField = value
        End Set
    End Property

#End Region



#Region "Methods"

  Public Function HelloWorld() As String
    Return "HelloWorld from mpLib"
  End Function


Public Function Real() As mpRealObject
	Dim m1 As New mpRealObject
    Return m1
  End Function



  Public Function HelloWorld2() As String
    Return "HelloWorld2  from mpLib"
  End Function



#End Region


End Class
