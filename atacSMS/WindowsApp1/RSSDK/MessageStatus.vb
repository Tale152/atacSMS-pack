Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class MessageStatus
        Private rcpt_number As SMSRecipient
        ' SMS recipient
        Private m_status As MessageStatus.SMSStatus
        ' Message status
        Private m_deliveryDate As DateTime
        ' Delivery date
        Public Sub New(ByVal rcpt_number As SMSRecipient, ByVal status As MessageStatus.SMSStatus, ByVal deliveryDate As DateTime)
            Me.rcpt_number = rcpt_number
            Me.m_status = status
            Me.m_deliveryDate = deliveryDate
        End Sub

        Public ReadOnly Property Recipient() As SMSRecipient
            Get
                Return rcpt_number
            End Get
        End Property
        Public ReadOnly Property Status() As SMSStatus
            Get
                Return m_status
            End Get
        End Property
        Public ReadOnly Property DeliveryDate() As DateTime
            Get
                Return m_deliveryDate
            End Get
        End Property

        Public Overloads Overrides Function ToString() As String
            Return New StringBuilder().Append("(rcpt_number=").Append(Me.rcpt_number).Append(",status=").Append(Me.m_status).Append(",deliveryDate=").Append(If(Me.m_deliveryDate.Equals(DateTime.MinValue), "*immediate*", Me.m_deliveryDate.ToString())).Append(")"c).ToString()
        End Function

        Public Shared Function GetStatus(ByVal status_code As String) As SMSStatus
            Try
                Return DirectCast([Enum].Parse(GetType(SMSStatus), status_code, True), SMSStatus)
            Catch generatedExceptionName As Exception
                Return SMSStatus.UNKNOWN
            End Try
        End Function

        Public ReadOnly Property IsError() As Boolean
            Get
                Select Case Me.m_status
                    Case SMSStatus.[ERROR], SMSStatus.TIMEOUT, SMSStatus.TOOM4NUM, SMSStatus.TOOM4USER, SMSStatus.UNKNPFX, SMSStatus.UNKNRCPT
                        Return True
                End Select
                Return False
            End Get
        End Property

        Public Enum SMSStatus
            SCHEDULED
            ' postponed, not jet arrived
            SENT
            ' sent, wait for delivery notification (depending on message type)
            DLVRD
            ' the sms has been correctly delivered to the mobile phone
            [ERROR]
            ' error sending sms
            TIMEOUT
            ' cannot deliver sms to the mobile in 48 hours
            TOOM4NUM
            ' too many messages sent to this number (spam warning)
            TOOM4USER
            ' too many messages sent by this user
            UNKNPFX
            ' unknown/unparsable mobile phone prefix
            UNKNRCPT
            ' unknown recipient
            WAIT4DLVR
            ' message sent, waiting for delivery notification
            WAITING
            ' not yet sent (still active)
            UNKNOWN
            ' received an unknown status code from server (should never happen!)
        End Enum
    End Class
End Namespace
