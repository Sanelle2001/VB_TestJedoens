Imports UnitTestDemo.AppDomain.Interfaces

Namespace AppKernel

    Public Class AdvertisingUseCase
        Implements IAdvertisingUseCase

        Private ReadOnly _userRepository As IUserRepository
        Private ReadOnly _advertiser As IBarkToTheWoodAdvertiserService

        Public Sub New(userRepository As IUserRepository, advertiser As IBarkToTheWoodAdvertiserService)
            If userRepository Is Nothing Then
                Throw New ArgumentNullException(NameOf(userRepository))
            End If

            If advertiser Is Nothing Then
                Throw New ArgumentNullException(NameOf(advertiser))
            End If

            _userRepository = userRepository
            _advertiser = advertiser
        End Sub

        Public Async Function SendAdvertisingToUserByNamePart(namePart As String) As Task Implements IAdvertisingUseCase.SendAdvertisingToUserByNamePart
            For Each user In Await _userRepository.GetUsersContainsText(namePart, True)
                _advertiser.Advertise(user)
            Next
        End Function

    End Class
End Namespace
