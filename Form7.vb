Public Class Form7
    Dim sqlnya As String
    Sub panggildata()
        konec()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_data", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_data")
        DataGrid1.DataSource = DS.Tables("tb_data")
        DataGrid1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konec()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub DataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        konec()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_data where nama like '%" & BunifuTextbox1.text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_data")
        DataGrid1.DataSource = DS.Tables("tb_data")
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Form9.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub
End Class