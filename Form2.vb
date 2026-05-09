Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUserName.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Dim resultTable As DataTable = ValidateUser(username, password)

        If resultTable.Rows.Count > 0 Then
            Dim row As DataRow = resultTable.Rows(0)
            Dim userRole As String = row("role").ToString()
            Dim userNameFromDb As String = row("username").ToString()

            If String.Equals(userRole, "Admin", StringComparison.OrdinalIgnoreCase) Then
                ' Open admin dashboard
                Dim adminDash As New frmadminDashBoard()
                adminDash.UserRole = userRole
                adminDash.UserName = userNameFromDb
                adminDash.Show()
                Me.Hide()
            Else
                ' Open user dashboard for any other valid role (e.g., "User")
                Dim userDash As New userDashBoard()
                userDash.UserRole = userRole
                userDash.UserName = userNameFromDb
                userDash.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
