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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogout, Me.menuKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabStop = False
        Me.MenuStrip1.Text = "MenuStrip1"

        Me.menuLogout.Name = "menuLogout"
        Me.menuLogout.Size = New System.Drawing.Size(80, 20)
        Me.menuLogout.Text = "Logout"

        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(56, 20)
        Me.menuKeluar.Text = "Keluar"

        Me.GroupBox1.Controls.Add(Me.lblKode)
        Me.GroupBox1.Controls.Add(Me.txtKodePelanggan)
        Me.GroupBox1.Controls.Add(Me.lblNama)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.lblTelepon)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.lblAlamat)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnUbah)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Input"

        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(10, 25)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(90, 13)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "Kode Pelanggan"

        Me.txtKodePelanggan.Location = New System.Drawing.Point(115, 22)
        Me.txtKodePelanggan.MaxLength = 10
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txtKodePelanggan.TabIndex = 1

        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(10, 53)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(33, 13)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"

        Me.txtNama.Location = New System.Drawing.Point(115, 50)
        Me.txtNama.MaxLength = 100
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(430, 20)
        Me.txtNama.TabIndex = 3

        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(10, 81)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(60, 13)
        Me.lblTelepon.TabIndex = 4
        Me.lblTelepon.Text = "No. Telepon"

        Me.txtTelepon.Location = New System.Drawing.Point(115, 78)
        Me.txtTelepon.MaxLength = 15
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(150, 20)
        Me.txtTelepon.TabIndex = 5

        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(10, 109)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(40, 13)
        Me.lblAlamat.TabIndex = 6
        Me.lblAlamat.Text = "Alamat"

        Me.txtAlamat.Location = New System.Drawing.Point(115, 106)
        Me.txtAlamat.MaxLength = 200
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(430, 20)
        Me.txtAlamat.TabIndex = 7

        Me.btnSimpan.Location = New System.Drawing.Point(115, 135)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True

        Me.btnUbah.Location = New System.Drawing.Point(196, 135)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True

        Me.btnHapus.Location = New System.Drawing.Point(277, 135)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True

        Me.btnBatal.Location = New System.Drawing.Point(358, 135)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True

        Me.GroupBox2.Controls.Add(Me.lblCari)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.dgvPelanggan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 230)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pelanggan"

        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(10, 22)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(50, 13)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Cari Data"

        Me.txtSearch.Location = New System.Drawing.Point(70, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 1

        Me.dgvPelanggan.AllowUserToAddRows = False
        Me.dgvPelanggan.AllowUserToDeleteRows = False
        Me.dgvPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelanggan.Location = New System.Drawing.Point(10, 48)
        Me.dgvPelanggan.MultiSelect = False
        Me.dgvPelanggan.Name = "dgvPelanggan"
        Me.dgvPelanggan.ReadOnly = True
        Me.dgvPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPelanggan.Size = New System.Drawing.Size(540, 172)
        Me.dgvPelanggan.TabIndex = 2

        Me.ErrorProvider1.ContainerControl = Me

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pelanggan — Sistem Informasi Air Isi Ulang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
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