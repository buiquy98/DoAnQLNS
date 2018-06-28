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
    Public Function delete(sach As SACHDTO) As Result
        Return sachDAL.delete(sach.Imasach)
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

    Public Function selectALL_ByName(tensach As String, ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.selectALL_ByName(tensach, listSach)
    End Function

    Public Function update_SoLuongTon(sach As SACHDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.update_SoLuongTon(sach)
    End Function

End Class
