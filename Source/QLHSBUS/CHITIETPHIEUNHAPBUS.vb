Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CTPhieuNhapBUS
    Private ctDAL As CTPhieuNhapDAL

    Public Sub New()
        ctDAL = New CTPhieuNhapDAL()
    End Sub

    Public Sub New(connectionString As String)
        ctDAL = New CTPhieuNhapDAL(connectionString)
    End Sub

    Public Function isValidMaPhieuNhap(phieuNhap As CHITIETPHIEUNHAPDTO) As Boolean
        If (phieuNhap.Imaphieunhap = "") Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidSoLuongNhap(SLN As CHITIETPHIEUNHAPDTO) As Boolean
        If (SLN.Isoluongnhap = "") Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(ct As CHITIETPHIEUNHAPDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.insert(ct)
    End Function

    Public Function update(ct As CHITIETPHIEUNHAPDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.update(ct)
    End Function

    Public Function delete(mact As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.delete(mact)
    End Function

    Public Function selectAll(ByRef listCt As List(Of CHITIETPHIEUNHAPDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.selectALL(listCt)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ctDAL.getNextID(nextID)
    End Function

    Public Function selectALL_ByType(maPhieuNhap As Integer, ByRef listCTPhieuNhap As List(Of CHITIETPHIEUNHAPDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctDAL.selectALL_ByType(maPhieuNhap, listCTPhieuNhap)
    End Function


End Class
