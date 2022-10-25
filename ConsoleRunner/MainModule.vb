Imports AppKernel
Imports AppKernel.AppKernel
Imports Autofac
Imports UnitTestDemo.AppDomain
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppDomain.Models
Imports UnitTestDemo.AppInfrastructure
Imports UnitTestDemo.AppInfrastructure.Services

Module MainModule
    Private _container As IContainer

    Sub Main()
        InitContainer()

        Dim advertisingUseCase = _container.Resolve(Of IAdvertisingUseCase)
        advertisingUseCase.SendAdvertisingToUserByNamePart("ranz").Wait()

        Using unitOfWork = _container.Resolve(Of IUnitOfWork)
            Dim userRepo = unitOfWork.GetRepository(Of IUserRepository)()
            unitOfWork.Complete()
        End Using
        Console.ReadLine()
    End Sub

    Private Sub InitContainer()
        Dim builder As New ContainerBuilder
        builder.RegisterType(Of Persistance).As(Of IPersistance)().SingleInstance()
        builder.RegisterType(Of BarkToTheWoodAdvertiserService).As(Of IBarkToTheWoodAdvertiserService)()
        builder.RegisterType(Of UserRepository).As(Of IUserRepository)()
        builder.RegisterType(Of AdvertisingUseCase).As(Of IAdvertisingUseCase)()
        builder.RegisterType(Of UnitOfWork).As(Of IUnitOfWork)()
        _container = builder.Build()
    End Sub
End Module
