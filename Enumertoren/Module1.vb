Module Module1

    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag
    End Enum

    Sub Main()

        Dim heute As Wochentag = Wochentag.Mittwoch
        Console.WriteLine($"Heute ist {heute}.")

        For index = 1 To 7
            Console.WriteLine($"{index}: {DirectCast(index, Wochentag)}")
        Next

        heute = Integer.Parse(Console.ReadLine())

        Console.WriteLine($"Heute ist {heute}.")

        Select Case heute

            Case Wochentag.Montag
                Console.WriteLine("Schönen Wochenstart")
            Case Wochentag.Mittwoch
                Console.WriteLine("Hälfte geschafft")
            Case Wochentag.Freitag
                Console.WriteLine("Woche fast vorbei")
            Case Else
                Console.WriteLine("Woche läuft...")

        End Select


        Console.ReadKey()
    End Sub

End Module
