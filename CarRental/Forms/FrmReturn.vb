Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmReturn
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

    Private Sub FrmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureForm()
        ConfigureDataGridView()
        LoadRentedCars()
        ClearFields()
    End Sub

    ' ==========================================
    ' FORM CONFIGURATION
    ' ==========================================
    Private Sub ConfigureForm()
        ' Form properties for better appearance
        Me.Movable = True
        Me.Resizable = False

        ' Disable text fields for display only
        txtCarId.ReadOnly = True
        txtCustName.ReadOnly = True
        txtDueDate.ReadOnly = True
        txtFine.ReadOnly = True

        ' Set button styles
        btnCalculate.Highlight = True
        btnReturn.Highlight = True
    End Sub

    ' ==========================================
    ' DATAGRIDVIEW CONFIGURATION
    ' ==========================================
    Private Sub ConfigureDataGridView()
        With dgvRented
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None

            ' Alternating row colors for better readability
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255)
        End With
    End Sub

    ' ==========================================
    ' 1. LOAD ONLY RENTED CARS
    ' ==========================================
    Private Sub LoadRentedCars()
        Try
            Dim query As String = "SELECT r.rent_id AS 'Rent ID', " &
                                  "r.car_reg AS 'Car Registration', " &
                                  "c.cust_name AS 'Customer Name', " &
                                  "DATE_FORMAT(r.return_date, '%Y-%m-%d') AS 'Due Date' " &
                                  "FROM tbl_rentals r " &
                                  "JOIN tbl_customers c ON r.cust_id = c.cust_id " &
                                  "JOIN tbl_cars car ON r.car_reg = car.reg_no " &
                                  "WHERE car.available = 'No' " &
                                  "ORDER BY r.return_date ASC"

            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            dgvRented.DataSource = dt

            ' Hide Rent ID column if exists
            If dgvRented.Columns.Contains("Rent ID") Then
                dgvRented.Columns("Rent ID").Visible = False
            End If

            ' Update status label
            lblStatus.Text = "Total Rented Cars: " & dt.Rows.Count.ToString()

        Catch ex As Exception
            MsgBox("Error loading rented cars: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub

    ' ==========================================
    ' 2. GRID CLICK (Select a Car)
    ' ==========================================
    Private Sub dgvRented_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRented.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvRented.Rows(e.RowIndex)

                ' Get the actual column names from the DataGridView
                Dim carRegColumn As String = If(dgvRented.Columns.Contains("Car Registration"), "Car Registration", "car_reg")
                Dim custNameColumn As String = If(dgvRented.Columns.Contains("Customer Name"), "Customer Name", "cust_name")
                Dim dueDateColumn As String = If(dgvRented.Columns.Contains("Due Date"), "Due Date", "return_date")

                txtCarId.Text = row.Cells(carRegColumn).Value.ToString()
                txtCustName.Text = row.Cells(custNameColumn).Value.ToString()

                ' Format date
                Dim dateValue = row.Cells(dueDateColumn).Value
                If dateValue IsNot Nothing AndAlso Not IsDBNull(dateValue) Then
                    Dim d As DateTime = Convert.ToDateTime(dateValue)
                    txtDueDate.Text = d.ToString("yyyy-MM-dd")

                    ' Auto-calculate fine when row is selected
                    CalculateFineAmount()
                End If

            Catch ex As Exception
                MsgBox("Error selecting car: " & ex.Message, MsgBoxStyle.Exclamation, "Selection Error")
            End Try
        End If
    End Sub

    ' ==========================================
    ' 3. CALCULATE FINE (Enhanced Logic)
    ' ==========================================
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateFineAmount()
    End Sub

    Private Sub CalculateFineAmount()
        If String.IsNullOrEmpty(txtDueDate.Text) Then
            MsgBox("Please select a rented car first.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Try
            Dim dueDate As DateTime = DateTime.Parse(txtDueDate.Text)
            Dim today As DateTime = DateTime.Now.Date ' Use Date only for accurate day calculation

            If today > dueDate Then
                Dim delayDays As Integer = (today - dueDate).Days
                Dim finePerDay As Integer = 500 ' Fine amount per day
                Dim totalFine As Integer = delayDays * finePerDay

                txtFine.Text = totalFine.ToString("N0") ' Format with thousand separators
                txtFine.ForeColor = Color.Red

                lblFineStatus.Text = $"Late by {delayDays} day(s) @ ₹{finePerDay}/day"
                lblFineStatus.ForeColor = Color.Red
                lblFineStatus.Visible = True

            Else
                txtFine.Text = "0"
                txtFine.ForeColor = Color.Green

                Dim daysRemaining As Integer = (dueDate - today).Days
                If daysRemaining = 0 Then
                    lblFineStatus.Text = "Due today - No delay"
                Else
                    lblFineStatus.Text = $"On time ({daysRemaining} day(s) remaining)"
                End If
                lblFineStatus.ForeColor = Color.Green
                lblFineStatus.Visible = True
            End If

        Catch ex As Exception
            MsgBox("Date calculation error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    ' ==========================================
    ' 4. CONFIRM RETURN
    ' ==========================================
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If String.IsNullOrEmpty(txtCarId.Text) Then
            MsgBox("Please select a car to return.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        ' Confirmation dialog
        Dim result As MsgBoxResult = MsgBox($"Confirm return of car {txtCarId.Text}?" & vbCrLf &
                                           $"Customer: {txtCustName.Text}" & vbCrLf &
                                           $"Fine Amount: ₹{txtFine.Text}",
                                           MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                                           "Confirm Return")

        If result = MsgBoxResult.No Then Return

        Try
            ' Update car status to available
            Dim queryUpdate As String = $"UPDATE tbl_cars SET available='Yes' WHERE reg_no='{txtCarId.Text}'"
            DatabaseConnection.ExecuteQuery(queryUpdate)

            ' Optional: Update rental record with actual return date and fine
            Dim queryUpdateRental As String = $"UPDATE tbl_rentals SET " &
                                             $"actual_return_date = NOW(), " &
                                             $"fine_amount = {Val(txtFine.Text.Replace(",", ""))} " &
                                             $"WHERE car_reg='{txtCarId.Text}' AND actual_return_date IS NULL"
            DatabaseConnection.ExecuteQuery(queryUpdateRental)

            MsgBox($"Car {txtCarId.Text} returned successfully!" & vbCrLf &
                   "The vehicle is now available for rent.",
                   MsgBoxStyle.Information,
                   "Success")

            ' Refresh and clear
            LoadRentedCars()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error processing return: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub

    ' ==========================================
    ' 5. REFRESH BUTTON
    ' ==========================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRentedCars()
        ClearFields()
        MsgBox("List refreshed successfully!", MsgBoxStyle.Information, "Refresh")
    End Sub

    ' ==========================================
    ' 6. BACK BUTTON
    ' ==========================================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to close this window?",
                                           MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                                           "Confirm Close")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' ==========================================
    ' CLEAR FIELDS
    ' ==========================================
    Private Sub ClearFields()
        txtCarId.Text = ""
        txtCustName.Text = ""
        txtDueDate.Text = ""
        txtFine.Text = "0"
        txtFine.ForeColor = Color.Black
        lblFineStatus.Text = ""
        lblFineStatus.Visible = False

        ' Clear selection in grid
        If dgvRented.Rows.Count > 0 Then
            dgvRented.ClearSelection()
        End If
    End Sub

    ' ==========================================
    ' SEARCH FUNCTIONALITY
    ' ==========================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If dgvRented.DataSource IsNot Nothing Then
            Try
                Dim dv As DataView = CType(dgvRented.DataSource, DataTable).DefaultView

                If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    dv.RowFilter = ""
                Else
                    ' Search in multiple columns
                    dv.RowFilter = $"[Car Registration] LIKE '%{txtSearch.Text}%' OR " &
                                  $"[Customer Name] LIKE '%{txtSearch.Text}%'"
                End If

                lblStatus.Text = "Showing " & dv.Count & " of " & CType(dgvRented.DataSource, DataTable).Rows.Count & " cars"

            Catch ex As Exception
                ' Ignore filter errors
            End Try
        End If
    End Sub

End Class
