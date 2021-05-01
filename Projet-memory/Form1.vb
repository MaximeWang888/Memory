Public Class Form1
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim res As Integer = MsgBox("Voulez vous quittez", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter")

        If res = 6 Then
            End
        ElseIf res = 7 Then

        End If
    End Sub

    Private Sub Label_Nom_TextChanged(sender As Object, e As EventArgs) Handles Label_Nom.TextChanged
        If Label_Nom.TextLength >= 1 Then
            Button_Jouer.Enabled = True
            Label_Nom.MaxLength = 12
        End If
    End Sub

    Private Sub Button_Jouer_Click(sender As Object, e As EventArgs) Handles Button_Jouer.Click
        Form2.Label_NomDuJoueur.Text = Me.Label_Nom.Text
        Me.Hide()
        Form2.Show()
    End Sub
End Class
