Imports Autofac

Module ApplicationModule

    Sub Main()
        Dim builder As New ContainerBuilder
        builder.RegisterType(Of UserProvider).As(Of IUserProvider)().SingleInstance()
        builder.RegisterType(Of UserPrinter).As(Of IUserPrinter)()
        builder.RegisterType(Of Logger).As(Of ILogger)()

        Dim container = builder.Build()

        Dim userPrinter1 = container.Resolve(Of IUserPrinter)
        Dim userPrinter2 = container.Resolve(Of IUserPrinter)

        userPrinter1.PrintUser()
        userPrinter2.PrintUser()

        Console.ReadLine()

    End Sub

    Friend Class User
        Public Property FirstName As String
        Public Property LastName As String
        Public Property No As Integer

        Public Overrides Function ToString() As String
            Return No.ToString() + " " + FirstName + " " + LastName
        End Function
    End Class

    Friend Interface IUserProvider
        Function GetUser() As User

    End Interface

    Friend Class UserProvider
        Implements IUserProvider

        Private Shared counter As Integer = 0

        Sub New()
            Console.WriteLine("New UserProvider")
        End Sub

        Public Function GetUser() As User Implements IUserProvider.GetUser
            Dim u = New User()
            u.FirstName = "Franz"
            u.LastName = "Nellen"
            counter = counter + 1
            u.No = counter
            Return u
        End Function
    End Class

    Friend Interface IUserPrinter
        Sub PrintUser()
    End Interface

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
End Module

Public Interface ILogger
    Sub Trace(message As String)
End Interface

Public Class Logger
    Implements ILogger

    Public Sub Trace(message As String) Implements ILogger.Trace
        Console.WriteLine(message)
    End Sub
End Class

Public Class LoggerNeu
    Implements ILogger

    Public Sub Trace(message As String) Implements ILogger.Trace
        Console.WriteLine(DateTime.Now + " : " + message)
    End Sub
End Class