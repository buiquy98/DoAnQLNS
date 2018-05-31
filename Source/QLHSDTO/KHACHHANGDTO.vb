Public Class KHACHHANGDTO
    Private makhachhang As Integer
    Private hotenkhachhang As String
    Private diachi As String
    Private dienthoai As String
    Private email As String
    Private sotienno As Integer
    Public Sub New()
    End Sub
    Public Sub New(makhachhang As Integer, hotenkhachhang As String, diachi As String, dienthoai As String, email As String, sotienno As Integer)
        Me.Makhachhang1 = makhachhang
        Me.Hotenkhachhang1 = hotenkhachhang
        Me.Diachi1 = diachi
        Me.Dienthoai1 = dienthoai
        Me.Email1 = email
        Me.Sotienno1 = sotienno
    End Sub

    Public Property Makhachhang1 As Integer
        Get
            Return makhachhang
        End Get
        Set(value As Integer)
            makhachhang = value
        End Set
    End Property

    Public Property Hotenkhachhang1 As String
        Get
            Return hotenkhachhang
        End Get
        Set(value As String)
            hotenkhachhang = value
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

    Public Property Dienthoai1 As String
        Get
            Return dienthoai
        End Get
        Set(value As String)
            dienthoai = value
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

    Public Property Sotienno1 As Integer
        Get
            Return sotienno
        End Get
        Set(value As Integer)
            sotienno = value
        End Set
    End Property
End Class
