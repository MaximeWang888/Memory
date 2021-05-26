Public Class Jouer
    ''' <summary>
    ''' 
    ''' </summary>
    Dim TempsPartie As String
    Dim temps As Date
    Dim value As Integer
    Dim carre As Boolean
    Dim tab(6) As Image
    Dim nbDeCarteRetourner As Integer, nbCarreTrouve As Integer
    Dim tabNbDeCartesRetourner As New ArrayList
    Dim valeurActuelle As Integer


    Private Sub Jouer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        TempsPartie = "#00:" & Paramettre.TextBoxMinute.Text & ":" & Paramettre.TextBoxSecond.Text & "#"
        temps = TempsPartie
        If Paramettre.RadioButton1.Checked = True Then
            tab(0) = Projet_memory.My.Resources.Resources.BackCard
            tab(1) = Projet_memory.My.Resources.Resources.Card0
            tab(2) = Projet_memory.My.Resources.Resources.Card0
            tab(3) = Projet_memory.My.Resources.Resources.Card0
            tab(4) = Projet_memory.My.Resources.Resources.Card0
            tab(5) = Projet_memory.My.Resources.Resources.Card0
        Else
            tab(0) = Projet_memory.My.Resources.Resources.
            tab(1) = Projet_memory.My.Resources.Resources.neon
            tab(2) = Projet_memory.My.Resources.Resources.neon
            tab(3) = Projet_memory.My.Resources.Resources.neon
            tab(4) = Projet_memory.My.Resources.Resources.neon
            tab(5) = Projet_memory.My.Resources.Resources.neon
        End If


    End Sub
    Private Sub WaitFor(Sec%)
        Dim Dt As DateTime = DateTime.Now
        Do
            Application.DoEvents()
        Loop While Dt.AddSeconds(Sec) > DateTime.Now
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
        nbDeCarteRetourner = 0
        nbCarreTrouve = 0
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

    Function GetIndice(sender As Object) As Integer
        Dim i As Integer = 0

        For Each ctl In GroupBox1.Controls
            If TypeOf ctl Is PictureBox Then
                i += 1
                If sender.name = ctl.name Then
                    Return i
                End If
            End If
        Next
        Return -1
    End Function
    Function GetValeur(indice As Integer) As Integer
        Return Module1.GetValeur(indice)
    End Function

    Private Sub Jouer_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl In Me.Controls
            If TypeOf ctl Is PictureBox Then
                ctl.Size = New Size(90, 125)
                ctl.image = tab(0)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Permet de tourner la carte pour y voir le contenu 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Voir_LaCarte_Click(sender As Object, e As EventArgs) Handles PictureBox_1.Click, PictureBox17.Click, PictureBox20.Click, PictureBox16.Click, PictureBox19.Click,
PictureBox7.Click, PictureBox5.Click, PictureBox4.Click, PictureBox8.Click, PictureBox3.Click, PictureBox6.Click, PictureBox2.Click, PictureBox11.Click,
PictureBox10.Click, PictureBox9.Click, PictureBox1.Click, PictureBox13.Click, PictureBox12.Click, PictureBox15.Click, PictureBox14.Click
        Timer1.Start()
        Dim valeur As Integer = GetValeur(GetIndice(sender))

        retournerLesCartes(sender, valeur)
        nbDeCarteRetourner += 1
        tabNbDeCartesRetourner.Add(GetIndice(sender))
        If nbDeCarteRetourner < 2 Then
            valeurActuelle = valeur

        Else
            If valeurActuelle = valeur Then
                ' c les meme catrte
                ' MsgBox("les carte sont pareil")
                If nbDeCarteRetourner = 4 Then
                    'ça fait un caréé

                    nbCarreTrouve += 1
                    rendreEnable(tabNbDeCartesRetourner)
                    valeurActuelle = 0
                    nbDeCarteRetourner = 0
                    tabNbDeCartesRetourner.Clear()

                    If nbCarreTrouve = 5 Then
                        Timer1.Stop()
                        MsgBox("vous avez gagné")
                    End If

                End If
            Else
                'Les cartes ne sont pas les même
                valeurActuelle = 0
                nbDeCarteRetourner = 0
                GroupBox1.Enabled = False
                WaitFor(2)
                GroupBox1.Enabled = True
                retournerCarte(tabNbDeCartesRetourner)
                tabNbDeCartesRetourner.Clear()
                MsgBox(tabNbDeCartesRetourner.Count())


                ' tt remettre a 0 
            End If
        End If

    End Sub

    Sub retournerCarte(tab As ArrayList)

        Dim a As String = ""
        For j As Integer = 0 To tab.Count() - 1
            Dim i As Integer = 0
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is PictureBox Then
                    i += 1
                    If i = tab(j) Then
                        ctl.image = Projet_memory.My.Resources.Resources.BackCard
                    End If
                End If
            Next
        Next
    End Sub

    Sub rendreEnable(tab As ArrayList)

        For j As Integer = 0 To tab.Count() - 1
            Dim i As Integer = 0
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is PictureBox Then
                    i += 1
                    If i = tab(j) Then
                        ctl.enabled = False
                    End If
                End If
            Next
        Next
    End Sub



    Sub retournerLesCartes(sender As Object, valeur As Integer)
        'If valeur = 1 Then
        '    sender.image = Projet_memory.My.Resources.Resources.Capture1
        'ElseIf valeur = 2 Then
        '    sender.image = Projet_memory.My.Resources.Resources.Capture2

        'ElseIf valeur = 3 Then
        '    sender.image = Projet_memory.My.Resources.Resources.Capture3
        'ElseIf valeur = 4 Then
        '    sender.image = Projet_memory.My.Resources.Resources.Capture4

        'ElseIf valeur = 5 Then
        '    sender.image = Projet_memory.My.Resources.Resources.Capture
        'End If
        sender.image = tab(valeur)
    End Sub

End Class