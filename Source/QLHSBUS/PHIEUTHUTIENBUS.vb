Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class PhieuThuTienBUS
    Private pttDAL As PhieuThuTienDAL

    Public Sub New()
        pttDAL = New PhieuThuTienDAL
    End Sub

    Public Sub New(connectionString As String)
        pttDAL = New PhieuThuTienDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return pttDAL.getNextID(nextID)
    End Function

    Public Function insert(phieuthutien As PhieuThuTienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pttDAL.insert(phieuthutien)
    End Function

    Public Function update(phieuthutien As PhieuThuTienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pttDAL.update(phieuthutien)
    End Function

    Public Function delete(maphieu As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pttDAL.delete(maphieu)
    End Function

    Public Function selectAll(ByRef listPhieu As List(Of PhieuThuTienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pttDAL.selectALL(listPhieu)
    End Function

    Public Function selectAll_byMaPhieu(maPhieu As Integer, ByRef listPhieu As List(Of PhieuThuTienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pttDAL.selectALL_byMaPhieu(maPhieu, listPhieu)
    End Function
End Class
