Imports WindowsApp.RS
Imports System.Net.Mail

Public Class Credentials

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'go back to MainFrom
        MainForm.Show()
        Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'checking that all credentials textboxes are filled
        If (txtSMSUser.Text = "" Or txtSMSPsw.Text = "" Or txtMailUser.Text = "" Or txtMailPsw.Text = "") Then
            MsgBox("Riempire tutti i campi prima di procedere", MsgBoxStyle.OkOnly, "")
        Else
            If (checkMailSintax() And testSMS() And testMail()) Then
                'if all test passed than enable save button
                MsgBox("Connessione attraverso le credenziali effettuata con successo", MsgBoxStyle.OkOnly, "")
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Function checkMailSintax() As Boolean
        'checking wether or not user has inputed a valid mail to prevent errors while testing it
        If txtMailUser.Text.Contains("@") Then
            If txtMailUser.Text.Split("@").Last.Contains(".") Then
                Return True
            End If
        End If
        MsgBox("Errore, l'user della email deve rispettare la forma xxx@yyy.zzz", MsgBoxStyle.OkOnly, "Errore")
        Return False
    End Function

    Private Sub UpdateCredentials(c As SqlConnection, deleteQuery As String, insertionQuery As String)
        Dim comm = New SqlCommand(deleteQuery, c)
        comm.ExecuteNonQuery()  'executing deleteQuery
        comm = New SqlCommand(insertionQuery, c)
        comm.ExecuteNonQuery()  'executing insertionQuery
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening db connection
        'updating ArubaSMS credentials
        UpdateCredentials(cnn, "DELETE CredenzialiArubaSMS",
                          "INSERT INTO CredenzialiArubaSMS(Id,Password) " +
                            "VALUES('" + txtSMSUser.Text + "','" + txtSMSPsw.Text + "')")
        'updating mail credentials
        UpdateCredentials(cnn, "DELETE CredenzialiMail", "INSERT INTO CredenzialiMail(Mail, Password) " +
                            "VALUES('" + txtMailUser.Text + "','" + txtMailPsw.Text + "')")
        cnn.Close() 'closing db connection
        'go back to MainForm
        MainForm.Show()
        Close()
    End Sub

    Private Function testSMS() As Boolean
        'setting ArubaSMS credentials
        RS.Config.USERNAME = txtSMSUser.Text.ToString
        RS.Config.PASSWORD = txtSMSPsw.Text.ToString
        Dim connection As SMSCConnection    'opening connection to ArubaSMS
        Try
            connection = New SMSCHTTPConnection()   'testing ArubaSMS credentials 
        Catch smsce As SMSCException
            System.Console.WriteLine("exception: " + smsce.ToString)
            Return False
        Catch invalidUserPsw As SMSCRemoteException
            'returning false if wrong credentials
            MsgBox("Username o password errati per il servizio Aruba SMS", MsgBoxStyle.OkOnly, "")
            Return False
        End Try
        connection.logout()
        Return True
    End Function

    Private Function testMail() As Boolean
        Dim emailMessage As New MailMessage()
        Try
            'setting mail parameters
            emailMessage.From = New MailAddress(txtMailUser.Text)
            emailMessage.To.Add(txtMailUser.Text)   'adding inputed mail to mailList to test if mail works
            emailMessage.Subject = "Mail di test per servizio segnalazioni"
            emailMessage.IsBodyHtml = False
            emailMessage.Body = ""
            Dim SMTP As New SmtpClient
            'obtaining mail host slicing inputed mail
            Dim split As String() = txtMailUser.Text.Split("@").Last.Split(".")
            SMTP.Host = "smtp." + split.ElementAt(split.Length - 2) + "." + split.ElementAt(split.Length - 1)
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.UseDefaultCredentials = False
            SMTP.Credentials = New System.Net.NetworkCredential(txtMailUser.Text, txtMailPsw.Text)
            SMTP.Send(emailMessage)
        Catch ex As Exception
            MsgBox("Errore durante la connessione alla mail", MsgBoxStyle.OkOnly, "")
            Return False    'returning false if something went wrong
        End Try
        Return True
    End Function

    Private Sub txtSMSUser_TextChanged(sender As Object, e As EventArgs) Handles txtSMSUser.TextChanged
        'setting save button not enabled so user has to pass test before saving
        btnSave.Enabled = False
    End Sub

    Private Sub txtSMSPsw_TextChanged(sender As Object, e As EventArgs) Handles txtSMSPsw.TextChanged
        'setting save button not enabled so user has to pass test before saving
        btnSave.Enabled = False
    End Sub

    Private Sub txtMailUser_TextChanged(sender As Object, e As EventArgs) Handles txtMailUser.TextChanged
        'setting save button not enabled so user has to pass test before saving
        btnSave.Enabled = False
    End Sub

    Private Sub txtMailPsw_TextChanged(sender As Object, e As EventArgs) Handles txtMailPsw.TextChanged
        'setting save button not enabled so user has to pass test before saving
        btnSave.Enabled = False
    End Sub

    Private Sub Credenziali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading pre-existing credentials
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        'loading ArubaSMS credentials
        LoadCredentials(txtSMSUser, txtSMSPsw, "SELECT TOP (1) * FROM CredenzialiArubaSMS", cnn)
        'loading mail credentials
        LoadCredentials(txtMailUser, txtMailPsw, "SELECT TOP(1) * FROM CredenzialiMail", cnn)
        cnn.Close()
    End Sub

    Private Sub LoadCredentials(txt1 As TextBox, txt2 As TextBox, query As String, connection As SqlConnection)
        Dim comm As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        If dt.Rows.Count > 0 Then
            txt1.Text = dt.Rows.Item(0).Item(0).ToString
            txt2.Text = dt.Rows.Item(0).Item(1).ToString
        End If
    End Sub
End Class