Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmMain
    Inherits PoisonForm

    Private ReadOnly PoisonThemeStyle As Object
    Private ReadOnly tileCust As Object

    ' 1. CONSTRUCTOR: This runs BEFORE the form opens
    Public Sub New()
        InitializeComponent()

        ' SAFETY CHECK: Force the StyleManager to recognize the form
        If Me.PoisonStyleManager1 Is Nothing Then
            Me.PoisonStyleManager1 = New PoisonStyleManager(Me)
        End If

        ' FORCE THEME: This prevents "None" errors
        Me.PoisonStyleManager1.Owner = Me
        Me.PoisonStyleManager1.Theme = PoisonThemeStyle.Light
        Me.PoisonStyleManager1.Style = PoisonColorStyle.Blue

        ' Assign it to the form
        Me.StyleManager = Me.PoisonStyleManager1
    End Sub

    Public ReadOnly Property PoisonColorStyle As Object

    ' 2. LOAD EVENT: Fetch the data
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    ' 3. DATA LOGIC
    Private Sub LoadDashboardStats()
        Try
            ' Get Car Count (Ensure you check 'available' status)
            Dim dtCars As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_cars WHERE available='Yes'")
            If dtCars.Rows.Count > 0 Then
                tileCars.TileCount = CInt(dtCars.Rows(0)(0))
            End If

            ' Get Customer Count
            Dim dtCust As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_customers")
            If dtCust.Rows.Count > 0 Then
                tileCust.TileCount = CInt(dtCust.Rows(0)(0))
            End If

            ' Get Active Rentals (Rentals not yet returned)
            Dim dtRent As DataTable = DatabaseConnection.RunQuery("SELECT COUNT(*) FROM tbl_rentals WHERE return_date IS NULL")
            If dtRent.Rows.Count > 0 Then
                tileRentals.TileCount = CInt(dtRent.Rows(0)(0))
            End If

        Catch ex As Exception
            ' If database fails, set to 0 to prevent crash
            tileCars.TileCount = 0
            tileCust.TileCount = 0
            tileRentals.TileCount = 0
        End Try
    End Sub

    ' 4. LOGOUT BUTTON
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim f As New FrmLogin
        f.Show()
        Me.Close()
    End Sub

End Class