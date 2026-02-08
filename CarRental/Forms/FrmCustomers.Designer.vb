<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
    Inherits ReaLTaiizor.Forms.PoisonForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.dgvCustomers = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.txtId = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtName = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtAddress = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPhone = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.btnAdd = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnEdit = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnDelete = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnClear = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnRefresh = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel4 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel6 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtSearch = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel7 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonPanel2 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonTile1 = New ReaLTaiizor.Controls.PoisonTile()
        Me.txtEmail = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel8 = New ReaLTaiizor.Controls.PoisonLabel()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.PoisonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomers.ColumnHeadersHeight = 35
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomers.EnableHeadersVisualStyles = False
        Me.dgvCustomers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCustomers.RowTemplate.Height = 30
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(670, 410)
        Me.dgvCustomers.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.dgvCustomers.TabIndex = 0
        '
        'txtId
        '
        '
        '
        '
        Me.txtId.CustomButton.Image = Nothing
        Me.txtId.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtId.CustomButton.Name = ""
        Me.txtId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtId.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtId.CustomButton.TabIndex = 1
        Me.txtId.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtId.CustomButton.UseSelectable = True
        Me.txtId.CustomButton.Visible = False
        Me.txtId.Enabled = False
        Me.txtId.Lines = New String(-1) {}
        Me.txtId.Location = New System.Drawing.Point(15, 35)
        Me.txtId.MaxLength = 32767
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.ReadOnly = True
        Me.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtId.SelectedText = ""
        Me.txtId.SelectionLength = 0
        Me.txtId.SelectionStart = 0
        Me.txtId.ShortcutsEnabled = True
        Me.txtId.Size = New System.Drawing.Size(220, 23)
        Me.txtId.TabIndex = 1
        Me.txtId.UseSelectable = True
        Me.txtId.WaterMark = "Auto-generated"
        Me.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(15, 95)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(220, 23)
        Me.txtName.TabIndex = 2
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMark = "e.g., John Doe"
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(69, 69)
        Me.txtAddress.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(15, 215)
        Me.txtAddress.MaxLength = 200
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(220, 71)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMark = "Full address..."
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone
        '
        '
        '
        '
        Me.txtPhone.CustomButton.Image = Nothing
        Me.txtPhone.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtPhone.CustomButton.Name = ""
        Me.txtPhone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhone.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPhone.CustomButton.TabIndex = 1
        Me.txtPhone.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPhone.CustomButton.UseSelectable = True
        Me.txtPhone.CustomButton.Visible = False
        Me.txtPhone.Lines = New String(-1) {}
        Me.txtPhone.Location = New System.Drawing.Point(15, 155)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.SelectionLength = 0
        Me.txtPhone.SelectionStart = 0
        Me.txtPhone.ShortcutsEnabled = True
        Me.txtPhone.Size = New System.Drawing.Size(220, 23)
        Me.txtPhone.TabIndex = 3
        Me.txtPhone.UseSelectable = True
        Me.txtPhone.WaterMark = "e.g., +91-9876543210"
        Me.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAdd
        '
        Me.btnAdd.Highlight = True
        Me.btnAdd.Location = New System.Drawing.Point(15, 405)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 35)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "➕ Add"
        Me.btnAdd.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(130, 405)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(105, 35)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "✏️ Update"
        Me.btnEdit.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 450)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 35)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "🗑️ Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 450)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "🔄 Clear"
        Me.btnClear.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(130, 495)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 35)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "← Back"
        Me.btnBack.UseSelectable = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(15, 495)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 35)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "↻ Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(15, 13)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(81, 19)
        Me.PoisonLabel1.TabIndex = 12
        Me.PoisonLabel1.Text = "Customer ID"
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(15, 73)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(102, 19)
        Me.PoisonLabel2.TabIndex = 13
        Me.PoisonLabel2.Text = "Customer Name"
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(15, 133)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(90, 19)
        Me.PoisonLabel3.TabIndex = 14
        Me.PoisonLabel3.Text = "Phone Number"
        '
        'PoisonLabel4
        '
        Me.PoisonLabel4.AutoSize = True
        Me.PoisonLabel4.Location = New System.Drawing.Point(15, 193)
        Me.PoisonLabel4.Name = "PoisonLabel4"
        Me.PoisonLabel4.Size = New System.Drawing.Size(56, 19)
        Me.PoisonLabel4.TabIndex = 15
        Me.PoisonLabel4.Text = "Address"
        '
        'PoisonLabel5
        '
        Me.PoisonLabel5.AutoSize = True
        Me.PoisonLabel5.Location = New System.Drawing.Point(15, 301)
        Me.PoisonLabel5.Name = "PoisonLabel5"
        Me.PoisonLabel5.Size = New System.Drawing.Size(84, 19)
        Me.PoisonLabel5.TabIndex = 16
        Me.PoisonLabel5.Text = "Email Address"
        '
        'PoisonLabel6
        '
        Me.PoisonLabel6.AutoSize = True
        Me.PoisonLabel6.Location = New System.Drawing.Point(273, 73)
        Me.PoisonLabel6.Name = "PoisonLabel6"
        Me.PoisonLabel6.Size = New System.Drawing.Size(185, 19)
        Me.PoisonLabel6.TabIndex = 17
        Me.PoisonLabel6.Text = "👥 Customer Management"
        Me.PoisonLabel6.UseCustomForeColor = True
        Me.PoisonLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
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
        Me.txtSearch.Location = New System.Drawing.Point(852, 73)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(218, 23)
        Me.txtSearch.TabIndex = 18
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search by Name, Phone, Email..."
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PoisonLabel7
        '
        Me.PoisonLabel7.AutoSize = True
        Me.PoisonLabel7.Location = New System.Drawing.Point(783, 77)
        Me.PoisonLabel7.Name = "PoisonLabel7"
        Me.PoisonLabel7.Size = New System.Drawing.Size(63, 19)
        Me.PoisonLabel7.TabIndex = 19
        Me.PoisonLabel7.Text = "🔍 Search"
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.txtEmail)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel8)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.Controls.Add(Me.txtId)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel1.Controls.Add(Me.txtName)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel3)
        Me.PoisonPanel1.Controls.Add(Me.txtPhone)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel4)
        Me.PoisonPanel1.Controls.Add(Me.txtAddress)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel5)
        Me.PoisonPanel1.Controls.Add(Me.btnAdd)
        Me.PoisonPanel1.Controls.Add(Me.btnEdit)
        Me.PoisonPanel1.Controls.Add(Me.btnDelete)
        Me.PoisonPanel1.Controls.Add(Me.btnClear)
        Me.PoisonPanel1.Controls.Add(Me.btnRefresh)
        Me.PoisonPanel1.Controls.Add(Me.btnBack)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(23, 110)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(250, 548)
        Me.PoisonPanel1.TabIndex = 20
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'PoisonPanel2
        '
        Me.PoisonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel2.Controls.Add(Me.dgvCustomers)
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
        'PoisonTile1
        '
        Me.PoisonTile1.ActiveControl = Nothing
        Me.PoisonTile1.Location = New System.Drawing.Point(290, 528)
        Me.PoisonTile1.Name = "PoisonTile1"
        Me.PoisonTile1.Size = New System.Drawing.Size(250, 50)
        Me.PoisonTile1.TabIndex = 22
        Me.PoisonTile1.Text = "Total Customers: 0"
        Me.PoisonTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PoisonTile1.UseSelectable = True
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(198, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(15, 323)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(220, 23)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "e.g., john@example.com"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PoisonLabel8
        '
        Me.PoisonLabel8.AutoSize = True
        Me.PoisonLabel8.ForeColor = System.Drawing.Color.Red
        Me.PoisonLabel8.Location = New System.Drawing.Point(15, 359)
        Me.PoisonLabel8.Name = "PoisonLabel8"
        Me.PoisonLabel8.Size = New System.Drawing.Size(207, 19)
        Me.PoisonLabel8.TabIndex = 18
        Me.PoisonLabel8.Text = "* Name and Phone are required"
        Me.PoisonLabel8.UseCustomForeColor = True
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.PoisonTile1)
        Me.Controls.Add(Me.PoisonPanel2)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.Controls.Add(Me.PoisonLabel7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PoisonLabel6)
        Me.Name = "FrmCustomers"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.Text = "Customer Management - Car Rental System"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.PoisonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents dgvCustomers As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnClear As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnDelete As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnEdit As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnAdd As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents txtPhone As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtAddress As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtName As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtId As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel4 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel6 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtSearch As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel7 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonPanel2 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonTile1 As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents txtEmail As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel8 As ReaLTaiizor.Controls.PoisonLabel
End Class
