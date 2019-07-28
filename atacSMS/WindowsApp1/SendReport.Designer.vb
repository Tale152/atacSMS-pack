<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chckSMS = New System.Windows.Forms.CheckBox()
        Me.chckMail = New System.Windows.Forms.CheckBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblMessageLength = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gridSelected = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAddReceiver = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.gridSource = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblSmSBalance = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblMessageText = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtMailObject = New System.Windows.Forms.TextBox()
        Me.lblMailObject = New System.Windows.Forms.Label()
        CType(Me.gridSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chckSMS
        '
        Me.chckSMS.AutoSize = True
        Me.chckSMS.Location = New System.Drawing.Point(144, 21)
        Me.chckSMS.Name = "chckSMS"
        Me.chckSMS.Size = New System.Drawing.Size(49, 17)
        Me.chckSMS.TabIndex = 0
        Me.chckSMS.Text = "SMS"
        Me.chckSMS.UseVisualStyleBackColor = True
        '
        'chckMail
        '
        Me.chckMail.AutoSize = True
        Me.chckMail.Location = New System.Drawing.Point(144, 56)
        Me.chckMail.Name = "chckMail"
        Me.chckMail.Size = New System.Drawing.Size(45, 17)
        Me.chckMail.TabIndex = 1
        Me.chckMail.Text = "Mail"
        Me.chckMail.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(144, 97)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(429, 67)
        Me.txtMessage.TabIndex = 3
        '
        'lblMessageLength
        '
        Me.lblMessageLength.AutoSize = True
        Me.lblMessageLength.Location = New System.Drawing.Point(237, 81)
        Me.lblMessageLength.Name = "lblMessageLength"
        Me.lblMessageLength.Size = New System.Drawing.Size(36, 13)
        Me.lblMessageLength.TabIndex = 3
        Me.lblMessageLength.Text = "0/160"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(293, 576)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Invia"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(383, 576)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Annulla"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gridSelected
        '
        Me.gridSelected.AllowUserToAddRows = False
        Me.gridSelected.AllowUserToDeleteRows = False
        Me.gridSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSelected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colSurname, Me.colUser, Me.colAddress, Me.colBranch, Me.colSelection})
        Me.gridSelected.Location = New System.Drawing.Point(12, 449)
        Me.gridSelected.Name = "gridSelected"
        Me.gridSelected.RowHeadersVisible = False
        Me.gridSelected.Size = New System.Drawing.Size(760, 94)
        Me.gridSelected.TabIndex = 6
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "Nome"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colSurname
        '
        Me.colSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSurname.HeaderText = "Cognome"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.ReadOnly = True
        Me.colSurname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colUser
        '
        Me.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUser.HeaderText = "Utenza"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        Me.colUser.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAddress.HeaderText = "Via"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colBranch
        '
        Me.colBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBranch.HeaderText = "Ramo"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.ReadOnly = True
        Me.colBranch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colSelection
        '
        Me.colSelection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSelection.HeaderText = ""
        Me.colSelection.Name = "colSelection"
        Me.colSelection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnAddReceiver
        '
        Me.btnAddReceiver.Location = New System.Drawing.Point(651, 408)
        Me.btnAddReceiver.Name = "btnAddReceiver"
        Me.btnAddReceiver.Size = New System.Drawing.Size(111, 23)
        Me.btnAddReceiver.TabIndex = 10
        Me.btnAddReceiver.Text = "Aggiungi selezionati"
        Me.btnAddReceiver.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(651, 549)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(111, 23)
        Me.btnRemoveSelected.TabIndex = 11
        Me.btnRemoveSelected.Text = "Rimuovi selezionati"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'gridSource
        '
        Me.gridSource.AllowUserToAddRows = False
        Me.gridSource.AllowUserToDeleteRows = False
        Me.gridSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSource.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.gridSource.Location = New System.Drawing.Point(12, 308)
        Me.gridSource.Name = "gridSource"
        Me.gridSource.RowHeadersVisible = False
        Me.gridSource.Size = New System.Drawing.Size(760, 94)
        Me.gridSource.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cognome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Utenza"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Via"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ramo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(145, 281)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 5
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(357, 281)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(100, 20)
        Me.txtBranch.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(251, 281)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 6
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(463, 279)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(91, 23)
        Me.btnFilter.TabIndex = 8
        Me.btnFilter.Text = "Filtra"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(560, 279)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(91, 23)
        Me.btnSelectAll.TabIndex = 9
        Me.btnSelectAll.Text = "Seleziona tutti"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Utenza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Via"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Ramo"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(9, 554)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(303, 13)
        Me.lblSelected.TabIndex = 18
        Me.lblSelected.Text = "Destinatari: 0 di cui 0 con cellulare, 0 con telefono e 0 con mail"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(9, 413)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(70, 13)
        Me.lblSource.TabIndex = 19
        Me.lblSource.Text = "Banca dati: 0"
        '
        'lblSmSBalance
        '
        Me.lblSmSBalance.AutoSize = True
        Me.lblSmSBalance.Location = New System.Drawing.Point(230, 22)
        Me.lblSmSBalance.Name = "lblSmSBalance"
        Me.lblSmSBalance.Size = New System.Drawing.Size(185, 13)
        Me.lblSmSBalance.TabIndex = 20
        Me.lblSmSBalance.Text = "Sms disponibili con credito corrente: 0"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(144, 188)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(429, 67)
        Me.txtNotes.TabIndex = 4
        '
        'lblMessageText
        '
        Me.lblMessageText.AutoSize = True
        Me.lblMessageText.Location = New System.Drawing.Point(141, 81)
        Me.lblMessageText.Name = "lblMessageText"
        Me.lblMessageText.Size = New System.Drawing.Size(90, 13)
        Me.lblMessageText.TabIndex = 22
        Me.lblMessageText.Text = "Testo messaggio:"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(141, 172)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(33, 13)
        Me.lblNotes.TabIndex = 23
        Me.lblNotes.Text = "Note:"
        '
        'txtMailObject
        '
        Me.txtMailObject.Enabled = False
        Me.txtMailObject.Location = New System.Drawing.Point(305, 54)
        Me.txtMailObject.Name = "txtMailObject"
        Me.txtMailObject.Size = New System.Drawing.Size(225, 20)
        Me.txtMailObject.TabIndex = 2
        '
        'lblMailObject
        '
        Me.lblMailObject.AutoSize = True
        Me.lblMailObject.Location = New System.Drawing.Point(230, 57)
        Me.lblMailObject.Name = "lblMailObject"
        Me.lblMailObject.Size = New System.Drawing.Size(69, 13)
        Me.lblMailObject.TabIndex = 25
        Me.lblMailObject.Text = "Oggetto mail:"
        '
        'InvioSegnalazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.lblMailObject)
        Me.Controls.Add(Me.txtMailObject)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblMessageText)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblSmSBalance)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.gridSource)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.btnAddReceiver)
        Me.Controls.Add(Me.gridSelected)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblMessageLength)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.chckMail)
        Me.Controls.Add(Me.chckSMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InvioSegnalazioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invio segnalazioni"
        CType(Me.gridSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chckSMS As CheckBox
    Friend WithEvents chckMail As CheckBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblMessageLength As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents gridSelected As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colSurname As DataGridViewTextBoxColumn
    Friend WithEvents colUser As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colBranch As DataGridViewTextBoxColumn
    Friend WithEvents colSelection As DataGridViewCheckBoxColumn
    Friend WithEvents btnAddReceiver As Button
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents gridSource As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lblSmSBalance As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblMessageText As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtMailObject As TextBox
    Friend WithEvents lblMailObject As Label
End Class
