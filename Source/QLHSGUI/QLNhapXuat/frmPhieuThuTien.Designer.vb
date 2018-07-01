<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuThuTien
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpngaylap = New System.Windows.Forms.DateTimePicker()
        Me.tbxmaphieu = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxsotienno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbapdung = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxsotienthu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnlapphieu = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnphieumoi = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpngaylap)
        Me.GroupBox1.Controls.Add(Me.tbxmaphieu)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu thu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ngày lập phiếu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã phiếu thu"
        '
        'dtpngaylap
        '
        Me.dtpngaylap.Location = New System.Drawing.Point(442, 23)
        Me.dtpngaylap.Name = "dtpngaylap"
        Me.dtpngaylap.Size = New System.Drawing.Size(200, 20)
        Me.dtpngaylap.TabIndex = 1
        '
        'tbxmaphieu
        '
        Me.tbxmaphieu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxmaphieu.Enabled = False
        Me.tbxmaphieu.Location = New System.Drawing.Point(120, 23)
        Me.tbxmaphieu.Name = "tbxmaphieu"
        Me.tbxmaphieu.Size = New System.Drawing.Size(100, 20)
        Me.tbxmaphieu.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbxsotienno)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtDiaChi)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSDT)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtMaKH)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtHoTenKH)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin khách hàng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(456, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Số tiền nợ"
        '
        'tbxsotienno
        '
        Me.tbxsotienno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbxsotienno.Location = New System.Drawing.Point(548, 144)
        Me.tbxsotienno.Name = "tbxsotienno"
        Me.tbxsotienno.ReadOnly = True
        Me.tbxsotienno.Size = New System.Drawing.Size(228, 20)
        Me.tbxsotienno.TabIndex = 56
        Me.tbxsotienno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Chọn khách hàng"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(141, 83)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(635, 39)
        Me.txtDiaChi.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Mã Khách Hàng"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(570, 31)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(206, 20)
        Me.txtSDT.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(456, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Số Điện Thoại"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(141, 31)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(189, 20)
        Me.txtMaKH.TabIndex = 47
        Me.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMaKH.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Họ Tên Khách Hàng"
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(141, 57)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.ReadOnly = True
        Me.txtHoTenKH.Size = New System.Drawing.Size(294, 20)
        Me.txtHoTenKH.TabIndex = 48
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(279, 48)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(299, 31)
        Me.lblMain.TabIndex = 59
        Me.lblMain.Text = "LẬP PHIẾU THU TIỀN"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.cbapdung)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 389)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(812, 73)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quy định"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Thay đổi quy định"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbapdung
        '
        Me.cbapdung.AutoSize = True
        Me.cbapdung.Enabled = False
        Me.cbapdung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbapdung.Location = New System.Drawing.Point(92, 31)
        Me.cbapdung.Name = "cbapdung"
        Me.cbapdung.Size = New System.Drawing.Size(380, 20)
        Me.cbapdung.TabIndex = 0
        Me.cbapdung.Text = "Áp dụng số tiền thu không được vượt quá  số tiền nợ"
        Me.cbapdung.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tbxsotienthu)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(47, 477)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(812, 73)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chi tiết phiếu thu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(456, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Đồng"
        '
        'tbxsotienthu
        '
        Me.tbxsotienthu.Location = New System.Drawing.Point(217, 34)
        Me.tbxsotienthu.Name = "tbxsotienthu"
        Me.tbxsotienthu.Size = New System.Drawing.Size(230, 20)
        Me.tbxsotienthu.TabIndex = 53
        Me.tbxsotienthu.Text = "0"
        Me.tbxsotienthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Số tiền thu"
        '
        'btnlapphieu
        '
        Me.btnlapphieu.Location = New System.Drawing.Point(218, 568)
        Me.btnlapphieu.Name = "btnlapphieu"
        Me.btnlapphieu.Size = New System.Drawing.Size(75, 23)
        Me.btnlapphieu.TabIndex = 62
        Me.btnlapphieu.Text = "Lập phiếu"
        Me.btnlapphieu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(538, 568)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 63
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnphieumoi
        '
        Me.btnphieumoi.Enabled = False
        Me.btnphieumoi.Location = New System.Drawing.Point(381, 568)
        Me.btnphieumoi.Name = "btnphieumoi"
        Me.btnphieumoi.Size = New System.Drawing.Size(101, 23)
        Me.btnphieumoi.TabIndex = 64
        Me.btnphieumoi.Text = "Tạo phiếu mới"
        Me.btnphieumoi.UseVisualStyleBackColor = True
        '
        'frmPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(923, 614)
        Me.Controls.Add(Me.btnphieumoi)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnlapphieu)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPhieuThuTien"
        Me.Text = "frmPhieuThuTien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpngaylap As DateTimePicker
    Friend WithEvents tbxmaphieu As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxsotienno As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents btnlapphieu As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxsotienthu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cbapdung As CheckBox
    Friend WithEvents lblMain As Label
    Friend WithEvents btnhuy As Button
    Friend WithEvents btnphieumoi As Button
End Class
