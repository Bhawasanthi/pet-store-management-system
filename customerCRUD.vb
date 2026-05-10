Imports MySql.Data.MySqlClient

Module customerCRUD
    Public Function LoadCustomers() As DataTable
        Dim table As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT customer_id, customer_name, contact_number, address FROM customers"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function
End Module
