Public Class SACHDTO
    Private masach As Integer
    Private tensach As String
    Private theloai As String
    Private tacgia As String
    Private dongia As Integer
    Private soluongton As Integer
    Public Sub New()
    End Sub
    Public Sub New(masach As Integer, tensach As String, theloai As String, tacgia As String, dongia As Integer, soluongton As Integer)
        Me.Masach1 = masach
        Me.Tensach1 = tensach
        Me.Theloai1 = theloai
        Me.Tacgia1 = tacgia
        Me.Dongia1 = dongia
        Me.Soluongton1 = soluongton
    End Sub

    Public Property Masach1 As Integer
        Get
            Return masach
        End Get
        Set(value As Integer)
            masach = value
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

    Public Property Dongia1 As Integer
        Get
            Return dongia
        End Get
        Set(value As Integer)
            dongia = value
        End Set
    End Property

    Public Property Soluongton1 As Integer
        Get
            Return soluongton
        End Get
        Set(value As Integer)
            soluongton = value
        End Set
    End Property
End Class
