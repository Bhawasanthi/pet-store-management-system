Imports MySql.Data.MySqlClient

Module dbConnection

    Private ReadOnly connString As String = "Server=localhost;Database=psms;User Id=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn IsNot Nothing Then
                If conn.State <> ConnectionState.Closed Then conn.Close()
                conn.Dispose()
            End If
            Return Nothing
        End Try
    End Function

    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                Return conn IsNot Nothing AndAlso conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
