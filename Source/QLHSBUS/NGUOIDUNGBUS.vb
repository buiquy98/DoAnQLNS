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



End Class
