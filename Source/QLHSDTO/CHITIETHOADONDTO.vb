Public Class CHITIETHOADONDTO
    Private maChiTietHoaDon As Integer
    Private maHoaDon As Integer
    Private maSach As Integer
    Private soLuongBan As Integer
    Private donGiaBan As Integer
    Private thanhTien As Integer
    Public Sub New()

    End Sub
    Public Sub New(maChiTietPhieuNhap As Integer, maPhieuNhap As Integer, maSach As Integer, soLuongBan As Integer, donGiaBan As Integer, thanhTien As Integer)
        Me.MaChiTietHoaDon1 = maChiTietPhieuNhap
        Me.MaHoaDon1 = maPhieuNhap
        Me.maSach = maSach
        Me.soLuongBan = soLuongBan
        Me.donGiaBan = donGiaBan
        Me.thanhTien = thanhTien

    End Sub


    Public Property MaSach1 As Integer
        Get
            Return maSach
        End Get
        Set(value As Integer)
            maSach = value
        End Set
    End Property

    Public Property SoLuongBan1 As Integer
        Get
            Return soLuongBan
        End Get
        Set(value As Integer)
            soLuongBan = value
        End Set
    End Property

    Public Property DonGiaBan1 As Integer
        Get
            Return donGiaBan
        End Get
        Set(value As Integer)
            donGiaBan = value
        End Set
    End Property

    Public Property ThanhTien1 As Integer
        Get
            Return thanhTien
        End Get
        Set(value As Integer)
            thanhTien = value
        End Set
    End Property

    Public Property MaChiTietHoaDon1 As Integer
        Get
            Return maChiTietHoaDon
        End Get
        Set(value As Integer)
            maChiTietHoaDon = value
        End Set
    End Property

    Public Property MaHoaDon1 As Integer
        Get
            Return maHoaDon
        End Get
        Set(value As Integer)
            maHoaDon = value
        End Set
    End Property
End Class
