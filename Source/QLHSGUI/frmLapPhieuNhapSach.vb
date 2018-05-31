Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class frmLapPhieuNhapSach
    Private dgBus As PHIEUNHAPBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim phieunhap As PHIEUNHAPDTO
        phieunhap = New PHIEUNHAPDTO()

        '1. Mapping data from GUI control
        phieunhap.Maphieunhap1 = txbmpn.Text
        phieunhap.Tensach1 = tbxtensach.Text
        phieunhap.Tacgia1 = tbxtacgia.Text
        phieunhap.Ngaynhapsach1 = dtpngaylap.Value
        phieunhap.Theloai1 = tbxtheloai.Text
        phieunhap.Soluongnhap1 = Int32.Parse(tbxSoLuong.Text)
        '2. Business .....
        'If (dgBus.isValidName(phieunhap) = False) Then
        '    MessageBox.Show("Họ tên phiếu nhập sách không đúng")
        '    tbxtensach.Focus()
        '    Return
        'End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(phieunhap)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu nhập sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaHS = "1"
            result = dgBus.buildmaHS(nextMaHS)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txbmpn.Text = nextMaHS
            tbxtacgia.Text = String.Empty
            tbxtheloai.Text = String.Empty


        Else
            MessageBox.Show("Thêm phiếu nhập sách không thành công hehe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New PHIEUNHAPBUS()
        ' Dim thamso As ThamSo
        'thamso = New ThamSo()
        ' dtpngaylap.Value = dtpngaylap.Value.AddMonths(thamso.thoihanthe)
        ' Load LoaiHocSinh list
        Dim result As Result

        'set MSSH auto
        Dim nextMaHS = "1"
        result = dgBus.buildmaHS(nextMaHS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txbmpn.Text = nextMaHS

    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Dim phieunhap As PHIEUNHAPDTO
        phieunhap = New PHIEUNHAPDTO()

        '1. Mapping data from GUI control
        phieunhap.Maphieunhap1 = txbmpn.Text
        phieunhap.Tensach1 = tbxtensach.Text
        phieunhap.Tacgia1 = tbxtacgia.Text
        phieunhap.Ngaynhapsach1 = dtpngaylap.Value
        phieunhap.Theloai1 = tbxtheloai.Text
        phieunhap.Ngaynhapsach1 = dtpngaylap.Value
        '2. Business .....
        'If (dgBus.isValidName(phieunhap) = False) Then
        '    MessageBox.Show("Họ tên phiếu nhập sách không đúng")
        '    tbxtensach.Focus()
        '    Return
        'End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(phieunhap)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu nhập sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm phiếu nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txbMHS_TextChanged(sender As Object, e As EventArgs) Handles txbmpn.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub


End Class