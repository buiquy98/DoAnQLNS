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

    Public Property StrTenLoaiNguoiDung As String
        Get
            Return _strTenLoaiNguoiDung
        End Get
        Set(value As String)
            _strTenLoaiNguoiDung = value
        End Set
    End Property
End Class
