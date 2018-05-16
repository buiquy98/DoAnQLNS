Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapTheDocGia
    Private dgBus As DocGiaBUS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()
        '1. Mapping data from GUI control
        docgia.Madg1 = tbmadg.Text
        docgia.Hoten1 = tbhoten.Text
        docgia.Ngaysinh1 = dtpngaysinh.Value
        docgia.Maloaidocgia1 = Convert.ToInt32(cbbmaloaidg.SelectedValue)
        docgia.Diachi1 = tbdiachi.Text
        docgia.Email1 = tbemail.Text
        docgia.Ngaylapthe1 = dtpngaylapthe.Value
        docgia.Ngayhethan1 = dtpngayhethan.Value
        docgia.Nguoilap1 = tbnguoilap.Text
        '2. Business .....
        If (dgBus.isValidAge(docgia) = False) Then
            MessageBox.Show("Tuổi độc giả không hợp lệ!")
            dtpngaysinh.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = dgBus.buildMSHS(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            tbmadg.Text = nextMshs
            tbhoten.Text = String.Empty
            cbbmaloaidg.SelectedValue = String.Empty
            tbdiachi.Text = String.Empty
            tbemail.Text = String.Empty

            tbnguoilap.Text = String.Empty

        Else
            MessageBox.Show("Thêm độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub frmLapTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbmaloaidg.Items.Add("1")
        cbbmaloaidg.Items.Add("2")
        dgBus = New DocGiaBUS()

        ' Load LoaiHocSinh list
        Dim result As Result

        'set MSSH auto
        Dim nextMaHS = "1"
        result = dgBus.buildMSHS(nextMaHS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tbmadg.Text = nextMaHS

    End Sub

    Private Sub dtpngaylapthe_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaylapthe.ValueChanged
        Dim dt As DateTime = dtpngaylapthe.Value
        dtpngayhethan.Value = dtpngaylapthe.Value.AddMonths(6)
    End Sub


End Class