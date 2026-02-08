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
        Me.lblTitle = New ReaLTaiizor.Controls.PoisonLabel()
        Me.txtUser = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.txtPass = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.btnLogin = New ReaLTaiizor.Controls.PoisonButton()
        Me.btnClear = New ReaLTaiizor.Controls.PoisonButton()
        Me.PoisonLabel1 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.PoisonLabel2 = New ReaLTaiizor.Controls.PoisonLabel()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall
        Me.lblTitle.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold
        Me.lblTitle.Location = New System.Drawing.Point(299, 87)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER LOGIN"
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.Lines = New String() {"..."}
        Me.txtUser.Location = New System.Drawing.Point(330, 159)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PromptText = "...."
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(182, 23)
        Me.txtUser.TabIndex = 1
        Me.txtUser.Text = "..."
        Me.txtUser.UseSelectable = True
        Me.txtUser.UseStyleColors = True
        Me.txtUser.WaterMark = "...."
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPass.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.Lines = New String() {"PoisonTextBox2"}
        Me.txtPass.Location = New System.Drawing.Point(330, 221)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PromptText = "Password"
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(182, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = "PoisonTextBox2"
        Me.txtPass.UseSelectable = True
        Me.txtPass.WaterMark = "Password"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogin
        '
        Me.btnLogin.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium
        Me.btnLogin.Location = New System.Drawing.Point(250, 285)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(116, 40)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(422, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseSelectable = True
        '
        'PoisonLabel1
        '
        Me.PoisonLabel1.AutoSize = True
        Me.PoisonLabel1.Location = New System.Drawing.Point(175, 159)
        Me.PoisonLabel1.Name = "PoisonLabel1"
        Me.PoisonLabel1.Size = New System.Drawing.Size(109, 19)
        Me.PoisonLabel1.TabIndex = 5
        Me.PoisonLabel1.Text = "Enter Username: "
        '
        'PoisonLabel2
        '
        Me.PoisonLabel2.AutoSize = True
        Me.PoisonLabel2.Location = New System.Drawing.Point(175, 221)
        Me.PoisonLabel2.Name = "PoisonLabel2"
        Me.PoisonLabel2.Size = New System.Drawing.Size(97, 19)
        Me.PoisonLabel2.TabIndex = 6
        Me.PoisonLabel2.Text = "Enter Password"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PoisonLabel2)
        Me.Controls.Add(Me.PoisonLabel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents btnClear As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents btnLogin As ReaLTaiizor.Controls.PoisonButton
    Friend WithEvents txtPass As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents txtUser As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents PoisonLabel2 As ReaLTaiizor.Controls.PoisonLabel
    Friend WithEvents PoisonLabel1 As ReaLTaiizor.Controls.PoisonLabel
End Class
