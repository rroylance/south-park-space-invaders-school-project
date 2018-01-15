Public Class Login

    Private Sub btnauthorize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnauthorize.Click
        Dim i As Integer
        Dim userfound As Boolean

        userfound = False

        'For i = 0 To register.intmaxusers - 1
        i = 0
        Do
            If Register.auser(i).username = txtuser.Text And Register.auser(i).password = txtpassword.Text Then
                userfound = True
            Else
                i = i + 1
            End If
            'Next
        Loop While userfound = False And i < register.intmaxusers

        If userfound = True Then
            MsgBox("Authorization Complete")
            Me.Hide()
            frmStart.Visible = True
        Else
            MsgBox("Authorization Failed")
        End If
    End Sub

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        Register.Show()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("You MUST register before you can play.")
    End Sub
End Class