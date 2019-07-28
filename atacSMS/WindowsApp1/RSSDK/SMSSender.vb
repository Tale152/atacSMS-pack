Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMSSender
        Inherits PhoneNumber

        Public Sub New(ByVal tpoa As [String])
            MyBase.New(tpoa)
        End Sub

        Public Overloads Overrides Function isValid() As Boolean
            Return Me.Number IsNot Nothing AndAlso Str.isValidTPOA(Me.Number)
        End Function

        Public Overloads Overrides Function ToString() As String
            Return New StringBuilder().Append("(tpoa=").Append(Me.number).Append(")"c).ToString()
        End Function

    End Class
End Namespace
