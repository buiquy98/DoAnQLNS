Public Class BAOCAOTONDTO
    Private maBaoCaoTon As Integer
    Private thang As Integer
    Private nam As Integer

    Public Sub New()

    End Sub
    Public Sub New(maBaoCaoTon As Integer, thang As Integer, nam As Integer)
        Me.maBaoCaoTon = maBaoCaoTon
        Me.Thang1 = thang
        Me.Nam1 = nam
    End Sub

    Public Property MaBaoCaoTon1 As Integer
        Get
            Return maBaoCaoTon
        End Get
        Set(value As Integer)
            maBaoCaoTon = value
        End Set
    End Property

    Public Property Nam1 As Integer
        Get
            Return nam
        End Get
        Set(value As Integer)
            nam = value
        End Set
    End Property

    Public Property Thang1 As Integer
        Get
            Return thang
        End Get
        Set(value As Integer)
            thang = value
        End Set
    End Property
End Class

