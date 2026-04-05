Public Class Form3

    Public nama As String
    Public id As String
    Public komunitas As String
    Public telepon As String
    Public hobi As String
    Public foto As Image

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = "Nama: " & nama
        lblID.Text = "ID: " & id
        lblKomunitas.Text = "Komunitas: " & komunitas
        lblTelepon.Text = "Telepon: " & telepon
        lblHobi.Text = "Hobi: " & hobi
        picKartu.Image = foto
    End Sub

End Class