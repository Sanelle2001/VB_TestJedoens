Module Benchmarks

    Public Class Benchi

        Public Shared Sub CheckTimeSpan(ByRef TestMethod As Action)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke()
            watch.Stop()
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Function CheckTimeSpan(Of T)(ByRef TestFunction As Func(Of T)) As T
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke()
            watch.Stop()
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

    End Class

End Module
