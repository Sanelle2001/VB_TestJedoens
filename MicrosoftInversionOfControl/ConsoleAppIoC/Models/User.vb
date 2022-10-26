Friend Class User
    Public Property FirstName As String
    Public Property LastName As String
    Public Property No As Integer

    Public Overrides Function ToString() As String
        Return No.ToString() + " " + FirstName + " " + LastName
    End Function
End Class