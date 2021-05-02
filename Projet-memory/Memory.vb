Public Class Memory
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim res As Integer = MsgBox("Voulez vous quitter l'application ?", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter")

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
        Jouer.Label_NomDuJoueur.Text = Me.Label_Nom.Text
        If Label_Nom.TextLength < 3 Then
            Label_Nom.ForeColor = Color.Red
        Else
            Label_Nom.ForeColor = Color.Black
            Me.Hide()
            Jouer.Show()
        End If

    End Sub

    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Memory"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("blabla")
    End Sub

End Class
