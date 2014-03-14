Public Class myRemoteClass
    Inherits MarshalByRefObject
    Public Function SetString(sTemp As String) As Boolean
        Try
            Console.WriteLine("player has connected", sTemp, Len(sTemp))
            Return (sTemp <> "")
        Catch
            Return (False)
        End Try
    End Function
End Class
