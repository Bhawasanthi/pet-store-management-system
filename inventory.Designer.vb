<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventory
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
        Me.txtStockId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnitinStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUnitPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSupplierID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProductID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStandardPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnshow = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStockId
        '
        Me.txtStockId.BorderColor = System.Drawing.Color.Black
        Me.txtStockId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockId.DefaultText = ""
        Me.txtStockId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStockId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStockId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockId.ForeColor = System.Drawing.Color.Black
        Me.txtStockId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockId.Location = New System.Drawing.Point(163, 99)
        Me.txtStockId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStockId.Name = "txtStockId"
        Me.txtStockId.PlaceholderText = ""
        Me.txtStockId.SelectedText = ""
        Me.txtStockId.Size = New System.Drawing.Size(158, 51)
        Me.txtStockId.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Stock ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = True
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(471, 99)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(234, 36)
        Me.DateTimePicker1.TabIndex = 58
        Me.DateTimePicker1.Value = New Date(2025, 6, 4, 20, 53, 44, 799)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(526, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Category"
        '
        'txtUnitinStock
        '
        Me.txtUnitinStock.BorderColor = System.Drawing.Color.Black
        Me.txtUnitinStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnitinStock.DefaultText = ""
        Me.txtUnitinStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnitinStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnitinStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitinStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitinStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitinStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtUnitinStock.ForeColor = System.Drawing.Color.Black
        Me.txtUnitinStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitinStock.Location = New System.Drawing.Point(163, 490)
        Me.txtUnitinStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUnitinStock.Name = "txtUnitinStock"
        Me.txtUnitinStock.PlaceholderText = ""
        Me.txtUnitinStock.SelectedText = ""
        Me.txtUnitinStock.Size = New System.Drawing.Size(273, 51)
        Me.txtUnitinStock.TabIndex = 63
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BorderColor = System.Drawing.Color.Black
        Me.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnitPrice.DefaultText = ""
        Me.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnitPrice.Location = New System.Drawing.Point(163, 377)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.PlaceholderText = ""
        Me.txtUnitPrice.SelectedText = ""
        Me.txtUnitPrice.Size = New System.Drawing.Size(273, 51)
        Me.txtUnitPrice.TabIndex = 64
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BorderColor = System.Drawing.Color.Black
        Me.txtSupplierID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplierID.DefaultText = ""
        Me.txtSupplierID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupplierID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplierID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSupplierID.ForeColor = System.Drawing.Color.Black
        Me.txtSupplierID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierID.Location = New System.Drawing.Point(163, 280)
        Me.txtSupplierID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.PlaceholderText = ""
        Me.txtSupplierID.SelectedText = ""
        Me.txtSupplierID.Size = New System.Drawing.Size(273, 51)
        Me.txtSupplierID.TabIndex = 65
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderColor = System.Drawing.Color.Black
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(636, 490)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(273, 51)
        Me.txtQuantity.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Unit in Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 23)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 23)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Supplier ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1392, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 23)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(970, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 23)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Type"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderColor = System.Drawing.Color.Black
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Pet", "Product"})
        Me.cmbCategory.Location = New System.Drawing.Point(636, 181)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(273, 36)
        Me.cmbCategory.TabIndex = 73
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.Transparent
        Me.cmbType.BorderColor = System.Drawing.Color.Black
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.ItemHeight = 30
        Me.cmbType.Items.AddRange(New Object() {"Dog", "Cat", "Food", "Toys", "Accessories", "Litter and Waste Supplies"})
        Me.cmbType.Location = New System.Drawing.Point(1038, 181)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(273, 36)
        Me.cmbType.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(59, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 23)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Quantity"
        '
        'txtProductID
        '
        Me.txtProductID.BorderColor = System.Drawing.Color.Black
        Me.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductID.DefaultText = ""
        Me.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProductID.ForeColor = System.Drawing.Color.Black
        Me.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductID.Location = New System.Drawing.Point(163, 181)
        Me.txtProductID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.PlaceholderText = ""
        Me.txtProductID.SelectedText = ""
        Me.txtProductID.Size = New System.Drawing.Size(273, 51)
        Me.txtProductID.TabIndex = 76
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.BackColor = System.Drawing.Color.Transparent
        Me.lblProductID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(42, 197)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(102, 23)
        Me.lblProductID.TabIndex = 77
        Me.lblProductID.Text = "Product ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(-114, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2152, 70)
        Me.Panel1.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(928, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 35)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Inventory"
        '
        'txtStandardPrice
        '
        Me.txtStandardPrice.BorderColor = System.Drawing.Color.Black
        Me.txtStandardPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStandardPrice.DefaultText = ""
        Me.txtStandardPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStandardPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStandardPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStandardPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStandardPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStandardPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStandardPrice.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStandardPrice.Location = New System.Drawing.Point(636, 377)
        Me.txtStandardPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStandardPrice.Name = "txtStandardPrice"
        Me.txtStandardPrice.PlaceholderText = ""
        Me.txtStandardPrice.SelectedText = ""
        Me.txtStandardPrice.Size = New System.Drawing.Size(273, 51)
        Me.txtStandardPrice.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(480, 392)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 23)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Standard Price"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 601)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1476, 357)
        Me.DataGridView1.TabIndex = 81
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.Color.Transparent
        Me.cmbName.BorderColor = System.Drawing.Color.Black
        Me.cmbName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbName.ForeColor = System.Drawing.Color.Black
        Me.cmbName.ItemHeight = 30
        Me.cmbName.Items.AddRange(New Object() {"Dog Food", "Cat Food", "Ball", "Squeaky Toy", "Chew Toy", "Scratching Post", "Litter Box", "Poop Bag", "Scooper", "Collar", "Leash", "Harness", "ID Tag", "Geraman Shepherd", "Bull Dog", "Labrador Retriever", "Golden Retriever", "Duchshund", "Rottweiler", "Boxer", "Pomeranian", "Siamese Cat", "British Shorthair", "Persian Cat"})
        Me.cmbName.Location = New System.Drawing.Point(1471, 181)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(273, 36)
        Me.cmbName.TabIndex = 82
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.AutoRoundedCorners = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1534, 601)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(137, 56)
        Me.btnAdd.TabIndex = 83
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseTransparentBackground = True
        '
        'btnshow
        '
        Me.btnshow.Animated = True
        Me.btnshow.AutoRoundedCorners = True
        Me.btnshow.BackColor = System.Drawing.Color.Transparent
        Me.btnshow.BorderThickness = 1
        Me.btnshow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnshow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnshow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnshow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnshow.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnshow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnshow.ForeColor = System.Drawing.Color.White
        Me.btnshow.Location = New System.Drawing.Point(1534, 697)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(137, 56)
        Me.btnshow.TabIndex = 84
        Me.btnshow.Text = "SHOW"
        Me.btnshow.UseTransparentBackground = True
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AutoRoundedCorners = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderThickness = 1
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(1534, 802)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(137, 56)
        Me.btnEdit.TabIndex = 85
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseTransparentBackground = True
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.AutoRoundedCorners = True
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BorderThickness = 1
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(1534, 890)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(137, 56)
        Me.btndelete.TabIndex = 86
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseTransparentBackground = True
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.AutoRoundedCorners = True
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderThickness = 1
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(478, 280)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(137, 51)
        Me.btnSearch.TabIndex = 87
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseTransparentBackground = True
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 958)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStandardPrice)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtUnitinStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStockId)
        Me.Name = "inventory"
        Me.Text = "inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStockId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitinStock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUnitPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSupplierID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProductID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStandardPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnshow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
End Class
