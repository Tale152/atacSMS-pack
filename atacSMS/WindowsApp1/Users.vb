Public Class Users

    Private dt As New DataTable

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MainForm.Show()
        Close()
    End Sub

    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        'checking that filters are not empty
        If (txtFilterUser.Text.Count = 0 And txtFilterBranch.Text.Count = 0) Then
            MsgBox("I campi di ricerca per i filtri sono vuoti", MsgBoxStyle.OkOnly, "")
        Else
            UserFilter(txtFilterUser.Text, txtFilterBranch.Text)    'loading users using filters
        End If

    End Sub

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        'clear filters, table and details
        txtFilterUser.Text = ""
        txtFilterBranch.Text = ""
        gridUsers.Rows.Clear()
        clearDetails()
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        'if gridUsers is empty do nothing, otherwie select all users
        If gridUsers.Rows.Count = 0 Then
            MsgBox("La tabella delle utenze è vuota", MsgBoxStyle.OkOnly, "")
        Else
            Dim i = 0
            While i < gridUsers.Rows.Count
                gridUsers.Rows.Item(i).Cells.Item(4).Value = True
                i = i + 1
            End While
        End If
    End Sub

    Private Sub UserFilter(UserFilter As String, BranchFilter As String)
        'apply filters and load users from db to table
        gridUsers.Rows.Clear()
        Dim query = "SELECT * " +
                    "FROM Utenze " +
                    "WHERE Ramo LIKE '%" + BranchFilter + "%' " +
                    "AND CodiceUtenza LIKE '%" + UserFilter + "%'"
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        Dim comm As New SqlCommand(query, cnn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        dt.Clear()
        dt.Load(reader)
        cnn.Close()
        If (dt.Rows.Count = 0) Then
            MsgBox("La ricerca non ha prodotto risultati", MsgBoxStyle.OkOnly, "")
        Else
            For Each row As DataRow In dt.Rows
                gridUsers.Rows.Add(row.Item("CodiceUtenza"),
                                        row.Item("Ramo"),
                                        row.Item("Nome"),
                                        row.Item("Cognome"))
                gridUsers.Rows.Item(gridUsers.Rows.Count - 1).Cells.Item(4).Value = False
            Next row
        End If
        clearDetails()

    End Sub

    Private Sub btnDeleteAllSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteAllSelected.Click
        'delete all selected users
        Dim i = 0
        Dim toDelete = 0
        While i < gridUsers.Rows.Count
            If (gridUsers.Rows.Item(i).Cells.Item(4).Value) Then
                toDelete = toDelete + 1
            End If
            i = i + 1
        End While

        If toDelete = 0 Then
            MsgBox("Nessuna utenza selezionata", MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Eliminare " + toDelete.ToString + " utenze?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                i = 0
                Dim cnn As New SqlConnection(My.Settings.cnn)
                cnn.Open()
                While i < gridUsers.Rows.Count
                    If (gridUsers.Rows.Item(i).Cells.Item(4).Value = True) Then
                        Dim deleteQuery = "DELETE FROM Utenze WHERE CodiceUtenza = '" + gridUsers.Rows.Item(i).Cells.Item(0).Value + "'"
                        Dim comm As New SqlCommand(deleteQuery, cnn)
                        comm.ExecuteNonQuery()
                    End If
                    i = i + 1
                End While
                cnn.Close()
                MsgBox(toDelete.ToString + " utenze eliminate con successo", MsgBoxStyle.OkOnly, "")
                UserFilter(txtFilterUser.Text, txtFilterBranch.Text)
            End If
        End If
    End Sub

    Private Sub clearDetails()
        'clear user details
        txtUser.Text = ""
        txtBranch.Text = ""
        txtName.Text = ""
        txtSurname.Text = ""
        txtAddress.Text = ""
        txtCAP.Text = ""
        txtCity.Text = ""
        txtRegion.Text = ""
        txtPhone.Text = ""
        txtMobilePhone.Text = ""
        txtMail.Text = ""
    End Sub

    Private Sub gridUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUsers.CellClick
        'load selected user details 
        If (e.RowIndex >= 0 And e.ColumnIndex < 4) Then
            Dim row = dt.Select(
            "CodiceUtenza = '" + gridUsers.Rows.Item(e.RowIndex).Cells.Item(0).Value + "'").First
            txtUser.Text = row.Item("CodiceUtenza")
            txtBranch.Text = row.Item("Ramo")
            txtName.Text = row.Item("Nome")
            txtSurname.Text = row.Item("Cognome")
            txtAddress.Text = row.Item("Via")
            txtCAP.Text = row.Item("Cap")
            txtCity.Text = row.Item("Citta")
            txtRegion.Text = row.Item("Provincia")
            txtPhone.Text = row.Item("Telefono")
            txtMobilePhone.Text = row.Item("Cellulare")
            txtMail.Text = row.Item("Mail")
        End If
    End Sub

    Private Sub btnLoadAll_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        'load all users from db
        txtFilterUser.Text = ""
        txtFilterBranch.Text = ""
        UserFilter("", "")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'open UserEdit in new user mode
        UserEdit.Show()
        UserEdit.Text = "Nuova utenza"
        UserEdit.creation = True
        UserEdit.originalID = ""
        Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'opens UserEdit in edit mode loading user details into UserEdit
        If (txtUser.Text.Count > 0) Then
            UserEdit.Show()
            UserEdit.Text = "Modifica utenza"
            UserEdit.txtUser.Text = txtUser.Text
            UserEdit.txtBranch.Text = txtBranch.Text
            UserEdit.txtName.Text = txtName.Text
            UserEdit.txtSurname.Text = txtSurname.Text
            UserEdit.txtAddress.Text = txtAddress.Text
            UserEdit.txtCAP.Text = txtCAP.Text
            UserEdit.txtCity.Text = txtCity.Text
            UserEdit.txtRegion.Text = txtRegion.Text
            UserEdit.txtPhone.Text = txtPhone.Text
            UserEdit.txtMobilePhone.Text = txtMobilePhone.Text
            UserEdit.txtMail.Text = txtMail.Text
            UserEdit.creation = False
            UserEdit.originalID = txtUser.Text
            Close()
        Else
            MsgBox("Nessuna utenza selezionata", MsgBoxStyle.OkOnly, "")
        End If
    End Sub

End Class