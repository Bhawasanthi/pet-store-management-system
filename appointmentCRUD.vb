Imports MySql.Data.MySqlClient

Module appointmentCRUD
    Public Function GetAppointments() As DataTable
        Dim table As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT * FROM appointment"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using
        Return table
    End Function

    Public Function InsertAppointment(customerName As String, serviceType As String, phoneNumber As String, appointmentDate As Date, appointmentTime As String, employeeName As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim query As String = "INSERT INTO appointment (customer_name, service_type, phone_number, appointment_date, appointment_time, employee_name) VALUES (@customerName, @serviceType, @phoneNumber, @appointmentDate, @appointmentTime, @employeeName)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@customerName", customerName)
                    cmd.Parameters.AddWithValue("@serviceType", serviceType)
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                    cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate)
                    cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime)
                    cmd.Parameters.AddWithValue("@employeeName", employeeName)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting appointment: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateAppointment(id As Integer, customerName As String, serviceType As String, phoneNumber As String, appointmentDate As Date, appointmentTime As String, employeeName As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim query As String = "UPDATE appointment SET customer_name=@customerName, service_type=@serviceType, phone_number=@phoneNumber, appointment_date=@appointmentDate, appointment_time=@appointmentTime, employee_name=@employeeName WHERE appointment_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@customerName", customerName)
                    cmd.Parameters.AddWithValue("@serviceType", serviceType)
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                    cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate)
                    cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime)
                    cmd.Parameters.AddWithValue("@employeeName", employeeName)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating appointment: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteAppointment(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                Dim query As String = "DELETE FROM appointment WHERE appointment_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting appointment: " & ex.Message)
            Return False
        End Try
    End Function
End Module
