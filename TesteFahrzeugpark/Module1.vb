Imports Fahrzeugpark

Module Module1

    Sub Main()

#Region "Modul/Lab 04: Objektorientierte Programmierung"

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name-Property von fz1 (über deren Getter)
        'Console.WriteLine(fz1.Name)

        ''Ausführen einer Methode von fz1
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine(fz1.AktGeschwindigkeit)
        'Console.WriteLine(fz2.AktGeschwindigkeit)

        ''Ausführen von Methoden von fz1
        'fz1.StarteMotor()
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine(fz1.BeschreibeMich())
        'Console.WriteLine(fz2.BeschreibeMich())

#End Region

#Region "Modul05/Lab05: Vererbung"
        'Deklaration und Initialisierung der spezifischen Fahrzeuge sowie Aufruf der BeschreibeMich()-Methoden
        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        Console.WriteLine(pkw1.BeschreibeMich())

        Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        Console.WriteLine(flugzeug1.BeschreibeMich())

        Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)
        Console.WriteLine(schiff1.BeschreibeMich())

        'Aufruf der abstarkten Methoden Hupen()
        pkw1.Hupen()
        schiff1.Hupen()
        flugzeug1.Hupen()

        'Ausgabe des Shared Members der Fahrzeug-Klasse
        Console.WriteLine("Produzierte Fahrzeuge: " + Fahrzeug.AnzahlFahrzeuge.ToString())
#End Region

        Console.ReadKey()

    End Sub

End Module
