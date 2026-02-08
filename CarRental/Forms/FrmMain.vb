Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmMain
    Inherits PoisonForm

    Private ReadOnly PoisonThemeStyle As Object
    Private ReadOnly tileCust As Object

    ' 1. CONSTRUCTOR: This runs BEFORE the form opens
    Private _styleManager As PoisonStyleManager

    Public Sub New()
        InitializeComponent()

        ' 2. CREATE IT MANUALLY IN CODE
        ' This bypasses the "Requested value 'none'" error
        _styleManager = New PoisonStyleManager(Me)

        ' 3. FORCE THE SETTINGS
        _styleManager.Style = ColorStyle.Blue
        _styleManager.Theme = ThemeStyle.Light

        ' 4. ASSIGN TO FORM
        Me.StyleManager = _styleManager
    End Sub

    Public ReadOnly Property PoisonColorStyle As Object

    ' 2. LOAD EVENT: Fetch the data
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Just to be double safe, set it again on load
        If Me.StyleManager Is Nothing Then
            Me.StyleManager = _styleManager
        End If

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