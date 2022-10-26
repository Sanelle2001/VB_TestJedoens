Friend Class UserProvider
    Implements IUserProvider

    Private Shared counter As Integer = 0

    Sub New()
        Console.WriteLine("New UserProvider")
    End Sub

    Public Function GetUser() As User Implements IUserProvider.GetUser
        Dim u = New User()
        u.FirstName = "Franz"
        u.LastName = "Nellen"
        counter = counter + 1
        u.No = counter
        Return u
    End Function
End Class