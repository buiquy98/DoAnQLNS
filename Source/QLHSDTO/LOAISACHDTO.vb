Public Class LOAISACHDTO
    Private maLoaiSach As Integer
    Private tenLoaiSach As String
    Public Sub New()
    End Sub
    Public Sub New(maLoaiSach As Integer, tenLoaiSach As String)
        Me.maLoaiSach = maLoaiSach
        Me.tenLoaiSach = tenLoaiSach
    End Sub

    Public Property MaLoaiSach1 As Integer
        Get
            Return maLoaiSach
        End Get
        Set(value As Integer)
            maLoaiSach = value
        End Set
    End Property

    Public Property TenLoaiSach1 As String
        Get
            Return tenLoaiSach
        End Get
        Set(value As String)
            tenLoaiSach = value
        End Set
    End Property
End Class
