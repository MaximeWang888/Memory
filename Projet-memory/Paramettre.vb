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
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            PictureBox1.Size = New System.Drawing.Size(91, 126)
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


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            CheckBox2.Text = "Non"
        Else
            CheckBox2.Text = "Oui"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            CheckBox3.Text = "Non"
        Else
            CheckBox3.Text = "Oui"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            PictureBox1.Size = New System.Drawing.Size(121, 156)
            PictureBox2.Size = New System.Drawing.Size(91, 126)
        Else
            PictureBox2.Size = New System.Drawing.Size(121, 156)
            PictureBox1.Size = New System.Drawing.Size(91, 126)
        End If
    End Sub

    Private Sub Paramettre_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton2.Checked = True
    End Sub
End Class