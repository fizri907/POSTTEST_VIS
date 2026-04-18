Imports MySql.Data.MySqlClient
Public Module DataModuleTransaksi


    ' Ambil semua transaksi dengan INNER JOIN ke tbpelanggan

    Public Function GetAllTransaksi() As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "SELECT t.kodeTransaksi, t.kodePelanggan, p.nama AS namaPelanggan, " &
                "t.tanggal, t.jenisPaket, t.jumlahGalon, t.hargaSatuan, " &
                "t.totalBayar, t.statusBayar, t.keterangan " &
                "FROM tbtransaksi t " &
                "INNER JOIN tbpelanggan p ON t.kodePelanggan = p.kodePelanggan " &
                "ORDER BY t.tanggal DESC, t.kodeTransaksi ASC"
            Dim adapter As New MySqlDataAdapter(query, ConnectionModule.conn)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Gagal mengambil data transaksi: " & ex.Message)
        End Try
        Return dt
    End Function


    ' Cari transaksi berdasarkan keyword

    Public Function SearchTransaksi(keyword As String) As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "SELECT t.kodeTransaksi, t.kodePelanggan, p.nama AS namaPelanggan, " &
                "t.tanggal, t.jenisPaket, t.jumlahGalon, t.hargaSatuan, " &
                "t.totalBayar, t.statusBayar, t.keterangan " &
                "FROM tbtransaksi t " &
                "INNER JOIN tbpelanggan p ON t.kodePelanggan = p.kodePelanggan " &
                "WHERE t.kodeTransaksi LIKE @key OR p.nama LIKE @key " &
                "OR t.jenisPaket LIKE @key OR t.statusBayar LIKE @key " &
                "ORDER BY t.tanggal DESC"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Pencarian transaksi gagal: " & ex.Message)
        End Try
        Return dt
    End Function


    ' Cari transaksi berdasarkan kode

    Public Function GetTransaksiByKode(kode As String) As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "SELECT t.*, p.nama AS namaPelanggan " &
                "FROM tbtransaksi t " &
                "INNER JOIN tbpelanggan p ON t.kodePelanggan = p.kodePelanggan " &
                "WHERE t.kodeTransaksi = @kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
        End Try
        Return dt
    End Function


    ' Cek duplikat kode transaksi

    Public Function KodeTransaksiSudahAda(kode As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "SELECT COUNT(*) FROM tbtransaksi WHERE kodeTransaksi=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' Simpan transaksi baru

    Public Function SimpanTransaksi(kode As String, kodePelanggan As String,
                                     tanggal As Date, jenisPaket As String,
                                     jumlahGalon As Integer, hargaSatuan As Decimal,
                                     totalBayar As Decimal, statusBayar As String,
                                     keterangan As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "INSERT INTO tbtransaksi " &
                "(kodeTransaksi, kodePelanggan, tanggal, jenisPaket, " &
                "jumlahGalon, hargaSatuan, totalBayar, statusBayar, keterangan) " &
                "VALUES (@kode, @kodePelanggan, @tanggal, @jenisPaket, " &
                "@jumlahGalon, @hargaSatuan, @totalBayar, @statusBayar, @keterangan)"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.Parameters.AddWithValue("@kodePelanggan", kodePelanggan)
            cmd.Parameters.AddWithValue("@tanggal", tanggal)
            cmd.Parameters.AddWithValue("@jenisPaket", jenisPaket)
            cmd.Parameters.AddWithValue("@jumlahGalon", jumlahGalon)
            cmd.Parameters.AddWithValue("@hargaSatuan", hargaSatuan)
            cmd.Parameters.AddWithValue("@totalBayar", totalBayar)
            cmd.Parameters.AddWithValue("@statusBayar", statusBayar)
            cmd.Parameters.AddWithValue("@keterangan",
                If(keterangan = "", DirectCast(DBNull.Value, Object), keterangan))
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Gagal simpan transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    ' Ubah transaksi

    Public Function UbahTransaksi(kode As String, kodePelanggan As String,
                                   tanggal As Date, jenisPaket As String,
                                   jumlahGalon As Integer, hargaSatuan As Decimal,
                                   totalBayar As Decimal, statusBayar As String,
                                   keterangan As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "UPDATE tbtransaksi SET " &
                "kodePelanggan=@kodePelanggan, tanggal=@tanggal, jenisPaket=@jenisPaket, " &
                "jumlahGalon=@jumlahGalon, hargaSatuan=@hargaSatuan, " &
                "totalBayar=@totalBayar, statusBayar=@statusBayar, keterangan=@keterangan " &
                "WHERE kodeTransaksi=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.Parameters.AddWithValue("@kodePelanggan", kodePelanggan)
            cmd.Parameters.AddWithValue("@tanggal", tanggal)
            cmd.Parameters.AddWithValue("@jenisPaket", jenisPaket)
            cmd.Parameters.AddWithValue("@jumlahGalon", jumlahGalon)
            cmd.Parameters.AddWithValue("@hargaSatuan", hargaSatuan)
            cmd.Parameters.AddWithValue("@totalBayar", totalBayar)
            cmd.Parameters.AddWithValue("@statusBayar", statusBayar)
            cmd.Parameters.AddWithValue("@keterangan",
                If(keterangan = "", DirectCast(DBNull.Value, Object), keterangan))
            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MsgBox("Gagal ubah transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    ' Hapus transaksi

    Public Function HapusTransaksi(kode As String) As Boolean
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String = "DELETE FROM tbtransaksi WHERE kodeTransaksi=@kode"
            Dim cmd As New MySqlCommand(query, ConnectionModule.conn)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Gagal hapus transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    ' Ambil semua pelanggan untuk ComboBox

    Public Function GetPelangganUntukCombo() As DataTable
        Dim dt As New DataTable
        Try
            Call ConnectionModule.BukaKoneksi()
            Dim query As String =
                "SELECT kodePelanggan, " &
                "CONCAT(kodePelanggan, ' - ', nama) AS tampil " &
                "FROM tbpelanggan ORDER BY kodePelanggan"
            Dim adapter As New MySqlDataAdapter(query, ConnectionModule.conn)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Gagal load data pelanggan: " & ex.Message)
        End Try
        Return dt
    End Function

End Module