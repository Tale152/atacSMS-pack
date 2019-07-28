<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gridReports = New System.Windows.Forms.DataGridView()
        Me.columnDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnOperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridDetails = New System.Windows.Forms.DataGridView()
        Me.columnUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lbl_TextDetails = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtFilterOperator = New System.Windows.Forms.TextBox()
        Me.txtFilterNotes = New System.Windows.Forms.TextBox()
        Me.btnApplyFilter = New System.Windows.Forms.Button()
        Me.btnRemoveFilter = New System.Windows.Forms.Button()
        Me.lblFilterNotes = New System.Windows.Forms.Label()
        Me.lblFilterOperator = New System.Windows.Forms.Label()
        Me.timePickFilterStart = New System.Windows.Forms.DateTimePicker()
        Me.timePickFilterEnd = New System.Windows.Forms.DateTimePicker()
        Me.checkFilterStart = New System.Windows.Forms.CheckBox()
        Me.checkFilterEnd = New System.Windows.Forms.CheckBox()
        CType(Me.gridReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridReports
        '
        Me.gridReports.AllowUserToAddRows = False
        Me.gridReports.AllowUserToDeleteRows = False
        Me.gridReports.AllowUserToResizeColumns = False
        Me.gridReports.AllowUserToResizeRows = False
        Me.gridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDateTime, Me.columnOperator, Me.columnNotes})
        Me.gridReports.Location = New System.Drawing.Point(12, 25)
        Me.gridReports.Name = "gridReports"
        Me.gridReports.ReadOnly = True
        Me.gridReports.RowHeadersVisible = False
        Me.gridReports.Size = New System.Drawing.Size(684, 150)
        Me.gridReports.TabIndex = 0
        Me.gridReports.TabStop = False
        '
        'columnDateTime
        '
        Me.columnDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnDateTime.HeaderText = "Data e ora"
        Me.columnDateTime.Name = "columnDateTime"
        Me.columnDateTime.ReadOnly = True
        Me.columnDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnOperator
        '
        Me.columnOperator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnOperator.HeaderText = "Operatore"
        Me.columnOperator.Name = "columnOperator"
        Me.columnOperator.ReadOnly = True
        Me.columnOperator.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnNotes
        '
        Me.columnNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnNotes.HeaderText = "Note"
        Me.columnNotes.Name = "columnNotes"
        Me.columnNotes.ReadOnly = True
        Me.columnNotes.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'gridDetails
        '
        Me.gridDetails.AllowUserToAddRows = False
        Me.gridDetails.AllowUserToDeleteRows = False
        Me.gridDetails.AllowUserToResizeColumns = False
        Me.gridDetails.AllowUserToResizeRows = False
        Me.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnUser, Me.columnName, Me.columnSurname, Me.columnSMS, Me.columnMail})
        Me.gridDetails.Location = New System.Drawing.Point(12, 272)
        Me.gridDetails.Name = "gridDetails"
        Me.gridDetails.ReadOnly = True
        Me.gridDetails.RowHeadersVisible = False
        Me.gridDetails.ShowCellErrors = False
        Me.gridDetails.ShowCellToolTips = False
        Me.gridDetails.ShowEditingIcon = False
        Me.gridDetails.ShowRowErrors = False
        Me.gridDetails.Size = New System.Drawing.Size(684, 121)
        Me.gridDetails.TabIndex = 1
        Me.gridDetails.TabStop = False
        '
        'columnUser
        '
        Me.columnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnUser.HeaderText = "Utenza"
        Me.columnUser.Name = "columnUser"
        Me.columnUser.ReadOnly = True
        Me.columnUser.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnName
        '
        Me.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnName.HeaderText = "Nome"
        Me.columnName.Name = "columnName"
        Me.columnName.ReadOnly = True
        Me.columnName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnSurname
        '
        Me.columnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnSurname.HeaderText = "Cognome"
        Me.columnSurname.Name = "columnSurname"
        Me.columnSurname.ReadOnly = True
        '
        'columnSMS
        '
        Me.columnSMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnSMS.HeaderText = "Esito SMS"
        Me.columnSMS.Name = "columnSMS"
        Me.columnSMS.ReadOnly = True
        Me.columnSMS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnMail
        '
        Me.columnMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnMail.HeaderText = "Esito Mail"
        Me.columnMail.Name = "columnMail"
        Me.columnMail.ReadOnly = True
        Me.columnMail.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(298, 526)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(119, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Menu principale"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(124, 399)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(508, 53)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.TabStop = False
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Location = New System.Drawing.Point(9, 9)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(104, 13)
        Me.lblReports.TabIndex = 4
        Me.lblReports.Text = "Strorico segnalazioni"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(9, 256)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(108, 13)
        Me.lblDetails.TabIndex = 5
        Me.lblDetails.Text = "Dettagli segnalazione"
        '
        'lbl_TextDetails
        '
        Me.lbl_TextDetails.AutoSize = True
        Me.lbl_TextDetails.Location = New System.Drawing.Point(18, 418)
        Me.lbl_TextDetails.Name = "lbl_TextDetails"
        Me.lbl_TextDetails.Size = New System.Drawing.Size(102, 13)
        Me.lbl_TextDetails.TabIndex = 6
        Me.lbl_TextDetails.Text = "Testo segnalazione:"
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(18, 478)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(98, 13)
        Me.lblNote.TabIndex = 8
        Me.lblNote.Text = "Nota segnalazione:"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(124, 458)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(508, 53)
        Me.txtNote.TabIndex = 7
        Me.txtNote.TabStop = False
        '
        'txtFilterOperator
        '
        Me.txtFilterOperator.Location = New System.Drawing.Point(426, 206)
        Me.txtFilterOperator.Name = "txtFilterOperator"
        Me.txtFilterOperator.Size = New System.Drawing.Size(100, 20)
        Me.txtFilterOperator.TabIndex = 4
        '
        'txtFilterNotes
        '
        Me.txtFilterNotes.Location = New System.Drawing.Point(532, 206)
        Me.txtFilterNotes.Name = "txtFilterNotes"
        Me.txtFilterNotes.Size = New System.Drawing.Size(100, 20)
        Me.txtFilterNotes.TabIndex = 5
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(476, 232)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnApplyFilter.TabIndex = 6
        Me.btnApplyFilter.Text = "Applica filtri"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.Location = New System.Drawing.Point(557, 232)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveFilter.TabIndex = 7
        Me.btnRemoveFilter.Text = "Rimuovi filtri"
        Me.btnRemoveFilter.UseVisualStyleBackColor = True
        '
        'lblFilterNotes
        '
        Me.lblFilterNotes.AutoSize = True
        Me.lblFilterNotes.Location = New System.Drawing.Point(529, 190)
        Me.lblFilterNotes.Name = "lblFilterNotes"
        Me.lblFilterNotes.Size = New System.Drawing.Size(30, 13)
        Me.lblFilterNotes.TabIndex = 14
        Me.lblFilterNotes.Text = "Note"
        '
        'lblFilterOperator
        '
        Me.lblFilterOperator.AutoSize = True
        Me.lblFilterOperator.Location = New System.Drawing.Point(423, 190)
        Me.lblFilterOperator.Name = "lblFilterOperator"
        Me.lblFilterOperator.Size = New System.Drawing.Size(54, 13)
        Me.lblFilterOperator.TabIndex = 15
        Me.lblFilterOperator.Text = "Operatore"
        '
        'timePickFilterStart
        '
        Me.timePickFilterStart.Enabled = False
        Me.timePickFilterStart.Location = New System.Drawing.Point(73, 206)
        Me.timePickFilterStart.Name = "timePickFilterStart"
        Me.timePickFilterStart.Size = New System.Drawing.Size(169, 20)
        Me.timePickFilterStart.TabIndex = 1
        Me.timePickFilterStart.Value = New Date(2019, 7, 9, 12, 28, 42, 0)
        '
        'timePickFilterEnd
        '
        Me.timePickFilterEnd.Enabled = False
        Me.timePickFilterEnd.Location = New System.Drawing.Point(248, 206)
        Me.timePickFilterEnd.Name = "timePickFilterEnd"
        Me.timePickFilterEnd.Size = New System.Drawing.Size(169, 20)
        Me.timePickFilterEnd.TabIndex = 3
        Me.timePickFilterEnd.Value = New Date(2019, 7, 9, 12, 28, 42, 0)
        '
        'checkFilterStart
        '
        Me.checkFilterStart.AutoSize = True
        Me.checkFilterStart.Location = New System.Drawing.Point(73, 189)
        Me.checkFilterStart.Name = "checkFilterStart"
        Me.checkFilterStart.Size = New System.Drawing.Size(75, 17)
        Me.checkFilterStart.TabIndex = 0
        Me.checkFilterStart.Text = "Data inizio"
        Me.checkFilterStart.UseVisualStyleBackColor = True
        '
        'checkFilterEnd
        '
        Me.checkFilterEnd.AutoSize = True
        Me.checkFilterEnd.Location = New System.Drawing.Point(248, 189)
        Me.checkFilterEnd.Name = "checkFilterEnd"
        Me.checkFilterEnd.Size = New System.Drawing.Size(69, 17)
        Me.checkFilterEnd.TabIndex = 2
        Me.checkFilterEnd.Text = "Data fine"
        Me.checkFilterEnd.UseVisualStyleBackColor = True
        '
        'ConsultazioneSegnalazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 561)
        Me.Controls.Add(Me.checkFilterEnd)
        Me.Controls.Add(Me.checkFilterStart)
        Me.Controls.Add(Me.timePickFilterEnd)
        Me.Controls.Add(Me.timePickFilterStart)
        Me.Controls.Add(Me.lblFilterOperator)
        Me.Controls.Add(Me.lblFilterNotes)
        Me.Controls.Add(Me.btnRemoveFilter)
        Me.Controls.Add(Me.btnApplyFilter)
        Me.Controls.Add(Me.txtFilterNotes)
        Me.Controls.Add(Me.txtFilterOperator)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lbl_TextDetails)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblReports)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gridDetails)
        Me.Controls.Add(Me.gridReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ConsultazioneSegnalazioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultazione segnalazioni"
        CType(Me.gridReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridReports As DataGridView
    Friend WithEvents gridDetails As DataGridView
    Friend WithEvents columnUser As DataGridViewTextBoxColumn
    Friend WithEvents columnName As DataGridViewTextBoxColumn
    Friend WithEvents columnSurname As DataGridViewTextBoxColumn
    Friend WithEvents columnSMS As DataGridViewTextBoxColumn
    Friend WithEvents columnMail As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblReports As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lbl_TextDetails As Label
    Friend WithEvents columnDateTime As DataGridViewTextBoxColumn
    Friend WithEvents columnOperator As DataGridViewTextBoxColumn
    Friend WithEvents columnNotes As DataGridViewTextBoxColumn
    Friend WithEvents lblNote As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtFilterOperator As TextBox
    Friend WithEvents txtFilterNotes As TextBox
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnRemoveFilter As Button
    Friend WithEvents lblFilterNotes As Label
    Friend WithEvents lblFilterOperator As Label
    Friend WithEvents timePickFilterStart As DateTimePicker
    Friend WithEvents timePickFilterEnd As DateTimePicker
    Friend WithEvents checkFilterStart As CheckBox
    Friend WithEvents checkFilterEnd As CheckBox
End Class
