Imports UnitTestDemo.AppDomain.Models

Namespace Interfaces
    Public Interface IUserRepository
        Inherits IReadRepository(Of User), IWriteRepositoryOf(Of User)
        Function GetUsersContainsText(text As String, ignoreCase As Boolean) As Task(Of IEnumerable(Of User))
    End Interface
End Namespace

