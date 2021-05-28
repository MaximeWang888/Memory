Public Class Jouer
    ''' <summary>
    ''' Des attributs du formulaire utiles pour la suite
    ''' </summary>
    Dim temps As Integer, tempDeLaPartie As Integer, tempsTrouvCarre As Integer
    Dim value As Integer
    Dim tab(6) As Image
    Dim nbDeCarteRetourner As Integer, nbCarreTrouve As Integer
    Dim tabNbDeCartesRetourner As New ArrayList
    Dim valeurActuelle As Integer


    ''' <summary>
    ''' Permet d'initialiser toutes les images.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Jouer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        temps = Paramettre.TextBoxMinute.Text * 60 + Paramettre.TextBoxSecond.Text
        tempDeLaPartie = temps
        Module1.melangeTableau(Module1.tab)
        If Paramettre.RadioButton1.Checked = True Then
            tab(0) = Projet_memory.My.Resources.Resources.BackCard
            tab(1) = Projet_memory.My.Resources.Resources.Card0
            tab(2) = Projet_memory.My.Resources.Resources.Card1
            tab(3) = Projet_memory.My.Resources.Resources.Card2
            tab(4) = Projet_memory.My.Resources.Resources.Card3
            tab(5) = Projet_memory.My.Resources.Resources.Card4
        Else
            tab(0) = Projet_memory.My.Resources.Resources.neon
            tab(1) = Projet_memory.My.Resources.Resources.neon1
            tab(2) = Projet_memory.My.Resources.Resources.neon2
            tab(3) = Projet_memory.My.Resources.Resources.neon3
            tab(4) = Projet_memory.My.Resources.Resources.neon4
            tab(5) = Projet_memory.My.Resources.Resources.neon5
        End If
    End Sub

    ''' <summary>
    ''' Permet de faire une pause de quelques secondes 
    ''' </summary>
    ''' <param name="Sec%"></param>
    Private Sub WaitFor(Sec%)
        Dim Dt As DateTime = DateTime.Now
        Do
            Application.DoEvents()
        Loop While Dt.AddSeconds(Sec) > DateTime.Now
    End Sub

    ''' <summary>
    ''' Permet d'initialiser toutes les données sauf les images qui sont initialisés autres part.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Jouer_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Dim s As String = temps \ 60 & " : "
        If temps Mod 60 < 10 Then
            s &= "0"
        End If
        s &= temps Mod 60
        Me.Label_TempsRestant.Text = s
        Label_NomDuJoueur.Text = Memory.ComboBox1.Text
        Button_ArreterTimer.Text = "Pause"
        Button_ReprendreTimer.Text = "Reprendre"
        Timer1.Interval = 1000
        Timer1.Stop()
        nbDeCarteRetourner = 0
        nbCarreTrouve = 0

        If Paramettre.CheckBox3.Checked = True Then
            Dim i As Integer = 0
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is PictureBox Then
                    i += 1
                    ctl.image = tab(GetValeur(i))
                End If
            Next
            WaitFor(1)
        End If

        For Each ctl In GroupBox1.Controls
            If TypeOf ctl Is PictureBox Then
                ctl.Size = New Size(90, 125)
                ctl.image = tab(0)
                ctl.Visible = True
            End If
        Next
    End Sub

    ''' <summary>
    ''' Traitement du timer d'une partie de jeu Memory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temps -= 1
        Dim s As String = temps \ 60 & " : "
        If temps Mod 60 < 10 Then
            s &= "0"
        End If
        s &= temps Mod 60
        Me.Label_TempsRestant.Text = s
        If temps < 10 Then
            Label_TempsRestant.ForeColor = Color.Red
        End If
        If temps = 0 Then
            Timer1.Stop()
            FinDePartie()
            MsgBox("Vous avez perdu")
            Me.Close()
            Memory.Show()
        End If
    End Sub

    ''' <summary>
    ''' Permet d'abandonner la partie en cours en cliquant sur le button 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Abandon_Click(sender As Object, e As EventArgs) Handles Button_Abandon.Click
        If MsgBox("Voulez vous abandonner la partie en cours ?", vbQuestion + vbYesNo + vbDefaultButton2, "Abandon") = vbYes Then
            Me.Close()
            Memory.Show()
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

    ''' <summary>
    ''' Permet de connaître l'indice se trouvant dans le tableau d'images
    ''' </summary>
    ''' <param name="indice">l'indice de l'image dans le tableau enregistré dans Module1</param>
    ''' <returns></returns>
    Function GetValeur(indice As Integer) As Integer
        Return Module1.GetValeur(indice)
    End Function


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

        sender.image = tab(valeur)

        nbDeCarteRetourner += 1
        tabNbDeCartesRetourner.Add(GetIndice(sender))
        sender.Enabled = False

        If nbDeCarteRetourner < 2 Then
            valeurActuelle = valeur
        Else
            If valeurActuelle = valeur Then
                ' ce sont les mêmes cartes
                If nbDeCarteRetourner = 4 Then
                    ' ça fait un carée
                    tempsTrouvCarre = tempDeLaPartie - temps
                    nbCarreTrouve += 1
                    rendreEnable(tabNbDeCartesRetourner)
                    valeurActuelle = 0
                    nbDeCarteRetourner = 0
                    tabNbDeCartesRetourner.Clear()

                    If nbCarreTrouve = 5 Then
                        Timer1.Stop()
                        FinDePartie()
                        MsgBox("vous avez gagné")
                        Me.Close()
                        Memory.Show()
                    End If

                End If
            Else
                'Les cartes ne sont pas les même
                valeurActuelle = 0
                nbDeCarteRetourner = 0
                GroupBox1.Enabled = False
                WaitFor(1)
                GroupBox1.Enabled = True
                retournerCarte(tabNbDeCartesRetourner)
                tabNbDeCartesRetourner.Clear()
                ' tt remettre à 0 
            End If
        End If
    End Sub

    ''' <summary>
    ''' Permet d'enregistrer le joueur lors de la fin de la partie dans la base
    ''' </summary>
    Sub FinDePartie()
        Module1.EnregistreJoueur(Replace(Label_NomDuJoueur.Text, " ", ""), nbCarreTrouve, tempsTrouvCarre, 1, tempDeLaPartie - temps)
    End Sub

    ''' <summary>
    ''' Permet de retourner la carte
    ''' </summary>
    ''' <param name="tableau">Le tableau d'image</param>
    Sub retournerCarte(tableau As ArrayList)

        For j As Integer = 0 To tableau.Count() - 1
            Dim i As Integer = 0
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is PictureBox Then
                    i += 1
                    If i = tableau(j) Then
                        ctl.image = tab(0)
                        ctl.Enabled = True
                    End If
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Permet de rendre enable une ou plusieurs pictureBox d'un tableau 
    ''' </summary>
    ''' <param name="tab">le tableau d'image</param>
    Sub rendreEnable(tab As ArrayList)

        For j As Integer = 0 To tab.Count() - 1
            Dim i As Integer = 0
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is PictureBox Then
                    i += 1
                    If i = tab(j) Then
                        ctl.enabled = False
                        If Paramettre.CheckBox2.Checked = True Then
                            ctl.Visible = False
                        End If
                    End If
                End If
            Next
        Next
    End Sub

End Class