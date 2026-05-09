Imports System.IO
Imports System.Transactions
Imports MySql.Data.MySqlClient


Public Class frmemployeeReg
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtimage_path.Text = OpenFileDialog1.FileName
            pictureBox.Image = Image.FromFile(txtimage_path.Text)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Using con As MySqlConnection = GetConnection()
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                Dim transaction As MySqlTransaction = con.BeginTransaction()
                Try
                    ' Insert into employee table
                    Dim empQuery As String = "INSERT INTO employee (full_name, contact_number, email, gender, date_of_birth, position, salary, date_of_hired, image) VALUES (@fullname, @contact_number, @email, @gender, @date_of_birth, @position, @salary, @date_of_hired, @image)"
                    Using empCmd As New MySqlCommand(empQuery, con, transaction)
                        empCmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim())
                        empCmd.Parameters.AddWithValue("@contact_number", txtContactNumber.Text.Trim())
                        empCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                        empCmd.Parameters.AddWithValue("@position", txtPosition.Text.Trim())
                        empCmd.Parameters.AddWithValue("@salary", If(IsNumeric(txtSalary.Text), Convert.ToDecimal(txtSalary.Text), 0))
                        empCmd.Parameters.AddWithValue("@date_of_birth", dtpDOB.Value.Date)
                        empCmd.Parameters.AddWithValue("@date_of_hired", dtpDateHired.Value.Date)

                        Dim gender As String = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))
                        If gender = "" Then
                            MessageBox.Show("Please select a gender.")
                            Return
                        End If
                        empCmd.Parameters.AddWithValue("@gender", gender)

                        ' Convert image to byte array correctly
                        If pictureBox.Image Is Nothing Then
                            MessageBox.Show("Please select an image.")
                            Return
                        End If
                        Using ms As New MemoryStream()
                            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat)
                            empCmd.Parameters.AddWithValue("@image", ms.ToArray())
                        End Using

                        empCmd.ExecuteNonQuery()

                        ' Get the last inserted employee ID
                        Dim employeeId As Long = empCmd.LastInsertedId

                        ' Insert into users table including the role and required fields from schema
                        ' Based on psms.sql: sqes, answer, changeDate_Time, oldPassword are NOT NULL
                        Dim userQuery As String = "INSERT INTO users (username, password, role, employee_id, sqes, answer, changeDate_Time, oldPassword) " &
                                                  "VALUES (@Username, @Password, @Role, @EmployeeID, @sqes, @answer, @changeDate_Time, @oldPassword)"
                        Using userCmd As New MySqlCommand(userQuery, con, transaction)
                            userCmd.Parameters.AddWithValue("@Username", txtUserName.Text.Trim())
                            userCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                            userCmd.Parameters.AddWithValue("@Role", txtPosition.Text.Trim())
                            userCmd.Parameters.AddWithValue("@EmployeeID", employeeId)
                            ' Provide default values for other NOT NULL columns if not in UI
                            userCmd.Parameters.AddWithValue("@sqes", "")
                            userCmd.Parameters.AddWithValue("@answer", "")
                            userCmd.Parameters.AddWithValue("@changeDate_Time", DateTime.Now.ToString())
                            userCmd.Parameters.AddWithValue("@oldPassword", txtPassword.Text.Trim())

                            userCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    If transaction IsNot Nothing Then transaction.Rollback()
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
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
