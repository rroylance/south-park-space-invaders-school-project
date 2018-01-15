<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Char_Select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Char_Select))
        Me.lblcartman = New System.Windows.Forms.Label
        Me.lblkyle = New System.Windows.Forms.Label
        Me.lblstan = New System.Windows.Forms.Label
        Me.lblbutters = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblsure = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.lblyes = New System.Windows.Forms.Label
        Me.pbbutters = New System.Windows.Forms.PictureBox
        Me.pbstan = New System.Windows.Forms.PictureBox
        Me.pbkyle = New System.Windows.Forms.PictureBox
        Me.pbcartman = New System.Windows.Forms.PictureBox
        Me.btnback = New System.Windows.Forms.Button
        Me.pbp1 = New System.Windows.Forms.PictureBox
        CType(Me.pbbutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbkyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcartman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcartman
        '
        Me.lblcartman.AutoSize = True
        Me.lblcartman.BackColor = System.Drawing.Color.Transparent
        Me.lblcartman.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartman.ForeColor = System.Drawing.Color.Blue
        Me.lblcartman.Location = New System.Drawing.Point(126, 318)
        Me.lblcartman.Name = "lblcartman"
        Me.lblcartman.Size = New System.Drawing.Size(189, 38)
        Me.lblcartman.TabIndex = 0
        Me.lblcartman.Text = "Eric Cartman"
        '
        'lblkyle
        '
        Me.lblkyle.AutoSize = True
        Me.lblkyle.BackColor = System.Drawing.Color.Transparent
        Me.lblkyle.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkyle.ForeColor = System.Drawing.Color.Blue
        Me.lblkyle.Location = New System.Drawing.Point(353, 612)
        Me.lblkyle.Name = "lblkyle"
        Me.lblkyle.Size = New System.Drawing.Size(211, 38)
        Me.lblkyle.TabIndex = 1
        Me.lblkyle.Text = "Kyle Broflovski"
        '
        'lblstan
        '
        Me.lblstan.AutoSize = True
        Me.lblstan.BackColor = System.Drawing.Color.Transparent
        Me.lblstan.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstan.ForeColor = System.Drawing.Color.Blue
        Me.lblstan.Location = New System.Drawing.Point(571, 318)
        Me.lblstan.Name = "lblstan"
        Me.lblstan.Size = New System.Drawing.Size(171, 38)
        Me.lblstan.TabIndex = 2
        Me.lblstan.Text = "Stan Marsh"
        '
        'lblbutters
        '
        Me.lblbutters.AutoSize = True
        Me.lblbutters.BackColor = System.Drawing.Color.Transparent
        Me.lblbutters.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbutters.ForeColor = System.Drawing.Color.Blue
        Me.lblbutters.Location = New System.Drawing.Point(673, 612)
        Me.lblbutters.Name = "lblbutters"
        Me.lblbutters.Size = New System.Drawing.Size(347, 38)
        Me.lblbutters.TabIndex = 3
        Me.lblbutters.Text = "Leopold ""Butters"" Stotch"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1020, 100)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Please Select Your Character... "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsure
        '
        Me.lblsure.BackColor = System.Drawing.Color.Transparent
        Me.lblsure.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsure.ForeColor = System.Drawing.Color.Yellow
        Me.lblsure.Location = New System.Drawing.Point(12, 109)
        Me.lblsure.Name = "lblsure"
        Me.lblsure.Size = New System.Drawing.Size(1020, 100)
        Me.lblsure.TabIndex = 5
        Me.lblsure.Text = "Are You Sure ?"
        Me.lblsure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblno
        '
        Me.lblno.BackColor = System.Drawing.Color.Transparent
        Me.lblno.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Red
        Me.lblno.Location = New System.Drawing.Point(532, 209)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(124, 100)
        Me.lblno.TabIndex = 6
        Me.lblno.Text = "No"
        Me.lblno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblyes
        '
        Me.lblyes.BackColor = System.Drawing.Color.Transparent
        Me.lblyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyes.ForeColor = System.Drawing.Color.Lime
        Me.lblyes.Location = New System.Drawing.Point(360, 209)
        Me.lblyes.Name = "lblyes"
        Me.lblyes.Size = New System.Drawing.Size(152, 100)
        Me.lblyes.TabIndex = 7
        Me.lblyes.Text = "Yes"
        Me.lblyes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbbutters
        '
        Me.pbbutters.BackColor = System.Drawing.Color.Transparent
        Me.pbbutters.Location = New System.Drawing.Point(748, 348)
        Me.pbbutters.Name = "pbbutters"
        Me.pbbutters.Size = New System.Drawing.Size(206, 261)
        Me.pbbutters.TabIndex = 8
        Me.pbbutters.TabStop = False
        '
        'pbstan
        '
        Me.pbstan.BackColor = System.Drawing.Color.Transparent
        Me.pbstan.Location = New System.Drawing.Point(560, 356)
        Me.pbstan.Name = "pbstan"
        Me.pbstan.Size = New System.Drawing.Size(193, 253)
        Me.pbstan.TabIndex = 9
        Me.pbstan.TabStop = False
        '
        'pbkyle
        '
        Me.pbkyle.BackColor = System.Drawing.Color.Transparent
        Me.pbkyle.Location = New System.Drawing.Point(348, 348)
        Me.pbkyle.Name = "pbkyle"
        Me.pbkyle.Size = New System.Drawing.Size(216, 269)
        Me.pbkyle.TabIndex = 10
        Me.pbkyle.TabStop = False
        '
        'pbcartman
        '
        Me.pbcartman.BackColor = System.Drawing.Color.Transparent
        Me.pbcartman.Location = New System.Drawing.Point(64, 359)
        Me.pbcartman.Name = "pbcartman"
        Me.pbcartman.Size = New System.Drawing.Size(283, 269)
        Me.pbcartman.TabIndex = 11
        Me.pbcartman.TabStop = False
        '
        'btnback
        '
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(12, 692)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(1020, 23)
        Me.btnback.TabIndex = 12
        Me.btnback.Text = "<<<<< Back to Main >>>>>"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'pbp1
        '
        Me.pbp1.Location = New System.Drawing.Point(464, 721)
        Me.pbp1.Name = "pbp1"
        Me.pbp1.Size = New System.Drawing.Size(100, 50)
        Me.pbp1.TabIndex = 13
        Me.pbp1.TabStop = False
        '
        'Char_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 720)
        Me.Controls.Add(Me.pbp1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pbcartman)
        Me.Controls.Add(Me.pbkyle)
        Me.Controls.Add(Me.pbstan)
        Me.Controls.Add(Me.pbbutters)
        Me.Controls.Add(Me.lblyes)
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.lblsure)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblbutters)
        Me.Controls.Add(Me.lblstan)
        Me.Controls.Add(Me.lblkyle)
        Me.Controls.Add(Me.lblcartman)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Char_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Char_Select"
        CType(Me.pbbutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbkyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcartman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcartman As System.Windows.Forms.Label
    Friend WithEvents lblkyle As System.Windows.Forms.Label
    Friend WithEvents lblstan As System.Windows.Forms.Label
    Friend WithEvents lblbutters As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsure As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents lblyes As System.Windows.Forms.Label
    Friend WithEvents pbbutters As System.Windows.Forms.PictureBox
    Friend WithEvents pbstan As System.Windows.Forms.PictureBox
    Friend WithEvents pbkyle As System.Windows.Forms.PictureBox
    Friend WithEvents pbcartman As System.Windows.Forms.PictureBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents pbp1 As System.Windows.Forms.PictureBox
End Class
