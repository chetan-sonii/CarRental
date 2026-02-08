<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.PoisonTabControl1 = New ReaLTaiizor.Controls.PoisonTabControl()
        Me.tabDashboard = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.btnlogout = New ReaLTaiizor.Controls.PoisonButton()
        Me.tileRentals = New ReaLTaiizor.Controls.PoisonTile()
        Me.PoisonTile1 = New ReaLTaiizor.Controls.PoisonTile()
        Me.tileCars = New ReaLTaiizor.Controls.PoisonTile()
        Me.tabCars = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.tabCustomers = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.tabRentals = New ReaLTaiizor.Controls.PoisonTabPage()
        Me.PoisonTabControl1.SuspendLayout()
        Me.tabDashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonTabControl1
        '
        Me.PoisonTabControl1.Controls.Add(Me.tabDashboard)
        Me.PoisonTabControl1.Controls.Add(Me.tabCars)
        Me.PoisonTabControl1.Controls.Add(Me.tabCustomers)
        Me.PoisonTabControl1.Controls.Add(Me.tabRentals)
        Me.PoisonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoisonTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.PoisonTabControl1.Name = "PoisonTabControl1"
        Me.PoisonTabControl1.SelectedIndex = 0
        Me.PoisonTabControl1.Size = New System.Drawing.Size(760, 370)
        Me.PoisonTabControl1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.PoisonTabControl1.TabIndex = 0
        Me.PoisonTabControl1.UseSelectable = True
        Me.PoisonTabControl1.UseStyleColors = True
        '
        'tabDashboard
        '
        Me.tabDashboard.Controls.Add(Me.btnlogout)
        Me.tabDashboard.Controls.Add(Me.tileRentals)
        Me.tabDashboard.Controls.Add(Me.PoisonTile1)
        Me.tabDashboard.Controls.Add(Me.tileCars)
        Me.tabDashboard.HorizontalScrollbarBarColor = True
        Me.tabDashboard.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDashboard.HorizontalScrollbarSize = 10
        Me.tabDashboard.Location = New System.Drawing.Point(4, 38)
        Me.tabDashboard.Name = "tabDashboard"
        Me.tabDashboard.Size = New System.Drawing.Size(752, 328)
        Me.tabDashboard.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Red
        Me.tabDashboard.TabIndex = 0
        Me.tabDashboard.Text = "Dashboard"
        Me.tabDashboard.VerticalScrollbarBarColor = True
        Me.tabDashboard.VerticalScrollbarHighlightOnWheel = False
        Me.tabDashboard.VerticalScrollbarSize = 10
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(597, 309)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(159, 23)
        Me.btnlogout.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Red
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseSelectable = True
        '
        'tileRentals
        '
        Me.tileRentals.ActiveControl = Nothing
        Me.tileRentals.Location = New System.Drawing.Point(19, 179)
        Me.tileRentals.Name = "tileRentals"
        Me.tileRentals.Size = New System.Drawing.Size(200, 100)
        Me.tileRentals.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Orange
        Me.tileRentals.TabIndex = 2
        Me.tileRentals.Text = "Active Rentals"
        Me.tileRentals.UseSelectable = True
        '
        'PoisonTile1
        '
        Me.PoisonTile1.ActiveControl = Nothing
        Me.PoisonTile1.Location = New System.Drawing.Point(3, 3)
        Me.PoisonTile1.Name = "PoisonTile1"
        Me.PoisonTile1.Size = New System.Drawing.Size(200, 120)
        Me.PoisonTile1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.PoisonTile1.TabIndex = 2
        Me.PoisonTile1.Text = "Available Cars"
        Me.PoisonTile1.UseSelectable = True
        '
        'tileCars
        '
        Me.tileCars.ActiveControl = Nothing
        Me.tileCars.Location = New System.Drawing.Point(233, 3)
        Me.tileCars.Name = "tileCars"
        Me.tileCars.Size = New System.Drawing.Size(150, 120)
        Me.tileCars.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.tileCars.TabIndex = 2
        Me.tileCars.Text = "Available Customers"
        Me.tileCars.UseSelectable = True
        '
        'tabCars
        '
        Me.tabCars.HorizontalScrollbarBarColor = True
        Me.tabCars.HorizontalScrollbarHighlightOnWheel = False
        Me.tabCars.HorizontalScrollbarSize = 10
        Me.tabCars.Location = New System.Drawing.Point(4, 38)
        Me.tabCars.Name = "tabCars"
        Me.tabCars.Size = New System.Drawing.Size(752, 328)
        Me.tabCars.TabIndex = 1
        Me.tabCars.Text = "Cars"
        Me.tabCars.VerticalScrollbarBarColor = True
        Me.tabCars.VerticalScrollbarHighlightOnWheel = False
        Me.tabCars.VerticalScrollbarSize = 10
        '
        'tabCustomers
        '
        Me.tabCustomers.HorizontalScrollbarBarColor = True
        Me.tabCustomers.HorizontalScrollbarHighlightOnWheel = False
        Me.tabCustomers.HorizontalScrollbarSize = 10
        Me.tabCustomers.Location = New System.Drawing.Point(4, 38)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.Size = New System.Drawing.Size(752, 328)
        Me.tabCustomers.TabIndex = 2
        Me.tabCustomers.Text = "Customers"
        Me.tabCustomers.VerticalScrollbarBarColor = True
        Me.tabCustomers.VerticalScrollbarHighlightOnWheel = False
        Me.tabCustomers.VerticalScrollbarSize = 10
        '
        'tabRentals
        '
        Me.tabRentals.HorizontalScrollbarBarColor = True
        Me.tabRentals.HorizontalScrollbarHighlightOnWheel = False
        Me.tabRentals.HorizontalScrollbarSize = 10
        Me.tabRentals.Location = New System.Drawing.Point(4, 38)
        Me.tabRentals.Name = "tabRentals"
        Me.tabRentals.Size = New System.Drawing.Size(752, 328)
        Me.tabRentals.TabIndex = 3
        Me.tabRentals.Text = "Rentals"
        Me.tabRentals.VerticalScrollbarBarColor = True
        Me.tabRentals.VerticalScrollbarHighlightOnWheel = False
        Me.tabRentals.VerticalScrollbarSize = 10
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PoisonTabControl1)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.PoisonTabControl1.ResumeLayout(False)
        Me.tabDashboard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PoisonTabControl1 As ReaLTaiizor.Controls.PoisonTabControl
    Friend WithEvents tabDashboard As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents tileCars As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents tabCars As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents tabCustomers As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents tabRentals As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents PoisonTile1 As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents tileRentals As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents btnlogout As ReaLTaiizor.Controls.PoisonButton
End Class
