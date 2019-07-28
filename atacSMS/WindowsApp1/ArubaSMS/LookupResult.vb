Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class LookupResult
        Private m_valid As Boolean = False
        Private order_id As String
        Private m_recipient As SMSRecipient
        Private m_nation As Nation
        Private m_nationName As String
        Private mobileop As String

        Public Sub New(ByVal numLookupID As String)
            Me.m_valid = False
        End Sub
        Public Sub New(ByVal order_id As String, ByVal recipient As SMSRecipient, ByVal nation As Nation, ByVal nationName As String, ByVal mobileop As String)
            Me.m_valid = True
            Me.order_id = order_id
            Me.m_recipient = recipient
            Me.m_nation = nation
            Me.m_nationName = nationName
            Me.mobileop = mobileop
        End Sub

        '*
        '         * The method verify if the <code>Nation</code> of 
        '         * the number lookup recipient is one to which we can send.
        '         * 
        '         * @return <code>true</code> in case of success, <code>false</code> otherwise
        '         

        Public Function CanSendTo() As Boolean
            Return Valid AndAlso Me.m_nation <> Nations.UNKNOWN_NATION
        End Function

        '*
        '         * The result of the number lookup call.
        '         * 
        '         * @return <code>true</code> in case of success, <code>false</code> otherwise
        '         

        Public ReadOnly Property Valid() As Boolean
            Get
                Return m_valid
            End Get
        End Property

        Public ReadOnly Property OrderId() As String
            Get
                Return order_id
            End Get
        End Property

        Public ReadOnly Property Recipient() As SMSRecipient
            Get
                Return m_recipient
            End Get
        End Property

        Public ReadOnly Property Nation() As Nation
            Get
                Return m_nation
            End Get
        End Property

        Public ReadOnly Property NationName() As String
            Get
                Return m_nationName
            End Get
        End Property

        Public ReadOnly Property MobileCompany() As String
            Get
                Return mobileop
            End Get
        End Property

        Public Overloads Overrides Function ToString() As String
            Dim sb As StringBuilder = New StringBuilder().Append("(valid=").Append(Me.m_valid).Append(",order_id=").Append(Me.order_id)
            If Me.m_valid Then
                sb.Append(",recipient=").Append(Me.m_recipient).Append(",nation=").Append(Me.m_nation).Append(",nationName=").Append(Me.m_nationName).Append(",mobileop=").Append(Me.mobileop).Append(")"c)
            Else
                sb.Append(")"c)
            End If
            Return sb.ToString()
        End Function

    End Class

End Namespace
