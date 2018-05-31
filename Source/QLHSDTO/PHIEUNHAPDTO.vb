Public Class PHIEUNHAPDTO

    Private maphieunhap As String
    Private ngaynhapsach As DateTime
    Private soluongnhap As Int32
    Private tensach As String
    Private theloai As String
    Private tacgia As String


    Public Sub New()
    End Sub


    Public Sub New(maphieunhap As String, ngaynhapsach As DateTime, soluongnhap As Int32, tensach As String, theloai As String, tacgia As String)
        Me.Maphieunhap1 = maphieunhap
        Me.Ngaynhapsach1 = ngaynhapsach
        Me.Soluongnhap1 = soluongnhap
        Me.Tensach1 = tensach
        Me.Theloai1 = theloai
        Me.Tacgia1 = tacgia
    End Sub

    Public Property Maphieunhap1 As String
        Get
            Return maphieunhap
        End Get
        Set(value As String)
            maphieunhap = value
        End Set
    End Property

    Public Property Ngaynhapsach1 As Date
        Get
            Return ngaynhapsach
        End Get
        Set(value As Date)
            ngaynhapsach = value
        End Set
    End Property

    Public Property Soluongnhap1 As Integer
        Get
            Return soluongnhap
        End Get
        Set(value As Integer)
            soluongnhap = value
        End Set
    End Property

    Public Property Tensach1 As String
        Get
            Return tensach
        End Get
        Set(value As String)
            tensach = value
        End Set
    End Property

    Public Property Theloai1 As String
        Get
            Return theloai
        End Get
        Set(value As String)
            theloai = value
        End Set
    End Property

    Public Property Tacgia1 As String
        Get
            Return tacgia
        End Get
        Set(value As String)
            tacgia = value
        End Set
    End Property
End Class
