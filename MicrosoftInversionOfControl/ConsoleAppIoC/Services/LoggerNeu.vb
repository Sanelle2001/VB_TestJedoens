Public Class LoggerNeu
    Implements ILogger

    Public Sub Trace(message As String) Implements ILogger.Trace
        Console.WriteLine(DateTime.Now + " : " + message)
    End Sub
End Class