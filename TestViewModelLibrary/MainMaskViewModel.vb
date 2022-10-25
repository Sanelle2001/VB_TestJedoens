Imports System.Windows.Input
Imports CommunityToolkit.Mvvm.ComponentModel
Imports CommunityToolkit.Mvvm.Input

Namespace Testjedoens.ViewModels
    Partial Public Class MainMaskViewModel
        Inherits ObservableObject

        Private _uiAlert As IUiAlert
        Private _firstName As String
        Private _lastName As String

        Public Sub New(uiAlert As IUiAlert)
            _uiAlert = uiAlert
            ShowAlertCommand = New RelayCommand(AddressOf ShowAllert, AddressOf CanShowAlert)
        End Sub

        Private Function CanShowAlert() As Boolean
            Return Not String.IsNullOrWhiteSpace(FirstName) And Not String.IsNullOrWhiteSpace(LastName)
        End Function

        Private Sub ShowAllert()
            _uiAlert.Alert($"Hello {FirstName} {LastName} :-)", "Hi")
            FirstName = ""
            LastName = ""
        End Sub

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                SetProperty(_firstName, value)
                ShowAlertCommand.NotifyCanExecuteChanged()
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                SetProperty(_lastName, value)
                ShowAlertCommand.NotifyCanExecuteChanged()
            End Set
        End Property

        Public Property ShowAlertCommand As RelayCommand

    End Class
End Namespace
