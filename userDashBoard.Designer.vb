<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btn10 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn14 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.lblDate)
        Me.Guna2Panel2.Controls.Add(Me.lblTime)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(256, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1409, 57)
        Me.Guna2Panel2.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(92, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 23)
        Me.lblDate.TabIndex = 85
        Me.lblDate.Text = "Label1"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(286, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(78, 23)
        Me.lblTime.TabIndex = 84
        Me.lblTime.Text = "Label12"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Guna2Panel1.Controls.Add(Me.btnCustomer)
        Me.Guna2Panel1.Controls.Add(Me.btn10)
        Me.Guna2Panel1.Controls.Add(Me.btn11)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.btn14)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(256, 1055)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnCustomer
        '
        Me.btnCustomer.Animated = True
        Me.btnCustomer.AutoRoundedCorners = True
        Me.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCustomer.FillColor = System.Drawing.Color.Transparent
        Me.btnCustomer.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnCustomer.HoverState.FillColor = System.Drawing.Color.White
        Me.btnCustomer.Location = New System.Drawing.Point(3, 298)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(242, 38)
        Me.btnCustomer.TabIndex = 14
        Me.btnCustomer.Text = "Customer"
        '
        'btn10
        '
        Me.btn10.Animated = True
        Me.btn10.AutoRoundedCorners = True
        Me.btn10.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn10.FillColor = System.Drawing.Color.Transparent
        Me.btn10.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn10.ForeColor = System.Drawing.Color.Black
        Me.btn10.HoverState.FillColor = System.Drawing.Color.White
        Me.btn10.Location = New System.Drawing.Point(3, 348)
        Me.btn10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(242, 38)
        Me.btn10.TabIndex = 13
        Me.btn10.Text = "Order"
        '
        'btn11
        '
        Me.btn11.Animated = True
        Me.btn11.AutoRoundedCorners = True
        Me.btn11.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn11.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn11.FillColor = System.Drawing.Color.Transparent
        Me.btn11.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn11.ForeColor = System.Drawing.Color.Black
        Me.btn11.HoverState.FillColor = System.Drawing.Color.White
        Me.btn11.Location = New System.Drawing.Point(3, 456)
        Me.btn11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(242, 38)
        Me.btn11.TabIndex = 12
        Me.btn11.Text = "Appointment"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(3, 248)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(242, 38)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "Pet"
        '
        'btn14
        '
        Me.btn14.Animated = True
        Me.btn14.AutoRoundedCorners = True
        Me.btn14.BackColor = System.Drawing.Color.Transparent
        Me.btn14.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn14.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn14.FillColor = System.Drawing.Color.Transparent
        Me.btn14.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn14.ForeColor = System.Drawing.Color.Black
        Me.btn14.HoverState.FillColor = System.Drawing.Color.White
        Me.btn14.Location = New System.Drawing.Point(3, 926)
        Me.btn14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(242, 38)
        Me.btn14.TabIndex = 10
        Me.btn14.Text = "Log Out"
        '
        'pnlContainer
        '
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(256, 57)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1409, 998)
        Me.pnlContainer.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'userDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1665, 1055)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "userDashBoard"
        Me.Text = "userDashBoard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn14 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer2 As Timer
End Class
