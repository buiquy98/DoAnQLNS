Public Class CHITIETBAOCAOTONDTO
    Private maChiTietBaoCaoTon As Integer
    Private maSach As Integer
    Private maBaoCaoTon As Integer
    Private tonDau As Integer
    Private tonPhatSinh As Integer
    Private tonCuoi As Integer

    Public Sub New()

    End Sub
    Public Sub New(maChiTietBaoCaoTon As Integer, maSach As Integer, maBaoCaoTon As Integer, tonDau As Integer, tonPhatSinh As Integer, tonCuoi As Integer)
        Me.maChiTietBaoCaoTon = maChiTietBaoCaoTon
        Me.maSach = maSach
        Me.maBaoCaoTon = maBaoCaoTon
        Me.tonDau = tonDau
        Me.tonPhatSinh = tonPhatSinh
        Me.tonCuoi = tonCuoi
    End Sub

    Public Property MaChiTietBaoCaoTon1 As Integer
        Get
            Return maChiTietBaoCaoTon
        End Get
        Set(value As Integer)
            maChiTietBaoCaoTon = value
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

    Public Property MaBaoCaoTon1 As Integer
        Get
            Return maBaoCaoTon
        End Get
        Set(value As Integer)
            maBaoCaoTon = value
        End Set
    End Property

    Public Property TonDau1 As Integer
        Get
            Return tonDau
        End Get
        Set(value As Integer)
            tonDau = value
        End Set
    End Property

    Public Property TonPhatSinh1 As Integer
        Get
            Return tonPhatSinh
        End Get
        Set(value As Integer)
            tonPhatSinh = value
        End Set
    End Property

    Public Property TonCuoi1 As Integer
        Get
            Return tonCuoi
        End Get
        Set(value As Integer)
            tonCuoi = value
        End Set
    End Property
End Class
