Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class LOAINGUOIDUNGBUS
    Private lnddal As LOAINGUOIDUNGDAL
    Public Sub New()
        lnddal = New LOAINGUOIDUNGDAL()
    End Sub

    Public Sub New(connectionString As String)
        lnddal = New LOAINGUOIDUNGDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listLoaiSach As List(Of LoaiNguoiDungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lnddal.selectALL(listLoaiSach)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lnddal.getNextID(nextID)
    End Function
End Class
