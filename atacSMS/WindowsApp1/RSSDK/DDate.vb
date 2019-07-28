Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Globalization

Namespace RS
    Public Class DDate
        Public Shared ReadOnly STANDARD_FORMAT As String = "yyyyMMddHHmmss"
        Public Shared ReadOnly STANDARD_TIME_FORMAT As String = "HH:mm"

        Public Shared Function Format(ByVal [date] As DateTime) As String
            Return [date].ToString(STANDARD_FORMAT)
        End Function

        Public Shared Function Parse(ByVal [date] As String) As System.Nullable(Of DateTime)
            If String.IsNullOrEmpty([date]) Then
                Return Nothing
            End If
            Return DateTime.ParseExact([date], STANDARD_FORMAT, CultureInfo.CurrentCulture)
        End Function

    End Class
End Namespace
