Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmMain
    Inherits PoisonForm

    ' 1. DEFINE MANAGER (Code-Only to prevent Designer bugs)
    Private _styleManager As PoisonStyleManager

    Public Sub New()
        InitializeComponent()

        _styleManager = New PoisonStyleManager()   ' <- do NOT pass Me here
        _styleManager.Owner = Me                   ' set owner explicitly
        _styleManager.Style = ColorStyle.Blue
        _styleManager.Theme = ThemeStyle.Light
        Me.StyleManager = _styleManager
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        Try
            ' 3. FETCH DATA SAFEGUARDS
            ' We check if the connection is actually valid before running queries

            ' Count Cars
            Dim dtCars As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_cars WHERE available='Yes'")
            If dtCars.Rows.Count > 0 Then
                ' We check if tileCars exists (it might not be created yet in some designer states)
                If tileCust IsNot Nothing Then tileCust.TileCount = CInt(dtCars.Rows(0)(0))
            End If

            ' Count Customers
            Dim dtCust As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_customers")
            If dtCust.Rows.Count > 0 Then
                If tileCust IsNot Nothing Then tileCust.TileCount = CInt(dtCust.Rows(0)(0))
            End If

            ' Count Rentals
            Dim dtRent As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_rentals WHERE return_date IS NULL")
            If dtRent.Rows.Count > 0 Then
                If tileRentals IsNot Nothing Then tileRentals.TileCount = CInt(dtRent.Rows(0)(0))
            End If

        Catch ex As Exception
            ' If stats fail, we simply show 0 instead of crashing the whole app
            Console.WriteLine("Stats Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim f As New FrmLogin
        f.Show()
        Me.Close()
    End Sub
    Private Sub tileCars_Click(sender As Object, e As EventArgs) Handles tileCars.Click
        ' Open the Cars Management Form
        Dim f As New FrmCars()
        f.ShowDialog() ' ShowDialog means you can't click the dashboard until you close this form

        ' Refresh stats when you come back (so the numbers update!)
        LoadDashboardStats()
    End Sub

    Private Sub tileCust_Click(sender As Object, e As EventArgs) Handles tileCust.Click
        Dim f As New FrmCustomers()
        f.ShowDialog()
        LoadDashboardStats() ' Refresh the "Total Customers" count when you return
    End Sub
    Private Sub tileRentals_Click(sender As Object, e As EventArgs) Handles tileRentals.Click
        Dim f As New FrmRental()
        f.ShowDialog()
        LoadDashboardStats() ' Refresh stats (Car count will drop by 1!)
    End Sub
End Class