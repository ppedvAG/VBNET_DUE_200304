'vgl Schiff
Public Class Flugzeug
    Inherits Fahrzeug
    Implements IBewegbar

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
        End Set
    End Property

    Private _anzahlRäder As Integer
    Public Property AnzahlRäder As Integer Implements IBewegbar.AnzahlRäder
        Get
            Return _anzahlRäder
        End Get
        Set(value As Integer)
            _anzahlRäder = value
        End Set
    End Property

    Public Sub New(name As String, preis As Double, maxG As Integer, maxF As Integer)
        MyBase.New(name, preis, maxG)
        _maxFlughöhe = maxF
        _anzahlRäder = 8
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Flugzeug " + MyBase.BeschreibeMich() + $" Es kann auf {MaxFlughöhe}m aufsteigen."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Piep")
    End Sub

    Public Sub Crash() Implements IBewegbar.Crash
        AnzahlRäder -= 1

        Console.WriteLine("Du hast den Vogel übersehen")
    End Sub
End Class
