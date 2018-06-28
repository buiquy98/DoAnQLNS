Imports QLHSBUS
Imports QLHSDTO
Imports System.Configuration
Imports Utility

Public Class frmThayDoiQuyDinh
    Dim qdBus As QuyDinhBUS

    Dim quydinh As QuyDinhDTO

    Private Sub frmQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        txtLuongNhapToiThieu.Text = quydinh.LuongNhapToiThieu1
        txtLuongTonToiDa.Text = quydinh.LuongTonToiDa1
        txtTienNoToiDa.Text = quydinh.TienNoToiDa1
        txtLuongTonToiThieu.Text = quydinh.LuongTonToiThieu1
        cbqd.Checked = quydinh.ApDung1
    End Sub

    Private Sub btCapNhatQuyDinh_Click(sender As Object, e As EventArgs) Handles btCapNhatQuyDinh.Click
        Try
            If (cbqd.Checked = True) Then
                quydinh.ApDung1 = 1
            Else
                quydinh.ApDung1 = 0
            End If
            quydinh.LuongTonToiThieu1 = Integer.Parse(txtLuongNhapToiThieu.Text)
            quydinh.LuongTonToiDa1 = Integer.Parse(txtLuongTonToiDa.Text)
            quydinh.TienNoToiDa1 = Integer.Parse(txtTienNoToiDa.Text)
            quydinh.LuongTonToiThieu1 = Integer.Parse(txtLuongTonToiThieu.Text)
            Dim result As Result
            result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class