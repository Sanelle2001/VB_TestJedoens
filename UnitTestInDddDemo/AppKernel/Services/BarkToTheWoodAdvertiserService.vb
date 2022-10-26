Imports UnitTestDemo.AppDomain.Models

Public Class BarkToTheWoodAdvertiserService
    Implements IBarkToTheWoodAdvertiserService

    Public Sub Advertise(user As User) Implements IBarkToTheWoodAdvertiserService.Advertise
        Console.WriteLine($"Hello {user.FirstName} {user.LastName }, here is your special offer.")
    End Sub
End Class
