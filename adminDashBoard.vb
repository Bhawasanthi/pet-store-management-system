Public Class frmadminDashBoard
    Public Property UserRole As String
    Public Property UserName As String

    Dim iscollapsed As Boolean = True
    Private Sub frmadminDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropPnl1.Height = dropPnl1.MinimumSize.Height
        dropBtn1.Image = My.Resources.download__2_3 ' initial image

        ' Hide sub-buttons initially
        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn6.Visible = False
    End Sub


    Private Sub dropBtn1_Click(sender As Object, e As EventArgs) Handles dropBtn1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If iscollapsed Then
            dropPnl1.Height += 10
            If dropPnl1.Height >= dropPnl1.MaximumSize.Height Then
                Timer1.Stop()
                iscollapsed = False
                dropBtn1.Image = My.Resources.download3

                ' Show sub-buttons
                btn1.Visible = True
                btn2.Visible = True
                btn3.Visible = True
                btn4.Visible = True
                btn5.Visible = True
                btn6.Visible = True
            End If
        Else
            dropPnl1.Height -= 10
            If dropPnl1.Height <= dropPnl1.MinimumSize.Height Then
                Timer1.Stop()
                iscollapsed = True
                dropBtn1.Image = My.Resources.download__2_3

                ' Hide sub-buttons
                btn1.Visible = False
                btn2.Visible = False
                btn3.Visible = False
                btn4.Visible = False
                btn5.Visible = False
                btn6.Visible = False
            End If

        End If
    End Sub


End Class