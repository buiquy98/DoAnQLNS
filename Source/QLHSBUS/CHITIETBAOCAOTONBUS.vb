Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CHITIETBAOCAOTONBUS
    Private ctbctDAL As CHITIETBAOCAOTONDAL

    Public Sub New()
        ctbctDAL = New CHITIETBAOCAOTONDAL()
    End Sub

    Public Sub New(connectionString As String)
        ctbctDAL = New CHITIETBAOCAOTONDAL(connectionString)
    End Sub

    Public Function insert(ct As CHITIETBAOCAOTONDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbctDAL.insert(ct)
    End Function


    Public Function update(mact As Integer, tonDau As Integer, phatSinh As Integer, tonCuoi As Integer, listCTBCT As List(Of CHITIETBAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbctDAL.update(mact, tonDau, phatSinh, tonCuoi, listCTBCT)
    End Function

    Public Function delete(mact As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbctDAL.delete(mact)
    End Function

    Public Function selectAll(ByRef listCt As List(Of CHITIETBAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbctDAL.selectALL(listCt)
    End Function

    Public Function selectAll_byMaBaoCaoTon(maBaoCao As Integer, ByRef listCt As List(Of CHITIETBAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbctDAL.selectALL_ByMaBaoCaoTon(maBaoCao, listCt)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ctbctDAL.getNextID(nextID)
    End Function
End Class
