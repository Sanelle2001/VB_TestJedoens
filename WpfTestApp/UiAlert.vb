Imports TestViewModelLibrary

Public Class UiAlert
    Implements IUiAlert

    Public Sub Alert(message As String, header As String) Implements IUiAlert.Alert
        MessageBox.Show(message, header)
    End Sub
End Class
