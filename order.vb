Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmOrder
    Private WithEvents printDoc As New PrintDocument()

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupCartGrid()
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        ' Generate Bill No
        txtBillNo.Text = "BILL" & DateTime.Now.ToString("yyyyMMddHHmmss")
        txtBillNo.ReadOnly = True

        ' Set Date and Time
        dtpDate.Value = DateTime.Now
        txtTime.Text = DateTime.Now.ToString("HH:mm:ss")
        txtTime.ReadOnly = True

        ' Fetch Last Customer ID
        FetchLastCustomerID()

        ' Clear item fields
        ClearItemFields()

        txtTotalAmount.ReadOnly = True
        txtUnitPrice.ReadOnly = True
    End Sub

    Private Sub FetchLastCustomerID()
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT MAX(customer_id) FROM customers"
                    Using cmd As New MySqlCommand(query, conn)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                            txtCustomerID.Text = result.ToString()
                        Else
                            txtCustomerID.Text = "N/A"
                        End If
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching customer ID: " & ex.Message)
        End Try
        txtCustomerID.ReadOnly = True
    End Sub

    Private Sub SetupCartGrid()
        dgvCart.Columns.Clear()
        dgvCart.Columns.Add("BillNo", "Bill No")
        dgvCart.Columns.Add("Date", "Date")
        dgvCart.Columns.Add("Time", "Time")
        dgvCart.Columns.Add("CustomerID", "Customer ID")
        dgvCart.Columns.Add("Category", "Category")
        dgvCart.Columns.Add("ItemName", "Item Name")
        dgvCart.Columns.Add("UnitPrice", "Unit Price")
        dgvCart.Columns.Add("Quantity", "Quantity")
        dgvCart.Columns.Add("TotalAmount", "Total Amount")
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        cmbName.Items.Clear()
        txtUnitPrice.Clear()
        txtQuantity.Clear()
        txtTotalAmount.Clear()

        If cmbCategory.SelectedItem IsNot Nothing Then
            Dim category As String = cmbCategory.SelectedItem.ToString()
            If category = "Product" Then
                cmbName.Items.AddRange(New String() {"Dog Food", "Cat Food", "Ball", "Squeaky Toy", "Chew Toy", "Scratching"})
            ElseIf category = "Service" Then
                cmbName.Items.AddRange(New String() {"groomin", "vetenarian"})
            End If
        End If
    End Sub

    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        If cmbName.SelectedItem Is Nothing Then Exit Sub

        Dim itemName As String = cmbName.SelectedItem.ToString()
        Dim category As String = cmbCategory.SelectedItem.ToString()

        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = ""
                    If category = "Product" Then
                        query = "SELECT price FROM product WHERE product_name = @name LIMIT 1"
                    Else
                        ' Try to match groomin/vetenarian to what might be in DB (Grooming/Veterinarian/Groomig)
                        query = "SELECT service_charge FROM service WHERE type LIKE @name LIMIT 1"
                    End If

                    Using cmd As New MySqlCommand(query, conn)
                        If category = "Product" Then
                            cmd.Parameters.AddWithValue("@name", itemName)
                        Else
                            ' Add wildcard for flexibility with user typos vs DB
                            cmd.Parameters.AddWithValue("@name", itemName & "%")
                        End If

                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            txtUnitPrice.Text = result.ToString()
                        Else
                            txtUnitPrice.Text = "0"
                        End If
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching price: " & ex.Message)
        End Try
        CalculateTotal()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim unitPrice As Decimal = 0
        Dim quantity As Integer = 0

        If Decimal.TryParse(txtUnitPrice.Text, unitPrice) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then
            txtTotalAmount.Text = (unitPrice * quantity).ToString("F2")
        Else
            txtTotalAmount.Text = "0.00"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbCategory.SelectedItem Is Nothing OrElse cmbName.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(txtQuantity.Text) Then
            MessageBox.Show("Please fill all item details.")
            Exit Sub
        End If

        dgvCart.Rows.Add(txtBillNo.Text, dtpDate.Value.ToShortDateString(), txtTime.Text, txtCustomerID.Text, cmbCategory.Text, cmbName.Text, txtUnitPrice.Text, txtQuantity.Text, txtTotalAmount.Text)
        ClearItemFields()
    End Sub

    Private Sub ClearItemFields()
        cmbCategory.SelectedIndex = -1
        cmbName.Items.Clear()
        txtUnitPrice.Clear()
        txtQuantity.Clear()
        txtTotalAmount.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        InitializeForm()
        dgvCart.Rows.Clear()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty.")
            Exit Sub
        End If

        PrintReceipt()
    End Sub

    Private Sub PrintReceipt()
        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler
        Dim printDlg As New PrintPreviewDialog()
        printDlg.Document = printDoc
        printDlg.ShowDialog()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim offset As Integer = 40

        e.Graphics.DrawString("PET STORE RECEIPT", fontHeader, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString("Bill No: " & txtBillNo.Text, fontBody, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString("Customer ID: " & txtCustomerID.Text, fontBody, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString("Date: " & dtpDate.Value.ToShortDateString(), fontBody, Brushes.Black, startX, startY)
        startY += offset

        e.Graphics.DrawString("Item", fontBody, Brushes.Black, startX, startY)
        e.Graphics.DrawString("Qty", fontBody, Brushes.Black, startX + 200, startY)
        e.Graphics.DrawString("Price", fontBody, Brushes.Black, startX + 250, startY)
        e.Graphics.DrawString("Total", fontBody, Brushes.Black, startX + 320, startY)
        startY += 20
        e.Graphics.DrawString("----------------------------------------------------------------", fontBody, Brushes.Black, startX, startY)
        startY += 20

        Dim grandTotal As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                Dim name As String = If(row.Cells("ItemName").Value IsNot Nothing, row.Cells("ItemName").Value.ToString(), "")
                Dim qty As String = If(row.Cells("Quantity").Value IsNot Nothing, row.Cells("Quantity").Value.ToString(), "0")
                Dim price As String = If(row.Cells("UnitPrice").Value IsNot Nothing, row.Cells("UnitPrice").Value.ToString(), "0")
                Dim total As String = If(row.Cells("TotalAmount").Value IsNot Nothing, row.Cells("TotalAmount").Value.ToString(), "0")

                e.Graphics.DrawString(name, fontBody, Brushes.Black, startX, startY)
                e.Graphics.DrawString(qty, fontBody, Brushes.Black, startX + 200, startY)
                e.Graphics.DrawString(price, fontBody, Brushes.Black, startX + 250, startY)
                e.Graphics.DrawString(total, fontBody, Brushes.Black, startX + 320, startY)

                Dim val As Decimal = 0
                Decimal.TryParse(total, val)
                grandTotal += val
                startY += 20
            End If
        Next

        startY += offset
        e.Graphics.DrawString("Grand Total: " & grandTotal.ToString("F2"), fontHeader, Brushes.Black, startX, startY)
    End Sub
End Class
