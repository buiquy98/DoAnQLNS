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


    Private Sub loadListSach_ByMaLoaiSach(maLoaiSach As String)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_ByMaSach(maLoaiSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListSach.SuspendLayout()
        dgvsach.Columns.Clear()
        dgvsach.DataSource = Nothing

        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listSach

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
        clMaLoaiSach.HeaderText = "The Loai"
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
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvsach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListSach_ByTenSach(tenSach As String)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_ByName(tenSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách theo tên sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listSach

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

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvsach.DataSource)
        myCurrencyManager.Refresh()
    End Sub


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

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Try
            Dim tenSach = tbxtensach.Text
            loadListSach_ByTenSach(tenSach)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub

    Private Sub btnall_Click(sender As Object, e As EventArgs) Handles btnall.Click
        LoadContent()
    End Sub
End Class