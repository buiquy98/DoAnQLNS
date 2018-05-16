Imports QLTVDAL
Imports QLTVDTO
Imports Utility
Public Class LoaiDocGiaBUS
    Private ldgDAL As LoaiDocGiaDAL
    Public Sub New()
        ldgDAL = New LoaiDocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ldgDAL = New LoaiDocGiaDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listLoaiHS As List(Of LoaiDocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.selectALL(listLoaiHS)
    End Function
End Class
