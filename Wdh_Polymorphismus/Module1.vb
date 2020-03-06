Module Module1

    Sub Main()

        Dim hund1 As Hund = New Hund("Bello", "Braun")
        Console.WriteLine(hund1.Name + ": " + hund1.Fellfarbe)

        Dim meise1 As Meise = New Meise("Tschiep", "Blau")
        Console.WriteLine(meise1.Name + ": " + meise1.Federfarbe)

        BenenneUm(hund1, "Hasso")
        Console.WriteLine(hund1.Name + ": " + hund1.Fellfarbe)

        BenenneUm(meise1, "Pieps")
        Console.WriteLine(meise1.Name + ": " + meise1.Federfarbe)

        Dim flugzeug1 As Flugzeug = New Flugzeug(9999, 4)
        Console.WriteLine(flugzeug1.MaxFlughöhe.ToString() + ": " + flugzeug1.AnzahlFlügel.ToString())

        FlügelAb(meise1)
        FlügelAb(flugzeug1)
        Console.WriteLine(flugzeug1.MaxFlughöhe.ToString() + ": " + flugzeug1.AnzahlFlügel.ToString())

        Console.ReadKey()

    End Sub

    Public Sub BenenneUm(tier1 As Tier, neuerName As String)

        tier1.Name = neuerName

        If TypeOf tier1 Is Hund Then

            Dim hund1 As Hund = DirectCast(tier1, Hund)

            hund1.Fellfarbe = "Schwarz"

        End If

    End Sub

    Public Sub FlügelAb(flugfähigeObjekt As IFlugfähig)

        flugfähigeObjekt.AnzahlFlügel -= 1

    End Sub

End Module

Public MustInherit Class Tier

    Private _anzahlBeine As Integer
    Public Property AnzahlBeine() As Integer
        Get
            Return _anzahlBeine
        End Get
        Set(ByVal value As Integer)
            _anzahlBeine = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Sub New(name As String, anzB As Integer)
        _anzahlBeine = anzB
        _name = name
    End Sub

    Public MustOverride Sub Fressen()

End Class

Public Class Hund
    Inherits Tier

    Private _fellfarbe As String
    Public Property Fellfarbe() As String
        Get
            Return _fellfarbe
        End Get
        Set(ByVal value As String)
            _fellfarbe = value
        End Set
    End Property

    Public Sub New(name As String, fellfarbe As String)

        MyBase.New(name, 4)
        _fellfarbe = fellfarbe

    End Sub

    Public Overrides Sub Fressen()

        Console.WriteLine("Der Hund frisst ein Stück Fleisch")

    End Sub

End Class

Public Class Meise
    Inherits Tier
    Implements IFlugfähig

    Private _federfarbe As String
    Public Property Federfarbe() As String
        Get
            Return _federfarbe
        End Get
        Set(ByVal value As String)
            _federfarbe = value
        End Set
    End Property

    Private _anzahlFlügel As Integer
    Public Property AnzahlFlügel As Integer Implements IFlugfähig.AnzahlFlügel
        Get
            Return _anzahlFlügel
        End Get
        Set(value As Integer)
            _anzahlFlügel = value
        End Set
    End Property

    Public Sub New(name As String, federfarbe As String)

        MyBase.New(name, 2)

        _federfarbe = federfarbe

        _anzahlFlügel = 2

    End Sub

    Public Overrides Sub Fressen()
        Console.WriteLine("Die Meise pickt Körner")
    End Sub

    Public Sub Absturz() Implements IFlugfähig.Absturz
        Console.WriteLine("Die Meise ist zu hoch geflogen")
    End Sub
End Class

Public Class Flugzeug
    Implements IFlugfähig

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
        End Set
    End Property

    Private _anzahlFlügel As Integer
    Public Property AnzahlFlügel As Integer Implements IFlugfähig.AnzahlFlügel
        Get
            Return _anzahlFlügel
        End Get
        Set(value As Integer)
            _anzahlFlügel = value
        End Set
    End Property

    Public Sub New(maxF As Integer, anzF As Integer)

        _maxFlughöhe = maxF

        _anzahlFlügel = anzF

    End Sub

    Public Sub Absturz() Implements IFlugfähig.Absturz
        Console.WriteLine("Da war eine Meise im Weg")
    End Sub
End Class

Public Interface IFlugfähig

    Property AnzahlFlügel As Integer

    Sub Absturz()

End Interface
