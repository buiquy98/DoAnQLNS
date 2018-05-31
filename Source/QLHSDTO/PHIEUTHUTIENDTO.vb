Public Class PHIEUTHUTIENDTO
    Private maphieuthu As Integer
    Private makhachhang As Integer
    Private sotienthu As Integer
    Public Sub New()
    End Sub
    Public Sub New(maphieuthu As Integer, makhachhang As Integer, sotienthu As Integer)
        Me.Maphieuthu1 = maphieuthu
        Me.Makhachhang1 = makhachhang
        Me.Sotienthu1 = sotienthu
    End Sub

    Public Property Maphieuthu1 As Integer
        Get
            Return maphieuthu
        End Get
        Set(value As Integer)
            maphieuthu = value
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

    Public Property Sotienthu1 As Integer
        Get
            Return sotienthu
        End Get
        Set(value As Integer)
            sotienthu = value
        End Set
    End Property
End Class
