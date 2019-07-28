<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credentials
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
        Me.lblSMSUser = New System.Windows.Forms.Label()
        Me.lblSMSPsw = New System.Windows.Forms.Label()
        Me.lblMailUser = New System.Windows.Forms.Label()
        Me.lblMailPsw = New System.Windows.Forms.Label()
        Me.txtSMSUser = New System.Windows.Forms.TextBox()
        Me.txtSMSPsw = New System.Windows.Forms.TextBox()
        Me.txtMailUser = New System.Windows.Forms.TextBox()
        Me.txtMailPsw = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSMSUser
        '
        Me.lblSMSUser.AutoSize = True
        Me.lblSMSUser.Location = New System.Drawing.Point(26, 18)
        Me.lblSMSUser.Name = "lblSMSUser"
        Me.lblSMSUser.Size = New System.Drawing.Size(87, 13)
        Me.lblSMSUser.TabIndex = 0
        Me.lblSMSUser.Text = "Aruba SMS user:"
        '
        'lblSMSPsw
        '
        Me.lblSMSPsw.AutoSize = True
        Me.lblSMSPsw.Location = New System.Drawing.Point(26, 44)
        Me.lblSMSPsw.Name = "lblSMSPsw"
        Me.lblSMSPsw.Size = New System.Drawing.Size(112, 13)
        Me.lblSMSPsw.TabIndex = 1
        Me.lblSMSPsw.Text = "Aruba SMS password:"
        '
        'lblMailUser
        '
        Me.lblMailUser.AutoSize = True
        Me.lblMailUser.Location = New System.Drawing.Point(26, 70)
        Me.lblMailUser.Name = "lblMailUser"
        Me.lblMailUser.Size = New System.Drawing.Size(52, 13)
        Me.lblMailUser.TabIndex = 2
        Me.lblMailUser.Text = "Mail user:"
        '
        'lblMailPsw
        '
        Me.lblMailPsw.AutoSize = True
        Me.lblMailPsw.Location = New System.Drawing.Point(26, 96)
        Me.lblMailPsw.Name = "lblMailPsw"
        Me.lblMailPsw.Size = New System.Drawing.Size(77, 13)
        Me.lblMailPsw.TabIndex = 3
        Me.lblMailPsw.Text = "Mail password:"
        '
        'txtSMSUser
        '
        Me.txtSMSUser.Location = New System.Drawing.Point(140, 15)
        Me.txtSMSUser.Name = "txtSMSUser"
        Me.txtSMSUser.Size = New System.Drawing.Size(152, 20)
        Me.txtSMSUser.TabIndex = 0
        '
        'txtSMSPsw
        '
        Me.txtSMSPsw.Location = New System.Drawing.Point(140, 41)
        Me.txtSMSPsw.Name = "txtSMSPsw"
        Me.txtSMSPsw.Size = New System.Drawing.Size(152, 20)
        Me.txtSMSPsw.TabIndex = 1
        '
        'txtMailUser
        '
        Me.txtMailUser.Location = New System.Drawing.Point(140, 67)
        Me.txtMailUser.Name = "txtMailUser"
        Me.txtMailUser.Size = New System.Drawing.Size(152, 20)
        Me.txtMailUser.TabIndex = 2
        '
        'txtMailPsw
        '
        Me.txtMailPsw.Location = New System.Drawing.Point(140, 93)
        Me.txtMailPsw.Name = "txtMailPsw"
        Me.txtMailPsw.Size = New System.Drawing.Size(152, 20)
        Me.txtMailPsw.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(29, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(122, 129)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(217, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Annulla"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Credenziali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 176)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMailPsw)
        Me.Controls.Add(Me.txtMailUser)
        Me.Controls.Add(Me.txtSMSPsw)
        Me.Controls.Add(Me.txtSMSUser)
        Me.Controls.Add(Me.lblMailPsw)
        Me.Controls.Add(Me.lblMailUser)
        Me.Controls.Add(Me.lblSMSPsw)
        Me.Controls.Add(Me.lblSMSUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Credenziali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credenziali"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSMSUser As Label
    Friend WithEvents lblSMSPsw As Label
    Friend WithEvents lblMailUser As Label
    Friend WithEvents lblMailPsw As Label
    Friend WithEvents txtSMSUser As TextBox
    Friend WithEvents txtSMSPsw As TextBox
    Friend WithEvents txtMailUser As TextBox
    Friend WithEvents txtMailPsw As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnDelete As Button
End Class
