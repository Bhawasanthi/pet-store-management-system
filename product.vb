Public Class frmproduct
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        cmbProductType.SelectedIndex = -1
        cmbProductName.SelectedIndex = -1
        Guna2DateTimePicker1.Value = DateTime.Now
        Guna2TextBox4.Clear()
        cmbAvailability.SelectedIndex = -1
    End Sub
End Class