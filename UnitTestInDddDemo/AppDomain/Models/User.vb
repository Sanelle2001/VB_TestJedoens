Namespace Models
    Public Class User
        Private _firstName As String
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                _firstName = value
            End Set
        End Property

        Private _lastName As String
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                _lastName = value
            End Set
        End Property

        Private _birthDate As Date
        Public Property BirthDate() As Date
            Get
                Return _birthDate
            End Get
            Set(ByVal value As Date)
                _birthDate = value
            End Set
        End Property
    End Class
End Namespace