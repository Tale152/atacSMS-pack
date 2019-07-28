<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(142, 46)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(142, 78)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(100, 20)
        Me.txtPsw.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.Location = New System.Drawing.Point(107, 124)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 25)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Accedi"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.Location = New System.Drawing.Point(50, 49)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(42, 13)
        Me.lblUtente.TabIndex = 3
        Me.lblUtente.Text = "Utente:"
        '
        'lblPsw
        '
        Me.lblPsw.AutoSize = True
        Me.lblPsw.Location = New System.Drawing.Point(50, 81)
        Me.lblPsw.Name = "lblPsw"
        Me.lblPsw.Size = New System.Drawing.Size(56, 13)
        Me.lblPsw.TabIndex = 4
        Me.lblPsw.Text = "Password:"
        '
        'Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.lblUtente)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.txtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Authentication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticazione"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUtente As Label
    Friend WithEvents lblPsw As Label
End Class
