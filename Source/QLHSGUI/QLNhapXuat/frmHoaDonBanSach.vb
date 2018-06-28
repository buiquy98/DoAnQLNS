Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class frmHoaDonBanSach
    Private qdbus As QUYDINHBUS
    Private khbus As KHACHHANGBUS
    Private sbus As SACHBUS
    Private hdbus As HoaDonBUS
    Private listsach As List(Of SACHDTO)
    Private Sub frmHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdbus = New QUYDINHBUS()
        hdbus = New HoaDonBUS()
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
            MessageBox.Show("Lấy ID kế tiếp của mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim istrung = False
        Dim listtemp = New List(Of SACHDTO)

        If (frmdg.listSachDuocChon.Count <> 0) Then
            sbus = New SACHBUS

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

            Else
                MessageBox.Show("Chưa chọn sách hoặc bị trùng")
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmdg As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        tbxquidinh1.Text = frmdg.txtLuongTonToiDa.Text
        tbxquidinh2.Text = frmdg.txtTienNoToiDa.Text

    End Sub

    Private Sub dtpngaylap_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaylap.ValueChanged
        If dtpngaylap.Value < DateTime.Now Then
            dtpngaylap.Value = DateTime.Now
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











    End Sub

    Private Sub dgvsach_MouseLeave(sender As Object, e As EventArgs) Handles dgvsach.MouseLeave
        btnlapphieu.Focus()
    End Sub
End Class