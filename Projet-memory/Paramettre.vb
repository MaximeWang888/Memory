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

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        If MsgBox("Etes vous sur de réinitialiser les paramettres", MsgBoxStyle.YesNo, "") = 6 Then
            TextBoxMinute.Text = "01"
            TextBoxSecond.Text = "00"
            CheckBox1.Checked = False
        End If
    End Sub



    Private Sub TextBoxMinute_LostFocus(sender As Object, e As EventArgs) Handles TextBoxMinute.LostFocus, TextBoxSecond.LostFocus
        If TextBoxMinute.Text = "" Then
            TextBoxMinute.Text = "01"
        End If
        If TextBoxMinute.Text > 5 Then
            TextBoxMinute.Text = "05"
        End If
        If TextBoxSecond.Text = "" Then
            TextBoxSecond.Text = "00"
        End If
        If TextBoxSecond.Text > 59 Then
            TextBoxSecond.Text = "59"
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            CheckBox1.Text = "Non"
        Else
            CheckBox1.Text = "Oui"
        End If
    End Sub

End Class