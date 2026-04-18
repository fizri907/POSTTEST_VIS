<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKodeTransaksi = New System.Windows.Forms.Label()
        Me.txtKodeTransaksi = New System.Windows.Forms.TextBox()
        Me.lblPelanggan = New System.Windows.Forms.Label()
        Me.cmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblJenisPaket = New System.Windows.Forms.Label()
        Me.cmbJenisPaket = New System.Windows.Forms.ComboBox()
        Me.lblJumlahGalon = New System.Windows.Forms.Label()
        Me.txtJumlahGalon = New System.Windows.Forms.TextBox()
        Me.lblHargaSatuan = New System.Windows.Forms.Label()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.lblStatusBayar = New System.Windows.Forms.Label()
        Me.cmbStatusBayar = New System.Windows.Forms.ComboBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.menuPelanggan, Me.menuLogout, Me.menuKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 24)
        Me.MenuStrip1.TabStop = False
        Me.MenuStrip1.Text = "MenuStrip1"

        Me.menuPelanggan.Name = "menuPelanggan"
        Me.menuPelanggan.Size = New System.Drawing.Size(105, 20)
        Me.menuPelanggan.Text = "Data Pelanggan"

        Me.menuLogout.Name = "menuLogout"
        Me.menuLogout.Size = New System.Drawing.Size(56, 20)
        Me.menuLogout.Text = "Logout"

        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(52, 20)
        Me.menuKeluar.Text = "Keluar"

        Me.GroupBox1.Controls.Add(Me.lblKodeTransaksi)
        Me.GroupBox1.Controls.Add(Me.txtKodeTransaksi)
        Me.GroupBox1.Controls.Add(Me.lblPelanggan)
        Me.GroupBox1.Controls.Add(Me.cmbPelanggan)
        Me.GroupBox1.Controls.Add(Me.lblTanggal)
        Me.GroupBox1.Controls.Add(Me.dtpTanggal)
        Me.GroupBox1.Controls.Add(Me.lblJenisPaket)
        Me.GroupBox1.Controls.Add(Me.cmbJenisPaket)
        Me.GroupBox1.Controls.Add(Me.lblJumlahGalon)
        Me.GroupBox1.Controls.Add(Me.txtJumlahGalon)
        Me.GroupBox1.Controls.Add(Me.lblHargaSatuan)
        Me.GroupBox1.Controls.Add(Me.txtHargaSatuan)
        Me.GroupBox1.Controls.Add(Me.lblTotalBayar)
        Me.GroupBox1.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox1.Controls.Add(Me.lblStatusBayar)
        Me.GroupBox1.Controls.Add(Me.cmbStatusBayar)
        Me.GroupBox1.Controls.Add(Me.lblKeterangan)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Input Transaksi"

        Me.lblKodeTransaksi.AutoSize = True
        Me.lblKodeTransaksi.Location = New System.Drawing.Point(10, 26)
        Me.lblKodeTransaksi.Name = "lblKodeTransaksi"
        Me.lblKodeTransaksi.Text = "Kode Transaksi"

        Me.txtKodeTransaksi.Location = New System.Drawing.Point(125, 23)
        Me.txtKodeTransaksi.MaxLength = 10
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeTransaksi.TabIndex = 1

        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(380, 26)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Text = "Tanggal"

        Me.dtpTanggal.Format = DateTimePickerFormat.Short
        Me.dtpTanggal.Location = New System.Drawing.Point(450, 23)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(110, 20)
        Me.dtpTanggal.TabIndex = 2

        Me.lblPelanggan.AutoSize = True
        Me.lblPelanggan.Location = New System.Drawing.Point(10, 55)
        Me.lblPelanggan.Name = "lblPelanggan"
        Me.lblPelanggan.Text = "Pelanggan"

        Me.cmbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbPelanggan.Location = New System.Drawing.Point(125, 52)
        Me.cmbPelanggan.Name = "cmbPelanggan"
        Me.cmbPelanggan.Size = New System.Drawing.Size(280, 21)
        Me.cmbPelanggan.TabIndex = 3

        Me.lblJenisPaket.AutoSize = True
        Me.lblJenisPaket.Location = New System.Drawing.Point(10, 85)
        Me.lblJenisPaket.Name = "lblJenisPaket"
        Me.lblJenisPaket.Text = "Jenis Paket"

        Me.cmbJenisPaket.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbJenisPaket.Items.AddRange(New Object() {
            "Galon 19L", "Galon 10L", "Cup 240ml", "Botol 600ml", "Botol 1500ml"})
        Me.cmbJenisPaket.Location = New System.Drawing.Point(125, 82)
        Me.cmbJenisPaket.Name = "cmbJenisPaket"
        Me.cmbJenisPaket.Size = New System.Drawing.Size(160, 21)
        Me.cmbJenisPaket.TabIndex = 4

        Me.lblJumlahGalon.AutoSize = True
        Me.lblJumlahGalon.Location = New System.Drawing.Point(10, 115)
        Me.lblJumlahGalon.Name = "lblJumlahGalon"
        Me.lblJumlahGalon.Text = "Jumlah"

        Me.txtJumlahGalon.Location = New System.Drawing.Point(125, 112)
        Me.txtJumlahGalon.MaxLength = 5
        Me.txtJumlahGalon.Name = "txtJumlahGalon"
        Me.txtJumlahGalon.Size = New System.Drawing.Size(70, 20)
        Me.txtJumlahGalon.TabIndex = 5

        Me.lblHargaSatuan.AutoSize = True
        Me.lblHargaSatuan.Location = New System.Drawing.Point(215, 115)
        Me.lblHargaSatuan.Name = "lblHargaSatuan"
        Me.lblHargaSatuan.Text = "Harga Satuan (Rp)"

        Me.txtHargaSatuan.Location = New System.Drawing.Point(330, 112)
        Me.txtHargaSatuan.MaxLength = 12
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaSatuan.TabIndex = 6

        Me.lblTotalBayar.AutoSize = True
        Me.lblTotalBayar.Location = New System.Drawing.Point(10, 145)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Text = "Total Bayar (Rp)"

        Me.txtTotalBayar.Location = New System.Drawing.Point(125, 142)
        Me.txtTotalBayar.MaxLength = 15
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.BackColor = System.Drawing.Color.LightYellow
        Me.txtTotalBayar.Size = New System.Drawing.Size(130, 20)
        Me.txtTotalBayar.TabIndex = 7

        Me.lblStatusBayar.AutoSize = True
        Me.lblStatusBayar.Location = New System.Drawing.Point(290, 145)
        Me.lblStatusBayar.Name = "lblStatusBayar"
        Me.lblStatusBayar.Text = "Status Pembayaran"

        Me.cmbStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbStatusBayar.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.cmbStatusBayar.Location = New System.Drawing.Point(420, 142)
        Me.cmbStatusBayar.Name = "cmbStatusBayar"
        Me.cmbStatusBayar.Size = New System.Drawing.Size(120, 21)
        Me.cmbStatusBayar.TabIndex = 8

        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(10, 175)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Text = "Keterangan"

        Me.txtKeterangan.Location = New System.Drawing.Point(125, 172)
        Me.txtKeterangan.MaxLength = 255
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(515, 20)
        Me.txtKeterangan.TabIndex = 9

        Me.btnSimpan.Location = New System.Drawing.Point(125, 210)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 28)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True

        Me.btnUbah.Location = New System.Drawing.Point(210, 210)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 28)
        Me.btnUbah.TabIndex = 11
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True

        Me.btnHapus.Location = New System.Drawing.Point(295, 210)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 28)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True

        Me.btnBatal.Location = New System.Drawing.Point(380, 210)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 28)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True

        Me.GroupBox2.Controls.Add(Me.lblCari)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.dgvTransaksi)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Transaksi"

        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(10, 22)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Text = "Cari Data"

        Me.txtSearch.Location = New System.Drawing.Point(75, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 20)
        Me.txtSearch.TabIndex = 0

        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(10, 48)
        Me.dgvTransaksi.MultiSelect = False
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaksi.Size = New System.Drawing.Size(636, 192)
        Me.dgvTransaksi.TabIndex = 1

        Me.ErrorProvider1.ContainerControl = Me

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Air Isi Ulang — Sistem Informasi Air Isi Ulang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKodeTransaksi As System.Windows.Forms.Label
    Friend WithEvents txtKodeTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents lblPelanggan As System.Windows.Forms.Label
    Friend WithEvents cmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJenisPaket As System.Windows.Forms.Label
    Friend WithEvents cmbJenisPaket As System.Windows.Forms.ComboBox
    Friend WithEvents lblJumlahGalon As System.Windows.Forms.Label
    Friend WithEvents txtJumlahGalon As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaSatuan As System.Windows.Forms.Label
    Friend WithEvents txtHargaSatuan As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBayar As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusBayar As System.Windows.Forms.Label
    Friend WithEvents cmbStatusBayar As System.Windows.Forms.ComboBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class