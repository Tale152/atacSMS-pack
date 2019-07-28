Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class CreditType
        Public Shared ReadOnly ALTA As New CreditType("N", "ALTA")
        Public Shared ReadOnly STANDARD As New CreditType("LL", "STANDARD")
        Public Shared ReadOnly OTHER As New CreditType("EE", "Foreign")
        Public Shared ReadOnly ALL_CREDIT_TYPES As CreditType() = {ALTA, STANDARD, OTHER}

        Private m_code As String
        Private m_description As String
        Public Sub New(ByVal code As String, ByVal description As String)
            Me.m_code = code
            Me.m_description = description
        End Sub

        Public Overloads Overrides Function ToString() As String
            Return Me.m_description
        End Function
        Public Shared Function fromCode(ByVal code As String) As CreditType
            For Each ct As CreditType In ALL_CREDIT_TYPES
                If code.Equals(ct.Code) Then
                    Return ct
                End If
            Next
            Return Nothing
        End Function

        Public ReadOnly Property Code() As String
            Get
                Return Me.m_code
            End Get
        End Property
        Public ReadOnly Property Description() As String
            Get
                Return Me.m_description
            End Get
        End Property

    End Class
End Namespace
