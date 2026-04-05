<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
		Me.lblNama = New System.Windows.Forms.Label()
		Me.lblID = New System.Windows.Forms.Label()
		Me.lblKomunitas = New System.Windows.Forms.Label()
		Me.lblTelepon = New System.Windows.Forms.Label()
		Me.lblHobi = New System.Windows.Forms.Label()
		Me.picKartu = New System.Windows.Forms.PictureBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		CType(Me.picKartu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblNama
		'
		Me.lblNama.AutoSize = True
		Me.lblNama.Location = New System.Drawing.Point(145, 19)
		Me.lblNama.Name = "lblNama"
		Me.lblNama.Size = New System.Drawing.Size(35, 13)
		Me.lblNama.TabIndex = 0
		Me.lblNama.Text = "Nama"
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(145, 70)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(61, 13)
		Me.lblID.TabIndex = 1
		Me.lblID.Text = "ID Anggota"
		'
		'lblKomunitas
		'
		Me.lblKomunitas.AutoSize = True
		Me.lblKomunitas.Location = New System.Drawing.Point(150, 113)
		Me.lblKomunitas.Name = "lblKomunitas"
		Me.lblKomunitas.Size = New System.Drawing.Size(56, 13)
		Me.lblKomunitas.TabIndex = 2
		Me.lblKomunitas.Text = "Komunitas"
		'
		'lblTelepon
		'
		Me.lblTelepon.AutoSize = True
		Me.lblTelepon.Location = New System.Drawing.Point(145, 154)
		Me.lblTelepon.Name = "lblTelepon"
		Me.lblTelepon.Size = New System.Drawing.Size(46, 13)
		Me.lblTelepon.TabIndex = 3
		Me.lblTelepon.Text = "Telepon"
		'
		'lblHobi
		'
		Me.lblHobi.AutoSize = True
		Me.lblHobi.Location = New System.Drawing.Point(151, 206)
		Me.lblHobi.Name = "lblHobi"
		Me.lblHobi.Size = New System.Drawing.Size(29, 13)
		Me.lblHobi.TabIndex = 4
		Me.lblHobi.Text = "Hobi"
		'
		'picKartu
		'
		Me.picKartu.Location = New System.Drawing.Point(6, 19)
		Me.picKartu.Name = "picKartu"
		Me.picKartu.Size = New System.Drawing.Size(109, 200)
		Me.picKartu.TabIndex = 5
		Me.picKartu.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.picKartu)
		Me.GroupBox1.Controls.Add(Me.lblNama)
		Me.GroupBox1.Controls.Add(Me.lblID)
		Me.GroupBox1.Controls.Add(Me.lblKomunitas)
		Me.GroupBox1.Controls.Add(Me.lblTelepon)
		Me.GroupBox1.Controls.Add(Me.lblHobi)
		Me.GroupBox1.Location = New System.Drawing.Point(223, 16)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(291, 252)
		Me.GroupBox1.TabIndex = 6
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GroupBox1"
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form3"
		Me.Text = "Form3"
		CType(Me.picKartu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblNama As Label
	Friend WithEvents lblID As Label
	Friend WithEvents lblKomunitas As Label
	Friend WithEvents lblTelepon As Label
	Friend WithEvents lblHobi As Label
	Friend WithEvents picKartu As PictureBox
	Friend WithEvents GroupBox1 As GroupBox
End Class
