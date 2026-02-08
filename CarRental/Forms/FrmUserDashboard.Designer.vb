<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserDashboard
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.PoisonTabControl1 = New ReaLTaiizor.Controls.PoisonTabControl()
        Me.tabRent = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.lblCarDetails = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblSelectedCar = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnRefreshCars = New ReaLTaiizor.Controls.PoisonButton()
        Me.txtSearchCar = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnBook = New ReaLTaiizor.Controls.PoisonButton()
        Me.dgvAvailable = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.tabHistory = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.PoisonPanel2 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.lblRentalInfo = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblTotalCost = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnRefreshRentals = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnReturn = New ReaLTaiizor.Controls.PoisonButton()
        Me.dgvMyRentals = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.lblWelcome = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnLogout = New ReaLTaiizor.Controls.PoisonButton()
        Me.lblUserEmail = New ReaLTaiizor.Controls.PoisonLabel()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonTabControl1.SuspendLayout()
        Me.tabRent.SuspendLayout()
        Me.PoisonPanel1.SuspendLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        Me.PoisonPanel2.SuspendLayout()
        CType(Me.dgvMyRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        Me.PoisonStyleManager1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.PoisonStyleManager1.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        '
        'PoisonTabControl1
        '
        Me.PoisonTabControl1.Controls.Add(Me.tabRent)
        Me.PoisonTabControl1.Controls.Add(Me.tabHistory)
        Me.PoisonTabControl1.Location = New System.Drawing.Point(23, 120)
        Me.PoisonTabControl1.Name = "PoisonTabControl1"
        Me.PoisonTabControl1.SelectedIndex = 0
        Me.PoisonTabControl1.Size = New System.Drawing.Size(1155, 580)
        Me.PoisonTabControl1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.PoisonTabControl1.TabIndex = 0
        Me.PoisonTabControl1.UseSelectable = True
        '
        'tabRent
        '
        Me.tabRent.Controls.Add(Me.PoisonPanel1)
        Me.tabRent.Controls.Add(Me.dgvAvailable)
        Me.tabRent.HorizontalScrollbarBarColor = True
        Me.tabRent.HorizontalScrollbarHighlightOnWheel = False
        Me.tabRent.HorizontalScrollbarSize = 10
        Me.tabRent.Location = New System.Drawing.Point(4, 38)
        Me.tabRent.Name = "tabRent"
        Me.tabRent.Size = New System.Drawing.Size(1147, 538)
        Me.tabRent.TabIndex = 0
        Me.tabRent.Text = "   Browse Available Cars   "
        Me.tabRent.VerticalScrollbarBarColor = True
        Me.tabRent.VerticalScrollbarHighlightOnWheel = False
        Me.tabRent.VerticalScrollbarSize = 10
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.lblCarDetails)
        Me.PoisonPanel1.Controls.Add(Me.lblSelectedCar)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel3)
        Me.PoisonPanel1.Controls.Add(Me.btnRefreshCars)
        Me.PoisonPanel1.Controls.Add(Me.txtSearchCar)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.Controls.Add(Me.btnBook)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(15, 15)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(280, 505)
        Me.PoisonPanel1.TabIndex = 3
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'lblCarDetails
        '
        Me.lblCarDetails.AutoSize = True
        Me.lblCarDetails.Location = New System.Drawing.Point(15, 220)
        Me.lblCarDetails.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblCarDetails.Name = "lblCarDetails"
        Me.lblCarDetails.Size = New System.Drawing.Size(238, 57)
        Me.lblCarDetails.TabIndex = 8
        Me.lblCarDetails.Text = "Select a car from the grid to view" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "detailed information including:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Price per day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Availabili" &
    "ty status"
        Me.lblCarDetails.WrapToLine = True
        '
        'lblSelectedCar
        '
        Me.lblSelectedCar.AutoSize = True

        Me.lblSelectedCar.Location = New System.Drawing.Point(15, 190)
        Me.lblSelectedCar.Name = "lblSelectedCar"
        Me.lblSelectedCar.Size = New System.Drawing.Size(111, 19)
        Me.lblSelectedCar.TabIndex = 7
        Me.lblSelectedCar.Text = "No car selected"
        Me.lblSelectedCar.UseStyleColors = True
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True

        Me.PoisonLabel3.Location = New System.Drawing.Point(15, 160)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(124, 19)
        Me.PoisonLabel3.TabIndex = 6
        Me.PoisonLabel3.Text = "Selected Vehicle:"
        '
        'btnRefreshCars
        '
        Me.btnRefreshCars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshCars.Location = New System.Drawing.Point(15, 110)
        Me.btnRefreshCars.Name = "btnRefreshCars"
        Me.btnRefreshCars.Size = New System.Drawing.Size(250, 35)
        Me.btnRefreshCars.TabIndex = 5
        Me.btnRefreshCars.Text = "🔄 Refresh Car List"
        Me.btnRefreshCars.UseSelectable = True
        '
        'txtSearchCar
        '
        '
        '
        '
        Me.txtSearchCar.CustomButton.Image = Nothing
        Me.txtSearchCar.CustomButton.Location = New System.Drawing.Point(224, 1)
        Me.txtSearchCar.CustomButton.Name = ""
        Me.txtSearchCar.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSearchCar.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtSearchCar.CustomButton.TabIndex = 1
        Me.txtSearchCar.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtSearchCar.CustomButton.UseSelectable = True
        Me.txtSearchCar.CustomButton.Visible = False
        Me.txtSearchCar.Lines = New String(-1) {}
        Me.txtSearchCar.Location = New System.Drawing.Point(15, 70)
        Me.txtSearchCar.MaxLength = 32767
        Me.txtSearchCar.Name = "txtSearchCar"
        Me.txtSearchCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchCar.SelectedText = ""
        Me.txtSearchCar.SelectionLength = 0
        Me.txtSearchCar.SelectionStart = 0
        Me.txtSearchCar.ShortcutsEnabled = True
        Me.txtSearchCar.Size = New System.Drawing.Size(248, 25)
        Me.txtSearchCar.TabIndex = 4
        Me.txtSearchCar.UseSelectable = True
        Me.txtSearchCar.WaterMark = "Search by brand, model, type..."
        Me.txtSearchCar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchCar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True

        Me.PoisonLabel1.Location = New System.Drawing.Point(15, 15)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(107, 25)
        Me.PoisonLabel1.TabIndex = 1
        Me.PoisonLabel1.Text = "Search Car"
        Me.PoisonLabel1.UseStyleColors = True
        '
        'btnBook
        '
        Me.btnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBook.Highlight = True
        Me.btnBook.Location = New System.Drawing.Point(15, 450)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(250, 40)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "📅 BOOK SELECTED CAR"
        Me.btnBook.UseSelectable = True
        '
        'dgvAvailable
        '
        Me.dgvAvailable.AllowUserToAddRows = False
        Me.dgvAvailable.AllowUserToDeleteRows = False
        Me.dgvAvailable.AllowUserToResizeRows = False
        Me.dgvAvailable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAvailable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAvailable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAvailable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAvailable.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAvailable.EnableHeadersVisualStyles = False
        Me.dgvAvailable.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvAvailable.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAvailable.Location = New System.Drawing.Point(310, 15)
        Me.dgvAvailable.MultiSelect = False
        Me.dgvAvailable.Name = "dgvAvailable"
        Me.dgvAvailable.ReadOnly = True
        Me.dgvAvailable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAvailable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAvailable.RowHeadersVisible = False
        Me.dgvAvailable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAvailable.Size = New System.Drawing.Size(820, 505)
        Me.dgvAvailable.TabIndex = 2
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.PoisonPanel2)
        Me.tabHistory.Controls.Add(Me.dgvMyRentals)
        Me.tabHistory.HorizontalScrollbarBarColor = True
        Me.tabHistory.HorizontalScrollbarHighlightOnWheel = False
        Me.tabHistory.HorizontalScrollbarSize = 10
        Me.tabHistory.Location = New System.Drawing.Point(4, 38)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Size = New System.Drawing.Size(1147, 538)
        Me.tabHistory.TabIndex = 1
        Me.tabHistory.Text = "   My Rental History   "
        Me.tabHistory.VerticalScrollbarBarColor = True
        Me.tabHistory.VerticalScrollbarHighlightOnWheel = False
        Me.tabHistory.VerticalScrollbarSize = 10
        '
        'PoisonPanel2
        '
        Me.PoisonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel2.Controls.Add(Me.lblRentalInfo)
        Me.PoisonPanel2.Controls.Add(Me.lblTotalCost)
        Me.PoisonPanel2.Controls.Add(Me.PoisonLabel5)
        Me.PoisonPanel2.Controls.Add(Me.btnRefreshRentals)
        Me.PoisonPanel2.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel2.Controls.Add(Me.btnReturn)
        Me.PoisonPanel2.HorizontalScrollbarBarColor = True
        Me.PoisonPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.HorizontalScrollbarSize = 10
        Me.PoisonPanel2.Location = New System.Drawing.Point(15, 15)
        Me.PoisonPanel2.Name = "PoisonPanel2"
        Me.PoisonPanel2.Size = New System.Drawing.Size(280, 505)
        Me.PoisonPanel2.TabIndex = 4
        Me.PoisonPanel2.VerticalScrollbarBarColor = True
        Me.PoisonPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.VerticalScrollbarSize = 10
        '
        'lblRentalInfo
        '
        Me.lblRentalInfo.AutoSize = True
        Me.lblRentalInfo.Location = New System.Drawing.Point(15, 160)
        Me.lblRentalInfo.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblRentalInfo.Name = "lblRentalInfo"
        Me.lblRentalInfo.Size = New System.Drawing.Size(241, 95)
        Me.lblRentalInfo.TabIndex = 8
        Me.lblRentalInfo.Text = "Select a rental from the grid to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• View rental details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Check return status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Calculate t" &
    "otal cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Return the vehicle"
        Me.lblRentalInfo.WrapToLine = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True

        Me.lblTotalCost.Location = New System.Drawing.Point(15, 130)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(87, 19)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Total: ₹0.00"
        Me.lblTotalCost.UseStyleColors = True
        '
        'PoisonLabel5
        '
        Me.PoisonLabel5.AutoSize = True

        Me.PoisonLabel5.Location = New System.Drawing.Point(15, 100)
        Me.PoisonLabel5.Name = "PoisonLabel5"
        Me.PoisonLabel5.Size = New System.Drawing.Size(86, 19)
        Me.PoisonLabel5.TabIndex = 6
        Me.PoisonLabel5.Text = "Rental Cost:"
        '
        'btnRefreshRentals
        '
        Me.btnRefreshRentals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshRentals.Location = New System.Drawing.Point(15, 50)
        Me.btnRefreshRentals.Name = "btnRefreshRentals"
        Me.btnRefreshRentals.Size = New System.Drawing.Size(250, 35)
        Me.btnRefreshRentals.TabIndex = 5
        Me.btnRefreshRentals.Text = "🔄 Refresh My Rentals"
        Me.btnRefreshRentals.UseSelectable = True
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True

        Me.PoisonLabel2.Location = New System.Drawing.Point(15, 15)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(122, 25)
        Me.PoisonLabel2.TabIndex = 1
        Me.PoisonLabel2.Text = "My Rentals"
        Me.PoisonLabel2.UseStyleColors = True
        '
        'btnReturn
        '
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.Highlight = True
        Me.btnReturn.Location = New System.Drawing.Point(15, 450)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(250, 40)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "🚗 RETURN SELECTED CAR"
        Me.btnReturn.UseSelectable = True
        '
        'dgvMyRentals
        '
        Me.dgvMyRentals.AllowUserToAddRows = False
        Me.dgvMyRentals.AllowUserToDeleteRows = False
        Me.dgvMyRentals.AllowUserToResizeRows = False
        Me.dgvMyRentals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMyRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMyRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMyRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMyRentals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMyRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMyRentals.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMyRentals.EnableHeadersVisualStyles = False
        Me.dgvMyRentals.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvMyRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMyRentals.Location = New System.Drawing.Point(310, 15)
        Me.dgvMyRentals.MultiSelect = False
        Me.dgvMyRentals.Name = "dgvMyRentals"
        Me.dgvMyRentals.ReadOnly = True
        Me.dgvMyRentals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMyRentals.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMyRentals.RowHeadersVisible = False
        Me.dgvMyRentals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMyRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMyRentals.Size = New System.Drawing.Size(820, 505)
        Me.dgvMyRentals.TabIndex = 2
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True

        Me.lblWelcome.Location = New System.Drawing.Point(23, 70)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(244, 25)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to Car Rental!"
        Me.lblWelcome.UseStyleColors = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Location = New System.Drawing.Point(1060, 70)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 35)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.UseSelectable = True
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(270, 76)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(0, 0)
        Me.lblUserEmail.TabIndex = 3
        '
        'FrmUserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PoisonTabControl1)
        Me.DisplayHeader = False
        Me.Name = "FrmUserDashboard"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.Text = "User Dashboard - Car Rental System"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonTabControl1.ResumeLayout(False)
        Me.tabRent.ResumeLayout(False)
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.PoisonPanel2.ResumeLayout(False)
        Me.PoisonPanel2.PerformLayout()
        CType(Me.dgvMyRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents PoisonTabControl1 As ReaLTaiizor.Controls.PoisonTabControl
    Friend WithEvents tabRent As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents dgvAvailable As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents tabHistory As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents btnBook As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents dgvMyRentals As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents btnReturn As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents lblWelcome As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnLogout As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonPanel2 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents txtSearchCar As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnRefreshCars As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRefreshRentals As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblSelectedCar As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCarDetails As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblTotalCost As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblRentalInfo As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblUserEmail As ReaLTaiizor.Controls.PoisonLabel
End Class
