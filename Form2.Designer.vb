<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblForgotPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.txtUserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.CheckBox1)
        Me.Guna2Panel1.Controls.Add(Me.lblForgotPassword)
        Me.Guna2Panel1.Controls.Add(Me.btnLogin)
        Me.Guna2Panel1.Controls.Add(Me.txtPassword)
        Me.Guna2Panel1.Controls.Add(Me.lblUserLogin)
        Me.Guna2Panel1.Controls.Add(Me.txtUserName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Panel1.Location = New System.Drawing.Point(61, 61)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(344, 660)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPassword.Location = New System.Drawing.Point(66, 629)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(212, 31)
        Me.lblForgotPassword.TabIndex = 4
        Me.lblForgotPassword.Text = "Forgot Password?"
        Me.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderColor = System.Drawing.Color.White
        Me.btnLogin.BorderThickness = 2
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(96, 561)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(143, 56)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        '
        'txtPassword
        '
        Me.txtPassword.AutoRoundedCorners = True
        Me.txtPassword.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.BorderRadius = 27
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = Global.pet_store_management_system.My.Resources.Resources.download__7_
        Me.txtPassword.Location = New System.Drawing.Point(3, 448)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(338, 56)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogin.ForeColor = System.Drawing.Color.Black
        Me.lblUserLogin.Location = New System.Drawing.Point(106, 313)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(133, 29)
        Me.lblUserLogin.TabIndex = 0
        Me.lblUserLogin.Text = "User Login"
        '
        'txtUserName
        '
        Me.txtUserName.AutoRoundedCorners = True
        Me.txtUserName.BorderColor = System.Drawing.Color.Black
        Me.txtUserName.BorderRadius = 27
        Me.txtUserName.BorderThickness = 2
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.DefaultText = ""
        Me.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.IconLeft = Global.pet_store_management_system.My.Resources.Resources.download__4_
        Me.txtUserName.Location = New System.Drawing.Point(3, 365)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtUserName.PlaceholderText = "User Name"
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.Size = New System.Drawing.Size(338, 56)
        Me.txtUserName.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BackgroundImage = Global.pet_store_management_system.My.Resources.Resources.Picture12
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(344, 310)
        Me.Guna2Panel2.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(20, 511)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(145, 44)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.pet_store_management_system.My.Resources.Resources.WhatsApp_Image_2025_05_30_at_23_09_13_f6b302d8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1185, 721)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_ Interface"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents txtUserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
