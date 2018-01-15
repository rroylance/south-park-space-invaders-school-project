Public Class Battle_Char_Select

    Private Sub lblstan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstan.Click
        'shows the selected character and check
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\stan.gif")
        pbp1ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Battle_Char_Select_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'makes the checks not seen
        pbp1ready.Visible = False
        pbp2ready.Visible = False
    End Sub

    Private Sub lblstan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstan2.Click
        'shows the selected character and check

        pbp2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\stan.gif")
        pbp2ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblcartman2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcartman2.Click
        'shows the selected character and check
        pbp2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\cartman.gif")
        pbp2ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblkyle2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblkyle2.Click
        'shows the selected character and check
        pbp2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\kyle.gif")
        pbp2ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblbutters2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbutters2.Click
        'shows the selected character and check
        pbp2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\butters.gif")
        pbp2ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblbutters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbutters.Click
        'shows the selected character and check
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\butters.gif")
        pbp1ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblkyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblkyle.Click
        'shows the selected character and check
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\kyle.gif")
        pbp1ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblcartman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcartman.Click
        'shows the selected character and check
        pbp1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Pictures\cartman.gif")
        pbp1ready.Visible = True
        If pbp1ready.Visible = True And pbp2ready.Visible = True Then
            Battle.Show()
            Me.Hide()
        End If
    End Sub
End Class