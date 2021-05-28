Public Class Score
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Memory.Show()
    End Sub


End Class