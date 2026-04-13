Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Module ConnectionModule
    Public conn As MySqlConnection

    Public Sub BukaKoneksi()
        Dim str As String = "server=localhost;user=root;password=;database=dbair_ulang"
        Try
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module