Public Class Form5
    Dim sqlnya As String
    Sub panggildata()
        konec()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_data", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_data")
        Form7.DataGrid1.DataSource = DS.Tables("tb_data")
        Form7.DataGrid1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konec()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        Form6.Label8.Text = Form2.namatext.Text
        Form6.Label9.Text = Form2.nistext.Text
        Form6.Label10.Text = Form2.pekerjaantext.Text
        Form6.Label11.Text = Form2.alamattekxt.Text
        Form2.namatext.Text = ""
        Form2.nistext.Text = ""
        Form2.pekerjaantext.Text = ""
        Form2.alamattekxt.Text = ""
        form3.Label15.Text = ""
        Form4.Label15.Text = ""
        Label15.Text = ""
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = Form2.namatext.Text
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If Form6.Label12.Text <= 7 Then
            Form6.Label14.Text = "Resiko Rendah"
        ElseIf Form6.Label12.Text <= 14 Then
            Form6.Label14.Text = "Resiko sedang"
        Else
            Form6.Label14.Text = "Resiko tinggi"
        End If
        sqlnya = "insert into tb_data(nama,umur,pekerjaan,alamat,point,keterangan)values('" & Form2.namatext.Text & "','" & Form2.nistext.Text & "','" & Form2.pekerjaantext.Text & "','" & Form2.alamattekxt.Text & "','" & Form6.Label12.Text & "','" & Form6.Label14.Text & "')"
        Call panggildata()
        Call jalan()
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub BunifuCheckbox3_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox3.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox4_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox4.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox5_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox5.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
    End Sub
End Class