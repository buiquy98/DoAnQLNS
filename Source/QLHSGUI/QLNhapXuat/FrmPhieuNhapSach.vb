Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class FrmPhieuNhapSach

    Dim pnbus As PHIEUNHAPBUS
    Dim ctpnbus As CHITIETPHIEUNHAPDTO
    Private sbus As SACHBUS
    Private listsach As List(Of SACHDTO)
    Private Sub FrmPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContent()
        listsach = New List(Of SACHDTO)
        sbus = New SACHBUS()


    End Sub


    Public Function LoadContent()

        Dim result As Result
        pnbus = New PHIEUNHAPBUS
        Dim quidinh As QUYDINHDTO
        quidinh = New QUYDINHDTO()
        Dim nextID As Integer

        result = pnbus.buildmaPN(nextID)
        If (result.FlagResult = True) Then
            tbxmaphieunhap.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        tbxquidinh2.Enabled = tbxquidinh1.Enabled = False
        tbxquidinh1.Text = quidinh.LuongNhapToiThieu1.ToString()
        tbxquidinh2.Text = quidinh.LuongTonToiDa1
        Dim listsach = New List(Of SACHDTO)

    End Function

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim frmdg As frmCHONSACH = New frmCHONSACH()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        Dim listtemp = New List(Of SACHDTO)

        If (frmdg.listSachDuocChon.Count <> 0) Then


            Dim result As Result
            result = sbus.selectALL_ByMaSach(frmdg.listSachDuocChon(0), listtemp)
        End If

        listsach.AddRange(listtemp)

        'check trùng




        '  dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach


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



    End Sub

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
        dgvsach.AllowUserToDeleteRows = True

        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        dgvsach.Rows.RemoveAt(dgvsach.SelectedRows(0).Index)
        'dgvsach.Rows.Remove(dgvsach.Rows(currentRowIndex))

    End Sub
End Class