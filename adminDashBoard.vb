

Public Class frmadminDashBoard
        Public Property UserRole As String
        Public Property UserName As String

    Private Sub loadChildForm(childform As Form)
        pnlContainer.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(childform)
        pnlContainer.Tag = childform
        childform.Show()

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        loadChildForm(New frmemployeeReg)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        loadChildForm(New frmCustomer)
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        loadChildForm(New frmTransactions)
    End Sub

    Private Sub btnPet_Click(sender As Object, e As EventArgs) Handles btnPet.Click
        loadChildForm(New frmPet)
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        loadChildForm(New frmproduct)
    End Sub

    Private Sub btnServiceProduct_Click(sender As Object, e As EventArgs) Handles btnServiceProduct.Click
        loadChildForm(New frmServiceProduct)
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        loadChildForm(New frmService)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        loadChildForm(New frmAppointment)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        loadChildForm(New frmOrder)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New frmLogin()
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmadminDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub


End Class