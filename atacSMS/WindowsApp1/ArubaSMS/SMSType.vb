Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMSType
        Public Shared ReadOnly ALTA As New SMSType("N", "ALTA", True)
        Public Shared ReadOnly STANDARD As New SMSType("LL", "STANDARD", False)
        Public Shared ReadOnly ALL_MESSAGE_TYPES As SMSType() = {ALTA,STANDARD}

        Private m_code As String
        Private description As String
        Private has_custom_tpoa As Boolean
        Private Sub New(ByVal code As String, ByVal description As String, ByVal has_custom_tpoa As Boolean)
            Me.m_code = code
            Me.description = description
            Me.has_custom_tpoa = has_custom_tpoa
        End Sub

        Public Overloads Overrides Function ToString() As String
            Return Me.description
        End Function
        Public ReadOnly Property Code() As String
            Get
                Return Me.m_code
            End Get
        End Property
        Public ReadOnly Property CustomSender() As Boolean
            Get
                Return Me.has_custom_tpoa
            End Get
        End Property
        Public Shared Function fromCode(ByVal code As String) As SMSType
            For Each smstype As SMSType In ALL_MESSAGE_TYPES
                If smstype.Code.Equals(code) Then
                    Return smstype
                End If
            Next
            Return Nothing
        End Function

    End Class
End Namespace
