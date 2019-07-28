Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace RS
    Public Class Credit
        Private m_creditType As CreditType
        ' Type of credit.
        Private m_nation As Nation
        ' Nation relative to the credit.
        Private availability As Integer
        ' Credit counter.
        Public Sub New(ByVal credit_type As CreditType, ByVal nation As Nation, ByVal availability As Integer)
            Me.m_creditType = credit_type
            Me.m_nation = nation
            Me.availability = availability
        End Sub

        Public ReadOnly Property CreditType() As CreditType
            Get
                Return m_creditType
            End Get
        End Property
        Public ReadOnly Property Nation() As Nation
            Get
                Return Me.m_nation
            End Get
        End Property
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.availability
            End Get
        End Property

        Public Overloads Overrides Function ToString() As String
            Dim toPrint As StringBuilder = New StringBuilder().Append("(creditType:").Append(Me.m_creditType).Append(",")
            If Me.m_nation IsNot Nothing Then
                toPrint.Append("nation=").Append(Me.m_nation).Append(",")
            End If
            toPrint.Append("count='").Append(Me.availability).Append(")")
            Return toPrint.ToString()
        End Function

    End Class
End Namespace
