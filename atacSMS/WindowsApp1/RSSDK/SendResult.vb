Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SendResult
        Private sent_smss As Integer
        ' The number of reached recipients
        Private order_id As String
        ' sms order ID
        Public Sub New(ByVal order_id As String, ByVal sent_smss As Integer)
            Me.order_id = order_id
            Me.sent_smss = sent_smss
        End Sub

        Public ReadOnly Property CountSentSMS() As Integer
            Get
                Return sent_smss
            End Get
        End Property

        Public ReadOnly Property OrderId() As String
            Get
                Return order_id
            End Get
        End Property

        Public Overloads Overrides Function ToString() As String
            Return New StringBuilder().Append("(order_id=").Append(Me.order_id).Append(",sent_smss=").Append(Me.sent_smss).Append(")"c).ToString()
        End Function

    End Class
End Namespace
