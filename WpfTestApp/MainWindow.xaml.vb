Imports TestViewModelLibrary.Testjedoens.ViewModels

Class MainWindow
    Sub New(vm As MainMaskViewModel)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        DataContext = vm
    End Sub
End Class
