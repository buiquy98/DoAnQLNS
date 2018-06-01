<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemKhachHang
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(254, 312)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(589, 294)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(581, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(168, 103)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(391, 82)
        Me.txtDiaChi.TabIndex = 45
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(168, 225)
        Me.txtSDT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(391, 22)
        Me.txtSDT.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Số Điện Thoại"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(168, 193)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(391, 22)
        Me.txtEmail.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNoKH
        '
        Me.txtTienNoKH.Location = New System.Drawing.Point(168, 71)
        Me.txtTienNoKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTienNoKH.Name = "txtTienNoKH"
        Me.txtTienNoKH.Size = New System.Drawing.Size(391, 22)
        Me.txtTienNoKH.TabIndex = 38
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(168, 39)
        Me.txtHoTenKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.Size = New System.Drawing.Size(391, 22)
        Me.txtHoTenKH.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Họ Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(168, 7)
        Me.txtMaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(391, 22)
        Me.txtMaKH.TabIndex = 34
        Me.txtMaKH.WordWrap = False
        '
        'frmThemKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 335)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmThemKhachHang"
        Me.Text = "frmThemKhachHang"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
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
End Class
