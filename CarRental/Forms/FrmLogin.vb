Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Inherits PoisonForm

    Public Sub New()
        InitializeComponent()
    End Sub

    ' 1. LOAD EVENT: Sets the Color Theme
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' We use the Full Address here to prevent "Type not found" errors
        Me.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light
        Me.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue

        ' Optional: Make the textboxes match the theme
        txtUser.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
        txtPass.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue
    End Sub

    ' 2. LOGIN BUTTON LOGIC
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validation
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please enter Username and Password", MsgBoxStyle.Exclamation, "Missing Info")
            Return
        End If

        Try
            ' Database Connection Check
            Dim query As String = "SELECT * FROM tbl_users WHERE username='" & txtUser.Text & "' AND password='" & txtPass.Text & "'"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            If dt.Rows.Count > 0 Then
                ' SUCCESS
                MsgBox("Login Successful!", MsgBoxStyle.Information, "Welcome")

                ' Open Main Dashboard
                Dim f As New FrmMain
                f.Show()

                ' Hide Login Form
                Me.Hide()
            Else
                ' FAIL
                MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Login Failed")
            End If

        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
        End Try
    End Sub

    ' 3. CLEAR BUTTON LOGIC
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUser.Text = ""
        txtPass.Text = ""
        txtUser.Focus() ' Put cursor back in first box
    End Sub

End Class