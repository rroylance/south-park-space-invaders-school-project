<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battle
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Battle))
        Me.pbp1 = New System.Windows.Forms.PictureBox
        Me.pbp2 = New System.Windows.Forms.PictureBox
        Me.lblp2 = New System.Windows.Forms.Label
        Me.lblp1 = New System.Windows.Forms.Label
        Me.lblp2ammo = New System.Windows.Forms.Label
        Me.lblp1ammo = New System.Windows.Forms.Label
        Me.tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrp1ammo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrp2ammo = New System.Windows.Forms.Timer(Me.components)
        Me.pbsnowball = New System.Windows.Forms.PictureBox
        Me.pbsnowball2 = New System.Windows.Forms.PictureBox
        Me.tmrp1snowballmove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrp1shoot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrp2shoot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrp2snowballmove = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsnowball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsnowball2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbp1
        '
        Me.pbp1.BackColor = System.Drawing.Color.Transparent
        Me.pbp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbp1.Location = New System.Drawing.Point(12, 345)
        Me.pbp1.Name = "pbp1"
        Me.pbp1.Size = New System.Drawing.Size(72, 78)
        Me.pbp1.TabIndex = 4
        Me.pbp1.TabStop = False
        '
        'pbp2
        '
        Me.pbp2.BackColor = System.Drawing.Color.Transparent
        Me.pbp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbp2.Location = New System.Drawing.Point(929, 345)
        Me.pbp2.Name = "pbp2"
        Me.pbp2.Size = New System.Drawing.Size(72, 78)
        Me.pbp2.TabIndex = 5
        Me.pbp2.TabStop = False
        '
        'lblp2
        '
        Me.lblp2.AutoSize = True
        Me.lblp2.BackColor = System.Drawing.Color.Transparent
        Me.lblp2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp2.ForeColor = System.Drawing.Color.Blue
        Me.lblp2.Location = New System.Drawing.Point(877, 9)
        Me.lblp2.Name = "lblp2"
        Me.lblp2.Size = New System.Drawing.Size(124, 38)
        Me.lblp2.TabIndex = 6
        Me.lblp2.Text = "Player 2"
        '
        'lblp1
        '
        Me.lblp1.AutoSize = True
        Me.lblp1.BackColor = System.Drawing.Color.Transparent
        Me.lblp1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp1.ForeColor = System.Drawing.Color.Blue
        Me.lblp1.Location = New System.Drawing.Point(12, 9)
        Me.lblp1.Name = "lblp1"
        Me.lblp1.Size = New System.Drawing.Size(124, 38)
        Me.lblp1.TabIndex = 7
        Me.lblp1.Text = "Player 1"
        '
        'lblp2ammo
        '
        Me.lblp2ammo.AutoSize = True
        Me.lblp2ammo.BackColor = System.Drawing.Color.Transparent
        Me.lblp2ammo.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp2ammo.ForeColor = System.Drawing.Color.Lime
        Me.lblp2ammo.Location = New System.Drawing.Point(812, 733)
        Me.lblp2ammo.Name = "lblp2ammo"
        Me.lblp2ammo.Size = New System.Drawing.Size(0, 38)
        Me.lblp2ammo.TabIndex = 8
        '
        'lblp1ammo
        '
        Me.lblp1ammo.AutoSize = True
        Me.lblp1ammo.BackColor = System.Drawing.Color.Transparent
        Me.lblp1ammo.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp1ammo.ForeColor = System.Drawing.Color.Lime
        Me.lblp1ammo.Location = New System.Drawing.Point(12, 733)
        Me.lblp1ammo.Name = "lblp1ammo"
        Me.lblp1ammo.Size = New System.Drawing.Size(0, 38)
        Me.lblp1ammo.TabIndex = 9
        '
        'tmrmove
        '
        Me.tmrmove.Enabled = True
        Me.tmrmove.Interval = 50
        '
        'tmrp1ammo
        '
        Me.tmrp1ammo.Interval = 5000
        '
        'tmrp2ammo
        '
        Me.tmrp2ammo.Interval = 5000
        '
        'pbsnowball
        '
        Me.pbsnowball.BackColor = System.Drawing.Color.Transparent
        Me.pbsnowball.BackgroundImage = CType(resources.GetObject("pbsnowball.BackgroundImage"), System.Drawing.Image)
        Me.pbsnowball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbsnowball.Location = New System.Drawing.Point(90, 377)
        Me.pbsnowball.Name = "pbsnowball"
        Me.pbsnowball.Size = New System.Drawing.Size(20, 21)
        Me.pbsnowball.TabIndex = 27
        Me.pbsnowball.TabStop = False
        '
        'pbsnowball2
        '
        Me.pbsnowball2.BackColor = System.Drawing.Color.Transparent
        Me.pbsnowball2.BackgroundImage = CType(resources.GetObject("pbsnowball2.BackgroundImage"), System.Drawing.Image)
        Me.pbsnowball2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbsnowball2.Location = New System.Drawing.Point(903, 377)
        Me.pbsnowball2.Name = "pbsnowball2"
        Me.pbsnowball2.Size = New System.Drawing.Size(20, 21)
        Me.pbsnowball2.TabIndex = 28
        Me.pbsnowball2.TabStop = False
        '
        'tmrp1snowballmove
        '
        Me.tmrp1snowballmove.Enabled = True
        Me.tmrp1snowballmove.Interval = 50
        '
        'tmrp1shoot
        '
        Me.tmrp1shoot.Interval = 50
        '
        'tmrp2shoot
        '
        Me.tmrp2shoot.Interval = 50
        '
        'tmrp2snowballmove
        '
        Me.tmrp2snowballmove.Enabled = True
        Me.tmrp2snowballmove.Interval = 50
        '
        'Battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1013, 780)
        Me.Controls.Add(Me.pbsnowball2)
        Me.Controls.Add(Me.pbsnowball)
        Me.Controls.Add(Me.lblp1ammo)
        Me.Controls.Add(Me.lblp2ammo)
        Me.Controls.Add(Me.lblp1)
        Me.Controls.Add(Me.lblp2)
        Me.Controls.Add(Me.pbp2)
        Me.Controls.Add(Me.pbp1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Battle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battle"
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsnowball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsnowball2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbp1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbp2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblp2 As System.Windows.Forms.Label
    Friend WithEvents lblp1 As System.Windows.Forms.Label
    Friend WithEvents lblp2ammo As System.Windows.Forms.Label
    Friend WithEvents lblp1ammo As System.Windows.Forms.Label
    Friend WithEvents tmrmove As System.Windows.Forms.Timer
    Friend WithEvents tmrp1ammo As System.Windows.Forms.Timer
    Friend WithEvents tmrp2ammo As System.Windows.Forms.Timer
    Friend WithEvents pbsnowball As System.Windows.Forms.PictureBox
    Friend WithEvents pbsnowball2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrp1snowballmove As System.Windows.Forms.Timer
    Friend WithEvents tmrp1shoot As System.Windows.Forms.Timer
    Friend WithEvents tmrp2shoot As System.Windows.Forms.Timer
    Friend WithEvents tmrp2snowballmove As System.Windows.Forms.Timer
End Class
