Public Class LoaiDocGiaDTO
    Private maloaidocgia As Integer
    Private tenloaidocgia As String
    Public Sub New()
    End Sub
    Public Sub New(maloaidocgia As Integer, tenloaidocgia As String)
        Me.Maloaidocgia1 = maloaidocgia
        Me.Tenloaidocgia1 = tenloaidocgia
    End Sub

    Public Property Maloaidocgia1 As Integer
        Get
            Return maloaidocgia
        End Get
        Set(value As Integer)
            maloaidocgia = value
        End Set
    End Property

    Public Property Tenloaidocgia1 As String
        Get
            Return tenloaidocgia
        End Get
        Set(value As String)
            tenloaidocgia = value
        End Set
    End Property
End Class
'anbnb
