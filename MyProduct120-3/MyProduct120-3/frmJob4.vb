Public Class frmJob4
    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Now As Date = Date.Now
        Console.WriteLine(Now.ToShortDateString())
        lblDate.Text = Now
        radGenDate.Checked = True
        'lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)

    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07
        Dim dblYearSalary, dblSalary, dblSale As Integer
        Dim dblBonus, dblAllowance, dblTax, dblAllIncome As Double
        dblSalary = Val(txtSalary.Text)
        dblSale = Val(txtSale.Text)

        dblYearSalary = dblSalary * 12
        dblBonus = dblSale * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = FormatNumber(dblBonus, 2)
        lblAllIncome.Text = FormatNumber(dblAllIncome, 2)
        lblAllownce.Text = FormatNumber(dblAllowance, 2)
        lblTax.Text = FormatNumber(dblTax, 2)

    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        Dim Now As Date = Date.Now
        lblDate.Text = Now
        'lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        Dim shortDate As Date = Date.Now
        lblDate.Text = shortDate.Date
        'lblDate.Text = FormatDateTime(Today, DateFormat.ShortDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        'Dim LongDate As String = Format(Now, "Long Date")
        'lblDate.Text = LongDate
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)

    End Sub
End Class