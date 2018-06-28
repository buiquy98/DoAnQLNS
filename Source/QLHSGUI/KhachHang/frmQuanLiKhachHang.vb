Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiKhachHang
    Private khBus As KHACHHANGBUS
    Private Sub frmQuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KHACHHANGBUS()
        Dim listkh = New List(Of KHACHHANGDTO)

    End Sub



    Private Sub btCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btCapNhatKhachHang.Click



    End Sub

    Private Sub btXoaKhachHang_Click(sender As Object, e As EventArgs) Handles btXoaKhachHang.Click

    End Sub

    Private Sub btTimKiemTheoMAKH_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btTimKiemTheHoTen_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btTimKiemTheHoTen_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtHoTenKHTimKiem_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btTimKiemTheoMAKH_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMaKHTimKiem_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        Dim frmdg As frmCHONKHACHHANG = New frmCHONKHACHHANG()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
    End Sub
End Class