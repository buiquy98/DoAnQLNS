Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class NGUOIDUNGBUS
    Private nddal As NGUOIDUNGDAL
    Public Sub New()
        nddal = New NGUOIDUNGDAL
    End Sub

    Public Function selectAll(ByRef listuser As List(Of NguoiDungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nddal.getallUser(listuser)
    End Function

    Public Function selectAll_bytdn(tdn As String, ByRef listuser As List(Of NguoiDungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nddal.getallUser_bytdn(tdn, listuser)
    End Function

    Public Function getnextID(ByRef inextid As Integer)
        Return nddal.NextMS(inextid)
    End Function

    Public Function insert(nd As NguoiDungDTO) As Result
        Return nddal.insert(nd)
    End Function
End Class
