Public Class Jouer
    ''' <summary>
    ''' 
    ''' </summary>
    Dim temps As Date = #00:01:00#
    Dim stpw As New Stopwatch

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_NomDuJoueur.Text = Memory.Label_Nom.Text
        Timer1.Interval = 1000
        Timer1.Start()
        stpw.Start()
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
        Timer1.Stop()
        Dim res As Integer = MsgBox("Voulez vous abandonner la partie en cours ?", vbQuestion + vbYesNo + vbDefaultButton2)

        If res = 6 Then
            stpw.Reset()
            stpw.Restart()
            Me.Hide()
            Memory.Show()
        ElseIf res = 7 Then
            Timer1.Start()
        End If
    End Sub

End Class