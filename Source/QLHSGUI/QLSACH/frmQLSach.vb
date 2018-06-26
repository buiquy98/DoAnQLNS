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


End Class