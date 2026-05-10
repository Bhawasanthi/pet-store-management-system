Imports System.IO
Imports System.Data
Imports MySql.Data.MySqlClient

﻿Public Class frmPet
    ' Dictionary to store pet types and corresponding breeds
    Private petBreeds As New Dictionary(Of String, List(Of String)) From {
        {"Dog", New List(Of String) From {"Geraman Shepherd", "Bull Dog", "Labrador Retriever", "Golden Retriever", "Duchshund", "Rottweiler", "Boxer", "Pomeranian"}},
        {"Cat", New List(Of String) From {"Siamese Cat", "British Shorthair", "Persian Cat"}}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate pet type ComboBox
        cmbType.Items.AddRange(New String() {"Dog", "Cat"})
        LoadPetData()
    End Sub

    Private Sub LoadPetData()
        Try
            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn Is Nothing Then Exit Sub
                Dim query As String = "SELECT * FROM pets"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView1.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPetType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        ' Clear existing breed items
        cmbBreed.Items.Clear()

        ' Get selected pet type
        If cmbType.SelectedItem IsNot Nothing Then
            Dim selectedType As String = cmbType.SelectedItem.ToString()

            ' Add breeds for the selected pet type
            If petBreeds.ContainsKey(selectedType) Then
                cmbBreed.Items.AddRange(petBreeds(selectedType).ToArray())
            End If
        End If

        ' Clear current selection
        cmbBreed.SelectedIndex = -1
    End Sub

    Private Sub btnBrowsePet_Click(sender As Object, e As EventArgs) Handles btnBrowsePet.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                txtPetimagePath.Text = OpenFileDialog1.FileName
                petPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        LoadPetData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim gender As String = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))
            If cmbType.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Or gender = "" Or txtPrice.Text = "" Then
                MessageBox.Show("Please fill all required fields (Type, Breed, Gender, Price).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim price As Decimal
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MessageBox.Show("Please enter a valid numeric value for Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim age As Integer = 0
            If txtAge.Text <> "" AndAlso Not Integer.TryParse(txtAge.Text, age) Then
                MessageBox.Show("Please enter a valid numeric value for Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn Is Nothing Then Exit Sub
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim query As String = "INSERT INTO pets (Type, Breed, Age, Gender, Price, HealthStatus, Status, image, color, name) " &
                                     "VALUES (@Type, @Breed, @Age, @Gender, @Price, @HealthStatus, @Status, @image, @color, @name)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Type", cmbType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Breed", cmbBreed.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@HealthStatus", If(cmbHealthStatus.SelectedIndex = -1, "", cmbHealthStatus.SelectedItem.ToString()))
                    cmd.Parameters.AddWithValue("@Status", "Available")
                    cmd.Parameters.AddWithValue("@color", txtColor.Text)
                    cmd.Parameters.AddWithValue("@name", "Unknown")

                    ' Image to byte array
                    If petPictureBox.Image IsNot Nothing Then
                        Using ms As New MemoryStream()
                            petPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            cmd.Parameters.AddWithValue("@image", ms.ToArray())
                        End Using
                    Else
                        cmd.Parameters.AddWithValue("@image", New Byte() {})
                    End If

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Pet added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPetData()
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding pet: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        cmbType.SelectedIndex = -1
        cmbBreed.Items.Clear()
        txtColor.Clear()
        txtAge.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        cmbHealthStatus.SelectedIndex = -1
        txtPrice.Clear()
        txtPetimagePath.Clear()
        petPictureBox.Image = Nothing
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtID.Text = "" Then
                MessageBox.Show("Please select a pet from the list to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim gender As String = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))
            If cmbType.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Or gender = "" Or txtPrice.Text = "" Then
                MessageBox.Show("Please fill all required fields (Type, Breed, Gender, Price).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim price As Decimal
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MessageBox.Show("Please enter a valid numeric value for Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim age As Integer = 0
            If txtAge.Text <> "" AndAlso Not Integer.TryParse(txtAge.Text, age) Then
                MessageBox.Show("Please enter a valid numeric value for Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using conn As MySqlConnection = dbConnection.GetConnection()
                If conn Is Nothing Then Exit Sub
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim query As String = "UPDATE pets SET Type=@Type, Breed=@Breed, Age=@Age, Gender=@Gender, Price=@Price, HealthStatus=@HealthStatus, image=@image, color=@color WHERE PetID=@PetID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Type", cmbType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Breed", cmbBreed.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@HealthStatus", If(cmbHealthStatus.SelectedIndex = -1, "", cmbHealthStatus.SelectedItem.ToString()))
                    cmd.Parameters.AddWithValue("@color", txtColor.Text)
                    cmd.Parameters.AddWithValue("@PetID", txtID.Text)

                    ' Image to byte array
                    If petPictureBox.Image IsNot Nothing Then
                        Using ms As New MemoryStream()
                            petPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            cmd.Parameters.AddWithValue("@image", ms.ToArray())
                        End Using
                    Else
                        cmd.Parameters.AddWithValue("@image", New Byte() {})
                    End If

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Pet updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPetData()
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating pet: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If txtID.Text = "" Then
                MessageBox.Show("Please select a pet from the list to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this pet?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using conn As MySqlConnection = dbConnection.GetConnection()
                    If conn Is Nothing Then Exit Sub
                    If conn.State <> ConnectionState.Open Then conn.Open()

                    Dim query As String = "DELETE FROM pets WHERE PetID=@PetID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@PetID", txtID.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Pet deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadPetData()
                        ClearFields()
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting pet: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                txtID.Text = row.Cells("PetID").Value.ToString()
                cmbType.SelectedItem = row.Cells("Type").Value.ToString()
                cmbBreed.SelectedItem = row.Cells("Breed").Value.ToString()
                txtColor.Text = row.Cells("color").Value.ToString()
                txtAge.Text = row.Cells("Age").Value.ToString()

                Dim gender As String = row.Cells("Gender").Value.ToString()
                If gender = "Male" Then
                    rbMale.Checked = True
                ElseIf gender = "Female" Then
                    rbFemale.Checked = True
                Else
                    rbMale.Checked = False
                    rbFemale.Checked = False
                End If

                cmbHealthStatus.SelectedItem = If(IsDBNull(row.Cells("HealthStatus").Value), "", row.Cells("HealthStatus").Value.ToString())
                txtPrice.Text = row.Cells("Price").Value.ToString()

                If Not IsDBNull(row.Cells("image").Value) Then
                    Dim imgData As Byte() = DirectCast(row.Cells("image").Value, Byte())
                    If imgData.Length > 0 Then
                        Using ms As New MemoryStream(imgData)
                            ' Create a copy of the image to avoid stream disposal issues
                            Dim img As Image = Image.FromStream(ms)
                            petPictureBox.Image = New Bitmap(img)
                        End Using
                    Else
                        petPictureBox.Image = Nothing
                    End If
                Else
                    petPictureBox.Image = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("Error selecting row: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
