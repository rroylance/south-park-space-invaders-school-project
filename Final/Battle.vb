Public Class Battle
    'declares variables need thoughout this class
    Dim p1ammo As Integer = 10
    Dim p2ammo As Integer = 10
    Dim p1move As Integer = 0
    Dim p2move As Integer = 0

    Private Sub Battle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loads the player images
        pbp1.BackgroundImage = Battle_Char_Select.pbp1.BackgroundImage
        pbp2.BackgroundImage = Battle_Char_Select.pbp2.BackgroundImage
    End Sub

    Private Sub tmrmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrmove.Tick
        'displays ammo 
        lblp1ammo.Text = "Ammo : " & p1ammo
        lblp2ammo.Text = "Ammo : " & p2ammo
        'checks boundaries and allows movement when available
        If pbp1.Top <= 50 Then
            pbp1.Top = 51
            p1move = 0
        ElseIf pbp1.Top >= 640 Then
            pbp1.Top = 639
            p1move = 0
        ElseIf pbp2.Top <= 50 Then
            pbp2.Top = 51
            p2move = 0
        ElseIf pbp2.Top >= 640 Then
            pbp2.Top = 639
            p2move = 0
        End If

        If pbp1.Top >= 50 And pbp1.Top <= 640 Then
            pbp1.Top = pbp1.Top + p1move
        End If
        If pbp2.Top >= 50 And pbp2.Top <= 640 Then
            pbp2.Top = pbp2.Top + p2move
        End If
    End Sub

    Private Sub Battle_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'gets user input to move character/throw snowball
        Select Case e.KeyCode
            Case Keys.W
                p1move = -20
            Case Keys.S
                p1move = 20
            Case Keys.Space
                If p1ammo <= 0 Then
                    p1ammo = 0
                    tmrp1ammo.Enabled = True
                ElseIf tmrp1shoot.Enabled = False Then
                    p1ammo = p1ammo - 1
                    tmrp1shoot.Enabled = True
                    tmrp1snowballmove.Enabled = False
                End If

            Case Keys.Escape
                End

        End Select

        'gets user input to move character/throw snowball
        Select Case e.KeyCode
            Case Keys.Up
                p2move = -20
            Case Keys.Down
                p2move = 20
            Case Keys.NumPad0
                If p2ammo <= 0 Then
                    p2ammo = 0
                    tmrp2ammo.Enabled = True
                ElseIf tmrp2shoot.Enabled = False Then
                    p2ammo = p2ammo - 1
                    tmrp2shoot.Enabled = True
                    tmrp2snowballmove.Enabled = False
                End If
        End Select
    End Sub

    Private Sub tmrp1ammo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp1ammo.Tick
        'resets ammo
        p1ammo = 10
        tmrp1ammo.Enabled = False
    End Sub

    Private Sub tmrp2ammo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp2ammo.Tick
        'resets ammo
        p2ammo = 10
        tmrp2ammo.Enabled = False
    End Sub

    Private Sub tmrp1snowballmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp1snowballmove.Tick
        'keeps the snowball with your player as you move around
        pbsnowball.Top = pbp1.Top + 21
        pbsnowball.Left = pbp1.Right + 10
    End Sub

    Private Sub tmrp1shoot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp1shoot.Tick
        'shoots the snowball across the screen at the other player
        pbsnowball.Left = pbsnowball.Left + 20
        'resets the snowball back to your character
        If pbsnowball.Left > Me.Right Then
            pbsnowball.Top = pbp1.Top + 21
            pbsnowball.Left = pbp1.Right + 10
            tmrp1shoot.Enabled = False
            tmrp1snowballmove.Enabled = True
        End If
        'checks if you hit you enemy
        If pbsnowball.Top > pbp2.Top And pbsnowball.Top < pbp2.Bottom And pbsnowball.Left > pbp2.Left And pbsnowball.Left < pbp2.Right Then
            pbp2.Visible = False
            tmrp2shoot.Enabled = False
            tmrp1shoot.Enabled = False
            MsgBox("P1 Wins !!!!!!!, Thanks For Playing ^_^")
            End
        End If

    End Sub

    Private Sub tmrp2shoot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp2shoot.Tick
        'shoots the snowball across the screen at the other player
        pbsnowball2.Left = pbsnowball2.Left - 20
        'resets the snowball back to your character
        If pbsnowball2.Left < 0 Then
            pbsnowball.Top = pbp1.Top + 21
            pbsnowball.Left = pbp1.Right - 30
            tmrp2shoot.Enabled = False
            tmrp2snowballmove.Enabled = True
        End If
        'checks if you hit you enemy
        If pbsnowball2.Top > pbp1.Top And pbsnowball2.Top < pbp1.Bottom And pbsnowball2.Left > pbp1.Left And pbsnowball2.Left < pbp1.Right Then
            pbp1.Visible = False
            tmrp2shoot.Enabled = False
            tmrp1shoot.Enabled = False
            MsgBox("P2 Wins !!!!!!!, Thanks For Playing ^_^")
            End
        End If

    End Sub

    Private Sub tmrp2snowballmove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrp2snowballmove.Tick
        'keeps the snowball with your player as you move around
        pbsnowball2.Top = pbp2.Top + 21
        pbsnowball2.Left = pbp2.Left - 30
    End Sub

End Class
