Imports UnitTestDemo.AppDomain.Models

Friend Interface IPersistance
    ReadOnly Property TransActionStarted As Boolean
    Sub BeginTransaction()
    Function GetAllUsers() As Task(Of IEnumerable(Of User))
    Function EndTransaction() As Boolean
End Interface
