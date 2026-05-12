Imports MySql.Data.MySqlClient

Public Class frmOrder
    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBillNo.Text = GenerateBillNo()
        dtpOrderDate.Value = DateTime.Now
        txtTime.Text = DateTime.Now.ToString("HH:mm:ss")
        SetupCartGrid()
        LoadCategories()
    End Sub

    Private Function GenerateBillNo() As String
        Return "B" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub SetupCartGrid()
        dgvCart.Columns.Clear()
        dgvCart.Columns.Add("ItemName", "Item Name")
        dgvCart.Columns.Add("Category", "Category")
        dgvCart.Columns.Add("UnitPrice", "Unit Price")
        dgvCart.Columns.Add("Qty", "Quantity")
        dgvCart.Columns.Add("Total", "Total Price")
        dgvCart.Columns.Add("Customer", "Customer Name")
    End Sub

    Private Sub LoadCategories()
        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("Pet")
        cmbCategory.Items.Add("Product")
        cmbCategory.Items.Add("Service ")
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        cmbProductType.Items.Clear()
        cmbProductName.Items.Clear()
        txtUnitPrice.Clear()

        If cmbCategory.SelectedItem Is Nothing Then Return

        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString()
        Dim query As String = ""
        Dim columnName As String = ""

        If selectedCategory = "Pet" Then
            query = "SELECT DISTINCT Type FROM pets"
            columnName = "Type"
        ElseIf selectedCategory = "Product" Then
            query = "SELECT DISTINCT product_type FROM product"
            columnName = "product_type"
        ElseIf selectedCategory = "Service " Then
            query = "SELECT DISTINCT type FROM service"
            columnName = "type"
        End If

        If query <> "" Then
            Try
                Using con As MySqlConnection = dbConnection.GetConnection()
                    If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                        Dim cmd As New MySqlCommand(query, con)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                cmbProductType.Items.Add(reader(columnName).ToString())
                            End While
                        End Using
                    End If
                End Using
            Catch ex As Exception
                ' Silent fail
            End Try
        End If
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        cmbProductName.Items.Clear()
        txtUnitPrice.Clear()

        If cmbProductType.SelectedItem Is Nothing Then Return

        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString()
        Dim selectedType As String = cmbProductType.SelectedItem.ToString()

        If selectedCategory = "Service " Then
            cmbProductName.Items.Add(selectedType)
            Return
        End If

        Dim query As String = ""
        Dim nameCol As String = ""

        If selectedCategory = "Pet" Then
            query = "SELECT Breed FROM pets WHERE Type = @type"
            nameCol = "Breed"
        ElseIf selectedCategory = "Product" Then
            query = "SELECT product_name FROM product WHERE product_type = @type"
            nameCol = "product_name"
        End If

        Try
            Using con As MySqlConnection = dbConnection.GetConnection()
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@type", selectedType)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbProductName.Items.Add(reader(nameCol).ToString())
                        End While
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Silent fail
        End Try
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductName.SelectedIndexChanged
        If cmbProductName.SelectedItem Is Nothing Then Return

        Dim selectedCategory As String = cmbCategory.SelectedItem.ToString()
        Dim selectedName As String = cmbProductName.SelectedItem.ToString()
        Dim query As String = ""

        If selectedCategory = "Pet" Then
            query = "SELECT Price FROM pets WHERE Breed = @name LIMIT 1"
        ElseIf selectedCategory = "Product" Then
            query = "SELECT price FROM product WHERE product_name = @name LIMIT 1"
        ElseIf selectedCategory = "Service " Then
            query = "SELECT service_charge FROM service WHERE type = @name LIMIT 1"
        End If

        Try
            Using con As MySqlConnection = dbConnection.GetConnection()
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@name", selectedName)
                    Dim price = cmd.ExecuteScalar()
                    If price IsNot Nothing Then
                        txtUnitPrice.Text = price.ToString()
                    End If
                End If
            End Using
        Catch ex As Exception
            ' Silent fail
        End Try
    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged
        If String.IsNullOrEmpty(txtCustomerID.Text) Then
            txtCustomerName.Clear()
            Return
        End If

        Try
            Using con As MySqlConnection = dbConnection.GetConnection()
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    Dim cmd As New MySqlCommand("SELECT customer_name FROM customers WHERE customer_id = @id", con)
                    cmd.Parameters.AddWithValue("@id", txtCustomerID.Text)
                    Dim name = cmd.ExecuteScalar()
                    If name IsNot Nothing Then
                        txtCustomerName.Text = name.ToString()
                    Else
                        txtCustomerName.Text = "Not Found"
                    End If
                End If
            End Using
        Catch ex As Exception
            ' Silent fail
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProductName.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(txtQty.Text) OrElse String.IsNullOrEmpty(txtCustomerName.Text) OrElse txtCustomerName.Text = "Not Found" Then
            MessageBox.Show("Please ensure all fields are filled correctly.")
            Return
        End If

        Dim price As Decimal = 0
        Dim qty As Integer = 0
        Dim total As Decimal = 0

        If Decimal.TryParse(txtUnitPrice.Text, price) AndAlso Integer.TryParse(txtQty.Text, qty) Then
            total = price * qty
        End If

        dgvCart.Rows.Add(cmbProductName.SelectedItem.ToString(), cmbCategory.SelectedItem.ToString(), txtUnitPrice.Text, txtQty.Text, total.ToString("F2"), txtCustomerName.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        cmbCategory.SelectedIndex = -1
        cmbProductType.Items.Clear()
        cmbProductName.Items.Clear()
        txtUnitPrice.Clear()
        txtQty.Clear()
        dgvCart.Rows.Clear()
        txtBillNo.Text = GenerateBillNo()
    End Sub
End Class
