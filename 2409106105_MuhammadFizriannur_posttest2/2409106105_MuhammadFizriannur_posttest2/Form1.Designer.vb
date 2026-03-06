<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.txtJudul = New TextBox()
		Me.txtGenre = New TextBox()
		Me.txtHapus = New TextBox()
		Me.btnTambah = New Button()
		Me.btnHapus = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		lstBuku = New ListBox()
		GroupBox1 = New GroupBox()
		GroupBox2 = New GroupBox()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' txtJudul
		' 
		Me.txtJudul.Location = New Point(94, 21)
		Me.txtJudul.Name = "txtJudul"
		Me.txtJudul.Size = New Size(100, 23)
		Me.txtJudul.TabIndex = 0
		' 
		' txtGenre
		' 
		Me.txtGenre.Location = New Point(94, 49)
		Me.txtGenre.Name = "txtGenre"
		Me.txtGenre.Size = New Size(100, 23)
		Me.txtGenre.TabIndex = 1
		' 
		' txtHapus
		' 
		Me.txtHapus.Location = New Point(84, 46)
		Me.txtHapus.Name = "txtHapus"
		Me.txtHapus.Size = New Size(100, 23)
		Me.txtHapus.TabIndex = 2
		' 
		' btnTambah
		' 
		Me.btnTambah.Location = New Point(125, 113)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New Size(75, 23)
		Me.btnTambah.TabIndex = 3
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = True
		' 
		' btnHapus
		' 
		Me.btnHapus.Location = New Point(119, 75)
		Me.btnHapus.Name = "btnHapus"
		Me.btnHapus.Size = New Size(75, 23)
		Me.btnHapus.TabIndex = 4
		Me.btnHapus.Text = "Hapus"
		Me.btnHapus.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(19, 30)
		Label1.Name = "Label1"
		Label1.Size = New Size(65, 15)
		Label1.TabIndex = 5
		Label1.Text = "Judul Buku"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(19, 57)
		Label2.Name = "Label2"
		Label2.Size = New Size(38, 15)
		Label2.TabIndex = 6
		Label2.Text = "Genre"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(6, 54)
		Label3.Name = "Label3"
		Label3.Size = New Size(65, 15)
		Label3.TabIndex = 7
		Label3.Text = "Judul Buku"
		' 
		' lstBuku
		' 
		lstBuku.FormattingEnabled = True
		lstBuku.Location = New Point(319, 275)
		lstBuku.Name = "lstBuku"
		lstBuku.Size = New Size(266, 124)
		lstBuku.TabIndex = 8
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(Me.btnTambah)
		GroupBox1.Controls.Add(Label2)
		GroupBox1.Controls.Add(Label1)
		GroupBox1.Controls.Add(Me.txtJudul)
		GroupBox1.Controls.Add(Me.txtGenre)
		GroupBox1.Location = New Point(68, 64)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(200, 142)
		GroupBox1.TabIndex = 9
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' GroupBox2
		' 
		GroupBox2.Controls.Add(Label3)
		GroupBox2.Controls.Add(Me.txtHapus)
		GroupBox2.Controls.Add(Me.btnHapus)
		GroupBox2.Location = New Point(423, 85)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(272, 160)
		GroupBox2.TabIndex = 0
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hapus Buku"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Controls.Add(lstBuku)
		Name = "Form1"
		Text = "Form1"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents txtJudul As TextBox
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lstBuku As ListBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox

End Class
