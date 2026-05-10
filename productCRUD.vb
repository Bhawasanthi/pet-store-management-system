Imports MySql.Data.MySqlClient

Module productCRUD
    Public Function GetProducts() As DataTable
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn Is Nothing Then Return table
                Dim query As String = "SELECT * FROM product"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
        Return table
    End Function

    Public Function AddProduct(id As String, type As String, name As String, expiry As DateTime, price As Decimal, availability As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn Is Nothing Then Return False
                Dim query As String = "INSERT INTO product (product_id, product_type, product_name, expiry_date, price, availability) VALUES (@id, @type, @name, @expiry, @price, @availability)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@type", type)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@expiry", expiry)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@availability", availability)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateProduct(id As String, type As String, name As String, expiry As DateTime, price As Decimal, availability As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn Is Nothing Then Return False
                Dim query As String = "UPDATE product SET product_type=@type, product_name=@name, expiry_date=@expiry, price=@price, availability=@availability WHERE product_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@type", type)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@expiry", expiry)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@availability", availability)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteProduct(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn Is Nothing Then Return False
                Dim query As String = "DELETE FROM product WHERE product_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message)
            Return False
        End Try
    End Function
End Module
