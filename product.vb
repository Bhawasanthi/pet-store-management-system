Public Class frmproduct
    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        If cmbProductType.SelectedItem Is Nothing Then Exit Sub
        cmbProductName.Items.Clear()

        If cmbProductType.SelectedItem.ToString() = "Food" Then
            cmbProductName.Items.AddRange(New String() {"Dog Food", "Cat Food"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Toys" Then
            cmbProductName.Items.AddRange(New String() {"Ball", "Squeaky Toy", "Chew Toy", "Scratching Post"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Accessories" Then
            cmbProductName.Items.AddRange(New String() {"Collar", "ID Tags", "Leash", "Harness"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Litter and Waste Supplies" Then
            cmbProductName.Items.AddRange(New String() {"Litter Box", "Poop Bag", "Scooper"})
        End If
    End Sub

    Private Sub LoadProductData()
        DataGridView1.DataSource = GetProducts()
    End Sub

    Private Sub frmproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "NEW" Then
            ClearFields()
            btnAdd.Text = "ADD"
            txtName.Enabled = True
            Return
        End If

        If txtName.Text = "" Or cmbProductType.SelectedItem Is Nothing Or cmbProductName.SelectedItem Is Nothing Or Guna2TextBox4.Text = "" Or cmbAvailability.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields")
            Return
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(Guna2TextBox4.Text, price) Then
            MessageBox.Show("Please enter a valid price")
            Return
        End If

        If AddProduct(txtName.Text, cmbProductType.SelectedItem.ToString(), cmbProductName.SelectedItem.ToString(), Guna2DateTimePicker1.Value, price, cmbAvailability.SelectedItem.ToString()) Then
            MessageBox.Show("Product added successfully")
            LoadProductData()
            ClearFields()
        End If
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        LoadProductData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please select a product from the grid to edit")
            Return
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(Guna2TextBox4.Text, price) Then
            MessageBox.Show("Please enter a valid price")
            Return
        End If

        If UpdateProduct(txtName.Text, cmbProductType.SelectedItem.ToString(), cmbProductName.SelectedItem.ToString(), Guna2DateTimePicker1.Value, price, cmbAvailability.SelectedItem.ToString()) Then
            MessageBox.Show("Product updated successfully")
            LoadProductData()
            ClearFields()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please select a product from the grid to delete")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If DeleteProduct(txtName.Text) Then
                MessageBox.Show("Product deleted successfully")
                LoadProductData()
                ClearFields()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtName.Text = row.Cells("product_id").Value.ToString()
            cmbProductType.SelectedItem = row.Cells("product_type").Value.ToString()
            ' After setting ProductType, items in ProductName are cleared and refilled by SelectedIndexChanged event.
            ' We need to ensure the item is set correctly.
            cmbProductName.SelectedItem = row.Cells("product_name").Value.ToString()

            Guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells("expiry_date").Value)
            Guna2TextBox4.Text = row.Cells("price").Value.ToString()
            cmbAvailability.SelectedItem = row.Cells("availability").Value.ToString()

            txtName.Enabled = False ' Disable ID editing
            btnAdd.Text = "NEW"
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtName.Enabled = True
        cmbProductType.SelectedIndex = -1
        cmbProductName.Items.Clear()
        ' Repopulate default items if needed or just leave empty until Type is selected
        Guna2TextBox4.Clear()
        cmbAvailability.SelectedIndex = -1
        Guna2DateTimePicker1.Value = DateTime.Now
        btnAdd.Text = "ADD"
    End Sub
End Class