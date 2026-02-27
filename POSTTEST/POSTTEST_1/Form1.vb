Public Class Form1

    ' Variabel untuk menyimpan total seluruh IP Semester
    Dim totalIPS As Double = 0

    ' Variabel untuk menghitung jumlah semester yang telah dimasukkan
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim nilaiIPS As Double

        ' Memeriksa apakah input berupa angka
        If Double.TryParse(txtIPS.Text, nilaiIPS) Then

            ' Memastikan nilai berada pada rentang 0 sampai 4
            If nilaiIPS >= 0 And nilaiIPS <= 4 Then

                ' Menambahkan nilai ke total
                totalIPS += nilaiIPS

                ' Menambah jumlah semester
                jumlahSemester += 1

                ' Menghitung IP Kumulatif
                Dim nilaiIPK As Double = totalIPS / jumlahSemester

                ' Menampilkan IPK dengan dua angka di belakang koma
                lblIPK.Text = nilaiIPK.ToString("0.00")

                ' Menentukan predikat berdasarkan IPK
                If nilaiIPK >= 2.0 And nilaiIPK <= 2.75 Then
                    lblPredikat.Text = "Cukup"
                ElseIf nilaiIPK >= 2.76 And nilaiIPK <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf nilaiIPK >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                Else
                    lblPredikat.Text = "-"
                End If

                ' Mengosongkan kotak input setelah ditambahkan
                txtIPS.Clear()
                txtIPS.Focus()

            Else
                MessageBox.Show("Nilai IP Semester harus berada pada rentang 0 sampai 4.")
            End If

        Else
            MessageBox.Show("Masukkan nilai dalam bentuk angka yang valid.")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Mengembalikan seluruh variabel ke nilai awal
        totalIPS = 0
        jumlahSemester = 0

        ' Mengatur ulang tampilan
        lblIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIPS.Clear()
        txtIPS.Focus()

    End Sub

End Class