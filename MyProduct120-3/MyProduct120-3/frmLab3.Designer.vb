<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.ForeColor = New System.Windows.Forms.GroupBox()
        Me.BgColor = New System.Windows.Forms.GroupBox()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.ForeColor.SuspendLayout()
        Me.BgColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(199, 73)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(354, 72)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(549, 73)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(38, 38)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'cbSize
        '
        Me.cbSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cbSize.Location = New System.Drawing.Point(499, 184)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(88, 26)
        Me.cbSize.TabIndex = 2
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(549, 107)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(38, 38)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ขนาดฟรอนต์"
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(28, 30)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(36, 24)
        Me.lblFRed.TabIndex = 4
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(70, 30)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(36, 24)
        Me.lblFBlue.TabIndex = 4
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Lime
        Me.lblFGreen.Location = New System.Drawing.Point(112, 30)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(36, 24)
        Me.lblFGreen.TabIndex = 4
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Location = New System.Drawing.Point(154, 30)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(36, 24)
        Me.lblFViolet.TabIndex = 4
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(196, 30)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(36, 24)
        Me.lblFBlack.TabIndex = 4
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(28, 63)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(36, 24)
        Me.lblFOrange.TabIndex = 4
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(70, 63)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(36, 24)
        Me.lblFYellow.TabIndex = 4
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblFBrown.Location = New System.Drawing.Point(112, 63)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(36, 24)
        Me.lblFBrown.TabIndex = 4
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFWhite.Location = New System.Drawing.Point(154, 63)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(36, 24)
        Me.lblFWhite.TabIndex = 4
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.Aqua
        Me.lblFSky.Location = New System.Drawing.Point(196, 63)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(36, 24)
        Me.lblFSky.TabIndex = 4
        '
        'ForeColor
        '
        Me.ForeColor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ForeColor.Controls.Add(Me.lblFYellow)
        Me.ForeColor.Controls.Add(Me.lblFSky)
        Me.ForeColor.Controls.Add(Me.lblFRed)
        Me.ForeColor.Controls.Add(Me.lblFBlack)
        Me.ForeColor.Controls.Add(Me.lblFOrange)
        Me.ForeColor.Controls.Add(Me.lblFWhite)
        Me.ForeColor.Controls.Add(Me.lblFBlue)
        Me.ForeColor.Controls.Add(Me.lblFViolet)
        Me.ForeColor.Controls.Add(Me.lblFGreen)
        Me.ForeColor.Controls.Add(Me.lblFBrown)
        Me.ForeColor.Location = New System.Drawing.Point(111, 291)
        Me.ForeColor.Name = "ForeColor"
        Me.ForeColor.Size = New System.Drawing.Size(250, 100)
        Me.ForeColor.TabIndex = 5
        Me.ForeColor.TabStop = False
        Me.ForeColor.Text = "ForeColor"
        '
        'BgColor
        '
        Me.BgColor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BgColor.Controls.Add(Me.lblBYellow)
        Me.BgColor.Controls.Add(Me.lblBSky)
        Me.BgColor.Controls.Add(Me.lblBRed)
        Me.BgColor.Controls.Add(Me.lblBBlack)
        Me.BgColor.Controls.Add(Me.lblBOrange)
        Me.BgColor.Controls.Add(Me.lblBWhite)
        Me.BgColor.Controls.Add(Me.lblBBlue)
        Me.BgColor.Controls.Add(Me.lblBViolet)
        Me.BgColor.Controls.Add(Me.lblBGreen)
        Me.BgColor.Controls.Add(Me.lblBBrown)
        Me.BgColor.Location = New System.Drawing.Point(380, 291)
        Me.BgColor.Name = "BgColor"
        Me.BgColor.Size = New System.Drawing.Size(250, 100)
        Me.BgColor.TabIndex = 5
        Me.BgColor.TabStop = False
        Me.BgColor.Text = "BgColor"
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(70, 63)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(36, 24)
        Me.lblBYellow.TabIndex = 4
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.Aqua
        Me.lblBSky.Location = New System.Drawing.Point(196, 63)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(36, 24)
        Me.lblBSky.TabIndex = 4
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(28, 30)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(36, 24)
        Me.lblBRed.TabIndex = 4
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(196, 30)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(36, 24)
        Me.lblBBlack.TabIndex = 4
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Location = New System.Drawing.Point(28, 63)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(36, 24)
        Me.lblBOrange.TabIndex = 4
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBWhite.Location = New System.Drawing.Point(154, 63)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(36, 24)
        Me.lblBWhite.TabIndex = 4
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(70, 30)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(36, 24)
        Me.lblBBlue.TabIndex = 4
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Location = New System.Drawing.Point(154, 30)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(36, 24)
        Me.lblBViolet.TabIndex = 4
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Lime
        Me.lblBGreen.Location = New System.Drawing.Point(112, 30)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(36, 24)
        Me.lblBGreen.TabIndex = 4
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblBBrown.Location = New System.Drawing.Point(112, 63)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(36, 24)
        Me.lblBBrown.TabIndex = 4
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 439)
        Me.Controls.Add(Me.BgColor)
        Me.Controls.Add(Me.ForeColor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmColor"
        Me.ForeColor.ResumeLayout(False)
        Me.BgColor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents btnDown As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents ForeColor As GroupBox
    Friend WithEvents BgColor As GroupBox
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBBrown As Label
End Class
