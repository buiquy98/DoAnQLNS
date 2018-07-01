Public Class BAOCAOCONGNODTO
    Private maBaoCaoCongNo As Integer
    Private thang As Integer
    Private nam As Integer


    Public Sub New()
    End Sub
    Public Sub New(maBaoCaoCongNo As Integer, thang As Integer, nam As Integer)
        Me.maBaoCaoCongNo = maBaoCaoCongNo
        Me.Thang1 = thang
        Me.nam = nam
    End Sub

    Public Property MaBaoCaoCongNo1 As Integer
        Get
            Return maBaoCaoCongNo
        End Get
        Set(value As Integer)
            maBaoCaoCongNo = value
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
