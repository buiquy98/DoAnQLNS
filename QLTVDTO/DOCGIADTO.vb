Public Class DocGiaDTO
    Private madg As String
    Private hoten As String
    Private ngaysinh As DateTime
    Private diachi As String
    Private email As String
    Private ngaylapthe As DateTime
    Private ngayhethan As DateTime
    Private maloaidocgia As Integer
    Private nguoilap As String
    Public Sub New()
    End Sub
    Public Sub New(madg As String, hoten As String, ngaysinh As DateTime, diachi As String, email As String, ngaylapthe As DateTime, ngayhethan As DateTime, maloaidocgia As Integer, nguoilap As String)
        Me.madg = madg
        Me.hoten = hoten
        Me.ngaysinh = ngaysinh
        Me.diachi = diachi
        Me.email = email
        Me.ngaylapthe = ngaylapthe
        Me.ngayhethan = ngayhethan
        Me.maloaidocgia = maloaidocgia
        Me.nguoilap = nguoilap
    End Sub
    Public Property Madg1 As String
        Get
            Return madg
        End Get
        Set(value As String)
            madg = value
        End Set
    End Property

    Public Property Hoten1 As String
        Get
            Return hoten
        End Get
        Set(value As String)
            hoten = value
        End Set
    End Property

    Public Property Ngaysinh1 As Date
        Get
            Return ngaysinh
        End Get
        Set(value As Date)
            ngaysinh = value
        End Set
    End Property

    Public Property Diachi1 As String
        Get
            Return diachi
        End Get
        Set(value As String)
            diachi = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Ngaylapthe1 As Date
        Get
            Return ngaylapthe
        End Get
        Set(value As Date)
            ngaylapthe = value
        End Set
    End Property

    Public Property Ngayhethan1 As Date
        Get
            Return ngayhethan
        End Get
        Set(value As Date)
            ngayhethan = value
        End Set
    End Property

    Public Property Maloaidocgia1 As Integer
        Get
            Return maloaidocgia
        End Get
        Set(value As Integer)
            maloaidocgia = value
        End Set
    End Property

    Public Property Nguoilap1 As String
        Get
            Return nguoilap
        End Get
        Set(value As String)
            nguoilap = value
        End Set
    End Property
End Class
