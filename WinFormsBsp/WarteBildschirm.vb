Imports System.Threading

Public Class WarteBildschirm

    Private Sub WarteBildschirm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Label1.Text = "Bitte Warten. DB-Abfrage"

        RufeDBAb()

        Me.Close()
    End Sub

    Private Sub RufeDBAb()

        Thread.Sleep(1000)

        For index = 1 To 10000
            Debug.WriteLine(index)
        Next

    End Sub

End Class