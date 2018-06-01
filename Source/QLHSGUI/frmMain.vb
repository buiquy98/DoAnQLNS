Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click

    End Sub

    Private Sub LậpThẻĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpThẻĐọcGiảToolStripMenuItem.Click
        Dim frmdg As frmLapPhieuNhapSach = New frmLapPhieuNhapSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub ThêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmToolStripMenuItem.Click
        Dim frmdg As frmThemKhachHang = New frmThemKhachHang()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        Dim frmdg As frmQuanLiKhachHang = New frmQuanLiKhachHang()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub
End Class