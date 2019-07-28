Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public MustInherit Class PhoneNumber
        Protected m_number As String

        Public Sub New(ByVal number As String)
            Me.m_number = number
        End Sub

        Public MustOverride Function isValid() As Boolean

        Public ReadOnly Property Number() As String
            Get
                Return Me.m_number
            End Get
        End Property

    End Class
End Namespace
