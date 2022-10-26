Public Interface IUnitOfWork
    Inherits IDisposable
    Function GetRepository(Of T)() As T
    Function Complete() As Boolean
End Interface
