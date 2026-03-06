Public Class Form1

    Sub TampilBuku()

        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlah - 1
            ListBox1.Items.Add(judulBuku(i) & " - " & genreBuku(i))
        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilBuku()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        HapusBuku(txtHapus.Text)

        TampilBuku()

        txtHapus.Clear()

    End Sub

End Class