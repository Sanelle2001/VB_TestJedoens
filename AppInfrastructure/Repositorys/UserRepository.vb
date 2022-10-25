Imports UnitTestDemo.AppDomain
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppDomain.Models

Friend Class UserRepository
    Implements IUserRepository

    Dim _userPesistance As IPersistance

    Sub New(userPersistance As IPersistance)
        _userPesistance = userPersistance
    End Sub

    Public Sub Add(value As User) Implements IWriteRepositoryOf(Of User).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Remove(value As User) Implements IWriteRepositoryOf(Of User).Remove
        Throw New NotImplementedException()
    End Sub

    Public Function GetAllUser() As Task(Of IEnumerable(Of User)) Implements IUserRepository.GetAllUser
        Return _userPesistance.GetAllUsers()
    End Function

    Public Async Function GetUsersContainsText(text As String, ignoreCase As Boolean) As Task(Of IEnumerable(Of User)) Implements IUserRepository.GetUsersContainsText
        If ignoreCase Then
            Return (Await _userPesistance.GetAllUsers()).Where(Function(x) x.LastName.ToLower().Contains(text.ToLower()) OrElse x.FirstName.ToLower().Contains(text.ToLower()))
        Else
            Return (Await _userPesistance.GetAllUsers()).Where(Function(x) x.LastName.Contains(text) OrElse x.FirstName.Contains(text))
        End If
    End Function
End Class
