Public Class BAOCAONOCONGDTO
    Private maBaoCaoCongNo As Integer
    Private thang As DateTime


    Public Sub New()
    End Sub
    Public Sub New(maBaoCaoCongNo As Integer, thang As DateTime)
        Me.MaBaoCaoCongNo1 = maBaoCaoCongNo
        Me.Thang1 = thang

    End Sub

    Public Property MaBaoCaoCongNo1 As Integer
        Get
            Return maBaoCaoCongNo
        End Get
        Set(value As Integer)
            maBaoCaoCongNo = value
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
End Class
