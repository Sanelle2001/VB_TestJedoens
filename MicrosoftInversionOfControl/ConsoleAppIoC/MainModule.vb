Imports System.ComponentModel
Imports Microsoft.Extensions.DependencyInjection

Module MainModule
    Sub Main()
        Dim container As New ServiceCollection()
        container.AddSingleton(Of IUserProvider, UserProvider)()
        container.AddTransient(Of IUserPrinter, UserPrinter)()
        'container.AddTransient(Of ILogger, Logger)()
        container.AddTransient(Of ILogger, LoggerNeu)()

        Dim serviceProvider = container.BuildServiceProvider()

        Dim userPrinter1 = serviceProvider.GetService(Of IUserPrinter)
        Dim userPrinter2 = serviceProvider.GetService(Of IUserPrinter)

        userPrinter1.PrintUser()
        userPrinter2.PrintUser()

        Console.ReadLine()
    End Sub

End Module
