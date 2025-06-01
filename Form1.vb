Public Class frmFrontPage
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblReportProgress.Text = pbLoarding1.Value & "%"

        pbLoarding1.Value += 2

        If pbLoarding1.Value > 10 Then
            lblStatusText.Text = "Initializing system..."
        End If

        If pbLoarding1.Value > 35 Then
            lblStatusText.Text = "Loading resources..."
        End If

        If pbLoarding1.Value > 65 Then
            lblStatusText.Text = "Connecting to database... "
        End If

        If pbLoarding1.Value > 85 Then
            lblStatusText.Text = "Processing data..."
        End If

        If pbLoarding1.Value = 100 Then
            lblStatusText.Text = "Launching application..."
            frmLogin.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub


End Class
