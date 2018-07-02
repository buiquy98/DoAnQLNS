Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class frmTraCuuSach

    Private theloaibus As LOAISACHBUS
    Private sbus As SACHBUS
    Private Sub frmTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sbus = New SACHBUS()



        LoadContent()


        theloaibus = New LOAISACHBUS()
        'load the loai 
        Dim listtheloai = New List(Of LOAISACHDTO)
        Dim result As Result
        result = theloaibus.selectAll(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbxtheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbxtheloai.DisplayMember = "Strtenloaisach"
        cbxtheloai.ValueMember = "Imaloaisach"
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


        For index = 0 To 5
            dgvsach.Columns(index).Width = dgvsach.Width / 6
        Next




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
        LoadData()
    End Sub

    Public Function LoadData()
        Dim tlbut = New LOAISACHBUS()
        Dim dstl = New List(Of LOAISACHDTO)
        Dim result As Result
        result = tlbut.selectAll(dstl)



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
        For index = 0 To 5
            dgvsach.Columns(index).Width = dgvsach.Width / 6
        Next
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvsach.DataSource)
        myCurrencyManager.Refresh()

    End Function






    Private Sub loadlistsachbytacgia(tacgia As String)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_ByTacgia(tacgia, listSach)
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

        LoadData()
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
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbxmasach.Text <> "" Then
            Dim ms = tbxmasach.Text
            loadListSach_ByMaLoaiSach(ms)
            Return
        End If

        If tbxtensach.Text <> "" Then
            Dim ts = tbxtensach.Text
            loadListSach_ByTenSach(ts)
            Return
        End If


        If tbxtacgia.Text <> "" Then

            Dim tg = tbxtacgia.Text
            loadlistsachbytacgia(tg)
            Return


        End If

        If cbxtheloai.SelectedValue <> 0 Then

            Dim maloai = cbxtheloai.SelectedValue
            loadListSach_ByTheloai(maloai)
            Return

        End If

        If cboxdongia.Checked Then
            Dim giadau = tbxgia1.Text
            Dim giacuoi = tbxgia2.Text
            loadListSach_ByDonGia(giadau, giacuoi)

        End If



        If cbxslt.Checked Then
            Dim tondau = tbxton1.Text
            Dim toncuoi = tbxton2.Text
            loadListSach_BySLT(tondau, toncuoi)


        End If


    End Sub


    Private Sub loadListSach_ByDonGia(dau As Integer, cuoi As Integer)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_ByDonGia(dau, cuoi, listSach)
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

        LoadData()
    End Sub



    Private Sub loadListSach_ByTheloai(maloai As String)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_ByLoaiSach(maloai, listSach)
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

        LoadData()

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvsach.DataSource)
        myCurrencyManager.Refresh()
    End Sub



    Private Sub loadListSach_BySLT(dau As Integer, cuoi As Integer)
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectALL_BySLT(dau, cuoi, listSach)
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

        LoadData()
    End Sub



    Private Sub tbxtacgia_TextChanged(sender As Object, e As EventArgs) Handles tbxtacgia.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxslt.CheckedChanged

    End Sub

    Private Sub btnall_Click(sender As Object, e As EventArgs) Handles btnall.Click
        LoadContent()
    End Sub
End Class