<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kenny_Dead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kenny_Dead))
        Me.lblcontinue = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblcontinue
        '
        Me.lblcontinue.BackColor = System.Drawing.Color.Transparent
        Me.lblcontinue.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontinue.ForeColor = System.Drawing.Color.Red
        Me.lblcontinue.Location = New System.Drawing.Point(580, 667)
        Me.lblcontinue.Name = "lblcontinue"
        Me.lblcontinue.Size = New System.Drawing.Size(394, 55)
        Me.lblcontinue.TabIndex = 0
        Me.lblcontinue.Text = "Continue ..."
        Me.lblcontinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Kenny_Dead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 731)
        Me.Controls.Add(Me.lblcontinue)
        Me.DoubleBuffered = True
        Me.Name = "Kenny_Dead"
        Me.Text = "Kenny_Dead"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblcontinue As System.Windows.Forms.Label
End Class
