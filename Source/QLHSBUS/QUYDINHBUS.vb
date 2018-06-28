Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class QUYDINHBUS

    Private qddal As QUYDINHDAL
    Public Sub New()
        qddal = New QUYDINHDAL()
    End Sub

    Public Function update(qd As QUYDINHDTO) As Result
        Return qddal.update(qd)
    End Function
    Public Function selectAll(ByRef listqd As List(Of QUYDINHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qddal.selectALL(listqd)
    End Function

End Class
