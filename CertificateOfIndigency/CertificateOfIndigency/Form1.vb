Public Class Form1
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
