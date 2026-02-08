Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FrmRegister
    Inherits PoisonForm
    Private _styleManager As PoisonStyleManager

    Public Sub New()
        InitializeComponent()
        _styleManager = New PoisonStyleManager()
        _styleManager.Owner = Me
        _styleManager.Style = ColorStyle.Green
        _styleManager.Theme = ThemeStyle.Light
        Me.StyleManager = _styleManager
        
        ' Initialize password strength indicator
        PoisonProgressBar1.Value = 0
        lblPasswordStrength.Text = ""
    End Sub

    ' Password strength checker
    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        Dim password As String = txtPass.Text
        Dim strength As Integer = 0
        
        If password.Length = 0 Then
            PoisonProgressBar1.Value = 0
            lblPasswordStrength.Text = ""
            lblPasswordStrength.ForeColor = System.Drawing.Color.Gray
            Return
        End If
        
        ' Length check
        If password.Length >= 8 Then strength += 25
        If password.Length >= 12 Then strength += 10
        
        ' Contains uppercase
        If Regex.IsMatch(password, "[A-Z]") Then strength += 20
        
        ' Contains lowercase
        If Regex.IsMatch(password, "[a-z]") Then strength += 20
        
        ' Contains numbers
        If Regex.IsMatch(password, "[0-9]") Then strength += 15
        
        ' Contains special characters
        If Regex.IsMatch(password, "[!@#$%^&*(),.?""':{}|<>]") Then strength += 10
        
        PoisonProgressBar1.Value = Math.Min(strength, 100)
        
        ' Update label based on strength
        If strength < 40 Then
            lblPasswordStrength.Text = "Weak"
            lblPasswordStrength.ForeColor = System.Drawing.Color.Red
        ElseIf strength < 70 Then
            lblPasswordStrength.Text = "Medium"
            lblPasswordStrength.ForeColor = System.Drawing.Color.Orange
        Else
            lblPasswordStrength.Text = "Strong"
            lblPasswordStrength.ForeColor = System.Drawing.Color.Green
        End If
    End Sub

    ' Show/Hide password toggle
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPass.UseSystemPasswordChar = False
            txtPass.PasswordChar = ChrW(0)
            txtConfirm.UseSystemPasswordChar = False
            txtConfirm.PasswordChar = ChrW(0)
        Else
            txtPass.UseSystemPasswordChar = True
            txtPass.PasswordChar = ChrW(9679)
            txtConfirm.UseSystemPasswordChar = True
            txtConfirm.PasswordChar = ChrW(9679)
        End If
    End Sub

    ' Email validation helper
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Return Regex.IsMatch(email, emailPattern)
        Catch
            Return False
        End Try
    End Function

    ' Phone validation helper
    Private Function IsValidPhone(phone As String) As Boolean
        ' Remove spaces and special characters for validation
        Dim cleanPhone As String = Regex.Replace(phone, "[^0-9+]", "")
        Return cleanPhone.Length >= 10 AndAlso cleanPhone.Length <= 15
    End Function

    ' REGISTER BUTTON
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Comprehensive Validation
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If txtName.Text.Length < 3 Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPass.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return
        End If

        If txtPass.Text.Length < 8 Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return
        End If

        If txtPass.Text <> txtConfirm.Text Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Passwords do not match! Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirm.Clear()
            txtConfirm.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter your phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If Not IsValidPhone(txtPhone.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter a valid phone number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Please enter your address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return
        End If

        Try
            ' 2. Check if Email already exists using parameterized query
            Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_customers WHERE email = @email"
            Dim checkParams As New List(Of MySqlParameter)
            checkParams.Add(New MySqlParameter("@email", txtEmail.Text.Trim()))
            
            Dim dt As DataTable = DatabaseConnection.RunQuery(checkQuery, checkParams)
            
            If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)(0)) > 0 Then
                ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "This email is already registered. Please use a different email or login.", "Email Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            End If

            ' 3. Insert into Database using parameterized query (SECURE)
            Dim insertQuery As String = "INSERT INTO tbl_customers (cust_name, address, phone, email, password) VALUES (@name, @address, @phone, @email, @password)"
            
            Dim insertParams As New List(Of MySqlParameter)
            insertParams.Add(New MySqlParameter("@name", txtName.Text.Trim()))
            insertParams.Add(New MySqlParameter("@address", txtAddress.Text.Trim()))
            insertParams.Add(New MySqlParameter("@phone", txtPhone.Text.Trim()))
            insertParams.Add(New MySqlParameter("@email", txtEmail.Text.Trim()))
            ' Note: In production, you should hash the password before storing
            insertParams.Add(New MySqlParameter("@password", txtPass.Text))
            
            DatabaseConnection.ExecuteQuery(insertQuery, insertParams)

            ' 4. Success message
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Registration successful! You can now login with your credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 5. Navigate to Login
            Dim f As New FrmLogin()
            f.Show()
            Me.Close()

        Catch ex As MySqlException
            ' Handle database-specific errors
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle general errors
            ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Confirm if user wants to leave
        Dim result As DialogResult = ReaLTaiizor.Controls.PoisonMessageBox.Show(Me, "Are you sure you want to go back? Any entered data will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If result = DialogResult.Yes Then
            Dim f As New FrmLogin()
            f.Show()
            Me.Close()
        End If
    End Sub

    ' Form load - center on screen
    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ' Only allow numbers and + in phone field
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

End Class
