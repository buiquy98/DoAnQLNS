Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class SACHBUS
    Private sachDAL As SACHDAL
    Public Sub New()
        sachDAL = New SACHDAL
    End Sub


    'kiem tra ten
    Public Function isValicdname(sach As SACHDTO)
        If (sach.Strtensach.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(sach As SACHDTO) As Result
        Return sachDAL.insert(sach)
    End Function
    Public Function delete(imasach As Integer) As Result
        Return sachDAL.delete(imasach)
    End Function
    Public Function update(sach As SACHDTO) As Result
        Return sachDAL.update(sach)
    End Function
    Public Function selectAll(ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.getallsach(listSach)
    End Function

    Public Function getnextID(ByRef inextid As Integer)
        Return sachDAL.NextMS(inextid)
    End Function

    Public Function selectALL_ByMaSach(maSach As Integer, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByMaSach(maSach, listSach)
    End Function


    Public Function selectALL_ByTacgia(tacgia As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByTacgia(tacgia, listSach)
    End Function

    Public Function selectALL_ByName(tensach As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByName(tensach, listSach)
    End Function



    Public Function selectALL_ByLoaiSach(maloai As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByTheloai(maloai, listSach)
    End Function


    Public Function selectALL_ByDonGia(tu As String, den As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.Sellecall_byDonGia(tu, den, listSach)
    End Function

    Public Function selectALL_BySLT(tondau As String, toncuoi As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.Sellecall_byslt(tondau, toncuoi, listSach)
    End Function





    Public Function update_SoLuongTon(sach As SACHDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.update_SoLuongTon(sach)
    End Function

End Class
