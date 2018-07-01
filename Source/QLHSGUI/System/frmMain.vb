Imports System.Configuration
Imports QLHSDTO
Public Class frmMain
    Private ConnectionString As String
    Private nguoidunghientai As NguoiDungDTO
    Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click

    End Sub

    Private Sub LậpThẻĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frmdg As frmLapPhieuNhapSach = New frmLapPhieuNhapSach()
        'frmdg.MdiParent = Me
        'frmdg.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

        Dim frmLogin As New frmDangNhap
        If (frmLogin.ShowDialog() = DialogResult.OK) Then
            nguoidunghientai = frmLogin.NguoiDungKetQua1
            tbxuser.Text = nguoidunghientai.StrHoTenNguoiDung
            LoadPhanQuyen()

        Else
            Me.Close()
        End If
    End Sub

    Public Function LoadPhanQuyen()
        Select Case nguoidunghientai.StrMaLoaiNguoiDung
            Case Is = 1 'admin trùm cuối
                khtool.Enabled = True
                bctool.Enabled = True
                nxtool.Enabled = True
                tstool.Enabled = True
                tltool.Enabled = True
                tctool.Enabled = True
                qlsachtool.Enabled = True
                qltltool.Enabled = True
                httool.Enabled = True
            Case Is = 2 ' khách
                khtool.Enabled = False
                bctool.Enabled = False
                nxtool.Enabled = False
                tstool.Enabled = False
                tltool.Enabled = False
                tctool.Enabled = True
                qlsachtool.Enabled = False
                qltltool.Enabled = False
                httool.Enabled = False

            Case Is = 3 'quản trị hệ thống
                khtool.Enabled = False
                bctool.Enabled = False

            Case Is = 4 'Giám đốc
                khtool.Enabled = False
                bctool.Enabled = False
                nxtool.Enabled = False
                tstool.Enabled = False
                tltool.Enabled = False
                tctool.Enabled = True
                qlsachtool.Enabled = False
                qltltool.Enabled = False
                httool.Enabled = True
            Case Is = 5 'Nhân viên
                khtool.Enabled = True


        End Select
    End Function

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

    Private Sub ThêmThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tltool.Click
        Dim frmtl As frmTheLoai = New frmTheLoai()
        frmtl.MdiParent = Me
        frmtl.Show()
    End Sub

    Private Sub TheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tstool.Click
        Dim frmdg As frmSach = New frmSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub BáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuànLíBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuảnLíBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuảnLíChiTiếtBáoCáoCôngNọToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuảnLýThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles qltltool.Click
        Dim frmdg As frmQLTheLoai = New frmQLTheLoai()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles qlsachtool.Click
        Dim frmdg As frmQLSach = New frmQLSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub LậpPhiếuNhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuNhậpSáchToolStripMenuItem.Click
        Dim frmdg As FrmPhieuNhapSach = New FrmPhieuNhapSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub QuảnLíChiTiếtBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LậpPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuThuTiềnToolStripMenuItem.Click
        Dim frmdg As frmPhieuThuTien = New frmPhieuThuTien()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles httool.Click

    End Sub

    Private Sub ThayĐổiQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiQuyĐịnhToolStripMenuItem.Click
        Dim frmdg As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub LậpHóaĐơnBánSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpHóaĐơnBánSáchToolStripMenuItem.Click
        Dim frmdg As frmHoaDonBanSach = New frmHoaDonBanSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub TraCứuSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tctool.Click
        Dim frmdg As frmTraCuuSach = New frmTraCuuSach()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub ThêmNgườiDùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmNgườiDùngToolStripMenuItem.Click
        Dim frmdg As frmThemNguoiDung = New frmThemNguoiDung()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub btndangxuat_Click(sender As Object, e As EventArgs) Handles btndangxuat.Click
        Dim frmLogin As New frmDangNhap

        If (frmLogin.ShowDialog() = DialogResult.OK) Then
            nguoidunghientai = frmLogin.NguoiDungKetQua1
            tbxuser.Text = nguoidunghientai.StrHoTenNguoiDung
            LoadPhanQuyen()

        Else
            Me.Close()
        End If
    End Sub

    Private Sub LậpBáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpBáoCáoTồnToolStripMenuItem.Click
        Dim frmdg As frmLapBaoCaoTonGUI = New frmLapBaoCaoTonGUI()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub
End Class