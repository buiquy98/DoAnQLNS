Public Class frmMain
    Private Sub TạoMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TạoMớiToolStripMenuItem.Click
        Dim frmLTDG As frmLapTheDocGia = New frmLapTheDocGia()
        frmLTDG.MdiParent = Me
        frmLTDG.Show()

    End Sub

    'Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
    '    Dim answer As MsgBoxResult
    '    answer = MsgBox("Bạn thật sự muốn thoát?", MsgBoxStyle.YesNo)
    '    If answer = MsgBoxResult.Yes Then
    '        frmLapTheDocGia.Close()
    '    End If
    'End Sub
End Class
