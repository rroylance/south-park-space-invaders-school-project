Public Class Register

    Public auser(9) As user
    Dim intcount As Integer
    Public intmaxusers As Integer
    Public intwhoisloggedin As Integer

    Private Sub btnregister_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        If intcount >= intmaxusers Then
            MsgBox("You reached the max users")
            End
        Else
            auser(intcount).uname = txtuser.Text
            auser(intcount).password = txtpassword.Text
            txtuser.Text = Nothing
            txtpassword.Text = Nothing
            intcount = intcount + 1
            MsgBox("You may now login with this username and password.")
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 9
            auser(i) = New user
        Next
        intcount = 0
        intmaxusers = 10
        intwhoisloggedin = 0
    End Sub

End Class

Public Class user
    Public uname As String
    Public password As String

    Property username() As String
        Get
            Return uname
        End Get
        Set(ByVal value As String)
            uname = value
        End Set
    End Property

    Property pass() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

End Class

