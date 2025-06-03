Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class petform
    Dim con As New MySqlConnection("Server=localhost;Database=psms;User Id=root;Password=;")
    Private Sub btnBrowsePet_Click(sender As Object, e As EventArgs) Handles btnBrowsePet.Click
        OpenFileDialog1.ShowDialog()
        txtPetimagePath.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        petPictureBox.Image = Image.FromFile(txtPetimagePath.Text)
    End Sub


    Private Sub LoadData()
        Try
            con.Open()
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter("SELECT * FROM Pets", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txtPetid.Clear()
        txtName.Clear()
        cmbType.SelectedIndex = -1
        cmbBreed.SelectedIndex = -1
        txtColor.Clear()
        txtAge.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        cmbHealthStatus.SelectedIndex = -1
        txtPrice.Clear()
        txtQunatity.Clear()
        txtSupplierId.Clear()
        cmbStatus.SelectedIndex = -1
        txtPetimagePath.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            con.Open()
            Dim gender As String = If(rbMale.Checked, "Male", "Female")

            Dim query As String = "INSERT INTO Pets (PetID, Name, Type, Breed, Age, Gender, Price, HealthStatus, Status, Quantity, Image, Color)
                               VALUES (@PetID, @Name, @Type, @Breed, @Age, @Gender, @Price, @HealthStatus, @Status, @Quantity, @Image, @Color)"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@PetID", txtPetid.Text)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Type", cmbType.Text)
                cmd.Parameters.AddWithValue("@Breed", cmbBreed.Text)
                cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@HealthStatus", cmbHealthStatus.Text)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@Quantity", txtQunatity.Text)
                cmd.Parameters.AddWithValue("@Image", txtPetimagePath.Text)
                cmd.Parameters.AddWithValue("@Color", txtColor.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Pet added successfully.")
            ClearFields()
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class