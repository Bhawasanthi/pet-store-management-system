Imports MySql.Data.MySqlClient

﻿Public Class frmCustomer

    Private Sub LoadData()
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim query As String = "SELECT * FROM customers"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView1.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtContact.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("Please fill all details.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "INSERT INTO customers (customer_name, contact_number, address) VALUES (@name, @contact, @address)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text)
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Customer Added Successfully!")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.")
            Exit Sub
        End If

        Dim selectedID As String = DataGridView1.SelectedRows(0).Cells("customer_id").Value.ToString()

        ' If the loaded ID doesn't match selected row, load selected row's data
        If txtID.Text <> selectedID Then
            txtID.Text = selectedID
            txtName.Text = DataGridView1.SelectedRows(0).Cells("customer_name").Value.ToString()
            txtContact.Text = DataGridView1.SelectedRows(0).Cells("contact_number").Value.ToString()
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells("address").Value.ToString()
            MessageBox.Show("Details loaded into textboxes. Modify and click EDIT again to save changes.")
        Else
            ' Update database
            Try
                Using conn As MySqlConnection = GetConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim query As String = "UPDATE customers SET customer_name=@name, contact_number=@contact, address=@address WHERE customer_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", txtName.Text)
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text)
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@id", selectedID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Customer Updated Successfully!")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error updating customer: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim selectedID As String = DataGridView1.SelectedRows(0).Cells("customer_id").Value.ToString()
            Try
                Using conn As MySqlConnection = GetConnection()
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim query As String = "DELETE FROM customers WHERE customer_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", selectedID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Customer Deleted Successfully!")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting customer: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtName.Clear()
        txtContact.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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