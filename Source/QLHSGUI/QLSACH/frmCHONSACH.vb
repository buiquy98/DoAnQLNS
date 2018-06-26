Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmCHONSACH

    Private sbus As SACHBUS
    Public isMulti As Boolean
    Public listSachDuocChon As List(Of Integer)
    Public Function LoadContent()
        listSachDuocChon = New List(Of Integer)
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

    Private Sub frmCHONSACH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sbus = New SACHBUS()
        LoadContent()
    End Sub

    Private Sub btnchon_Click(sender As Object, e As EventArgs) Handles btnchon.Click
        If listSachDuocChon.Count <> 0 Then
            listSachDuocChon.Clear()
        End If

        Dim index = dgvsach.CurrentRow.Cells(0).Value
        listSachDuocChon.Add(index)
        Me.Close()
    End Sub
End Class