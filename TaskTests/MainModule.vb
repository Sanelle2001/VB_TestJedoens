Module MainModule

    Sub Main()
        Dim parameter = New ProcessData() With {.CheckValue = "HaHaHa"}
        Dim result As ProcessResult

        result = Task.Run(Async Function() As Task(Of ProcessResult)
                              Await Task.Delay(5000)
                              Return New ProcessResult("Moser")
                          End Function).Result

        Console.WriteLine(result.Name + " " + result.Index.ToString())
        Console.ReadLine()
    End Sub

End Module
