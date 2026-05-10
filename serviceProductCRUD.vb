Imports MySql.Data.MySqlClient

Module serviceProductCRUD
    Public Function LoadServiceProducts() As DataTable
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    Dim query As String = "SELECT * FROM service_product"
                    Using cmd As New MySqlCommand(query, conn)
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(table)
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading service products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return table
    End Function

    Public Function AddServiceProduct(type As String, name As String, stock As Integer, expiry As DateTime) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    Dim query As String = "INSERT INTO service_product (service_type, product_name, unit_in_stock, expiry_date) VALUES (@type, @name, @stock, @expiry)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@stock", stock)
                        cmd.Parameters.AddWithValue("@expiry", expiry)
                        cmd.ExecuteNonQuery()
                        Return True
                    End Using
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function UpdateServiceProduct(id As Integer, type As String, name As String, stock As Integer, expiry As DateTime) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    Dim query As String = "UPDATE service_product SET service_type=@type, product_name=@name, unit_in_stock=@stock, expiry_date=@expiry WHERE service_product_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@stock", stock)
                        cmd.Parameters.AddWithValue("@expiry", expiry)
                        cmd.ExecuteNonQuery()
                        Return True
                    End Using
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function DeleteServiceProduct(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    Dim query As String = "DELETE FROM service_product WHERE service_product_id=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                        Return True
                    End Using
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Module
