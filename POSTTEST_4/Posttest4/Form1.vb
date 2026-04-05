Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKomunitas.Items.Add("Programmer")
        cbKomunitas.Items.Add("Desain Grafis")
        cbKomunitas.Items.Add("Multimedia")
        cbKomunitas.Items.Add("Gaming")
        cbKomunitas.Items.Add("Robotik")
    End Sub

    ' VALIDASI INPUT
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtxtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtTelepon.KeyPress
        HanyaAngka(e)
    End Sub

    ' MENU
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim fk As New Form3
        KirimData(fk)
        fk.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SimpanData()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        BukaData()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' BROWSE FOTO
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    ' CETAK
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not Validasi() Then Exit Sub

        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim fk As New Form3
            KirimData(fk)
            fk.Show()
        End If
    End Sub

    ' VALIDASI
    Private Function Validasi() As Boolean
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not mtxtTelepon.MaskCompleted Then
            MessageBox.Show("Nomor telepon belum lengkap")
            Return False
        End If

        Return True
    End Function

    ' AMBIL HOBI
    Private Function AmbilHobi() As String
        Dim hasil As String = ""

        For Each ctrl As Control In TabPage3.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hasil &= cb.Text & ", "
                End If
            End If
        Next

        Return hasil
    End Function

    ' KIRIM DATA
    Private Sub KirimData(fk As Form3)
        fk.nama = txtNama.Text
        fk.id = txtID.Text
        fk.komunitas = cbKomunitas.Text
        fk.telepon = mtxtTelepon.Text
        fk.hobi = AmbilHobi()
        fk.foto = picFoto.Image
    End Sub

    ' SIMPAN
    Private Sub SimpanData()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Dim sw As New StreamWriter(sfd.FileName)
            sw.WriteLine(txtNama.Text)
            sw.WriteLine(txtID.Text)
            sw.WriteLine(cbKomunitas.Text)
            sw.WriteLine(mtxtTelepon.Text)
            sw.Close()

            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    ' BUKA
    Private Sub BukaData()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim sr As New StreamReader(ofd.FileName)
            txtNama.Text = sr.ReadLine()
            txtID.Text = sr.ReadLine()
            cbKomunitas.Text = sr.ReadLine()
            mtxtTelepon.Text = sr.ReadLine()
            sr.Close()
        End If
    End Sub

End Class