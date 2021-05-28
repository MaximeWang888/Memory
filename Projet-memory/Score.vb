Public Class Score
    ''' <summary>
    ''' Permet d'initialiser ce formulaire dont les valeurs qui sont stockés dans les fichiers extérieurs.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To Module1.nbJoueur - 1
            Dim temps As String = Module1.joueurs(i).temps \ 60 & " : "
            If Module1.joueurs(i).temps Mod 60 < 10 Then
                temps &= "0"
            End If
            temps &= Module1.joueurs(i).temps Mod 60

            Dim cumule As String = Module1.joueurs(i).cumule \ 60 & " : "
            If Module1.joueurs(i).cumule Mod 60 < 10 Then
                cumule &= "0"
            End If
            cumule &= Module1.joueurs(i).cumule Mod 60

            DataGridView1.Rows.Add(Module1.joueurs(i).nom, Module1.joueurs(i).nbcarretrouvé, temps,
                                   Module1.joueurs(i).nbpartiejoué, cumule)
        Next

    End Sub

    ''' <summary>
    ''' Un bouton retourner qui permet de cacher ce formulaire actuelle et d'afficher le formulaire "Memory".
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        Memory.Show()
    End Sub


End Class