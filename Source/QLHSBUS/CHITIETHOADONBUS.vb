Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CTHoaDonBUS
    Private cthdDAL As CTHoaDonDAL

    Public Sub New()
        cthdDAL = New CTHoaDonDAL
    End Sub

    Public Sub New(connectionString As String)
        cthdDAL = New CTHoaDonDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return cthdDAL.getNextID(nextID)
    End Function

    Public Function insert(cthd As CHITIETHOADONDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.insert(cthd)
    End Function

    Public Function update(cthd As CHITIETHOADONDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.update(cthd)
    End Function

    Public Function selectALL(ByRef listHoaDon As List(Of CHITIETHOADONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.selectALL(listHoaDon)
    End Function

    Public Function selectALL_byMaHD(maHD As Integer, ByRef listHoaDon As List(Of CHITIETHOADONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.selectALL_byMaHD(maHD, listHoaDon)
    End Function

    Public Function delete(macthd As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cthdDAL.delete(macthd)
    End Function
End Class
