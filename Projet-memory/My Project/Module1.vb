Imports System.IO
Module Module1
    ''' <summary>
    ''' Définit les différents attributs qui seront utiles par la suite
    ''' </summary>
    Public path As String = "Scores.txt"
    Public tab(19) As Integer
    Public joueurs(2) As Joueur
    Public nbJoueur As Integer = 0

    ''' <summary>
    ''' Déclaration de la structure Joueur
    ''' </summary>
    Public Structure Joueur
        Public nom As String
        Public nbcarretrouvé As Integer
        Public temps As Integer
        Public nbpartiejoué As Integer
        Public cumule As Integer
    End Structure

    ''' <summary>
    ''' Permet de mélanger le tableau passé en paramètre
    ''' </summary>
    ''' <param name="tab">le tableau a mélangé</param>
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

    ''' <summary>
    ''' Permet de la valeur à l'indice du tableau passé en paramètre
    ''' </summary>
    ''' <param name="indice"></param>
    ''' <returns></returns>
    Function GetValeur(indice As Integer) As Integer
        Return tab(indice - 1)
    End Function

    ''' <summary>
    ''' Permet d'initialiser les valeurs des images sous formes de nombres entiers dans un tableau
    ''' </summary>
    Sub initialiserTableau()

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

    ''' <summary>
    ''' Permet d'enregistrer un joueur 
    ''' </summary>
    ''' <param name="nom">le nom du joueur à enregistrer</param>
    ''' <param name="nbcarretrouvé">le nombre de carré trouvé par ce joueur</param>
    ''' <param name="temps">le temps qui lui a pris pour trouvé le nbCarreTrouvé</param>
    ''' <param name="nbpartiejoué">le nombre de parties joués par ce joueur</param>
    ''' <param name="cumule">le temps cumulé de toutes les parties joués par ce joueur là</param>
    Public Sub EnregistreJoueur(nom As String, nbcarretrouvé As Integer, temps As Integer, nbpartiejoué As Integer, cumule As Integer)
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
            J.nbpartiejoué = nbpartiejoué
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

    ''' <summary>
    ''' Permet de savoir si un joueur existe déjà ou non en recherchant dans le tableau de joueur par son nom 
    ''' </summary>
    ''' <param name="nom">le nom du joueur</param>
    ''' <returns></returns>
    Function JoueurExiste(nom As String) As Integer
        For i As Integer = 0 To nbJoueur - 1
            If nom = joueurs(i).nom Then
                Return i
            End If
        Next
        Return -1
    End Function

    ''' <summary>
    ''' Permet de sauvegarder le score des joueurs dans un fichier externe
    ''' </summary>
    Public Sub sauvegarder()
        If File.Exists(path) Then
            File.Delete(path)
        End If
        Dim mot As String = ""
        For i As Integer = 0 To nbJoueur - 1
            mot &= joueurs(i).nom & " " & joueurs(i).nbcarretrouvé & " " & joueurs(i).temps & " " & joueurs(i).nbpartiejoué & " " & joueurs(i).cumule & vbCrLf
        Next
        File.WriteAllText(path, mot)
    End Sub

    ''' <summary>
    ''' Permet de récupérer les scores des joueurs depuis un fichier externe
    ''' </summary>
    Public Sub recupSauvegarder()
        Dim lire As New StreamReader(path)

        If File.Exists(path) Then
            While (lire.Peek() >= 0)
                Dim joueur As String = lire.ReadLine()
                Dim tabJoeur() As String = joueur.Split()
                EnregistreJoueur(tabJoeur(0), tabJoeur(1), tabJoeur(2), tabJoeur(3), tabJoeur(4))
            End While
        End If
        lire.Close()
    End Sub

    ''' <summary>
    ''' Permet de lancer l'application en commançant par le formulaire 'Memory'
    ''' </summary>
    Sub Main()
        ReDim joueurs(2)
        recupSauvegarder()
        initialiserTableau()
        melangeTableau(tab)
        Application.Run(Memory)
    End Sub
End Module