Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ErrorProvider1.Clear()

        Dim userOk As Boolean = ValidasiTextBox(ErrorProvider1, txtUsername, "Username tidak boleh kosong")
        Dim passOk As Boolean = ValidasiTextBox(ErrorProvider1, txtPassword, "Password tidak boleh kosong")

        If Not (userOk And passOk) Then Exit Sub

        If ValidationModule.CekLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim()) Then
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim f As New FormPelanggan()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub
End Class