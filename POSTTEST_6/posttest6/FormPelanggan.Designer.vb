<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPelanggan
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		MenuStrip1 = New MenuStrip()
		menuTransaksi = New ToolStripMenuItem()
		menuLogout = New ToolStripMenuItem()
		menuKeluar = New ToolStripMenuItem()
		GroupBox1 = New GroupBox()
		lblKode = New Label()
		txtKodePelanggan = New TextBox()
		lblNama = New Label()
		txtNama = New TextBox()
		lblTelepon = New Label()
		txtTelepon = New TextBox()
		lblAlamat = New Label()
		txtAlamat = New TextBox()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		GroupBox2 = New GroupBox()
		lblCari = New Label()
		txtSearch = New TextBox()
		dgvPelanggan = New DataGridView()
		ErrorProvider1 = New ErrorProvider(components)
		MenuStrip1.SuspendLayout()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()

		MenuStrip1.Items.AddRange(New ToolStripItem() {menuTransaksi, menuLogout, menuKeluar})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Padding = New Padding(7, 2, 0, 2)
		MenuStrip1.Size = New Size(681, 24)
		MenuStrip1.TabIndex = 2
		MenuStrip1.Text = "MenuStrip1"

		menuTransaksi.Name = "menuTransaksi"
		menuTransaksi.Size = New Size(94, 20)
		menuTransaksi.Text = "Data Transaksi"

		menuLogout.Name = "menuLogout"
		menuLogout.Size = New Size(57, 20)
		menuLogout.Text = "Logout"

		menuKeluar.Name = "menuKeluar"
		menuKeluar.Size = New Size(52, 20)
		menuKeluar.Text = "Keluar"

		GroupBox1.Controls.Add(lblKode)
		GroupBox1.Controls.Add(txtKodePelanggan)
		GroupBox1.Controls.Add(lblNama)
		GroupBox1.Controls.Add(txtNama)
		GroupBox1.Controls.Add(lblTelepon)
		GroupBox1.Controls.Add(txtTelepon)
		GroupBox1.Controls.Add(lblAlamat)
		GroupBox1.Controls.Add(txtAlamat)
		GroupBox1.Controls.Add(btnSimpan)
		GroupBox1.Controls.Add(btnUbah)
		GroupBox1.Controls.Add(btnHapus)
		GroupBox1.Controls.Add(btnBatal)
		GroupBox1.Location = New Point(14, 35)
		GroupBox1.Margin = New Padding(4, 3, 4, 3)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Padding = New Padding(4, 3, 4, 3)
		GroupBox1.Size = New Size(653, 190)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Form Input"

		lblKode.AutoSize = True
		lblKode.Location = New Point(12, 29)
		lblKode.Margin = New Padding(4, 0, 4, 0)
		lblKode.Name = "lblKode"
		lblKode.Size = New Size(93, 15)
		lblKode.TabIndex = 0
		lblKode.Text = "Kode Pelanggan"

		txtKodePelanggan.Location = New Point(134, 25)
		txtKodePelanggan.Margin = New Padding(4, 3, 4, 3)
		txtKodePelanggan.MaxLength = 10
		txtKodePelanggan.Name = "txtKodePelanggan"
		txtKodePelanggan.Size = New Size(116, 23)
		txtKodePelanggan.TabIndex = 1

		lblNama.AutoSize = True
		lblNama.Location = New Point(12, 61)
		lblNama.Margin = New Padding(4, 0, 4, 0)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(39, 15)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama"

		txtNama.Location = New Point(134, 58)
		txtNama.Margin = New Padding(4, 3, 4, 3)
		txtNama.MaxLength = 100
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(501, 23)
		txtNama.TabIndex = 3

		lblTelepon.AutoSize = True
		lblTelepon.Location = New Point(12, 93)
		lblTelepon.Margin = New Padding(4, 0, 4, 0)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(71, 15)
		lblTelepon.TabIndex = 4
		lblTelepon.Text = "No. Telepon"

		txtTelepon.Location = New Point(134, 90)
		txtTelepon.Margin = New Padding(4, 3, 4, 3)
		txtTelepon.MaxLength = 15
		txtTelepon.Name = "txtTelepon"
		txtTelepon.Size = New Size(174, 23)
		txtTelepon.TabIndex = 5

		lblAlamat.AutoSize = True
		lblAlamat.Location = New Point(12, 126)
		lblAlamat.Margin = New Padding(4, 0, 4, 0)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(45, 15)
		lblAlamat.TabIndex = 6
		lblAlamat.Text = "Alamat"

		txtAlamat.Location = New Point(134, 122)
		txtAlamat.Margin = New Padding(4, 3, 4, 3)
		txtAlamat.MaxLength = 200
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(501, 23)
		txtAlamat.TabIndex = 7

		btnSimpan.Location = New Point(134, 156)
		btnSimpan.Margin = New Padding(4, 3, 4, 3)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(88, 27)
		btnSimpan.TabIndex = 8
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = True

		btnUbah.Location = New Point(229, 156)
		btnUbah.Margin = New Padding(4, 3, 4, 3)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(88, 27)
		btnUbah.TabIndex = 9
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = True

		btnHapus.Location = New Point(323, 156)
		btnHapus.Margin = New Padding(4, 3, 4, 3)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(88, 27)
		btnHapus.TabIndex = 10
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = True

		btnBatal.Location = New Point(418, 156)
		btnBatal.Margin = New Padding(4, 3, 4, 3)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(88, 27)
		btnBatal.TabIndex = 11
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = True

		GroupBox2.Controls.Add(lblCari)
		GroupBox2.Controls.Add(txtSearch)
		GroupBox2.Controls.Add(dgvPelanggan)
		GroupBox2.Location = New Point(14, 237)
		GroupBox2.Margin = New Padding(4, 3, 4, 3)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Padding = New Padding(4, 3, 4, 3)
		GroupBox2.Size = New Size(653, 265)
		GroupBox2.TabIndex = 1
		GroupBox2.TabStop = False
		GroupBox2.Text = "Data Pelanggan"

		lblCari.AutoSize = True
		lblCari.Location = New Point(12, 25)
		lblCari.Margin = New Padding(4, 0, 4, 0)
		lblCari.Name = "lblCari"
		lblCari.Size = New Size(55, 15)
		lblCari.TabIndex = 0
		lblCari.Text = "Cari Data"

		txtSearch.Location = New Point(82, 22)
		txtSearch.Margin = New Padding(4, 3, 4, 3)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(233, 23)
		txtSearch.TabIndex = 1

		dgvPelanggan.AllowUserToAddRows = False
		dgvPelanggan.AllowUserToDeleteRows = False
		dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPelanggan.Location = New Point(12, 55)
		dgvPelanggan.Margin = New Padding(4, 3, 4, 3)
		dgvPelanggan.MultiSelect = False
		dgvPelanggan.Name = "dgvPelanggan"
		dgvPelanggan.ReadOnly = True
		dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPelanggan.Size = New Size(630, 198)
		dgvPelanggan.TabIndex = 2

		ErrorProvider1.ContainerControl = Me

		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(681, 517)
		Controls.Add(GroupBox1)
		Controls.Add(GroupBox2)
		Controls.Add(MenuStrip1)
		FormBorderStyle = FormBorderStyle.FixedSingle
		MainMenuStrip = MenuStrip1
		Margin = New Padding(4, 3, 4, 3)
		MaximizeBox = False
		Name = "FormPelanggan"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Data Pelanggan — Sistem Informasi Air Isi Ulang"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents menuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents txtKodePelanggan As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class