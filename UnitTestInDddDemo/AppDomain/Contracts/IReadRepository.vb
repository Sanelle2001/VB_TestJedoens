
Public Interface IReadRepository(Of T)
    Function GetAllUser() As Task(Of IEnumerable(Of T))
End Interface
