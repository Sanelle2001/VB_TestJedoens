Imports AppKernel
Imports AppKernel.AppKernel
Imports Moq
Imports UnitTestDemo.AppDomain.Interfaces
Imports UnitTestDemo.AppDomain.Models

<TestClass()> Public Class AdvertisingUseCaseTests

    Private ReadOnly persistanceTestData As IEnumerable(Of User) = New List(Of User) From {
                                                     {New User With {.FirstName = "Franz", .LastName = "Nellen"}},
                                                     {New User With {.FirstName = "Erik", .LastName = "Franzen"}},
                                                     {New User With {.FirstName = "Franziska", .LastName = "Musterfrau"}},
                                                     {New User With {.FirstName = "Markus", .LastName = "Mustermannfranzin"}},
                                                     {New User With {.FirstName = "Naomi", .LastName = "Nagata"}}
                                                     }

    Private _subjectUnderTest As IAdvertisingUseCase
    Private _userRepository As Mock(Of IUserRepository)
    Private _barkToTheWoodAdvertiserService As Mock(Of IBarkToTheWoodAdvertiserService)

    ''' <summary> 
    ''' Wird vor jedem Test neu ausgeführt
    ''' </summary>
    <TestInitialize> Public Sub Setup()
        _userRepository = New Mock(Of IUserRepository)
        _barkToTheWoodAdvertiserService = New Mock(Of IBarkToTheWoodAdvertiserService)
        _subjectUnderTest = New AdvertisingUseCase(_userRepository.Object, _barkToTheWoodAdvertiserService.Object)
    End Sub

    <TestMethod()> Public Async Function AdvertisingUseCase_advertise_was_called_for_every_provided_users() As Task
        'Arrange
        _userRepository.Setup(Function(x) x.GetUsersContainsText(It.IsAny(Of String), It.IsAny(Of Boolean))).ReturnsAsync(persistanceTestData)
        'Act

        Await _subjectUnderTest.SendAdvertisingToUserByNamePart("SpieltHierKeineRolle")

        'Assert
        _barkToTheWoodAdvertiserService.Verify(Sub(x) x.Advertise(It.IsAny(Of User)), Times.Exactly(persistanceTestData.Count()))

    End Function

End Class