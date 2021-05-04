Public Class Paramettre

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        Memory.Show()
    End Sub


    Private Sub TextBoxMinute_KeyPres(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinute.KeyPress, TextBoxSecond.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class