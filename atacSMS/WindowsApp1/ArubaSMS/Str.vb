Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions

Namespace RS
    Public Class Str

        Private Shared nonnumeric As New Regex("[^0-9]")
        Public Shared Function stripNonNumeric(ByVal toclean As String) As String
            If String.IsNullOrEmpty(toclean) Then
                Return toclean
            End If
            Return nonnumeric.Replace(toclean, String.Empty)
        End Function

        '*<p>
        '         * The message origin, also known as TPOA (Transmission Path Originating Address) 
        '         * is the SMS header field that contains the message sender's number.
        '         * ValueSMS can alter this field to include reply path information 
        '         * (the user's own phone number) or other branding information, 
        '         * such as the company name.
        '         * </p>
        '         * <p>
        '         * The TPOA field is limited by GSM standards to:<br>
        '         * - maximum 16 digits if the origin is numeric (e.g. a phone number), or<br>
        '         * - maximum 11 alphabet characters and digits if the origin is alphanumeric (e.g. a company name).
        '         * </p>
        '         * 
        '         

        Private Shared zerozerointernational As New Regex("00[0-9]{7,16}")
        Private Shared plusinternational As New Regex("\+[0-9]{7,16}")
        Public Shared Function isValidTPOA(ByVal tpoa As String) As Boolean
            Return zerozerointernational.IsMatch(tpoa) OrElse plusinternational.IsMatch(tpoa) OrElse tpoa.Length < 12
        End Function

        Public Shared Function nullify(ByVal str As String) As String
            If str Is Nothing Then
                Return Nothing
            End If
            If str.Trim().Equals(String.Empty) Then
                Return Nothing
            End If
            Return str
        End Function

        Public Shared Function countGSMChars(ByVal msg As String) As Integer
            Dim msgc As Char() = msg.ToCharArray()
            Dim len As Integer = 0
            For Each c As Char In msgc
                Select Case c
                    Case "|"c, "^"c, "€"c, "}"c, "{"c, "["c, _
                     "~"c, "]"c, "\"c
                        len += 1
                        Exit Select
                End Select
                len += 1
            Next
            Return len
        End Function

        Public Shared Function join(ByVal separator As Char, ByVal strings As String()) As [String]
            Dim sb As New StringBuilder()
            For Each s As String In strings
                If sb.Length > 0 Then
                    sb.Append(separator)
                End If
                sb.Append(s)
            Next
            Return sb.ToString()
        End Function

    End Class

End Namespace
