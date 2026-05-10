Imports MySql.Data.MySqlClient
Imports System.Data

Module serviceCRUD
    Public Function LoadServices() As DataTable
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "SELECT * FROM service"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return table
    End Function

    Public Function AddService(type As String, charge As Decimal, availability As String, employee As String) As Boolean
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "INSERT INTO service (type, service_charge, availability, employee_name) VALUES (@type, @charge, @availability, @employee)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@type", type)
                    cmd.Parameters.AddWithValue("@charge", charge)
                    cmd.Parameters.AddWithValue("@availability", availability)
                    cmd.Parameters.AddWithValue("@employee", employee)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateService(id As Integer, type As String, charge As Decimal, availability As String, employee As String) As Boolean
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "UPDATE service SET type=@type, service_charge=@charge, availability=@availability, employee_name=@employee WHERE service_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@type", type)
                    cmd.Parameters.AddWithValue("@charge", charge)
                    cmd.Parameters.AddWithValue("@availability", availability)
                    cmd.Parameters.AddWithValue("@employee", employee)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteService(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim query As String = "DELETE FROM service WHERE service_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module
