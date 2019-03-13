Public Class frmDraft

    Dim players As Dictionary(Of String, List(Of DraftPlayer))
    Dim playerTeams As New Dictionary(Of Integer, List(Of DraftPlayer))
    Dim draftRounds As Integer
    Dim currentPlayer = 1
    Dim currentRound = 1
    Dim playerCount As Integer

    Function GetPlayers(Optional fileLocation As String = "Draft.txt") As Dictionary(Of String, List(Of DraftPlayer))

        If Not System.IO.File.Exists(fileLocation) Then
            MessageBox.Show("The file " + fileLocation + " was not found")
            Return Nothing
        End If

        Try
            Dim players = New Dictionary(Of String, List(Of DraftPlayer))
            Dim position = String.Empty
            Dim lines = System.IO.File.ReadAllLines(fileLocation)

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
        Catch ex As Exception
            MessageBox.Show("There was an error loading your file")
            Return Nothing
        End Try

        Return Nothing

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        players = GetPlayers(txtFile.Text)

        If players Is Nothing Then
            Exit Sub
        End If

        If IsNumeric(txtDraftRounds.Text) Then
            draftRounds = txtDraftRounds.Text
        Else
            MessageBox.Show("Please enter a number for rounds!")
        End If

        If IsNumeric(txtPlayers.Text) Then
            playerTeams.Clear()
            playerCount = txtPlayers.Text
            For i As Integer = 0 To txtPlayers.Text
                playerTeams.Add(i, New List(Of DraftPlayer))
            Next
        Else
            MessageBox.Show("Please enter a number for players!")
        End If

        For Each position In players.Keys
            For Each player In players(position)
                ListBox1.Items.Add(player)
            Next
        Next

        currentRound = 1
        pStart.Visible = False
        pDraft.Visible = True

        lblCurrentUser.Text = "Current User: Player " + currentPlayer.ToString() + "    Current round " + currentRound.ToString() + " / " + draftRounds.ToString()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        ofdBrowseDraft.Multiselect = False
        ofdBrowseDraft.InitialDirectory = Application.StartupPath()

        If ofdBrowseDraft.ShowDialog() = DialogResult.OK Then
            txtFile.Text = ofdBrowseDraft.FileName
        End If

    End Sub

    Private Sub frmDraft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pDraft.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selectedPlayer = ListBox1.SelectedItem

        If selectedPlayer Is Nothing Then
            MessageBox.Show("Please select a player!")
            Exit Sub
        End If

        If playerTeams(currentPlayer) Is Nothing Then
            playerTeams(currentPlayer) = New List(Of DraftPlayer)
        End If

        playerTeams(currentPlayer).Add(selectedPlayer)

        ListBox1.Items.Remove(selectedPlayer)
        ListBox1.ClearSelected()

        currentPlayer += 1

        If currentPlayer > playerCount Then
            currentPlayer = 1
            currentRound += 1
        End If

        If currentRound > draftRounds Then
            calculateWinner()
            pStart.Visible = True
            pDraft.Visible = False
        End If

        lblCurrentUser.Text = "Current User: Player " + currentPlayer.ToString() + "    Current round " + currentRound.ToString() + " / " + draftRounds.ToString()
    End Sub

    Public Sub calculateWinner()

        Dim topPlayer As Integer = 0
        Dim smallestScore As Integer = -1

        For i As Integer = 1 To playerCount
            Dim localScore = 0

            For Each player As DraftPlayer In playerTeams(i)
                localScore += player.PositionRank
            Next

            If smallestScore = -1 Then
                smallestScore = localScore
                topPlayer = i
            ElseIf localScore < smallestScore Then
                smallestScore = localScore
                topPlayer = i
            End If
        Next

        MessageBox.Show("The player that will most likly win this season is Player " + topPlayer.ToString())

    End Sub
End Class
