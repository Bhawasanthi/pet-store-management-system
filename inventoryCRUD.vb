Imports MySql.Data.MySqlClient

Module inventoryCRUD
    Public Function LoadInventory() As DataTable
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT * FROM inventory"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function
End Module
