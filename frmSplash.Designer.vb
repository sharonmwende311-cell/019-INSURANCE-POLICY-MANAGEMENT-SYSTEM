<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplash
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
        components = New ComponentModel.Container()
        pn1TopAccent = New Panel()
        pnlBottomAccent = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        lblStatus = New Label()
        lblDots = New Label()
        lblCheck = New Label()
        lblWelcome = New Label()
        lblVersion = New Label()
        lbCopyright = New Label()
        tmrAnimation = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pn1TopAccent
        ' 
        pn1TopAccent.BackColor = Color.Firebrick
        pn1TopAccent.Location = New Point(0, 0)
        pn1TopAccent.Margin = New Padding(3, 4, 3, 4)
        pn1TopAccent.Name = "pn1TopAccent"
        pn1TopAccent.Size = New Size(1045, 11)
        pn1TopAccent.TabIndex = 0
        ' 
        ' pnlBottomAccent
        ' 
        pnlBottomAccent.BackColor = Color.Gold
        pnlBottomAccent.Location = New Point(0, 629)
        pnlBottomAccent.Margin = New Padding(3, 4, 3, 4)
        pnlBottomAccent.Name = "pnlBottomAccent"
        pnlBottomAccent.Size = New Size(1045, 11)
        pnlBottomAccent.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 26.0F)
        Label1.ForeColor = Color.Firebrick
        Label1.Location = New Point(241, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 47)
        Label1.TabIndex = 2
        Label1.Text = "INSURANCE POLICY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(241, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(291, 20)
        Label2.TabIndex = 3
        Label2.Text = "Your Trusted Insurance Mnagement System"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(365, 290)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(167, 20)
        lblStatus.TabIndex = 4
        lblStatus.Text = "Initializing apllication....."
        ' 
        ' lblDots
        ' 
        lblDots.AutoSize = True
        lblDots.Font = New Font("Segoe UI", 14.0F)
        lblDots.ForeColor = Color.Firebrick
        lblDots.Location = New Point(530, 290)
        lblDots.Name = "lblDots"
        lblDots.Size = New Size(24, 25)
        lblDots.TabIndex = 5
        lblDots.Text = "..."
        ' 
        ' lblCheck
        ' 
        lblCheck.AutoSize = True
        lblCheck.Font = New Font("Segoe UI", 40.0F)
        lblCheck.ForeColor = Color.ForestGreen
        lblCheck.Location = New Point(430, 190)
        lblCheck.Name = "lblCheck"
        lblCheck.Size = New Size(70, 72)
        lblCheck.TabIndex = 6
        lblCheck.Text = "✓"
        lblCheck.Visible = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 13.0F)
        lblWelcome.ForeColor = Color.ForestGreen
        lblWelcome.Location = New Point(300, 260)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(275, 25)
        lblWelcome.TabIndex = 7
        lblWelcome.Text = "Database connected successfully!"
        lblWelcome.Visible = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Segoe UI", 9.0F)
        lblVersion.Location = New Point(20, 440)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(72, 15)
        lblVersion.TabIndex = 8
        lblVersion.Text = "Version 1.0.0"
        ' 
        ' lbCopyright
        ' 
        lbCopyright.AutoSize = True
        lbCopyright.Font = New Font("Segoe UI", 9.0F)
        lbCopyright.Location = New Point(580, 440)
        lbCopyright.Name = "lbCopyright"
        lbCopyright.Size = New Size(272, 15)
        lbCopyright.TabIndex = 9
        lbCopyright.Text = "©2026 Insurance Policy System.All rights reserved."
        ' 
        ' tmrAnimation
        ' 
        tmrAnimation.Interval = 60
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(312, 195)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' frmSplash
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1045, 640)
        Controls.Add(PictureBox1)
        Controls.Add(lbCopyright)
        Controls.Add(lblVersion)
        Controls.Add(lblWelcome)
        Controls.Add(lblCheck)
        Controls.Add(lblDots)
        Controls.Add(lblStatus)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pnlBottomAccent)
        Controls.Add(pn1TopAccent)
        Font = New Font("Segoe UI", 11.0F)
        ForeColor = Color.DimGray
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(245, 155)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Your Trusted Insurance Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pn1TopAccent As Panel
    Friend WithEvents pnlBottomAccent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDots As Label
    Friend WithEvents lblCheck As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lbCopyright As Label
    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents PictureBox1 As PictureBox

End Class
