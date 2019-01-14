Public Class frmJob6
    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click

        Dim Free1, Free2, Free3 As Integer

        Free1 = 25000
        Free2 = 15000
        Free3 = 35000

        If chkCarForMe.Checked = True Then

            gbItems.Enabled = True
            gbFree.Enabled = True

            lblPaidPrice.Text = Val(lblStartPrice.Text) + Free1 + Free2 + Free3
        Else
            Dim result As DialogResult
            result = MessageBox.Show("ต้องการยกเลิกหรือไม่", ("การซื้อรถ"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) - DialogResult.Yes
            If result = False Then

                gbItems.Enabled = False
                gbFree.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = 0
            Else
                chkCarForMe.Checked = True

            End If
            'result = DialogResult.Yes
            'gbItems.Enabled = False
            'gbFree.Enabled = False

        End If
    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbItems.Enabled = False
        gbFree.Enabled = False
    End Sub

    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        End If

    End Sub

    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        End If

    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsAdd1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsAdd1.Text)
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsAdd2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsAdd2.Text)
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsAdd3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsAdd3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsAdd4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsAdd4.Text)
        End If
    End Sub
End Class