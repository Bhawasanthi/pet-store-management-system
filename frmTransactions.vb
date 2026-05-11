Imports MySql.Data.MySqlClient

Public Class frmTransactions

    Private Sub LoadTransactions(query As String, params As MySqlParameter())
        Dim table As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params)
                    End If
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using

            dgvTransactions.DataSource = table
            CalculateTotal(table)
        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateTotal(table As DataTable)
        Dim total As Decimal = 0
        For Each row As DataRow In table.Rows
            If Not IsDBNull(row("amount")) Then
                total += Convert.ToDecimal(row("amount"))
            End If
        Next
        lblTotalRevenue.Text = total.ToString("N2")
    End Sub

    Private Sub btnDay_Click(sender As Object, e As EventArgs) Handles btnDay.Click
        Dim selectedDate As Date = dtpReferenceDate.Value.Date
        Dim query As String = "SELECT transaction_id, customer_name, amount, transaction_date, transaction_time, type FROM transactions WHERE transaction_date = @tDate"
        Dim params As MySqlParameter() = {New MySqlParameter("@tDate", selectedDate)}
        LoadTransactions(query, params)
    End Sub

    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        Dim selectedDate As Date = dtpReferenceDate.Value.Date
        Dim diff As Integer = (selectedDate.DayOfWeek - DayOfWeek.Monday + 7) Mod 7
        Dim startOfWeek As Date = selectedDate.AddDays(-1 * diff)
        Dim endOfWeek As Date = startOfWeek.AddDays(6)

        Dim query As String = "SELECT transaction_id, customer_name, amount, transaction_date, transaction_time, type FROM transactions WHERE transaction_date BETWEEN @start AND @end"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@start", startOfWeek),
            New MySqlParameter("@end", endOfWeek)
        }
        LoadTransactions(query, params)
    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        Dim selectedDate As Date = dtpReferenceDate.Value.Date
        Dim query As String = "SELECT transaction_id, customer_name, amount, transaction_date, transaction_time, type FROM transactions WHERE MONTH(transaction_date) = @month AND YEAR(transaction_date) = @year"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@month", selectedDate.Month),
            New MySqlParameter("@year", selectedDate.Year)
        }
        LoadTransactions(query, params)
    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        Dim selectedDate As Date = dtpReferenceDate.Value.Date
        Dim query As String = "SELECT transaction_id, customer_name, amount, transaction_date, transaction_time, type FROM transactions WHERE YEAR(transaction_date) = @year"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@year", selectedDate.Year)
        }
        LoadTransactions(query, params)
    End Sub

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDay.PerformClick()
    End Sub
End Class
