Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class FrmPhieuNhapSach

    Dim pnbus As PHIEUNHAPBUS
    Dim ctpnbus As CHITIETPHIEUNHAPBUS
    Private sbus As SACHBUS
    Private listsach As List(Of SACHDTO)
    Private qdbus As QUYDINHBUS
    Private ctbctbus As CHITIETBAOCAOTONBUS
    Private bctbus As BAOCAOTONBUS
    Private Sub FrmPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContent()
        listsach = New List(Of SACHDTO)
        sbus = New SACHBUS()
        Dim listqd As List(Of QUYDINHDTO)
        listqd = New List(Of QUYDINHDTO)
        qdbus.selectAll(listqd)
        ctpnbus = New CHITIETPHIEUNHAPBUS()
        bctbus = New BAOCAOTONBUS()
        ctbctbus = New CHITIETBAOCAOTONBUS()
    End Sub


    Public Function LoadContent()


        pnbus = New PHIEUNHAPBUS
        ctpnbus = New CHITIETPHIEUNHAPBUS
        LoadQuiDinh()
        Dim nextID As Integer
        Dim result As Result
        result = pnbus.buildmaPN(nextID)
        If (result.FlagResult = True) Then
            tbxmaphieunhap.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        btnluu.Enabled = False





        Dim listsach = New List(Of SACHDTO)

    End Function


    Private Function CapNhatLaiSachTon()
        Try
            Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
            Dim sach As SACHDTO
            sach = New SACHDTO()

            '1. Mapping data from GUI control
            sach.Imaloaisach = tbxmasach.Text
            sach.Isoluongton = dgvsach.Rows(currentRowIndex).Cells(6).Value
            '2. Business .....
            '3. Insert to DB
            Dim result As Result
            result = sbus.update_SoLuongTon(sach)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function

    Private istrung As Boolean
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim frmdg As frmCHONSACH = New frmCHONSACH()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        istrung = False
        Dim listtemp = New List(Of SACHDTO)

        If (frmdg.listSachDuocChon.Count <> 0) Then


            Dim result As Result
            result = sbus.selectALL_ByMaSach(frmdg.listSachDuocChon(0), listtemp)
            listsach.AddRange(listtemp)

            'check trùng
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


                '  dgvsach.DataSource = Nothing
                dgvsach.Columns.Clear()
                dgvsach.AutoGenerateColumns = False
                dgvsach.AllowUserToAddRows = False
                dgvsach.DataSource = listsach

                btnluu.Enabled = True
                Dim clSTT = New DataGridViewTextBoxColumn()
                clSTT.Name = ""
                clSTT.HeaderText = "STT"
                clSTT.DataPropertyName = ""
                dgvsach.Columns.Add(clSTT)

                Dim clMaSach = New DataGridViewTextBoxColumn()
                clMaSach.Name = "Imasach"
                clMaSach.HeaderText = "Mã Sách"
                clMaSach.DataPropertyName = "Imasach"
                dgvsach.Columns.Add(clMaSach)

                Dim clTenSach = New DataGridViewTextBoxColumn()
                clTenSach.Name = "Strtensach"
                clTenSach.HeaderText = "Tên sách"
                clTenSach.DataPropertyName = "Strtensach"
                dgvsach.Columns.Add(clTenSach)

                Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
                clMaLoaiSach.Name = "Imaloaisach"
                clMaLoaiSach.HeaderText = "Thể loại"
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


                Dim clSoLuongNhap = New DataGridViewTextBoxColumn()
                clSoLuongNhap.HeaderText = "Số lượng nhập"
                dgvsach.Columns.Add(clSoLuongNhap)


                For index = 0 To dgvsach.RowCount - 1
                    dgvsach.Rows(index).Cells(0).Value = index + 1
                Next


                For index = 0 To 5
                    dgvsach.Columns(index).ReadOnly = True

                Next
            Else
                MessageBox.Show("Chưa chọn sách hoặc bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Else
            MessageBox.Show("Chưa chọn sách")
        End If




    End Sub
    Dim quydinh As QUYDINHDTO
    Private Function LoadQuiDinh()
        qdbus = New QUYDINHBUS()
        ' Dim quydinh = New QUYDINHDTO
        Dim listQuyDinh = New List(Of QUYDINHDTO)
        Dim result = qdbus.selectAll(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)

        tbxquidinh1.Text = quydinh.LuongNhapToiThieu1
        tbxquidinh2.Text = quydinh.LuongTonToiDa1
        tbxquidinh1.Enabled = False
        tbxquidinh2.Enabled = False
    End Function

    Private Sub dgvsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvsach.SelectionChanged
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Try
                Dim tl = CType(dgvsach.Rows(currentRowIndex).DataBoundItem, SACHDTO)
                tbxmasach.Text = tl.Imasach
                Dim a = dgvsach.SelectedRows
                tbxsoluongnhap.Text = dgvsach.Rows(currentRowIndex).Cells(6).Value
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub tbxsoluongnhap_TextChanged(sender As Object, e As EventArgs) Handles tbxsoluongnhap.TextChanged
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK

        dgvsach.Rows(currentRowIndex).Cells(6).Value = tbxsoluongnhap.Text

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected

        dgvsach.Rows.RemoveAt(currentRowIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        Dim  soluongnhaptoithieu = quydinh.LuongNhapToiThieu1
        Dim soluongnhaptoida = quydinh.LuongTonToiDa1



        For index = 0 To dgvsach.RowCount() - 1
            If dgvsach.Rows(index).Cells(6).Value = "" Then
                MessageBox.Show("Chưa nhập số lượng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim soluongnhap = Integer.Parse(dgvsach.Rows(index).Cells(6).Value)
            If soluongnhap < soluongnhaptoithieu Or soluongnhap > soluongnhaptoida Then
                MessageBox.Show("Số lượng nhập vào không thỏa Quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next








        Dim pndto = New PHIEUNHAPDTO()
                pndto.Imaphieunhap = tbxmaphieunhap.Text
                'Thêm chi tiết phiếu nhập và cập nhật lượng tồn mới trong sách
                Dim chiTietPhieuNhapDTO As New CHITIETPHIEUNHAPDTO
                pndto.Datengaynhap = dtpngaynhap.Text
                pnbus.insert(pndto)


        If dgvsach.RowCount <> 0 Then
            'new ma bct
            Dim bct As BAOCAOTONDTO
            bct = New BAOCAOTONDTO()

            'Load báo cáo tồn nếu tháng bị trùng sẽ không phát sinh thêm ID
            Dim listbct = New List(Of BAOCAOTONDTO)
            Dim thang = Integer.Parse(dtpngaynhap.Value.Month())
            Dim nam = Integer.Parse(dtpngaynhap.Value.Year())

            Dim result As Result
            result = bctbus.selectAll_byThang(thang, nam, listbct)
            If listbct.Count <> 0 Then
                bct.MaBaoCaoTon1 = listbct(0).MaBaoCaoTon1
                bct.Thang1 = thang
                bct.Nam1 = nam
            Else
                Dim nextid As Integer
                result = bctbus.getNextID(nextid)
                bct.MaBaoCaoTon1 = nextid
                bct.Nam1 = nam
                bct.Thang1 = thang
                result = bctbus.insert(bct)
                If result.FlagResult = False Then
                    MessageBox.Show("Lỗi")
                    Return
                End If
            End If
            For index = 0 To dgvsach.RowCount - 1
                chiTietPhieuNhapDTO = New CHITIETPHIEUNHAPDTO()
                Dim ctbct = New CHITIETBAOCAOTONDTO()
                Dim nextID As Integer
                result = ctpnbus.getNextID(nextID)
                If (result.FlagResult = True) Then
                Else
                    MessageBox.Show("Lấy ID kế tiếp của mã CT phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
                Dim sachDTO As New SACHDTO()

                'chiTietPhieuNhapDTO.Imachitietphieunhap =
                sachDTO.Imasach = dgvsach.Rows(index).Cells(1).Value
                sachDTO.Isoluongton = dgvsach.Rows(index).Cells(5).Value + dgvsach.Rows(index).Cells(6).Value
                sbus.update_SoLuongTon(sachDTO)


                ' cập nhật chi tiết phiếu nhập cho mỗi đầu sách thêm vào phiếu nhập

                chiTietPhieuNhapDTO.Imachitietphieunhap = nextID
                chiTietPhieuNhapDTO.Imaphieunhap = sachDTO.Imasach
                chiTietPhieuNhapDTO.Imasach = sachDTO.Imasach
                chiTietPhieuNhapDTO.Isoluongnhap = dgvsach.Rows(index).Cells(6).Value
                ctpnbus.insert(chiTietPhieuNhapDTO)

                'Cập nhật vào báo cáo tồn

                ctbct.MaBaoCaoTon1 = bct.MaBaoCaoTon1

                ctbct.MaSach1 = sachDTO.Imasach
                ctbct.MaBaoCaoTon1 = bct.MaBaoCaoTon1
                ctbct.TonCuoi1 = sachDTO.Isoluongton
                ctbct.TonDau1 = dgvsach.Rows(index).Cells(5).Value
                ctbct.TonPhatSinh1 = dgvsach.Rows(index).Cells(6).Value

                ' Load list chi tiet bao cao ton,  kt xem neu sach da co thi cap nhat lai ton dau ton phat sinh va ton cuoi
                Dim trung = False
                Dim lsctbct = New List(Of CHITIETBAOCAOTONDTO)

                result = ctbctbus.selectAll(lsctbct)
                For temp = 0 To lsctbct.Count - 1
                    'MS đã có trước đó, cập nhật lại 
                    If ctbct.MaBaoCaoTon1 = lsctbct(temp).MaBaoCaoTon1 And ctbct.MaSach1 = lsctbct(temp).MaSach1 Then
                        ctbct.MaChiTietBaoCaoTon1 = lsctbct(temp).MaChiTietBaoCaoTon1
                        ctbct.TonDau1 = lsctbct(temp).TonDau1
                        ctbct.TonPhatSinh1 = lsctbct(temp).TonPhatSinh1 + Integer.Parse(dgvsach.Rows(index).Cells(6).Value)
                        ctbct.TonCuoi1 = ctbct.TonDau1 + ctbct.TonPhatSinh1
                        result = ctbctbus.updatect(ctbct)
                        If result.FlagResult = False Then
                            MessageBox.Show("Lỗi")
                            Return
                        End If
                        trung = True
                    End If
                Next
                ' nếu k có sẵn thì add vào 
                If trung = False Then
                    Dim idctbct As Integer
                    result = ctbctbus.getNextID(idctbct)
                    ctbct.MaChiTietBaoCaoTon1 = idctbct
                    result = ctbctbus.insert(ctbct)
                    If result.FlagResult = False Then
                        MessageBox.Show("Lỗi")
                        Return
                    End If
                End If
            Next
        End If
        MessageBox.Show("Lập Phiếu nhập thành công")
        btnluu.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmdg As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        tbxquidinh1.Text = frmdg.txtLuongNhapToiThieu.Text
        tbxquidinh2.Text = frmdg.txtLuongTonToiDa.Text

    End Sub

    Private Sub dtpngaynhap_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaynhap.ValueChanged
        If dtpngaynhap.Value < DateTime.Now Then
            dtpngaynhap.Value = DateTime.Now
        End If
    End Sub
End Class