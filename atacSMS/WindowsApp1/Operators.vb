Public Class Operators

    Private Sub Operators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()  'fill operators grid
    End Sub

    Private Sub btnBackToMainMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMainMenu.Click
        'go back to MainForm
        MainForm.Show()
        Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If (txtUsername.Text.Count = 0 Or txtPassword.Text.Count = 0) Then
            'checking that username and password are not blank
            MsgBox("Username e password non possono essere vuoti", MsgBoxStyle.OkOnly, "Impossibile procedere")
        ElseIf Not (txtPassword.Text = txtConfirmPsw.Text) Then
            'check that password and confirmation password coincide
            MsgBox("I campi delle password non coincidono", MsgBoxStyle.OkOnly, "Impossibile procedere")
        Else
            'query to check if another operator with same username exist
            Dim query = "SELECT COUNT(Username) " +
                    "FROM Operatori " +
                    "WHERE Username = '" + txtUsername.Text + "' "
            Dim cnn As New SqlConnection(My.Settings.cnn)
            cnn.Open()  'opening db connection
            Dim comm As New SqlCommand(query, cnn)
            If (Convert.ToInt16(comm.ExecuteScalar()) = 1) Then
                'if another operator with same username exist than abort 
                cnn.Close() 'closing db connection
                MsgBox("L'username inserito esiste già", MsgBoxStyle.OkOnly, "Impossibile procedere")
            Else
                'if no other operator with same username exist than create new with input credentials
                'operator creating query
                Dim insert = "INSERT INTO Operatori(Username,Password, Amministratore) " +
                            "VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "',"
                'checking wether or not new operator is admin or not
                If (checkAdmin.Checked) Then
                    insert = insert + "1)"
                Else
                    insert = insert + "0)"
                End If
                comm = New SqlCommand(insert, cnn)
                comm.ExecuteNonQuery()  'executing query
                cnn.Close() 'closing db connection
                LoadGrid()  'reloading grid
                'communicating success and cleaning credentials TextBoxes
                MsgBox("Nuovo operatore inserito correttamente", MsgBoxStyle.OkOnly, )
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtConfirmPsw.Text = ""
            End If
        End If
    End Sub

    Private Sub LoadGrid()
        gridOperators.Rows.Clear()  'clearing grid
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening db connection
        'selecting all operators except user's login operator
        Dim comm As New SqlCommand("SELECT Username, Amministratore " +
                                    "FROM Operatori " +
                                    "WHERE Username <> '" + Authentication.operatorName + "' " +
                                    "ORDER BY Username", cnn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        cnn.Close() 'closing db connection
        For Each row As DataRow In dt.Rows  'loading values on table
            gridOperators.Rows.Add(row.Item("Username"))
            If (row.Item("Amministratore") = True) Then
                'if operator is admin than check that operator's admin checkbox
                gridOperators.Rows.Item(gridOperators.Rows.Count - 1).Cells().Item(1).Value = True
            Else
                'otherwise set it not checked
                gridOperators.Rows.Item(gridOperators.Rows.Count - 1).Cells().Item(1).Value = False
            End If
        Next row
    End Sub

    Private Sub gridOperators_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridOperators.CellContentClick
        If e.ColumnIndex = 1 Then
            'if user clicks on second column upgrade/downgrade selected operator's admin privileges
            UpdateAdmin(e)
        ElseIf e.ColumnIndex = 2 Then
            'if user clicks on third column ask if user wants to delete selected operator's
            DeleteUser(e)
        End If
    End Sub

    Private Sub DeleteUser(e As DataGridViewCellEventArgs)
        'checking that user didn't click on table intestation
        If (e.RowIndex >= 0) Then
            'asking if user really wants to delete selected operator
            If MsgBox("Eliminare l'operatore? Le segnalazioni da lui effettuate rimarranno senza un autore.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                'deleting operator query
                Dim delQuery = "DELETE FROM Operatori WHERE Username ='" +
                    gridOperators.Rows.Item(e.RowIndex).Cells.Item(0).Value + "'"
                Dim cnn As New SqlConnection(My.Settings.cnn)
                cnn.Open() 'opening db connection
                Dim comm = New SqlCommand(delQuery, cnn)
                comm.ExecuteNonQuery()  'executing query
                cnn.Close() 'closing db connection
                MsgBox("Operatore eliminato correttamente", MsgBoxStyle.OkOnly, "") 'communicating success to user
                LoadGrid()  'reloading grid
            End If
        End If
    End Sub

    Private Sub UpdateAdmin(e As DataGridViewCellEventArgs)
        'checking that user didn't click on table intestation
        If (e.RowIndex >= 0) Then
            'changing admin checkbox value to it's opposite
            gridOperators.Rows(e.RowIndex).Cells(1).Value = Not gridOperators.Rows(e.RowIndex).Cells(1).Value
            'admin privileges changing query
            Dim updateQuery = "UPDATE Operatori " +
                        "SET Amministratore = "
            If gridOperators.Rows(e.RowIndex).Cells(1).Value Then
                'if selected operator is was not an admin (so now checkbox is true) than upgrade to admin
                updateQuery = updateQuery + "1 WHERE Username = '" + gridOperators.Rows(e.RowIndex).Cells(0).Value.ToString + "'"
            Else
                'otherwise downgrade selected operator to normal user
                updateQuery = updateQuery + "0 WHERE Username = '" + gridOperators.Rows(e.RowIndex).Cells(0).Value.ToString + "'"
            End If
            Dim cnn As New SqlConnection(My.Settings.cnn)
            cnn.Open()  'opening db connection
            Dim comm = New SqlCommand(updateQuery, cnn)
            comm.ExecuteNonQuery()  'executing query
            cnn.Close() 'closing db connection
            MsgBox("Privilegi da amministratore modificati per l'operatore " + gridOperators.Rows(e.RowIndex).Cells(0).Value.ToString, MsgBoxStyle.OkOnly, "")
            'communicating success to user
        End If
    End Sub

End Class