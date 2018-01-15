Public Class Char_Select
    'allows for use of .wav files
    Dim Sound As New System.Media.SoundPlayer()

    Private Sub lblbutters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbutters.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Yellow
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\butters.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\oh jesus.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub
    Private Sub lblstan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstan.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Yellow
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\stan.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\get me out.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub
    Private Sub lblkyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblkyle.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Yellow
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\kyle.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\freaking me out.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub

    Private Sub lblcartman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcartman.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Yellow
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\cartman.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\beefcake.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub


    Private Sub Char_Select_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'makes the are you sure question not seen
        lblsure.Visible = False
        lblyes.Visible = False
        lblno.Visible = False
    End Sub

    Private Sub pbbutters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbutters.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Yellow
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\butters.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\oh jesus.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub

    Private Sub pbkyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbkyle.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Yellow
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\kyle.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\freaking me out.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True
        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub

    Private Sub pbcartman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcartman.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Yellow
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\cartman.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\beefcake.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub

    Private Sub pbstan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbstan.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Yellow
        lblbutters.BackColor = Color.Transparent
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\stan.gif")

        Sound.SoundLocation = Application.StartupPath & "\Sounds\get me out.wav"
        Sound.Load()
        Sound.Play()

        lblsure.Visible = True
        lblyes.Visible = True
        lblno.Visible = True

        lblbutters.Enabled = False
        pbbutters.Enabled = False
        lblcartman.Enabled = False
        pbcartman.Enabled = False
        lblstan.Enabled = False
        pbstan.Enabled = False
        lblkyle.Enabled = False
        pbkyle.Enabled = False
    End Sub

    Private Sub lblno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblno.Click
        'highlights you selected charcter, asks if you are sure and plays an audio clip.
        lblcartman.BackColor = Color.Transparent
        lblkyle.BackColor = Color.Transparent
        lblstan.BackColor = Color.Transparent
        lblbutters.BackColor = Color.Transparent

        lblsure.Visible = False
        lblyes.Visible = False
        lblno.Visible = False

        lblbutters.Enabled = True
        pbbutters.Enabled = True
        lblcartman.Enabled = True
        pbcartman.Enabled = True
        lblstan.Enabled = True
        pbstan.Enabled = True
        lblkyle.Enabled = True
        pbkyle.Enabled = True
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'shows main screen
        frmStart.Show()
        Me.Hide()
    End Sub

    Private Sub lblyes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblyes.Click
        'loads level1
        Level1.Show()
        Me.Hide()
    End Sub
End Class