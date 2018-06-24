Public Class HoaDonDTO
    Private iMaHD As Integer
    Private dateNgayHoaDon As DateTime
    Private iMaKH As Integer
    Private iTongTriGia As Integer

    Public Sub New()

    End Sub

    Public Sub New(iMaHD As Integer, dateNgayHoaDon As DateTime, iMaKH As Integer, iTongTriGia As Integer)
        Me.iMaHD = iMaHD
        Me.NgayHoaDon = dateNgayHoaDon
        Me.iMaKH = iMaKH
        Me.iTongTriGia = iTongTriGia
    End Sub

    Property MaHoaDon() As Integer
        Get
            Return iMaHD
        End Get
        Set(ByVal Value As Integer)
            iMaHD = Value
        End Set
    End Property

    Property NgayHoaDon() As DateTime
        Get
            Return dateNgayHoaDon
        End Get
        Set(ByVal value As DateTime)
            dateNgayHoaDon = value
        End Set
    End Property

    Property MaKhachHang() As Integer
        Get
            Return iMaKH
        End Get
        Set(ByVal Value As Integer)
            iMaKH = Value
        End Set
    End Property

    Property TongTriGia() As Integer
        Get
            Return iTongTriGia
        End Get
        Set(ByVal Value As Integer)
            iTongTriGia = Value
        End Set
    End Property

End Class
