Public Class Form4
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = Form2.namatext.Text
    End Sub

    Private Sub BunifuCheckbox8_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox8.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
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

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        Form6.Label12.Text = Val(Form6.Label12.Text) + 1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
    End Sub
End Class