Public Class LoaiNguoiDungDTO
    Private _strMaLoaiNguoiDung As String
    Private _strTenLoaiNguoiDung As String
    Public Property StrMaLoaiNguoiDung As String
        Get
            Return _strMaLoaiNguoiDung
        End Get
        Set(value As String)
            _strMaLoaiNguoiDung = value
        End Set
    End Property

    Public Sub New()
        StrMaLoaiNguoiDung = 0
        StrTenLoaiNguoiDung = String.Empty
    End Sub
    Public Sub New(maloainguoidung As Integer, tenloainguoidung As String)
        StrMaLoaiNguoiDung = maloainguoidung
        StrTenLoaiNguoiDung = tenloainguoidung
    End Sub

    Public Property StrTenLoaiNguoiDung As String
        Get
            Return _strTenLoaiNguoiDung
        End Get
        Set(value As String)
            _strTenLoaiNguoiDung = value
        End Set
    End Property
End Class
