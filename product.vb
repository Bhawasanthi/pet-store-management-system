Public Class frmproduct
    Private Sub LoadData()
        DataGridView1.DataSource = LoadProducts()
    End Sub

    Private Sub frmproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        LoadData()
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        cmbProductName.Items.Clear()

        If cmbProductType.SelectedItem.ToString() = "Food" Then
            cmbProductName.Items.AddRange(New String() {"Dog Food", "Cat Food"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Toys" Then
            cmbProductName.Items.AddRange(New String() {"Ball", "Squeaky Toy", "Chew Toy", "Scratching Post"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Accessories" Then
            cmbProductName.Items.AddRange(New String() {"Collar", "ID Tags", "Leash", "Harness"})
        ElseIf cmbProductType.SelectedItem.ToString() = "Litter and Waste Supplies" Then
        cmbProductName.Items.AddRange(New String() {"Litter Box", "Poop Bag", "Scooper"})
        End If
    End Sub
End Class