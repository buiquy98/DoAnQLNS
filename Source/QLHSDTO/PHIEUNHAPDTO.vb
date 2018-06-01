Public Class PHIEUNHAPDTO
    Private maPhieuNhap As Integer
    Private ngayNhap As DateTime
    Public Sub New()
    End Sub
    Public Sub New(maPhieuNhap As Integer, ngayNhap As DateTime)
        Me.MaPhieuNhap1 = maPhieuNhap
        Me.NgayNhap1 = ngayNhap
    End Sub

    Public Property MaPhieuNhap1 As Integer
        Get
            Return maPhieuNhap
        End Get
        Set(value As Integer)
            maPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap1 As Date
        Get
            Return ngayNhap
        End Get
        Set(value As Date)
            ngayNhap = value
        End Set
    End Property
End Class
