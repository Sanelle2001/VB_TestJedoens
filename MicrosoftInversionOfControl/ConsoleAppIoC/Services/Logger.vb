Public Class Logger
    Implements ILogger

    Public Sub Trace(message As String) Implements ILogger.Trace
        Console.WriteLine(message)
    End Sub
End Class