Imports MySql.Data.MySqlClient

Module loginCRUD
    Public Function LoadUser() As DataTable
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT userid, username, password, role FROM users"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function

    Public Function ValidateUser(username As String, password As String) As DataTable
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                Dim query As String = "SELECT username, role FROM users WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End If
        End Using
        Return table
    End Function
End Module
