Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit, price, unit As Double
    Dim tt As String

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        tt = txtProduct.Text
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        price = txtPrice.Text
        unit = txtUnit.Text
        decTotal = price * unit
        lblTotal.Text = decTotal

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked Then
            gbCusType.Enabled = True
        End If

    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        If radMember.Checked Then
            gbPay.Enabled = False
            gbPay.Enabled = True


        End If

    End Sub


End Class