Public Class BAOCAONOCONGDTO
    Private machitietnocong As Integer
    Private thang As DateTime
    Private makhachhang As Integer
    Private nodau As Integer
    Private nophatsinh As Integer
    Private nocuoi As Integer

    Public Sub New()
    End Sub
    Public Sub New(machitietnocong As Integer, thang As DateTime, makhachhang As Integer, nodau As Integer, nophatsinh As Integer, nocuoi As Integer)
        Me.Machitietnocong1 = machitietnocong
        Me.Thang1 = thang
        Me.Makhachhang1 = makhachhang
        Me.Nodau1 = nodau
        Me.Nophatsinh1 = nophatsinh
        Me.Nocuoi1 = nocuoi
    End Sub

    Public Property Machitietnocong1 As Integer
        Get
            Return machitietnocong
        End Get
        Set(value As Integer)
            machitietnocong = value
        End Set
    End Property

    Public Property Thang1 As Date
        Get
            Return thang
        End Get
        Set(value As Date)
            thang = value
        End Set
    End Property

    Public Property Makhachhang1 As Integer
        Get
            Return makhachhang
        End Get
        Set(value As Integer)
            makhachhang = value
        End Set
    End Property

    Public Property Nodau1 As Integer
        Get
            Return nodau
        End Get
        Set(value As Integer)
            nodau = value
        End Set
    End Property

    Public Property Nophatsinh1 As Integer
        Get
            Return nophatsinh
        End Get
        Set(value As Integer)
            nophatsinh = value
        End Set
    End Property

    Public Property Nocuoi1 As Integer
        Get
            Return nocuoi
        End Get
        Set(value As Integer)
            nocuoi = value
        End Set
    End Property
End Class
