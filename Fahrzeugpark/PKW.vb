'vgl auch Schiff
Public Class PKW
    Inherits Fahrzeug

    Private _anzahlTüren As Integer
    Public Property AnzahlTüren() As Integer
        Get
            Return _anzahlTüren
        End Get
        Set(ByVal value As Integer)
            _anzahlTüren = value
        End Set
    End Property

    Public Sub New(name As String, maxG As Integer, preis As Double, anzT As Integer)
        MyBase.New(name, maxG, preis)
        _anzahlTüren = anzT
    End Sub

    'Überschreibende Methode (Benötigt eine gleichnamige, mit OVERRIDABLE markierte Methode in der Mutterklasse)
    Public Overrides Function BeschreibeMich() As String
        Return "Der PKW " + MyBase.BeschreibeMich() + $" Er hat {AnzahlTüren} Türen."
    End Function

    'Implementierung der abstrakten Methode der Fahrzeug-Klasse
    Public Overrides Sub Hupen()
        Console.WriteLine("HupHup")
    End Sub

End Class
