Imports System      'Imports base components that work with system level components.
Imports System.IO 'Imports base components that work with system input/output.

Public Class Panda_Dead
    'allows for use of .wav files
    Dim Sound As New System.Media.SoundPlayer()

    Private Sub Panda_Dead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'plays an audio file
        Sound.SoundLocation = Application.StartupPath & "\Sounds\saaaad panda.wav"
        Sound.Load()
        Sound.Play()
    End Sub

    Private Sub lblcontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcontinue.Click
        'gets you initials and adds it to a highscores list along with your score
        Using sw As StreamWriter = New StreamWriter("Highscores.txt", FileMode.Append)
            ' Add some text to the file.
            sw.Write(InputBox("Your Initials ' 3 characters '", "Initials"))
            sw.WriteLine(Level2.score)
            MsgBox("Initials and score added to highscores list. Thanks for playing. ^_^")
            sw.Close()
            End
        End Using
    End Sub
End Class