Public Class frmMain

    Private Sub StartL1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartL1ToolStripMenuItem.Click
        Dim ffirst As New MyMoney
        'ffirst = New MyMoney 
        MyMoney.Show()
    End Sub

    Private Sub StartL2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartL2ToolStripMenuItem.Click
        Dim L2 As New frmProduct
        frmProduct.Show()

    End Sub

    Private Sub StartL3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartL3ToolStripMenuItem1.Click
        Dim L3 As New frmLab3
        frmLab3.Show()

    End Sub

    Private Sub StartL4ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StartL4ToolStripMenuItem2.Click
        Dim L4 As New frmJob4
        frmJob4.Show()

    End Sub

    Private Sub StartL5ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles StartL5ToolStripMenuItem3.Click
        Dim L5 As New frmLab5
        frmLab5.Show()
    End Sub

    Private Sub StartL6ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles StartL6ToolStripMenuItem4.Click
        Dim L6 As New frmJob6
        frmJob6.Show()

    End Sub

    Private Sub StartL7ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles StartL7ToolStripMenuItem5.Click
        Dim L7 As New frmJob7
        frmJob7.Show()

    End Sub

    Private Sub StartL8ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles StartL8ToolStripMenuItem6.Click
        Dim L8 As New frmLab8
        frmLab8.Show()

    End Sub
End Class