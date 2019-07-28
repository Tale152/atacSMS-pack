Public Class Authentication

    Public Shared operatorName 'used to excude current operator from operator list into Operators form
    Public Shared operatorAdmin 'used to determine whether or not operator is an admin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        GoToMainMenu()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        GoToMainMenuIfEnterKeyPressed(e)
    End Sub

    Private Sub txtPsw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPsw.KeyPress
        GoToMainMenuIfEnterKeyPressed(e)
    End Sub

    Private Sub GoToMainMenuIfEnterKeyPressed(e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            GoToMainMenu()
        End If
    End Sub

    Private Sub GoToMainMenu()
        'query returning number of credentials matching ones insered by user
        Dim query = "SELECT COUNT(Username) " +
                    "FROM Operatori " +
                    "WHERE Username = '" + txtUser.Text + "' " +
                    "AND Password = '" + txtPsw.Text + "'"
        'opening connection to db
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        'launching query
        Dim comm As New SqlCommand(query, cnn)
        'if query returned one (valid user) then login, error MsgBox otherwise
        If (Convert.ToInt16(comm.ExecuteScalar()) = 1) Then
            operatorName = txtUser.Text
            'query to check whether or not logged operator is admin
            query = "SELECT Amministratore " +
                    "FROM Operatori " +
                    "WHERE Username = '" + txtUser.Text + "' "
            comm = New SqlCommand(query, cnn)
            Dim reader As SqlDataReader = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            operatorAdmin = dt.Rows(0).Item("Amministratore")
            MainForm.Show()
            cnn.Close() 'closing db connection
            Me.Close()
        Else
            MsgBox("Username o password Errata", MsgBoxStyle.OkOnly, "Errore")
            cnn.Close() 'closing db connection
        End If
    End Sub

    Private Sub Authentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class