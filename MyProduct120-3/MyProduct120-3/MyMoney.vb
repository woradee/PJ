Public Class MyMoney
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'เงินเดือนทั้งปี = เงินเดือน*12เดือน
        lblYear.Text = Val(txtSalary.Text) * 12
        lblTax.Text = lblYear.Text * 5 / 100


        lblTotal.Text = lblYear.Text - lblTax.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class