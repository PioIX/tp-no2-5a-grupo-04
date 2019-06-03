Public Class Bingo


    Private Sub btnlinea_Click(sender As Object, e As EventArgs) Handles btnlinea.Click
        MsgBox("LINEA")
    End Sub

    Private Sub btnBingo_Click(sender As Object, e As EventArgs) Handles btnBingo.Click
        MsgBox("BINGO")
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        MsgBox("Realmente desea salir?", vbYesNo)
        If vbYesNo = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.BackColor = Color.Yellow
    End Sub

End Class
