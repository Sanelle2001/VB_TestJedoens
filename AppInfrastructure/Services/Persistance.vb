Imports UnitTestDemo.AppDomain.Models

Namespace Services
    Friend Class Persistance
        Implements IPersistance

        Sub New()
            Console.WriteLine("Persistance created.")
        End Sub

        Public Sub BeginTransaction() Implements IPersistance.BeginTransaction
            Console.WriteLine("Start Transaktion")
        End Sub

        Public Async Function GetAllUsers() As Task(Of IEnumerable(Of User)) Implements IPersistance.GetAllUsers
            Await Task.Delay(1000) 'Ist eine weit weit entfernte Datenbank ;-)
            Return New List(Of User) From {
            New User() With {.FirstName = "Franz", .LastName = "Nellen", .BirthDate = New Date(1973, 5, 11)},
            New User() With {.FirstName = "Hans", .LastName = "Glück", .BirthDate = New Date(1950, 8, 7)},
            New User() With {.FirstName = "Karin", .LastName = "Musterfrau", .BirthDate = New Date(1980, 2, 18)},
            New User() With {.FirstName = "Lena", .LastName = "Krawutke", .BirthDate = New Date(2015, 5, 11)},
            New User() With {.FirstName = "Erik", .LastName = "Kranz", .BirthDate = New Date(2015, 5, 11)},
            New User() With {.FirstName = "Kevin", .LastName = "Franzen", .BirthDate = New Date(2015, 5, 11)}
            }
        End Function

        Public Function EndTransaction() As Boolean Implements IPersistance.EndTransaction
            Console.WriteLine("Finalize Transaction")
            Return True
        End Function
    End Class
End Namespace
