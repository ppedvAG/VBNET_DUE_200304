Imports System.IO

Public Class Form1
    Private Sub BtnLogging_Click(sender As Object, e As EventArgs) Handles BtnLogging.Click
        SaveLine(DateTime.Now.ToString() + ": Button wurde geklickt")
    End Sub

    Private Sub SaveLine(line As String)

        'Deklaration des StreamWriters außerhalb des Try-Blocks
        Dim writer As StreamWriter = Nothing

        'Start des Try-Blocks
        Try

            'Initialisierung des StreamWriters im Try-Block mit Übergabe des gewählten Speicherorts
            writer = New StreamWriter($"logging_{DateTime.Now.ToShortDateString()}.txt", True)

            'Abspeichern der Strings in der gewählten Datei
            writer.WriteLine(line)

        Catch ex As Exception

            'Ausgabe einer Misserfolgsmeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally

            'Schließen der Verbindung im Finally-Block, damit andere Programme Zugriff auf die Datei haben
            'If Not IsNothing(writer) Then
            '    writer.Close()
            'End If

            ' ? <- Nullprüfung der Variable reader (wenn Null, dann wird die Methode nicht aufgerufen)
            writer?.Close()

        End Try

    End Sub

    Private Sub BtnSaveText_Click(sender As Object, e As EventArgs) Handles BtnSaveText.Click
        SaveLine(TbxInput.Text)
    End Sub

    Private Sub BtnLoadLogs_Click(sender As Object, e As EventArgs) Handles BtnLoadLogs.Click
        LbxLogging.Items.Clear()
        LoadLines()
    End Sub

    Private Sub LoadLines()

        Dim reader As StreamReader = Nothing

        Try
            reader = New StreamReader("logging.txt")

            While Not reader.EndOfStream

                LbxLogging.Items.Add(reader.ReadLine())

            End While


        Catch ex As Exception

            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            reader?.Close()

        End Try

    End Sub
End Class
