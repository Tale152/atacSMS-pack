Public Class MainForm

    Private Sub btnOperators_Click(sender As Object, e As EventArgs) Handles btnOperators.Click
        GoToFormIfAdmin(Operators)
    End Sub

    Private Sub btnSendReport_Click(sender As Object, e As EventArgs) Handles btnSendReport.Click
        If (CheckSMSAndMailCredentials()) Then
            GoToForm(SendReport)
        End If
    End Sub

    Private Sub btnConsultReports_Click(sender As Object, e As EventArgs) Handles btnConsultReports.Click
        If (CheckSMSAndMailCredentials()) Then
            GoToForm(ConsultReports)
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        GoToForm(Users)
    End Sub

    Private Sub btnCredentials_Click(sender As Object, e As EventArgs) Handles btnCredentials.Click
        GoToFormIfAdmin(Credentials)
    End Sub

    Private Function CheckSMSAndMailCredentials() As Boolean
        'opening db connection
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        'check if ArubaSMS's credentials are setted
        Dim comm As New SqlCommand("SELECT COUNT(id) FROM CredenzialiArubaSMS", cnn)
        If (Convert.ToInt16(comm.ExecuteScalar()) = 1) Then
            'check if mail's credentials are setted
            comm = New SqlCommand("SELECT COUNT(mail) FROM CredenzialiMail", cnn)
            If (Convert.ToInt16(comm.ExecuteScalar()) = 1) Then
                cnn.Close() 'closing connection to db
                Return True 'credentials setted
            End If
        End If
        cnn.Close() 'closing connection to db
        MsgBox("Le credenziali per mail e sms non sono impostate", MsgBoxStyle.OkOnly, "")
        Return False 'credentials not setted
    End Function

    Private Sub GoToForm(form As Form)
        form.Show()
        Close()
    End Sub

    Private Sub GoToFormIfAdmin(form As Form)
        If Authentication.operatorAdmin Then
            GoToForm(form)
        Else
            MsgBox("Non si dispone dei permessi da amministratore " +
                "per accedere a questa sezione, contattare un amministratore",
                   MsgBoxStyle.OkOnly, "Impossibile procedere")
        End If
    End Sub

End Class