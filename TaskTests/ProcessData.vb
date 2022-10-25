Public Class ProcessData
    Private _checkValue As String
    Public Property CheckValue() As String
        Get
            Return _checkValue
        End Get
        Set(ByVal value As String)
            _checkValue = value
        End Set
    End Property
End Class
