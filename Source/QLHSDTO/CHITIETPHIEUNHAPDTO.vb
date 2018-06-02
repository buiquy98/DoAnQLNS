Public Class CHITIETPHIEUNHAPDTO
    Private _imachitietphieunhap As Integer
    Private _imaphieunhap As Integer
    Private _imasach As Integer
    Private _isoluongnhap As Integer

    Public Sub New()

    End Sub
    Public Sub New(maChiTietPhieuNhap As Integer, maPhieuNhap As Integer, maSach As Integer, soLuongNhap As Integer)
        Me.Imachitietphieunhap = maChiTietPhieuNhap
        Me.Imaphieunhap = maPhieuNhap
        Me.Imasach = maSach
        Me.Isoluongnhap = soLuongNhap
    End Sub

    Public Property Imachitietphieunhap As Integer
        Get
            Return _imachitietphieunhap
        End Get
        Set(value As Integer)
            _imachitietphieunhap = value
        End Set
    End Property

    Public Property Imaphieunhap As Integer
        Get
            Return _imaphieunhap
        End Get
        Set(value As Integer)
            _imaphieunhap = value
        End Set
    End Property

    Public Property Imasach As Integer
        Get
            Return _imasach
        End Get
        Set(value As Integer)
            _imasach = value
        End Set
    End Property

    Public Property Isoluongnhap As Integer
        Get
            Return _isoluongnhap
        End Get
        Set(value As Integer)
            _isoluongnhap = value
        End Set
    End Property
End Class
