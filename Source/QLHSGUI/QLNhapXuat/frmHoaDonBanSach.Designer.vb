<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDonBanSach
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMain = New System.Windows.Forms.Label()
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
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbxquidinh2 = New System.Windows.Forms.TextBox()
        Me.tbxquidinh1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbxtongtien = New System.Windows.Forms.TextBox()
        Me.btnphieumoi = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnlapphieu = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(255, 35)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(348, 31)
        Me.lblMain.TabIndex = 54
        Me.lblMain.Text = "LẬP HÓA ĐƠN BÁN SÁCH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpngaylap)
        Me.GroupBox1.Controls.Add(Me.tbxmaphieu)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 63)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ngày lập hóa đơn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã hóa đơn"
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
        Me.GroupBox2.Location = New System.Drawing.Point(22, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 177)
        Me.GroupBox2.TabIndex = 4
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
        Me.txtMaKH.Text = "<tự động>"
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
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(22, 525)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 69
        Me.btnthem.Text = "Thêm sách"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(100, 525)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(142, 23)
        Me.btnxoa.TabIndex = 70
        Me.btnxoa.Text = "Xóa dòng đã chọn"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.tbxquidinh2)
        Me.GroupBox3.Controls.Add(Me.tbxquidinh1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 554)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(808, 100)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quy Định"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(480, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(239, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Thay đổi qui định"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbxquidinh2
        '
        Me.tbxquidinh2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxquidinh2.Enabled = False
        Me.tbxquidinh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxquidinh2.Location = New System.Drawing.Point(241, 65)
        Me.tbxquidinh2.Name = "tbxquidinh2"
        Me.tbxquidinh2.ReadOnly = True
        Me.tbxquidinh2.Size = New System.Drawing.Size(224, 22)
        Me.tbxquidinh2.TabIndex = 3
        '
        'tbxquidinh1
        '
        Me.tbxquidinh1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxquidinh1.Enabled = False
        Me.tbxquidinh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxquidinh1.Location = New System.Drawing.Point(241, 31)
        Me.tbxquidinh1.Name = "tbxquidinh1"
        Me.tbxquidinh1.ReadOnly = True
        Me.tbxquidinh1.Size = New System.Drawing.Size(224, 22)
        Me.tbxquidinh1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Số tiền nợ tối đa của khách hàng"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Số lượng tồn tối thiểu sau khi bán"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(22, 332)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(814, 191)
        Me.TabControl2.TabIndex = 68
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvsach)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(806, 165)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Chi tiết Hóa đơn"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvsach
        '
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(-4, 0)
        Me.dgvsach.MultiSelect = False
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.Size = New System.Drawing.Size(810, 169)
        Me.dgvsach.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(545, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "TỔNG TIỀN"
        '
        'tbxtongtien
        '
        Me.tbxtongtien.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbxtongtien.Location = New System.Drawing.Point(641, 525)
        Me.tbxtongtien.Name = "tbxtongtien"
        Me.tbxtongtien.ReadOnly = True
        Me.tbxtongtien.Size = New System.Drawing.Size(190, 20)
        Me.tbxtongtien.TabIndex = 72
        Me.tbxtongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnphieumoi
        '
        Me.btnphieumoi.Enabled = False
        Me.btnphieumoi.Location = New System.Drawing.Point(641, 660)
        Me.btnphieumoi.Name = "btnphieumoi"
        Me.btnphieumoi.Size = New System.Drawing.Size(101, 23)
        Me.btnphieumoi.TabIndex = 75
        Me.btnphieumoi.Text = "Tạo phiếu mới"
        Me.btnphieumoi.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(756, 660)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 74
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnlapphieu
        '
        Me.btnlapphieu.Location = New System.Drawing.Point(548, 660)
        Me.btnlapphieu.Name = "btnlapphieu"
        Me.btnlapphieu.Size = New System.Drawing.Size(75, 23)
        Me.btnlapphieu.TabIndex = 73
        Me.btnlapphieu.Text = "Lập phiếu"
        Me.btnlapphieu.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmHoaDonBanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(852, 690)
        Me.Controls.Add(Me.btnphieumoi)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnlapphieu)
        Me.Controls.Add(Me.tbxtongtien)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "frmHoaDonBanSach"
        Me.Text = "frmHoaDonBanSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
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
    Friend WithEvents btnthem As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents tbxquidinh2 As TextBox
    Friend WithEvents tbxquidinh1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents tbxtongtien As TextBox
    Friend WithEvents btnphieumoi As Button
    Friend WithEvents btnhuy As Button
    Friend WithEvents btnlapphieu As Button
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
