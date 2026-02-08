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
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.lblLastUpdate = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnRefresh = New ReaLTaiizor.Controls.PoisonButton()
        Me.lblWelcome = New ReaLTaiizor.Controls.PoisonLabel()
        Me.tileRequests = New ReaLTaiizor.Controls.PoisonTile()
        Me.tileReturn = New ReaLTaiizor.Controls.PoisonTile()
        Me.btnlogout = New ReaLTaiizor.Controls.PoisonButton()
        Me.tileRentals = New ReaLTaiizor.Controls.PoisonTile()
        Me.tileCars = New ReaLTaiizor.Controls.PoisonTile()
        Me.tileCust = New ReaLTaiizor.Controls.PoisonTile()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.PoisonTabControl1.SuspendLayout()
        Me.tabDashboard.SuspendLayout()
        Me.PoisonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonTabControl1
        '
        Me.PoisonTabControl1.Controls.Add(Me.tabDashboard)
        Me.PoisonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoisonTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.PoisonTabControl1.Name = "PoisonTabControl1"
        Me.PoisonTabControl1.SelectedIndex = 0
        Me.PoisonTabControl1.Size = New System.Drawing.Size(960, 540)
        Me.PoisonTabControl1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.PoisonTabControl1.TabIndex = 0
        Me.PoisonTabControl1.UseSelectable = True
        Me.PoisonTabControl1.UseStyleColors = True
        '
        'tabDashboard
        '
        Me.tabDashboard.Controls.Add(Me.PoisonPanel1)
        Me.tabDashboard.Controls.Add(Me.tileRequests)
        Me.tabDashboard.Controls.Add(Me.tileReturn)
        Me.tabDashboard.Controls.Add(Me.btnlogout)
        Me.tabDashboard.Controls.Add(Me.tileRentals)
        Me.tabDashboard.Controls.Add(Me.tileCars)
        Me.tabDashboard.Controls.Add(Me.tileCust)
        Me.tabDashboard.HorizontalScrollbarBarColor = True
        Me.tabDashboard.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDashboard.HorizontalScrollbarSize = 10
        Me.tabDashboard.Location = New System.Drawing.Point(4, 38)
        Me.tabDashboard.Name = "tabDashboard"
        Me.tabDashboard.Size = New System.Drawing.Size(952, 498)
        Me.tabDashboard.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.tabDashboard.TabIndex = 0
        Me.tabDashboard.Text = "📊 Admin Dashboard"
        Me.tabDashboard.VerticalScrollbarBarColor = True
        Me.tabDashboard.VerticalScrollbarHighlightOnWheel = False
        Me.tabDashboard.VerticalScrollbarSize = 10
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.lblLastUpdate)
        Me.PoisonPanel1.Controls.Add(Me.btnRefresh)
        Me.PoisonPanel1.Controls.Add(Me.lblWelcome)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(15, 15)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(920, 60)
        Me.PoisonPanel1.TabIndex = 5
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Location = New System.Drawing.Point(15, 35)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(151, 19)
        Me.lblLastUpdate.TabIndex = 2
        Me.lblLastUpdate.Text = "Last Updated: --:--:-- --"
        '
        'btnRefresh
        '
        Me.btnRefresh.Highlight = True
        Me.btnRefresh.Location = New System.Drawing.Point(795, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 30)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "🔄 REFRESH"
        Me.btnRefresh.UseSelectable = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(15, 10)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(137, 19)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Admin! 👋"
        Me.lblWelcome.UseStyleColors = True
        '
        'tileRequests
        '
        Me.tileRequests.ActiveControl = Nothing
        Me.tileRequests.Location = New System.Drawing.Point(15, 292)
        Me.tileRequests.Name = "tileRequests"
        Me.tileRequests.Size = New System.Drawing.Size(280, 150)
        Me.tileRequests.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Purple
        Me.tileRequests.TabIndex = 4
        Me.tileRequests.Text = "📋 Pending Requests"
        Me.tileRequests.UseSelectable = True
        Me.tileRequests.UseTileImage = True
        '
        'tileReturn
        '
        Me.tileReturn.ActiveControl = Nothing
        Me.tileReturn.Location = New System.Drawing.Point(655, 95)
        Me.tileReturn.Name = "tileReturn"
        Me.tileReturn.Size = New System.Drawing.Size(280, 150)
        Me.tileReturn.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Red
        Me.tileReturn.TabIndex = 3
        Me.tileReturn.Text = "🔙 Return Car"
        Me.tileReturn.UseSelectable = True
        Me.tileReturn.UseTileImage = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(811, 402)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(130, 30)
        Me.btnlogout.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Red
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.Text = "🚪 LOGOUT"
        Me.btnlogout.UseSelectable = True
        '
        'tileRentals
        '
        Me.tileRentals.ActiveControl = Nothing
        Me.tileRentals.Location = New System.Drawing.Point(334, 292)
        Me.tileRentals.Name = "tileRentals"
        Me.tileRentals.Size = New System.Drawing.Size(280, 150)
        Me.tileRentals.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Orange
        Me.tileRentals.TabIndex = 2
        Me.tileRentals.Text = "🚗 Active Rentals"
        Me.tileRentals.UseSelectable = True
        Me.tileRentals.UseTileImage = True
        '
        'tileCars
        '
        Me.tileCars.ActiveControl = Nothing
        Me.tileCars.Location = New System.Drawing.Point(15, 95)
        Me.tileCars.Name = "tileCars"
        Me.tileCars.Size = New System.Drawing.Size(280, 150)
        Me.tileCars.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.tileCars.TabIndex = 2
        Me.tileCars.Text = "🚙 Available Cars"
        Me.tileCars.UseSelectable = True
        Me.tileCars.UseTileImage = True
        '
        'tileCust
        '
        Me.tileCust.ActiveControl = Nothing
        Me.tileCust.Location = New System.Drawing.Point(334, 95)
        Me.tileCust.Name = "tileCust"
        Me.tileCust.Size = New System.Drawing.Size(280, 150)
        Me.tileCust.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.tileCust.TabIndex = 2
        Me.tileCust.Text = "👥 Total Customers"
        Me.tileCust.UseSelectable = True
        Me.tileCust.UseTileImage = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 620)
        Me.Controls.Add(Me.PoisonTabControl1)
        Me.MinimumSize = New System.Drawing.Size(1000, 620)
        Me.Name = "FrmMain"
        Me.Text = "CAR RENTAL MANAGEMENT SYSTEM - ADMIN PANEL"
        Me.PoisonTabControl1.ResumeLayout(False)
        Me.tabDashboard.ResumeLayout(False)
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PoisonTabControl1 As ReaLTaiizor.Controls.PoisonTabControl
    Friend WithEvents tabDashboard As ReaLTaiizor.Controls.PoisonTabPage
    Friend WithEvents tileCust As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents tileCars As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents tileRentals As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents btnlogout As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents tileReturn As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents tileRequests As ReaLTaiizor.Controls.PoisonTile
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents lblWelcome As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents lblLastUpdate As ReaLTaiizor.Controls.PoisonLabel
End Class
