<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapPhieuNhapSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbLop = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txbmpn = New System.Windows.Forms.TextBox()
        Me.tbxtensach = New System.Windows.Forms.TextBox()
        Me.tbxtacgia = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.tbxtheloai = New System.Windows.Forms.TextBox()
        Me.dtpngaylap = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxSoLuong = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Location = New System.Drawing.Point(6, 66)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(54, 13)
        Me.lbHoTen.TabIndex = 1
        Me.lbHoTen.Text = "Tên Sách"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(6, 95)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(49, 13)
        Me.lbGioiTinh.TabIndex = 1
        Me.lbGioiTinh.Text = "Thể Loại"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(377, 39)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(53, 13)
        Me.lbNgaySinh.TabIndex = 1
        Me.lbNgaySinh.Text = "Số Lượng"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(6, 125)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(42, 13)
        Me.lbDiaChi.TabIndex = 1
        Me.lbDiaChi.Text = "TácGiả"
        '
        'lbLop
        '
        Me.lbLop.AutoSize = True
        Me.lbLop.Location = New System.Drawing.Point(365, 62)
        Me.lbLop.Name = "lbLop"
        Me.lbLop.Size = New System.Drawing.Size(83, 13)
        Me.lbLop.TabIndex = 1
        Me.lbLop.Text = "Ngày Lập Phiếu"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(6, 26)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(81, 13)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "Mã Phiếu Nhập"
        '
        'txbmpn
        '
        Me.txbmpn.Location = New System.Drawing.Point(108, 36)
        Me.txbmpn.Name = "txbmpn"
        Me.txbmpn.ReadOnly = True
        Me.txbmpn.Size = New System.Drawing.Size(205, 20)
        Me.txbmpn.TabIndex = 2
        '
        'tbxtensach
        '
        Me.tbxtensach.Location = New System.Drawing.Point(108, 72)
        Me.tbxtensach.Name = "tbxtensach"
        Me.tbxtensach.Size = New System.Drawing.Size(205, 20)
        Me.tbxtensach.TabIndex = 2
        '
        'tbxtacgia
        '
        Me.tbxtacgia.Location = New System.Drawing.Point(96, 122)
        Me.tbxtacgia.Name = "tbxtacgia"
        Me.tbxtacgia.Size = New System.Drawing.Size(205, 20)
        Me.tbxtacgia.TabIndex = 2
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(456, 172)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(82, 49)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Nhập và Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(200, 172)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(87, 49)
        Me.btnNhap.TabIndex = 5
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'tbxtheloai
        '
        Me.tbxtheloai.Location = New System.Drawing.Point(108, 105)
        Me.tbxtheloai.Name = "tbxtheloai"
        Me.tbxtheloai.Size = New System.Drawing.Size(205, 20)
        Me.tbxtheloai.TabIndex = 7
        '
        'dtpngaylap
        '
        Me.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngaylap.Location = New System.Drawing.Point(458, 56)
        Me.dtpngaylap.Name = "dtpngaylap"
        Me.dtpngaylap.Size = New System.Drawing.Size(205, 20)
        Me.dtpngaylap.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxSoLuong)
        Me.GroupBox1.Controls.Add(Me.dtpngaylap)
        Me.GroupBox1.Controls.Add(Me.tbxtacgia)
        Me.GroupBox1.Controls.Add(Me.lbDiaChi)
        Me.GroupBox1.Controls.Add(Me.lbLop)
        Me.GroupBox1.Controls.Add(Me.lbGioiTinh)
        Me.GroupBox1.Controls.Add(Me.lbHoTen)
        Me.GroupBox1.Controls.Add(Me.lbID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 250)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thẻ đọc giả"
        '
        'tbxSoLuong
        '
        Me.tbxSoLuong.Location = New System.Drawing.Point(458, 20)
        Me.tbxSoLuong.Name = "tbxSoLuong"
        Me.tbxSoLuong.Size = New System.Drawing.Size(100, 20)
        Me.tbxSoLuong.TabIndex = 9
        '
        'frmLapTheDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 340)
        Me.Controls.Add(Me.tbxtheloai)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.tbxtensach)
        Me.Controls.Add(Me.txbmpn)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLapTheDocGia"
        Me.Text = "Lập Thẻ Đọc Giả"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbLop As Label
    Friend WithEvents lbID As Label
    Friend WithEvents txbmpn As TextBox
    Friend WithEvents tbxtensach As TextBox
    Friend WithEvents tbxtacgia As TextBox
    Friend WithEvents btnDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents tbxtheloai As TextBox
    Friend WithEvents dtpngaylap As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxSoLuong As TextBox
End Class
