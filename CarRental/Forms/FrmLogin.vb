Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Inherits PoisonForm

    ' Manager defined in code for safety
    Private _loginStyleManager As PoisonStyleManager

    Public Sub New()
        InitializeComponent()

        ' Initialize style manager
        _loginStyleManager = New PoisonStyleManager()
        _loginStyleManager.Owner = Me
        _loginStyleManager.Style = ColorStyle.Blue
        _loginStyleManager.Theme = ThemeStyle.Light
        Me.StyleManager = _loginStyleManager
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set focus to username field
        txtUser.Focus()

        ' Set initial state
        chkShowPassword.Checked = False

        ' Enable Enter key for login
        Me.AcceptButton = btnLogin
    End Sub

    ' ==========================================
    ' LOGIN BUTTON - Main Authentication
    ' ==========================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please enter Username/Email and Password", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            ' 1. CHECK ADMIN LOGIN (Table: tbl_users)
            ' Admins still use their "username" (e.g., 'admin')
            Dim queryAdmin As String = "SELECT * FROM tbl_users WHERE username='" & txtUser.Text & "' AND password='" & txtPass.Text & "'"
            Dim dtAdmin As DataTable = DatabaseConnection.RunQuery(queryAdmin)

            If dtAdmin.Rows.Count > 0 Then
                ' ADMIN FOUND
                UserSession.CurrentUserID = 0
                UserSession.CurrentUserName = "Administrator"

                MsgBox("Welcome Admin!", MsgBoxStyle.Information)
                Dim f As New FrmMain()
                f.Show()
                Me.Hide()
                Return ' Stop here so we don't check customers
            End If

            ' 2. CHECK CUSTOMER LOGIN (Table: tbl_customers)
            ' FIX: We now check the 'email' column instead of 'cust_name'
            Dim queryCust As String = "SELECT * FROM tbl_customers WHERE email='" & txtUser.Text & "' AND password='" & txtPass.Text & "'"
            Dim dtCust As DataTable = DatabaseConnection.RunQuery(queryCust)

            If dtCust.Rows.Count > 0 Then
                ' CUSTOMER FOUND
                UserSession.CurrentUserID = Convert.ToInt32(dtCust.Rows(0)("cust_id"))
                UserSession.CurrentUserName = dtCust.Rows(0)("cust_name").ToString()

                MsgBox("Welcome " & UserSession.CurrentUserName, MsgBoxStyle.Information)

                Dim f As New FrmUserDashboard()
                '  userId:=Convert.ToInt32(dtCust.Rows(0)("cust_id")),
                ' userEmail:=dtCust.Rows(0)("email").ToString(),
                'userName:=dtCust.Rows(0)("cust_name").ToString()
                f.Show()
                Me.Hide()
            Else
                ' NEITHER FOUND
                MsgBox("Invalid Email/Username or Password.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Login Error: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' INPUT VALIDATION
    ' ==========================================
    Private Function ValidateInputs() As Boolean
        ' Check username
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            MsgBox("Please enter your username.", MsgBoxStyle.Exclamation, "Username Required")
            txtUser.Focus()
            Return False
        End If

        ' Check password
        If String.IsNullOrWhiteSpace(txtPass.Text) Then
            MsgBox("Please enter your password.", MsgBoxStyle.Exclamation, "Password Required")
            txtPass.Focus()
            Return False
        End If

        ' Check minimum length
        If txtUser.Text.Trim().Length < 3 Then
            MsgBox("Username must be at least 3 characters long.", MsgBoxStyle.Exclamation, "Invalid Username")
            txtUser.Focus()
            Return False
        End If

        If txtPass.Text.Length < 4 Then
            MsgBox("Password must be at least 4 characters long.", MsgBoxStyle.Exclamation, "Invalid Password")
            txtPass.Focus()
            Return False
        End If

        Return True
    End Function

    ' ==========================================
    ' CLEAR BUTTON - Reset Fields
    ' ==========================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' ==========================================
    ' HELPER: CLEAR FIELDS
    ' ==========================================
    Private Sub ClearFields()
        txtUser.Text = ""
        txtPass.Text = ""
        chkShowPassword.Checked = False
        txtUser.Focus()
    End Sub

    ' ==========================================
    ' EXIT BUTTON - Close Application
    ' ==========================================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MsgBox("Are you sure you want to exit the application?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Exit")

        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ==========================================
    ' SHOW PASSWORD CHECKBOX
    ' ==========================================
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            ' Show password
            txtPass.PasswordChar = ChrW(0)
        Else
            ' Hide password
            txtPass.PasswordChar = ChrW(42) ' Asterisk
        End If
    End Sub

    ' ==========================================
    ' ENTER KEY PRESS - Submit on Enter
    ' ==========================================
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPass.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    ' ==========================================
    ' FORM CLOSING - Prevent accidental close
    ' ==========================================
    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' If user clicks X button, confirm exit
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Exit")

            If result = MsgBoxResult.No Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim f As New FrmRegister()
        f.Show()
        Me.Hide()
    End Sub
End Class
