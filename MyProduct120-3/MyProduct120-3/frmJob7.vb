Public Class frmJob7
    Private Sub frmJob7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        txtAdd.Clear()
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a, b As Integer
        a = lstAdd.Items.Count
        If a = 0 Then
            MessageBox.Show("ไม่มีตัวเลือก", "โปรแกรมควบคุม ListBox-ComboBox ", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            cb0Output.Items.Add(lstAdd.SelectedItem)
            b = lstAdd.SelectedIndex
            If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then 'item
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex) 'item
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = b
            End If
            cb0Output.SelectedIndex = cb0Output.Items.Count - 1
        End If
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        '>>
        'If lstAdd.Items.Count > 0 Then
        'cb0Output.Items.Add(lstAdd.SelectedItem)
        'lstAdd.Items.Remove(lstAdd.SelectedItem)
        'End If
        'cb0Output.Items.Add(lstAdd.SelectedItem)
        'lstAdd.Items.Remove(lstAdd.SelectedItem)
        'Dim lst As Integer
        'lst = lstAdd.Items.Count

        If lstAdd.Items.Count < 1 Then
            MessageBox.Show("ไม่มีตัวเลือก", "โปรแกรมควบคุม ListBox-ComboBox ", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            For ma = 1 To lstAdd.Items.Count
                cb0Output.Items.Add(lstAdd.SelectedItem)
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                cb0Output.SelectedIndex = cb0Output.Items.Count - 1
            Next
            lblOutput.Text = cb0Output.SelectedItem
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '<
        If cb0Output.Items.Count < 1 Then
            MessageBox.Show("ไม่มีตัวเลือก", "โปรแกรมควบคุม ListBox-ComboBox ", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            cb0Output.Text = ""
            lstAdd.Items.Add(cb0Output.SelectedItem)
            cb0Output.Items.Remove(cb0Output.SelectedItem)
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            cb0Output.SelectedIndex = cb0Output.Items.Count - 1
        End If
        lblOutput.Text = cb0Output.SelectedItem
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        '<<
        If cb0Output.Items.Count < 1 Then
            MessageBox.Show("ไม่มีตัวเลือก", "โปรแกรมควบคุม ListBox-ComboBox ", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            For ba = 1 To cb0Output.Items.Count
                lstAdd.Items.Add(cb0Output.SelectedItem)
                cb0Output.Items.RemoveAt(cb0Output.SelectedIndex)
                cb0Output.SelectedIndex = cb0Output.Items.Count - 1
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
            cb0Output.Text = ""
            lblOutput.Text = cb0Output.SelectedItem
        End If
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

    Private Sub cb0Output_SelectedIndexChanged(sender As Object, e As EventArgs) 
        lblOutput.Text = cb0Output.SelectedItem
    End Sub
End Class