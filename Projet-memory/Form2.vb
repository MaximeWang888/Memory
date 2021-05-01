Public Class Form2

    Private Sub Label_NomDuJoueur_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_NomDuJoueur.Text = Form1.Label_Nom.Text
    End Sub

    Private Sub Button_Abandon_Click(sender As Object, e As EventArgs) Handles Button_Abandon.Click
        Dim res As Integer = MsgBox("Voulez vous abandonner la partie en cours ?", vbQuestion + vbYesNo + vbDefaultButton2)

        If res = 6 Then
            Me.Hide()
            Form1.Show()
        ElseIf res = 7 Then

        End If
    End Sub

    Private Sub Label_TempsRestant_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_TempsRestant.Text = "1:00"
    End Sub
End Class