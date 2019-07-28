Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SentSMS
        Private order_id As String
        Private create_time As DateTime
        Private sms_type As SMSType
        Private m_sender As SMSSender
        Private recipients_count As Integer
        Private scheduled_send As System.Nullable(Of DateTime)

        Public Sub New(ByVal order_id As String, ByVal create_time As DateTime, ByVal sms_type As SMSType, ByVal sender As SMSSender, ByVal recipients_count As Integer, ByVal scheduled_send As System.Nullable(Of DateTime))
            Me.order_id = order_id
            Me.create_time = create_time
            Me.sms_type = sms_type
            Me.m_sender = sender
            Me.recipients_count = recipients_count
            Me.scheduled_send = scheduled_send
        End Sub

        Public ReadOnly Property OrderId() As String
            Get
                Return order_id
            End Get
        End Property
        Public ReadOnly Property CreateTime() As DateTime
            Get
                Return create_time
            End Get
        End Property
        Public ReadOnly Property TypeOfSMS() As SMSType
            Get
                Return sms_type
            End Get
        End Property
        Public ReadOnly Property Sender() As SMSSender
            Get
                Return m_sender
            End Get
        End Property
        Public ReadOnly Property RecipientsCount() As Integer
            Get
                Return recipients_count
            End Get
        End Property
        Public ReadOnly Property ScheduledSend() As System.Nullable(Of DateTime)
            Get
                Return scheduled_send
            End Get
        End Property
        Public ReadOnly Property Scheduled() As Boolean
            Get
                Return Me.scheduled_send.HasValue
            End Get
        End Property
    End Class

End Namespace
