<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Highscores))
        Me.btnmain = New System.Windows.Forms.Button
        Me.lsthigh = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnmain
        '
        Me.btnmain.BackColor = System.Drawing.Color.Silver
        Me.btnmain.Location = New System.Drawing.Point(149, 763)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(358, 23)
        Me.btnmain.TabIndex = 7
        Me.btnmain.Text = "<<<<< Back to Main >>>>>"
        Me.btnmain.UseVisualStyleBackColor = False
        '
        'lsthigh
        '
        Me.lsthigh.BackColor = System.Drawing.Color.Black
        Me.lsthigh.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsthigh.ForeColor = System.Drawing.Color.Gold
        Me.lsthigh.FormattingEnabled = True
        Me.lsthigh.ItemHeight = 22
        Me.lsthigh.Location = New System.Drawing.Point(149, 455)
        Me.lsthigh.Name = "lsthigh"
        Me.lsthigh.Size = New System.Drawing.Size(358, 290)
        Me.lsthigh.TabIndex = 8
        '
        'Highscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 878)
        Me.Controls.Add(Me.lsthigh)
        Me.Controls.Add(Me.btnmain)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Highscores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Highscores"
        Me.TransparencyKey = System.Drawing.Color.SlateGray
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnmain As System.Windows.Forms.Button
    Friend WithEvents lsthigh As System.Windows.Forms.ListBox
End Class
