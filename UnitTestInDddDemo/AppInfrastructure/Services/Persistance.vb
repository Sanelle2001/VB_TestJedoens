Imports UnitTestDemo.AppDomain.Models

Namespace Services
    Friend Class Persistance
        Implements IPersistance, IDisposable

        Private disposedValue As Boolean
        Private Shared _instanciationCount As Integer = 0
        Private ReadOnly _instanceNo As Integer
        Private _transactionStarted As Boolean = False

        Public ReadOnly Property TransActionStarted As Boolean Implements IPersistance.TransActionStarted
            Get
                Return _transactionStarted
            End Get
        End Property

        Sub New()

            _instanciationCount += 1
            _instanceNo = _instanciationCount
            Console.WriteLine($"Persistance {_instanceNo} created.")

        End Sub

        Public Sub BeginTransaction() Implements IPersistance.BeginTransaction
            Console.WriteLine("Start Transaktion")
            _transactionStarted = True
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

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects)
                    Console.WriteLine($"Dispose Persistance {_instanceNo}.")
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                ' TODO: set large fields to null
                disposedValue = True
            End If
        End Sub

        ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
        ' Protected Overrides Sub Finalize()
        '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
