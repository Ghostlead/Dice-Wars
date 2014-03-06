Public Class myRemoteClass
    Inherits MarshalByRefObject
    Public Function SetString(sTemp As String) As Boolean
        Try
            Console.WriteLine("This string '{0}' has a length of {1}", sTemp, Len(sTemp))
            Return (sTemp <> "")
        Catch
            Return (False)
        End Try
    End Function
End Class
