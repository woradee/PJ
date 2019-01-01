<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblAllownce = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี (อย่างหยาบ)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "วันที่"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(82, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "เงินเดือน"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = " ยอดขายทั้งปี"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(82, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = " เงินเดือนทั้งปี"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(82, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = " รับเงินโบนัส"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(82, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = " รายได้รวม"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(82, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = " หักค่าลดหย่อน"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(82, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = " ภาษีที่ต้องชำระ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(215, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(212, 23)
        Me.lblDate.TabIndex = 2
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(215, 150)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(212, 21)
        Me.txtSalary.TabIndex = 0
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(215, 189)
        Me.txtSale.Multiline = True
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(212, 21)
        Me.txtSale.TabIndex = 1
        Me.txtSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSalary.Location = New System.Drawing.Point(215, 227)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(212, 23)
        Me.lblYearSalary.TabIndex = 2
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBonus
        '
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(215, 267)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(212, 23)
        Me.lblBonus.TabIndex = 2
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllIncome.Location = New System.Drawing.Point(215, 311)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(212, 23)
        Me.lblAllIncome.TabIndex = 2
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAllownce
        '
        Me.lblAllownce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllownce.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllownce.Location = New System.Drawing.Point(215, 359)
        Me.lblAllownce.Name = "lblAllownce"
        Me.lblAllownce.Size = New System.Drawing.Size(212, 23)
        Me.lblAllownce.TabIndex = 2
        Me.lblAllownce.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(215, 402)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(212, 23)
        Me.lblTax.TabIndex = 2
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radShortDate.Location = New System.Drawing.Point(38, 36)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(162, 24)
        Me.radShortDate.TabIndex = 1
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGenDate.Location = New System.Drawing.Point(38, 66)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(180, 24)
        Me.radGenDate.TabIndex = 0
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLongDate.Location = New System.Drawing.Point(38, 96)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(159, 24)
        Me.radLongDate.TabIndex = 2
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'btnCalTax
        '
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(496, 310)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(159, 62)
        Me.btnCalTax.TabIndex = 5
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(450, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 141)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 482)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllownce)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "Calculate of Taxation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblAllIncome As Label
    Friend WithEvents lblAllownce As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents radShortDate As RadioButton
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents btnCalTax As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
