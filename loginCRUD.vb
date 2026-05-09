Imports MySql.Data.MySqlClient
Module loginCRUD
    Public Function LoadUser() As DataTable 'Returns a value thats why not sub, but function
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "SELECT userid, username, password, role FROM users"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
            'conn.Close()
        End Using
        Return table

    End Function

    Public Function LoadEmployee() As DataTable
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT employee_id, userName, password FROM employee"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table

    End Function
End Module
