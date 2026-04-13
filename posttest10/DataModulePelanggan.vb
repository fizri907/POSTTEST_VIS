Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Module DataModulePelanggan

    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "SELECT * FROM tbpelanggan"
            Dim adapter As New MySqlDataAdapter(query, ConnectionModule.conn)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Gagal mengambil data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodePelangganSudahAda(kode As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "SELECT COUNT(*) FROM tbpelanggan WHERE kodePelanggan=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function SimpanPelanggan(kode As String, nama As String, telp As String, alamat As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "INSERT INTO tbpelanggan (kodePelanggan, nama, telepon, alamat) VALUES (@kode, @nama, @telp, @alamat)"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@telp", telp)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahPelanggan(kode As String, nama As String, telp As String, alamat As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "UPDATE tbpelanggan SET nama=@nama, telepon=@telp, alamat=@alamat WHERE kodePelanggan=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@telp", telp)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            MsgBox("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusPelanggan(kode As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "DELETE FROM tbpelanggan WHERE kodePelanggan=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SearchPelanggan(keyword As String) As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "SELECT * FROM tbpelanggan WHERE nama LIKE @key OR kodePelanggan LIKE @key"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Pencarian gagal: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetPelangganByKode(kode As String) As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "SELECT * FROM tbpelanggan WHERE kodePelanggan=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
        End Try
        Return dt
    End Function

End Module