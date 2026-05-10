Public Class frmServiceProduct
    Private Sub LoadData()
        dgvServiceProduct.DataSource = LoadServiceProducts()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        LoadData()
    End Sub

    Private Sub frmServiceProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtID.ReadOnly = True
        dgvServiceProduct.ReadOnly = True
        dgvServiceProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbType.SelectedIndex = -1 Or cmbProductName.SelectedIndex = -1 Or txtStock.Text = "" Then
            MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stockValue As Integer
        If Not Integer.TryParse(txtStock.Text, stockValue) Then
            MessageBox.Show("Please enter a valid number for Unit in Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AddServiceProduct(cmbType.SelectedItem.ToString(), cmbProductName.SelectedItem.ToString(), stockValue, dtpExpiry.Value) Then
            MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record from the grid view to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbType.SelectedIndex = -1 Or cmbProductName.SelectedIndex = -1 Or txtStock.Text = "" Then
            MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stockValue As Integer
        If Not Integer.TryParse(txtStock.Text, stockValue) Then
            MessageBox.Show("Please enter a valid number for Unit in Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If UpdateServiceProduct(Convert.ToInt32(txtID.Text), cmbType.SelectedItem.ToString(), cmbProductName.SelectedItem.ToString(), stockValue, dtpExpiry.Value) Then
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record from the grid view to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If DeleteServiceProduct(Convert.ToInt32(txtID.Text)) Then
                MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            End If
        End If
    End Sub

    Private Sub dgvServiceProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceProduct.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvServiceProduct.Rows(e.RowIndex)
            txtID.Text = If(IsDBNull(row.Cells("service_product_id").Value), "", row.Cells("service_product_id").Value.ToString())
            cmbType.SelectedItem = If(IsDBNull(row.Cells("service_type").Value), Nothing, row.Cells("service_type").Value.ToString())
            cmbProductName.SelectedItem = If(IsDBNull(row.Cells("product_name").Value), Nothing, row.Cells("product_name").Value.ToString())
            txtStock.Text = If(IsDBNull(row.Cells("unit_in_stock").Value), "", row.Cells("unit_in_stock").Value.ToString())

            If Not IsDBNull(row.Cells("expiry_date").Value) Then
                dtpExpiry.Value = Convert.ToDateTime(row.Cells("expiry_date").Value)
            Else
                dtpExpiry.Value = DateTime.Now
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        cmbType.SelectedIndex = -1
        cmbProductName.SelectedIndex = -1
        txtStock.Clear()
        dtpExpiry.Value = DateTime.Now
    End Sub
End Class
