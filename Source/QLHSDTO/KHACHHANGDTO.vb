Public Class KHACHHANGDTO
    Private maKH As Integer
    Private hoTenKH As String
    Private tienNoKH As String
    Private diaChi As String
    Private email As String
    Private sdt As Integer
    Public Sub New()
    End Sub
    Public Sub New(maKH As Integer, hoTenKH As String, tienNOKH As String, diaChi As String, email As String, sdt As Integer)
        Me.MaKH1 = maKH
        Me.HoTenKH1 = hoTenKH
        Me.TienNoKH1 = tienNOKH
        Me.DiaChi1 = diaChi
        Me.Email1 = email
        Me.Sdt1 = sdt

    End Sub

    Public Property MaKH1 As Integer
        Get
            Return maKH
        End Get
        Set(value As Integer)
            maKH = value
        End Set
    End Property

    Public Property HoTenKH1 As String
        Get
            Return hoTenKH
        End Get
        Set(value As String)
            hoTenKH = value
        End Set
    End Property

    Public Property TienNoKH1 As String
        Get
            Return tienNoKH
        End Get
        Set(value As String)
            tienNoKH = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return diaChi
        End Get
        Set(value As String)
            diaChi = value
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

    Public Property Sdt1 As Integer
        Get
            Return sdt
        End Get
        Set(value As Integer)
            sdt = value
        End Set
    End Property
End Class
