Public Class BAOCAOTONDTO
    Private machitietton As Integer
    Private thang As DateTime
    Private masach As Integer
    Private tondau As Integer
    Private tonphatsinh As Integer
    Private toncuoi As Integer
    Public Sub New()
    End Sub
    Public Sub New(machitietton As Integer, thang As DateTime, masach As Integer, tondau As Integer, tonphatsinh As Integer, toncuoi As Integer)
        Me.Machitietton1 = machitietton
        Me.Thang1 = thang
        Me.Masach1 = masach
        Me.Tondau1 = tondau
        Me.Tonphatsinh1 = tonphatsinh
        Me.Toncuoi1 = toncuoi
    End Sub

    Public Property Machitietton1 As Integer
        Get
            Return machitietton
        End Get
        Set(value As Integer)
            machitietton = value
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

    Public Property Masach1 As Integer
        Get
            Return masach
        End Get
        Set(value As Integer)
            masach = value
        End Set
    End Property

    Public Property Tondau1 As Integer
        Get
            Return tondau
        End Get
        Set(value As Integer)
            tondau = value
        End Set
    End Property

    Public Property Tonphatsinh1 As Integer
        Get
            Return tonphatsinh
        End Get
        Set(value As Integer)
            tonphatsinh = value
        End Set
    End Property

    Public Property Toncuoi1 As Integer
        Get
            Return toncuoi
        End Get
        Set(value As Integer)
            toncuoi = value
        End Set
    End Property
End Class
