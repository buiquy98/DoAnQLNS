<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCHONKHACHHANG
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListKhachHang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnall = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btTimKiemTheHoTen = New System.Windows.Forms.Button()
        Me.txtMaKHTimKiem = New System.Windows.Forms.TextBox()
        Me.btTimKiemTheoMAKH = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoTenKHTimKiem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnchon = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(76, 209)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(644, 191)
        Me.TabControl2.TabIndex = 41
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListKhachHang)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 165)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Danh Sách Khách Hàng"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListKhachHang
        '
        Me.dgvListKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKhachHang.Location = New System.Drawing.Point(6, 6)
        Me.dgvListKhachHang.MultiSelect = False
        Me.dgvListKhachHang.Name = "dgvListKhachHang"
        Me.dgvListKhachHang.ReadOnly = True
        Me.dgvListKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListKhachHang.Size = New System.Drawing.Size(624, 153)
        Me.dgvListKhachHang.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnall)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btTimKiemTheHoTen)
        Me.GroupBox1.Controls.Add(Me.txtMaKHTimKiem)
        Me.GroupBox1.Controls.Add(Me.btTimKiemTheoMAKH)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtHoTenKHTimKiem)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 105)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm Khách Hàng"
        '
        'btnall
        '
        Me.btnall.Location = New System.Drawing.Point(282, 82)
        Me.btnall.Name = "btnall"
        Me.btnall.Size = New System.Drawing.Size(148, 23)
        Me.btnall.TabIndex = 43
        Me.btnall.Text = "Lấy danh sách khách hàng"
        Me.btnall.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Tìm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(468, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(387, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Số Điện Thoại"
        '
        'btTimKiemTheHoTen
        '
        Me.btTimKiemTheHoTen.Location = New System.Drawing.Point(282, 54)
        Me.btTimKiemTheHoTen.Name = "btTimKiemTheHoTen"
        Me.btTimKiemTheHoTen.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheHoTen.TabIndex = 39
        Me.btTimKiemTheHoTen.Text = "Tìm"
        Me.btTimKiemTheHoTen.UseVisualStyleBackColor = True
        '
        'txtMaKHTimKiem
        '
        Me.txtMaKHTimKiem.Location = New System.Drawing.Point(125, 31)
        Me.txtMaKHTimKiem.Name = "txtMaKHTimKiem"
        Me.txtMaKHTimKiem.Size = New System.Drawing.Size(138, 20)
        Me.txtMaKHTimKiem.TabIndex = 37
        '
        'btTimKiemTheoMAKH
        '
        Me.btTimKiemTheoMAKH.Location = New System.Drawing.Point(282, 28)
        Me.btTimKiemTheoMAKH.Name = "btTimKiemTheoMAKH"
        Me.btTimKiemTheoMAKH.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheoMAKH.TabIndex = 38
        Me.btTimKiemTheoMAKH.Text = "Tìm "
        Me.btTimKiemTheoMAKH.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Mã Khách Hàng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tên Khách Hàng"
        '
        'txtHoTenKHTimKiem
        '
        Me.txtHoTenKHTimKiem.Location = New System.Drawing.Point(125, 54)
        Me.txtHoTenKHTimKiem.Name = "txtHoTenKHTimKiem"
        Me.txtHoTenKHTimKiem.Size = New System.Drawing.Size(138, 20)
        Me.txtHoTenKHTimKiem.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(243, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 31)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "CHỌN KHÁCH HÀNG"
        '
        'btnchon
        '
        Me.btnchon.Location = New System.Drawing.Point(264, 422)
        Me.btnchon.Name = "btnchon"
        Me.btnchon.Size = New System.Drawing.Size(75, 23)
        Me.btnchon.TabIndex = 44
        Me.btnchon.Text = "Chọn"
        Me.btnchon.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(466, 422)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 45
        Me.btnthoat.Text = "Hủy"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmCHONKHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(802, 489)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnchon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCHONKHACHHANG"
        Me.Text = "frmCHONKHACHHANG"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListKhachHang As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btTimKiemTheHoTen As Button
    Friend WithEvents txtMaKHTimKiem As TextBox
    Friend WithEvents btTimKiemTheoMAKH As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHoTenKHTimKiem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnchon As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents btnall As Button
End Class
