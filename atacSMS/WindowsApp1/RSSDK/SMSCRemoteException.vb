Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMSCRemoteException
        Inherits Exception
        Private code As Integer
        Public Sub New(ByVal code As Integer, ByVal message As String)
            MyBase.New(message)
            Me.code = code
        End Sub
        Public ReadOnly Property ErrorCode() As Integer
            Get
                Return Me.code
            End Get
        End Property
    End Class
End Namespace
