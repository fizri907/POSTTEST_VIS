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
        Me.btnTambah = New Button()
        Me.txtIPS = New TextBox()
        Me.btnReset = New Button()
        Me.lblIPS = New Label()
        Me.lblIPKText = New Label()
        Me.lblIPK = New Label()
        Me.lblPredikatText = New Label()
        Me.lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        Me.btnTambah.Location = New Point(138, 200)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New Size(94, 29)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtIPS
        ' 
        Me.txtIPS.Location = New Point(341, 277)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New Size(125, 27)
        Me.txtIPS.TabIndex = 2
        ' 
        ' btnReset
        ' 
        Me.btnReset.Location = New Point(138, 235)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New Size(94, 29)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIPS
        ' 
        Me.lblIPS.AutoSize = True
        Me.lblIPS.Font = New Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Me.lblIPS.Location = New Point(341, 56)
        Me.lblIPS.Name = "lblIPS"
        Me.lblIPS.Size = New Size(136, 24)
        Me.lblIPS.TabIndex = 4
        Me.lblIPS.Text = "IP Semester"
        ' 
        ' lblIPKText
        ' 
        Me.lblIPKText.AutoSize = True
        Me.lblIPKText.Location = New Point(308, 204)
        Me.lblIPKText.Name = "lblIPKText"
        Me.lblIPKText.Size = New Size(89, 20)
        Me.lblIPKText.TabIndex = 5
        Me.lblIPKText.Text = "IP Kumulatif"
        ' 
        ' lblIPK
        ' 
        Me.lblIPK.AutoSize = True
        Me.lblIPK.Location = New Point(332, 239)
        Me.lblIPK.Name = "lblIPK"
        Me.lblIPK.Size = New Size(36, 20)
        Me.lblIPK.TabIndex = 6
        Me.lblIPK.Text = "0.00"
        ' 
        ' lblPredikatText
        ' 
        Me.lblPredikatText.AutoSize = True
        Me.lblPredikatText.Location = New Point(433, 204)
        Me.lblPredikatText.Name = "lblPredikatText"
        Me.lblPredikatText.Size = New Size(63, 20)
        Me.lblPredikatText.TabIndex = 7
        Me.lblPredikatText.Text = "Predikat"
        ' 
        ' lblPredikat
        ' 
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New Point(456, 239)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New Size(15, 20)
        Me.lblPredikat.TabIndex = 8
        Me.lblPredikat.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._UnionJack
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Me.lblPredikat)
        Controls.Add(Me.lblPredikatText)
        Controls.Add(Me.lblIPK)
        Controls.Add(Me.lblIPKText)
        Controls.Add(Me.lblIPS)
        Controls.Add(Me.btnReset)
        Controls.Add(Me.txtIPS)
        Controls.Add(Me.btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPKText As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikatText As Label
    Friend WithEvents lblPredikat As Label

End Class
