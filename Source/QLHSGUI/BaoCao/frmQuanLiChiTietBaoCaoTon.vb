Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiChiTietBaoCaoTon
    Private sachBus As SACHBUS
    Private loaisachBus As LOAISACHBUS
    Private ctbaocaotonBus As CHITIETBAOCAOTONBUS
    Private baocaotonBus As BAOCAOTONBUS

    Private baocaoton As BAOCAOTONDTO
    Private sach As SACHDTO
    Private loaiSach As LOAISACHDTO
    Private Sub frmQuanLiChiTietBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBus = New SACHBUS()
        loaisachBus = New LOAISACHBUS()
        ctbaocaotonBus = New CHITIETBAOCAOTONBUS()
        baocaotonBus = New BAOCAOTONBUS()

        Dim listBaoCaoTon = New List(Of BAOCAOTONDTO)
        Dim result As Result
        result = baocaotonBus.selectAll(listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub
    Private Sub loadListChiTietBaoCaoTon()
        Dim listct = New List(Of CHITIETBAOCAOTONDTO)
        Dim result As Result
        result = ctbaocaotonBus.selectAll(listct)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListChiTietBaoCaoTon.Columns.Clear()
        dgvListChiTietBaoCaoTon.DataSource = Nothing

        dgvListChiTietBaoCaoTon.AutoGenerateColumns = False
        dgvListChiTietBaoCaoTon.AllowUserToAddRows = False
        dgvListChiTietBaoCaoTon.DataSource = listct

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maChiTietBaoCaoTon"
        clMa.HeaderText = "Mã Chi Tiết Báo Cáo Tồn"
        clMa.DataPropertyName = "MaChiTietBaoCaoTon1"
        dgvListChiTietBaoCaoTon.Columns.Add(clMa)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "maSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach1"
        dgvListChiTietBaoCaoTon.Columns.Add(clMaSach)


        Dim clTonDau = New DataGridViewTextBoxColumn()
        clTonDau.Name = "tonDau"
        clTonDau.HeaderText = "Số Lượng Tồn Đầu"
        clTonDau.DataPropertyName = "TonDau1"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "tonPhatSinh"
        clPhatSinh.HeaderText = "Phát Sinh"
        clPhatSinh.DataPropertyName = "TonPhatSinh1"
        dgvListChiTietBaoCaoTon.Columns.Add(clPhatSinh)

        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        clTonCuoi.Name = "tonCuoi"
        clTonCuoi.HeaderText = "Số Lượng Tồn Cuối"
        clTonCuoi.DataPropertyName = "TonCuoi1"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietBaoCaoTon.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub loadlistBaoCao_ByMaBaoCaoTon(maBaoCao As String)
        Dim listctBaoCao = New List(Of CHITIETBAOCAOTONDTO)
        Dim result As Result
        result = ctbaocaotonBus.selectAll_byMaBaoCaoTon(maBaoCao, listctBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListChiTietBaoCaoTon.Columns.Clear()
        dgvListChiTietBaoCaoTon.DataSource = Nothing

        dgvListChiTietBaoCaoTon.AutoGenerateColumns = False
        dgvListChiTietBaoCaoTon.AllowUserToAddRows = False
        dgvListChiTietBaoCaoTon.DataSource = listctBaoCao

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maChiTietBaoCaoTon"
        clMa.HeaderText = "Mã Chi Tiết Báo Cáo Tồn"
        clMa.DataPropertyName = "MaChiTietBaoCaoTon1"
        dgvListChiTietBaoCaoTon.Columns.Add(clMa)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "maSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach1"
        dgvListChiTietBaoCaoTon.Columns.Add(clMaSach)


        Dim clTonDau = New DataGridViewTextBoxColumn()
        clTonDau.Name = "tonDau"
        clTonDau.HeaderText = "Số Lượng Tồn Đầu"
        clTonDau.DataPropertyName = "TonDau1"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "tonPhatSinh"
        clPhatSinh.HeaderText = "Phát Sinh"
        clPhatSinh.DataPropertyName = "TonPhatSinh1"
        dgvListChiTietBaoCaoTon.Columns.Add(clPhatSinh)

        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        clTonCuoi.Name = "tonCuoi"
        clTonCuoi.HeaderText = "Số Lượng Tồn Cuối"
        clTonCuoi.DataPropertyName = "TonCuoi1"
        dgvListChiTietBaoCaoTon.Columns.Add(clTonCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListChiTietBaoCaoTon.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub loadlistBaoCaoTon(maBaoCaoTon As String)
        Dim baocaotonBus = New BAOCAOTONBUS()
        Dim listBaoCao = New List(Of BAOCAOTONDTO)
        Dim result = baocaotonBus.selectAll_byMaBaoCaoTon(maBaoCaoTon, listBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoton = listBaoCao(0)
        dtpThangBaoCaoTon.Value = baocaoton.Thang1
    End Sub

    Private Sub btCapNhatChiTietBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btCapNhatChiTietBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Try
                Dim listCTBCT = New List(Of CHITIETBAOCAOTONDTO)
                '1. Mapping data from GUI control
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = ctbaocaotonBus.update(txtMaCTBCT.Text, txtSoLuongTonDau.Text, txtPhatSinh.Text, txtSoLuongTonCuoi.Text, listCTBCT)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistBaoCao_ByMaBaoCaoTon(txtMaBaoCaoTonTimKiem.Text)
                    ' Hightlight the row has been updated on table
                    dgvListChiTietBaoCaoTon.Rows(currentRowIndex).Selected = True
                    MessageBox.Show("Cập nhật chi tiết báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub dgvListChiTietBaoCaoTon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListChiTietBaoCaoTon.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Try
                Dim ctbct = CType(dgvListChiTietBaoCaoTon.Rows(currentRowIndex).DataBoundItem, CHITIETBAOCAOTONDTO)
                txtMaCTBCT.Text = ctbct.MaChiTietBaoCaoTon1
                txtMaSach.Text = ctbct.MaSach1
                txtSoLuongTonDau.Text = ctbct.TonDau1
                txtPhatSinh.Text = ctbct.TonPhatSinh1
                txtSoLuongTonCuoi.Text = ctbct.TonCuoi1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub loadListSach(maSach As String)
        Dim sachBus = New SACHBUS()
        Dim listSach = New List(Of SACHDTO)
        Dim result = sachBus.selectALL_ByMaSach(maSach, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        sach = listSach(0)
        txtTenSach.Text = sach.Strtensach
        txtTacGia.Text = sach.Strtacgia
        txtTheLoai.Text = sach.Imaloaisach
    End Sub
    Private Sub loadlistLoaiSach(maLoai As String)
        Dim loaisachBus = New LOAISACHBUS()
        Dim listLoai = New List(Of LOAISACHDTO)
        Dim result = loaisachBus.selectAll_ByMaLoaiSach(maLoai, listLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin loại sách thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loaiSach = listLoai(0)
        txtTheLoai.Text = loaiSach.Strtenloaisach
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Dim maBaoCao = txtMaBaoCaoTonTimKiem.Text
            loadlistBaoCao_ByMaBaoCaoTon(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaSach_TextChanged(sender As Object, e As EventArgs) Handles txtMaSach.TextChanged
        Try
            Dim maSach = txtMaSach.Text
            loadListSach(maSach)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTheLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTheLoai.TextChanged
        Try
            Dim maLoai = txtTheLoai.Text
            loadlistLoaiSach(maLoai)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btXoaChiTietBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btXoaChiTietBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListChiTietBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListChiTietBaoCaoTon.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết báo cáo có mã là  " + txtMaCTBCT.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctbaocaotonBus.delete(Convert.ToInt32(txtMaCTBCT.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCao_ByMaBaoCaoTon(txtMaBaoCaoTonTimKiem.Text)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListChiTietBaoCaoTon.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListChiTietBaoCaoTon.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ctbct = CType(dgvListChiTietBaoCaoTon.Rows(currentRowIndex).DataBoundItem, CHITIETBAOCAOTONDTO)
                                    txtMaCTBCT.Text = ctbct.MaChiTietBaoCaoTon1
                                    txtMaSach.Text = ctbct.MaSach1
                                    txtSoLuongTonDau.Text = ctbct.TonDau1
                                    txtPhatSinh.Text = ctbct.TonPhatSinh1
                                    txtSoLuongTonCuoi.Text = ctbct.TonCuoi1
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
    End Sub
End Class