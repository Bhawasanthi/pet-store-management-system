Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class frmOrder

    Dim conn As MySqlConnection

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = dbConnection.GetConnection()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to database: " & ex.Message)
        End Try

        ' Setup DataGridView columns if not already setup
        If dgvCart.Columns.Count = 0 Then
            dgvCart.Columns.Add("ItemID", "Item ID")
            dgvCart.Columns.Add("ItemName", "Item Name")
            dgvCart.Columns.Add("Category", "Category")
            dgvCart.Columns.Add("UnitPrice", "Unit Price")
            dgvCart.Columns.Add("Qty", "Quantity")
            dgvCart.Columns.Add("Total", "Total")
        End If

        dtpOrderDate.Value = DateTime.Now
        txtOrderTime.Text = DateTime.Now.ToString("HH:mm:ss")
        GenerateBillNo()
    End Sub

    Private Sub GenerateBillNo()
        txtBillNo.Text = "BILL-" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim category As String = cmbCategory.Text
        Dim name As String = txtName.Text

        If String.IsNullOrEmpty(category) Then
            MessageBox.Show("Please select a category.")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = ""
            If category = "Pet" Then
                query = "SELECT PetID, name, Price, Status FROM pets WHERE name LIKE @name OR Type LIKE @name"
            ElseIf category = "Product" Then
                query = "SELECT product_id, product_name, price, availability FROM product WHERE product_name LIKE @name OR product_type LIKE @name"
            ElseIf category = "Service " Then
                query = "SELECT service_id, type, service_charge, availability FROM service WHERE type LIKE @name"
            End If

            If query <> "" Then
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", "%" & name & "%")
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            If category = "Pet" Then
                                txtUnitPrice.Text = dr("Price").ToString()
                                txtStatus.Text = dr("Status").ToString()
                                txtStock.Text = "1"
                                txtName.Text = dr("name").ToString()
                            ElseIf category = "Product" Then
                                txtUnitPrice.Text = dr("price").ToString()
                                txtStatus.Text = dr("availability").ToString()
                                txtStock.Text = "N/A"
                                txtName.Text = dr("product_name").ToString()
                            ElseIf category = "Service " Then
                                txtUnitPrice.Text = dr("service_charge").ToString()
                                txtStatus.Text = dr("availability").ToString()
                                txtStock.Text = "N/A"
                                txtName.Text = dr("type").ToString()
                            End If
                        Else
                            MessageBox.Show("Item not found.")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Search for this category is not implemented yet.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CalculateItemTotal()
    End Sub

    Private Sub CalculateItemTotal()
        Dim price As Decimal = 0
        Dim qty As Integer = 0
        If Decimal.TryParse(txtUnitPrice.Text, price) AndAlso Integer.TryParse(txtQty.Text, qty) Then
            txtTotalPrice.Text = (price * qty).ToString("F2")
        Else
            txtTotalPrice.Text = "0.00"
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If String.IsNullOrEmpty(txtUnitPrice.Text) OrElse String.IsNullOrEmpty(txtQty.Text) Then
            MessageBox.Show("Please search for an item and enter quantity.")
            Return
        End If

        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If
        dgvCart.Rows.Add(txtName.Text, txtName.Text, cmbCategory.Text, txtUnitPrice.Text, txtQty.Text, txtTotalPrice.Text)
        CalculateGrandTotal()
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtName.Clear()
        txtUnitPrice.Clear()
        txtQty.Clear()
        txtTotalPrice.Clear()
        txtStock.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub CalculateGrandTotal()
        Dim grandTotal As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                Dim val As Decimal
                If Decimal.TryParse(row.Cells("Total").Value.ToString(), val) Then
                    grandTotal += val
                End If
            End If
        Next
        txtGrandTotal.Text = grandTotal.ToString("F2")
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If dgvCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty.")
            Return
        End If

        If String.IsNullOrEmpty(txtCustomerName.Text) Then
            MessageBox.Show("Please enter customer name.")
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Using transaction = conn.BeginTransaction()
                Try
                    ' Insert into orders
                    Dim orderQuery As String = "INSERT INTO orders (bill_no, customer_name, order_date, order_time, total_amount, status) VALUES (@bill, @cust, @date, @time, @total, @status)"
                    Dim orderId As Integer
                    Using cmd As New MySqlCommand(orderQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@bill", txtBillNo.Text)
                        cmd.Parameters.AddWithValue("@cust", txtCustomerName.Text)
                        cmd.Parameters.AddWithValue("@date", dtpOrderDate.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@time", txtOrderTime.Text)
                        cmd.Parameters.AddWithValue("@total", Decimal.Parse(txtGrandTotal.Text))
                        cmd.Parameters.AddWithValue("@status", "Completed")
                        cmd.ExecuteNonQuery()
                        orderId = CInt(cmd.LastInsertedId)
                    End Using

                    ' Insert into order_items
                    For Each row As DataGridViewRow In dgvCart.Rows
                        If Not row.IsNewRow Then
                            Dim itemQuery As String = "INSERT INTO order_items (order_id, item_name, category, unit_price, quantity, total_price) VALUES (@orderid, @name, @cat, @price, @qty, @total)"
                            Using cmdItem As New MySqlCommand(itemQuery, conn, transaction)
                                cmdItem.Parameters.AddWithValue("@orderid", orderId)
                                cmdItem.Parameters.AddWithValue("@name", row.Cells("ItemName").Value)
                                cmdItem.Parameters.AddWithValue("@cat", row.Cells("Category").Value)
                                cmdItem.Parameters.AddWithValue("@price", Decimal.Parse(row.Cells("UnitPrice").Value))
                                cmdItem.Parameters.AddWithValue("@qty", Integer.Parse(row.Cells("Qty").Value))
                                cmdItem.Parameters.AddWithValue("@total", Decimal.Parse(row.Cells("Total").Value))
                                cmdItem.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    transaction.Commit()
                    MessageBox.Show("Order placed successfully! Bill No: " & txtBillNo.Text)
                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error placing order: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Receipt Printing
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        Try
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf PrintReceiptPage
            Dim ppd As New PrintPreviewDialog()
            ppd.Document = pd
            ppd.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Printing error: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintReceiptPage(sender As Object, e As PrintPageEventArgs)
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim f10 As New Font("Arial", 10, FontStyle.Regular)
        Dim f10b As New Font("Arial", 10, FontStyle.Bold)
        Dim f14b As New Font("Arial", 14, FontStyle.Bold)

        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim y As Integer = topMargin

        e.Graphics.DrawString("PET STORE MANAGEMENT SYSTEM", f14b, Brushes.Black, leftMargin, y)
        y += 35
        e.Graphics.DrawString("Order Receipt", f10b, Brushes.Black, leftMargin, y)
        y += 25
        e.Graphics.DrawLine(Pens.Black, leftMargin, y, e.MarginBounds.Right, y)
        y += 10
        e.Graphics.DrawString("Bill No: " & txtBillNo.Text, f10, Brushes.Black, leftMargin, y)
        y += 20
        e.Graphics.DrawString("Customer: " & txtCustomerName.Text, f10, Brushes.Black, leftMargin, y)
        y += 20
        e.Graphics.DrawString("Date: " & dtpOrderDate.Value.ToString("dd-MM-yyyy") & " " & txtOrderTime.Text, f10, Brushes.Black, leftMargin, y)
        y += 35

        e.Graphics.DrawString("Item", f10b, Brushes.Black, leftMargin, y)
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, leftMargin + 200, y)
        e.Graphics.DrawString("Price", f10b, Brushes.Black, leftMargin + 260, y)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, leftMargin + 360, y)
        y += 25
        e.Graphics.DrawLine(Pens.Black, leftMargin, y, e.MarginBounds.Right, y)
        y += 10

        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                e.Graphics.DrawString(row.Cells("ItemName").Value.ToString(), f10, Brushes.Black, leftMargin, y)
                e.Graphics.DrawString(row.Cells("Qty").Value.ToString(), f10, Brushes.Black, leftMargin + 200, y)
                e.Graphics.DrawString(row.Cells("UnitPrice").Value.ToString(), f10, Brushes.Black, leftMargin + 260, y)
                e.Graphics.DrawString(row.Cells("Total").Value.ToString(), f10, Brushes.Black, leftMargin + 360, y)
                y += 20
            End If
        Next

        y += 15
        e.Graphics.DrawLine(Pens.Black, leftMargin, y, e.MarginBounds.Right, y)
        y += 10
        e.Graphics.DrawString("Grand Total: " & txtGrandTotal.Text, f14b, Brushes.Black, leftMargin + 250, y)
        y += 60
        e.Graphics.DrawString("--- Thank you for shopping with us! ---", f10, Brushes.Black, leftMargin + 50, y)
    End Sub


End Class