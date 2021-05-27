Module Module1

    Public tab(19) As Integer
    Public joueurs(2) As Joueur
    Dim nbJoueur As Integer = 0
    'Public nbImagesIdentique As Integer
    'Public nbImagesIdentique2 As Integer
    'Public nbImagesIdentique3 As Integer
    'Public nbImagesIdentique4 As Integer
    'Public nbImagesIdentique5 As Integer
    Public Structure Joueur
        Public nom As String
        Public nbcarretrouvé As Integer
        Public temps As Integer
        Public nbpartiejoué As Integer
        Public cumule As Integer
    End Structure


    Sub melangeTableau(tab() As Integer)

        For nbfois = 0 To 10
            For i = 0 To tab.Length - 1
                Dim random As Random
                random = New Random()
                Dim j As Integer = random.Next(0, tab.Length - 1)
                Dim temp
                temp = tab(i)
                tab(i) = tab(j)
                tab(j) = temp
            Next
        Next
    End Sub

    Sub avoirUnCarre(nb As Integer)
        If nb = 4 Then
            MsgBox("UN CARRE DE TROUVE")
        End If
    End Sub
    Function affiche(Joueurs As ArrayList) As String

        Dim mot As String = ""

        For Each joueur In Joueurs
            mot += joueur.Nom & " "
            mot += joueur.nbCarreTrouvé & " "
            mot += joueur.temps & " "
            mot += joueur.nbPartieJoué & " "
            mot += joueur.cumule & " \n"

        Next
        Return mot
    End Function
    Function GetValeur(indice As Integer) As Integer
        Return tab(indice - 1)
    End Function

    Sub initialiserTableau()
        ReDim Preserve joueurs(4)
        For i As Integer = 0 To 3
            tab(i) = 1
        Next
        For i As Integer = 4 To 7
            tab(i) = 2
        Next
        For i As Integer = 8 To 11
            tab(i) = 3
        Next
        For i As Integer = 12 To 15
            tab(i) = 4
        Next
        For i As Integer = 16 To 19
            tab(i) = 5
        Next
    End Sub
    Sub EnregeistreJour(nom As String, nbcarretrouvé As Integer, temps As Integer, cumule As Integer)
        If nbJoueur >= UBound(joueurs) Then
            ReDim Preserve joueurs(nbJoueur * 2)
        End If
        Dim indiceJoueur As Integer = JoueurExiste(nom)
        If indiceJoueur = -1 Then
            'Le joueur n'existe pas 
            Dim J As Joueur
            J.nom = nom
            J.nbcarretrouvé = nbcarretrouvé
            J.temps = temps
            J.nbpartiejoué = 1
            J.cumule = cumule
            joueurs(nbJoueur) = J
            nbJoueur += 1
        Else
            'Le joeur existe et il remplace les valeur qui sont mieuxx que a pertie d'avant

            joueurs(indiceJoueur).nbpartiejoué += 1
            joueurs(indiceJoueur).cumule += cumule
            If nbcarretrouvé > joueurs(indiceJoueur).nbcarretrouvé Then
                joueurs(indiceJoueur).nbcarretrouvé = nbcarretrouvé
                joueurs(indiceJoueur).temps = temps
            ElseIf nbcarretrouvé = joueurs(indiceJoueur).nbcarretrouvé And temps < joueurs(indiceJoueur).temps Then
                joueurs(indiceJoueur).temps = temps
            End If
        End If
    End Sub
    Function JoueurExiste(nom As String) As Integer
        'If nbJoueur Then
        '    Return -1
        'End If
        For i As Integer = 0 To nbJoueur - 1
            If nom = joueurs(i).Nom Then
                Return i
            End If
        Next
        Return -1
    End Function

    Sub Affiche()
        Dim mot As String = ""
        For i As Integer = 0 To nbJoueur - 1
            mot &= joueurs(i).Nom & "  "
            mot &= joueurs(i).nbcarretrouvé & "  "
            mot &= joueurs(i).temps & "  "
            mot &= joueurs(i).nbpartiejoué & "  "
            mot &= joueurs(i).cumule & vbCrLf
        Next
        Memory.LabelTest.Text = mot
    End Sub
    Sub Main()
        ReDim joueurs(2)
        EnregeistreJour("max", 3, 50, 50)
        EnregeistreJour("fab", 3, 40, 40)
        EnregeistreJour("toto", 2, 45, 45)
        EnregeistreJour("max", 4, 55, 55)
        EnregeistreJour("max", 3, 32, 55)
        Affiche()


        initialiserTableau()
        'Memory.LabelTest.Text = affiche(tab)
        melangeTableau(tab)
        ' Memory.LabelTest.Text = affiche(Joueurs)
        Application.Run(Memory)
    End Sub
End Module