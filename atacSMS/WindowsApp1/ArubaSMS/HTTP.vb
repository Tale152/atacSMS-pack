Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Diagnostics

Namespace RS
    Public Class HTTP
        Public Shared Function POST(ByVal uri__1 As String, ByVal parameters As Dictionary(Of String, String)) As String
            Return POST(uri__1, parameters, Nothing, 0)
        End Function
        Public Shared Function POST(ByVal uri__1 As String, ByVal parameters As Dictionary(Of String, String), ByVal proxy As String, ByVal proxyport As Integer) As String
            Dim sb_parameters As New StringBuilder()
            Dim isfirst As Boolean = True
            ' parameters: name1=value1&name2=value2	
            For Each kvp As KeyValuePair(Of String, String) In parameters
                If isfirst Then
                    isfirst = False
                Else
                    sb_parameters.Append("&"c)
                End If
                sb_parameters.Append(kvp.Key).Append("="c).Append(Uri.EscapeDataString(kvp.Value))
            Next
            System.Net.ServicePointManager.Expect100Continue = False
            Dim webRequest__2 As WebRequest = WebRequest.Create(uri__1)

            If Not (Str.nullify(proxy) Is Nothing) Then
                webRequest__2.Proxy = New WebProxy(proxy, proxyport)
            End If
            webRequest__2.ContentType = "application/x-www-form-urlencoded"
            webRequest__2.Method = "POST"
            Debug.Print(sb_parameters.ToString())
            Dim bytes As Byte() = Encoding.ASCII.GetBytes(sb_parameters.ToString())
            Dim os As Stream = Nothing
            Try
                ' send the Post
                webRequest__2.ContentLength = bytes.Length
                'Count bytes to send
                os = webRequest__2.GetRequestStream()
                'Send it
                os.Write(bytes, 0, bytes.Length)
            Catch ex As WebException
                Throw New HTTPException(ex.Message)
            Finally
                If os IsNot Nothing Then
                    os.Close()
                End If
            End Try

            Try
                Dim webResponse As WebResponse = webRequest__2.GetResponse()
                If webResponse Is Nothing Then
                    Return Nothing
                End If
                Dim sr As New StreamReader(webResponse.GetResponseStream())
                Dim res As String = sr.ReadToEnd()
                Return res
            Catch ex As WebException
                Throw New HTTPException(ex.Message)
            End Try
        End Function
    End Class
End Namespace
