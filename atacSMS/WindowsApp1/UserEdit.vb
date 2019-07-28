Public Class UserEdit

    Public creation As Boolean
    Public originalID As String

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Le modifiche andranno perse, continuare?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Users.Show()
            Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkObligatoryFields() Then
            If creation Then
                userCreation()
            Else
                userUpdate()
            End If
        End If
    End Sub

    Private Sub goToUser(c As SqlConnection, msg As String)
        c.Close()
        MsgBox(msg, MsgBoxStyle.OkOnly, "")
        Users.Show()
        Close()
    End Sub

    Private Sub userCreation()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        If Not checkPKExistence(cnn) Then
            createUserSQL(cnn)
            goToUser(cnn, "Utenza inserita correttamente")
        Else
            cnn.Close()
            MsgBox("Impossibile procedere, esiste già un'utenza con quel codice", MsgBoxStyle.OkOnly, "Errore")
        End If
    End Sub

    Private Sub userUpdate()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        If (txtUser.Text = originalID) Then
            updateUserSQL(cnn)
            goToUser(cnn, "Utenza modificata correttamente")
        Else
            If Not checkPKExistence(cnn) Then
                updateUserSQL(cnn)
                goToUser(cnn, "Utenza modificata correttamente")
            Else
                cnn.Close()
                MsgBox("Impossibile procedere, il codice Utenza è stato modificato ed esiste già un'utenza con quel codice", MsgBoxStyle.OkOnly, "Errore")
            End If
        End If
    End Sub

    Private Sub updateUserSQL(c As SqlConnection)
        Dim updateQuery = "UPDATE UTENZE " +
            "SET CodiceUtenza = '" + txtUser.Text + "', " +
            "Ramo = '" + txtBranch.Text + "', " +
            "Cognome = '" + txtSurname.Text + "', " +
            "Nome = '" + txtName.Text + "', " +
            "Via = '" + txtAddress.Text + "', " +
            "CAP = '" + txtCAP.Text + "', " +
            "Citta = '" + txtCity.Text + "', " +
            "Provincia = '" + txtRegion.Text + "', " +
            "Telefono = '" + txtPhone.Text + "', " +
            "Cellulare = '" + txtMobilePhone.Text + "', " +
            "Mail = '" + txtMail.Text + "' " +
            "WHERE CodiceUtenza = '" + originalID + "'"
        Dim comm As New SqlCommand(updateQuery, c)
        comm.ExecuteNonQuery()
    End Sub

    Private Sub createUserSQL(c As SqlConnection)
        Dim insertQuery = "INSERT INTO Utenze(CodiceUtenza, Ramo, Cognome, Nome, " +
                        "Via, CAP, Citta, Provincia, Telefono, Cellulare, Mail) " +
                        "VALUES('" + txtUser.Text + "', " +
                        "'" + txtBranch.Text + "', " +
                        "'" + txtSurname.Text + "', " +
                        "'" + txtName.Text + "', " +
                        "'" + txtAddress.Text + "', " +
                        "'" + txtCAP.Text + "', " +
                        "'" + txtCity.Text + "', " +
                        "'" + txtRegion.Text + "', " +
                        "'" + txtPhone.Text + "', " +
                        "'" + txtMobilePhone.Text + "', " +
                        "'" + txtMail.Text + "') "
        Dim comm As New SqlCommand(insertQuery, c)
        comm.ExecuteNonQuery()
    End Sub

    Function checkPKExistence(c As SqlConnection) As Boolean
        'checks wether or not user's pk already exists
        Dim comm As New SqlCommand("SELECT COUNT(CodiceUtenza) " +
                                   "FROM Utenze " +
                                   "WHERE CodiceUtenza ='" + txtUser.Text + "'", c)
        If (Convert.ToInt16(comm.ExecuteScalar()) = 0) Then
            Return False
        End If
        Return True
    End Function

    Function checkObligatoryFields() As Boolean
        If Not checkTxtBox(txtUser.Text) Then
            MsgBox("Il campo Utenza non può essere vuoto", MsgBoxStyle.OkOnly, "")
        ElseIf Not checkTxtBox(txtBranch.Text) Then
            MsgBox("Il campo Ramo non può essere vuoto", MsgBoxStyle.OkOnly, "")
        ElseIf Not checkTxtBox(txtName.Text) Then
            MsgBox("Il campo Nome non può essere vuoto", MsgBoxStyle.OkOnly, "")
        ElseIf Not checkTxtBox(txtSurname.Text) Then
            MsgBox("Il campo Cognome non può essere vuoto", MsgBoxStyle.OkOnly, "")
        ElseIf Not checkTxtBox(txtMobilePhone.Text) And Not checkTxtBox(txtMail.Text) Then
            MsgBox("Almeno un campo tra Cellulare e Mail deve essere presente", MsgBoxStyle.OkOnly, "")
        Else
            Return checkMailSyntax()
        End If
        Return False
    End Function

    Private Function checkMailSyntax() As Boolean
        If txtMail.Text.Count = 0 Then
            Return True
        End If
        If txtMail.Text.Contains("@") Then
            Dim split As String() = txtMail.Text.Split("@").Last.Split(".")
            If split.Count >= 2 Then
                Return True
            End If
        End If
        MsgBox("Errore nella sintassi della mail", MsgBoxStyle.OkOnly, "Errore")
        Return False
    End Function

    Private Function checkTxtBox(txt As String) As Boolean
        'checks that text isn't empty
        If (txt.Count = 0) Then
            Return False
        End If
        Return True
    End Function

    Private Sub txtMobilePhone_TextChanged(sender As Object, e As EventArgs) Handles txtMobilePhone.TextChanged
        txtMobilePhone.Text = System.Text.RegularExpressions.Regex.Replace(txtMobilePhone.Text, "[^\d]", "")
        txtMobilePhone.Select(txtMobilePhone.Text.Length, 0)
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        txtPhone.Text = System.Text.RegularExpressions.Regex.Replace(txtPhone.Text, "[^\d]", "")
        txtPhone.Select(txtPhone.Text.Length, 0)
    End Sub
End Class