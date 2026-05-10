Public Class frmCustomer
    Public Property IsLookupMode As Boolean = False
    Public Property SelectedCustomerName As String = ""

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Sub LoadData()
        DataGridView1.DataSource = customerCRUD.LoadCustomers()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells("customer_id").Value.ToString()
            Guna2TextBox1.Text = row.Cells("customer_name").Value.ToString()
            Guna2TextBox2.Text = row.Cells("contact_number").Value.ToString()
            Guna2TextBox3.Text = row.Cells("address").Value.ToString()

            If IsLookupMode Then
                SelectedCustomerName = Guna2TextBox1.Text
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
