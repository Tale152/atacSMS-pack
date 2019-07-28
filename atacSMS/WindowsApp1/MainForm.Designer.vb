<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnSendReport = New System.Windows.Forms.Button()
        Me.btnConsultReports = New System.Windows.Forms.Button()
        Me.btnOperators = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnCredentials = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSendReport
        '
        Me.btnSendReport.Location = New System.Drawing.Point(122, 29)
        Me.btnSendReport.Name = "btnSendReport"
        Me.btnSendReport.Size = New System.Drawing.Size(153, 45)
        Me.btnSendReport.TabIndex = 0
        Me.btnSendReport.Text = "Invio segnalazioni"
        Me.btnSendReport.UseVisualStyleBackColor = True
        '
        'btnConsultReports
        '
        Me.btnConsultReports.Location = New System.Drawing.Point(122, 80)
        Me.btnConsultReports.Name = "btnConsultReports"
        Me.btnConsultReports.Size = New System.Drawing.Size(153, 45)
        Me.btnConsultReports.TabIndex = 1
        Me.btnConsultReports.Text = "Consultazione segnalazioni"
        Me.btnConsultReports.UseVisualStyleBackColor = True
        '
        'btnOperators
        '
        Me.btnOperators.Location = New System.Drawing.Point(122, 131)
        Me.btnOperators.Name = "btnOperators"
        Me.btnOperators.Size = New System.Drawing.Size(153, 45)
        Me.btnOperators.TabIndex = 2
        Me.btnOperators.Text = "Gestione operatori"
        Me.btnOperators.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(122, 182)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(153, 45)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "Gestione utenze"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnCredentials
        '
        Me.btnCredentials.Location = New System.Drawing.Point(122, 233)
        Me.btnCredentials.Name = "btnCredentials"
        Me.btnCredentials.Size = New System.Drawing.Size(153, 45)
        Me.btnCredentials.TabIndex = 5
        Me.btnCredentials.Text = "Credenziali messaggistica"
        Me.btnCredentials.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 301)
        Me.Controls.Add(Me.btnCredentials)
        Me.Controls.Add(Me.btnSendReport)
        Me.Controls.Add(Me.btnConsultReports)
        Me.Controls.Add(Me.btnOperators)
        Me.Controls.Add(Me.btnUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSendReport As Button
    Friend WithEvents btnConsultReports As Button
    Friend WithEvents btnOperators As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnCredentials As Button
End Class
