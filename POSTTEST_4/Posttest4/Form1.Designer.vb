<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LihatKartuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BukaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.cbKomunitas = New System.Windows.Forms.ComboBox()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.txtAlamat = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.mtxtTelepon = New System.Windows.Forms.MaskedTextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.CheckBox8 = New System.Windows.Forms.CheckBox()
		Me.btnCetak = New System.Windows.Forms.Button()
		Me.CheckBox7 = New System.Windows.Forms.CheckBox()
		Me.btnBrowse = New System.Windows.Forms.Button()
		Me.CheckBox6 = New System.Windows.Forms.CheckBox()
		Me.PicFoto = New System.Windows.Forms.PictureBox()
		Me.CheckBox5 = New System.Windows.Forms.CheckBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadioButton6 = New System.Windows.Forms.RadioButton()
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.CheckBox4 = New System.Windows.Forms.CheckBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LihatKartuToolStripMenuItem, Me.SimpanDataToolStripMenuItem, Me.BukaDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'InputDataToolStripMenuItem
		'
		Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
		Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
		Me.InputDataToolStripMenuItem.Text = "Input Data"
		'
		'LihatKartuToolStripMenuItem
		'
		Me.LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
		Me.LihatKartuToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
		Me.LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
		'
		'SimpanDataToolStripMenuItem
		'
		Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
		Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
		Me.SimpanDataToolStripMenuItem.Text = "Simpan Data"
		'
		'BukaDataToolStripMenuItem
		'
		Me.BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
		Me.BukaDataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
		Me.BukaDataToolStripMenuItem.Text = "Buka Data"
		'
		'KeluarToolStripMenuItem
		'
		Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.KeluarToolStripMenuItem.Text = "Keluar"
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
		'
		'TabControl1
		'
		Me.TabControl1.AccessibleName = ""
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(12, 38)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(395, 322)
		Me.TabControl1.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.cbKomunitas)
		Me.TabPage1.Controls.Add(Me.RadioButton2)
		Me.TabPage1.Controls.Add(Me.RadioButton1)
		Me.TabPage1.Controls.Add(Me.dtpLahir)
		Me.TabPage1.Controls.Add(Me.txtID)
		Me.TabPage1.Controls.Add(Me.txtNama)
		Me.TabPage1.Controls.Add(Me.Label5)
		Me.TabPage1.Controls.Add(Me.Label4)
		Me.TabPage1.Controls.Add(Me.Label3)
		Me.TabPage1.Controls.Add(Me.Label2)
		Me.TabPage1.Controls.Add(Me.Label1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(387, 296)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Data Utama"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'cbKomunitas
		'
		Me.cbKomunitas.FormattingEnabled = True
		Me.cbKomunitas.Items.AddRange(New Object() {"Programmer", "Desain Grafis", "Multimedia", "Gaming", "Robotik"})
		Me.cbKomunitas.Location = New System.Drawing.Point(246, 251)
		Me.cbKomunitas.Name = "cbKomunitas"
		Me.cbKomunitas.Size = New System.Drawing.Size(100, 21)
		Me.cbKomunitas.TabIndex = 10
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(246, 194)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
		Me.RadioButton2.TabIndex = 9
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "Perempuan"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(246, 160)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
		Me.RadioButton1.TabIndex = 8
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Laki-laki"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'dtpLahir
		'
		Me.dtpLahir.Location = New System.Drawing.Point(246, 108)
		Me.dtpLahir.Name = "dtpLahir"
		Me.dtpLahir.Size = New System.Drawing.Size(100, 20)
		Me.dtpLahir.TabIndex = 7
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(246, 61)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(100, 20)
		Me.txtID.TabIndex = 6
		'
		'txtNama
		'
		Me.txtNama.Location = New System.Drawing.Point(246, 22)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(100, 20)
		Me.txtNama.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(14, 254)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(79, 18)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Komunitas"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(14, 178)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(100, 18)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Jenis Kelamin"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 108)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(96, 18)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Tanggal Lahir"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 18)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "ID Anggota"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(14, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 18)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nama"
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.txtAlamat)
		Me.TabPage2.Controls.Add(Me.txtEmail)
		Me.TabPage2.Controls.Add(Me.mtxtTelepon)
		Me.TabPage2.Controls.Add(Me.Label8)
		Me.TabPage2.Controls.Add(Me.Label7)
		Me.TabPage2.Controls.Add(Me.Label6)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(387, 296)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Kontak & Info"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'txtAlamat
		'
		Me.txtAlamat.Location = New System.Drawing.Point(218, 119)
		Me.txtAlamat.Multiline = True
		Me.txtAlamat.Name = "txtAlamat"
		Me.txtAlamat.Size = New System.Drawing.Size(100, 20)
		Me.txtAlamat.TabIndex = 5
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(218, 70)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(100, 20)
		Me.txtEmail.TabIndex = 4
		'
		'mtxtTelepon
		'
		Me.mtxtTelepon.Location = New System.Drawing.Point(218, 22)
		Me.mtxtTelepon.Mask = "0000-0000-0000"
		Me.mtxtTelepon.Name = "mtxtTelepon"
		Me.mtxtTelepon.Size = New System.Drawing.Size(100, 20)
		Me.mtxtTelepon.TabIndex = 3
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(28, 118)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(53, 18)
		Me.Label8.TabIndex = 2
		Me.Label8.Text = "Alamat"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(28, 72)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(45, 18)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "Email"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(20, 21)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(112, 18)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Nomor Telepon"
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.CheckBox8)
		Me.TabPage3.Controls.Add(Me.btnCetak)
		Me.TabPage3.Controls.Add(Me.CheckBox7)
		Me.TabPage3.Controls.Add(Me.btnBrowse)
		Me.TabPage3.Controls.Add(Me.CheckBox6)
		Me.TabPage3.Controls.Add(Me.PicFoto)
		Me.TabPage3.Controls.Add(Me.CheckBox5)
		Me.TabPage3.Controls.Add(Me.GroupBox1)
		Me.TabPage3.Controls.Add(Me.CheckBox4)
		Me.TabPage3.Controls.Add(Me.CheckBox1)
		Me.TabPage3.Controls.Add(Me.CheckBox3)
		Me.TabPage3.Controls.Add(Me.CheckBox2)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(387, 296)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Profil & Aktivitas"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'CheckBox8
		'
		Me.CheckBox8.AutoSize = True
		Me.CheckBox8.Location = New System.Drawing.Point(285, 191)
		Me.CheckBox8.Name = "CheckBox8"
		Me.CheckBox8.Size = New System.Drawing.Size(80, 17)
		Me.CheckBox8.TabIndex = 11
		Me.CheckBox8.Text = "Networking"
		Me.CheckBox8.UseVisualStyleBackColor = True
		'
		'btnCetak
		'
		Me.btnCetak.Location = New System.Drawing.Point(145, 258)
		Me.btnCetak.Name = "btnCetak"
		Me.btnCetak.Size = New System.Drawing.Size(227, 23)
		Me.btnCetak.TabIndex = 2
		Me.btnCetak.Text = "Simpan & Cetak Kartu"
		Me.btnCetak.UseVisualStyleBackColor = True
		'
		'CheckBox7
		'
		Me.CheckBox7.AutoSize = True
		Me.CheckBox7.Location = New System.Drawing.Point(285, 168)
		Me.CheckBox7.Name = "CheckBox7"
		Me.CheckBox7.Size = New System.Drawing.Size(102, 17)
		Me.CheckBox7.TabIndex = 10
		Me.CheckBox7.Text = "Publix Speaking"
		Me.CheckBox7.UseVisualStyleBackColor = True
		'
		'btnBrowse
		'
		Me.btnBrowse.Location = New System.Drawing.Point(30, 221)
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowse.Size = New System.Drawing.Size(102, 23)
		Me.btnBrowse.TabIndex = 1
		Me.btnBrowse.Text = "Browse Foto"
		Me.btnBrowse.UseVisualStyleBackColor = True
		'
		'CheckBox6
		'
		Me.CheckBox6.AutoSize = True
		Me.CheckBox6.Location = New System.Drawing.Point(285, 145)
		Me.CheckBox6.Name = "CheckBox6"
		Me.CheckBox6.Size = New System.Drawing.Size(67, 17)
		Me.CheckBox6.TabIndex = 9
		Me.CheckBox6.Text = "Fotografi"
		Me.CheckBox6.UseVisualStyleBackColor = True
		'
		'PicFoto
		'
		Me.PicFoto.Location = New System.Drawing.Point(16, 16)
		Me.PicFoto.Name = "PicFoto"
		Me.PicFoto.Size = New System.Drawing.Size(132, 180)
		Me.PicFoto.TabIndex = 0
		Me.PicFoto.TabStop = False
		'
		'CheckBox5
		'
		Me.CheckBox5.AutoSize = True
		Me.CheckBox5.Location = New System.Drawing.Point(285, 122)
		Me.CheckBox5.Name = "CheckBox5"
		Me.CheckBox5.Size = New System.Drawing.Size(62, 17)
		Me.CheckBox5.TabIndex = 8
		Me.CheckBox5.Text = "Menulis"
		Me.CheckBox5.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RadioButton6)
		Me.GroupBox1.Controls.Add(Me.RadioButton5)
		Me.GroupBox1.Controls.Add(Me.RadioButton4)
		Me.GroupBox1.Controls.Add(Me.RadioButton3)
		Me.GroupBox1.Location = New System.Drawing.Point(181, 16)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Peran dalam Komunitas"
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Location = New System.Drawing.Point(104, 71)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(54, 17)
		Me.RadioButton6.TabIndex = 3
		Me.RadioButton6.TabStop = True
		Me.RadioButton6.Text = "Admin"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(99, 25)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(65, 17)
		Me.RadioButton5.TabIndex = 2
		Me.RadioButton5.TabStop = True
		Me.RadioButton5.Text = "Anggota"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(8, 71)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(52, 17)
		Me.RadioButton4.TabIndex = 1
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "Wakil"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(3, 25)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(53, 17)
		Me.RadioButton3.TabIndex = 0
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "Ketua"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'CheckBox4
		'
		Me.CheckBox4.AutoSize = True
		Me.CheckBox4.Location = New System.Drawing.Point(178, 191)
		Me.CheckBox4.Name = "CheckBox4"
		Me.CheckBox4.Size = New System.Drawing.Size(62, 17)
		Me.CheckBox4.TabIndex = 7
		Me.CheckBox4.Text = "Gaming"
		Me.CheckBox4.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(178, 122)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
		Me.CheckBox1.TabIndex = 4
		Me.CheckBox1.Text = "Coding"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.Location = New System.Drawing.Point(178, 168)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Size = New System.Drawing.Size(88, 17)
		Me.CheckBox3.TabIndex = 6
		Me.CheckBox3.Text = "Editing Video"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Location = New System.Drawing.Point(178, 145)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
		Me.CheckBox2.TabIndex = 5
		Me.CheckBox2.Text = "Desain"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents dtpLahir As DateTimePicker
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents cbKomunitas As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents mtxtTelepon As MaskedTextBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents btnBrowse As Button
	Friend WithEvents PicFoto As PictureBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents RadioButton6 As RadioButton
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
End Class
