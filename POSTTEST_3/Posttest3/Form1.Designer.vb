<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		PictureBox1 = New PictureBox()
		Button1 = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		tbNama = New TextBox()
		tbUmur = New TextBox()
		tbNomor = New TextBox()
		tbAlamat = New TextBox()
		dtTanggal = New DateTimePicker()
		GroupBox1 = New GroupBox()
		rbPerempuan = New RadioButton()
		rbLaki = New RadioButton()
		GroupBox2 = New GroupBox()
		CheckBox10 = New CheckBox()
		CheckBox9 = New CheckBox()
		CheckBox8 = New CheckBox()
		CheckBox7 = New CheckBox()
		CheckBox6 = New CheckBox()
		CheckBox5 = New CheckBox()
		CheckBox4 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox1 = New CheckBox()
		Button2 = New Button()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = SystemColors.ButtonHighlight
		PictureBox1.Location = New Point(27, 40)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(188, 249)
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Button1
		' 
		Button1.Location = New Point(79, 319)
		Button1.Name = "Button1"
		Button1.Size = New Size(83, 23)
		Button1.TabIndex = 1
		Button1.Text = "browse Foto"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = SystemColors.ButtonHighlight
		Label1.Location = New Point(275, 48)
		Label1.Name = "Label1"
		Label1.Size = New Size(47, 15)
		Label1.TabIndex = 2
		Label1.Text = "Nama :"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = SystemColors.ButtonHighlight
		Label2.Location = New Point(275, 86)
		Label2.Name = "Label2"
		Label2.Size = New Size(44, 15)
		Label2.TabIndex = 3
		Label2.Text = "Umur :"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = SystemColors.ButtonHighlight
		Label3.Location = New Point(275, 122)
		Label3.Name = "Label3"
		Label3.Size = New Size(89, 15)
		Label3.TabIndex = 4
		Label3.Text = "Tanggal Lahir :"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = SystemColors.ButtonHighlight
		Label4.Location = New Point(275, 166)
		Label4.Name = "Label4"
		Label4.Size = New Size(72, 15)
		Label4.TabIndex = 5
		Label4.Text = "No. Telpon :"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = SystemColors.ButtonHighlight
		Label5.Location = New Point(275, 208)
		Label5.Name = "Label5"
		Label5.Size = New Size(53, 15)
		Label5.TabIndex = 6
		Label5.Text = "Alamat :"
		' 
		' tbNama
		' 
		tbNama.Location = New Point(381, 40)
		tbNama.Name = "tbNama"
		tbNama.Size = New Size(100, 24)
		tbNama.TabIndex = 7
		' 
		' tbUmur
		' 
		tbUmur.Location = New Point(381, 78)
		tbUmur.Name = "tbUmur"
		tbUmur.Size = New Size(100, 24)
		tbUmur.TabIndex = 8
		' 
		' tbNomor
		' 
		tbNomor.Location = New Point(381, 158)
		tbNomor.Name = "tbNomor"
		tbNomor.Size = New Size(100, 24)
		tbNomor.TabIndex = 9
		' 
		' tbAlamat
		' 
		tbAlamat.Location = New Point(381, 200)
		tbAlamat.Name = "tbAlamat"
		tbAlamat.Size = New Size(100, 24)
		tbAlamat.TabIndex = 10
		' 
		' dtTanggal
		' 
		dtTanggal.Location = New Point(381, 114)
		dtTanggal.Name = "dtTanggal"
		dtTanggal.Size = New Size(100, 24)
		dtTanggal.TabIndex = 11
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = SystemColors.ButtonHighlight
		GroupBox1.Controls.Add(rbPerempuan)
		GroupBox1.Controls.Add(rbLaki)
		GroupBox1.Location = New Point(253, 251)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(236, 145)
		GroupBox1.TabIndex = 12
		GroupBox1.TabStop = False
		GroupBox1.Text = "Jenis Kelamin"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(12, 62)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(88, 19)
		rbPerempuan.TabIndex = 1
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(3, 19)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(80, 19)
		rbLaki.TabIndex = 0
		rbLaki.TabStop = True
		rbLaki.Text = "Laki - Laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = SystemColors.ButtonHighlight
		GroupBox2.Controls.Add(CheckBox10)
		GroupBox2.Controls.Add(CheckBox9)
		GroupBox2.Controls.Add(CheckBox8)
		GroupBox2.Controls.Add(CheckBox7)
		GroupBox2.Controls.Add(CheckBox6)
		GroupBox2.Controls.Add(CheckBox5)
		GroupBox2.Controls.Add(CheckBox4)
		GroupBox2.Controls.Add(CheckBox3)
		GroupBox2.Controls.Add(CheckBox2)
		GroupBox2.Controls.Add(CheckBox1)
		GroupBox2.Location = New Point(515, 251)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(273, 145)
		GroupBox2.TabIndex = 0
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hobby"
		' 
		' CheckBox10
		' 
		CheckBox10.AutoSize = True
		CheckBox10.Location = New Point(177, 122)
		CheckBox10.Name = "CheckBox10"
		CheckBox10.Size = New Size(64, 19)
		CheckBox10.TabIndex = 9
		CheckBox10.Text = "Menari"
		CheckBox10.UseVisualStyleBackColor = True
		' 
		' CheckBox9
		' 
		CheckBox9.AutoSize = True
		CheckBox9.Location = New Point(177, 97)
		CheckBox9.Name = "CheckBox9"
		CheckBox9.Size = New Size(89, 19)
		CheckBox9.TabIndex = 8
		CheckBox9.Text = "Memancing"
		CheckBox9.UseVisualStyleBackColor = True
		' 
		' CheckBox8
		' 
		CheckBox8.AutoSize = True
		CheckBox8.Location = New Point(177, 72)
		CheckBox8.Name = "CheckBox8"
		CheckBox8.Size = New Size(69, 19)
		CheckBox8.TabIndex = 7
		CheckBox8.Text = "Gaming"
		CheckBox8.UseVisualStyleBackColor = True
		' 
		' CheckBox7
		' 
		CheckBox7.AutoSize = True
		CheckBox7.Location = New Point(177, 47)
		CheckBox7.Name = "CheckBox7"
		CheckBox7.Size = New Size(77, 19)
		CheckBox7.TabIndex = 6
		CheckBox7.Text = "Traveling"
		CheckBox7.UseVisualStyleBackColor = True
		' 
		' CheckBox6
		' 
		CheckBox6.AutoSize = True
		CheckBox6.Location = New Point(177, 22)
		CheckBox6.Name = "CheckBox6"
		CheckBox6.Size = New Size(67, 19)
		CheckBox6.TabIndex = 5
		CheckBox6.Text = "Menulis"
		CheckBox6.UseVisualStyleBackColor = True
		' 
		' CheckBox5
		' 
		CheckBox5.AutoSize = True
		CheckBox5.Location = New Point(6, 122)
		CheckBox5.Name = "CheckBox5"
		CheckBox5.Size = New Size(100, 19)
		CheckBox5.TabIndex = 4
		CheckBox5.Text = "Menggambar"
		CheckBox5.UseVisualStyleBackColor = True
		' 
		' CheckBox4
		' 
		CheckBox4.AutoSize = True
		CheckBox4.Location = New Point(6, 97)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(78, 19)
		CheckBox4.TabIndex = 3
		CheckBox4.Text = "Olahraga"
		CheckBox4.UseVisualStyleBackColor = True
		' 
		' CheckBox3
		' 
		CheckBox3.AutoSize = True
		CheckBox3.Location = New Point(6, 72)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(79, 19)
		CheckBox3.TabIndex = 2
		CheckBox3.Text = "Membaca"
		CheckBox3.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(6, 47)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(79, 19)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "menyanyi"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(6, 22)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(78, 19)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "Memasak"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.BackColor = Color.Transparent
		Button2.Location = New Point(286, 415)
		Button2.Name = "Button2"
		Button2.Size = New Size(480, 23)
		Button2.TabIndex = 10
		Button2.Text = "Cetak Kartu"
		Button2.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.GrayText
		BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(Button2)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Controls.Add(dtTanggal)
		Controls.Add(tbAlamat)
		Controls.Add(tbNomor)
		Controls.Add(tbUmur)
		Controls.Add(tbNama)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Button1)
		Controls.Add(PictureBox1)
		DoubleBuffered = True
		Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Name = "Form1"
		Text = "Form1"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents tbNama As TextBox
	Friend WithEvents tbUmur As TextBox
	Friend WithEvents tbNomor As TextBox
	Friend WithEvents tbAlamat As TextBox
	Friend WithEvents dtTanggal As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents CheckBox10 As CheckBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button2 As Button

End Class
