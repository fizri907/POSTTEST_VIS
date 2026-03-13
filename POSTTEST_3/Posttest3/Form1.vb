Public Class Form1

	'BROWSE FOTO
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim buka As New OpenFileDialog

		buka.Filter = "Image Files|*.jpg;*.png;*.jpeg"

		If buka.ShowDialog = DialogResult.OK Then
			PictureBox1.Image = Image.FromFile(buka.FileName)
		End If

	End Sub


	'VALIDASI NAMA 
	Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress

		If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
			e.Handled = True
		End If

	End Sub


	'VALIDASI UMUR 
	Private Sub tbUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUmur.KeyPress

		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If

	End Sub


	'VALIDASI NOMOR 
	Private Sub tbNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomor.KeyPress

		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If

	End Sub


	'CETAK KARTU
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


		'VALIDASI TEXTBOX
		If tbNama.Text = "" Or tbUmur.Text = "" Or tbNomor.Text = "" Or tbAlamat.Text = "" Then

			MessageBox.Show("Inputan tidak boleh kosong")
			Exit Sub

		End If


		'VALIDASI RADIO BUTTON
		If Not rbLaki.Checked And Not rbPerempuan.Checked Then

			MessageBox.Show("Pilih jenis kelamin")
			Exit Sub

		End If


		'AMBIL HOBBY (PERULANGAN)
		Dim hobby As String = ""

		For Each c As CheckBox In GroupBox2.Controls

			If c.Checked = True Then
				hobby = hobby & c.Text & ", "
			End If

		Next


		If hobby = "" Then

			MessageBox.Show("Pilih minimal satu hobby")
			Exit Sub

		End If


		'JENIS KELAMIN
		Dim jk As String

		If rbLaki.Checked Then
			jk = "Laki - Laki"
		Else
			jk = "Perempuan"
		End If


		'KIRIM DATA KE FORM2
		Form2.lblNama.Text = tbNama.Text
		Form2.lblUmur.Text = tbUmur.Text
		Form2.lblTanggal.Text = dtTanggal.Value.ToShortDateString
		Form2.lblNomor.Text = tbNomor.Text
		Form2.lblAlamat.Text = tbAlamat.Text
		Form2.lblHobby.Text = hobby
		Form2.lblJK.Text = jk

		Form2.PictureBox1.Image = CType(PictureBox1.Image.Clone(), Image)

		Form2.Show()

	End Sub

	Private Sub tbNama_TextChanged(sender As Object, e As EventArgs) Handles tbNama.TextChanged

	End Sub
End Class