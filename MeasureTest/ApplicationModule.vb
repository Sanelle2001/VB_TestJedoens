Module ApplicationModule

    Sub Main()
        Benchi.CheckTimeSpan(AddressOf PrintHello)

        Console.WriteLine(Benchi.CheckTimeSpan(AddressOf GetAnswerForEverything))

        Console.ReadLine()
    End Sub

    Sub PrintHello()
        Console.WriteLine("Hello World")
        Task.Delay(250).Wait()
    End Sub

    Function GetAnswerForEverything() As Integer
        Task.Delay(1000).Wait()
        Return 42
    End Function

    Sub Test()
        Dim testString = "42"
        Dim zahl As Integer = Nothing

        If Not Integer.TryParse(testString, zahl) Then
            zahl = -1
        End If
        Console.WriteLine(zahl)
    End Sub

End Module
