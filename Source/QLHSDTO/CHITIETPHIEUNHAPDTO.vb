Public Class CHITIETPHIEUNHAPDTO
    Private maChiTietPhieuNhap As Integer
    Private maPhieuNhap As Integer
    Private maSach As Integer
    Private soLuongNhap As Integer

    Public Sub New()

    End Sub
    Public Sub New(maChiTietPhieuNhap As Integer, maPhieuNhap As Integer, maSach As Integer, soLuongNhap As Integer)
        Me.MaChiTietPhieuNhap1 = maChiTietPhieuNhap
        Me.MaPhieuNhap1 = maPhieuNhap
        Me.MaSach1 = maSach
        Me.SoLuongNhap1 = soLuongNhap
    End Sub

    Public Property MaChiTietPhieuNhap1 As Integer
        Get
            Return maChiTietPhieuNhap
        End Get
        Set(value As Integer)
            maChiTietPhieuNhap = value
        End Set
    End Property

    Public Property MaPhieuNhap1 As Integer
        Get
            Return maPhieuNhap
        End Get
        Set(value As Integer)
            maPhieuNhap = value
        End Set
    End Property

    Public Property MaSach1 As Integer
        Get
            Return maSach
        End Get
        Set(value As Integer)
            maSach = value
        End Set
    End Property

    Public Property SoLuongNhap1 As Integer
        Get
            Return soLuongNhap
        End Get
        Set(value As Integer)
            soLuongNhap = value
        End Set
    End Property
End Class
