Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmRental
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

    Private Sub FrmRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCarCombo()
        FillCustomerCombo()
        LoadRentalHistory()
    End Sub

    ' ==========================================
    ' 1. FILL DROPDOWNS
    ' ==========================================
    Private Sub FillCarCombo()
        ' ONLY show cars that are Available='Yes'
        Dim query As String = "SELECT reg_no FROM tbl_cars WHERE available='Yes'"
        Dim dt As DataTable = DatabaseConnection.RunQuery(query)

        cbCar.Items.Clear()
        For Each row As DataRow In dt.Rows
            cbCar.Items.Add(row("reg_no").ToString())
        Next
    End Sub

    Private Sub FillCustomerCombo()
        Dim query As String = "SELECT cust_id FROM tbl_customers"
        Dim dt As DataTable = DatabaseConnection.RunQuery(query)

        cbCust.Items.Clear()
        For Each row As DataRow In dt.Rows
            cbCust.Items.Add(row("cust_id").ToString())
        Next
    End Sub

    ' ==========================================
    ' 2. FETCH CUSTOMER NAME (When ID selected)
    ' ==========================================
    ' ==========================================
    ' 2. FETCH CUSTOMER NAME (When ID selected)
    ' ==========================================
    Private Sub cbCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCust.SelectedIndexChanged

        ' SAFETY CHECK: If nothing is selected, STOP here.
        If cbCust.SelectedIndex = -1 Or cbCust.SelectedItem Is Nothing Then
            Return
        End If

        Try
            Dim query As String = "SELECT cust_name FROM tbl_customers WHERE cust_id=" & cbCust.SelectedItem.ToString()
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            If dt.Rows.Count > 0 Then
                lblName.Text = "Name: " & dt.Rows(0)("cust_name").ToString()
            Else
                lblName.Text = "Name: Not Found"
            End If

        Catch ex As Exception
            ' If it fails, just ignore it to prevent crashing
        End Try
    End Sub

    ' ==========================================
    ' 3. CALCULATE FEES
    ' ==========================================
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If cbCar.SelectedIndex = -1 Then
            MsgBox("Select a car first")
            Return
        End If

        Try
            ' 1. Get Price Per Day of selected car
            Dim query As String = "SELECT price FROM tbl_cars WHERE reg_no='" & cbCar.SelectedItem.ToString() & "'"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            Dim pricePerDay As Decimal = 0

            If dt.Rows.Count > 0 Then
                pricePerDay = Convert.ToDecimal(dt.Rows(0)("price"))
            End If

            ' 2. Calculate Days
            Dim days As TimeSpan = dtReturn.Value.Date - dtDate.Value.Date
            Dim totalDays As Integer = days.Days

            If totalDays <= 0 Then
                MsgBox("Return date must be after Rental date")
                Return
            End If

            ' 3. Show Total
            Dim totalFee As Decimal = totalDays * pricePerDay
            lblFee.Text = "Total Fees: " & totalFee.ToString()

        Catch ex As Exception
            MsgBox("Calculation Error: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' 4. CONFIRM RENTAL (The Big Transaction)
    ' ==========================================
    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        If cbCar.SelectedIndex = -1 Or cbCust.SelectedIndex = -1 Then
            MsgBox("Please select Car and Customer")
            Return
        End If

        Try
            ' A. Get the fee amount from the label (simple way)
            Dim feeString As String = lblFee.Text.Replace("Total Fees: ", "")
            Dim fee As Decimal = Val(feeString)

            ' B. SQL 1: Insert into Rentals
            Dim dateOut As String = dtDate.Value.ToString("yyyy-MM-dd")
            Dim dateIn As String = dtReturn.Value.ToString("yyyy-MM-dd")

            Dim queryInsert As String = "INSERT INTO tbl_rentals (car_reg, cust_id, rent_date, return_date, fees) VALUES ('" & cbCar.SelectedItem.ToString() & "', " & cbCust.SelectedItem.ToString() & ", '" & dateOut & "', '" & dateIn & "', " & fee & ")"
            DatabaseConnection.ExecuteQuery(queryInsert)

            ' C. SQL 2: Update Car Status to 'No'
            Dim queryUpdate As String = "UPDATE tbl_cars SET available='No' WHERE reg_no='" & cbCar.SelectedItem.ToString() & "'"
            DatabaseConnection.ExecuteQuery(queryUpdate)

            MsgBox("Car Rented Successfully!")

            ' D. Refresh
            LoadRentalHistory()
            FillCarCombo() ' Remove the rented car from the list
            cbCar.SelectedIndex = -1
            cbCust.SelectedIndex = -1
            lblFee.Text = "Total Fees: 0.00"

        Catch ex As Exception
            MsgBox("Booking Error: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' 5. LOAD HISTORY
    ' ==========================================
    Private Sub LoadRentalHistory()
        Dim query As String = "SELECT * FROM tbl_rentals"
        dgvRentals.DataSource = DatabaseConnection.RunQuery(query)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class