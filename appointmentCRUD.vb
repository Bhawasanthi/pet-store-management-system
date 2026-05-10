Imports System.Data
Imports MySql.Data.MySqlClient

Module appointmentCRUD
    Public Function GetAppointments() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return dt
            ' Connection is opened in GetConnection based on dbConnection.vb
            Dim query As String = "SELECT appointment_id, customer_name, service_type, phone_number, appointment_date, appointment_time, employee_name FROM appointment"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function AddAppointment(customerName As String, serviceType As String, phoneNumber As String, appDate As DateTime, appTime As String, employeeName As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return False
            Dim query As String = "INSERT INTO appointment (customer_name, service_type, phone_number, appointment_date, appointment_time, employee_name) " &
                                 "VALUES (@customerName, @serviceType, @phoneNumber, @appDate, @appTime, @employeeName)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@customerName", customerName)
                cmd.Parameters.AddWithValue("@serviceType", serviceType)
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@appDate", appDate)
                cmd.Parameters.AddWithValue("@appTime", appTime)
                cmd.Parameters.AddWithValue("@employeeName", employeeName)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateAppointment(id As Integer, customerName As String, serviceType As String, phoneNumber As String, appDate As DateTime, appTime As String, employeeName As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return False
            Dim query As String = "UPDATE appointment SET customer_name=@customerName, service_type=@serviceType, phone_number=@phoneNumber, " &
                                 "appointment_date=@appDate, appointment_time=@appTime, employee_name=@employeeName WHERE appointment_id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@customerName", customerName)
                cmd.Parameters.AddWithValue("@serviceType", serviceType)
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@appDate", appDate)
                cmd.Parameters.AddWithValue("@appTime", appTime)
                cmd.Parameters.AddWithValue("@employeeName", employeeName)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DeleteAppointment(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return False
            Dim query As String = "DELETE FROM appointment WHERE appointment_id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Module
