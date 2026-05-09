Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'TestConnection()
        Dim usersTable As DataTable = LoadUser()

        ' Check users table for Admin login
        For Each row As DataRow In usersTable.Rows
            If row("username").ToString() = txtUserName.Text.Trim() AndAlso
               row("password").ToString() = txtPassword.Text.Trim() Then

                ' Redirect to adminDashBoard
                Dim adminDashBoard As New frmadminDashBoard()
                adminDashBoard.UserRole = row("role").ToString()
                adminDashBoard.UserName = row("username").ToString()
                adminDashBoard.Show()
                Me.Hide()
                Return
            End If
        Next

        ' If not found in users table, check employee table for User login
        Dim employeeTable As DataTable = LoadEmployee()
        For Each row As DataRow In employeeTable.Rows
            If row("userName").ToString() = txtUserName.Text.Trim() AndAlso
               row("password").ToString() = txtPassword.Text.Trim() Then

                ' Redirect to userDashBoard
                Dim dashboard As New userDashBoard()
                dashboard.UserRole = "User"
                dashboard.UserName = row("userName").ToString()
                dashboard.Show()
                Me.Hide()
                Return
            End If
        Next

        ' If no match in both tables
        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class