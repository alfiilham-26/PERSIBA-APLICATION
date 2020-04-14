Public Class form3
    Private Sub BunifuCheckbox8_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox8.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = Form2.namatext.Text
    End Sub

    Private Sub BunifuCheckbox7_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox7.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox6_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox6.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox5_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox5.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox4_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox4.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox3_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox3.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox9_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox9.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuCheckbox10_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox10.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Me.Hide()
    End Sub
End Class