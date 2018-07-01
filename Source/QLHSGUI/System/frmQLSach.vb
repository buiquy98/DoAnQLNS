Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmQLSach
    Private sbus As SACHBUS
    Private lsbus As LOAISACHBUS
    Private Sub frmQLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sbus = New SACHBUS
        lsbus = New LOAISACHBUS()
        LoadContent()
    End Sub



    Private Function LoadContent()

        tbxmasach.Enabled = False
        tbxdongia.Enabled = False
        tbxsoluong.Enabled = False
        tbxtacgia.Enabled = False
        ' cbxtheloai.Enabled = False
        tbxtensach.Enabled = False
        'Load loai sach
        Dim listLoaiSach = New List(Of LOAISACHDTO)

        Dim result As Result
        result = lsbus.selectall(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If

        cbxtheloai.DataSource = New BindingSource(listLoaiSach, String.Empty)
        cbxtheloai.DisplayMember = "Strtenloaisach"
        cbxtheloai.ValueMember = "Imaloaisach"

    End Function


    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub dgvsach_SelectionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmdg As frmCHONSACH = New frmCHONSACH()
        '   frmdg.MdiParent = Me
        frmdg.ShowDialog()
        If (frmdg.listSachDuocChon.Count <> 0) Then
            tbxtacgia.Enabled = True
            tbxsoluong.Enabled = True
            tbxtensach.Enabled = True
            tbxdongia.Enabled = True
            cbxtheloai.Enabled = True
            Dim listsach = New List(Of SACHDTO)
            Dim result As Result
            result = sbus.selectALL_ByMaSach(frmdg.listSachDuocChon(0), listsach)
            tbxmasach.Text = listsach(0).Imasach
            tbxtacgia.Text = listsach(0).Strtacgia
            tbxtensach.Text = listsach(0).Strtensach
            tbxsoluong.Text = listsach(0).Isoluongton
            tbxdongia.Text = listsach(0).Idongia
            cbxtheloai.SelectedValue = listsach(0).Imaloaisach

        End If
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Try
            Dim sach As SACHDTO
            sach = New SACHDTO()

            '1. Mapping data from GUI control
            sach.Imasach = tbxmasach.Text
            sach.Strtensach = tbxtensach.Text
            sach.Strtacgia = tbxtacgia.Text
            sach.Isoluongton = tbxsoluong.Text
            sach.Idongia = tbxdongia.Text
            sach.Imaloaisach = Convert.ToInt32(cbxtheloai.SelectedValue)
            If (sbus.isValicdname(sach) = False) Then
                MessageBox.Show("Tên sách không đúng.")
                tbxtensach.Focus()
                Return
            End If


            Dim result As Result
            result = sbus.update(sach)
            If (result.FlagResult = True) Then

                MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Select Case MsgBox("Bạn có thực sự muốn xóa sách có mã số là " + tbxmasach.Text, MsgBoxStyle.YesNo, "Information")
            Case MsgBoxResult.Yes
                Try
                    '1. Delete from DB
                    Dim result As Result
                    result = sbus.delete(tbxmasach.Text)
                    If (result.FlagResult = True) Then
                        MessageBox.Show("Xóa sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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