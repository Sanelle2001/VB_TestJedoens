Imports Autofac
Imports UnitTestDemo.AppDomain
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppInfrastructure.Services

Public NotInheritable Class UnitOfWork
    Implements IUnitOfWork

    Private ReadOnly _container As IContainer
    Private ReadOnly _baseConnector As IPersistance
    Private _wasCompleted As Boolean = False

    Public Sub New()
        Dim builder As New ContainerBuilder
        builder.RegisterType(Of Persistance).As(Of IPersistance)().SingleInstance()
        builder.RegisterType(Of UserRepository).As(Of IUserRepository)()

        _container = builder.Build()

        _baseConnector = _container.Resolve(Of IPersistance)
        _baseConnector.BeginTransaction()
    End Sub

    Public Function GetRepository(Of T)() As T Implements IUnitOfWork.GetRepository
        Return _container.Resolve(Of T)
    End Function

    Public Function Complete() As Boolean Implements IUnitOfWork.Complete
        Dim baseConnector = _container.Resolve(Of IPersistance)
        _wasCompleted = baseConnector.EndTransaction()
        Return _wasCompleted
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        _container?.Dispose()
        If Not _wasCompleted And _baseConnector.TransActionStarted Then

            Console.WriteLine("Irgendwie nicht gespeichert.")
        End If
    End Sub
End Class
