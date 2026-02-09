<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRequests
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.dgvRentals = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonLabel8 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblDays = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel6 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCar = New ReaLTaiizor.Controls.PoisonLabel()
        Me.cbCar = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.btnRent = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnCalculate = New ReaLTaiizor.Controls.PoisonButton()
        Me.cbCustomer = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.dtReturnDate = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.dtRentDate = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.lblFee = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblReturnDate = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel2 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtSearch = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonTile1 = New ReaLTaiizor.Controls.PoisonTile()
        Me.btnClear = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnRefresh = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.lblRentDate = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCustomerPhone = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel4 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCustomerName = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCarInfo = New ReaLTaiizor.Controls.PoisonLabel()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.PoisonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        '
        'dgvRentals
        '
        Me.dgvRentals.AllowUserToAddRows = False
        Me.dgvRentals.AllowUserToDeleteRows = False
        Me.dgvRentals.AllowUserToResizeRows = False
        Me.dgvRentals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvRentals.ColumnHeadersHeight = 35
        Me.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentals.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRentals.EnableHeadersVisualStyles = False
        Me.dgvRentals.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentals.Location = New System.Drawing.Point(0, 0)
        Me.dgvRentals.MultiSelect = False
        Me.dgvRentals.Name = "dgvRentals"
        Me.dgvRentals.ReadOnly = True
        Me.dgvRentals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentals.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvRentals.RowHeadersVisible = False
        Me.dgvRentals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRentals.RowTemplate.Height = 30
        Me.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentals.Size = New System.Drawing.Size(670, 480)
        Me.dgvRentals.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.dgvRentals.TabIndex = 0
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.lblCarInfo)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel8)
        Me.PoisonPanel1.Controls.Add(Me.lblDays)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel6)
        Me.PoisonPanel1.Controls.Add(Me.lblCustomerPhone)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel4)
        Me.PoisonPanel1.Controls.Add(Me.lblCar)
        Me.PoisonPanel1.Controls.Add(Me.cbCar)
        Me.PoisonPanel1.Controls.Add(Me.btnRent)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel3)
        Me.PoisonPanel1.Controls.Add(Me.btnCalculate)
        Me.PoisonPanel1.Controls.Add(Me.cbCustomer)
        Me.PoisonPanel1.Controls.Add(Me.dtReturnDate)
        Me.PoisonPanel1.Controls.Add(Me.lblCustomerName)
        Me.PoisonPanel1.Controls.Add(Me.dtRentDate)
        Me.PoisonPanel1.Controls.Add(Me.lblRentDate)
        Me.PoisonPanel1.Controls.Add(Me.lblFee)
        Me.PoisonPanel1.Controls.Add(Me.lblReturnDate)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(23, 110)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(250, 627)
        Me.PoisonPanel1.TabIndex = 1
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'PoisonLabel8
        '
        Me.PoisonLabel8.AutoSize = True
        Me.PoisonLabel8.Location = New System.Drawing.Point(4, 432)
        Me.PoisonLabel8.Name = "PoisonLabel8"
        Me.PoisonLabel8.Size = New System.Drawing.Size(101, 19)
        Me.PoisonLabel8.TabIndex = 13
        Me.PoisonLabel8.Text = "Total Rental Fee"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(143, 400)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(46, 19)
        Me.lblDays.TabIndex = 12
        Me.lblDays.Text = "0 days"
        '
        'PoisonLabel6
        '
        Me.PoisonLabel6.AutoSize = True
        Me.PoisonLabel6.Location = New System.Drawing.Point(6, 400)
        Me.PoisonLabel6.Name = "PoisonLabel6"
        Me.PoisonLabel6.Size = New System.Drawing.Size(99, 19)
        Me.PoisonLabel6.TabIndex = 11
        Me.PoisonLabel6.Text = "Rental Duration"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Location = New System.Drawing.Point(15, 13)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(68, 19)
        Me.lblCar.TabIndex = 1
        Me.lblCar.Text = "Select Car"
        '
        'cbCar
        '
        Me.cbCar.FormattingEnabled = True
        Me.cbCar.ItemHeight = 23
        Me.cbCar.Location = New System.Drawing.Point(15, 35)
        Me.cbCar.Name = "cbCar"
        Me.cbCar.Size = New System.Drawing.Size(220, 29)
        Me.cbCar.TabIndex = 4
        Me.cbCar.UseSelectable = True
        '
        'btnRent
        '
        Me.btnRent.Highlight = True
        Me.btnRent.Location = New System.Drawing.Point(15, 553)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(220, 40)
        Me.btnRent.TabIndex = 8
        Me.btnRent.Text = "✓ Confirm Rental"
        Me.btnRent.UseSelectable = True
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(15, 73)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(104, 19)
        Me.PoisonLabel3.TabIndex = 3
        Me.PoisonLabel3.Text = "Select Customer"
        '
        'btnCalculate
        '
        Me.btnCalculate.Highlight = True
        Me.btnCalculate.Location = New System.Drawing.Point(15, 504)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(220, 35)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "💰 Calculate Total Fee"
        Me.btnCalculate.UseSelectable = True
        '
        'cbCustomer
        '
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.ItemHeight = 23
        Me.cbCustomer.Location = New System.Drawing.Point(15, 95)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(220, 29)
        Me.cbCustomer.TabIndex = 5
        Me.cbCustomer.UseSelectable = True
        '
        'dtReturnDate
        '
        Me.dtReturnDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.dtReturnDate.Location = New System.Drawing.Point(4, 368)
        Me.dtReturnDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtReturnDate.Name = "dtReturnDate"
        Me.dtReturnDate.Size = New System.Drawing.Size(220, 29)
        Me.dtReturnDate.TabIndex = 7
        '
        'dtRentDate
        '
        Me.dtRentDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.dtRentDate.Location = New System.Drawing.Point(6, 287)
        Me.dtRentDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtRentDate.Name = "dtRentDate"
        Me.dtRentDate.Size = New System.Drawing.Size(220, 29)
        Me.dtRentDate.TabIndex = 6
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Location = New System.Drawing.Point(143, 432)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(44, 19)
        Me.lblFee.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.lblFee.TabIndex = 3
        Me.lblFee.Text = "₹ 0.00"
        Me.lblFee.UseStyleColors = True
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Location = New System.Drawing.Point(6, 334)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(78, 19)
        Me.lblReturnDate.TabIndex = 3
        Me.lblReturnDate.Text = "Return Date"
        '
        'PoisonPanel2
        '
        Me.PoisonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel2.Controls.Add(Me.dgvRentals)
        Me.PoisonPanel2.HorizontalScrollbarBarColor = True
        Me.PoisonPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.HorizontalScrollbarSize = 10
        Me.PoisonPanel2.Location = New System.Drawing.Point(290, 110)
        Me.PoisonPanel2.Name = "PoisonPanel2"
        Me.PoisonPanel2.Size = New System.Drawing.Size(672, 482)
        Me.PoisonPanel2.TabIndex = 2
        Me.PoisonPanel2.VerticalScrollbarBarColor = True
        Me.PoisonPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.VerticalScrollbarSize = 10
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PoisonLabel1.Location = New System.Drawing.Point(340, 73)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(123, 19)
        Me.PoisonLabel1.TabIndex = 3
        Me.PoisonLabel1.Text = "🚗 New Car Rental"
        Me.PoisonLabel1.UseCustomForeColor = True
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(641, 73)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(113, 19)
        Me.PoisonLabel2.TabIndex = 4
        Me.PoisonLabel2.Text = "📋 Rental History"
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
        Me.txtSearch.Location = New System.Drawing.Point(500, 73)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search rentals..."
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(218, 23)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search rentals..."
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PoisonLabel5
        '
        Me.PoisonLabel5.AutoSize = True
        Me.PoisonLabel5.Location = New System.Drawing.Point(431, 77)
        Me.PoisonLabel5.Name = "PoisonLabel5"
        Me.PoisonLabel5.Size = New System.Drawing.Size(71, 19)
        Me.PoisonLabel5.TabIndex = 6
        Me.PoisonLabel5.Text = "🔍 Search"
        '
        'PoisonTile1
        '
        Me.PoisonTile1.ActiveControl = Nothing
        Me.PoisonTile1.Location = New System.Drawing.Point(23, 743)
        Me.PoisonTile1.Name = "PoisonTile1"
        Me.PoisonTile1.Size = New System.Drawing.Size(250, 50)
        Me.PoisonTile1.TabIndex = 7
        Me.PoisonTile1.Text = "Total Rentals: 0"
        Me.PoisonTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PoisonTile1.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(291, 743)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "🔄 Clear"
        Me.btnClear.UseSelectable = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(290, 615)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 35)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "↻ Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(290, 681)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 35)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "← Back"
        Me.btnBack.UseSelectable = True
        '
        'lblRentDate
        '
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Location = New System.Drawing.Point(15, 246)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(76, 19)
        Me.lblRentDate.TabIndex = 3
        Me.lblRentDate.Text = "Rental Date"
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Location = New System.Drawing.Point(15, 156)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(46, 19)
        Me.lblCustomerPhone.TabIndex = 10
        Me.lblCustomerPhone.Text = "Phone"
        '
        'PoisonLabel4
        '
        Me.PoisonLabel4.AutoSize = True
        Me.PoisonLabel4.Location = New System.Drawing.Point(116, 156)
        Me.PoisonLabel4.Name = "PoisonLabel4"
        Me.PoisonLabel4.Size = New System.Drawing.Size(108, 19)
        Me.PoisonLabel4.TabIndex = 9
        Me.PoisonLabel4.Text = "Customer Details"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(109, 203)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(126, 19)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Select customer first"
        '
        'lblCarInfo
        '
        Me.lblCarInfo.AutoSize = True
        Me.lblCarInfo.Location = New System.Drawing.Point(15, 203)
        Me.lblCarInfo.Name = "lblCarInfo"
        Me.lblCarInfo.Size = New System.Drawing.Size(90, 19)
        Me.lblCarInfo.TabIndex = 14
        Me.lblCarInfo.Text = "Select car first"
        '
        'FrmRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 805)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PoisonTile1)
        Me.Controls.Add(Me.PoisonLabel5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PoisonLabel2)
        Me.Controls.Add(Me.PoisonLabel1)
        Me.Controls.Add(Me.PoisonPanel2)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.Name = "FrmRequests"
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.Text = "Car Rental - Car Rental Management"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.PoisonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents dgvRentals As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonPanel2 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents lblCar As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblReturnDate As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents cbCar As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents cbCustomer As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents dtRentDate As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents dtReturnDate As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents btnCalculate As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRent As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents lblFee As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtSearch As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonTile1 As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents btnClear As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents lblDays As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel6 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel8 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblRentDate As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCarInfo As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCustomerPhone As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel4 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCustomerName As ReaLTaiizor.Controls.PoisonLabel
End Class
