Public Class frmAppointment
    Private Sub LoadData()
        Try
            DataGridView1.DataSource = GetAppointments()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Please enter customer name.")
            Return
        End If

        If InsertAppointment(txtCustomerName.Text, cmbType.Text, txtPhoneNumber.Text, dtpDate.Value.Date, txtTime.Text, txtEmployeeName.Text) Then
            MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        LoadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = If(row.Cells("appointment_id").Value IsNot DBNull.Value, row.Cells("appointment_id").Value.ToString(), "")
            txtCustomerName.Text = If(row.Cells("customer_name").Value IsNot DBNull.Value, row.Cells("customer_name").Value.ToString(), "")
            cmbType.Text = If(row.Cells("service_type").Value IsNot DBNull.Value, row.Cells("service_type").Value.ToString(), "")
            txtPhoneNumber.Text = If(row.Cells("phone_number").Value IsNot DBNull.Value, row.Cells("phone_number").Value.ToString(), "")
            If row.Cells("appointment_date").Value IsNot DBNull.Value Then
                dtpDate.Value = Convert.ToDateTime(row.Cells("appointment_date").Value)
            End If
            txtTime.Text = If(row.Cells("appointment_time").Value IsNot DBNull.Value, row.Cells("appointment_time").Value.ToString(), "")
            txtEmployeeName.Text = If(row.Cells("employee_name").Value IsNot DBNull.Value, row.Cells("employee_name").Value.ToString(), "")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Please select an appointment from the list to edit.")
            Return
        End If

        If UpdateAppointment(Convert.ToInt32(txtID.Text), txtCustomerName.Text, cmbType.Text, txtPhoneNumber.Text, dtpDate.Value.Date, txtTime.Text, txtEmployeeName.Text) Then
            MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Please select an appointment from the list to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If DeleteAppointment(Convert.ToInt32(txtID.Text)) Then
                MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtCustomerName.Clear()
        cmbType.SelectedIndex = -1
        txtPhoneNumber.Clear()
        dtpDate.Value = DateTime.Now
        txtTime.Clear()
        txtEmployeeName.Clear()
    End Sub
End Class
