Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Module petCRUD
    Public Function GetPets() As DataTable
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim query As String = "SELECT * FROM pets"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return table
    End Function
End Module
