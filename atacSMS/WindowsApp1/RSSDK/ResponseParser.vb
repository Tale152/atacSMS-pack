Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class ResponseParser
        Private Shared ReadOnly SEPARATOR As Char = "|"c
        Private Shared ReadOnly NEWLINE As Char = ";"c
        Private response As Char()
        Private cursor As Integer
        Private isok As Boolean
        Private errcode As Integer
        Private errmsg As String

        Public Sub New(ByVal str_response As String)
            Me.response = str_response.ToCharArray()
            Me.cursor = 0
            If response.Length >= 2 Then
                Dim stat As String = NextString
                If "OK".Equals(stat) Then
                    isok = True
                End If
                If "KO".Equals(stat) Then
                    isok = False
                    errcode = NextInt
                    errmsg = NextString
                End If
            End If
        End Sub

        Public Function GoNextLine() As Boolean
            While response(cursor) <> NEWLINE
                cursor = cursor + 1
                If cursor >= response.Length Then
                    Return False
                End If
            End While
            cursor = cursor + 1
            Return response.Length <> cursor
        End Function

        Public ReadOnly Property NextString() As String
            Get
                Dim sb As New StringBuilder()
                While response(cursor) <> SEPARATOR AndAlso response(cursor) <> NEWLINE
                    sb.Append(response(cursor))
                    cursor += 1
                    If cursor >= response.Length Then
                        Exit While
                    End If
                End While
                If cursor < response.Length AndAlso response(cursor) <> NEWLINE Then
                    cursor += 1
                End If
                Dim res As String = Uri.UnescapeDataString(sb.ToString())
                Return res
            End Get
        End Property
        Public ReadOnly Property NextInt() As Integer
            Get
                Dim str_i As String = NextString
                Return Integer.Parse(str_i)
            End Get
        End Property
        Public ReadOnly Property NextLong() As Long
            Get
                Dim str_i As String = NextString
                Return Long.Parse(str_i)
            End Get
        End Property
        Public ReadOnly Property NextDate() As DateTime
            Get
                Dim dt As System.Nullable(Of DateTime) = DDate.Parse(NextString)
                If dt.HasValue Then
                    Return dt.Value
                Else
                    Return DateTime.MinValue
                End If
            End Get
        End Property
        Public ReadOnly Property NextOptionalDate() As System.Nullable(Of DateTime)
            Get
                Return DDate.Parse(NextString)
            End Get
        End Property
        Public ReadOnly Property NextSMSRecipient() As SMSRecipient
            Get
                Return New SMSRecipient(NextString)
            End Get
        End Property
        Public ReadOnly Property NextSMSType() As SMSType
            Get
                Dim str_sms_type As String = NextString
                Return SMSType.fromCode(str_sms_type)
            End Get
        End Property
        Public ReadOnly Property NextSMSSender() As SMSSender
            Get
                Return New SMSSender(NextString)
            End Get
        End Property
        Public ReadOnly Property NextCreditType() As CreditType
            Get
                Dim str_credit_type As String = NextString
                Return CreditType.fromCode(str_credit_type)
            End Get
        End Property
        Public ReadOnly Property NextMessageStatus_Status() As MessageStatus.SMSStatus
            Get
                Return MessageStatus.GetStatus(NextString)
            End Get
        End Property
        Public ReadOnly Property NextNation() As Nation
            Get
                Dim str_iso3166 As String = NextString
                If String.IsNullOrEmpty(str_iso3166) Then
                    Return Nations.NO_NATION
                End If
                Return Nations.I(str_iso3166)
            End Get
        End Property
        Public ReadOnly Property NextBool() As Boolean
            Get
                Dim str_b As String = NextString
                Return Boolean.Parse(str_b)
            End Get
        End Property

        Public ReadOnly Property Ok() As Boolean
            Get
                Return Me.isok
            End Get
        End Property
        Public ReadOnly Property ErrorCode() As Integer
            Get
                Return Me.errcode
            End Get
        End Property
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return Me.errmsg
            End Get
        End Property
    End Class

End Namespace
