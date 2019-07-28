Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMS_MO
        Private id_message As Long
        ' SMS sending date
        Private send_date As DateTime
        ' SMS sending date
        Private m_message As String
        ' SMS text message
        Private m_keyword As String
        ' SMS's text first word, if used as a keyword, otherwise null
        Private sms_sender As SMSSender
        ' SMS sender
        Private sms_recipient As SMSRecipient
        ' SMS recipient
        Public Sub New(ByVal id_message As Long, ByVal sms_recipient As SMSRecipient, ByVal sms_sender As SMSSender, ByVal message As String, ByVal send_date As DateTime, ByVal keyword As String)
            Me.id_message = id_message
            Me.sms_recipient = sms_recipient
            Me.sms_sender = sms_sender
            Me.m_message = message
            Me.send_date = send_date
            If String.IsNullOrEmpty(keyword) Then
                Me.m_keyword = Nothing
            Else
                Me.m_keyword = keyword
            End If
        End Sub

        Public ReadOnly Property SendDate() As DateTime
            Get
                Return send_date
            End Get
        End Property
        Public ReadOnly Property Sender() As SMSSender
            Get
                Return sms_sender
            End Get
        End Property
        Public ReadOnly Property Recipient() As SMSRecipient
            Get
                Return sms_recipient
            End Get
        End Property
        Public ReadOnly Property Message() As String
            Get
                Return Me.m_message
            End Get
        End Property
        Public ReadOnly Property IdMessage() As Long
            Get
                Return id_message
            End Get
        End Property
        Public ReadOnly Property Keyword() As String
            Get
                Return m_keyword
            End Get
        End Property

        Public Overloads Overrides Function ToString() As String
            Return New StringBuilder().Append("(send_date=").Append(Me.send_date).Append(",message=").Append(m_message).Append(",sms_sender=").Append(Me.sms_sender).Append(",sms_recipient=").Append(Me.sms_recipient).Append(")"c).ToString()
        End Function

    End Class

End Namespace
