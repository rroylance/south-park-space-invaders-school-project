Public Class Kenny_Dead
    'allows for use of .wav files
    Dim Sound As New System.Media.SoundPlayer()

    Private Sub Kenny_Dead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'plays an audio clip
        Sound.SoundLocation = Application.StartupPath & "\Sounds\you killed kenny.wav"
        Sound.Load()
        Sound.Play()
    End Sub

    Private Sub lblcontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcontinue.Click
        'starts level 2
        Level2.Show()
        Me.Hide()
    End Sub
End Class