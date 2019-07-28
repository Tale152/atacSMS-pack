<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEdit
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
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.lblMobilePhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCAP = New System.Windows.Forms.TextBox()
        Me.lblCAP = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(372, 135)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(175, 20)
        Me.txtMail.TabIndex = 9
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(315, 138)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(29, 13)
        Me.lblMail.TabIndex = 56
        Me.lblMail.Text = "Mail:"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Location = New System.Drawing.Point(372, 109)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(175, 20)
        Me.txtMobilePhone.TabIndex = 8
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.AutoSize = True
        Me.lblMobilePhone.Location = New System.Drawing.Point(315, 112)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(50, 13)
        Me.lblMobilePhone.TabIndex = 54
        Me.lblMobilePhone.Text = "Cellulare:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(372, 83)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(175, 20)
        Me.txtPhone.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(315, 86)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 13)
        Me.lblPhone.TabIndex = 52
        Me.lblPhone.Text = "Telefono:"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(372, 57)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(175, 20)
        Me.txtRegion.TabIndex = 6
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(315, 60)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(54, 13)
        Me.lblRegion.TabIndex = 50
        Me.lblRegion.Text = "Provincia:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(372, 31)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(175, 20)
        Me.txtCity.TabIndex = 6
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(315, 34)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 13)
        Me.lblCity.TabIndex = 48
        Me.lblCity.Text = "Città:"
        '
        'txtCAP
        '
        Me.txtCAP.Location = New System.Drawing.Point(99, 161)
        Me.txtCAP.Name = "txtCAP"
        Me.txtCAP.Size = New System.Drawing.Size(175, 20)
        Me.txtCAP.TabIndex = 5
        '
        'lblCAP
        '
        Me.lblCAP.AutoSize = True
        Me.lblCAP.Location = New System.Drawing.Point(42, 164)
        Me.lblCAP.Name = "lblCAP"
        Me.lblCAP.Size = New System.Drawing.Size(31, 13)
        Me.lblCAP.TabIndex = 46
        Me.lblCAP.Text = "CAP:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(99, 135)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(175, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(42, 138)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 44
        Me.lblAddress.Text = "Indirizzo:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(99, 109)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(175, 20)
        Me.txtSurname.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(42, 112)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(59, 13)
        Me.lblSurname.TabIndex = 42
        Me.lblSurname.Text = "Cognome*:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 20)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(42, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 13)
        Me.lblName.TabIndex = 40
        Me.lblName.Text = "Nome*:"
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(99, 57)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(175, 20)
        Me.txtBranch.TabIndex = 1
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(42, 60)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(42, 13)
        Me.lblBranch.TabIndex = 38
        Me.lblBranch.Text = "Ramo*:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(99, 31)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(175, 20)
        Me.txtUser.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(42, 34)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 13)
        Me.lblUser.TabIndex = 36
        Me.lblUser.Text = "Utenza*:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(220, 213)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(301, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Annulla"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 251)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "UserEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea nuova utenza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents lblMobilePhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCAP As TextBox
    Friend WithEvents lblCAP As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents lblBranch As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
End Class
