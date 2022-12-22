Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Integer = txtScore.Text
        If score >= 70 Then
            MessageBox.Show("That test score is an A grade")
        ElseIf score >= 60 Then
            MessageBox.Show("That test score is a B grade")
        ElseIf score >= 50 Then
            MessageBox.Show("That test score is a C grade")
        ElseIf score >= 40 Then
            MessageBox.Show("That test score is a D grade")
        Else
            MessageBox.Show("That test score is a U grade")
        End If

    End Sub
End Class
