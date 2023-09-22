Public Class Form2
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class