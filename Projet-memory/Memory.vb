﻿Public Class Memory


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim res As Integer = MsgBox("Voulez vous quitter l'application ?", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter")

        If res = 6 Then
            End
        ElseIf res = 7 Then

        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Jouer_Click(sender As Object, e As EventArgs) Handles Button_Jouer.Click
        If Not ComboBox1.Items.Contains(ComboBox1.Text) AndAlso ComboBox1.Text.Length > 2 Then
            ComboBox1.Items.Add(ComboBox1.Text)
        End If
        Jouer.Label_NomDuJoueur.Text = Me.ComboBox1.Text
        If ComboBox1.Text.Length < 3 Then
            ComboBox1.ForeColor = Color.Red
        Else
            ComboBox1.ForeColor = Color.Black
            Me.Hide()
            Jouer.Show()
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Memory"
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text.Length >= 1 Then
            Button_Jouer.Enabled = True
            ComboBox1.MaxLength = 12
        End If
    End Sub
End Class
