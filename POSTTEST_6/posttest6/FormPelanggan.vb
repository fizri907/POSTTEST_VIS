Imports MySql.Data.MySqlClient '
Public Class FormPelanggan

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub Kosong()
        txtKodePelanggan.Clear()
        txtNama.Clear()
        txtTelepon.Clear()
        txtAlamat.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodePelanggan.Focus()
    End Sub

    Private Sub TampilData()
        Try
            Dim dt As DataTable = GetAllPelanggan()
            If dt IsNot Nothing Then
                dgvPelanggan.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        Dim kodeOk As Boolean = ValidasiTextBox(ErrorProvider1, txtKodePelanggan, "Kode tidak boleh kosong")
        Dim namaOk As Boolean = ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        If Not (kodeOk And namaOk) Then Exit Sub

        Dim kode As String = txtKodePelanggan.Text.Trim()

        If KodePelangganSudahAda(kode) Then
            MessageBox.Show("Kode pelanggan sudah terdaftar.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePelanggan.Focus()
            Exit Sub
        End If

        If SimpanPelanggan(kode, txtNama.Text.Trim(),
                            txtTelepon.Text.Trim(), txtAlamat.Text.Trim()) Then
            MessageBox.Show("Data berhasil disimpan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        Dim kodeOk As Boolean = ValidasiTextBox(ErrorProvider1, txtKodePelanggan, "Kode tidak boleh kosong")
        Dim namaOk As Boolean = ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        If Not (kodeOk And namaOk) Then Exit Sub

        If UbahPelanggan(txtKodePelanggan.Text.Trim(), txtNama.Text.Trim(),
                          txtTelepon.Text.Trim(), txtAlamat.Text.Trim()) Then
            MessageBox.Show("Data berhasil diubah.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePelanggan.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusPelanggan(txtKodePelanggan.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex >= 0 Then

            txtKodePelanggan.Text = dgvPelanggan.Rows(e.RowIndex).Cells("kodePelanggan").Value.ToString()
            txtNama.Text = dgvPelanggan.Rows(e.RowIndex).Cells("nama").Value.ToString()
            txtTelepon.Text = dgvPelanggan.Rows(e.RowIndex).Cells("telepon").Value.ToString()
            txtAlamat.Text = dgvPelanggan.Rows(e.RowIndex).Cells("alamat").Value.ToString()
        End If
    End Sub

    Private Sub txtKodePelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePelanggan.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetPelangganByKode(txtKodePelanggan.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNama.Text = dt.Rows(0)("nama").ToString()
                txtTelepon.Text = dt.Rows(0)("telepon").ToString()
                txtAlamat.Text = dt.Rows(0)("alamat").ToString()
            Else
                txtNama.Clear()
                txtTelepon.Clear()
                txtAlamat.Clear()
            End If
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtTelepon.Focus()
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPelanggan.DataSource = SearchPelanggan(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub menuTransaksi_Click(sender As Object, e As EventArgs) Handles menuTransaksi.Click
        Dim f As New FormTransaksi()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub menuLogout_Click(sender As Object, e As EventArgs) Handles menuLogout.Click
        Dim konfirmasi As DialogResult =
            MessageBox.Show("Apakah Anda ingin logout?", "Konfirmasi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then

            Application.Restart()
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Application.Exit()
    End Sub

End Class