Imports WindowsApp.RS

Public Class ConsultReports

    Private dtReports As New DataTable

    Private Sub ConsultazioneSegnalazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReports()
        LoadSMSCredentials()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Close()
    End Sub

    Private Sub gridReports_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridReports.CellClick
        loadDetails(e)
    End Sub

    Private Sub loadReports()
        gridReports.Rows.Clear()    'clearing two tables
        gridDetails.Rows.Clear()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening db connection
        Dim comm As New SqlCommand("SELECT * " +
                                   "FROM Segnalazione " +
                                   "ORDER BY Data DESC", cnn)   'obtaining every report
        Dim reader As SqlDataReader = comm.ExecuteReader
        dtReports.Clear()
        dtReports.Load(reader)
        cnn.Close()
        gridReports.Rows.Clear()    'clearing grid reports
        For Each row As DataRow In dtReports.Rows   'adding every report otained to gridReport
            gridReports.Rows.Add(row.Item("Data"),
                                 row.Item("Operatore"),
                                 row.Item("Note"))
        Next row
    End Sub

    Private Sub loadDetails(e As DataGridViewCellEventArgs)
        If (e.RowIndex >= 0) Then   'checking that user didn't click on talbe intestation
            'obtaining report's id
            Dim idReport = dtReports.Select("Data = '" +
                                     gridReports.Rows.Item(e.RowIndex).Cells.Item(0).Value +
                                     "'").First.Item("IdSegnalazione")
            'obtaining report's details
            Dim query = "SELECT ds.CodiceUtenza, u.Nome, u.Cognome, ds.EsitoSMS, ds.EsitoMail " +
                "FROM DettSegnalazione ds, Utenze u " +
                "WHERE ds.CodiceUtenza = u.CodiceUtenza " +
                "AND ds.IdSegnalazione = '" + idReport.ToString + "'"
            gridDetails.Rows.Clear()    'clearing gridDetails
            Dim cnn As New SqlConnection(My.Settings.cnn)
            cnn.Open()  'opening db connection
            'obtaining sms id
            Dim comm As New SqlCommand("SELECT CodiceSMS FROM Segnalazione WHERE IdSegnalazione = " + idReport.ToString, cnn)
            Dim SMSCode As String = Convert.ToString(comm.ExecuteScalar)
            If SMSCode IsNot "" Then
                'if sms code exist than update sms satus into user's details
                updateSMSStatus(SMSCode, idReport, cnn, gridReports.Rows.Item(e.RowIndex).Cells.Item(0).Value)
            End If
            'obtaining report's text
            comm = New SqlCommand("SELECT Testo FROM Segnalazione WHERE IdSegnalazione ='" +
                idReport.ToString + "'", cnn)
            txtMessage.Text = comm.ExecuteScalar()
            'obtaining report's notes
            comm = New SqlCommand("SELECT Note FROM Segnalazione WHERE IdSegnalazione ='" +
                idReport.ToString + "'", cnn)
            txtNote.Text = comm.ExecuteScalar()
            comm = New SqlCommand(query, cnn)
            Dim reader As SqlDataReader = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            cnn.Close() 'closing db connection
            gridDetails.Rows.Clear()
            For Each row As DataRow In dt.Rows  'inserting into gridDetails every user detail
                gridDetails.Rows.Add(row.Item("CodiceUtenza"),
                                     row.Item("Nome"),
                                     row.Item("Cognome"),
                                     getSMSString(Integer.Parse(row.Item("EsitoSMS"))),    'converting from integer to readable status
                                     getMailString(Integer.Parse(row.Item("EsitoMail"))))
            Next row
        End If
    End Sub

    Private Function getSMSString(code As Integer) As String
        'converts based on smsStatus code
        Select Case code
            Case -1
                Return "Non inviato"
            Case 1 Or 9
                Return "Inviato, attesa consegna"
            Case 2
                Return "Inviato e Consegnato"
            Case 4
                Return "Non consegnato entro 48 ore"
            Case Else
                Return "Errore nella consegna"
        End Select
    End Function

    Private Function getMailString(code As Integer) As String
        'converts based on mail status code
        If code = 0 Then
            Return "Non inviata"
        End If
        Return "Inviata"
    End Function

    Private Sub btnRemoveFilter_Click(sender As Object, e As EventArgs) Handles btnRemoveFilter.Click
        loadReports()   'load againg every report
        'clear filters
        txtFilterOperator.Text = ""
        txtFilterNotes.Text = ""
        checkFilterStart.Checked = False
        checkFilterEnd.Checked = False
        timePickFilterStart.Enabled = False
        timePickFilterEnd.Enabled = False
    End Sub

    Private Sub checkFilterStart_CheckedChanged(sender As Object, e As EventArgs) Handles checkFilterStart.CheckedChanged
        'enable/disable timePickFilterStart
        If (checkFilterStart.Checked) Then
            timePickFilterStart.Enabled = True
        Else
            timePickFilterStart.Enabled = False
        End If
    End Sub

    Private Sub checkFilterEnd_CheckedChanged(sender As Object, e As EventArgs) Handles checkFilterEnd.CheckedChanged
        'enable/disable timePickFilterEnd
        If (checkFilterEnd.Checked) Then
            timePickFilterEnd.Enabled = True
        Else
            timePickFilterEnd.Enabled = False
        End If
    End Sub

    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        If (checkFilterStart.Checked And checkFilterEnd.Checked) Then
            'if date filters are checked check that start date is less than end date
            If (timePickFilterStart.Value > timePickFilterEnd.Value) Then
                MsgBox("La data di inizio dev'essere minore o uguale alla data di fine", MsgBoxStyle.OkOnly, "")
                Return
            End If
        End If
        'starting filtered query
        Dim filterQuery = "SELECT * " +
                        "FROM Segnalazione " +
                        "WHERE Operatore LIKE '%" + txtFilterOperator.Text + "%' " +
                        "AND Note LIKE '%" + txtFilterNotes.Text + "%' "
        If (checkFilterStart.Checked And checkFilterEnd.Checked) Then
            'if both start date and end date filters are active than add then to query
            filterQuery = filterQuery +
                "AND Data BETWEEN '" + timePickFilterStart.Value.ToShortDateString.ToString + " 00:00:00" +
                "' AND '" + timePickFilterEnd.Value.ToShortDateString.ToString + " 23:59:59' "
        ElseIf checkFilterStart.Checked Then
            'if just start date filter is active then add it to query
            filterQuery = filterQuery +
                "AND Data >= '" + timePickFilterStart.Value.ToShortDateString.ToString + " 00:00:00'"
        ElseIf checkFilterEnd.Checked Then
            'if just end date filter is active then add it to query
            filterQuery = filterQuery +
                "AND Data <= '" + timePickFilterEnd.Value.ToShortDateString.ToString + " 23:23:59'"
        End If
        filterQuery = filterQuery + "ORDER BY Data DESC"    'ordering
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()  'opening db connection
        Dim comm As New SqlCommand(filterQuery, cnn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        dtReports.Clear()
        dtReports.Load(reader)
        cnn.Close() 'closing db connection
        gridReports.Rows.Clear()    'clearing both tables, message and notes
        gridDetails.Rows.Clear()
        txtMessage.Text = ""
        txtNote.Text = ""
        For Each row As DataRow In dtReports.Rows   'loading obtained filters
            gridReports.Rows.Add(row.Item("Data"),
                                 row.Item("Operatore"),
                                 row.Item("Note"))
        Next row
    End Sub

    Private Sub LoadSMSCredentials()
        Dim cnn As New SqlConnection(My.Settings.cnn)
        cnn.Open()
        Dim comm As New SqlCommand("SELECT TOP (1) * FROM CredenzialiArubaSMS", cnn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        If dt.Rows.Count > 0 Then
            RS.Config.USERNAME = dt.Rows.Item(0).Item(0).ToString
            RS.Config.PASSWORD = dt.Rows.Item(0).Item(1).ToString
        End If
        cnn.Close()
    End Sub

    Private Sub updateSMSStatus(SMSID As String, pkSegnalazione As Integer, c As SqlConnection, data As String)
        Dim parsedDate As DateTime = Convert.ToDateTime(data)   'obtaining report's date
        'checking if enlapsed days from date are less than 30 (after that aruba will not provide sms status)
        If Convert.ToInt32(DateTime.Now.Subtract(parsedDate).Days) <= 30 Then
            'checking if into this report's detail there are still sms that need status update, otherwise do nothing
            Dim detailsQuery = "SELECT COUNT(*) " +
                "FROM DettSegnalazione " +
                "WHERE IdSegnalazione = " + pkSegnalazione.ToString + "AND " +
                "(EsitoSMS = 1 OR EsitoSMS = 9) "
            Dim comm As New SqlCommand(detailsQuery, c)
            If (Convert.ToInt32(comm.ExecuteScalar) > 0) Then
                Dim connection As SMSCConnection    'connect to arubaSMS
                Try
                    connection = New SMSCHTTPConnection()
                    'gettting sms status using smsID
                    Dim smsstatus As List(Of MessageStatus) = connection.getMessageStatus(SMSID)
                    'update sms status into db
                    updateSMSStatusDB(SMSID, pkSegnalazione, c, smsstatus)
                Catch smsce As SMSCException
                    System.Console.WriteLine("exception: " + smsce.ToString)
                Catch smscre As SMSCRemoteException
                    System.Console.WriteLine("message: " + smscre.Message)
                Catch invalidUserPsw As SMSCRemoteException
                    MsgBox("Username o password errati per il servizio Aruba SMS", MsgBoxStyle.OkOnly, "")
                End Try
                connection.logout() 'closing connection with arubaSMS
            End If
        End If
    End Sub

    Private Sub updateSMSStatusDB(SMSID As String, pkSegnalazione As Integer, c As SqlConnection, smsStatus As List(Of MessageStatus))
        For Each status In smsStatus
            'obtaining user'id
            Dim idUserQuery = "SELECT Top (1) CodiceUtenza " +
                                "FROM Utenze " +
                                "WHERE Cellulare = '" + status.Recipient.ToString + "' " +
                                "OR Cellulare = '" + status.Recipient.ToString.Replace("+39", "") + "'"
            Dim comm As New SqlCommand(idUserQuery, c)
            Dim idUser = Convert.ToString(comm.ExecuteScalar)
            Dim statusValue As Integer = status.Status  'converting status value from enum to int
            'updating sms status into db
            Dim updateStatusQuery =
                "UPDATE DettSegnalazione " +
                "SET EsitoSMS = " + statusValue.ToString + " " +
                "WHERE CodiceUtenza = '" + idUser + "' AND " +
                "IdSegnalazione = " + pkSegnalazione.ToString
            comm = New SqlCommand(updateStatusQuery, c)
            comm.ExecuteNonQuery()
        Next
    End Sub

End Class