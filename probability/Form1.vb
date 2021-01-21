Public Class Form1

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Randomize()
        Dim intCounter As Integer
        Dim intCount As Integer
        Dim intUser As Integer
        Dim intD1 As Integer
        Dim intD2 As Integer
        Dim intTotal As Integer
        Const TRIALS As Integer = 1000000

        intUser = Val(txtNumber.Text)

        For intCounter = 1 To TRIALS
            intD1 = Int(Rnd() * 6) + 1
            intD2 = Int(Rnd() * 6) + 1
            intTotal = intD1 + intD2

            If intTotal = intUser Then
                intCount = intCount + 1
            End If
        Next

        MessageBox.Show("Probability: " & intCount / TRIALS)

    End Sub
End Class
