Imports Org.BouncyCastle.Asn1.X509

Public Class inventory

    Private Sub RefreshInventoryGrid()
        Try
            DataGridView1.DataSource = inventoryCRUD.LoadInventory()
        Catch ex As Exception
            MessageBox.Show("Failed to refresh inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshInventoryGrid()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.Text = "Product" Then
            lblProductID.Text = "Product ID"
        Else
            lblProductID.Text = "Pet ID"
        End If

        cmbType.Items.Clear()
        cmbName.Items.Clear()

        If cmbCategory.SelectedItem.ToString() = "Pet" Then
            cmbType.Items.AddRange(New String() {"Dog", "Cat"})
        ElseIf cmbCategory.SelectedItem.ToString() = "Product" Then
            cmbType.Items.AddRange(New String() {"Food", "Toys", "Accessories", "Litter and Waste Supplies"})
        End If
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDateTime As Date = DateTimePicker1.Value

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        cmbName.Items.Clear()

        If cmbCategory.SelectedItem.ToString() = "Pet" Then
            If cmbType.SelectedItem.ToString() = "Dog" Then
                cmbName.Items.AddRange(New String() {"Geraman Shepherd", "Bull Dog", "Labrador Retriever", "Golden Retriever", "Duchshund", "Rottweiler", "Boxer", "Pomeranian"})
            ElseIf cmbType.SelectedItem.ToString() = "Cat" Then
                cmbName.Items.AddRange(New String() {"Siamese Cat", "British Shorthair", "Persian Cat"})
            End If
        ElseIf cmbCategory.SelectedItem.ToString() = "Product" Then
            If cmbType.SelectedItem.ToString() = "Food" Then
                cmbName.Items.AddRange(New String() {"Dog Food", "Cat Food"})
            ElseIf cmbType.SelectedItem.ToString() = "Toys" Then
                cmbName.Items.AddRange(New String() {"Ball", "Squeaky Toy", "Chew Toy", "Scratching Post"})
            ElseIf cmbType.SelectedItem.ToString() = "Accessories" Then
                cmbName.Items.AddRange(New String() {"Collar", "ID Tags", "Leash", " Harness"})
            ElseIf cmbType.SelectedItem.ToString() = "Litter and Waste Supplies" Then
                cmbName.Items.AddRange(New String() {"Litter Box", "Poop Bag", "Scooper"})
            End If
        End If


    End Sub
End Class