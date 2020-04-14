<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.alamattekxt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pekerjaantext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.nistext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.namatext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.alamattekxt)
        Me.Panel2.Controls.Add(Me.pekerjaantext)
        Me.Panel2.Controls.Add(Me.nistext)
        Me.Panel2.Controls.Add(Me.namatext)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Location = New System.Drawing.Point(185, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 360)
        Me.Panel2.TabIndex = 1
        '
        'alamattekxt
        '
        Me.alamattekxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alamattekxt.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamattekxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.alamattekxt.HintForeColor = System.Drawing.Color.Empty
        Me.alamattekxt.HintText = ""
        Me.alamattekxt.isPassword = False
        Me.alamattekxt.LineFocusedColor = System.Drawing.Color.Red
        Me.alamattekxt.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.alamattekxt.LineMouseHoverColor = System.Drawing.Color.Red
        Me.alamattekxt.LineThickness = 4
        Me.alamattekxt.Location = New System.Drawing.Point(34, 170)
        Me.alamattekxt.Margin = New System.Windows.Forms.Padding(4)
        Me.alamattekxt.Name = "alamattekxt"
        Me.alamattekxt.Size = New System.Drawing.Size(370, 44)
        Me.alamattekxt.TabIndex = 4
        Me.alamattekxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pekerjaantext
        '
        Me.pekerjaantext.BackColor = System.Drawing.Color.White
        Me.pekerjaantext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pekerjaantext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pekerjaantext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pekerjaantext.HintForeColor = System.Drawing.Color.Empty
        Me.pekerjaantext.HintText = ""
        Me.pekerjaantext.isPassword = False
        Me.pekerjaantext.LineFocusedColor = System.Drawing.Color.Red
        Me.pekerjaantext.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.pekerjaantext.LineMouseHoverColor = System.Drawing.Color.Red
        Me.pekerjaantext.LineThickness = 4
        Me.pekerjaantext.Location = New System.Drawing.Point(34, 118)
        Me.pekerjaantext.Margin = New System.Windows.Forms.Padding(4)
        Me.pekerjaantext.Name = "pekerjaantext"
        Me.pekerjaantext.Size = New System.Drawing.Size(370, 44)
        Me.pekerjaantext.TabIndex = 3
        Me.pekerjaantext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'nistext
        '
        Me.nistext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nistext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nistext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nistext.HintForeColor = System.Drawing.Color.Empty
        Me.nistext.HintText = ""
        Me.nistext.isPassword = False
        Me.nistext.LineFocusedColor = System.Drawing.Color.Red
        Me.nistext.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.nistext.LineMouseHoverColor = System.Drawing.Color.Red
        Me.nistext.LineThickness = 4
        Me.nistext.Location = New System.Drawing.Point(34, 66)
        Me.nistext.Margin = New System.Windows.Forms.Padding(4)
        Me.nistext.Name = "nistext"
        Me.nistext.Size = New System.Drawing.Size(370, 44)
        Me.nistext.TabIndex = 2
        Me.nistext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'namatext
        '
        Me.namatext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namatext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namatext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.namatext.HintForeColor = System.Drawing.Color.Empty
        Me.namatext.HintText = ""
        Me.namatext.isPassword = False
        Me.namatext.LineFocusedColor = System.Drawing.Color.Red
        Me.namatext.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.namatext.LineMouseHoverColor = System.Drawing.Color.Red
        Me.namatext.LineThickness = 4
        Me.namatext.Location = New System.Drawing.Point(34, 14)
        Me.namatext.Margin = New System.Windows.Forms.Padding(4)
        Me.namatext.Name = "namatext"
        Me.namatext.Size = New System.Drawing.Size(370, 44)
        Me.namatext.TabIndex = 1
        Me.namatext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "LOGIN"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.Location = New System.Drawing.Point(116, 249)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(223, 73)
        Me.BunifuThinButton21.TabIndex = 0
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(532, -75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(394, 277)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-24, -75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(318, 255)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(532, 336)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-109, 381)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(318, 255)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IDENTITAS"
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.BunifuThinButton21
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me.Panel2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(771, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pekerjaantext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents nistext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents namatext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents alamattekxt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label

    Private Sub namatext_MouseEnter(sender As Object, e As EventArgs) Handles namatext.MouseEnter
        Dim colortext As Color
        colortext = Color.FromArgb(50, 50, 50)
        If namatext.Text = "NAMA" Then
            namatext.Text = ""
            namatext.ForeColor = colortext
        End If
    End Sub

    Private Sub namatext_MouseLeave(sender As Object, e As EventArgs) Handles namatext.MouseLeave
        Dim colorhint As Color
        colorhint = Color.FromArgb(200, 200, 200)
        If namatext.Text = "" Then
            namatext.Text = "NAMA"
            namatext.ForeColor = colorhint
        End If
    End Sub

    Private Sub nistext_MouseEnter(sender As Object, e As EventArgs) Handles nistext.MouseEnter
        Dim colortext As Color
        colortext = Color.FromArgb(50, 50, 50)
        If nistext.Text = "UMUR" Then
            nistext.Text = ""
            nistext.ForeColor = colortext
        End If
    End Sub

    Private Sub nistext_MouseLeave(sender As Object, e As EventArgs) Handles nistext.MouseLeave
        Dim colorhint As Color
        colorhint = Color.FromArgb(200, 200, 200)
        If nistext.Text = "" Then
            nistext.Text = "UMUR"
            nistext.ForeColor = colorhint
        End If
    End Sub

    Private Sub pekerjaantext_MouseEnter(sender As Object, e As EventArgs) Handles pekerjaantext.MouseEnter
        Dim colortext As Color
        colortext = Color.FromArgb(50, 50, 50)
        If pekerjaantext.Text = "PEKERJAAN" Then
            pekerjaantext.Text = ""
            pekerjaantext.ForeColor = colortext
        End If
    End Sub

    Private Sub pekerjaantext_MouseLeave(sender As Object, e As EventArgs) Handles pekerjaantext.MouseLeave
        Dim colorhint As Color
        colorhint = Color.FromArgb(200, 200, 200)
        If pekerjaantext.Text = "" Then
            pekerjaantext.Text = "PEKERJAAN"
            pekerjaantext.ForeColor = colorhint
        End If
    End Sub

    Private Sub alamattekxt_MouseEnter(sender As Object, e As EventArgs) Handles alamattekxt.MouseEnter
        Dim colortext As Color
        colortext = Color.FromArgb(50, 50, 50)
        If alamattekxt.Text = "ALAMAT" Then
            alamattekxt.Text = ""
            alamattekxt.ForeColor = colortext
        End If
    End Sub

    Private Sub alamattekxt_MouseLeave(sender As Object, e As EventArgs) Handles alamattekxt.MouseLeave
        Dim colorhint As Color
        colorhint = Color.FromArgb(200, 200, 200)
        If alamattekxt.Text = "" Then
            alamattekxt.Text = "ALAMAT"
            alamattekxt.ForeColor = colorhint
        End If
    End Sub
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If namatext.Text = "" Then
            MsgBox("harus diidsi brou", vbCritical)
        ElseIf nistext.Text = "" Then
            MsgBox("harus diidsi brou", vbCritical)
        ElseIf pekerjaantext.Text = "" Then
            MsgBox("harus diidsi brou", vbCritical)
        ElseIf alamattekxt.Text = "" Then
            MsgBox("harus diidsi brou", vbCritical)

        Else
            Me.Hide()
            Form10.Show()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konec()
        namatext.Text = "NAMA"
        nistext.Text = "UMUR"
        alamattekxt.Text = "ALAMAT"
        pekerjaantext.Text = "PEKERJAAN"

    End Sub

    Private Sub nistext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nistext.KeyPress
        Dim keyChar As Integer
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub
End Class
