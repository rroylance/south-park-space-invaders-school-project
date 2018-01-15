Public Class frmStart
    'allows for use of .wav files
    Dim Sound As New System.Media.SoundPlayer()

    Private Sub lblquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblquit.Click
        'closes the game
        End
    End Sub

    Private Sub lblstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstart.Click
        'shows the character selection screen
        Char_Select.Show()
        Me.Hide()
    End Sub

    Private Sub lblhighscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhighscore.Click
        'shows the highscores screen
        Highscores.Show()
        Me.Hide()
    End Sub

    Private Sub lblcredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcredits.Click
        'shows about info
        MsgBox("Designed & Developed by : Richard Roylance" & vbNewLine & vbNewLine & "Sounds courtesy of : www.southparkstudios.com" & vbNewLine & vbNewLine & "Optimized for resolution : 1280 x 1024" & vbNewLine & vbNewLine & "Controls : P1 -> A,D,Space / P2 -> Left Arrow,Right Arrow, NumPad 0 / In sigle player -> A,D,Space,Left Arrow,Right Arrow")
    End Sub

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'plays audio file
        Sound.SoundLocation = Application.StartupPath & "\Sounds\sp theme.wav"
        Sound.Load()
        Sound.Play()
        MsgBox("During play (Single or Multi, press ESC to quit.)")
    End Sub

    Private Sub lblmulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmulti.Click
        'shows the battle character selection screen
        Sound.Stop()
        Battle_Char_Select.Show()
        Me.Hide()
    End Sub
End Class
