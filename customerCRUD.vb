Imports MySql.Data.MySqlClient

Module customerCRUD
    Public Function LoadCustomers() As DataTable
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT * FROM customers"
                    Using cmd As New MySqlCommand(query, conn)
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(table)
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Error handled by GetConnection or caller
        End Try
        Return table
    End Function

    Public Function GetNextCustomerID() As Integer
        Dim nextID As Integer = 1
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    If conn.State <> ConnectionState.Open Then conn.Open()
                    ' Using DATABASE() to get current db name instead of hardcoding 'psms'
                    Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_NAME = 'customers' AND TABLE_SCHEMA = DATABASE()"
                    Using cmd As New MySqlCommand(query, conn)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                            nextID = Convert.ToInt32(result)
                        End If
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Fallback to 1 or log error
        End Try
        Return nextID
    End Function

    Public Sub AddCustomer(name As String, contact As String, address As String)
        Using conn As MySqlConnection = GetConnection()
            If conn IsNot Nothing Then
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "INSERT INTO customers (customer_name, contact_number, address) VALUES (@name, @contact, @address)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Public Sub UpdateCustomer(id As Integer, name As String, contact As String, address As String)
        Using conn As MySqlConnection = GetConnection()
            If conn IsNot Nothing Then
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "UPDATE customers SET customer_name=@name, contact_number=@contact, address=@address WHERE customer_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Public Sub DeleteCustomer(id As Integer)
        Using conn As MySqlConnection = GetConnection()
            If conn IsNot Nothing Then
                if conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "DELETE FROM customers WHERE customer_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub
End Module
