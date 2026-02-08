Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmMain
    Inherits PoisonForm

    Private _styleManager As PoisonStyleManager

    Public Sub New()
        InitializeComponent()
        _styleManager = New PoisonStyleManager()
        _styleManager.Owner = Me
        _styleManager.Style = ColorStyle.Blue
        _styleManager.Theme = ThemeStyle.Light
        Me.StyleManager = _styleManager
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureForm()
        LoadDashboardStats()
        ShowWelcomeMessage()
    End Sub

    ' ==========================================
    ' FORM CONFIGURATION
    ' ==========================================
    Private Sub ConfigureForm()
        Me.Movable = True
        Me.Resizable = False
    End Sub

    ' ==========================================
    ' LOAD DASHBOARD STATISTICS
    ' ==========================================
    Private Sub LoadDashboardStats()
        Try
            ' Count Available Cars
            Dim dtCars As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_cars WHERE available='Yes'")
            If dtCars IsNot Nothing AndAlso dtCars.Rows.Count > 0 Then
                If tileCars IsNot Nothing Then
                    tileCars.TileCount = CInt(dtCars.Rows(0)(0))
                End If
            End If

            ' Count Total Customers
            Dim dtCust As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_customers")
            If dtCust IsNot Nothing AndAlso dtCust.Rows.Count > 0 Then
                If tileCust IsNot Nothing Then
                    tileCust.TileCount = CInt(dtCust.Rows(0)(0))
                End If
            End If

            ' Count Active Rentals (Cars that are NOT available)
            Dim dtRent As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_cars WHERE available='No'")
            If dtRent IsNot Nothing AndAlso dtRent.Rows.Count > 0 Then
                If tileRentals IsNot Nothing Then
                    tileRentals.TileCount = CInt(dtRent.Rows(0)(0))
                End If
            End If

            ' Count Pending Requests
            Dim dtRequests As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_rentals WHERE status!='Active'")
            If dtRequests IsNot Nothing AndAlso dtRequests.Rows.Count > 0 Then
                If tileRequests IsNot Nothing Then
                    tileRequests.TileCount = CInt(dtRequests.Rows(0)(0))
                End If
            End If

            ' Update last refresh time
            If lblLastUpdate IsNot Nothing Then
                lblLastUpdate.Text = "Last Updated: " & DateTime.Now.ToString("hh:mm:ss tt")
            End If

        Catch ex As Exception
            Console.WriteLine("Stats Error: " & ex.Message)
            MsgBox("Error loading dashboard statistics: " & ex.Message, MsgBoxStyle.Exclamation, "Database Error")
        End Try
    End Sub

    ' ==========================================
    ' WELCOME MESSAGE
    ' ==========================================
    Private Sub ShowWelcomeMessage()
        If lblWelcome IsNot Nothing Then
            Dim hour As Integer = DateTime.Now.Hour
            Dim greeting As String = ""

            If hour < 12 Then
                greeting = "Good Morning"
            ElseIf hour < 18 Then
                greeting = "Good Afternoon"
            Else
                greeting = "Good Evening"
            End If

            lblWelcome.Text = greeting & ", Admin! 👋"
        End If
    End Sub

    ' ==========================================
    ' TILE CLICK EVENTS
    ' ==========================================
    Private Sub tileCars_Click(sender As Object, e As EventArgs) Handles tileCars.Click
        Try
            Dim f As New FrmCars()
            f.ShowDialog()
            LoadDashboardStats()
        Catch ex As Exception
            MsgBox("Error opening Cars Management: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tileCust_Click(sender As Object, e As EventArgs) Handles tileCust.Click
        Try
            Dim f As New FrmCustomers()
            f.ShowDialog()
            LoadDashboardStats()
        Catch ex As Exception
            MsgBox("Error opening Customer Management: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tileRentals_Click(sender As Object, e As EventArgs) Handles tileRentals.Click
        Try
            Dim f As New FrmRental()
            f.ShowDialog()
            LoadDashboardStats()
        Catch ex As Exception
            MsgBox("Error opening Rental Management: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tileReturn_Click(sender As Object, e As EventArgs) Handles tileReturn.Click
        Try
            Dim f As New FrmReturn()
            f.ShowDialog()
            LoadDashboardStats()
        Catch ex As Exception
            MsgBox("Error opening Return Management: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tileRequests_Click(sender As Object, e As EventArgs) Handles tileRequests.Click
        Try
            Dim f As New FrmRequests()
            f.ShowDialog()
            LoadDashboardStats()
        Catch ex As Exception
            MsgBox("Error opening Requests: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' ==========================================
    ' LOGOUT
    ' ==========================================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to logout?", 
                                           MsgBoxStyle.YesNo + MsgBoxStyle.Question, 
                                           "Confirm Logout")
        
        If result = MsgBoxResult.Yes Then
            Dim f As New FrmLogin()
            f.Show()
            Me.Close()
        End If
    End Sub

    ' ==========================================
    ' REFRESH BUTTON
    ' ==========================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDashboardStats()
        MsgBox("Dashboard statistics refreshed successfully!", MsgBoxStyle.Information, "Refreshed")
    End Sub

End Class
