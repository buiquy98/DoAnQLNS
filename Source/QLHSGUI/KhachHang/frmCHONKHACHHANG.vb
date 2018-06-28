Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmCHONKHACHHANG
    Private khBus As KHACHHANGBUS
    Public khdc = New List(Of String)
    Public listkh As List(Of KHACHHANGDTO)
    Private Sub frmCHONKHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KHACHHANGBUS()
        khdc = New List(Of String)

        loadListKH()
    End Sub


    Private Sub loadListKH()
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectAll(listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListKhachHang.SuspendLayout()
        dgvListKhachHang.Columns.Clear()
        dgvListKhachHang.DataSource = Nothing

        dgvListKhachHang.AutoGenerateColumns = False
        dgvListKhachHang.AllowUserToAddRows = False
        dgvListKhachHang.DataSource = listKH

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maKH"
        clMa.HeaderText = "Mã Khách Hàng"
        clMa.DataPropertyName = "maKH1"
        dgvListKhachHang.Columns.Add(clMa)

        Dim clTenKH = New DataGridViewTextBoxColumn()
        clTenKH.Name = "hoTenKH"
        clTenKH.HeaderText = "Họ Tên Khách Hàng"
        clTenKH.DataPropertyName = "hoTenKH1"
        dgvListKhachHang.Columns.Add(clTenKH)



        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)


        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diaChi1"
        dgvListKhachHang.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "email1"
        dgvListKhachHang.Columns.Add(clEmail)

        Dim clSDT = New DataGridViewTextBoxColumn()
        clSDT.Name = "sdt"
        clSDT.HeaderText = "SDT"
        clSDT.DataPropertyName = "sdt1"
        dgvListKhachHang.Columns.Add(clSDT)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListKhachHang.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListKH_ByName(name As String)
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectALL_ByName(name, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListKhachHang.SuspendLayout()
        dgvListKhachHang.Columns.Clear()
        dgvListKhachHang.DataSource = Nothing

        dgvListKhachHang.AutoGenerateColumns = False
        dgvListKhachHang.AllowUserToAddRows = False
        dgvListKhachHang.DataSource = listKH

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maKH"
        clMa.HeaderText = "Mã Khách Hàng"
        clMa.DataPropertyName = "maKH1"
        dgvListKhachHang.Columns.Add(clMa)

        Dim clTenKH = New DataGridViewTextBoxColumn()
        clTenKH.Name = "hoTenKH"
        clTenKH.HeaderText = "Họ Tên Khách Hàng"
        clTenKH.DataPropertyName = "hoTenKH1"
        dgvListKhachHang.Columns.Add(clTenKH)

        'Dim clLoaikh= New DataGridView()

        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)
        'dgvListKhachHang.ResumeLayout()

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diaChi1"
        dgvListKhachHang.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "email1"
        dgvListKhachHang.Columns.Add(clEmail)

        Dim clSDT = New DataGridViewTextBoxColumn()
        clSDT.Name = "sdt"
        clSDT.HeaderText = "SDT"
        clSDT.DataPropertyName = "sdt1"
        dgvListKhachHang.Columns.Add(clSDT)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListKhachHang.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub loadListKH_ByMaKH(makh As String)
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectALL_ByType(makh, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListKhachHang.SuspendLayout()
        dgvListKhachHang.Columns.Clear()
        dgvListKhachHang.DataSource = Nothing

        dgvListKhachHang.AutoGenerateColumns = False
        dgvListKhachHang.AllowUserToAddRows = False
        dgvListKhachHang.DataSource = listKH

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maKH"
        clMa.HeaderText = "Mã Khách Hàng"
        clMa.DataPropertyName = "maKH1"
        dgvListKhachHang.Columns.Add(clMa)

        Dim clTenKH = New DataGridViewTextBoxColumn()
        clTenKH.Name = "hoTenKH"
        clTenKH.HeaderText = "Họ Tên Khách Hàng"
        clTenKH.DataPropertyName = "hoTenKH1"
        dgvListKhachHang.Columns.Add(clTenKH)

        'Dim clLoaikh= New DataGridView()

        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)
        'dgvListKhachHang.ResumeLayout()

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diaChi1"
        dgvListKhachHang.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "email1"
        dgvListKhachHang.Columns.Add(clEmail)

        Dim clSDT = New DataGridViewTextBoxColumn()
        clSDT.Name = "sdt"
        clSDT.HeaderText = "SDT"
        clSDT.DataPropertyName = "sdt1"
        dgvListKhachHang.Columns.Add(clSDT)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListKhachHang.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btTimKiemTheoMAKH_Click(sender As Object, e As EventArgs) Handles btTimKiemTheoMAKH.Click
        Try
            Dim makh = txtMaKHTimKiem.Text
            loadListKH_ByMaKH(makh)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btTimKiemTheHoTen_Click(sender As Object, e As EventArgs) Handles btTimKiemTheHoTen.Click
        Try
            Dim name = txtHoTenKHTimKiem.Text
            loadListKH_ByName(name)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnchon_Click(sender As Object, e As EventArgs) Handles btnchon.Click
        If khdc.Count <> 0 Then
            khdc.Clear()
        End If

        Dim index = dgvListKhachHang.CurrentRow.Cells(0).Value
        khdc.Add(index)
        Me.Close()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub btnall_Click(sender As Object, e As EventArgs) Handles btnall.Click
        loadListKH()
    End Sub
End Class