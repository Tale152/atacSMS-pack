Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMSRecipient
        Inherits PhoneNumber
        Private m_international As Boolean

        '*
        '         * The constructor add the default international prefix clean the phone
        '         * number string from non numeric digits.
        '         * @throws InvalidRecipientException 
        '         

        Public Sub New(ByVal number As String)
            MyBase.New(number)
            cleanIntl()
        End Sub

        Private Sub cleanIntl()
            If Not String.IsNullOrEmpty(Me.number) Then
                If Me.number(0) = "+"c Then
                    Me.m_number = Me.Number.Substring(1)
                    Me.m_international = True
                Else
                    If Me.number.StartsWith("00") Then
                        Me.m_number = Me.Number.Substring(2)
                        Me.m_international = True
                    Else
                        Me.m_international = False
                    End If
                End If
                Me.m_number = Str.stripNonNumeric(Me.m_number)
            End If
        End Sub

        '*
        '         * Check that the number is a number :)
        '         * 
        '         * @return true or false
        '         

        Public Overloads Overrides Function isValid() As Boolean
            If String.IsNullOrEmpty(Me.number) Then
                Return False
            End If
            Return Me.number.Length > 2
        End Function

        Public ReadOnly Property International() As Boolean
            Get
                Return Me.m_international
            End Get
        End Property

        '*
        '         * The function get the Nation of recipient.
        '         * 
        '         * @return an instance of <code>Nation</code> relative to the recipient,
        '         * <code>NO_NATION</code> if the recipient hasn't an international prefix,
        '         * <code>UNKNOWN_NATION</code> if the prefix is unknown, <code>null</code>
        '         * if the object <code>Recipient</code> isn't a valid recipient.
        '         

        Public ReadOnly Property Nation() As Nation
            Get
                If Not isValid() Then
                    Return Nations.UNKNOWN_NATION
                End If
                If Not International Then
                    Return Nations.NO_NATION
                End If
                Return Nations.I.getPhoneNumberNation(Me.number)
            End Get
        End Property

        Public Function getNumber() As String
            Return If(International, "+" & Me.number, Me.number)
        End Function

        Public Overloads Overrides Function ToString() As String
            Return getNumber()
        End Function
    End Class
End Namespace
