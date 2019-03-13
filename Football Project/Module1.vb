Imports System.IO
Imports System.Text

Module Module1

    Sub Main()

        'Dim sb As StringBuilder = New StringBuilder()
        'For Each line In lines
        '    Dim workingLine = line.Split(vbTab)
        '    If workingLine.Length = 1 Then
        '        ' it is a position
        '        sb.AppendLine(workingLine(0))
        '    ElseIf workingLine.Length = 2 Then
        '        ' it is a Tier 1, etc.
        '        Continue For
        '    Else
        '        Dim separatorIndex = workingLine(2).Trim().LastIndexOf(" ")
        '        Dim name = workingLine(2).Substring(0, separatorIndex)
        '        Dim team = workingLine(2).Substring(separatorIndex + 1)
        '        sb.Append(workingLine(0)).Append(vbTab).Append(name).Append(vbTab).AppendLine(team)
        '    End If
        'Next

        'File.WriteAllText("Draft.txt", sb.ToString())

        Dim players = GetPlayers()

        For Each position In players.Keys
            Console.WriteLine("We have a position of " & position)
            For Each player In players(position)
                Console.WriteLine(vbTab & player.ToString())
            Next
        Next

        Console.ReadLine()

    End Sub

    Function GetPlayers() As Dictionary(Of String, List(Of DraftPlayer))

        Dim players = New Dictionary(Of String, List(Of DraftPlayer))
        Dim position = String.Empty
        Dim lines = System.IO.File.ReadAllLines("Draft.txt")

        For Each line In lines

            Dim parts = line.Split(vbTab)

            If parts.Length = 1 Then
                ' we have a new position
                position = parts(0)
                players(position) = New List(Of DraftPlayer)()
            Else
                ' it must be a player
                Dim positionRank As Integer
                If Not Integer.TryParse(parts(0), positionRank) Then
                    positionRank = Integer.MaxValue
                End If

                Dim player = New DraftPlayer()
                With player
                    .Name = parts(1).Trim()
                    .Team = parts(2).Trim()
                    .Position = position
                    .PositionRank = positionRank
                End With

                players(position).Add(player)
            End If
        Next

        Return players
    End Function

End Module