<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLiKhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnChon = New System.Windows.Forms.Button()
        Me.btXoaKhachHang = New System.Windows.Forms.Button()
        Me.btCapNhatKhachHang = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTienNoKH = New System.Windows.Forms.TextBox()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(76, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 267)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnChon)
        Me.TabPage1.Controls.Add(Me.btXoaKhachHang)
        Me.TabPage1.Controls.Add(Me.btCapNhatKhachHang)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTienNoKH)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Khách Hàng"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnChon
        '
        Me.btnChon.Location = New System.Drawing.Point(499, 7)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(104, 23)
        Me.btnChon.TabIndex = 35
        Me.btnChon.Text = "Chọn khách hàng"
        Me.btnChon.UseVisualStyleBackColor = True
        '
        'btXoaKhachHang
        '
        Me.btXoaKhachHang.Location = New System.Drawing.Point(320, 212)
        Me.btXoaKhachHang.Name = "btXoaKhachHang"
        Me.btXoaKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btXoaKhachHang.TabIndex = 32
        Me.btXoaKhachHang.Text = "Xóa"
        Me.btXoaKhachHang.UseVisualStyleBackColor = True
        '
        'btCapNhatKhachHang
        '
        Me.btCapNhatKhachHang.Location = New System.Drawing.Point(239, 212)
        Me.btCapNhatKhachHang.Name = "btCapNhatKhachHang"
        Me.btCapNhatKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatKhachHang.TabIndex = 31
        Me.btCapNhatKhachHang.Text = "Cập nhật"
        Me.btCapNhatKhachHang.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(175, 85)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(294, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(175, 182)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(294, 20)
        Me.txtSDT.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Số Điện Thoại"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(175, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(294, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNoKH
        '
        Me.txtTienNoKH.Location = New System.Drawing.Point(175, 59)
        Me.txtTienNoKH.Name = "txtTienNoKH"
        Me.txtTienNoKH.Size = New System.Drawing.Size(294, 20)
        Me.txtTienNoKH.TabIndex = 20
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(175, 33)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.Size = New System.Drawing.Size(294, 20)
        Me.txtHoTenKH.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Họ Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(175, 7)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(294, 20)
        Me.txtMaKH.TabIndex = 16
        Me.txtMaKH.WordWrap = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(281, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(316, 31)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'frmQuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(787, 404)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuanLiKhachHang"
        Me.Text = "frmQuanLiKhachHang"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btXoaKhachHang As Button
    Friend WithEvents btCapNhatKhachHang As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTienNoKH As TextBox
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnChon As Button
End Class
