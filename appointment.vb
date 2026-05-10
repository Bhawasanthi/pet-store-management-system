Public Class frmAppointment
    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        DataGridView1.DataSource = GetAppointments()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInput() Then
            If AddAppointment(txtCustomerName.Text, cmbType.Text, txtPhoneNumber.Text, dtpDate.Value, txtTime.Text, txtEmployeeName.Text) Then
                MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Else
                MessageBox.Show("Failed to add appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select an appointment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateInput() Then
            If UpdateAppointment(Convert.ToInt32(txtID.Text), txtCustomerName.Text, cmbType.Text, txtPhoneNumber.Text, dtpDate.Value, txtTime.Text, txtEmployeeName.Text) Then
                MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Else
                MessageBox.Show("Failed to update appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select an appointment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If DeleteAppointment(Convert.ToInt32(txtID.Text)) Then
                MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Else
                MessageBox.Show("Failed to delete appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells("appointment_id").Value.ToString()
            txtCustomerName.Text = row.Cells("customer_name").Value.ToString()
            cmbType.Text = row.Cells("service_type").Value.ToString()
            txtPhoneNumber.Text = row.Cells("phone_number").Value.ToString()
            dtpDate.Value = Convert.ToDateTime(row.Cells("appointment_date").Value)
            txtTime.Text = row.Cells("appointment_time").Value.ToString()
            txtEmployeeName.Text = row.Cells("employee_name").Value.ToString()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) OrElse
           String.IsNullOrWhiteSpace(cmbType.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhoneNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtTime.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmployeeName.Text) Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

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
