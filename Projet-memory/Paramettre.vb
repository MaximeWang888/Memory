Public Class Paramettre

    ''' <summary>
    ''' Permet de retourner vers le formulaire 'Memory'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        Memory.Show()
    End Sub


    ''' <summary>
    ''' Une fonction permettant aux champs destinés de ne pouvoir rentrer que des nombres et rien d'autres
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBoxMinute_KeyPres(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinute.KeyPress, TextBoxSecond.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Permet de reset tout le formulaire 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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


    ''' <summary>
    ''' Permet de définir des valeurs par défaut si valeurs mal exprimés dans les textBoxMinute/Seconde 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' Permet de changer l'affichage du checkBox selon la valeur Oui/Non
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            CheckBox2.Text = "Non"
        Else
            CheckBox2.Text = "Oui"
        End If
    End Sub

    ''' <summary>
    ''' Permet de changer l'affichage du checkBox selon la valeur Oui/Non
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            CheckBox3.Text = "Non"
        Else
            CheckBox3.Text = "Oui"
        End If
    End Sub

    ''' <summary>
    ''' Permet de changer la taille de l'image selon la carte choisit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            PictureBox1.Size = New System.Drawing.Size(121, 156)
            PictureBox2.Size = New System.Drawing.Size(91, 126)
        Else
            PictureBox2.Size = New System.Drawing.Size(121, 156)
            PictureBox1.Size = New System.Drawing.Size(91, 126)
        End If
    End Sub

    Private Sub Paramettre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class