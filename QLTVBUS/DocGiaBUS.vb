Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidAge(hs As DocGiaDTO) As Boolean

        If (hs.Ngaysinh1.Year > 2000 And hs.Ngaysinh1.Year < 1963) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(hs As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(hs)
    End Function
    Public Function buildMSHS(ByRef nextMshs As Integer) As Result
        Return dgDAL.buildMSHS(nextMshs)
    End Function
End Class
