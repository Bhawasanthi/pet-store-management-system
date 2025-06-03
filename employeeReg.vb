Imports System.IO
Imports System.Transactions
Imports MySql.Data.MySqlClient


Public Class employeeReg
    Dim con As New MySqlConnection("Server=localhost;Database=psms;User Id=root;Password=;")

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        txtimage_path.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        pictureBox.Image = Image.FromFile(txtimage_path.Text)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            con.Open()
            Dim transaction As MySqlTransaction = con.BeginTransaction()

            ' Insert into employee table
            Dim empCmd As New MySqlCommand("INSERT INTO employee (full_name, contact_number, email, gender, date_of_birth, position, salary, date_of_hired, image) VALUES (@fullname, @contact_number, @email, @gender, @date_of_birth, @position, @salary, @date_of_hired, @image)", con, transaction)


            empCmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            empCmd.Parameters.AddWithValue("@contact_number", txtContactNumber.Text)
            empCmd.Parameters.AddWithValue("@email", txtEmail.Text)
            empCmd.Parameters.AddWithValue("@position", txtPosition.Text)
            empCmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text))
            empCmd.Parameters.AddWithValue("@date_of_birth", dtpDOB.Value.Date)
            empCmd.Parameters.AddWithValue("@date_of_hired", dtpDateHired.Value.Date)


            Dim gender As String = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))
            If gender = "" Then
                MessageBox.Show("Please select a gender.")
                Exit Sub
            End If
            empCmd.Parameters.AddWithValue("@gender", gender)


            ' Convert image to byte array
            Dim ms As New MemoryStream()
            If pictureBox.Image Is Nothing Then
                MessageBox.Show("Please select an image.")
                Exit Sub
            End If
            empCmd.Parameters.AddWithValue("@image", ms.ToArray())

            empCmd.ExecuteNonQuery()

            ' Get the last inserted employee ID

            Dim employeeId As Long = empCmd.LastInsertedId
            If empCmd.LastInsertedId = 0 Then
                MessageBox.Show("Failed to retrieve employee ID. Ensure 'employee_id' is AUTO_INCREMENT.")
                transaction.Rollback()
                Exit Sub
            End If




            ' Insert into users table
            Dim userCmd As New MySqlCommand("INSERT INTO users (username, password, employee_id) VALUES (@Username, @Password, @EmployeeID)", con, transaction)
            userCmd.Parameters.AddWithValue("@Username", txtUserName.Text)
            userCmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            userCmd.Parameters.AddWithValue("@EmployeeID", employeeId)

            userCmd.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFullName.Clear()
        txtUserName.Clear()
        txtPassword.Clear()
        txtContactNumber.Clear()
        txtEmail.Clear()
        txtPosition.Clear()
        txtSalary.Clear()
        dtpDOB.Value = DateTime.Now
        dtpDateHired.Value = DateTime.Now
        pictureBox.Image = Nothing
    End Sub


End Class