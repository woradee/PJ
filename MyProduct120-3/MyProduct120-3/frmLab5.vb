Public Class frmLab5
    Dim decTotal, totaldiscount, discount, decCredit, totalprice, unit As Double
    Dim tt As String

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        tt = txtProduct.Text
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked = True Then
                If radPaid.Checked = True Then
                    If decTotal < 1000 Then
                        discount = 0
                        totaldiscount = discount
                        totalprice = decTotal - totaldiscount
                    ElseIf decTotal < 5000 Then
                        discount = 5 / 100
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount
                    ElseIf decTotal < 10000 Then
                        discount = 10 / 100
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount
                    Else
                        discount = 15 / 100
                        totaldiscount = decTotal * discount
                        totalprice = decTotal - totaldiscount 

                    End If
                    lblDiscount.Text = totaldiscount
                    lblPaid.Text = totalprice
                    lblCredit.Text = "ไม่มีค่าค้างชำระ"
                ElseIf radCredit.Checked = True Then
                    lblDiscount.Text = "ไม่มีส่วนลด"
                    lblPaid.Text = lblTotal.Text
                    lblCredit.Text = lblTotal.Text





                End If

            ElseIf radOther.Checked = True Then
                lblPaid.Text = decTotal
                    lblCredit.Text = "ไม่มีเงินเชื่อ"
                lblDiscount.Text = "ไม่มีส่วนลด"
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        totalprice = txtPrice.Text
        unit = Val(txtUnit.Text)
        decTotal = totalprice * unit
        lblTotal.Text = decTotal

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text)
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked = True Then
            gbPay.Enabled = True
        End If

    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged

        gbPay.Enabled = False
        radPaid.Enabled = True

    End Sub


End Class