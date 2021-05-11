Module Module1

    Dim tab(19) As Integer

    Sub melangeTableau(tab() As Integer)
        Dim random As Random
        random = New Random()
        For nbfois = 0 To 10
            For i = 0 To tab.Length - 1
                Dim j As Integer = random.Next(0, tab.Length - 1)
                Dim temp
                temp = tab(i)
                tab(i) = tab(j)
                tab(j) = temp
            Next
        Next
    End Sub

    Function affiche(tab() As Integer) As String

        Dim mot As String = ""

        For i As Integer = 0 To UBound(tab)
            mot += tab(i) & ", "
        Next
        Return mot
    End Function
    Function GetValeur(indice As Integer) As Integer
        Return tab(indice - 1)
    End Function
    Sub Main()


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
        'Memory.LabelTest.Text = affiche(tab)
        melangeTableau(tab)
        Memory.LabelTest.Text = affiche(tab)
        Application.Run(Memory)
    End Sub
End Module