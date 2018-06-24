Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmQLSach
    Private sbus As SACHBUS

    Private Sub frmQLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sbus = New SACHBUS
        LoadContent()
    End Sub





    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub dgvsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvsach.SelectionChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Public Function LoadContent()
        Dim listsach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectAll(listsach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đầu sách không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "Imasach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "Imasach"
        dgvsach.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "Strtensach"
        clTenSach.HeaderText = "Ten Sach"
        clTenSach.DataPropertyName = "Strtensach"
        dgvsach.Columns.Add(clTenSach)

        Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
        clMaLoaiSach.Name = "Imaloaisach"
        clMaLoaiSach.HeaderText = "TheLoai"
        clMaLoaiSach.DataPropertyName = "Imaloaisach"
        dgvsach.Columns.Add(clMaLoaiSach)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "Strtacgia"
        clTacGia.HeaderText = "tác giả"
        clTacGia.DataPropertyName = "Strtacgia"
        dgvsach.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "Isoluongton"
        clSoLuongTon.HeaderText = "Số lượng tồn"
        clSoLuongTon.DataPropertyName = "Isoluongton"
        dgvsach.Columns.Add(clSoLuongTon)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "Idongia"
        clDonGia.HeaderText = "Đơn giá"
        clDonGia.DataPropertyName = "Idongia"
        dgvsach.Columns.Add(clDonGia)





    End Function
End Class