Imports MySql.Data.MySqlClient
Imports System.Data

Public Module DatabaseConnection

    ' Keep the connection string in ONE place
    Public ReadOnly ConnectionString As String =
        "server=localhost;user=root;password=ChetanRootUser-PWD_Store-7729;database=db_car_rental;SslMode=none;"

    ' For SELECT queries (returns DataTable)
    Public Function RunQuery(query As String,
                             Optional parameters As List(Of MySqlParameter) = Nothing) As DataTable

        Dim dt As New DataTable()

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    ' For INSERT / UPDATE / DELETE
    Public Sub ExecuteQuery(query As String,
                            Optional parameters As List(Of MySqlParameter) = Nothing)

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
