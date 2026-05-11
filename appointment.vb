Public Class frmAppointment
    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = GetNextID("appointment").ToString()
    End Sub
End Class