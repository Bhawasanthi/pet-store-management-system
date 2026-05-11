Public Class frmService
    Private Sub frmService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = GetNextID("service").ToString()
    End Sub
End Class