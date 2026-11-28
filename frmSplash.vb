Imports MySql.Data.MySqlClient

Public Class frmSplash

    Private dotCount As Integer = 0
    Private spinnerAngle As Integer = 0

    Private Async Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblCheck.Visible = False
        lblWelcome.Visible = False

        lblStatus.Text = "Initializing application..."
        lblDots.Text = ""

        tmrAnimation.Start()
        Await CheckDatabaseConnectionAsync()

    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick

        dotCount += 1

        If dotCount > 3 Then
            dotCount = 0
        End If

        lblDots.Text = New String("."c, dotCount)

        spinnerAngle += 15

        If spinnerAngle >= 360 Then
            spinnerAngle = 0
        End If

        PictureBox1.Invalidate()

    End Sub

    Private Sub picSpinner_paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim rect As New Rectangle(10, 10, 40, 40)

        For i As Integer = 0 To 7

            Dim alpha As Integer = 30 + (i * 28)
            Dim pen As New Pen(Color.FromArgb(alpha, Color.Firebrick), 4)

            g.DrawArc(pen, rect, spinnerAngle + (i * 45), 30)

            pen.Dispose()

        Next

    End Sub
    Private Async Function CheckDatabaseConnectionAsync() As Task

        Try

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                Await conn.OpenAsync()

                tmrAnimation.Stop()

                lblStatus.Text = "Database connected successfully!"
                lblCheck.Visible = True
                lblWelcome.Visible = True

                Dim login As New frmLogin

                AddHandler login.FormClosed, AddressOf Login_FormClosed

                login.Show()
                Me.Hide()

            End Using

        Catch ex As Exception

            tmrAnimation.Stop()

            lblStatus.Text = "Unable to connect to the database."
            lblCheck.Visible = False
            lblWelcome.Visible = False

            MessageBox.Show(
            "We couldn't connect to the database. Please check your connection and try again.",
            "Connection Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Application.Exit()

        End Try

    End Function
    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Close()
    End Sub

End Class