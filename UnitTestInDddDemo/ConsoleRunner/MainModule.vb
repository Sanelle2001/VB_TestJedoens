#Const UNITOFWORK = 1
Imports AppKernel
Imports AppKernel.AppKernel
Imports Autofac
Imports UnitTestDemo.AppDomain
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppInfrastructure
Imports UnitTestDemo.AppInfrastructure.Services

Module MainModule

    Sub Main()
        Using container = InitContainer()
            Dim advertisingUseCase = container.Resolve(Of IAdvertisingUseCase)
            advertisingUseCase.SendAdvertisingToUserByNamePart("ranz").Wait()
#Region "UoW"
            TestUnitOfWork(container)
#End Region
        End Using

        Console.ReadLine()
    End Sub

    <Conditional("UNITOFWORK")>
    Private Sub TestUnitOfWork(container As IContainer)
        Console.WriteLine(vbCrLf + vbCrLf + "Beginne UnitOfWork Test:" + vbCrLf)
        Using unitOfWork = container.Resolve(Of IUnitOfWork)
            Dim userRepo = unitOfWork.GetRepository(Of IUserRepository)()
            unitOfWork.Complete()
        End Using
    End Sub

    Private Function InitContainer() As IContainer
        Dim builder As New ContainerBuilder
        builder.RegisterType(Of Persistance).As(Of IPersistance)().SingleInstance()
        builder.RegisterType(Of BarkToTheWoodAdvertiserService).As(Of IBarkToTheWoodAdvertiserService)()
        builder.RegisterType(Of UserRepository).As(Of IUserRepository)()
        builder.RegisterType(Of AdvertisingUseCase).As(Of IAdvertisingUseCase)()
        builder.RegisterType(Of UnitOfWork).As(Of IUnitOfWork)()
        Return builder.Build()
    End Function
End Module
