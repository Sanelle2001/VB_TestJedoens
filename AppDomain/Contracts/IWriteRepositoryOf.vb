Public Interface IWriteRepositoryOf(Of T)
    Inherits IWriteRepository
    Sub Add(value As T)
    Sub Remove(value As T)
End Interface
