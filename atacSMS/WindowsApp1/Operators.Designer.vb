<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Operators
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
        Me.gridOperators = New System.Windows.Forms.DataGridView()
        Me.culumnOperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAdmin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBackToMainMenu = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPsw = New System.Windows.Forms.TextBox()
        Me.lblConfirmPsw = New System.Windows.Forms.Label()
        Me.checkAdmin = New System.Windows.Forms.CheckBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        CType(Me.gridOperators, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridOperators
        '
        Me.gridOperators.AllowUserToAddRows = False
        Me.gridOperators.AllowUserToDeleteRows = False
        Me.gridOperators.AllowUserToResizeColumns = False
        Me.gridOperators.AllowUserToResizeRows = False
        Me.gridOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOperators.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.culumnOperator, Me.columnAdmin, Me.columnDelete})
        Me.gridOperators.Location = New System.Drawing.Point(71, 12)
        Me.gridOperators.Name = "gridOperators"
        Me.gridOperators.RowHeadersVisible = False
        Me.gridOperators.ShowEditingIcon = False
        Me.gridOperators.Size = New System.Drawing.Size(383, 150)
        Me.gridOperators.TabIndex = 0
        Me.gridOperators.TabStop = False
        '
        'culumnOperator
        '
        Me.culumnOperator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.culumnOperator.HeaderText = "Operatore"
        Me.culumnOperator.Name = "culumnOperator"
        Me.culumnOperator.ReadOnly = True
        Me.culumnOperator.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnAdmin
        '
        Me.columnAdmin.HeaderText = "Amministratore"
        Me.columnAdmin.Name = "columnAdmin"
        Me.columnAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnDelete
        '
        Me.columnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnDelete.HeaderText = ""
        Me.columnDelete.Name = "columnDelete"
        Me.columnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.columnDelete.Text = "Elimina"
        Me.columnDelete.UseColumnTextForButtonValue = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(151, 287)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(114, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "Inserisci nuovo"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnBackToMainMenu
        '
        Me.btnBackToMainMenu.Location = New System.Drawing.Point(271, 287)
        Me.btnBackToMainMenu.Name = "btnBackToMainMenu"
        Me.btnBackToMainMenu.Size = New System.Drawing.Size(114, 23)
        Me.btnBackToMainMenu.TabIndex = 5
        Me.btnBackToMainMenu.Text = "Menu principale"
        Me.btnBackToMainMenu.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(148, 179)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(148, 205)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(260, 176)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(125, 20)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(260, 202)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(125, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtConfirmPsw
        '
        Me.txtConfirmPsw.Location = New System.Drawing.Point(260, 228)
        Me.txtConfirmPsw.Name = "txtConfirmPsw"
        Me.txtConfirmPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPsw.Size = New System.Drawing.Size(125, 20)
        Me.txtConfirmPsw.TabIndex = 2
        '
        'lblConfirmPsw
        '
        Me.lblConfirmPsw.AutoSize = True
        Me.lblConfirmPsw.Location = New System.Drawing.Point(148, 231)
        Me.lblConfirmPsw.Name = "lblConfirmPsw"
        Me.lblConfirmPsw.Size = New System.Drawing.Size(103, 13)
        Me.lblConfirmPsw.TabIndex = 8
        Me.lblConfirmPsw.Text = "Conferma password:"
        '
        'checkAdmin
        '
        Me.checkAdmin.AutoSize = True
        Me.checkAdmin.Location = New System.Drawing.Point(260, 255)
        Me.checkAdmin.Name = "checkAdmin"
        Me.checkAdmin.Size = New System.Drawing.Size(15, 14)
        Me.checkAdmin.TabIndex = 3
        Me.checkAdmin.UseVisualStyleBackColor = True
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(148, 255)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(78, 13)
        Me.lblAdmin.TabIndex = 11
        Me.lblAdmin.Text = "Amministratore:"
        '
        'Operatori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 324)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.checkAdmin)
        Me.Controls.Add(Me.txtConfirmPsw)
        Me.Controls.Add(Me.lblConfirmPsw)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnBackToMainMenu)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gridOperators)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Operatori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione operatori"
        CType(Me.gridOperators, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As Button
    Friend WithEvents btnBackToMainMenu As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents gridOperators As DataGridView
    Friend WithEvents txtConfirmPsw As TextBox
    Friend WithEvents lblConfirmPsw As Label
    Friend WithEvents culumnOperator As DataGridViewTextBoxColumn
    Friend WithEvents columnAdmin As DataGridViewCheckBoxColumn
    Friend WithEvents columnDelete As DataGridViewButtonColumn
    Friend WithEvents checkAdmin As CheckBox
    Friend WithEvents lblAdmin As Label
End Class
