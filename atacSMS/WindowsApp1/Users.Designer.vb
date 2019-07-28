<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.gridUsers = New System.Windows.Forms.DataGridView()
        Me.columnUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnBranch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSelection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnRemoveFilter = New System.Windows.Forms.Button()
        Me.btnApplyFilter = New System.Windows.Forms.Button()
        Me.txtFilterUser = New System.Windows.Forms.TextBox()
        Me.txtFilterBranch = New System.Windows.Forms.TextBox()
        Me.lblFilterUser = New System.Windows.Forms.Label()
        Me.lblFilterBranch = New System.Windows.Forms.Label()
        Me.btnDeleteAllSelected = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCAP = New System.Windows.Forms.TextBox()
        Me.lblCAP = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.lblMobilePhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnLoadAll = New System.Windows.Forms.Button()
        CType(Me.gridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(300, 522)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 27)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "Crea nuovo"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(408, 522)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(102, 27)
        Me.btnMainMenu.TabIndex = 20
        Me.btnMainMenu.Text = "Menu principale"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'gridUsers
        '
        Me.gridUsers.AllowUserToAddRows = False
        Me.gridUsers.AllowUserToDeleteRows = False
        Me.gridUsers.AllowUserToResizeColumns = False
        Me.gridUsers.AllowUserToResizeRows = False
        Me.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnUser, Me.columnBranch, Me.columnName, Me.columnSurname, Me.columnSelection})
        Me.gridUsers.Location = New System.Drawing.Point(46, 88)
        Me.gridUsers.Name = "gridUsers"
        Me.gridUsers.RowHeadersVisible = False
        Me.gridUsers.ShowCellErrors = False
        Me.gridUsers.ShowCellToolTips = False
        Me.gridUsers.ShowEditingIcon = False
        Me.gridUsers.ShowRowErrors = False
        Me.gridUsers.Size = New System.Drawing.Size(722, 195)
        Me.gridUsers.TabIndex = 2
        Me.gridUsers.TabStop = False
        '
        'columnUser
        '
        Me.columnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnUser.HeaderText = "Utenza"
        Me.columnUser.Name = "columnUser"
        Me.columnUser.ReadOnly = True
        Me.columnUser.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnBranch
        '
        Me.columnBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnBranch.HeaderText = "Ramo"
        Me.columnBranch.Name = "columnBranch"
        Me.columnBranch.ReadOnly = True
        Me.columnBranch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'columnSelection
        '
        Me.columnSelection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnSelection.HeaderText = ""
        Me.columnSelection.Name = "columnSelection"
        Me.columnSelection.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.columnSelection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.Location = New System.Drawing.Point(543, 55)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(102, 27)
        Me.btnRemoveFilter.TabIndex = 3
        Me.btnRemoveFilter.Text = "Rimuovi filtro"
        Me.btnRemoveFilter.UseVisualStyleBackColor = True
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(436, 55)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(102, 27)
        Me.btnApplyFilter.TabIndex = 2
        Me.btnApplyFilter.Text = "Applica filtro"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'txtFilterUser
        '
        Me.txtFilterUser.Location = New System.Drawing.Point(63, 59)
        Me.txtFilterUser.Name = "txtFilterUser"
        Me.txtFilterUser.Size = New System.Drawing.Size(131, 20)
        Me.txtFilterUser.TabIndex = 0
        '
        'txtFilterBranch
        '
        Me.txtFilterBranch.Location = New System.Drawing.Point(200, 59)
        Me.txtFilterBranch.Name = "txtFilterBranch"
        Me.txtFilterBranch.Size = New System.Drawing.Size(131, 20)
        Me.txtFilterBranch.TabIndex = 1
        '
        'lblFilterUser
        '
        Me.lblFilterUser.AutoSize = True
        Me.lblFilterUser.Location = New System.Drawing.Point(60, 43)
        Me.lblFilterUser.Name = "lblFilterUser"
        Me.lblFilterUser.Size = New System.Drawing.Size(41, 13)
        Me.lblFilterUser.TabIndex = 7
        Me.lblFilterUser.Text = "Utenza"
        '
        'lblFilterBranch
        '
        Me.lblFilterBranch.AutoSize = True
        Me.lblFilterBranch.Location = New System.Drawing.Point(197, 43)
        Me.lblFilterBranch.Name = "lblFilterBranch"
        Me.lblFilterBranch.Size = New System.Drawing.Size(35, 13)
        Me.lblFilterBranch.TabIndex = 8
        Me.lblFilterBranch.Text = "Ramo"
        '
        'btnDeleteAllSelected
        '
        Me.btnDeleteAllSelected.Location = New System.Drawing.Point(651, 289)
        Me.btnDeleteAllSelected.Name = "btnDeleteAllSelected"
        Me.btnDeleteAllSelected.Size = New System.Drawing.Size(102, 27)
        Me.btnDeleteAllSelected.TabIndex = 6
        Me.btnDeleteAllSelected.Text = "Elimina selezionati"
        Me.btnDeleteAllSelected.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(543, 289)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(102, 27)
        Me.btnSelectAll.TabIndex = 5
        Me.btnSelectAll.Text = "Seleziona tutti"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(52, 365)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(44, 13)
        Me.lblUser.TabIndex = 12
        Me.lblUser.Text = "Utenza:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(109, 362)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(175, 20)
        Me.txtUser.TabIndex = 7
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(109, 388)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.ReadOnly = True
        Me.txtBranch.Size = New System.Drawing.Size(175, 20)
        Me.txtBranch.TabIndex = 8
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(52, 391)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(38, 13)
        Me.lblBranch.TabIndex = 14
        Me.lblBranch.Text = "Ramo:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(109, 440)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(175, 20)
        Me.txtSurname.TabIndex = 10
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(52, 443)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(55, 13)
        Me.lblSurname.TabIndex = 18
        Me.lblSurname.Text = "Cognome:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 414)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(175, 20)
        Me.txtName.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(52, 417)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Nome:"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(347, 440)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.ReadOnly = True
        Me.txtRegion.Size = New System.Drawing.Size(175, 20)
        Me.txtRegion.TabIndex = 14
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(290, 443)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(54, 13)
        Me.lblRegion.TabIndex = 26
        Me.lblRegion.Text = "Provincia:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(347, 414)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(175, 20)
        Me.txtCity.TabIndex = 13
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(290, 417)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 13)
        Me.lblCity.TabIndex = 24
        Me.lblCity.Text = "Città:"
        '
        'txtCAP
        '
        Me.txtCAP.Location = New System.Drawing.Point(347, 388)
        Me.txtCAP.Name = "txtCAP"
        Me.txtCAP.ReadOnly = True
        Me.txtCAP.Size = New System.Drawing.Size(175, 20)
        Me.txtCAP.TabIndex = 12
        '
        'lblCAP
        '
        Me.lblCAP.AutoSize = True
        Me.lblCAP.Location = New System.Drawing.Point(290, 391)
        Me.lblCAP.Name = "lblCAP"
        Me.lblCAP.Size = New System.Drawing.Size(31, 13)
        Me.lblCAP.TabIndex = 22
        Me.lblCAP.Text = "CAP:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(347, 362)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(175, 20)
        Me.txtAddress.TabIndex = 11
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(290, 365)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Indirizzo:"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(585, 414)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(175, 20)
        Me.txtMail.TabIndex = 17
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(528, 417)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(29, 13)
        Me.lblMail.TabIndex = 32
        Me.lblMail.Text = "Mail:"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Location = New System.Drawing.Point(585, 388)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.ReadOnly = True
        Me.txtMobilePhone.Size = New System.Drawing.Size(175, 20)
        Me.txtMobilePhone.TabIndex = 16
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.AutoSize = True
        Me.lblMobilePhone.Location = New System.Drawing.Point(528, 391)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(50, 13)
        Me.lblMobilePhone.TabIndex = 30
        Me.lblMobilePhone.Text = "Cellulare:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(585, 362)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(175, 20)
        Me.txtPhone.TabIndex = 15
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(528, 365)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 13)
        Me.lblPhone.TabIndex = 28
        Me.lblPhone.Text = "Telefono:"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(91, 332)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(43, 13)
        Me.lblDetails.TabIndex = 36
        Me.lblDetails.Text = "Dettagli"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(651, 466)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 27)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Modifica utenza"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnLoadAll
        '
        Me.btnLoadAll.Location = New System.Drawing.Point(651, 55)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(102, 27)
        Me.btnLoadAll.TabIndex = 4
        Me.btnLoadAll.Text = "Carica tutti"
        Me.btnLoadAll.UseVisualStyleBackColor = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 561)
        Me.Controls.Add(Me.btnLoadAll)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtMobilePhone)
        Me.Controls.Add(Me.lblMobilePhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtCAP)
        Me.Controls.Add(Me.lblCAP)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnDeleteAllSelected)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.lblFilterBranch)
        Me.Controls.Add(Me.lblFilterUser)
        Me.Controls.Add(Me.txtFilterBranch)
        Me.Controls.Add(Me.txtFilterUser)
        Me.Controls.Add(Me.btnRemoveFilter)
        Me.Controls.Add(Me.btnApplyFilter)
        Me.Controls.Add(Me.gridUsers)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione utenze"
        CType(Me.gridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents gridUsers As DataGridView
    Friend WithEvents btnRemoveFilter As Button
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents txtFilterUser As TextBox
    Friend WithEvents txtFilterBranch As TextBox
    Friend WithEvents lblFilterUser As Label
    Friend WithEvents lblFilterBranch As Label
    Friend WithEvents btnDeleteAllSelected As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents columnUser As DataGridViewTextBoxColumn
    Friend WithEvents columnBranch As DataGridViewTextBoxColumn
    Friend WithEvents columnName As DataGridViewTextBoxColumn
    Friend WithEvents columnSurname As DataGridViewTextBoxColumn
    Friend WithEvents columnSelection As DataGridViewCheckBoxColumn
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents lblBranch As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCAP As TextBox
    Friend WithEvents lblCAP As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents lblMobilePhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnLoadAll As Button
End Class
