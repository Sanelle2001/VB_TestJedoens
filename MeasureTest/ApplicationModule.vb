Module ApplicationModule

    Sub Main()
        Benchi.CheckTimeSpan(NameOf(PrintHello), AddressOf PrintHello)

        Console.WriteLine("Result GetAnswerForEverything = " + Benchi.CheckTimeSpan(NameOf(GetAnswerForEverything), AddressOf GetAnswerForEverything).ToString())

        Console.WriteLine("Result TestParameterFunction = " + Benchi.CheckTimeSpan(NameOf(TestParameterFunction), AddressOf TestParameterFunction, "Franz"))

        Console.WriteLine("Result TestParameterFunction = " + Benchi.CheckTimeSpan(NameOf(TestParameterFunction), AddressOf TestParameterFunction, 4711))

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

    Function TestParameterFunction(name As String) As String
        Task.Delay(500).Wait()
        Return "Hello " + name
    End Function

    Function TestParameterFunction(number As Integer) As String
        Task.Delay(300).Wait()
        Return number.ToString()
    End Function

End Module
