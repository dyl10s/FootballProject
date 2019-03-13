Public Class DraftPlayer
    Public Property Name As String
    Public Property Team As String
    Public Property Position As String
    Public Property PositionRank As Integer

    Public Overrides Function ToString() As String
        Return Name & ", " & Team & ", " & Position & " " & PositionRank.ToString()
    End Function

End Class