Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmLapBaoCaoCongNoGui
    Private bccnbus As BAOCAOCONGNOBUS
    Private ctbcbus As CHITIETBAOCAOCONGNOBUS
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nudnam.Value = DateTime.Now().Year()
        nudthang.Value = DateTime.Now().Month()
        bccnbus = New BAOCAOCONGNOBUS()
        ctbcbus = New CHITIETBAOCAOCONGNOBUS
        Dim listbct = New List(Of BAOCAOCONGNODTO)
        Dim result As Result
        Dim thang = nudthang.Value
        Dim nam = nudnam.Value
        result = bccnbus.selectAll_byThang(thang, nam, listbct)
        If listbct.Count = 0 Then
            MessageBox.Show("Không có Đầu sách nào được nhập hay bán trong tháng")
            Return
        End If
        Dim listctbtt = New List(Of CHITIETBAOCAOCONGNODTO)
        result = ctbcbus.selectAll_byMaBaoCao(listbct(0).MaBaoCaoCongNo1, listctbtt)


        dgvkh.DataSource = Nothing
        dgvkh.Columns.Clear()
        dgvkh.AutoGenerateColumns = False
        dgvkh.AllowUserToAddRows = False
        dgvkh.DataSource = listctbtt


        Dim clStt = New DataGridViewTextBoxColumn()
        clStt.Name = ""
        clStt.HeaderText = "STT"
        clStt.DataPropertyName = ""
        dgvkh.Columns.Add(clStt)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "MaKH1"
        clTenSach.HeaderText = "Mã khách hàng"
        clTenSach.DataPropertyName = "MaKH1"
        dgvkh.Columns.Add(clTenSach)

        Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
        clMaLoaiSach.Name = "NoDau1"
        clMaLoaiSach.HeaderText = "Nợ đầu"
        clMaLoaiSach.DataPropertyName = "NoDau1"
        dgvkh.Columns.Add(clMaLoaiSach)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "NoPhatSinh1"
        clTacGia.HeaderText = "Nợ phát sinh"
        clTacGia.DataPropertyName = "NoPhatSinh1"
        dgvkh.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "NoCuoi1"
        clSoLuongTon.HeaderText = "Nợ cuối"
        clSoLuongTon.DataPropertyName = "NoCuoi1"
        dgvkh.Columns.Add(clSoLuongTon)

        For index = 0 To dgvkh.RowCount - 1
            dgvkh.Rows(index).Cells(0).Value = index + 1
            ' dgvkh.Rows(index).Cells(8).Value = 0
        Next
    End Sub

    Private Sub frmLapBaoCaoCongNoGui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudnam.Maximum = 1
        nudnam.Maximum = 10000
        nudthang.Minimum = 1
        nudthang.Maximum = 12


    End Sub
End Class