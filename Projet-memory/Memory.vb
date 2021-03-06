Public Class Memory


    ''' <summary>
    ''' Permet de quitter l'application Memory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
        Module1.sauvegarder()
    End Sub

    ''' <summary>
    ''' Permet de demander une confirmation à l'utilisateur si il est sûr de vouloir quitter l'application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_MemoryClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Voulez vous quitter l'application ?", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter") = vbNo Then
            e.Cancel = True
        End If

    End Sub

    ''' <summary>
    ''' Permet de changer formulaire du formulaire "Memory" à celui de "Jouer" sous certaines conditions (regarder le code)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Jouer_Click(sender As Object, e As EventArgs) Handles Button_Jouer.Click
        If Not ComboBox1.Items.Contains(ComboBox1.Text) AndAlso ComboBox1.Text.Length > 2 Then
            ComboBox1.Items.Add(ComboBox1.Text)
        End If
        If ComboBox1.Text.Length < 3 Then
            ComboBox1.ForeColor = Color.Red
        Else
            ComboBox1.ForeColor = Color.Black
            Me.Hide()
            Jouer.Show()
        End If

    End Sub

    ''' <summary>
    ''' Permet de rendre le bouton "Jouer" cliquable  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text.Length >= 1 Then
            Button_Jouer.Enabled = True
            ComboBox1.MaxLength = 12
        ElseIf ComboBox1.Text.Length < 1 Then
            Button_Jouer.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Permet d'aller dans le formulaire 'Score'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonScores_Click(sender As Object, e As EventArgs) Handles ButtonScores.Click
        Me.Hide()
        Score.Show()
    End Sub

    ''' <summary>
    ''' Permet d'aller dans le formulaire 'Options'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonOptions_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        Me.Hide()
        Paramettre.Show()
    End Sub

End Class
