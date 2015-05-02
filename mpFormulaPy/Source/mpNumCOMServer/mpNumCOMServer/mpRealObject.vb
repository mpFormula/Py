
'This Module needs To be compiled from SD With "Run As Administrator" because of registration.
	
'To test, run I:\Data\mpFormula40\Toolbox\COM\VBDllCOMServer\bin\x86\Release\Test32bitModuleOnWin64.bat

'In project options, Build events\postbuild event commandline, the whole path to regasm is needed: C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\regasm VBDllCOMServer.dll /tlb:VBDllCOMServer.tlb

'New registration requres some change in text, so that a re-compile does occur.


<ComClass(mpRealObject.ClassId, mpRealObject.InterfaceId, mpRealObject.EventsId)> _
Public Class mpRealObject

#Region "COM Registration"
    Public Const ClassId As String _
    = "A506F09D-20A2-4D29-B82A-7858D99E0AA9"
    Public Const InterfaceId As String _
    = "793F6646-71A1-464B-90A4-7A056D1FC1F7"
    Public Const EventsId As String _
    = "3BBE3955-A632-4FC2-B5B9-3BCC30074CAC"
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
        Return "HelloWorld from mpReal"
  End Function



  Public Function HelloWorld2() As String
    Return "HelloWorld2  from mpReal"
  End Function
#End Region


End Class
