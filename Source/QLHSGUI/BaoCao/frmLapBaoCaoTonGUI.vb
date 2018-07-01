Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmLapBaoCaoTonGUI
    Private bctbus As BAOCAOTONBUS
    Private ctbctbus As CHITIETBAOCAOTONBUS
    Private Sub nudnam_ValueChanged(sender As Object, e As EventArgs) Handles nudnam.ValueChanged

    End Sub

    Private Sub frmLapBaoCaoTonGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudnam.Maximum = 1
        nudnam.Maximum = 10000
        nudthang.Minimum = 1
        nudthang.Maximum = 12
        nudnam.Value = DateTime.Now().Year()
        nudthang.Value = DateTime.Now().Month()

        bctbus = New BAOCAOTONBUS()
        ctbctbus = New CHITIETBAOCAOTONBUS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Lấy mã bc theo tháng và năm
        Dim listbct = New List(Of BAOCAOTONDTO)
        Dim result As Result
        Dim thang = nudthang.Value
        Dim nam = nudnam.Value
        result = bctbus.selectAll_byThang(thang, nam, listbct)
        If listbct.Count = 0 Then
            MessageBox.Show("Không có Đầu sách nào được nhập hay bán trong tháng")
            Return
        End If
        Dim listctbtt = New List(Of CHITIETBAOCAOTONDTO)
        result = ctbctbus.selectAll_byMaBaoCaoTon(listbct(0).MaBaoCaoTon1, listctbtt)


        dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listctbtt


        Dim clStt = New DataGridViewTextBoxColumn()
        clStt.Name = ""
        clStt.HeaderText = "STT"
        clStt.DataPropertyName = ""
        dgvsach.Columns.Add(clStt)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "MaSach1"
        clTenSach.HeaderText = "Mã sách"
        clTenSach.DataPropertyName = "MaSach1"
        dgvsach.Columns.Add(clTenSach)

        Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
        clMaLoaiSach.Name = "tonDau1"
        clMaLoaiSach.HeaderText = "Tồn đầu"
        clMaLoaiSach.DataPropertyName = "tonDau1"
        dgvsach.Columns.Add(clMaLoaiSach)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "tonPhatSinh1"
        clTacGia.HeaderText = "Tồn phát sinh"
        clTacGia.DataPropertyName = "tonPhatSinh1"
        dgvsach.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "tonCuoi1"
        clSoLuongTon.HeaderText = "Tồn cuối"
        clSoLuongTon.DataPropertyName = "tonCuoi1"
        dgvsach.Columns.Add(clSoLuongTon)

        For index = 0 To dgvsach.RowCount - 1
            dgvsach.Rows(index).Cells(0).Value = index + 1
            ' dgvsach.Rows(index).Cells(8).Value = 0
        Next



    End Sub
End Class