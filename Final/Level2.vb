Imports System      'Imports base components that work with system level components.
Imports System.IO 'Imports base components that work with system input/output.

Public Class Level2
    ' dims variables need throughout this class
    Public score As Integer = 0
    Public lives As Integer = 3
    Dim movement As Integer = 0
    Dim enemymovement As Integer = 20
    Dim hitleft As Boolean = False
    Dim hitright As Boolean = False
    Dim pandahp As Integer = 5000

    Private Sub Level1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loads character image
        pbp1.BackgroundImage = Char_Select.pbp1.BackgroundImage
        'starts the move enemy timer
        tmrstartmove.Enabled = True
        'hides the boss' hp bar
        pgrpandahpdisplay.Visible = False
    End Sub

    Private Sub tmrmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrmove.Tick
        'diaplys score and number of lives
        lblscore.Text = "Score : " & score
        lbllives.Text = "Lives : " & lives
        'checks boundaries and moves character when available
        If pbp1.Left <= 10 Then
            pbp1.Left = 11
            movement = 0
        ElseIf pbp1.Left >= 901 Then
            pbp1.Left = 900
            movement = 0
        End If

        If pbp1.Left >= 10 And pbp1.Left <= 901 Then
            pbp1.Left = pbp1.Left + movement
        End If

    End Sub

    Private Sub Level1_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'gets user input to move and shoot
        Select Case e.KeyCode
            Case Keys.A
                movement = -20
            Case Keys.D
                movement = 20
            Case Keys.Left
                movement = -20
            Case Keys.Right
                movement = 20
            Case Keys.Space
                tmrshoot.Enabled = True
                tmrsnowballmove.Enabled = False

            Case Keys.Escape
                End

        End Select
    End Sub

    Private Sub tmrenemy_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrenemy.Tick
        'moves the enemies down and in the opposite direction if they hit the wall
        If pbenemy1.Left < 10 Then
            hitleft = True
            hitright = False
            pbenemy1.Top = pbenemy1.Top + 50
            pbenemy2.Top = pbenemy2.Top + 50
            pbenemy3.Top = pbenemy3.Top + 50
            pbenemy4.Top = pbenemy4.Top + 50
            pbenemy5.Top = pbenemy5.Top + 50
            pbenemy6.Top = pbenemy6.Top + 50
            pbenemy7.Top = pbenemy7.Top + 50
            pbenemy8.Top = pbenemy8.Top + 50
            pbenemy9.Top = pbenemy9.Top + 50
            pbenemy10.Top = pbenemy10.Top + 50
            pbenemy11.Top = pbenemy11.Top + 50
            pbenemy12.Top = pbenemy12.Top + 50
            pbenemy13.Top = pbenemy13.Top + 50
            pbenemy14.Top = pbenemy14.Top + 50
            pbenemy15.Top = pbenemy15.Top + 50
            pbenemy16.Top = pbenemy16.Top + 50
            pbenemy17.Top = pbenemy17.Top + 50
            pbenemy18.Top = pbenemy18.Top + 50
            pbenemy19.Top = pbenemy19.Top + 50
            pbenemy20.Top = pbenemy20.Top + 50
            tmrstartmove.Enabled = False
        ElseIf pbenemy10.Right > 1000 Then
            hitright = True
            hitleft = False
            pbenemy1.Top = pbenemy1.Top + 50
            pbenemy2.Top = pbenemy2.Top + 50
            pbenemy3.Top = pbenemy3.Top + 50
            pbenemy4.Top = pbenemy4.Top + 50
            pbenemy5.Top = pbenemy5.Top + 50
            pbenemy6.Top = pbenemy6.Top + 50
            pbenemy7.Top = pbenemy7.Top + 50
            pbenemy8.Top = pbenemy8.Top + 50
            pbenemy9.Top = pbenemy9.Top + 50
            pbenemy10.Top = pbenemy10.Top + 50
            pbenemy11.Top = pbenemy11.Top + 50
            pbenemy12.Top = pbenemy12.Top + 50
            pbenemy13.Top = pbenemy13.Top + 50
            pbenemy14.Top = pbenemy14.Top + 50
            pbenemy15.Top = pbenemy15.Top + 50
            pbenemy16.Top = pbenemy16.Top + 50
            pbenemy17.Top = pbenemy17.Top + 50
            pbenemy18.Top = pbenemy18.Top + 50
            pbenemy19.Top = pbenemy19.Top + 50
            pbenemy20.Top = pbenemy20.Top + 50
            tmrstartmove.Enabled = False
        End If
        If hitleft = True Then
            pbenemy1.Left = pbenemy1.Left + enemymovement
            pbenemy2.Left = pbenemy2.Left + enemymovement
            pbenemy3.Left = pbenemy3.Left + enemymovement
            pbenemy4.Left = pbenemy4.Left + enemymovement
            pbenemy5.Left = pbenemy5.Left + enemymovement
            pbenemy6.Left = pbenemy6.Left + enemymovement
            pbenemy7.Left = pbenemy7.Left + enemymovement
            pbenemy8.Left = pbenemy8.Left + enemymovement
            pbenemy9.Left = pbenemy9.Left + enemymovement
            pbenemy10.Left = pbenemy10.Left + enemymovement
            pbenemy11.Left = pbenemy11.Left + enemymovement
            pbenemy12.Left = pbenemy12.Left + enemymovement
            pbenemy13.Left = pbenemy13.Left + enemymovement
            pbenemy14.Left = pbenemy14.Left + enemymovement
            pbenemy15.Left = pbenemy15.Left + enemymovement
            pbenemy16.Left = pbenemy16.Left + enemymovement
            pbenemy17.Left = pbenemy17.Left + enemymovement
            pbenemy18.Left = pbenemy18.Left + enemymovement
            pbenemy19.Left = pbenemy19.Left + enemymovement
            pbenemy20.Left = pbenemy20.Left + enemymovement
        End If
        If hitright = True Then
            pbenemy1.Left = pbenemy1.Left - enemymovement
            pbenemy2.Left = pbenemy2.Left - enemymovement
            pbenemy3.Left = pbenemy3.Left - enemymovement
            pbenemy4.Left = pbenemy4.Left - enemymovement
            pbenemy5.Left = pbenemy5.Left - enemymovement
            pbenemy6.Left = pbenemy6.Left - enemymovement
            pbenemy7.Left = pbenemy7.Left - enemymovement
            pbenemy8.Left = pbenemy8.Left - enemymovement
            pbenemy9.Left = pbenemy9.Left - enemymovement
            pbenemy10.Left = pbenemy10.Left - enemymovement
            pbenemy11.Left = pbenemy11.Left - enemymovement
            pbenemy12.Left = pbenemy12.Left - enemymovement
            pbenemy13.Left = pbenemy13.Left - enemymovement
            pbenemy14.Left = pbenemy14.Left - enemymovement
            pbenemy15.Left = pbenemy15.Left - enemymovement
            pbenemy16.Left = pbenemy16.Left - enemymovement
            pbenemy17.Left = pbenemy17.Left - enemymovement
            pbenemy18.Left = pbenemy18.Left - enemymovement
            pbenemy19.Left = pbenemy19.Left - enemymovement
            pbenemy20.Left = pbenemy20.Left - enemymovement
        End If

    End Sub

    Private Sub tmrstartmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrstartmove.Tick
        'starts moving the enemies
        pbenemy1.Left = pbenemy1.Left - enemymovement
        pbenemy2.Left = pbenemy2.Left - enemymovement
        pbenemy3.Left = pbenemy3.Left - enemymovement
        pbenemy4.Left = pbenemy4.Left - enemymovement
        pbenemy5.Left = pbenemy5.Left - enemymovement
        pbenemy6.Left = pbenemy6.Left - enemymovement
        pbenemy7.Left = pbenemy7.Left - enemymovement
        pbenemy8.Left = pbenemy8.Left - enemymovement
        pbenemy9.Left = pbenemy9.Left - enemymovement
        pbenemy10.Left = pbenemy10.Left - enemymovement
        pbenemy11.Left = pbenemy11.Left - enemymovement
        pbenemy12.Left = pbenemy12.Left - enemymovement
        pbenemy13.Left = pbenemy13.Left - enemymovement
        pbenemy14.Left = pbenemy14.Left - enemymovement
        pbenemy15.Left = pbenemy15.Left - enemymovement
        pbenemy16.Left = pbenemy16.Left - enemymovement
        pbenemy17.Left = pbenemy17.Left - enemymovement
        pbenemy18.Left = pbenemy18.Left - enemymovement
        pbenemy19.Left = pbenemy19.Left - enemymovement
        pbenemy20.Left = pbenemy20.Left - enemymovement
    End Sub

    Private Sub tmrshoot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrshoot.Tick
        'shoots snowball and returns it to your character
        pbsnowball.Top = pbsnowball.Top - 20
        If pbsnowball.Top < 0 Then
            pbsnowball.Top = pbp1.Top - 25
            pbsnowball.Left = pbp1.Left + 27
            tmrshoot.Enabled = False
            tmrsnowballmove.Enabled = True
        End If
        'reduce pandas health if you hit him
        If pbsnowball.Top > pbpanda.Top And pbsnowball.Top < pbpanda.Bottom And pbsnowball.Left > pbpanda.Left And pbsnowball.Left < pbpanda.Right Then
            pandahp = pandahp - 20
            If pgrpandahpdisplay.Value > 0 Then
                pgrpandahpdisplay.Value = pgrpandahpdisplay.Value - 20
            ElseIf pgrpandahpdisplay.Value <= 0 Then
                pgrpandahpdisplay.Value = 0
            End If
            If pandahp <= 0 Then
                score = score + 10000
                Panda_Dead.Show()
                Me.Hide()
            End If
        End If
        'hides enemies after thay are hit
        If pbsnowball.Top > pbenemy1.Top And pbsnowball.Top < pbenemy1.Bottom And pbsnowball.Left > pbenemy1.Left And pbsnowball.Left < pbenemy1.Right Then
            pbenemy1.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy2.Top And pbsnowball.Top < pbenemy2.Bottom And pbsnowball.Left > pbenemy2.Left And pbsnowball.Left < pbenemy2.Right Then
            pbenemy2.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy3.Top And pbsnowball.Top < pbenemy3.Bottom And pbsnowball.Left > pbenemy3.Left And pbsnowball.Left < pbenemy3.Right Then
            pbenemy3.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy4.Top And pbsnowball.Top < pbenemy4.Bottom And pbsnowball.Left > pbenemy4.Left And pbsnowball.Left < pbenemy4.Right Then
            pbenemy4.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy5.Top And pbsnowball.Top < pbenemy5.Bottom And pbsnowball.Left > pbenemy5.Left And pbsnowball.Left < pbenemy5.Right Then
            pbenemy5.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy6.Top And pbsnowball.Top < pbenemy6.Bottom And pbsnowball.Left > pbenemy6.Left And pbsnowball.Left < pbenemy6.Right Then
            pbenemy6.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy7.Top And pbsnowball.Top < pbenemy7.Bottom And pbsnowball.Left > pbenemy7.Left And pbsnowball.Left < pbenemy7.Right Then
            pbenemy7.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy8.Top And pbsnowball.Top < pbenemy8.Bottom And pbsnowball.Left > pbenemy8.Left And pbsnowball.Left < pbenemy8.Right Then
            pbenemy8.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy9.Top And pbsnowball.Top < pbenemy9.Bottom And pbsnowball.Left > pbenemy9.Left And pbsnowball.Left < pbenemy9.Right Then
            pbenemy9.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy10.Top And pbsnowball.Top < pbenemy10.Bottom And pbsnowball.Left > pbenemy10.Left And pbsnowball.Left < pbenemy10.Right Then
            pbenemy10.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy11.Top And pbsnowball.Top < pbenemy11.Bottom And pbsnowball.Left > pbenemy11.Left And pbsnowball.Left < pbenemy11.Right Then
            pbenemy11.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy12.Top And pbsnowball.Top < pbenemy12.Bottom And pbsnowball.Left > pbenemy12.Left And pbsnowball.Left < pbenemy12.Right Then
            pbenemy12.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy13.Top And pbsnowball.Top < pbenemy13.Bottom And pbsnowball.Left > pbenemy13.Left And pbsnowball.Left < pbenemy13.Right Then
            pbenemy13.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy14.Top And pbsnowball.Top < pbenemy14.Bottom And pbsnowball.Left > pbenemy14.Left And pbsnowball.Left < pbenemy14.Right Then
            pbenemy14.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy15.Top And pbsnowball.Top < pbenemy15.Bottom And pbsnowball.Left > pbenemy15.Left And pbsnowball.Left < pbenemy15.Right Then
            pbenemy15.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy16.Top And pbsnowball.Top < pbenemy16.Bottom And pbsnowball.Left > pbenemy16.Left And pbsnowball.Left < pbenemy16.Right Then
            pbenemy16.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy17.Top And pbsnowball.Top < pbenemy17.Bottom And pbsnowball.Left > pbenemy17.Left And pbsnowball.Left < pbenemy17.Right Then
            pbenemy17.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy18.Top And pbsnowball.Top < pbenemy18.Bottom And pbsnowball.Left > pbenemy18.Left And pbsnowball.Left < pbenemy18.Right Then
            pbenemy18.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy19.Top And pbsnowball.Top < pbenemy19.Bottom And pbsnowball.Left > pbenemy19.Left And pbsnowball.Left < pbenemy19.Right Then
            pbenemy19.Visible = False
            score = score + 100
        End If
        If pbsnowball.Top > pbenemy20.Top And pbsnowball.Top < pbenemy20.Bottom And pbsnowball.Left > pbenemy20.Left And pbsnowball.Left < pbenemy20.Right Then
            pbenemy20.Visible = False
            score = score + 100
        End If

    End Sub

    Private Sub tmrsnowballmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrsnowballmove.Tick
        'makes snowball move with your character
        pbsnowball.Top = pbp1.Top - 21
        pbsnowball.Left = pbp1.Left + 27
    End Sub


    Private Sub tmrloselife_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloselife.Tick
        'checks to see if the enemies made it to you and takes away a life
        If pbenemy11.Bottom > pbp1.Top Then
            lives = lives - 1
            score = score - 5000
            reload()
        End If
    End Sub

    Private Sub reload()
        'reloads the level
        Controls.Clear()
        InitializeComponent()
        Level1_load(Me, Nothing)
    End Sub

    Private Sub tmrboss_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrboss.Tick
        'checks to see if you defeated all the enemiesa nad shows the boss if you did
        If pbenemy1.Visible = False And pbenemy2.Visible = False And pbenemy3.Visible = False And pbenemy4.Visible = False And pbenemy5.Visible = False And pbenemy6.Visible = False And pbenemy7.Visible = False And pbenemy8.Visible = False And pbenemy9.Visible = False And pbenemy10.Visible = False And pbenemy11.Visible = False And pbenemy12.Visible = False And pbenemy13.Visible = False And pbenemy14.Visible = False And pbenemy15.Visible = False And pbenemy16.Visible = False And pbenemy17.Visible = False And pbenemy18.Visible = False And pbenemy19.Visible = False And pbenemy20.Visible = False Then
            tmrloselife.Enabled = False
            tmrbossfight.Enabled = True
            tmrboss.Enabled = False
            pgrpandahpdisplay.Visible = True
        End If
    End Sub

    Private Sub tmrbossfight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbossfight.Tick
        'makes boss move back and forth
        tmrbossattackrecharge.Enabled = True

        If pbpanda.Left < 10 Then
            hitleft = True
            hitright = False
        ElseIf pbpanda.Right > 1000 Then
            hitleft = False
            hitright = True
        End If

        If hitleft = True Then
            pbpanda.Left = pbpanda.Left + 20
        ElseIf hitright = True Then
            pbpanda.Left = pbpanda.Left - 20
        End If
    End Sub

    Private Sub tmrbossattack_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbossattack.Tick
        'boss attacks by moving down then returning to original movement pattern
        hitleft = False
        hitright = False

        If pbpanda.Bottom < Me.Bottom Then
            pbpanda.Top = pbpanda.Top + 30
        ElseIf pbpanda.Bottom > Me.Bottom Then
            pbpanda.Top = 25
            hitright = True
            tmrbossattack.Enabled = False
            tmrbossattackrecharge.Enabled = True
        End If
        If pbpanda.Bottom > pbp1.Top And ((pbpanda.Left > pbp1.Left And pbpanda.Left < pbp1.Right) Or (pbpanda.Right > pbp1.Left And pbpanda.Right < pbp1.Right)) Then
            lives = lives - 1
            pbpanda.Top = 25
            hitright = True
            tmrbossattack.Enabled = False
            tmrbossattackrecharge.Enabled = True
        End If
    End Sub

    Private Sub tmrbossattackrecharge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbossattackrecharge.Tick
        'gets the boss to attack periodically
        tmrbossattack.Enabled = True
        tmrbossattackrecharge.Enabled = False
    End Sub

    Private Sub tmrlives_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrlives.Tick
        'checks tro see if you have 0 lkives
        If lives = 0 Then
            tmrlives.Enabled = False
            tmrbossattack.Enabled = False
            tmrbossattackrecharge.Enabled = False
            tmrboss.Enabled = False
            tmrbossfight.Enabled = False
            ' Create an instance of StreamWriter to write text to a file.
            Using sw As StreamWriter = New StreamWriter("Highscores.txt", FileMode.Append)
                ' Add some text to the file.
                sw.WriteLine(InputBox("Your Initials ' 3 characters '", "Game Over !"))
                sw.WriteLine(score)
                MsgBox("Initials and score added to highscores list. Thanks for playing. ^_^")
                sw.Close()
                End
            End Using
        End If
    End Sub
End Class