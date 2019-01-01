Public Class frmJob7
    Private Sub frmJob7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear 

    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True

        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        '>
        cb0Output.Items.Add(lstAdd.SelectedItem) 'ข้อ4//
        lstAdd.Items.Remove(lstAdd.SelectedItem)
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        '>>
        'If lstAdd.Items.Count > 0 Then
        'cb0Output.Items.Add(lstAdd.SelectedItem)
        'lstAdd.Items.Remove(lstAdd.SelectedItem)
        'End If
        cb0Output.Items.Add(lstAdd.SelectedItem)
        lstAdd.Items.Remove(lstAdd.SelectedItem)


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '<
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        '<<
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cb0Output.Items.Clear()
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class