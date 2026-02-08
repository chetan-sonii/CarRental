Module UserSession
    ' If 0, it means Admin is logged in.
    ' If > 0, it is the Customer ID.
    Public CurrentUserID As Integer = 0

    ' To show their name on the dashboard
    Public CurrentUserName As String = ""
End Module