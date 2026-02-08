<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRental
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.dgvRentals = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.lblCar = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblDate = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblFee = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblName = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblReturn = New ReaLTaiizor.Controls.PoisonLabel()
        Me.cbCar = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.cbCust = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.dtReturn = New System.Windows.Forms.DateTimePicker()
        Me.btnCalculate = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnRent = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        '
        'dgvRentals
        '
        Me.dgvRentals.AllowUserToResizeRows = False
        Me.dgvRentals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentals.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRentals.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvRentals.EnableHeadersVisualStyles = False
        Me.dgvRentals.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentals.Location = New System.Drawing.Point(330, 60)
        Me.dgvRentals.Name = "dgvRentals"
        Me.dgvRentals.ReadOnly = True
        Me.dgvRentals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentals.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRentals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentals.Size = New System.Drawing.Size(450, 370)
        Me.dgvRentals.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.dgvRentals.TabIndex = 0
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Location = New System.Drawing.Point(38, 103)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(72, 19)
        Me.lblCar.TabIndex = 1
        Me.lblCar.Text = "Select Car:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(25, 237)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(79, 19)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Rental Date:"
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(163, 103)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(104, 19)
        Me.PoisonLabel3.TabIndex = 3
        Me.PoisonLabel3.Text = "Select Customer"
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Location = New System.Drawing.Point(28, 329)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(97, 19)
        Me.lblFee.TabIndex = 3
        Me.lblFee.Text = "Total Fees: 0.00"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(25, 203)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 19)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Customer Name: "
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Location = New System.Drawing.Point(25, 280)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(85, 19)
        Me.lblReturn.TabIndex = 3
        Me.lblReturn.Text = "Return Date: "
        '
        'cbCar
        '
        Me.cbCar.FormattingEnabled = True
        Me.cbCar.ItemHeight = 23
        Me.cbCar.Location = New System.Drawing.Point(23, 137)
        Me.cbCar.Name = "cbCar"
        Me.cbCar.Size = New System.Drawing.Size(121, 29)
        Me.cbCar.TabIndex = 4
        Me.cbCar.UseSelectable = True
        '
        'cbCust
        '
        Me.cbCust.FormattingEnabled = True
        Me.cbCust.ItemHeight = 23
        Me.cbCust.Location = New System.Drawing.Point(180, 137)
        Me.cbCust.Name = "cbCust"
        Me.cbCust.Size = New System.Drawing.Size(121, 29)
        Me.cbCust.TabIndex = 5
        Me.cbCust.UseSelectable = True
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(116, 236)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(200, 20)
        Me.dtDate.TabIndex = 6
        '
        'dtReturn
        '
        Me.dtReturn.Location = New System.Drawing.Point(116, 280)
        Me.dtReturn.Name = "dtReturn"
        Me.dtReturn.Size = New System.Drawing.Size(200, 20)
        Me.dtReturn.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(95, 372)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(138, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Fee"
        Me.btnCalculate.UseSelectable = True
        '
        'btnRent
        '
        Me.btnRent.Location = New System.Drawing.Point(58, 416)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(112, 23)
        Me.btnRent.TabIndex = 8
        Me.btnRent.Text = "CONFIRM RENTAL"
        Me.btnRent.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(208, 416)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseSelectable = True
        '
        'FrmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.dtReturn)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.cbCust)
        Me.Controls.Add(Me.cbCar)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.PoisonLabel3)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.dgvRentals)
        Me.Name = "FrmRental"
        Me.Text = "NEW RENTAL BOOKING"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents dgvRentals As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents lblReturn As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblName As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblFee As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblDate As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblCar As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRent As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnCalculate As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents dtReturn As DateTimePicker
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents cbCust As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents cbCar As ReaLTaiizor.Controls.PoisonComboBox
End Class
