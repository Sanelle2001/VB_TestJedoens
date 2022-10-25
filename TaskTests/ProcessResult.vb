Public Class ProcessResult
    Private Shared _count As Integer = 0

    Public Sub New()
        _count += 1
        Index = _count
    End Sub

    Public Sub New(name As String)
        _count += 1
        Index = _count
        Me.Name = name
    End Sub

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _index As Integer
    Public Property Index() As Integer
        Get
            Return _index
        End Get
        Private Set(ByVal value As Integer)
            _index = value
        End Set
    End Property
End Class
