<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequests
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReturnRequests = New ReaLTaiizor.Controls.PoisonDataGridView()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnConfirmReturn = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnApproveRent = New ReaLTaiizor.Controls.PoisonButton()
        Me.dgvRentRequests = New ReaLTaiizor.Controls.PoisonDataGridView()
        CType(Me.dgvReturnRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReturnRequests
        '
        Me.dgvReturnRequests.AllowUserToResizeRows = False
        Me.dgvReturnRequests.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReturnRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReturnRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReturnRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReturnRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReturnRequests.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReturnRequests.EnableHeadersVisualStyles = False
        Me.dgvReturnRequests.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvReturnRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReturnRequests.Location = New System.Drawing.Point(67, 283)
        Me.dgvReturnRequests.Name = "dgvReturnRequests"
        Me.dgvReturnRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnRequests.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReturnRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReturnRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnRequests.Size = New System.Drawing.Size(687, 102)
        Me.dgvReturnRequests.TabIndex = 1
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(57, 62)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(100, 19)
        Me.PoisonLabel1.TabIndex = 2
        Me.PoisonLabel1.Text = "Rental Requests"
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(67, 244)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(102, 19)
        Me.PoisonLabel2.TabIndex = 3
        Me.PoisonLabel2.Text = "Return Requests"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(600, 416)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(126, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = """Back"
        Me.btnBack.UseSelectable = True
        '
        'btnConfirmReturn
        '
        Me.btnConfirmReturn.Location = New System.Drawing.Point(107, 416)
        Me.btnConfirmReturn.Name = "btnConfirmReturn"
        Me.btnConfirmReturn.Size = New System.Drawing.Size(149, 23)
        Me.btnConfirmReturn.TabIndex = 5
        Me.btnConfirmReturn.Text = "Confirm Return"
        Me.btnConfirmReturn.UseSelectable = True
        '
        'btnApproveRent
        '
        Me.btnApproveRent.Location = New System.Drawing.Point(107, 218)
        Me.btnApproveRent.Name = "btnApproveRent"
        Me.btnApproveRent.Size = New System.Drawing.Size(96, 23)
        Me.btnApproveRent.TabIndex = 6
        Me.btnApproveRent.Text = "Approve Rent"
        Me.btnApproveRent.UseSelectable = True
        '
        'dgvRentRequests
        '
        Me.dgvRentRequests.AllowUserToResizeRows = False
        Me.dgvRentRequests.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRentRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRentRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentRequests.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRentRequests.EnableHeadersVisualStyles = False
        Me.dgvRentRequests.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvRentRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRentRequests.Location = New System.Drawing.Point(57, 103)
        Me.dgvRentRequests.Name = "dgvRentRequests"
        Me.dgvRentRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentRequests.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRentRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRentRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentRequests.Size = New System.Drawing.Size(687, 97)
        Me.dgvRentRequests.TabIndex = 7
        '
        'FrmRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnApproveRent)
        Me.Controls.Add(Me.btnConfirmReturn)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PoisonLabel2)
        Me.Controls.Add(Me.PoisonLabel1)
        Me.Controls.Add(Me.dgvReturnRequests)
        Me.Controls.Add(Me.dgvRentRequests)
        Me.Name = "FrmRequests"
        Me.Text = "FrmRequests"
        CType(Me.dgvReturnRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRentRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReturnRequests As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnConfirmReturn As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnApproveRent As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents dgvRentRequests As ReaLTaiizor.Controls.PoisonDataGridView
End Class
