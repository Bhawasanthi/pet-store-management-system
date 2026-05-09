Imports MySql.Data.MySqlClient

Module productCRUD
    Public Function LoadProducts() As DataTable
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT product_id, product_type, product_name, expiry_date, price, availability FROM product"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function
End Module
