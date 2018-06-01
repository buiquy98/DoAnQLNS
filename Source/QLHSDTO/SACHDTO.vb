Public Class SACHDTO
    Private maSach As Integer
    Private tenSach As String
    Private maLoaiSach As Integer
    Private tacGia As String
    Private soLuongTon As Integer
    Public Sub New()

    End Sub
    Public Sub New(maSach As Integer, tenSach As String, maLoaiSach As Integer, tacGia As String, soLuongTon As Integer)
        Me.maLoaiSach = maLoaiSach
        Me.tenSach = tenSach
        Me.maLoaiSach = maLoaiSach
        Me.tacGia = tacGia
        Me.soLuongTon = soLuongTon
    End Sub

    Public Property MaSach1 As Integer
        Get
            Return maSach
        End Get
        Set(value As Integer)
            maSach = value
        End Set
    End Property

    Public Property TenSach1 As String
        Get
            Return tenSach
        End Get
        Set(value As String)
            tenSach = value
        End Set
    End Property

    Public Property MaLoaiSach1 As Integer
        Get
            Return maLoaiSach
        End Get
        Set(value As Integer)
            maLoaiSach = value
        End Set
    End Property

    Public Property TacGia1 As String
        Get
            Return tacGia
        End Get
        Set(value As String)
            tacGia = value
        End Set
    End Property

    Public Property SoLuongTon1 As Integer
        Get
            Return soLuongTon
        End Get
        Set(value As Integer)
            soLuongTon = value
        End Set
    End Property
End Class
