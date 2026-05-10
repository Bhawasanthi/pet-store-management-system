Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmService
    Private Sub LoadData()
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "SELECT * FROM service"
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

    Private Sub ClearFields()
        txtID.Clear()
        cmbType.SelectedIndex = -1
        txtCharge.Clear()
        cmbAvailability.SelectedIndex = -1
        txtEmployeeName.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "NEW" Then
            ClearFields()
            btnAdd.Text = "ADD"
            Return
        End If

        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "INSERT INTO service (type, service_charge, availability, employee_name) VALUES (@type, @charge, @availability, @employee)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@type", cmbType.Text)
                    cmd.Parameters.AddWithValue("@charge", txtCharge.Text)
                    cmd.Parameters.AddWithValue("@availability", cmbAvailability.Text)
                    cmd.Parameters.AddWithValue("@employee", txtEmployeeName.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Service added successfully!")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding service: " & ex.Message)
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a record to edit.")
            Return
        End If

        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "UPDATE service SET type=@type, service_charge=@charge, availability=@availability, employee_name=@employee WHERE service_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@type", cmbType.Text)
                    cmd.Parameters.AddWithValue("@charge", txtCharge.Text)
                    cmd.Parameters.AddWithValue("@availability", cmbAvailability.Text)
                    cmd.Parameters.AddWithValue("@employee", txtEmployeeName.Text)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Service updated successfully!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error updating service: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = dbConnection.GetConnection()
                    If conn.State <> ConnectionState.Open Then conn.Open()
                    Dim query As String = "DELETE FROM service WHERE service_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", txtID.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Service deleted successfully!")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting service: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells("service_id").Value.ToString()
            cmbType.Text = row.Cells("type").Value.ToString()
            txtCharge.Text = row.Cells("service_charge").Value.ToString()
            cmbAvailability.Text = row.Cells("availability").Value.ToString()
            txtEmployeeName.Text = row.Cells("employee_name").Value.ToString()
            btnAdd.Text = "NEW"
        End If
    End Sub

    Private Sub frmService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.ReadOnly = True
        LoadData()
    End Sub
End Class
