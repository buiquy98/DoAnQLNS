Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class FrmPhieuNhapSach

    Dim pnbus As PHIEUNHAPBUS
    Private Sub FrmPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContent()
    End Sub


    Public Function LoadContent()
        Dim result As Result
        pnbus = New PHIEUNHAPBUS
        Dim quidinh As QUYDINHDTO
        quidinh = New QUYDINHDTO()
        tbxquidinh2.Enabled = tbxquidinh1.Enabled = False
        tbxquidinh1.Text = quidinh.LuongNhapToiThieu1.ToString()
        tbxquidinh2.Text = quidinh.LuongTonToiDa1


        Dim nextID As Integer

        result = pnbus.buildmaPN(nextID)
        If (Result.FlagResult = True) Then
            tbxmaphieunhap.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If

    End Function


End Class