Public Class Form9
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If BunifuMaterialTextbox1.Text = 12345678 Then
            Form7.DataGrid1.DataSource = Nothing
            Form7.DataGrid1.Refresh()
            Me.Hide()
        Else
            MsgBox("password salah", vbCritical)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
    End Sub
End Class