Imports QLHSDTO
Imports QLHSBUS
Imports Utility
Public Class frmPhieuThuTien

    Private qdbus As QUYDINHBUS
    Private khbus As KHACHHANGBUS
    Private ptbus As PhieuThuTienBUS
    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub frmPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listqd As List(Of QUYDINHDTO)
        qdbus = New QUYDINHBUS()
        khbus = New KHACHHANGBUS
        listqd = New List(Of QUYDINHDTO)
        qdbus.selectAll(listqd)
        LoadQuiDinh()
        btnlapphieu.Enabled = False
        ptbus = New PhieuThuTienBUS()
        Dim nextID As Integer
        Dim result As Result
        result = ptbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbxmaphieu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If





    End Sub


    Private Function LoadQuiDinh()
        Dim quydinh As QUYDINHDTO
        qdbus = New QUYDINHBUS()
        ' Dim quydinh = New QUYDINHDTO
        Dim listQuyDinh = New List(Of QUYDINHDTO)
        Dim result = qdbus.selectAll(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        quydinh = listQuyDinh(0)
        If quydinh.ApDung1 = 1 Then
            cbapdung.Checked = True
        Else
            cbapdung.Checked = False
        End If


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmdg As frmCHONKHACHHANG = New frmCHONKHACHHANG()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()

        Dim kh = New List(Of KHACHHANGDTO)

        If (frmdg.khdc.Count <> 0) Then


            Dim result As Result
            result = khbus.selectALL_ByType(frmdg.khdc(0), kh)
            txtMaKH.Text = kh(0).MaKH1
            txtHoTenKH.Text = kh(0).HoTenKH1
            txtDiaChi.Text = kh(0).DiaChi1
            txtSDT.Text = kh(0).Sdt1
            btnlapphieu.Enabled = True
            tbxsotienno.Text = kh(0).TienNoKH1
        Else
            MessageBox.Show("Chưa chọn khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmdg As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()

        cbapdung.Checked = frmdg.cbqd.Checked
    End Sub

    Private Sub btnlapphieu_Click(sender As Object, e As EventArgs) Handles btnlapphieu.Click
        Dim phieuThu As PHIEUTHUTIENDTO
        phieuThu = New PHIEUTHUTIENDTO()
        '1. Mapping data from GUI control
        If txtMaKH.Text = "" Then
            MessageBox.Show("Chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        phieuThu.MaPhieuThu1 = Convert.ToInt32(tbxmaphieu.Text)
        phieuThu.MaKH1 = Convert.ToInt32(txtMaKH.Text)
        phieuThu.NgayThuTien1 = dtpngaylap.Text
        phieuThu.SoTienThu1 = tbxsotienthu.Text

        Dim sotienthu = tbxsotienthu.Text
        Dim sotienno = tbxsotienno.Text
        If cbapdung.Checked = True Then
            If sotienthu <= sotienno Then
                Dim result As Result

                Dim khbus = New KHACHHANGBUS
                Dim lkh = New List(Of KHACHHANGDTO)
                result = khbus.selectALL_ByType(txtMaKH.Text, lkh)
                Dim tiennomoi = sotienthu - sotienno
                lkh(0).TienNoKH1 = tiennomoi
                khbus.update(lkh(0))
                tbxsotienno.Text=tiennomoi
                result = ptbus.insert(phieuThu)
                MessageBox.Show("Thêm phiếu thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnphieumoi.Enabled = True
                btnlapphieu.Enabled = False
            Else
                MessageBox.Show("Thêm không thành công vì số tiền thu lớn hơn số tiền nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbxsotienthu.Focus()
                Return
                'System.Console.WriteLine(Result.SystemMessage)
            End If
        Else
            Dim result As Result
            Dim khbus = New KHACHHANGBUS
            Dim lkh = New List(Of KHACHHANGDTO)
            result = khbus.selectALL_ByType(txtMaKH.Text, lkh)
            Dim tiennomoi = 0
            lkh(0).TienNoKH1 = tiennomoi
            khbus.update(lkh(0))
            tbxsotienno.Text = tiennomoi
            result = ptbus.insert(phieuThu)
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnlapphieu.Enabled = False
            btnphieumoi.Enabled = True
        End If
    End Sub

    Private Sub btnphieumoi_Click(sender As Object, e As EventArgs) Handles btnphieumoi.Click
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ptbus.getNextID(nextID)
        If (Result.FlagResult = True) Then
            tbxmaphieu.Text = nextID.ToString()
            txtDiaChi.Text = ""
            txtHoTenKH.Text = ""
            txtHoTenKH.Text = ""
            txtSDT.Clear()
            txtMaKH.Clear()
            tbxsotienno.Clear()
            tbxsotienthu.Clear()
        Else
            MessageBox.Show("Lấy ID kế tiếp của phiếu thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If
        btnphieumoi.Enabled = False
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub dtpngaylap_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaylap.ValueChanged
        If dtpngaylap.Value < DateTime.Now Then
            dtpngaylap.Value = DateTime.Now
        End If
    End Sub
End Class