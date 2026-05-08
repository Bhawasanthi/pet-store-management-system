Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'TestConnection()
        Dim employeeTable As DataTable = LoadEmployee()

        Dim userRole As String = ""
        Dim userName As String = ""

        For Each row As DataRow In employeeTable.Rows
            If row("userName").ToString() = txtUserName.Text.Trim() AndAlso
               row("password").ToString() = txtPassword.Text.Trim() Then

                userRole = row("position").ToString()
                userName = row("userName").ToString()

                Exit For
            End If
        Next

        If userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            ' Open dashboard and pass role if needed
            Dim adminDashBoard As New frmadminDashBoard()
            adminDashBoard.UserRole = userRole
            adminDashBoard.UserName = userName
            adminDashBoard.Show()
            Me.Hide()
        ElseIf Not String.IsNullOrEmpty(userRole) Then
            ' Open user dashboard for other roles (e.g., cashier)
            Dim dashboard As New userDashBoard()
            dashboard.UserRole = userRole
            dashboard.UserName = userName
            dashboard.Show()
            Me.Hide()
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