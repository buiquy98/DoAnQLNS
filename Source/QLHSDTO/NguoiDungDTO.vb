Public Class NguoiDungDTO

    Private _strMaNguoiDung As String
    Private _strHoTenNguoiDung As String
    Private _strTenDangNhap As String
    Private _strMatKhau As String
    Private _strMaLoaiNguoiDung As String


    Public Sub New(manguoidung As String, hoten As String, tendangnhap As String, matkhau As String, maloainguoidung As String)
        Me.StrMaNguoiDung = manguoidung
        Me.StrHoTenNguoiDung = hoten
        Me.StrTenDangNhap = tendangnhap
        Me.StrMatKhau = matkhau
        Me.StrMaLoaiNguoiDung = maloainguoidung

    End Sub






    Public Property StrMaNguoiDung As String
        Get
            Return _strMaNguoiDung
        End Get
        Set(value As String)
            _strMaNguoiDung = value
        End Set
    End Property

    Public Property StrHoTenNguoiDung As String
        Get
            Return _strHoTenNguoiDung
        End Get
        Set(value As String)
            _strHoTenNguoiDung = value
        End Set
    End Property

    Public Property StrTenDangNhap As String
        Get
            Return _strTenDangNhap
        End Get
        Set(value As String)
            _strTenDangNhap = value
        End Set
    End Property

    Public Property StrMatKhau As String
        Get
            Return _strMatKhau
        End Get
        Set(value As String)
            _strMatKhau = value
        End Set
    End Property

    Public Property StrMaLoaiNguoiDung As String
        Get
            Return _strMaLoaiNguoiDung
        End Get
        Set(value As String)
            _strMaLoaiNguoiDung = value
        End Set
    End Property
End Class
