Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiKhachHang
    Private khBus As KHACHHANGBUS
    Private Sub frmQuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KHACHHANGBUS()
        Dim listkh = New List(Of KHACHHANGDTO)

    End Sub



    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        Dim frmdg As frmCHONKHACHHANG = New frmCHONKHACHHANG()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()

        Dim kh = New List(Of KHACHHANGDTO)

        If (frmdg.khdc.Count <> 0) Then


            Dim result As Result
            result = khBus.selectALL_ByType(frmdg.khdc(0), kh)
            txtMaKH.Text = kh(0).MaKH1
            txtHoTenKH.Text = kh(0).HoTenKH1
            txtTienNoKH.Text = kh(0).TienNoKH1
            txtDiaChi.Text = kh(0).DiaChi1
            txtSDT.Text = kh(0).Sdt1
            txtEmail.Text = kh(0).Email1
        Else
            MessageBox.Show("Chưa chọn khách hàng")
        End If



    End Sub

    Private Sub btCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btCapNhatKhachHang.Click
        Try
            Dim kh As KHACHHANGDTO
            kh = New KHACHHANGDTO

            '1. Mapping data from GUI control
            kh.MaKH1 = txtMaKH.Text
            kh.HoTenKH1 = txtHoTenKH.Text
            kh.TienNoKH1 = txtTienNoKH.Text
            kh.DiaChi1 = txtDiaChi.Text
            kh.Email1 = txtEmail.Text
            kh.Sdt1 = txtSDT.Text
            '2. Business .....
            If (khBus.isValidName(kh) = False) Then
                MessageBox.Show("Tên khách hàng không đúng.")
                txtHoTenKH.Focus()
                Return
            End If
            '3. Insert to DB
            Dim result As Result
            result = khBus.update(kh)
            If (result.FlagResult = True) Then
                MessageBox.Show("Cập nhật khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub btXoaKhachHang_Click(sender As Object, e As EventArgs) Handles btXoaKhachHang.Click
        Select Case MsgBox("Bạn có thực sự muốn xóa khách hàng có mã số là " + txtMaKH.Text, MsgBoxStyle.YesNo, "Information")
            Case MsgBoxResult.Yes
                Try
                    '1. Delete from DB
                    Dim result As Result
                    result = khBus.delete(Integer.Parse(txtMaKH.Text))
                    If (result.FlagResult = True) Then
                        MessageBox.Show("Xóa khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try
            Case MsgBoxResult.No
                Return
        End Select
    End Sub
End Class