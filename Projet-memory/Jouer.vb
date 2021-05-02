Public Class Jouer
    ''' <summary>
    ''' 
    ''' </summary>
    Dim temps As Date = #00:01:00#

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Label_TempsRestant.Text = Format(temps, "mm:ss")
        Label_NomDuJoueur.Text = Memory.ComboBox1.Text
        Button_ArreterTimer.Text = "Arrêter"
        Button_ReprendreTimer.Text = "Reprendre"
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    ''' <summary>
    ''' 
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
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Abandon_Click(sender As Object, e As EventArgs) Handles Button_Abandon.Click
        Dim res As Integer = MsgBox("Voulez vous abandonner la partie en cours ?", vbQuestion + vbYesNo + vbDefaultButton2)

        If res = 6 Then
            Me.Close()
            Memory.Show()
        ElseIf res = 7 Then

        End If
    End Sub

    Private Sub Button_ArreterTimer_Click(sender As Object, e As EventArgs) Handles Button_ArreterTimer.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button_ReprendreTimer_Click(sender As Object, e As EventArgs) Handles Button_ReprendreTimer.Click
        Timer1.Enabled = True
    End Sub
End Class