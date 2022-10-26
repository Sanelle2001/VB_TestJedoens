Friend Class UserPrinter
    Implements IUserPrinter

    Private ReadOnly _userProvider As IUserProvider
    Private ReadOnly _logger As ILogger

    Sub New(userProvider As IUserProvider, logger As ILogger)
        _userProvider = userProvider
        _logger = logger
        Console.WriteLine("New UserPrinter")
    End Sub

    Public Sub PrintUser() Implements IUserPrinter.PrintUser
        Console.WriteLine(_userProvider.GetUser())
        _logger.Trace("Hab was getan!")
    End Sub
End Class