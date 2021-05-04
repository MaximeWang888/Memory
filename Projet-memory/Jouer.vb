Imports System.ComponentModel
Imports System.Threading
Public Class Jouer
    ''' <summary>
    ''' 
    ''' </summary>
    Dim TempsPartie As String
    Dim temps As Date
    Private Sub Jouer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        TempsPartie = "#00:" & Paramettre.TextBoxMinute.Text & ":" & Paramettre.TextBoxSecond.Text & "#"
        temps = TempsPartie
        'temps = "#00:03:00#"
    End Sub

    'DateInterval.minute = 

    ''' <summary>
    '''  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Jouer_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Label_TempsRestant.Text = Format(temps, "mm:ss")
        Label_NomDuJoueur.Text = Memory.ComboBox1.Text
        Button_ArreterTimer.Text = "Pause"
        Button_ReprendreTimer.Text = "Reprendre"
        Timer1.Interval = 1000
        Timer1.Stop()
    End Sub

    ''' <summary>
    ''' Traitement du timer d'une partie de jeu Memory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temps = DateAdd(DateInterval.Second, -1, temps)
        Me.Label_TempsRestant.Text = Format(temps, "mm:ss")
        If temps < #00:00:10# Then
            Label_TempsRestant.ForeColor = Color.Red
        End If
        If temps = #00:00:00# Then
            Timer1.Stop()
            MsgBox("Vous avez perdu")
        End If
    End Sub

    ''' <summary>
    ''' Permet d'abandonner la partie en cours en cliquant sur le button 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Abandon_Click(sender As Object, e As EventArgs) Handles Button_Abandon.Click
        Me.Close()
        Memory.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_MemoryClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Voulez vous abandonner la partie en cours ?", vbQuestion + vbYesNo + vbDefaultButton2, "Abandon") = vbNo Then
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' Permet d'arrêter le timer en cliquant sur le button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_ArreterTimer_Click(sender As Object, e As EventArgs) Handles Button_ArreterTimer.Click
        Timer1.Enabled = False
    End Sub

    ''' <summary>
    ''' Permet de reprendre le timer en cliquant sur le button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_ReprendreTimer_Click(sender As Object, e As EventArgs) Handles Button_ReprendreTimer.Click
        Timer1.Enabled = True
    End Sub

    ''' <summary>
    ''' Permet de tourner la carte pour y voir le contenu 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Voir_LaCarte_Click(sender As Object, e As EventArgs) Handles PictureBox_1.Click
        Timer1.Start()
        For i As Integer = 0 To 1
            MsgBox("La carte va se retourner, reste vif !")
            PictureBox_1.Image = Projet_memory.My.Resources.Resources.Card0
            Thread.Sleep(3000)
            MsgBox("Hop les 3 secondes passés")
            PictureBox_1.Image = Projet_memory.My.Resources.Resources.BackCard
        Next

    End Sub


End Class