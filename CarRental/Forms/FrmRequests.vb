Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Manager
Imports ReaLTaiizor.Enum.Poison
Imports MySql.Data.MySqlClient

Public Class FrmRequests
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

    Private Sub FrmRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCarCombo()
        FillCustomerCombo()
        LoadRentalHistory()
        UpdateStatistics()
        ConfigureDataGridView()

        dtRentDate.Value = DateTime.Now
        dtReturnDate.Value = DateTime.Now.AddDays(1)
    End Sub

    Private Sub ConfigureDataGridView()
        Try
            If dgvRentals.Columns.Count > 0 Then
                dgvRentals.Columns(0).HeaderText = "Rental ID"
                dgvRentals.Columns(1).HeaderText = "Car Reg"
                dgvRentals.Columns(2).HeaderText = "Customer ID"
                dgvRentals.Columns(3).HeaderText = "Rent Date"
                dgvRentals.Columns(4).HeaderText = "Return Date"
                dgvRentals.Columns(5).HeaderText = "Fees (₹)"

                If dgvRentals.Columns.Count > 6 Then
                    dgvRentals.Columns(6).HeaderText = "Status"
                End If

                dgvRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FillCarCombo()
        Try
            Dim query As String = "SELECT reg_no, brand, model FROM tbl_cars WHERE available='Yes' ORDER BY reg_no"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            cbCar.Items.Clear()

            For Each row As DataRow In dt.Rows
                cbCar.Items.Add(row("reg_no").ToString())
            Next

            If cbCar.Items.Count = 0 Then
                MsgBox("No cars are currently available for rental.", MsgBoxStyle.Information, "No Availability")
            End If
        Catch ex As Exception
            MsgBox("Error loading cars: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FillCustomerCombo()
        Try
            Dim query As String = "SELECT cust_id, cust_name FROM tbl_customers ORDER BY cust_name"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            cbCustomer.Items.Clear()

            For Each row As DataRow In dt.Rows
                cbCustomer.Items.Add(row("cust_id").ToString() & " - " & row("cust_name").ToString())
            Next
        Catch ex As Exception
            MsgBox("Error loading customers: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCar.SelectedIndexChanged
        If cbCar.SelectedIndex = -1 OrElse cbCar.SelectedItem Is Nothing Then
            lblCarInfo.Text = "Select car first"
            Return
        End If

        Try
            Dim carReg As String = cbCar.SelectedItem.ToString()
            Dim query As String = "SELECT brand, model, price FROM tbl_cars WHERE reg_no='" & carReg.Replace("'", "''") & "'"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            If dt.Rows.Count > 0 Then
                Dim brand As String = dt.Rows(0)("brand").ToString()
                Dim model As String = dt.Rows(0)("model").ToString()
                Dim price As String = dt.Rows(0)("price").ToString()

                lblCarInfo.Text = brand & " " & model & " | ₹" & price & "/day"
            Else
                lblCarInfo.Text = "Car info not available"
            End If
        Catch ex As Exception
            lblCarInfo.Text = "Error loading car info"
        End Try
    End Sub

    Private Sub cbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomer.SelectedIndexChanged
        If cbCustomer.SelectedIndex = -1 OrElse cbCustomer.SelectedItem Is Nothing Then
            lblCustomerName.Text = "Select customer first"
            lblCustomerPhone.Text = "Phone"
            Return
        End If

        Try
            Dim selectedText As String = cbCustomer.SelectedItem.ToString()
            Dim custId As String = selectedText.Split("-"c)(0).Trim()

            Dim query As String = "SELECT cust_name, phone FROM tbl_customers WHERE cust_id=" & custId
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)

            If dt.Rows.Count > 0 Then
                lblCustomerName.Text = dt.Rows(0)("cust_name").ToString()
                lblCustomerPhone.Text = "📞 " & dt.Rows(0)("phone").ToString()
            Else
                lblCustomerName.Text = "Customer not found"
                lblCustomerPhone.Text = "Phone"
            End If
        Catch ex As Exception
            lblCustomerName.Text = "Error loading customer info"
            lblCustomerPhone.Text = "Phone"
        End Try
    End Sub

    Private Sub dtRentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtRentDate.ValueChanged, dtReturnDate.ValueChanged
        UpdateDuration()
    End Sub

    Private Sub UpdateDuration()
        Try
            Dim rentDate As Date = dtRentDate.Value.Date
            Dim returnDate As Date = dtReturnDate.Value.Date
            Dim duration As TimeSpan = returnDate - rentDate
            Dim days As Integer = duration.Days

            If days < 0 Then
                lblDays.Text = "Invalid dates!"
                lblDays.UseCustomForeColor = True
                lblDays.ForeColor = Color.Red
            ElseIf days = 0 Then
                lblDays.Text = "Same day rental"
                lblDays.UseCustomForeColor = False
            Else
                lblDays.Text = days.ToString() & " day" & If(days > 1, "s", "")
                lblDays.UseCustomForeColor = False
            End If
        Catch ex As Exception
            lblDays.Text = "0 days"
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If cbCar.SelectedIndex = -1 Then
            MsgBox("Please select a car.", MsgBoxStyle.Exclamation, "Car Required")
            cbCar.Focus()
            Return
        End If

        Try
            Dim carReg As String = cbCar.SelectedItem.ToString()
            Dim query As String = "SELECT price FROM tbl_cars WHERE reg_no='" & carReg.Replace("'", "''") & "'"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            Dim pricePerDay As Decimal = 0

            If dt.Rows.Count > 0 Then
                pricePerDay = Convert.ToDecimal(dt.Rows(0)("price"))
            Else
                MsgBox("Unable to retrieve car price.", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim rentDate As Date = dtRentDate.Value.Date
            Dim returnDate As Date = dtReturnDate.Value.Date
            Dim duration As TimeSpan = returnDate - rentDate
            Dim totalDays As Integer = duration.Days

            If totalDays <= 0 Then
                MsgBox("Return date must be after rental date.", MsgBoxStyle.Exclamation, "Invalid Dates")
                dtReturnDate.Focus()
                Return
            End If

            Dim totalFee As Decimal = totalDays * pricePerDay
            lblFee.Text = "₹ " & totalFee.ToString("N2")

            MsgBox("Calculation complete!" & vbCrLf & vbCrLf &
                   "Duration: " & totalDays & " day(s)" & vbCrLf &
                   "Rate: ₹" & pricePerDay.ToString() & "/day" & vbCrLf &
                   "Total: ₹" & totalFee.ToString("N2"),
                   MsgBoxStyle.Information, "Fee Calculated")

        Catch ex As Exception
            MsgBox("Error calculating fee: " & ex.Message, MsgBoxStyle.Critical, "Calculation Error")
        End Try
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        If cbCar.SelectedIndex = -1 Then
            MsgBox("Please select a car.", MsgBoxStyle.Exclamation, "Car Required")
            cbCar.Focus()
            Return
        End If

        If cbCustomer.SelectedIndex = -1 Then
            MsgBox("Please select a customer.", MsgBoxStyle.Exclamation, "Customer Required")
            cbCustomer.Focus()
            Return
        End If

        Dim rentDate As Date = dtRentDate.Value.Date
        Dim returnDate As Date = dtReturnDate.Value.Date
        Dim duration As TimeSpan = returnDate - rentDate
        Dim totalDays As Integer = duration.Days

        If totalDays <= 0 Then
            MsgBox("Return date must be after rental date.", MsgBoxStyle.Exclamation, "Invalid Dates")
            Return
        End If

        Dim feeString As String = lblFee.Text.Replace("₹ ", "").Replace(",", "").Trim()
        Dim fee As Decimal = 0

        If Not Decimal.TryParse(feeString, fee) OrElse fee <= 0 Then
            MsgBox("Please calculate the fee first by clicking 'Calculate Total Fee'.", MsgBoxStyle.Exclamation, "Fee Required")
            btnCalculate.Focus()
            Return
        End If

        Try
            Dim carReg As String = cbCar.SelectedItem.ToString()
            Dim selectedText As String = cbCustomer.SelectedItem.ToString()
            Dim custId As String = selectedText.Split("-"c)(0).Trim()

            Dim result = MsgBox("Confirm rental details:" & vbCrLf & vbCrLf &
                               "Car: " & carReg & " - " & lblCarInfo.Text & vbCrLf &
                               "Customer: " & lblCustomerName.Text & vbCrLf &
                               "Rent Date: " & rentDate.ToString("dd-MMM-yyyy") & vbCrLf &
                               "Return Date: " & returnDate.ToString("dd-MMM-yyyy") & vbCrLf &
                               "Duration: " & totalDays & " day(s)" & vbCrLf &
                               "Total Fee: ₹" & fee.ToString("N2") & vbCrLf & vbCrLf &
                               "Proceed with rental?",
                               MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Rental")

            If result = MsgBoxResult.No Then Return

            Dim dateOut As String = rentDate.ToString("yyyy-MM-dd")
            Dim dateIn As String = returnDate.ToString("yyyy-MM-dd")

            Dim queryInsert As String = "INSERT INTO tbl_rentals (car_reg, cust_id, rent_date, return_date, fees, status) " &
                                       "VALUES ('" & carReg.Replace("'", "''") & "', " & custId & ", '" & dateOut & "', '" & dateIn & "', " & fee & ", 'Pending')"
            DatabaseConnection.ExecuteQuery(queryInsert)

            Dim queryUpdate As String = "UPDATE tbl_cars SET available='No' WHERE reg_no='" & carReg.Replace("'", "''") & "'"
            DatabaseConnection.ExecuteQuery(queryUpdate)

            MsgBox("✓ Rental created successfully!" & vbCrLf & vbCrLf &
                   "Status: Pending Approval" & vbCrLf &
                   "The rental will be activated once approved by management.",
                   MsgBoxStyle.Information, "Success")

            LoadRentalHistory()
            FillCarCombo()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error creating rental: " & ex.Message, MsgBoxStyle.Critical, "Rental Error")
        End Try
    End Sub

    Private Sub LoadRentalHistory()
        Try
            Dim query As String = "SELECT * FROM tbl_rentals ORDER BY rent_id DESC"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            dgvRentals.DataSource = dt

            ConfigureDataGridView()
            UpdateStatistics()
        Catch ex As Exception
            MsgBox("Error loading rental history: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UpdateStatistics()
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbl_rentals"
            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            Dim total As Integer = 0

            If dt.Rows.Count > 0 Then
                total = Convert.ToInt32(dt.Rows(0)(0))
            End If

            PoisonTile1.Text = "Total Rentals: " & total.ToString()
        Catch ex As Exception
            PoisonTile1.Text = "Total Rentals: 0"
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                LoadRentalHistory()
                Return
            End If

            Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")
            Dim query As String = "SELECT * FROM tbl_rentals WHERE " &
                                 "rent_id LIKE '%" & searchText & "%' OR " &
                                 "car_reg LIKE '%" & searchText & "%' OR " &
                                 "cust_id LIKE '%" & searchText & "%' OR " &
                                 "status LIKE '%" & searchText & "%' " &
                                 "ORDER BY rent_id DESC"

            Dim dt As DataTable = DatabaseConnection.RunQuery(query)
            dgvRentals.DataSource = dt
            ConfigureDataGridView()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        cbCar.SelectedIndex = -1
        cbCustomer.SelectedIndex = -1
        lblCustomerName.Text = "Select customer first"
        lblCustomerPhone.Text = "Phone"
        lblCarInfo.Text = "Select car first"
        lblFee.Text = "₹ 0.00"
        lblDays.Text = "0 days"
        lblDays.UseCustomForeColor = False
        dtRentDate.Value = DateTime.Now
        dtReturnDate.Value = DateTime.Now.AddDays(1)
        cbCar.Focus()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRentalHistory()
        FillCarCombo()
        FillCustomerCombo()
        txtSearch.Text = ""
        MsgBox("✓ Data refreshed successfully!", MsgBoxStyle.Information, "Refreshed")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result = MsgBox("Are you sure you want to close this window?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Exit")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
