Public Class frmLab8
    Dim sumScore, sumCredit As Integer
    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sumScore As Decimal = 150
        Dim sumCredit As Decimal = 50

        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()

        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()
        lblNewGPA.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call frmLab8_Load(sender, e)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSubject.Text = "" Or txtScore.Text = "" Or txtCredit.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลใหม่", "โปรแกรมคำนวณเกรดเฉลี่ยสะสม", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Not IsNumeric(txtCredit.Text) Or Not IsNumeric(txtScore.Text) Then
                MessageBox.Show("กรุณาป้อนหมายเลขที่ถูกต้อง", "โปรแกรมคำนวณเกรดเฉลี่ยสะสม", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        lstSubject.Items.Add(txtSubject.Text)
        lstScore.Items.Add(txtScore.Text)
        lstCredit.Items.Add(txtCredit.Text)
        lstGrade.Items.Add(getGrade(txtScore.Text))

        lstSubject.SelectedIndex = lstSubject.Items.Count - 1
        lstScore.SelectedIndex = lstScore.Items.Count - 1
        lstCredit.SelectedIndex = lstCredit.Items.Count - 1
        lstGrade.SelectedIndex = lstGrade.Items.Count - 1
        Call calData()
        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()
    End Sub
    Private Function getGrade(ByVal Score As Integer) As String
        Dim YourGrade As String = ""
        If Score >= 80 Then
            YourGrade = "A"
        ElseIf Score >= 75 Then
            YourGrade = "B+"
        ElseIf Score >= 70 Then
            YourGrade = "B"
        ElseIf Score >= 65 Then
            YourGrade = "C+"
        ElseIf Score >= 60 Then
            YourGrade = "C"
        ElseIf Score >= 55 Then
            YourGrade = "D+"
        ElseIf Score >= 50 Then
            YourGrade = "D"
        Else
            YourGrade = "F"
        End If
        Return YourGrade
    End Function

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub calData()
        Dim Grade As String
        Dim douGR2, douGR3, douGRTotal, sumGrade, i, douA, douB, douC As Double
        i = lstCredit.Items.Count
        For intGR = 0 To i - 1
            sumScore = lstScore.Items(intGR)
            sumCredit = lstCredit.Items(intGR)
            Grade = lstGrade.Items(intGR)
            Select Case Grade
                Case "A"
                    sumGrade = 4
                Case "B+"
                    sumGrade = 3.5
                Case "B"
                    sumGrade = 3
                Case "C+"
                    sumGrade = 2.5
                Case "C"
                    sumGrade = 2
                Case "D+"
                    sumGrade = 1.5
                Case "D"
                    sumGrade = 1
                Case "F"
                    sumGrade = 0
            End Select
            douA = sumCredit * sumGrade
            douB = douA + douB
            douC = sumCredit + douC
        Next

        douGR2 = lblOldTotalScore.Text + douB
        douGR3 = lblOldTotalCredit.Text + douC
        douGRTotal = douGR2 / douGR3

        lblNewGPA.Text = FormatNumber(douGRTotal)
    End Sub



End Class