'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Module1

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    Sub Main()

        'Deklaration und Initialisierung einer String-Variablen
        Dim meinString As String = "Hello World"

        'Ausgabe der String-Variablen in der Konsole
        Console.WriteLine(meinString)
        'Ausgabe eines String-Literals in der Konsole
        Console.WriteLine("Mein Name ist Klaas")

        'Deklaration und Initialisierung weiterer Variablen
        Dim kommazahl As Double = 30.5
        Dim Alter As Integer = 30
        Dim Stadt As String = "Berlin"

        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden
        Console.WriteLine("Ich bin " & Alter.ToString() + " Jahre alt und ich komme aus " + Stadt + ".")
        Dim kombinierterString As String = "Ich bin " & Alter.ToString() + " Jahre alt und ich komme aus " + Stadt + "."
        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Ich bin {0} Jahre alt und ich komme aus {1}.", Alter, Stadt)
        ''$-Schreibweise -> Variablen werden direkt im String plaziert
        Console.WriteLine($"Ich bin {Alter} Jahre alt und ich komme aus {Stadt}.")
        kombinierterString = $"Ich bin {Alter} Jahre alt und ich komme aus {Stadt}."
        Console.WriteLine(kombinierterString)

        'Formatierung durch Konstanten
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine($"Dies ist ein {vbNewLine}Zeilenumbruch und dies ein {vbTab} horizontaler Tabulator.")
        'Deklaration und Initialisierung einer eigenen Konstanten
        Const meineKonstante As Integer = 45

        'Speichern einer Benutzereingabe (String) in einer Variablen
        Dim inputString As String = Console.ReadLine()
        Console.WriteLine("Du hast eingegeben: " + inputString)

        Console.WriteLine("Bitte gib eine ganze Zahl ein:")
        Dim eingabe As String = Console.ReadLine()
        'Parsen des Strings in einen Integer
        Dim zahl As Integer = Integer.Parse(eingabe)
        zahl = zahl * 2
        Console.WriteLine("Das Doppelte deiner Zahl ist " + zahl.ToString())

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
