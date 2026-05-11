Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'TestConnection()
        Dim usersTable As DataTable = LoadUser()

        Dim userRole As String = ""
        Dim userName As String = ""

        For Each row As DataRow In usersTable.Rows
            If row("username").ToString() = txtUserName.Text.Trim() AndAlso
               row("password").ToString() = txtPassword.Text.Trim() Then

                userRole = row("role").ToString()
                userName = row("username").ToString()

                Exit For
            End If
        Next

        If userRole = "Admin" Then



            ' Open dashboard and pass role if needed
            Dim adminDashBoard As New frmadminDashBoard()
            adminDashBoard.UserRole = userRole ' This should be a public property in frmDashboard
            adminDashBoard.UserName = userName ' Optional
            adminDashBoard.Show()
            Me.Hide()
        ElseIf userRole = "User" Then



            ' Open dashboard and pass role if needed
            Dim dashboard As New UserDashboard()
            dashboard.UserRole = userRole ' This should be a public property in frmDashboard
            dashboard.UserName = userName ' Optional
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class