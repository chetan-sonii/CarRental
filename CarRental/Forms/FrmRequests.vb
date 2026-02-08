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
        LoadRentRequests()
        LoadReturnRequests()
    End Sub

    ' 1. LOAD DATA
    Private Sub LoadRentRequests()
        ' Show only Pending rentals
        Dim query As String = "SELECT rent_id, car_reg, cust_id, status FROM tbl_rentals WHERE status='Pending'"
        dgvRentRequests.DataSource = DatabaseConnection.RunQuery(query)
    End Sub

    Private Sub LoadReturnRequests()
        ' Show only ReturnPending rentals
        Dim query As String = "SELECT rent_id, car_reg, cust_id, status FROM tbl_rentals WHERE status='ReturnPending'"
        dgvReturnRequests.DataSource = DatabaseConnection.RunQuery(query)
    End Sub
    ' ==========================================
    ' 2. APPROVE RENTAL (With Safety Check)
    ' ==========================================
    Private Sub btnApproveRent_Click(sender As Object, e As EventArgs) Handles btnApproveRent.Click
        ' Check if a row is actually selected
        If dgvRentRequests.SelectedRows.Count = 0 Then
            MsgBox("Please select a request row first.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' SAFETY CHECK: Ignore the empty "New Row" at the bottom
        If dgvRentRequests.SelectedRows(0).IsNewRow Then
            MsgBox("Invalid selection. Please select a record, not the empty row.")
            Return
        End If

        Try
            ' 1. Get the values safely
            Dim row As DataGridViewRow = dgvRentRequests.SelectedRows(0)

            ' Safety: Ensure cell exists and value is not null
            If row.Cells("rent_id").Value Is Nothing OrElse IsDBNull(row.Cells("rent_id").Value) Then
                MsgBox("Error: Selected row has no Rent ID.")
                Return
            End If

            Dim rentId As String = row.Cells("rent_id").Value.ToString()
            Dim carReg As String = row.Cells("car_reg").Value.ToString()

            ' 2. Execute Updates
            DatabaseConnection.ExecuteQuery("UPDATE tbl_rentals SET status='Active' WHERE rent_id=" & rentId)
            DatabaseConnection.ExecuteQuery("UPDATE tbl_cars SET available='No' WHERE reg_no='" & carReg & "'")

            MsgBox("Rental Approved!")
            LoadRentRequests()

        Catch ex As Exception
            MsgBox("Error Approving: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' 3. APPROVE RETURN (With Safety Check)
    ' ==========================================
    Private Sub btnConfirmReturn_Click(sender As Object, e As EventArgs) Handles btnConfirmReturn.Click
        If dgvReturnRequests.SelectedRows.Count = 0 Then
            MsgBox("Please select a return request first.", MsgBoxStyle.Exclamation)
            Return
        End If

        If dgvReturnRequests.SelectedRows(0).IsNewRow Then Return

        Try
            Dim row As DataGridViewRow = dgvReturnRequests.SelectedRows(0)

            ' Safety Check
            If row.Cells("rent_id").Value Is Nothing Then Return

            Dim rentId As String = row.Cells("rent_id").Value.ToString()
            Dim carReg As String = row.Cells("car_reg").Value.ToString()

            ' Execute Updates
            DatabaseConnection.ExecuteQuery("UPDATE tbl_rentals SET status='Returned' WHERE rent_id=" & rentId)
            DatabaseConnection.ExecuteQuery("UPDATE tbl_cars SET available='Yes' WHERE reg_no='" & carReg & "'")

            MsgBox("Return Confirmed. Car is available again.")
            LoadReturnRequests()

        Catch ex As Exception
            MsgBox("Error Returning: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class