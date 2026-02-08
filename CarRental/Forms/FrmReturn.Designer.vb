<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReturn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRented = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.lblFineStatus = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnRefresh = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnReturn = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnCalculate = New ReaLTaiizor.Controls.PoisonButton()
        Me.txtFine = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtDueDate = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtCustName = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtCarId = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblDelay = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblDate = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCust = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblCar = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel2 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.lblStatus = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtSearch = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        CType(Me.dgvRented, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.PoisonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRented
        '
        Me.dgvRented.AllowUserToResizeRows = False
        Me.dgvRented.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRented.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRented.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRented.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRented.ColumnHeadersHeight = 40
        Me.dgvRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRented.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRented.EnableHeadersVisualStyles = False
        Me.dgvRented.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvRented.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRented.Location = New System.Drawing.Point(15, 65)
        Me.dgvRented.Name = "dgvRented"
        Me.dgvRented.ReadOnly = True
        Me.dgvRented.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRented.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRented.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRented.RowTemplate.Height = 35
        Me.dgvRented.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRented.Size = New System.Drawing.Size(430, 345)
        Me.dgvRented.TabIndex = 0
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.lblFineStatus)
        Me.PoisonPanel1.Controls.Add(Me.btnRefresh)
        Me.PoisonPanel1.Controls.Add(Me.btnBack)
        Me.PoisonPanel1.Controls.Add(Me.btnReturn)
        Me.PoisonPanel1.Controls.Add(Me.btnCalculate)
        Me.PoisonPanel1.Controls.Add(Me.txtFine)
        Me.PoisonPanel1.Controls.Add(Me.txtDueDate)
        Me.PoisonPanel1.Controls.Add(Me.txtCustName)
        Me.PoisonPanel1.Controls.Add(Me.txtCarId)
        Me.PoisonPanel1.Controls.Add(Me.lblDelay)
        Me.PoisonPanel1.Controls.Add(Me.lblDate)
        Me.PoisonPanel1.Controls.Add(Me.lblCust)
        Me.PoisonPanel1.Controls.Add(Me.lblCar)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(465, 80)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(385, 480)
        Me.PoisonPanel1.TabIndex = 1
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'lblFineStatus
        '
        Me.lblFineStatus.AutoSize = True
        Me.lblFineStatus.Location = New System.Drawing.Point(145, 289)
        Me.lblFineStatus.Name = "lblFineStatus"
        Me.lblFineStatus.Size = New System.Drawing.Size(0, 0)
        Me.lblFineStatus.TabIndex = 15
        Me.lblFineStatus.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(145, 431)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(200, 35)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "🔄 REFRESH LIST"
        Me.btnRefresh.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(40, 431)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 35)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "← BACK"
        Me.btnBack.UseSelectable = True
        '
        'btnReturn
        '
        Me.btnReturn.Highlight = True
        Me.btnReturn.Location = New System.Drawing.Point(200, 375)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(145, 40)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "✓ CONFIRM RETURN"
        Me.btnReturn.UseSelectable = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Highlight = True
        Me.btnCalculate.Location = New System.Drawing.Point(40, 375)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 40)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "🧮 CALCULATE FINE"
        Me.btnCalculate.UseSelectable = True
        '
        'txtFine
        '
        '
        '
        '
        Me.txtFine.CustomButton.Image = Nothing
        Me.txtFine.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtFine.CustomButton.Name = ""
        Me.txtFine.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtFine.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtFine.CustomButton.TabIndex = 1
        Me.txtFine.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtFine.CustomButton.UseSelectable = True
        Me.txtFine.CustomButton.Visible = False
        Me.txtFine.Lines = New String() {"0"}
        Me.txtFine.Location = New System.Drawing.Point(145, 240)
        Me.txtFine.MaxLength = 32767
        Me.txtFine.Name = "txtFine"
        Me.txtFine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFine.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFine.SelectedText = ""
        Me.txtFine.SelectionLength = 0
        Me.txtFine.SelectionStart = 0
        Me.txtFine.ShortcutsEnabled = True
        Me.txtFine.Size = New System.Drawing.Size(200, 43)
        Me.txtFine.TabIndex = 10
        Me.txtFine.Text = "0"
        Me.txtFine.UseSelectable = True
        Me.txtFine.WaterMark = "Fine amount"
        Me.txtFine.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFine.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDueDate
        '
        '
        '
        '
        Me.txtDueDate.CustomButton.Image = Nothing
        Me.txtDueDate.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtDueDate.CustomButton.Name = ""
        Me.txtDueDate.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtDueDate.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtDueDate.CustomButton.TabIndex = 1
        Me.txtDueDate.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtDueDate.CustomButton.UseSelectable = True
        Me.txtDueDate.CustomButton.Visible = False
        Me.txtDueDate.Lines = New String(-1) {}
        Me.txtDueDate.Location = New System.Drawing.Point(145, 180)
        Me.txtDueDate.MaxLength = 32767
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDueDate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDueDate.SelectedText = ""
        Me.txtDueDate.SelectionLength = 0
        Me.txtDueDate.SelectionStart = 0
        Me.txtDueDate.ShortcutsEnabled = True
        Me.txtDueDate.Size = New System.Drawing.Size(200, 43)
        Me.txtDueDate.TabIndex = 9
        Me.txtDueDate.UseSelectable = True
        Me.txtDueDate.WaterMark = "Return due date"
        Me.txtDueDate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDueDate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCustName
        '
        '
        '
        '
        Me.txtCustName.CustomButton.Image = Nothing
        Me.txtCustName.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtCustName.CustomButton.Name = ""
        Me.txtCustName.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtCustName.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtCustName.CustomButton.TabIndex = 1
        Me.txtCustName.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtCustName.CustomButton.UseSelectable = True
        Me.txtCustName.CustomButton.Visible = False
        Me.txtCustName.Lines = New String(-1) {}
        Me.txtCustName.Location = New System.Drawing.Point(145, 120)
        Me.txtCustName.MaxLength = 32767
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCustName.SelectedText = ""
        Me.txtCustName.SelectionLength = 0
        Me.txtCustName.SelectionStart = 0
        Me.txtCustName.ShortcutsEnabled = True
        Me.txtCustName.Size = New System.Drawing.Size(200, 43)
        Me.txtCustName.TabIndex = 8
        Me.txtCustName.UseSelectable = True
        Me.txtCustName.WaterMark = "Customer name"
        Me.txtCustName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCustName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCarId
        '
        '
        '
        '
        Me.txtCarId.CustomButton.Image = Nothing
        Me.txtCarId.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtCarId.CustomButton.Name = ""
        Me.txtCarId.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtCarId.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtCarId.CustomButton.TabIndex = 1
        Me.txtCarId.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtCarId.CustomButton.UseSelectable = True
        Me.txtCarId.CustomButton.Visible = False
        Me.txtCarId.Lines = New String(-1) {}
        Me.txtCarId.Location = New System.Drawing.Point(145, 60)
        Me.txtCarId.MaxLength = 32767
        Me.txtCarId.Name = "txtCarId"
        Me.txtCarId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCarId.SelectedText = ""
        Me.txtCarId.SelectionLength = 0
        Me.txtCarId.SelectionStart = 0
        Me.txtCarId.ShortcutsEnabled = True
        Me.txtCarId.Size = New System.Drawing.Size(200, 43)
        Me.txtCarId.TabIndex = 7
        Me.txtCarId.UseSelectable = True
        Me.txtCarId.WaterMark = "Car registration"
        Me.txtCarId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCarId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Location = New System.Drawing.Point(40, 250)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(88, 19)
        Me.lblDelay.TabIndex = 6
        Me.lblDelay.Text = "💰 Fine (₹):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(40, 190)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 19)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "📅 Due Date:"
        '
        'lblCust
        '
        Me.lblCust.AutoSize = True
        Me.lblCust.Location = New System.Drawing.Point(40, 130)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(94, 19)
        Me.lblCust.TabIndex = 4
        Me.lblCust.Text = "👤 Customer:"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Location = New System.Drawing.Point(40, 70)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(97, 19)
        Me.lblCar.TabIndex = 3
        Me.lblCar.Text = "🚗 Car Reg #:"
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(105, 15)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(175, 25)
        Me.PoisonLabel1.TabIndex = 2
        Me.PoisonLabel1.Text = "📋 Return Details"
        Me.PoisonLabel1.UseStyleColors = True
        '
        'PoisonPanel2
        '
        Me.PoisonPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel2.Controls.Add(Me.lblStatus)
        Me.PoisonPanel2.Controls.Add(Me.txtSearch)
        Me.PoisonPanel2.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel2.Controls.Add(Me.dgvRented)
        Me.PoisonPanel2.HorizontalScrollbarBarColor = True
        Me.PoisonPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.HorizontalScrollbarSize = 10
        Me.PoisonPanel2.Location = New System.Drawing.Point(10, 80)
        Me.PoisonPanel2.Name = "PoisonPanel2"
        Me.PoisonPanel2.Size = New System.Drawing.Size(460, 480)
        Me.PoisonPanel2.TabIndex = 2
        Me.PoisonPanel2.VerticalScrollbarBarColor = True
        Me.PoisonPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel2.VerticalScrollbarSize = 10
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(15, 430)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(120, 15)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Total Rented Cars: 0"
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(394, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(15, 30)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(416, 23)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search by car registration or customer name..."
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(130, -3)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(200, 25)
        Me.PoisonLabel2.TabIndex = 1
        Me.PoisonLabel2.Text = "🚙 Currently Rented"
        Me.PoisonLabel2.UseStyleColors = True
        '
        'FrmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 580)
        Me.Controls.Add(Me.PoisonPanel2)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.DisplayHeader = True
        Me.MinimumSize = New System.Drawing.Size(860, 580)
        Me.Name = "FrmReturn"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Text = "CAR RETURN MANAGEMENT"
        CType(Me.dgvRented, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.PoisonPanel2.ResumeLayout(False)
        Me.PoisonPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRented As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents lblCar As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCust As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblDate As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblDelay As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtCarId As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtCustName As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtDueDate As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtFine As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnCalculate As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnReturn As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonPanel2 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtSearch As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents lblStatus As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblFineStatus As ReaLTaiizor.Controls.PoisonLabel
End Class
