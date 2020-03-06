Imports System.Threading

Public Class Form1

    Dim IsActive As Boolean = False

    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden
    Private Sub BtnKlickMich_Click(sender As Object, e As EventArgs) Handles BtnKlickMich.Click

        BtnKlickMich.Left += 10

        TextBox1.Text = "Hallo"

        MessageBox.Show(TextBox1.Text)

    End Sub

    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles BtnActivate.Click

        If IsActive Then

            MessageBox.Show("Deaktivieren erfolgreich")

            BackColor = Color.Aqua

            IsActive = False

        Else

            MessageBox.Show("Aktivieren erfolgreich")

            BackColor = Color.HotPink

            IsActive = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim warten As WarteBildschirm = New WarteBildschirm()

        'warten.ShowDialog()

        Label1.Visible = True
        Me.Refresh()

        For index = 1 To 10000
            Debug.WriteLine(index)
        Next


        Label1.Visible = False
        Me.Refresh()

    End Sub

End Class
