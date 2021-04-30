Public Class Form1
    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim res As Integer = MsgBox("Voulez vous quittez", vbQuestion + vbYesNo + vbDefaultButton2, "Quitter")

        If res = 6 Then
            'Me.Close()
            End
        ElseIf res = 7 Then

        End If
    End Sub
End Class
