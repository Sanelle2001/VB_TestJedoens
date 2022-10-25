''' <summary>
''' Vertrag für Logging
''' </summary>
Public Interface ILoggingProvider
    Sub Verbose(message As String)
    Sub Info(message As String)
    Sub Warning(message As String)
    Sub Critical(message As String, exception As Exception)
End Interface

''' <summary>
''' Model für Anwendungsbenutzer
''' </summary>
Public Class ApplicationUser

    Private _firstName As String ' Felder
    Private _lastName As String
    Private _loggingProvider As ILoggingProvider

    Public Sub New(loggingProvider As ILoggingProvider)
        _loggingProvider = loggingProvider
    End Sub

    Public Sub New(loggingProvider As ILoggingProvider, firstName As String, lastName As String) ' lokale Variable
        Me.New(loggingProvider)
        _firstName = firstName
        _lastName = lastName

    End Sub

    Public Property FirstName() As String ' Eigenschaften
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
            _loggingProvider.Verbose($"Neuer Vorname: {_firstName}")
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
            _loggingProvider.Verbose($"Neuer Nachname: {_lastName}")
        End Set
    End Property

    ''' <summary>
    ''' String bestehend aus Vor- und Nachname plust einer Zufallszahl in der Mitte
    ''' </summary>
    ''' <remarks>
    ''' 2022-09-22 FN: Erste komische Version dieses Geräts
    ''' 2022-09-23 FN (1) Logging hinzugefügt
    ''' </remarks>
    ''' <returns>Etwas zufälliger String</returns>
    Public Function GenerateRandomLoginName() As String ' Methodenbezeichnung
        Dim randomNumberGenerator As New Random(4711)
        Dim output = $"{_firstName}{randomNumberGenerator.Next}{_lastName}"
        _loggingProvider.Info($"Neuer zufälliger Bezeichner generiert: {output}.") '1
        Return output
    End Function

End Class
