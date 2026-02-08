<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.lblTitle = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtUser = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPass = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.btnLogin = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnClear = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblSubtitle = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.btnExit = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.chkShowPassword = New ReaLTaiizor.Controls.PoisonCheckBox()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(182, 90)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🚗 Car Rental Management System"
        Me.lblTitle.UseCustomForeColor = True
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtUser.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(25, 65)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(260, 33)
        Me.txtUser.TabIndex = 1
        Me.txtUser.UseSelectable = True
        Me.txtUser.WaterMark = "Enter your username"
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtPass.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(25, 145)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(260, 33)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSelectable = True
        Me.txtPass.WaterMark = "Enter your password"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogin
        '
        Me.btnLogin.Highlight = True
        Me.btnLogin.Location = New System.Drawing.Point(25, 230)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(125, 40)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "🔓 Login"
        Me.btnLogin.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 230)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "🔄 Clear"
        Me.btnClear.UseSelectable = True
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(25, 43)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(68, 19)
        Me.PoisonLabel1.TabIndex = 5
        Me.PoisonLabel1.Text = "Username"
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(25, 123)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(63, 19)
        Me.PoisonLabel2.TabIndex = 6
        Me.PoisonLabel2.Text = "Password"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Location = New System.Drawing.Point(213, 116)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(175, 19)
        Me.lblSubtitle.TabIndex = 7
        Me.lblSubtitle.Text = "Please login to your account"
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.chkShowPassword)
        Me.PoisonPanel1.Controls.Add(Me.btnExit)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.Controls.Add(Me.txtUser)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel1.Controls.Add(Me.txtPass)
        Me.PoisonPanel1.Controls.Add(Me.btnLogin)
        Me.PoisonPanel1.Controls.Add(Me.btnClear)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(145, 160)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(310, 320)
        Me.PoisonPanel1.TabIndex = 8
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(25, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(260, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "❌ Exit Application"
        Me.btnExit.UseSelectable = True
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(170, 500)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(260, 19)
        Me.PoisonLabel3.TabIndex = 9
        Me.PoisonLabel3.Text = "© 2026 Car Rental System. All rights reserved."
        Me.PoisonLabel3.UseCustomForeColor = True
        Me.PoisonLabel3.ForeColor = System.Drawing.Color.Gray
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(25, 190)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(109, 15)
        Me.chkShowPassword.TabIndex = 6
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseSelectable = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 550)
        Me.Controls.Add(Me.PoisonLabel3)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = True
        Me.Name = "FrmLogin"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Car Rental System"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents lblTitle As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnClear As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnLogin As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents txtPass As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtUser As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblSubtitle As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents btnExit As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents chkShowPassword As ReaLTaiizor.Controls.PoisonCheckBox
End Class
