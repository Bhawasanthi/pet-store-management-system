Public Class userDashBoard
    Public Property UserRole As String
    Public Property UserName As String

    Private Sub userDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub loadChildForm(childform As Form)
        pnlUserContainer.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnlUserContainer.Controls.Add(childform)
        pnlUserContainer.Tag = childform
        childform.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        loadChildForm(New frmPet())
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        loadChildForm(New frmOrder())
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        loadChildForm(New frmAppointment())
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class