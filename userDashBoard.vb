Public Class userDashBoard
    Public Property UserRole As String
    Public Property UserName As String

    Private Sub userDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub


End Class