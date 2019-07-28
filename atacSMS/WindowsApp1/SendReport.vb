Imports WindowsApp.RS
Imports System.Net.Mail

Public Class SendReport

    Private MAX_LENGTH = 160        'determines max length of a sms
    Private smsCredit               'number of sms that you can send returned by asking to ArubaSMS service
    Private mobileAndMailCount = 0  'how many selected user have both mail and mobile phone
    Private mobileCount = 0         'how many selected user have only mobile phone
    Private mailCount = 0           'how many selected user have only mail
    Private mailUser = ""           'credential's mail user
    Private mailPsw = ""            'credential's mail password

    Private Sub InvioSegnalazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSMSAndMailCredentials()     'loading credentials
        updateSMSCredit()               'updating smsCredit
        printMessageLength()            'printing how many charaters user has insered into txtMessage
    End Sub

    Private Sub chckSMS_CheckedChanged(sender As Object, e As EventArgs) Handles chckSMS.CheckedChanged
        printMessageLength()    'printing how many charaters user has insered into txtMessage
    End Sub

    Private Sub txtMessage_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged
        printMessageLength()    'printing how many charaters user has insered into txtMessage
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If checkIfCanSend() Then    'checking if is possible to proceed sending the report
            SendReport()            'sending the report
            OpenMainForm()          'opening MainForm
        End If
    End Sub

    Private Sub btnAddReceiver_Click(sender As Object, e As EventArgs) Handles btnAddReceiver.Click
        addReceiversToSelectedReceiversTable()  'adding selected Users into gridSelected
        updateLblSelected()                     'updating selected users infos
    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        removeReceiversFromSelectedReceiversTable()     'removing selected users from gridSelected
        updateLblSelected()                             'updating selected users infos
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'asking if users really wants to abort this report
        If MsgBox("Annullare l'invio della segnalazione?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            OpenMainForm()  'opening main form
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If checkIfFilterNotEmpty() Then             'checks if filters are not empty
            addUsersToSourceTableUsingFilters()     'adds users to gridSource using filters
        End If
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        'selects all users into gridSource
        For Each row As DataGridViewRow In gridSource.Rows
            row.Cells(5).Value = True
        Next
    End Sub

    Private Sub chckMail_CheckedChanged(sender As Object, e As EventArgs) Handles chckMail.CheckedChanged
        If chckMail.Checked Then
            txtMailObject.Enabled = True
        Else
            txtMailObject.Enabled = False
            txtMailObject.Text = ""
        End If
    End Sub

    Private Sub updateLblSelected()
        mobileAndMailCount = 0
        mobileCount = 0
        mailCount = 0
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening connection to db
        For Each row As DataGridViewRow In gridSelected.Rows
            'obtaining mobile number and mail for every user
            Dim query = "SELECT Cellulare, Mail FROM UTENZE " +
                        "WHERE CodiceUtenza ='" + row.Cells(2).Value + "'"
            Dim comm As New SqlCommand(query, cnn)
            Dim reader As SqlDataReader = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            If dt.Rows.Count = 1 Then
                If (Not (dt.Rows(0).Item("Cellulare") = "")) And (Not (dt.Rows(0).Item("mail") = "")) Then
                    'user has both mobile and mail
                    mobileAndMailCount = mobileAndMailCount + 1
                ElseIf Not (dt.Rows(0).Item("Cellulare") = "") Then
                    'user has just mobile
                    mobileCount = mobileCount + 1
                ElseIf Not dt.Rows(0).Item("Mail") = "" Then
                    'user has just mail
                    mailCount = mailCount + 1
                End If
            End If
        Next
        cnn.Close() 'closing db connection
        'updating lblSelected
        lblSelected.Text = "Destinatari: " + gridSelected.Rows.Count.ToString +
            " di cui " + mobileCount.ToString + " solo con cellulare," +
            mailCount.ToString + " solo con mail e " +
            mobileAndMailCount.ToString + " con entrambi"
    End Sub

    Private Sub loadSMSAndMailCredentials()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()                  'opening db connection
        LoadSMSCredentials(cnn)     'loading sms credentials
        LoadMailCredentials(cnn)    'loading mail credentials
        cnn.Close()                 'closing db connection
    End Sub

    Private Sub LoadSMSCredentials(connection As SqlConnection)
        Dim comm As New SqlCommand("SELECT TOP (1) * FROM CredenzialiArubaSMS", connection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        If dt.Rows.Count > 0 Then
            RS.Config.USERNAME = dt.Rows.Item(0).Item(0).ToString
            RS.Config.PASSWORD = dt.Rows.Item(0).Item(1).ToString
        End If
    End Sub

    Private Sub LoadMailCredentials(connection As SqlConnection)
        Dim comm As New SqlCommand("SELECT TOP (1) * FROM CredenzialiMail", connection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        If dt.Rows.Count > 0 Then
            mailUser = dt.Rows.Item(0).Item(0).ToString
            mailPsw = dt.Rows.Item(0).Item(1).ToString
        End If
    End Sub

    Private Sub printMessageLength()
        If chckSMS.Checked = True Then
            'if sms checked then check that txMessage length does not exceed MAX_LENGTH and update lblMessageLength 
            lblMessageLength.ForeColor = Color.Black
            If txtMessage.Text.Length > MAX_LENGTH Then
                MsgBox("Lunghezza massima di caratteri per un SMS raggiunta", MsgBoxStyle.OkOnly, "Errore")
                txtMessage.Text = txtMessage.Text.Substring(0, MAX_LENGTH)
            End If
            lblMessageLength.Text = txtMessage.Text.Length.ToString + "/" + MAX_LENGTH.ToString
        Else
            'if sms not checked then clear lblMessageLength and not impose n charater limitation to message
            lblMessageLength.Text = ""
        End If
    End Sub

    Private Sub updateSMSCredit()
        smsCredit = 0
        Dim connection As SMSCConnection    'initiate connection to ArubaSMS
        Try
            connection = New SMSCHTTPConnection()
            Dim credits As List(Of Credit) = connection.getCredits()    'getting smsCredit list
            For Each credit As Credit In credits
                If credit.Nation IsNot Nothing AndAlso credit.Nation = Nations.ITALY Then
                    If credit.CreditType.Equals(CreditType.ALTA) Then
                        smsCredit = credit.Count    'getting searched credit
                        Exit For
                    End If
                End If
            Next
        Catch smsce As SMSCException
            System.Console.WriteLine("exception: " + smsce.ToString)
        Catch invalidUserPsw As SMSCRemoteException
            MsgBox("Username o password errati per il servizio Aruba SMS", MsgBoxStyle.OkOnly, "")
        End Try
        connection.logout() 'closing connection with ArubaSMS
        'updating lblSmsBalance
        lblSmSBalance.Text = "Sms disponibili con credito corrente: " + smsCredit.ToString()
    End Sub

    Private Function checkIfCanSend() As Boolean
        If (gridSelected.Rows.Count = 0) Then
            MsgBox("Impossibile procedere, nessun destinatario selezionato",
                   MsgBoxStyle.Critical, "Errore")
            Return False
        ElseIf (Not chckSMS.Checked And Not chckMail.Checked) Then
            MsgBox("Impossibile procedere, nessun mezzo di trasmissione del messagio selezionato",
                   MsgBoxStyle.Critical, "Errore")
            Return False
        ElseIf (txtMessage.Text.Count = 0) Then
            MsgBox("Impossibile procedere, il messaggio della segnalazione non può essere vuoto",
                   MsgBoxStyle.Critical, "Errore")
            Return False
        ElseIf (txtNotes.Text.Count = 0) Then
            MsgBox("Impossibile procedere, la nota della segnalazione non può essere vuota",
                   MsgBoxStyle.Critical, "Errore")
            Return False
        ElseIf Not checkIfEnoughtCredit() Then
            MsgBox("Impossibile procedere, il numero di sms " +
                   "disponibili nel credito è inferiore al numero di contatti " +
                   "aventi un numero di cellulare", MsgBoxStyle.Critical, "Errore")
            Return False
        ElseIf chckMail.Checked Then
            If txtMailObject.Text.Count = 0 Then
                MsgBox("Impossibile procedere, l'oggetto della mail non può essere vuoto", MsgBoxStyle.Critical, "Errore")
                Return False
            End If
        End If
        Return True
    End Function

    Private Function checkIfEnoughtCredit() As Boolean
        If chckSMS.Checked Then
            Return smsCredit >= mobileCount
        End If
        Return True
    End Function

    Private Sub SendReport()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening connection to db
        Dim pkSegnalazione = insertReport(cnn)  'creating report and obtaining it's primary key
        insertDetails(pkSegnalazione, cnn)      'creating report details for every user selected
        cnn.Close() 'closing connection to db
        MsgBox("Segnalazione effettuata con successo", MsgBoxStyle.OkOnly, "")
    End Sub

    Private Sub insertDetails(pkSegnalazione As Integer, c As SqlConnection)
        Dim mobileNumberList As New List(Of String)
        Dim mailList As New List(Of String)
        'obtain every mobile number and mail of selected users
        For Each row As DataGridViewRow In gridSelected.Rows
            addNumberToList(mobileNumberList, row.Cells.Item(2).Value.ToString, c)
            addMailToList(mailList, row.Cells.Item(2).Value.ToString, c)
            insertReportDetail(pkSegnalazione, row.Cells.Item(2).Value.ToString, c)
        Next
        sendSMS(pkSegnalazione, c, mobileNumberList)    'send sms to every number into mobileNumberList
        sendMail(pkSegnalazione, c, mailList)           'send mail to every mail contact into mailList
    End Sub

    Private Sub sendSMS(pkSegnalazione As Integer, c As SqlConnection, mobileNumberList As List(Of String))
        If mobileNumberList.Count > 0 And chckSMS.Checked Then  'check if there is evena a mobile number 
            Dim connection As SMSCConnection    'opening connection to ArubaSMS
            Try
                connection = New SMSCHTTPConnection()
                Dim sms As New SMS()
                For Each number In mobileNumberList
                    sms.addSMSRecipient(number) 'adding every mobile number that will receive the sms
                Next
                sms.Message = txtMessage.Text
                sms.SMSSender = "atac"
                sms.setImmediate()
                Dim Result As SendResult = connection.sendSMS(sms)  'sending sms and getting it's unique id from aruba
                Dim comm As New SqlCommand("UPDATE Segnalazione SET CodiceSMS = '" +
                                           Result.OrderId.ToString + "' WHERE IdSegnalazione = " +
                                           pkSegnalazione.ToString, c)
                comm.ExecuteNonQuery()  'registering the sms'id to the report
                'getting sms status
                Dim smsstatus As List(Of MessageStatus) = connection.getMessageStatus(Result.OrderId.ToString)
                'updating sms status into every user contained into the report
                updateSMSStatus(Result.OrderId.ToString, pkSegnalazione, c, smsstatus)
            Catch smsce As SMSCException
                System.Console.WriteLine("exception: " + smsce.ToString)
            Catch smscre As SMSCRemoteException
                System.Console.WriteLine("message: " + smscre.Message)
            Catch invalidUserPsw As SMSCRemoteException
                MsgBox("Username o password errati per il servizio Aruba SMS", MsgBoxStyle.OkOnly, "")
            End Try
            connection.logout() 'closing aruba sms connection
        End If
    End Sub

    Private Sub updateSMSStatus(SMSID As String, pkSegnalazione As Integer, c As SqlConnection, smsStatus As List(Of MessageStatus))
        For Each status In smsStatus
            'getting user id
            Dim idUserQuery = "SELECT Top (1) CodiceUtenza " +
                                "FROM Utenze " +
                                "WHERE Cellulare = '" + status.Recipient.ToString + "' " +
                                "OR Cellulare = '" + status.Recipient.ToString.Replace("+39", "") + "'"
            Dim comm As New SqlCommand(idUserQuery, c)
            Dim idUser = Convert.ToString(comm.ExecuteScalar)
            Dim statusValue As Integer = status.Status
            'updating sms status value into user's report detail
            Dim updateStatusQuery =
                "UPDATE DettSegnalazione " +
                "SET EsitoSMS = " + statusValue.ToString + " " +
                "WHERE CodiceUtenza = '" + idUser + "' AND " +
                "IdSegnalazione = " + pkSegnalazione.ToString
            comm = New SqlCommand(updateStatusQuery, c)
            comm.ExecuteNonQuery()
        Next
    End Sub

    Private Sub sendMail(pkSegnalazione As Integer, c As SqlConnection, mailList As List(Of String))
        If mailList.Count > 0 And chckMail.Checked Then 'check mail number
            Dim emailMessage As New MailMessage()
            Try
                'obtaining mail from mail credentials
                Dim comm As New SqlCommand("SELECT TOP (1) Mail FROM CredenzialiMail", c)
                Dim userMail = Convert.ToString(comm.ExecuteScalar)
                emailMessage.From = New MailAddress(userMail)
                For Each mail In mailList
                    emailMessage.To.Add(mail)   'adding every mail to receivers
                Next
                emailMessage.Subject = txtMailObject.Text
                emailMessage.IsBodyHtml = False
                emailMessage.Body = txtMessage.Text
                Dim SMTP As New SmtpClient
                'obtaining mail host splicing mail from credentials
                Dim split As String() = userMail.Split("@").Last.Split(".")
                SMTP.Host = "smtp." + split.ElementAt(split.Length - 2) + "." + split.ElementAt(split.Length - 1)
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.UseDefaultCredentials = False
                'obtaining password from mail credentials
                comm = New SqlCommand("SELECT TOP (1) Password FROM CredenzialiMail", c)
                Dim pswMail = Convert.ToString(comm.ExecuteScalar)
                'setting mail and password
                SMTP.Credentials = New System.Net.NetworkCredential(userMail, pswMail)
                SMTP.Send(emailMessage)
                'updating mail status into every user's report detail
                UpdateMailStatus(pkSegnalazione, c, mailList)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Errore durante la connessione alla mail", MsgBoxStyle.OkOnly, "")
            End Try
        End If
    End Sub

    Private Sub UpdateMailStatus(pkSegnalazione As Integer, c As SqlConnection, mailList As List(Of String))
        For Each mail In mailList
            'obtaining user id
            Dim idUserQuery = "SELECT Top (1) CodiceUtenza " +
                                "FROM Utenze " +
                                "WHERE Mail = '" + mail.ToString + "' "
            Dim comm As New SqlCommand(idUserQuery, c)
            Dim idUser = Convert.ToString(comm.ExecuteScalar)
            'updating mail status for user into report
            Dim updateStatusQuery =
                "UPDATE DettSegnalazione " +
                "SET EsitoMail = 1 " +
                "WHERE CodiceUtenza = '" + idUser + "' AND " +
                "IdSegnalazione = " + pkSegnalazione.ToString
            comm = New SqlCommand(updateStatusQuery, c)
            comm.ExecuteNonQuery()
        Next
    End Sub

    Private Sub insertReportDetail(pkSegnalazione As Integer, userCode As String, c As SqlConnection)
        Dim insertQuery = "INSERT INTO DettSegnalazione" +
                "(IdSegnalazione,CodiceUtenza,EsitoSMS,EsitoMail) " +
                "VALUES(" + pkSegnalazione.ToString + "," +
                "'" + userCode + "'," +
                "-1,0)"
        Dim comm = New SqlCommand(insertQuery, c)
        comm.ExecuteNonQuery()
    End Sub

    Private Sub addNumberToList(numberList As List(Of String), userCode As String, c As SqlConnection)
        'getting mobile number to add it to mobileList
        Dim numberQuery = "SELECT Cellulare FROM Utenze WHERE CodiceUtenza ='" + userCode + "'"
        Dim comm As New SqlCommand(numberQuery, c)
        Dim mobileNumber = Convert.ToString(comm.ExecuteScalar())
        'checking that the mobile number is present
        If mobileNumber IsNot "" Then
            numberList.Add(checkMobileSyntax(mobileNumber)) 'if necessary correct mobile number syntax
        End If
    End Sub

    Private Sub addMailToList(mailList As List(Of String), userCode As String, c As SqlConnection)
        'getting mail contact
        Dim mailQuery = "SELECT Mail FROM Utenze WHERE CodiceUtenza ='" + userCode + "'"
        Dim comm As New SqlCommand(mailQuery, c)
        Dim mail = Convert.ToString(comm.ExecuteScalar())
        'checking that mail contact isn't empty
        If mail IsNot "" Then
            mailList.Add(mail)
        End If
    End Sub

    Private Function checkMobileSyntax(mobileNumber As String) As String
        'if necessary add italian prefix to mobile number
        If mobileNumber.Contains("+39") Then
            Return mobileNumber
        End If
        Return "+39" + mobileNumber
    End Function

    Private Function insertReport(c As SqlConnection) As Integer
        'inserting report
        Dim insertQuery = "INSERT INTO Segnalazione(Data, Operatore, Testo, Note) " +
            "VALUES('" + DateTime.Now + "'," +
            "'" + Authentication.operatorName + "'," +
            "'" + txtMessage.Text + "'," +
            "'" + txtNotes.Text + "')"
        Dim comm As New SqlCommand(insertQuery, c)
        comm.ExecuteNonQuery()
        'getting report's id
        comm = New SqlCommand("SELECT TOP 1 IdSegnalazione FROM Segnalazione ORDER BY IdSegnalazione DESC", c)
        Return Convert.ToInt16(comm.ExecuteScalar())
    End Function

    Private Sub addReceiversToSelectedReceiversTable()
        Dim selected = 0
        Dim valid = 0
        'adds user selected from gridSource to gridSelected making sure that there are no duplicates
        For Each row As DataGridViewRow In gridSource.Rows
            If Convert.ToBoolean(row.Cells(5).Value) Then
                selected = selected + 1
                Dim insert = True
                For Each checkRow As DataGridViewRow In gridSelected.Rows
                    If (checkRow.Cells(2).Value.Equals(row.Cells(2).Value)) Then
                        insert = False
                        Exit For
                    End If
                Next checkRow
                If insert Then
                    valid = valid + 1
                    gridSelected.Rows.Add(row.Cells(0).Value,
                                        row.Cells(1).Value,
                                        row.Cells(2).Value,
                                        row.Cells(3).Value,
                                        row.Cells(4).Value)
                End If
            End If
        Next row
        If selected = 0 Then
            'if no user was selected from gridSource that communicate it 
            MsgBox("Nessuna utenza risulta selezionata", MsgBoxStyle.OkOnly, "")
        End If
    End Sub

    Private Sub removeReceiversFromSelectedReceiversTable()
        'removes selected users from gridSelected
        Dim i = 0
        While i < gridSelected.Rows.Count
            If gridSelected.Rows(i).Cells(5).Value Then
                gridSelected.Rows.Remove(gridSelected.Rows(i))
            Else
                i += 1
            End If
        End While
    End Sub

    Private Function checkIfFilterNotEmpty() As Boolean
        If txtUser.Text.Length = 0 And txtAddress.Text.Length = 0 And txtBranch.Text.Length = 0 Then
            MsgBox("Inserire prima un filtro tra Utenza, Via e Ramo", , "")
            Return False
        End If
        Return True
    End Function

    Private Sub addUsersToSourceTableUsingFilters()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opens db connection
        'select every user that matches with filters
        Dim query = "SELECT * FROM UTENZE " +
        "WHERE CodiceUtenza LIKE '%" + txtUser.Text + "%' " +
            "AND Via LIKE '%" + txtAddress.Text + "%' " +
            "AND Ramo LIKE '%" + txtBranch.Text + "%' "
        Dim comm As New SqlCommand(query, cnn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        cnn.Close() 'closing db connection
        gridSource.Rows.Clear() 'clearing gridSource
        If dt.Rows.Count = 0 Then   'no user matches
            MsgBox("Nessuna utenza corrisponde ai filtri inseriti", , "")
        Else
            For Each row As DataRow In dt.Rows  'adding every user that matched
                gridSource.Rows.Add(row.Item("Nome"),
                                    row.Item("Cognome"),
                                    row.Item("CodiceUtenza"),
                                    row.Item("Via"),
                                    row.Item("Ramo"))
            Next row
        End If
        lblSource.Text = "Banca dati: " + gridSource.Rows.Count.ToString    'updating number of user that matched
    End Sub

    Private Sub OpenMainForm()
        MainForm.Show()
        Close()
    End Sub

    Private Sub EnterPressedAddUsersToSourceTableUsingFilters(e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If checkIfFilterNotEmpty() Then
                addUsersToSourceTableUsingFilters()
            End If
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        EnterPressedAddUsersToSourceTableUsingFilters(e)
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        EnterPressedAddUsersToSourceTableUsingFilters(e)
    End Sub

    Private Sub txtBranch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBranch.KeyPress
        EnterPressedAddUsersToSourceTableUsingFilters(e)
    End Sub
End Class