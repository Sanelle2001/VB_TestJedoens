Imports UnitTestDemo.AppDomain.Models

Friend Interface IPersistance
    Sub BeginTransaction()
    Function GetAllUsers() As Task(Of IEnumerable(Of User))
    Function EndTransaction() As Boolean
End Interface
