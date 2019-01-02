<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb0Output = New System.Windows.Forms.ComboBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(243, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมควบคุม ListBox-ComboBox "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb0Output
        '
        Me.cb0Output.FormattingEnabled = True
        Me.cb0Output.Location = New System.Drawing.Point(509, 126)
        Me.cb0Output.Name = "cb0Output"
        Me.cb0Output.Size = New System.Drawing.Size(132, 21)
        Me.cb0Output.TabIndex = 2
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.Color.Aqua
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove.Location = New System.Drawing.Point(361, 163)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(55, 34)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveAll
        '
        Me.btnMoveAll.BackColor = System.Drawing.Color.Aqua
        Me.btnMoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveAll.Location = New System.Drawing.Point(361, 203)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(55, 34)
        Me.btnMoveAll.TabIndex = 2
        Me.btnMoveAll.Text = " >>"
        Me.btnMoveAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Aqua
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(361, 243)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(55, 34)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.BackColor = System.Drawing.Color.Aqua
        Me.btnBackAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(361, 283)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(55, 34)
        Me.btnBackAll.TabIndex = 2
        Me.btnBackAll.Text = " <<"
        Me.btnBackAll.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(133, 429)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 34)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = " เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(496, 429)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = " เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Aqua
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(312, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 34)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "ปิหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(104, 481)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(184, 30)
        Me.txtAdd.TabIndex = 0
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(460, 481)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(190, 30)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstAdd
        '
        Me.lstAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.ItemHeight = 16
        Me.lstAdd.Location = New System.Drawing.Point(104, 126)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(230, 276)
        Me.lstAdd.TabIndex = 3
        '
        'frmJob7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(697, 583)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cb0Output)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob7"
        Me.Text = "Week7 Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb0Output As ComboBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnMoveAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBackAll As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lstAdd As ListBox
End Class
