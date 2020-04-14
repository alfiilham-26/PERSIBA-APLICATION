Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Call konec()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 5
        If BunifuProgressBar1.Value = 95 Then
            Timer1.Stop()
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class
