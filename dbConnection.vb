Imports MySql.Data.MySqlClient

Module dbConnection

    Private ReadOnly connString As String = "Server=localhost;Database=psms;User Id=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            'MessageBox.Show("Connectiion Successfull!")
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function

    Public Function TestConnection() As Boolean
        Using conn As MySqlConnection = GetConnection()
            Try
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function GetNextID(tableName As String) As Integer
        Dim nextID As Integer = 1
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.TABLES " &
                                         "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @tableName"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@tableName", tableName)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                            nextID = Convert.ToInt32(result)
                        End If
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Fallback to 1 if there's an error
            nextID = 1
        End Try
        Return nextID
    End Function
End Module
