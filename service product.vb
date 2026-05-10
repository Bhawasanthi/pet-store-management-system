Imports MySql.Data.MySqlClient

Public Class frmServiceProduct
    Private Sub LoadData()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT * FROM service_product"
                    Using cmd As New MySqlCommand(query, conn)
                        Using adapter As New MySqlDataAdapter(cmd)
                            Dim table As New DataTable()
                            adapter.Fill(table)
                            dgvServiceProduct.DataSource = table
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        LoadData()
    End Sub

    Private Sub frmServiceProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Guna2TextBox1.ReadOnly = True
        dgvServiceProduct.ReadOnly = True
        dgvServiceProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If cmbType.SelectedIndex = -1 Or Guna2ComboBox1.SelectedIndex = -1 Or Guna2TextBox5.Text = "" Or Guna2TextBox4.Text = "" Then
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "INSERT INTO service_product (service_type, product_name, unit_in_stock, expiry_date) VALUES (@type, @name, @stock, @expiry)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@name", Guna2ComboBox1.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@stock", Guna2TextBox5.Text)
                        cmd.Parameters.AddWithValue("@expiry", Guna2TextBox4.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData()
                        ClearFields()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If Guna2TextBox1.Text = "" Then
                MessageBox.Show("Please select a record from the grid view to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If cmbType.SelectedIndex = -1 Or Guna2ComboBox1.SelectedIndex = -1 Or Guna2TextBox5.Text = "" Or Guna2TextBox4.Text = "" Then
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "UPDATE service_product SET service_type=@type, product_name=@name, unit_in_stock=@stock, expiry_date=@expiry WHERE service_product_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@name", Guna2ComboBox1.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@stock", Guna2TextBox5.Text)
                        cmd.Parameters.AddWithValue("@expiry", Guna2TextBox4.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData()
                        ClearFields()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If Guna2TextBox1.Text = "" Then
                MessageBox.Show("Please select a record from the grid view to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using conn As MySqlConnection = GetConnection()
                    If conn IsNot Nothing Then
                        Dim query As String = "DELETE FROM service_product WHERE service_product_id=@id"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadData()
                            ClearFields()
                        End Using
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvServiceProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceProduct.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvServiceProduct.Rows(e.RowIndex)
            Guna2TextBox1.Text = If(IsDBNull(row.Cells("service_product_id").Value), "", row.Cells("service_product_id").Value.ToString())
            cmbType.SelectedItem = If(IsDBNull(row.Cells("service_type").Value), Nothing, row.Cells("service_type").Value.ToString())
            Guna2ComboBox1.SelectedItem = If(IsDBNull(row.Cells("product_name").Value), Nothing, row.Cells("product_name").Value.ToString())
            Guna2TextBox5.Text = If(IsDBNull(row.Cells("unit_in_stock").Value), "", row.Cells("unit_in_stock").Value.ToString())

            If Not IsDBNull(row.Cells("expiry_date").Value) Then
                Guna2TextBox4.Text = Convert.ToDateTime(row.Cells("expiry_date").Value).ToString("yyyy-MM-dd")
            Else
                Guna2TextBox4.Text = ""
            End If
        End If
    End Sub

    Private Sub ClearFields()
        Guna2TextBox1.Clear()
        cmbType.SelectedIndex = -1
        Guna2ComboBox1.SelectedIndex = -1
        Guna2TextBox5.Clear()
        Guna2TextBox4.Clear()
    End Sub
End Class
