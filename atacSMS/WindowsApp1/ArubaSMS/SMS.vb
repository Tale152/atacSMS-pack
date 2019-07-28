Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMS
        Private order_id As String
        ' sms order ID
        Private sms_type As SMSType
        ' SMS type
        Private scheduled_delivery As System.Nullable(Of DateTime)
        ' scheduled send date (null if immediate)
        Private m_message As String
        ' SMS text
        Private sms_sender As SMSSender
        ' SMS sender
        Private sms_recipients As List(Of SMSRecipient)
        ' The list of recipients
        Private str_recipients As String
        ' list of recipients separated by ,
        Public Sub New()
            Me.sms_recipients = New List(Of SMSRecipient)()
            ' default SMS type is ALTA
            Me.sms_type = SMSType.ALTA
        End Sub

        Public Property Message() As String
            Get
                Return Me.m_message
            End Get
            Set(ByVal value As String)
                If (value.Length = 0) OrElse (Str.countGSMChars(value) > 1000) Then
                    Throw New InvalidMessageContentException("invalid message content length (" & value.Length & ")")
                End If
                Me.m_message = value
            End Set
        End Property

        Public ReadOnly Property Length() As Integer
            Get
                Return Str.countGSMChars(Me.m_message)
            End Get
        End Property

        Public ReadOnly Property CountSMS() As Integer
            Get
                Return If(Length <= 160, 1, ((Length - 1) / 153) + 1)
            End Get
        End Property

        '*
        '         * Sets the message ID, assigned by the server when null
        '         

        Public Property OrderId() As String
            Get
                Return Me.order_id
            End Get
            Set(ByVal value As String)
                Me.order_id = value
            End Set
        End Property

        Public Property ScheduledDelivery() As DateTime
            Get
                If Me.scheduled_delivery.HasValue Then
                    Return Me.scheduled_delivery.Value
                Else
                    Return DateTime.Now
                End If
            End Get
            Set(ByVal value As DateTime)
                If value.Ticks <= DateTime.Now.Ticks Then
                    Me.scheduled_delivery = Nothing
                Else
                    Me.scheduled_delivery = value
                End If
            End Set
        End Property
        Public Sub setImmediate()
            Me.scheduled_delivery = Nothing
        End Sub
        Public ReadOnly Property Immediate() As Boolean
            Get
                Return Not Me.scheduled_delivery.HasValue
            End Get
        End Property

        Public Property TypeOfSMS() As SMSType
            Get
                Return Me.sms_type
            End Get
            Set(ByVal value As SMSType)
                Me.sms_type = value
            End Set
        End Property

        Public Property SMSSender() As String
            Get
                Return Me.sms_sender.Number
            End Get
            Set(ByVal value As String)
                Me.sms_sender = New SMSSender(value)
            End Set
        End Property

        Public ReadOnly Property Recipients() As IList(Of SMSRecipient)
            Get
                Return Me.sms_recipients.AsReadOnly()
            End Get
        End Property

        '*
        '         * The function checks the <code>SMSRrecipient</tt> and then adds it to the sms.
        '         * 
        '         * @param recipient the <code>SMSRrecipient</tt> of the sms
        '         * @throws InvalidRecipientException
        '         

        Public Sub addSMSRecipient(ByVal recipient As SMSRecipient)
            If Not recipient.isValid() Then
                Throw New InvalidRecipientException("Invalid SMS recipient: " & recipient.ToString())
            End If
            Me.sms_recipients.Add(recipient)
        End Sub
        '*
        '         * The function adds a sms recipient to the sms.
        '         * 
        '         * @param str_recipient the recipient phone number.
        '         * @throws InvalidRecipientException
        '         

        Public Sub addSMSRecipient(ByVal str_recipient As String)
            Me.addSMSRecipient(New SMSRecipient(str_recipient))
        End Sub
        Public Property StrRecipients() As String
            Get
                Return Me.str_recipients
            End Get
            Set(ByVal value As String)
                Me.str_recipients = value
            End Set
        End Property

        '*
        '         * Checks that sender, recipient, message and smsType are all OK.
        '         * 
        '         

        Public Sub validate()
            If sms_recipients.Count = 0 And String.IsNullOrEmpty(str_recipients) Then
                Throw New InvalidRecipientException("Invalid SMS recipient: no recipients specified!")
            End If
            If sms_type Is Nothing Then
                Throw New SMSCException("Invalid NULL message type")
            End If
            If sms_type.CustomSender AndAlso sms_sender Is Nothing Then
                Throw New InvalidSenderException("Invalid NULL sender")
            End If
            If m_message Is Nothing Then
                Throw New InvalidMessageContentException("message is empty")
            End If
        End Sub

        Public Overloads Overrides Function ToString() As String
            Dim sb As StringBuilder = New StringBuilder().Append("(id_message=").Append(Me.order_id).Append(",smsType=").Append(Me.sms_type).Append(",send_date=").Append(Me.scheduled_delivery).Append(",message=").Append(Me.m_message).Append(",smsSender=").Append(Me.sms_sender).Append(",smsRecipients:")
            Dim i As Integer = 0
            If String.IsNullOrEmpty(str_recipients) Then
                For Each recipient As SMSRecipient In sms_recipients
                    If System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1) > 0 Then
                        sb.Append(","c)
                    End If
                    sb.Append(recipient)
                Next
            Else
                sb.Append(str_recipients)
            End If
            sb.Append(")"c)
            Return sb.ToString()
        End Function

    End Class

End Namespace
