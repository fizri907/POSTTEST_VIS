<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		lblNama = New Label()
		lblUmur = New Label()
		lblTanggal = New Label()
		lblNomor = New Label()
		lblAlamat = New Label()
		lblHobby = New Label()
		lblJK = New Label()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		PictureBox1 = New PictureBox()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Location = New Point(424, 36)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(41, 15)
		lblNama.TabIndex = 6
		lblNama.Text = "Nama"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.Location = New Point(424, 75)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(38, 15)
		lblUmur.TabIndex = 5
		lblUmur.Text = "Umur"
		' 
		' lblTanggal
		' 
		lblTanggal.AutoSize = True
		lblTanggal.Location = New Point(424, 114)
		lblTanggal.Name = "lblTanggal"
		lblTanggal.Size = New Size(83, 15)
		lblTanggal.TabIndex = 4
		lblTanggal.Text = "Tanggal Lahir"
		' 
		' lblNomor
		' 
		lblNomor.AutoSize = True
		lblNomor.Location = New Point(424, 150)
		lblNomor.Name = "lblNomor"
		lblNomor.Size = New Size(66, 15)
		lblNomor.TabIndex = 3
		lblNomor.Text = "No. Telpon"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.Location = New Point(424, 191)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(47, 15)
		lblAlamat.TabIndex = 2
		lblAlamat.Text = "Alamat"
		' 
		' lblHobby
		' 
		lblHobby.AutoSize = True
		lblHobby.Location = New Point(424, 227)
		lblHobby.Name = "lblHobby"
		lblHobby.Size = New Size(43, 15)
		lblHobby.TabIndex = 1
		lblHobby.Text = "Hobby"
		' 
		' lblJK
		' 
		lblJK.AutoSize = True
		lblJK.Location = New Point(424, 262)
		lblJK.Name = "lblJK"
		lblJK.Size = New Size(81, 15)
		lblJK.TabIndex = 0
		lblJK.Text = "Jenis Kelamin"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(255, 36)
		Label1.Name = "Label1"
		Label1.Size = New Size(47, 15)
		Label1.TabIndex = 7
		Label1.Text = "Nama :"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(255, 75)
		Label2.Name = "Label2"
		Label2.Size = New Size(44, 15)
		Label2.TabIndex = 8
		Label2.Text = "Umur :"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(255, 114)
		Label3.Name = "Label3"
		Label3.Size = New Size(41, 15)
		Label3.TabIndex = 9
		Label3.Text = "Lahir :"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(255, 150)
		Label4.Name = "Label4"
		Label4.Size = New Size(75, 15)
		Label4.TabIndex = 10
		Label4.Text = "No . Telpon :"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(255, 191)
		Label5.Name = "Label5"
		Label5.Size = New Size(53, 15)
		Label5.TabIndex = 11
		Label5.Text = "Alamat :"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(255, 227)
		Label6.Name = "Label6"
		Label6.Size = New Size(49, 15)
		Label6.TabIndex = 12
		Label6.Text = "Hobby :"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(255, 262)
		Label7.Name = "Label7"
		Label7.Size = New Size(87, 15)
		Label7.TabIndex = 13
		Label7.Text = "Jenis Kelamin :"
		' 
		' PictureBox1
		' 
		PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
		PictureBox1.Location = New Point(36, 36)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(154, 241)
		PictureBox1.TabIndex = 14
		PictureBox1.TabStop = False
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
		ClientSize = New Size(716, 360)
		Controls.Add(PictureBox1)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(lblJK)
		Controls.Add(lblHobby)
		Controls.Add(lblAlamat)
		Controls.Add(lblNomor)
		Controls.Add(lblTanggal)
		Controls.Add(lblUmur)
		Controls.Add(lblNama)
		Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Name = "Form2"
		Text = "Form2"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblTanggal As Label
	Friend WithEvents lblNomor As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents lblHobby As Label
	Friend WithEvents lblJK As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
