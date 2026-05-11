Public Class frmPet
    ' Dictionary to store pet types and corresponding breeds
    Private petBreeds As New Dictionary(Of String, List(Of String)) From {
        {"Dog", New List(Of String) From {"Geraman Shepherd", "Bull Dog", "Labrador Retriever", "Golden Retriever", "Duchshund", "Rottweiler", "Boxer", "Pomeranian"}},
        {"Cat", New List(Of String) From {"Siamese Cat", "British Shorthair", "Persian Cat"}}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate pet type ComboBox
        cmbType.Items.AddRange(New String() {"Dog", "Cat"})
        txtID.Text = GetNextID("pets").ToString()
    End Sub

    Private Sub cmbPetType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        ' Clear existing breed items
        cmbBreed.Items.Clear()

        ' Get selected pet type
        Dim selectedType As String = cmbType.SelectedItem.ToString()

        ' Add breeds for the selected pet type
        If petBreeds.ContainsKey(selectedType) Then
            cmbBreed.Items.AddRange(petBreeds(selectedType).ToArray())
        End If

        ' Clear current selection
        cmbBreed.SelectedIndex = -1
    End Sub


End Class
