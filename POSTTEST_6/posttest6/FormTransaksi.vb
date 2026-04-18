Public Class FormTransaksi


	' Kosongkan semua input

	Private Sub Kosong()
		txtKodeTransaksi.Clear()
		cmbPelanggan.SelectedIndex = -1
		cmbPelanggan.Text = ""
		dtpTanggal.Value = Now.Date
		cmbJenisPaket.SelectedIndex = 0
		txtJumlahGalon.Clear()
		txtHargaSatuan.Clear()
		txtTotalBayar.Clear()
		cmbStatusBayar.SelectedIndex = 0
		txtKeterangan.Clear()
		txtSearch.Clear()
		ErrorProvider1.Clear()
		txtKodeTransaksi.Focus()
	End Sub


	' Tampilkan semua data ke DataGridView

	Private Sub TampilData()
		dgvTransaksi.DataSource = GetAllTransaksi()
		dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
	End Sub


	' Hitung otomatis total bayar

	Private Sub HitungTotal()
		Dim galon As Integer
		Dim harga As Decimal
		If Integer.TryParse(txtJumlahGalon.Text.Trim(), galon) AndAlso
		   Decimal.TryParse(txtHargaSatuan.Text.Trim(), harga) Then
			txtTotalBayar.Text = (galon * harga).ToString()
		End If
	End Sub


	Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim dtPelanggan As DataTable = GetPelangganUntukCombo()
		cmbPelanggan.DataSource = dtPelanggan

		cmbPelanggan.DisplayMember = "nama"

		cmbPelanggan.ValueMember = "kodePelanggan"
		cmbPelanggan.SelectedIndex = -1

		TampilData()
		Kosong()
	End Sub


	' Tombol Simpan

	Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
		ErrorProvider1.Clear()

		Dim kodeOk As Boolean = ValidasiTextBox(ErrorProvider1, txtKodeTransaksi, "Kode transaksi tidak boleh kosong")
		Dim galanOk As Boolean = ValidasiTextBox(ErrorProvider1, txtJumlahGalon, "Jumlah galon tidak boleh kosong")
		Dim hargaOk As Boolean = ValidasiTextBox(ErrorProvider1, txtHargaSatuan, "Harga satuan tidak boleh kosong")

		If cmbPelanggan.SelectedIndex < 0 Then
			ErrorProvider1.SetError(cmbPelanggan, "Pilih pelanggan terlebih dahulu")
			Exit Sub
		End If

		If Not (kodeOk And galanOk And hargaOk) Then Exit Sub

		Dim kode As String = txtKodeTransaksi.Text.Trim()
		If KodeTransaksiSudahAda(kode) Then
			MessageBox.Show("Kode transaksi sudah terdaftar.", "Peringatan",
							MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtKodeTransaksi.Focus()
			Exit Sub
		End If

		HitungTotal()

		Dim kodePelanggan As String = cmbPelanggan.SelectedValue.ToString()
		Dim tanggal As Date = dtpTanggal.Value.Date
		Dim jenisPaket As String = cmbJenisPaket.Text
		Dim jumlahGalon As Integer = Convert.ToInt32(txtJumlahGalon.Text.Trim())
		Dim hargaSatuan As Decimal = Convert.ToDecimal(txtHargaSatuan.Text.Trim())
		Dim totalBayar As Decimal = Convert.ToDecimal(txtTotalBayar.Text.Trim())
		Dim statusBayar As String = cmbStatusBayar.Text
		Dim keterangan As String = txtKeterangan.Text.Trim()

		If SimpanTransaksi(kode, kodePelanggan, tanggal, jenisPaket,
						   jumlahGalon, hargaSatuan, totalBayar, statusBayar, keterangan) Then
			MessageBox.Show("Transaksi berhasil disimpan.", "Informasi",
							MessageBoxButtons.OK, MessageBoxIcon.Information)
			TampilData()
			Kosong()
		End If
	End Sub


	' Tombol Ubah

	Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
		ErrorProvider1.Clear()

		Dim kodeOk As Boolean = ValidasiTextBox(ErrorProvider1, txtKodeTransaksi, "Kode transaksi tidak boleh kosong")
		Dim galanOk As Boolean = ValidasiTextBox(ErrorProvider1, txtJumlahGalon, "Jumlah galon tidak boleh kosong")
		Dim hargaOk As Boolean = ValidasiTextBox(ErrorProvider1, txtHargaSatuan, "Harga satuan tidak boleh kosong")

		If cmbPelanggan.SelectedIndex < 0 Then
			ErrorProvider1.SetError(cmbPelanggan, "Pilih pelanggan terlebih dahulu")
			Exit Sub
		End If

		If Not (kodeOk And galanOk And hargaOk) Then Exit Sub

		HitungTotal()

		Dim kode As String = txtKodeTransaksi.Text.Trim()
		Dim kodePelanggan As String = cmbPelanggan.SelectedValue.ToString()
		Dim tanggal As Date = dtpTanggal.Value.Date
		Dim jenisPaket As String = cmbJenisPaket.Text
		Dim jumlahGalon As Integer = Convert.ToInt32(txtJumlahGalon.Text.Trim())
		Dim hargaSatuan As Decimal = Convert.ToDecimal(txtHargaSatuan.Text.Trim())
		Dim totalBayar As Decimal = Convert.ToDecimal(txtTotalBayar.Text.Trim())
		Dim statusBayar As String = cmbStatusBayar.Text
		Dim keterangan As String = txtKeterangan.Text.Trim()

		If UbahTransaksi(kode, kodePelanggan, tanggal, jenisPaket,
						 jumlahGalon, hargaSatuan, totalBayar, statusBayar, keterangan) Then
			MessageBox.Show("Transaksi berhasil diubah.", "Informasi",
							MessageBoxButtons.OK, MessageBoxIcon.Information)
			TampilData()
			Kosong()
		Else
			MessageBox.Show("Data tidak ditemukan.", "Peringatan",
							MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub


	' Tombol Hapus

	Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
		If txtKodeTransaksi.Text.Trim() = "" Then
			MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan",
							MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Exit Sub
		End If

		Dim konfirmasi As DialogResult =
			MessageBox.Show("Apakah transaksi ini ingin dihapus?", "Konfirmasi",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If konfirmasi = DialogResult.Yes Then
			If HapusTransaksi(txtKodeTransaksi.Text.Trim()) Then
				MessageBox.Show("Transaksi berhasil dihapus.", "Informasi",
								MessageBoxButtons.OK, MessageBoxIcon.Information)
				TampilData()
				Kosong()
			End If
		End If
	End Sub


	' Tombol Batal

	Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
		Kosong()
		TampilData()
	End Sub


	Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
		Handles dgvTransaksi.CellClick
		If e.RowIndex >= 0 Then
			Dim row As DataGridViewRow = dgvTransaksi.Rows(e.RowIndex)
			txtKodeTransaksi.Text = row.Cells("kodeTransaksi").Value.ToString()
			cmbPelanggan.SelectedValue = row.Cells("kodePelanggan").Value.ToString()
			Dim tgl As Date
			If Date.TryParse(row.Cells("tanggal").Value.ToString(), tgl) Then
				dtpTanggal.Value = tgl
			End If
			cmbJenisPaket.Text = row.Cells("jenisPaket").Value.ToString()
			txtJumlahGalon.Text = row.Cells("jumlahGalon").Value.ToString()
			txtHargaSatuan.Text = row.Cells("hargaSatuan").Value.ToString()
			txtTotalBayar.Text = row.Cells("totalBayar").Value.ToString()
			cmbStatusBayar.Text = row.Cells("statusBayar").Value.ToString()
			If row.Cells("keterangan").Value IsNot DBNull.Value AndAlso
			   row.Cells("keterangan").Value IsNot Nothing Then
				txtKeterangan.Text = row.Cells("keterangan").Value.ToString()
			Else
				txtKeterangan.Clear()
			End If
		End If
	End Sub


	Private Sub txtKodeTransaksi_KeyPress(sender As Object, e As KeyPressEventArgs) _
		Handles txtKodeTransaksi.KeyPress
		If IsEnterKey(e) Then
			e.Handled = True
			Dim dt As DataTable = GetTransaksiByKode(txtKodeTransaksi.Text.Trim())
			If dt.Rows.Count > 0 Then
				cmbPelanggan.SelectedValue = dt.Rows(0)("kodePelanggan").ToString()
				Dim tgl As Date
				If Date.TryParse(dt.Rows(0)("tanggal").ToString(), tgl) Then
					dtpTanggal.Value = tgl
				End If
				cmbJenisPaket.Text = dt.Rows(0)("jenisPaket").ToString()
				txtJumlahGalon.Text = dt.Rows(0)("jumlahGalon").ToString()
				txtHargaSatuan.Text = dt.Rows(0)("hargaSatuan").ToString()
				txtTotalBayar.Text = dt.Rows(0)("totalBayar").ToString()
				cmbStatusBayar.Text = dt.Rows(0)("statusBayar").ToString()
				If dt.Rows(0)("keterangan") IsNot DBNull.Value Then
					txtKeterangan.Text = dt.Rows(0)("keterangan").ToString()
				End If
			End If
			cmbPelanggan.Focus()
		End If
	End Sub


	' Hanya angka untuk txtJumlahGalon

	Private Sub txtJumlahGalon_KeyPress(sender As Object, e As KeyPressEventArgs) _
		Handles txtJumlahGalon.KeyPress
		HanyaAngka(e)
		If IsEnterKey(e) Then
			e.Handled = True
			HitungTotal()
			txtHargaSatuan.Focus()
		End If
	End Sub


	Private Sub txtHargaSatuan_KeyPress(sender As Object, e As KeyPressEventArgs) _
		Handles txtHargaSatuan.KeyPress
		If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = "."c) Then
			e.Handled = True
		End If
		If IsEnterKey(e) Then
			e.Handled = True
			HitungTotal()
			cmbStatusBayar.Focus()
		End If
	End Sub


	Private Sub txtJumlahGalon_TextChanged(sender As Object, e As EventArgs) _
		Handles txtJumlahGalon.TextChanged
		HitungTotal()
	End Sub

	Private Sub txtHargaSatuan_TextChanged(sender As Object, e As EventArgs) _
		Handles txtHargaSatuan.TextChanged
		HitungTotal()
	End Sub


	' Search real-time

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) _
		Handles txtSearch.TextChanged
		If txtSearch.Text.Trim() = "" Then
			TampilData()
		Else
			dgvTransaksi.DataSource = SearchTransaksi(txtSearch.Text.Trim())
			dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		End If
	End Sub


	' Menu: Ke Form Pelanggan

	Private Sub menuPelanggan_Click(sender As Object, e As EventArgs) Handles menuPelanggan.Click
		Dim f As New FormPelanggan()
		f.Show()
		Me.Hide()
	End Sub


	' Menu: Logout

	Private Sub menuLogout_Click(sender As Object, e As EventArgs) Handles menuLogout.Click
		Dim konfirmasi As DialogResult =
			MessageBox.Show("Apakah Anda ingin logout?", "Konfirmasi",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If konfirmasi = DialogResult.Yes Then
			Dim f As New FormTransaksi()
			f.Show()
			Me.Close()
		End If
	End Sub


	' Menu: Keluar Aplikasi

	Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
		Application.Exit()
	End Sub

	Private Sub txtKodeTransaksi_TextChanged(sender As Object, e As EventArgs) Handles txtKodeTransaksi.TextChanged

	End Sub
End Class