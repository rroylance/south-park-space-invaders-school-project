Imports System      'Imports base components that work with system level components.
Imports System.IO 'Imports base components that work with system input/output.

Public Class Highscores
    'decares variables need throughout this class
    Dim scores(,) As String
    Dim i As Integer = 0
    Dim x As Integer
    Dim y As Integer

    Private Sub btnmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmain.Click
        'shows main screen
        frmStart.Show()
        Me.Hide()
    End Sub

    Private Sub Highscores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create an instance of StreamReader to read from a file.
        Using sr As StreamReader = New StreamReader("Highscores.txt")
            Dim line As String
            ' Read and display the lines from the file until the end
            ' of the file is reached.
            Do
                ReDim Preserve scores(1, i + 1)
                line = sr.ReadLine()
                scores(0, i) = line
                line = sr.ReadLine()
                scores(1, i) = line
                If line = Nothing Then
                    sr.Close()
                Else
                    i = i + 1
                End If
            Loop Until line Is Nothing
        End Using
        'displays scores 
        For x = 0 To i
            lsthigh.Items.Add(scores(0, x) & vbTab & scores(1, x))
        Next

    End Sub
End Class