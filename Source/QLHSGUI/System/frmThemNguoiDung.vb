Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class frmThemNguoiDung
    Private lndbus As LOAINGUOIDUNGBUS
    Private ndbus As NGUOIDUNGBUS
    Private Sub frmThemNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lndbus = New LOAINGUOIDUNGBUS()
        ndbus = New NGUOIDUNGBUS()
        'load the loai 
        Dim listloainguoidung = New List(Of LoaiNguoiDungDTO)
        Dim result As Result
        result = lndbus.selectAll(listloainguoidung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbxloainguoidung.DataSource = New BindingSource(listloainguoidung, String.Empty)
        cbxloainguoidung.DisplayMember = "StrtenLoaiNguoiDung"
        cbxloainguoidung.ValueMember = "StrMaLoaiNguoiDung"
        cbxloainguoidung.SelectedIndex = 4
        Dim nextID As Integer
        result = ndbus.getnextID(nextID)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If



        tbxmand.Text = nextID



    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If tbxtdn.Text = "" Then
            MessageBox.Show("Chưa tạo tên đăng nhập cho tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If tbxpass.Text = "" Then
            MessageBox.Show("Chưa nhập mật khẩu", "Lối", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbxloainguoidung.SelectedValue = 2 Then
            MessageBox.Show("Không thể tạo người dùng là khách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim result As Result
        Dim listnd = New List(Of NguoiDungDTO)
        result = ndbus.selectAll(listnd)
        If result.FlagResult = False Then
            MessageBox.Show("Lỗi khi lấy list người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        For index = 0 To listnd.Count - 1
            If tbxtdn.Text = listnd(index).StrTenDangNhap Then
                MessageBox.Show("Tên đăng nhập bị trùng vui lòng đặt tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        Dim ndmoi As NguoiDungDTO
        ndmoi = New NguoiDungDTO()
        ndmoi.StrMaNguoiDung = tbxmand.Text
        ndmoi.StrHoTenNguoiDung = tbxten.Text
        ndmoi.StrTenDangNhap = tbxtdn.Text
        ndmoi.StrMatKhau = tbxpass.Text
        ndmoi.StrMaLoaiNguoiDung = cbxloainguoidung.SelectedValue

        result = ndbus.insert(ndmoi)
        If result.FlagResult = False Then
            MessageBox.Show("Thêm người dùng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        MessageBox.Show("Thêm Người dùng thành công")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxmand.TextChanged

    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub
End Class