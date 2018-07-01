Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class frmHoaDonBanSach
    Private qdbus As QUYDINHBUS
    Private khbus As KHACHHANGBUS
    Private cthdbus As CHITIETHOADONBUS
    Private sbus As SACHBUS
    Private hdbus As HoaDonBUS
    Private listsach As List(Of SACHDTO)
    Private Sub frmHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdbus = New QUYDINHBUS()

        hdbus = New HoaDonBUS()
        cthdbus = New CHITIETHOADONBUS()
        LoadQuiDinh()
        LoadContent()

    End Sub


    Private Function LoadContent()
        listsach = New List(Of SACHDTO)
        Dim nextID As Integer
        Dim result As Result
        result = hdbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbxmaphieu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Function

    Private Function LoadQuiDinh()
        Dim quydinh As QUYDINHDTO
        qdbus = New QUYDINHBUS()
        ' Dim quydinh = New QUYDINHDTO
        Dim listQuyDinh = New List(Of QUYDINHDTO)
        Dim result = qdbus.selectAll(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        tbxquidinh1.Text = quydinh.LuongTonToiThieu1
        tbxquidinh2.Text = quydinh.TienNoToiDa1


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        khbus = New KHACHHANGBUS()
        Dim frmdg As frmCHONKHACHHANG = New frmCHONKHACHHANG()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()

        Dim kh = New List(Of KHACHHANGDTO)

        If (frmdg.khdc.Count <> 0) Then


            Dim result As Result
            result = khbus.selectALL_ByType(frmdg.khdc(0), kh)
            txtMaKH.Text = kh(0).MaKH1
            txtHoTenKH.Text = kh(0).HoTenKH1
            txtDiaChi.Text = kh(0).DiaChi1
            txtSDT.Text = kh(0).Sdt1
            btnlapphieu.Enabled = True
            tbxsotienno.Text = kh(0).TienNoKH1
        Else
            MessageBox.Show("Chưa chọn khách hàng")
        End If

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim frmdg As frmCHONSACH = New frmCHONSACH()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        If (frmdg.listSachDuocChon.Count <> 0) Then
            sbus = New SACHBUS
            Dim istrung = False
            Dim listtemp = New List(Of SACHDTO)
            Dim result As Result
            result = sbus.selectALL_ByMaSach(frmdg.listSachDuocChon(0), listtemp)
            listsach.AddRange(listtemp)

            'check trùng
            For i = 0 To listsach.Count - 2
                For j = i + 1 To listsach.Count - 1
                    If listsach(i).Imasach = listsach(j).Imasach Then
                        istrung = True
                        listsach.RemoveAt(j)
                    End If
                Next
            Next

            If istrung = False Then
                LoadDataGridSach()
            Else

                MessageBox.Show("Chưa chọn sách hoặc bị trùng")
            End If
        End If

    End Sub



    Public Function LoadDataGridSach()


        dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach


        Dim clStt = New DataGridViewTextBoxColumn()
                clStt.Name = ""
                clStt.HeaderText = "STT"
                clStt.DataPropertyName = ""
                dgvsach.Columns.Add(clStt)


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
                clMaLoaiSach.HeaderText = "Thể Loại"
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

                Dim clslnhap = New DataGridViewTextBoxColumn()
                clslnhap.Name = ""
                clslnhap.HeaderText = "Số lượng"
                clslnhap.DataPropertyName = ""
                dgvsach.Columns.Add(clslnhap)


                Dim clthanhtien = New DataGridViewTextBoxColumn()
                clthanhtien.Name = ""
                clthanhtien.HeaderText = "Thành tiền"
                clthanhtien.DataPropertyName = ""
                dgvsach.Columns.Add(clthanhtien)


                dgvsach.Columns(0).Width = 50
                dgvsach.Columns(1).Width = 50
                dgvsach.Columns(7).Width = 50
                For index = 0 To dgvsach.RowCount - 1
                    dgvsach.Rows(index).Cells(0).Value = index + 1
                    dgvsach.Rows(index).Cells(8).Value = 0
                Next


                For index = 0 To 6
                    dgvsach.Columns(index).ReadOnly = True

                Next
        dgvsach.Columns(8).ReadOnly = True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmdg As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        tbxquidinh1.Text = frmdg.txtLuongTonToiThieu.Text
        tbxquidinh2.Text = frmdg.txtTienNoToiDa.Text

    End Sub

    Private Sub dtpngaylap_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaynhap.ValueChanged
        If dtpngaynhap.Value < DateTime.Now Then
            dtpngaynhap.Value = DateTime.Now
        End If
    End Sub

    Private Sub dgvsach_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsach.CellEndEdit

    End Sub

    Private Sub dgvsach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsach.CellValueChanged
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK

        dgvsach.Rows(currentRowIndex).Cells(8).Value = dgvsach.Rows(currentRowIndex).Cells(6).Value * dgvsach.Rows(currentRowIndex).Cells(7).Value
        Dim sum = 0
        For index = 0 To dgvsach.RowCount - 1
            sum += dgvsach.Rows(index).Cells(8).Value
        Next
        tbxtongtien.Text = sum
    End Sub
    Private Sub dgvsach_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvsach.CellBeginEdit


    End Sub

    Private Sub btnlapphieu_Click(sender As Object, e As EventArgs) Handles btnlapphieu.Click
        If txtHoTenKH.Text = "" Or tbxtongtien.Text = "" Or dgvsach.RowCount() = 0 Then
            MessageBox.Show("Chưa chọn khách hàng hoặc sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Dim SoLuongTonToiThieuSauKhiBan = Integer.Parse(tbxquidinh1.Text)
        Dim TienNoToiDaCuaKhachHang = Integer.Parse(tbxquidinh2.Text)
        Dim TienNoHienTai = Integer.Parse(tbxsotienno.Text)

        If TienNoHienTai > TienNoToiDaCuaKhachHang Then
            MessageBox.Show("Tiền nợ khách hàng vượt quá số tiền nợ tối đa cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        For index = 0 To dgvsach.RowCount - 1
            Dim soLuongTonHienTai = Integer.Parse(dgvsach.Rows(index).Cells(5).Value) - Integer.Parse(dgvsach.Rows(index).Cells(7).Value)
            If soLuongTonHienTai < SoLuongTonToiThieuSauKhiBan Then
                MessageBox.Show("Số lượng tồn sau khi bán nhỏ hơn số lượng tồn tối đa cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        Next



        'Không bị chặn bởi 2 ông trên


        Dim hd As HoaDonDTO
        hd = New HoaDonDTO
        hd.MaHoaDon = tbxmaphieu.Text
        hd.NgayHoaDon = dtpngaynhap.Value
        hd.MaKhachHang = txtMaKH.Text
        hd.TongTriGia = tbxtongtien.Text
        Dim result As Result
        result = hdbus.insert(hd)
        If result.FlagResult = True Then

        Else
            MessageBox.Show("Thêm hóa đơn không thành công")
            Return
        End If

        Dim lkh As List(Of KHACHHANGDTO)
        lkh = New List(Of KHACHHANGDTO)
        Dim khbus = New KHACHHANGBUS
        khbus.selectALL_ByType(txtMaKH.Text, lkh)


        lkh(0).TienNoKH1 = Integer.Parse(tbxtongtien.Text) + Integer.Parse(tbxsotienno.Text)
        khbus.update(lkh(0))




        'new ma bct
        ' Kiểm tra mã tháng báo cáo

        Dim bct As BAOCAOTONDTO
        bct = New BAOCAOTONDTO()
        Dim bctbus = New BAOCAOTONBUS
        'Load báo cáo tồn nếu tháng bị trùng sẽ không phát sinh thêm ID
        Dim listbct = New List(Of BAOCAOTONDTO)
        Dim thang = Integer.Parse(dtpngaynhap.Value.Month())
        Dim nam = Integer.Parse(dtpngaynhap.Value.Year())

        result = bctbus.selectAll_byThang(thang, nam, listbct)
        If listbct.Count <> 0 Then
            bct.MaBaoCaoTon1 = listbct(0).MaBaoCaoTon1
            bct.Thang1 = thang
            bct.Nam1 = nam
        Else
            Dim nextidt As Integer
            result = bctbus.getNextID(nextidt)
            bct.MaBaoCaoTon1 = nextidt
            bct.Nam1 = nam
            bct.Thang1 = thang
            result = bctbus.insert(bct)
            If result.FlagResult = False Then
                MessageBox.Show("Lỗi")
                Return
            End If
        End If




        For index = 0 To dgvsach.RowCount - 1

            Dim ctbct = New CHITIETBAOCAOTONDTO()

            ctbct.MaBaoCaoTon1 = bct.MaBaoCaoTon1

            Dim ctbctbus = New CHITIETBAOCAOTONBUS
            Dim CThd = New CHITIETHOADONDTO()
            Dim nextID As Integer

            result = cthdbus.getNextID(nextID)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Lấy ID kế tiếp của mã CT Hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            Dim sachDTO As New SACHDTO()

            'chiTietPhieuNhapDTO.Imachitietphieunhap =
            sachDTO.Imasach = dgvsach.Rows(index).Cells(1).Value
            sachDTO.Isoluongton = dgvsach.Rows(index).Cells(5).Value - dgvsach.Rows(index).Cells(7).Value
            sbus.update_SoLuongTon(sachDTO)
            ctbct.MaSach1 = sachDTO.Imasach

            ' Load list chi tiet bao cao ton,  kt xem neu sach da co thi cap nhat lai ton dau ton phat sinh va ton cuoi
            Dim trung = False
            Dim lsctbct = New List(Of CHITIETBAOCAOTONDTO)

            result = ctbctbus.selectAll(lsctbct)
            For temp = 0 To lsctbct.Count - 1
                'MS đã có trước đó, cập nhật lại 
                If ctbct.MaBaoCaoTon1 = lsctbct(temp).MaBaoCaoTon1 And ctbct.MaSach1 = lsctbct(temp).MaSach1 Then
                    ctbct.MaChiTietBaoCaoTon1 = lsctbct(temp).MaChiTietBaoCaoTon1
                    ctbct.TonDau1 = lsctbct(temp).TonDau1
                    ctbct.TonPhatSinh1 = lsctbct(temp).TonPhatSinh1 - dgvsach.Rows(index).Cells(7).Value
                    ctbct.TonCuoi1 = sachDTO.Isoluongton
                    result = ctbctbus.updatect(ctbct)
                    If result.FlagResult = False Then
                        MessageBox.Show("Lỗi")
                        Return
                    End If
                End If
            Next



            CThd.MaChiTietHoaDon1 = nextID
            CThd.MaHoaDon1 = tbxmaphieu.Text
            CThd.MaSach1 = dgvsach.Rows(index).Cells(1).Value
            CThd.SoLuongBan1 = dgvsach.Rows(index).Cells(7).Value
            CThd.ThanhTien1 = dgvsach.Rows(index).Cells(8).Value
            CThd.DonGiaBan1 = dgvsach.Rows(index).Cells(6).Value

            result = cthdbus.insert(CThd)








            If result.FlagResult = True Then
            Else
                MessageBox.Show("Thêm chi tiết hóa đơn k thành công")
                Return
            End If

        Next

        MessageBox.Show("Thêm hóa đơn thành công", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)


        btnlapphieu.Enabled = False
        btnphieumoi.Enabled = True
        btnthem.Enabled = False
        Button1.Enabled = False
        dgvsach.Controls.Clear()
    End Sub

    Private Sub dgvsach_MouseLeave(sender As Object, e As EventArgs) Handles dgvsach.MouseLeave
        btnlapphieu.Focus()
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub dgvsach_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvsach.CellValidating
        If e.ColumnIndex = 7 Then
            If IsNumeric(e.FormattedValue) = False Then
                MessageBox.Show(" Nhập sai định dạng")

                dgvsach.CurrentCell.Value = 0
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnphieumoi_Click(sender As Object, e As EventArgs) Handles btnphieumoi.Click
        btnthem.Enabled = True
        Button1.Enabled = True
        btnphieumoi.Enabled = False
        btnlapphieu.Enabled = True
        tbxmaphieu.Clear()
        txtDiaChi.Clear()
        txtHoTenKH.Clear()
        txtMaKH.Clear()
        txtSDT.Clear()

        Dim nextID As Integer
        Dim result As Result
        result = hdbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbxmaphieu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y
        'dgvsach.Rows.Remove(dgvsach.Rows(currentRowIndex))
        Dim MScanXoa = dgvsach.Rows(currentRowIndex).Cells(1).Value
        Dim ms = 0
        For index = 0 To listsach.Count() - 1
            If listsach(index).Imasach = MScanXoa Then
                ms = index
            End If

        Next

        listsach.RemoveAt(ms)
        LoadDataGridSach()

    End Sub

    Private Sub dgvsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsach.CellContentClick

    End Sub
End Class