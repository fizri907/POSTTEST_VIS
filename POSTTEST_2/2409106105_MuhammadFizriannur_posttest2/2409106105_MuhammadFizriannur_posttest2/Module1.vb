Module Module1

    Public judulBuku(10) As String
    Public genreBuku(10) As String
    Public jumlah As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        judulBuku(jumlah) = judul
        genreBuku(jumlah) = genre
        jumlah = jumlah + 1

    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlah - 1
            If judulBuku(i) = judul Then
                Return i
            End If
        Next

        Return -1

    End Function

    Public Sub HapusBuku(ByVal judul As String)

        Dim index As Integer
        index = CariBuku(judul)

        If index <> -1 Then

            For i As Integer = index To jumlah - 2
                judulBuku(i) = judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next

            jumlah = jumlah - 1

        End If

    End Sub

End Module