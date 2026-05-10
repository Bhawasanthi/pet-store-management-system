Public Class frmAppointment
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using customerForm As New frmCustomer()
            customerForm.IsLookupMode = True
            If customerForm.ShowDialog() = DialogResult.OK Then
                Guna2TextBox5.Text = customerForm.SelectedCustomerName
            End If
        End Using
    End Sub
End Class
