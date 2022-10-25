Imports Moq
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppDomain.Models
Imports UnitTestDemo.AppInfrastructure

<TestClass()> Public Class UserRepositoryTests
    Private userPersistance As Mock(Of IPersistance)
    Private subjectUnderTest As IUserRepository
    Private persistanceTestData As IEnumerable(Of User) = New List(Of User) From {
                                                     {New User With {.FirstName = "Franz", .LastName = "Nellen"}},
                                                     {New User With {.FirstName = "Erik", .LastName = "Franzen"}},
                                                     {New User With {.FirstName = "Franziska", .LastName = "Musterfrau"}},
                                                     {New User With {.FirstName = "Markus", .LastName = "Mustermannfranzin"}},
                                                     {New User With {.FirstName = "Naomi", .LastName = "Nagata"}}
                                                     }

    ''' <summary> 
    ''' Wird vor jedem Test neu ausgeführt
    ''' </summary>
    <TestInitialize> Public Sub Setup()
        userPersistance = New Mock(Of IPersistance)
        subjectUnderTest = New UserRepository(userPersistance.Object)
    End Sub

    <TestMethod()> Public Async Function UserRepository_GetAllUsers_AlleTestdatenKorrektZurückgeben() As Task
        'Arrange
        userPersistance.Setup(Function(x) x.GetAllUsers).ReturnsAsync(persistanceTestData)

        'Act

        Dim data = Await subjectUnderTest.GetAllUser()


        'Assert
        Assert.AreEqual(5, data.Count(), "Die Anzahl zurückgegebener User ist nicht korrekt.")
        Assert.AreEqual("Franz", data.FirstOrDefault()?.FirstName, "Vorname erster User ist falsch.")
        Assert.AreEqual("Nagata", data.LastOrDefault().LastName, "Nachname des letzten Elements ist falsch.")
    End Function

    <TestMethod()> Public Async Function UserRepository_GetUsersContainsText_CaseSensitive_FilterKorrekt() As Task
        'Arrange
        userPersistance.Setup(Function(x) x.GetAllUsers).ReturnsAsync(persistanceTestData)

        'Act
        Dim data = Await subjectUnderTest.GetUsersContainsText("Franz", False)

        'Assert
        Assert.AreEqual(3, data.Count)
        Assert.AreEqual("Franz", data.ElementAt(0).FirstName)
        Assert.AreEqual("Franzen", data.ElementAt(1).LastName)
        Assert.AreEqual("Franziska", data.ElementAt(2).FirstName)
    End Function

    <TestMethod()> Public Async Function UserRepository_GetUsersContainsText_NotCaseSensitive_FilterKorrekt() As Task
        'Arrange
        userPersistance.Setup(Function(x) x.GetAllUsers).ReturnsAsync(persistanceTestData)

        'Act
        Dim data = Await subjectUnderTest.GetUsersContainsText("Franz", True)

        'Assert
        Assert.AreEqual(4, data.Count)
        Assert.AreEqual("Franz", data.ElementAt(0).FirstName)
        Assert.AreEqual("Franzen", data.ElementAt(1).LastName)
        Assert.AreEqual("Franziska", data.ElementAt(2).FirstName)
        Assert.AreEqual("Mustermannfranzin", data.ElementAt(3).LastName)
    End Function

End Class