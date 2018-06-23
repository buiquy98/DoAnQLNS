﻿Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click

    End Sub

    Private Sub LậpThẻĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frmdg As frmLapPhieuNhapSach = New frmLapPhieuNhapSach()
        'frmdg.MdiParent = Me
        'frmdg.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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

    Private Sub ThêmThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiToolStripMenuItem.Click
        Dim frmtl As frmTheLoai = New frmTheLoai()
        frmtl.MdiParent = Me
        frmtl.Show()
    End Sub

    Private Sub TheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheToolStripMenuItem.Click
        Dim frmdg As frmSach = New frmSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub BáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoCôngNợToolStripMenuItem.Click
        Dim frmdg As frmLapBaoCaoCongNo = New frmLapBaoCaoCongNo()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuànLíBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuànLíBáoCáoCôngNợToolStripMenuItem.Click
        Dim frmdg As frmQuanLiBaoCaoCongNo = New frmQuanLiBaoCaoCongNo()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTồnToolStripMenuItem.Click
        Dim frmdg As frmLapBaoCaoTon = New frmLapBaoCaoTon()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíBáoCáoTồnToolStripMenuItem.Click
        Dim frmdg As frmQuanLiBaoCaoTon = New frmQuanLiBaoCaoTon()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíChiTiếtBáoCáoCôngNọToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíChiTiếtBáoCáoCôngNọToolStripMenuItem.Click
        Dim frmdg As frmQuanLiChiTietBaoCaoCongNo = New frmQuanLiChiTietBaoCaoCongNo()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLýThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThểLoạiToolStripMenuItem.Click
        Dim frmdg As frmQLTheLoai = New frmQLTheLoai()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
        Dim frmdg As frmQLSach = New frmQLSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub
End Class