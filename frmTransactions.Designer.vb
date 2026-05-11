<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dtpReferenceDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnDay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnWeek = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMonth = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYear = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(500, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(256, 35)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Transaction History"
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactions.ColumnHeadersHeight = 30
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransactions.Location = New System.Drawing.Point(30, 200)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowHeadersWidth = 51
        Me.dgvTransactions.RowTemplate.Height = 24
        Me.dgvTransactions.Size = New System.Drawing.Size(1140, 450)
        Me.dgvTransactions.TabIndex = 1
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.HeaderStyle.HeigthSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTransactions.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvTransactions.ThemeStyle.ReadOnly = True
        Me.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTransactions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.RowsStyle.Height = 24
        Me.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dtpReferenceDate
        '
        Me.dtpReferenceDate.Checked = True
        Me.dtpReferenceDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpReferenceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpReferenceDate.Location = New System.Drawing.Point(30, 90)
        Me.dtpReferenceDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpReferenceDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpReferenceDate.Name = "dtpReferenceDate"
        Me.dtpReferenceDate.Size = New System.Drawing.Size(250, 36)
        Me.dtpReferenceDate.TabIndex = 2
        Me.dtpReferenceDate.Value = New Date(2026, 5, 11, 0, 0, 0, 0)
        '
        'btnDay
        '
        Me.btnDay.Animated = True
        Me.btnDay.AutoRoundedCorners = True
        Me.btnDay.BorderThickness = 1
        Me.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDay.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDay.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnDay.ForeColor = System.Drawing.Color.White
        Me.btnDay.Location = New System.Drawing.Point(300, 90)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(120, 45)
        Me.btnDay.TabIndex = 3
        Me.btnDay.Text = "Daily"
        '
        'btnWeek
        '
        Me.btnWeek.Animated = True
        Me.btnWeek.AutoRoundedCorners = True
        Me.btnWeek.BorderThickness = 1
        Me.btnWeek.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWeek.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWeek.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWeek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWeek.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWeek.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnWeek.ForeColor = System.Drawing.Color.White
        Me.btnWeek.Location = New System.Drawing.Point(440, 90)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(120, 45)
        Me.btnWeek.TabIndex = 4
        Me.btnWeek.Text = "Weekly"
        '
        'btnMonth
        '
        Me.btnMonth.Animated = True
        Me.btnMonth.AutoRoundedCorners = True
        Me.btnMonth.BorderThickness = 1
        Me.btnMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMonth.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMonth.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMonth.ForeColor = System.Drawing.Color.White
        Me.btnMonth.Location = New System.Drawing.Point(580, 90)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(120, 45)
        Me.btnMonth.TabIndex = 5
        Me.btnMonth.Text = "Monthly"
        '
        'btnYear
        '
        Me.btnYear.Animated = True
        Me.btnYear.AutoRoundedCorners = True
        Me.btnYear.BorderThickness = 1
        Me.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnYear.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnYear.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnYear.ForeColor = System.Drawing.Color.White
        Me.btnYear.Location = New System.Drawing.Point(720, 90)
        Me.btnYear.Name = "btnYear"
        Me.btnYear.Size = New System.Drawing.Size(120, 45)
        Me.btnYear.TabIndex = 6
        Me.btnYear.Text = "Yearly"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenue.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRevenue.Location = New System.Drawing.Point(1000, 670)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(54, 25)
        Me.lblTotalRevenue.TabIndex = 7
        Me.lblTotalRevenue.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(820, 670)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total Revenue:"
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 750)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalRevenue)
        Me.Controls.Add(Me.btnYear)
        Me.Controls.Add(Me.btnMonth)
        Me.Controls.Add(Me.btnWeek)
        Me.Controls.Add(Me.btnDay)
        Me.Controls.Add(Me.dtpReferenceDate)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTransactions"
        Me.Text = "Transactions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvTransactions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dtpReferenceDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnDay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnWeek As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMonth As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents Label1 As Label
End Class
