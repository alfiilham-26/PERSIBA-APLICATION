Public Class Form8
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Add(“RESIKO RENDAH”)
        Chart1.Series.Add(“RESIKO SEDANG”)
        Chart1.Series.Add(“RESIKO TINGGI”)
    End Sub
End Class