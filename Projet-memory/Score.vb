Public Class Score
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows(0).Cells("Column1").Value = "Miriam"
        DataGridView1.Rows.Add()
    End Sub
End Class