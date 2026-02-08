<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegister
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
        Me.PoisonStyleManager1 = New ReaLTaiizor.Manager.PoisonStyleManager(Me.components)
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel3 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel4 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.btnRegister = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnBack = New ReaLTaiizor.Controls.PoisonButton()
        Me.txtName = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPass = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPhone = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtEmail = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.label = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtConfirm = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.PoisonLabel5 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtAddress = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblTitle = New ReaLTaiizor.Controls.PoisonLabel()
        Me.lblSubtitle = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonPanel1 = New ReaLTaiizor.Controls.PoisonPanel()
        Me.chkShowPassword = New ReaLTaiizor.Controls.PoisonCheckBox()
        Me.lblPasswordStrength = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonProgressBar1 = New ReaLTaiizor.Controls.PoisonProgressBar()
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoisonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PoisonStyleManager1
        '
        Me.PoisonStyleManager1.Owner = Me
        Me.PoisonStyleManager1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(40, 20)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(69, 19)
        Me.PoisonLabel1.TabIndex = 0
        Me.PoisonLabel1.Text = "Full Name"
        Me.PoisonLabel1.UseStyleColors = True
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(40, 90)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(63, 19)
        Me.PoisonLabel2.TabIndex = 1
        Me.PoisonLabel2.Text = "Password"
        Me.PoisonLabel2.UseStyleColors = True
        '
        'PoisonLabel3
        '
        Me.PoisonLabel3.AutoSize = True
        Me.PoisonLabel3.Location = New System.Drawing.Point(40, 230)
        Me.PoisonLabel3.Name = "PoisonLabel3"
        Me.PoisonLabel3.Size = New System.Drawing.Size(99, 19)
        Me.PoisonLabel3.TabIndex = 2
        Me.PoisonLabel3.Text = "Phone Number"
        Me.PoisonLabel3.UseStyleColors = True
        '
        'PoisonLabel4
        '
        Me.PoisonLabel4.AutoSize = True
        Me.PoisonLabel4.Location = New System.Drawing.Point(40, 300)
        Me.PoisonLabel4.Name = "PoisonLabel4"
        Me.PoisonLabel4.Size = New System.Drawing.Size(92, 19)
        Me.PoisonLabel4.TabIndex = 3
        Me.PoisonLabel4.Text = "Email Address"
        Me.PoisonLabel4.UseStyleColors = True
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Highlight = True
        Me.btnRegister.Location = New System.Drawing.Point(162, 453)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(280, 40)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "CREATE ACCOUNT"
        Me.btnRegister.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Location = New System.Drawing.Point(340, 452)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(280, 40)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "BACK TO LOGIN"
        Me.btnBack.UseSelectable = True
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(40, 45)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PromptText = "Enter your full name"
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(560, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMark = "Enter your full name"
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(40, 115)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.PromptText = "Enter a strong password"
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(560, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMark = "Enter a strong password"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPhone
        '
        '
        '
        '
        Me.txtPhone.CustomButton.Image = Nothing
        Me.txtPhone.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtPhone.CustomButton.Name = ""
        Me.txtPhone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhone.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPhone.CustomButton.TabIndex = 1
        Me.txtPhone.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPhone.CustomButton.UseSelectable = True
        Me.txtPhone.CustomButton.Visible = False
        Me.txtPhone.Lines = New String(-1) {}
        Me.txtPhone.Location = New System.Drawing.Point(40, 255)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PromptText = "e.g., +91 9876543210"
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.SelectionLength = 0
        Me.txtPhone.SelectionStart = 0
        Me.txtPhone.ShortcutsEnabled = True
        Me.txtPhone.Size = New System.Drawing.Size(560, 23)
        Me.txtPhone.TabIndex = 5
        Me.txtPhone.UseSelectable = True
        Me.txtPhone.WaterMark = "e.g., +91 9876543210"
        Me.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(40, 325)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "your.email@example.com"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(560, 23)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "your.email@example.com"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(40, 160)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(115, 19)
        Me.label.TabIndex = 10
        Me.label.Text = "Confirm Password"
        Me.label.UseStyleColors = True
        '
        'txtConfirm
        '
        '
        '
        '
        Me.txtConfirm.CustomButton.Image = Nothing
        Me.txtConfirm.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtConfirm.CustomButton.Name = ""
        Me.txtConfirm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtConfirm.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtConfirm.CustomButton.TabIndex = 1
        Me.txtConfirm.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtConfirm.CustomButton.UseSelectable = True
        Me.txtConfirm.CustomButton.Visible = False
        Me.txtConfirm.Lines = New String(-1) {}
        Me.txtConfirm.Location = New System.Drawing.Point(40, 185)
        Me.txtConfirm.MaxLength = 50
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirm.PromptText = "Re-enter your password"
        Me.txtConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirm.SelectedText = ""
        Me.txtConfirm.SelectionLength = 0
        Me.txtConfirm.SelectionStart = 0
        Me.txtConfirm.ShortcutsEnabled = True
        Me.txtConfirm.Size = New System.Drawing.Size(560, 23)
        Me.txtConfirm.TabIndex = 3
        Me.txtConfirm.UseSelectable = True
        Me.txtConfirm.UseSystemPasswordChar = True
        Me.txtConfirm.WaterMark = "Re-enter your password"
        Me.txtConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PoisonLabel5
        '
        Me.PoisonLabel5.AutoSize = True
        Me.PoisonLabel5.Location = New System.Drawing.Point(40, 365)
        Me.PoisonLabel5.Name = "PoisonLabel5"
        Me.PoisonLabel5.Size = New System.Drawing.Size(56, 19)
        Me.PoisonLabel5.TabIndex = 12
        Me.PoisonLabel5.Text = "Address"
        Me.PoisonLabel5.UseStyleColors = True
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(514, 1)
        Me.txtAddress.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.txtAddress.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(40, 390)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PromptText = "Enter your complete address"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(560, 47)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMark = "Enter your complete address"
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblTitle
        '
        Me.lblTitle.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall
        Me.lblTitle.Location = New System.Drawing.Point(50, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(272, 24)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Create Your Account"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Location = New System.Drawing.Point(50, 110)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(278, 19)
        Me.lblSubtitle.TabIndex = 15
        Me.lblSubtitle.Text = "Join us today! Fill in your details to get started"
        '
        'PoisonPanel1
        '
        Me.PoisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoisonPanel1.Controls.Add(Me.btnRegister)
        Me.PoisonPanel1.Controls.Add(Me.chkShowPassword)
        Me.PoisonPanel1.Controls.Add(Me.lblPasswordStrength)
        Me.PoisonPanel1.Controls.Add(Me.PoisonProgressBar1)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel1)
        Me.PoisonPanel1.Controls.Add(Me.txtName)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel2)
        Me.PoisonPanel1.Controls.Add(Me.txtPass)
        Me.PoisonPanel1.Controls.Add(Me.label)
        Me.PoisonPanel1.Controls.Add(Me.txtConfirm)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel5)
        Me.PoisonPanel1.Controls.Add(Me.txtAddress)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel3)
        Me.PoisonPanel1.Controls.Add(Me.txtPhone)
        Me.PoisonPanel1.Controls.Add(Me.PoisonLabel4)
        Me.PoisonPanel1.Controls.Add(Me.txtEmail)
        Me.PoisonPanel1.HorizontalScrollbarBarColor = True
        Me.PoisonPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.HorizontalScrollbarSize = 10
        Me.PoisonPanel1.Location = New System.Drawing.Point(50, 150)
        Me.PoisonPanel1.Name = "PoisonPanel1"
        Me.PoisonPanel1.Size = New System.Drawing.Size(640, 520)
        Me.PoisonPanel1.TabIndex = 16
        Me.PoisonPanel1.VerticalScrollbarBarColor = True
        Me.PoisonPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.PoisonPanel1.VerticalScrollbarSize = 10
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShowPassword.Location = New System.Drawing.Point(40, 215)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(105, 15)
        Me.chkShowPassword.TabIndex = 17
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseSelectable = True
        '
        'lblPasswordStrength
        '
        Me.lblPasswordStrength.AutoSize = True
        Me.lblPasswordStrength.Location = New System.Drawing.Point(480, 143)
        Me.lblPasswordStrength.Name = "lblPasswordStrength"
        Me.lblPasswordStrength.Size = New System.Drawing.Size(0, 0)
        Me.lblPasswordStrength.TabIndex = 16
        '
        'PoisonProgressBar1
        '
        Me.PoisonProgressBar1.Location = New System.Drawing.Point(40, 143)
        Me.PoisonProgressBar1.Name = "PoisonProgressBar1"
        Me.PoisonProgressBar1.Size = New System.Drawing.Size(420, 10)
        Me.PoisonProgressBar1.TabIndex = 15
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 700)
        Me.Controls.Add(Me.PoisonPanel1)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.DisplayHeader = False
        Me.Name = "FrmRegister"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = ReaLTaiizor.[Enum].Poison.FormShadowType.AeroShadow
        Me.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Green
        Me.Text = "User Registration"
        CType(Me.PoisonStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoisonPanel1.ResumeLayout(False)
        Me.PoisonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoisonStyleManager1 As ReaLTaiizor.Manager.PoisonStyleManager
    Friend WithEvents txtEmail As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtPhone As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtPass As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtName As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnBack As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnRegister As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents PoisonLabel4 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel3 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtConfirm As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents label As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel5 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents txtAddress As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblTitle As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents lblSubtitle As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonPanel1 As ReaLTaiizor.Controls.PoisonPanel
    Friend WithEvents PoisonProgressBar1 As ReaLTaiizor.Controls.PoisonProgressBar
    Friend WithEvents lblPasswordStrength As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents chkShowPassword As ReaLTaiizor.Controls.PoisonCheckBox
End Class
