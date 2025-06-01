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
End Module
