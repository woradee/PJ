Public Class frmProduct
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim vistra, computer, commissiontotal, calvis, calcom As Double

        vistra = Val(txtVistraGluta.Text)
        computer = Val(txtComputer.Text)

        calvis = vistra * 5 / 100
        calcom = computer * 10 / 100
        commissiontotal = calvis + calcom

        lblVistraGluta.Text = calvis
        lblComputer.Text = calcom
        lblProducttotal.Text = vistra + computer

        lblCommistotal.Text = commissiontotal

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
