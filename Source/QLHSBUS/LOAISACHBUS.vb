Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class LOAISACHBUS
    Private lsDAL As LOAISACHDAL

    Public Sub New()
        lsDAL = New LOAISACHDAL()
    End Sub

    Public Sub New(connectionString As String)
        lsDAL = New LOAISACHDAL(connectionString)
    End Sub

    Public Function isValidName(ls As LOAISACHDTO) As Boolean

        If (ls.Strtenloaisach.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(ls As LOAISACHDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.insert(ls)
    End Function

    Public Function update(ls As LOAISACHDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.update(ls)
    End Function

    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.delete(maLoai)
    End Function

    Public Function selectAll(ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.selectALL(listLoaiSach)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lsDAL.getNextID(nextID)
    End Function

    Public Function selectAll_ByName(name As String, ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.selectALL_ByName(name, listLoaiSach)
    End Function

    Public Function selectAll_ByMaLoaiSach(maLoai As Integer, ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.selectALL_ByMaLoaiSach(maLoai, listLoaiSach)
    End Function
End Class
