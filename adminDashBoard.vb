

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

        ' Ensure the form can accommodate the expanded panel
        ' Option 1: Make the form auto-scroll
        Me.AutoScroll = True

        ' Option 2: Increase form height if needed
        ' Me.Height = Math.Max(Me.Height, dropPnl1.MaximumSize.Height + 200)
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
                    ShowSubButtons(True)

                    ' Ensure buttons below are still visible
                    EnsureButtonsVisible()
                End If
            Else
                dropPnl1.Height -= 10
                If dropPnl1.Height <= dropPnl1.MinimumSize.Height Then
                    Timer1.Stop()
                    iscollapsed = True
                    dropBtn1.Image = My.Resources.download__2_3

                    ' Hide sub-buttons
                    ShowSubButtons(False)
                End If
            End If
        End Sub

        Private Sub ShowSubButtons(visible As Boolean)
            btn1.Visible = visible
            btn2.Visible = visible
            btn3.Visible = visible
            btn4.Visible = visible
            btn5.Visible = visible
            btn6.Visible = visible
        End Sub

        Private Sub EnsureButtonsVisible()
            ' If you have buttons below the dropdown panel, move them down
            ' Replace 'buttonsBelowPanel' with actual control names
            ' Example:
            ' Dim offsetY As Integer = Math.Max(0, dropPnl1.Bottom - originalButtonPosition)
            ' bottomButton1.Top = originalBottomButton1Top + offsetY
            ' bottomButton2.Top = originalBottomButton2Top + offsetY

            ' Or ensure the form scrolls to show them
            If Me.AutoScroll Then
                Me.AutoScrollMinSize = New Size(Me.Width, dropPnl1.Bottom + 100)
            End If
        End Sub
End Class