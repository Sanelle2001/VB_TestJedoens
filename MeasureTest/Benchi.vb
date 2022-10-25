Module Benchmarks
    Public Class Benchi

#Region "Methods"
        Public Shared Sub CheckTimeSpan(name As String, ByRef TestMethod As Action)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke()
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Sub CheckTimeSpan(Of P1)(name As String, ByRef TestMethod As Action(Of P1), arg As P1)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke(arg)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Sub CheckTimeSpan(Of P1, P2)(name As String, ByRef TestMethod As Action(Of P1, P2), arg1 As P1, arg2 As P2)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke(arg1, arg2)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Sub CheckTimeSpan(Of P1, P2, P3)(name As String, ByRef TestMethod As Action(Of P1, P2, P3), arg1 As P1, arg2 As P2, arg3 As P3)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke(arg1, arg2, arg3)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Sub CheckTimeSpan(Of P1, P2, P3, P4)(name As String, ByRef TestMethod As Action(Of P1, P2, P3, P4), arg1 As P1, arg2 As P2, arg3 As P3, arg4 As P4)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke(arg1, arg2, arg3, arg4)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

        Public Shared Sub CheckTimeSpan(Of P1, P2, P3, P4, P5)(name As String, ByRef TestMethod As Action(Of P1, P2, P3, P4, P5), arg1 As P1, arg2 As P2, arg3 As P3, arg4 As P4, arg5 As P5)
            Dim watch = Stopwatch.StartNew()
            TestMethod.Invoke(arg1, arg2, arg3, arg4, arg5)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
        End Sub

#End Region

#Region "Function"

        Public Shared Function CheckTimeSpan(Of Tout)(name As String, ByRef TestFunction As Func(Of Tout)) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke()
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

        Public Shared Function CheckTimeSpan(Of P1, Tout)(name As String, ByRef TestFunction As Func(Of P1, Tout), arg As P1) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke(arg)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

        Public Shared Function CheckTimeSpan(Of P1, P2, Tout)(name As String, ByRef TestFunction As Func(Of P1, P2, Tout), arg1 As P1, arg2 As P2) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke(arg1, arg2)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

        Public Shared Function CheckTimeSpan(Of P1, P2, P3, Tout)(name As String, ByRef TestFunction As Func(Of P1, P2, P3, Tout), arg1 As P1, arg2 As P2, arg3 As P3) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke(arg1, arg2, arg3)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

        Public Shared Function CheckTimeSpan(Of P1, P2, P3, P4, Tout)(name As String, ByRef TestFunction As Func(Of P1, P2, P3, P4, Tout), arg1 As P1, arg2 As P2, arg3 As P3, arg4 As P4) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke(arg1, arg2, arg3, arg4)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function

        Public Shared Function CheckTimeSpan(Of P1, P2, P3, P4, P5, Tout)(name As String, ByRef TestFunction As Func(Of P1, P2, P3, P4, P5, Tout), arg1 As P1, arg2 As P2, arg3 As P3, arg4 As P4, arg5 As P5) As Tout
            Dim watch = Stopwatch.StartNew()
            Dim output = TestFunction.Invoke(arg1, arg2, arg3, arg4, arg5)
            watch.Stop()
            Console.WriteLine(name + $" Time: {watch.ElapsedMilliseconds} ms.")
            Return output
        End Function
    End Class

#End Region

End Module
