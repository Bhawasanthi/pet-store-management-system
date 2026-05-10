Public Class frmCustomer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try
            txtID.Text = GetNextCustomerID().ToString()
            DataGridView1.DataSource = LoadCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtContact.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a customer name.")
            Exit Sub
        End If

        Try
            AddCustomer(txtName.Text, txtContact.Text, txtAddress.Text)
            MessageBox.Show("Customer added successfully!")
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a customer from the table to edit.")
            Exit Sub
        End If

        ' Verify if we are actually editing an existing record (matching IDs)
        Dim selectedId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("customer_id").Value)
        If txtID.Text <> selectedId.ToString() Then
            MessageBox.Show("The ID in the text box does not match the selected record. Please click a record in the table first.")
            Exit Sub
        End If

        Try
            UpdateCustomer(selectedId, txtName.Text, txtContact.Text, txtAddress.Text)
            MessageBox.Show("Customer updated successfully!")
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a customer to delete.")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("customer_id").Value)
                DeleteCustomer(id)
                MessageBox.Show("Customer deleted successfully!")
                RefreshData()
            Catch ex As Exception
                MessageBox.Show("Error deleting customer: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        RefreshData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells("customer_id").Value.ToString()
            txtName.Text = row.Cells("customer_name").Value.ToString()
            txtContact.Text = row.Cells("contact_number").Value.ToString()
            txtAddress.Text = row.Cells("address").Value.ToString()
        End If
    End Sub
End Class
