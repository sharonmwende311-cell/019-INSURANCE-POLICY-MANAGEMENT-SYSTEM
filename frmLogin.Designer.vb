<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        lblTitle = New Label()
        lblInstruction = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblpPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 14.0F)
        lblTitle.ForeColor = Color.Firebrick
        lblTitle.Location = New Point(157, 40)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(430, 35)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Insurance Policy Management System"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Location = New Point(301, 93)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(142, 15)
        lblInstruction.TabIndex = 1
        lblInstruction.Text = "Please sign in to continue"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.ForeColor = Color.DimGray
        lblUsername.Location = New Point(320, 126)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(94, 15)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username/email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(269, 153)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(214, 23)
        txtUsername.TabIndex = 3
        ' 
        ' lblpPassword
        ' 
        lblpPassword.AutoSize = True
        lblpPassword.ForeColor = Color.DimGray
        lblpPassword.Location = New Point(344, 191)
        lblpPassword.Name = "lblpPassword"
        lblpPassword.Size = New Size(57, 15)
        lblpPassword.TabIndex = 4
        lblpPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(269, 218)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(214, 23)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.LightGray
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.0F)
        btnLogin.ForeColor = Color.Maroon
        btnLogin.Location = New Point(344, 264)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 31)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(401, 350)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 15)
        lblStatus.TabIndex = 7
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 411)
        Controls.Add(lblStatus)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(lblpPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(lblInstruction)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblpPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblStatus As Label
End Class
