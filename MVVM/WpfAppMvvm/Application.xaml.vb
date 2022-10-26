Imports Autofac
Imports TestViewModelLibrary
Imports TestViewModelLibrary.Testjedoens.ViewModels
Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    Public Property Container As IContainer

    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        InitDependencyInjectionContainer()

        Dim mainWindow = Container.Resolve(Of MainWindow)
        mainWindow.Show()
    End Sub

    Private Sub InitDependencyInjectionContainer()
        Dim builder As New ContainerBuilder
        builder.RegisterType(Of UiAlert).As(Of IUiAlert)()
        builder.RegisterType(Of MainMaskViewModel).AsSelf()
        builder.RegisterType(Of MainWindow).AsSelf()

        Container = builder.Build()
    End Sub

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
End Class
