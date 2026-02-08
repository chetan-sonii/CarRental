<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCars
    Inherits ReaLTaiizor.Forms.PoisonForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.dgvCars = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.txtRegNo = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtBrand = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtModel = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPrice = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.cbAvailable = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.btnAdd = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnEdit = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnDelete = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnClear = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnRefresh = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel4 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel6 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtSearch = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel7 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblTotalCars = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblAvailableCars = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonPanel2 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonPanel3 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonTile1 = New ReaLTaiizor.Controls.PoisonTile()
        Me.PoisonTile2 = New ReaLTaiizor.Controls.PoisonTile()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.PoisonPanel2.SuspendLayout()
        Me.PoisonPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        '
        'dgvCars
        '
        Me.dgvCars.AllowUserToAddRows = False
        Me.dgvCars.AllowUserToDeleteRows = False
        Me.dgvCars.AllowUserToResizeRows = False
        Me.dgvCars.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCars.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCars.ColumnHeadersHeight = 35
        Me.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCars.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCars.EnableHeadersVisualStyles = False
        Me.dgvCars.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCars.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCars.Location = New System.Drawing.Point(0, 0)
        Me.dgvCars.MultiSelect = False
        Me.dgvCars.Name = "dgvCars"
        Me.dgvCars.ReadOnly = True
        Me.dgvCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCars.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCars.RowHeadersVisible = False
        Me.dgvCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCars.RowTemplate.Height = 30
        Me.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCars.Size = New System.Drawing.Size(670, 410)
        Me.dgvCars.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.dgvCars.TabIndex = 0
        '
        'txtRegNo
        '
        '
        '
        '
        Me.txtRegNo.CustomButton.Image = Nothing
        Me.txtRegNo.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtRegNo.CustomButton.Name = ""
        Me.txtRegNo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRegNo.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtRegNo.CustomButton.TabIndex = 1
        Me.txtRegNo.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtRegNo.CustomButton.UseSelectable = True
        Me.txtRegNo.CustomButton.Visible = False
        Me.txtRegNo.Lines = New String(-1) {}
        Me.txtRegNo.Location = New System.Drawing.Point(15, 35)
        Me.txtRegNo.MaxLength = 32767
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegNo.PromptText = "e.g., MH-12-AB-1234"
        Me.txtRegNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRegNo.SelectedText = ""
        Me.txtRegNo.SelectionLength = 0
        Me.txtRegNo.SelectionStart = 0
        Me.txtRegNo.ShortcutsEnabled = True
        Me.txtRegNo.Size = New System.Drawing.Size(220, 23)
        Me.txtRegNo.TabIndex = 1
        Me.txtRegNo.UseSelectable = True
        Me.txtRegNo.WaterMark = "e.g., MH-12-AB-1234"
        Me.txtRegNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRegNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBrand
        '
        '
        '
        '
        Me.txtBrand.CustomButton.Image = Nothing
        Me.txtBrand.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtBrand.CustomButton.Name = ""
        Me.txtBrand.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBrand.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtBrand.CustomButton.TabIndex = 1
        Me.txtBrand.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtBrand.CustomButton.UseSelectable = True
        Me.txtBrand.CustomButton.Visible = False
        Me.txtBrand.Lines = New String(-1) {}
        Me.txtBrand.Location = New System.Drawing.Point(15, 95)
        Me.txtBrand.MaxLength = 32767
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.PromptText = "e.g., Toyota, Honda"
        Me.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.SelectionLength = 0
        Me.txtBrand.SelectionStart = 0
        Me.txtBrand.ShortcutsEnabled = True
        Me.txtBrand.Size = New System.Drawing.Size(220, 23)
        Me.txtBrand.TabIndex = 2
        Me.txtBrand.UseSelectable = True
        Me.txtBrand.WaterMark = "e.g., Toyota, Honda"
        Me.txtBrand.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBrand.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtModel
        '
        '
        '
        '
        Me.txtModel.CustomButton.Image = Nothing
        Me.txtModel.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtModel.CustomButton.Name = ""
        Me.txtModel.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtModel.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtModel.CustomButton.TabIndex = 1
        Me.txtModel.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtModel.CustomButton.UseSelectable = True
        Me.txtModel.CustomButton.Visible = False
        Me.txtModel.Lines = New String(-1) {}
        Me.txtModel.Location = New System.Drawing.Point(15, 155)
        Me.txtModel.MaxLength = 32767
        Me.txtModel.Name = "txtModel"
        Me.txtModel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModel.PromptText = "e.g., Camry, Civic"
        Me.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModel.SelectedText = ""
        Me.txtModel.SelectionLength = 0
        Me.txtModel.SelectionStart = 0
        Me.txtModel.ShortcutsEnabled = True
        Me.txtModel.Size = New System.Drawing.Size(220, 23)
        Me.txtModel.TabIndex = 3
        Me.txtModel.UseSelectable = True
        Me.txtModel.WaterMark = "e.g., Camry, Civic"
        Me.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrice
        '
        '
        '
        '
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrice.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(15, 215)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PromptText = "e.g., 5000"
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.Size = New System.Drawing.Size(220, 23)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMark = "e.g., 5000"
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbAvailable
        '
        Me.cbAvailable.FormattingEnabled = True
        Me.cbAvailable.ItemHeight = 23
        Me.cbAvailable.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbAvailable.Location = New System.Drawing.Point(15, 275)
        Me.cbAvailable.Name = "cbAvailable"
        Me.cbAvailable.Size = New System.Drawing.Size(220, 29)
        Me.cbAvailable.TabIndex = 5
        Me.cbAvailable.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Highlight = True
        Me.btnAdd.Location = New System.Drawing.Point(15, 325)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 35)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "➕ Add Car"
        Me.btnAdd.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(130, 325)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(105, 35)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "✏️ Update"
        Me.btnEdit.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 370)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 35)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "🗑️ Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(130, 415)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 35)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "← Back"
        Me.btnBack.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "🔄 Clear"
        Me.btnClear.UseSelectable = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(15, 415)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 35)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "↻ Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(15, 13)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(131, 19)
        Me.PoisonLabel1.TabIndex = 10
        Me.PoisonLabel1.Text = "Registration Number"
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(15, 133)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(47, 19)
        Me.PoisonLabel2.TabIndex = 11
        Me.PoisonLabel2.Text = "Model"
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(15, 73)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(44, 19)
        Me.PoisonLabel3.TabIndex = 12
        Me.PoisonLabel3.Text = "Brand"
        '
        'PoisonLabel4
        '
        Me.PoisonLabel4.AutoSize = True
        Me.PoisonLabel4.Location = New System.Drawing.Point(15, 193)
        Me.PoisonLabel4.Name = "PoisonLabel4"
        Me.PoisonLabel4.Size = New System.Drawing.Size(106, 19)
        Me.PoisonLabel4.TabIndex = 13
        Me.PoisonLabel4.Text = "Price Per Day (₹)"
        '
        'PoisonLabel5
        '
        Me.PoisonLabel5.AutoSize = True
        Me.PoisonLabel5.Location = New System.Drawing.Point(15, 253)
        Me.PoisonLabel5.Name = "PoisonLabel5"
        Me.PoisonLabel5.Size = New System.Drawing.Size(109, 19)
        Me.PoisonLabel5.TabIndex = 14
        Me.PoisonLabel5.Text = "Availability Status"
        '
        'PoisonLabel6
        '
        Me.PoisonLabel6.AutoSize = True
        Me.PoisonLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PoisonLabel6.Location = New System.Drawing.Point(273, 73)
        Me.PoisonLabel6.Name = "PoisonLabel6"
        Me.PoisonLabel6.Size = New System.Drawing.Size(111, 19)
        Me.PoisonLabel6.TabIndex = 15
        Me.PoisonLabel6.Text = "🚗 Car Inventory"
        Me.PoisonLabel6.UseCustomForeColor = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(871, 77)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search by Reg No, Brand, Model..."
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(218, 23)
        Me.txtSearch.TabIndex = 16
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search by Reg No, Brand, Model..."
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PoisonLabel7
        '
        Me.PoisonLabel7.AutoSize = True
        Me.PoisonLabel7.Location = New System.Drawing.Point(783, 77)
        Me.PoisonLabel7.Name = "PoisonLabel7"
        Me.PoisonLabel7.Size = New System.Drawing.Size(71, 19)
        Me.PoisonLabel7.TabIndex = 17
        Me.PoisonLabel7.Text = "🔍 Search"
        '
        'lblTotalCars
        '
        Me.lblTotalCars.AutoSize = True
        Me.lblTotalCars.Location = New System.Drawing.Point(10, 25)
        Me.lblTotalCars.Name = "lblTotalCars"
        Me.lblTotalCars.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalCars.TabIndex = 18
        Me.lblTotalCars.Text = "0"
        '
        'lblAvailableCars
        '
        Me.lblAvailableCars.AutoSize = True
        Me.lblAvailableCars.Location = New System.Drawing.Point(10, 25)
        Me.lblAvailableCars.Name = "lblAvailableCars"
        Me.lblAvailableCars.Size = New System.Drawing.Size(16, 19)
        Me.lblAvailableCars.TabIndex = 19
        Me.lblAvailableCars.Text = "0"
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.txtRegNo)
        Me.PoisonPanel1.Controls.Add(Me.txtBrand)
        Me.PoisonPanel1.Controls.Add(Me.txtModel)
        Me.PoisonPanel1.Controls.Add(Me.txtPrice)
        Me.PoisonPanel1.Controls.Add(Me.cbAvailable)
        Me.PoisonPanel1.Controls.Add(Me.btnAdd)
        Me.PoisonPanel1.Controls.Add(Me.btnEdit)
        Me.PoisonPanel1.Controls.Add(Me.btnDelete)
        Me.PoisonPanel1.Controls.Add(Me.btnClear)
        Me.PoisonPanel1.Controls.Add(Me.btnRefresh)
        Me.PoisonPanel1.Controls.Add(Me.btnBack)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel3)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel4)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel5)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(23, 110)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(250, 468)
        Me.PoisonPanel1.TabIndex = 20
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'PoisonPanel2
        '
        Me.PoisonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel2.Controls.Add(Me.dgvCars)
        Me.PoisonPanel2.HorizontalScrollbarBarColor = True
        Me.PoisonPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.HorizontalScrollbarSize = 10
        Me.PoisonPanel2.Location = New System.Drawing.Point(290, 110)
        Me.PoisonPanel2.Name = "PoisonPanel2"
        Me.PoisonPanel2.Size = New System.Drawing.Size(672, 412)
        Me.PoisonPanel2.TabIndex = 21
        Me.PoisonPanel2.VerticalScrollbarBarColor = True
        Me.PoisonPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.VerticalScrollbarSize = 10
        '
        'PoisonPanel3
        '
        Me.PoisonPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel3.Controls.Add(Me.lblAvailableCars)
        Me.PoisonPanel3.HorizontalScrollbarBarColor = True
        Me.PoisonPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel3.HorizontalScrollbarSize = 10
        Me.PoisonPanel3.Location = New System.Drawing.Point(988, 110)
        Me.PoisonPanel3.Name = "PoisonPanel3"
        Me.PoisonPanel3.Size = New System.Drawing.Size(150, 70)
        Me.PoisonPanel3.TabIndex = 22
        Me.PoisonPanel3.VerticalScrollbarBarColor = True
        Me.PoisonPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel3.VerticalScrollbarSize = 10
        '
        'PoisonTile1
        '
        Me.PoisonTile1.ActiveControl = Nothing
        Me.PoisonTile1.Location = New System.Drawing.Point(290, 528)
        Me.PoisonTile1.Name = "PoisonTile1"
        Me.PoisonTile1.Size = New System.Drawing.Size(200, 50)
        Me.PoisonTile1.TabIndex = 23
        Me.PoisonTile1.Text = "Total Cars"
        Me.PoisonTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PoisonTile1.UseSelectable = True
        '
        'PoisonTile2
        '
        Me.PoisonTile2.ActiveControl = Nothing
        Me.PoisonTile2.Location = New System.Drawing.Point(500, 528)
        Me.PoisonTile2.Name = "PoisonTile2"
        Me.PoisonTile2.Size = New System.Drawing.Size(200, 50)
        Me.PoisonTile2.TabIndex = 24
        Me.PoisonTile2.Text = "Available Cars"
        Me.PoisonTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PoisonTile2.UseSelectable = True
        '
        'FrmCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.PoisonTile2)
        Me.Controls.Add(Me.PoisonTile1)
        Me.Controls.Add(Me.PoisonPanel3)
        Me.Controls.Add(Me.PoisonPanel2)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.Controls.Add(Me.PoisonLabel7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PoisonLabel6)
        Me.Name = "FrmCars"
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.Text = "Car Rental Management System"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.PoisonPanel2.ResumeLayout(False)
        Me.PoisonPanel3.ResumeLayout(False)
        Me.PoisonPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents dgvCars As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnDelete As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnEdit As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnAdd As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents cbAvailable As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents txtPrice As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtModel As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtBrand As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtRegNo As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel4 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnClear As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel6 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtSearch As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel7 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblTotalCars As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblAvailableCars As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonPanel2 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonPanel3 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonTile1 As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents PoisonTile2 As ReaLTaiizor.Controls.PoisonTile
End Class
