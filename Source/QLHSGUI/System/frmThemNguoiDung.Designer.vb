<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemNguoiDung
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxloainguoidung = New System.Windows.Forms.ComboBox()
        Me.tbxpass = New System.Windows.Forms.TextBox()
        Me.tbxtdn = New System.Windows.Forms.TextBox()
        Me.tbxten = New System.Windows.Forms.TextBox()
        Me.tbxmand = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã người dùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên người dùng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên đăng nhập"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mật khẩu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(141, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "THÊM NGƯỜI DÙNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxloainguoidung)
        Me.GroupBox1.Controls.Add(Me.tbxpass)
        Me.GroupBox1.Controls.Add(Me.tbxtdn)
        Me.GroupBox1.Controls.Add(Me.tbxten)
        Me.GroupBox1.Controls.Add(Me.tbxmand)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 174)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin người dùng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Loại người dùng"
        '
        'cbxloainguoidung
        '
        Me.cbxloainguoidung.FormattingEnabled = True
        Me.cbxloainguoidung.Location = New System.Drawing.Point(125, 138)
        Me.cbxloainguoidung.Name = "cbxloainguoidung"
        Me.cbxloainguoidung.Size = New System.Drawing.Size(204, 21)
        Me.cbxloainguoidung.TabIndex = 8
        '
        'tbxpass
        '
        Me.tbxpass.Location = New System.Drawing.Point(125, 111)
        Me.tbxpass.Name = "tbxpass"
        Me.tbxpass.Size = New System.Drawing.Size(204, 20)
        Me.tbxpass.TabIndex = 7
        '
        'tbxtdn
        '
        Me.tbxtdn.Location = New System.Drawing.Point(125, 83)
        Me.tbxtdn.Name = "tbxtdn"
        Me.tbxtdn.Size = New System.Drawing.Size(204, 20)
        Me.tbxtdn.TabIndex = 6
        '
        'tbxten
        '
        Me.tbxten.Location = New System.Drawing.Point(125, 54)
        Me.tbxten.Name = "tbxten"
        Me.tbxten.Size = New System.Drawing.Size(204, 20)
        Me.tbxten.TabIndex = 5
        '
        'tbxmand
        '
        Me.tbxmand.Location = New System.Drawing.Point(125, 28)
        Me.tbxmand.Name = "tbxmand"
        Me.tbxmand.Size = New System.Drawing.Size(204, 20)
        Me.tbxmand.TabIndex = 4
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(135, 297)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 10
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(308, 297)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 16
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'frmThemNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(564, 383)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmThemNguoiDung"
        Me.Text = "frmThemNguoiDung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxloainguoidung As ComboBox
    Friend WithEvents tbxpass As TextBox
    Friend WithEvents tbxtdn As TextBox
    Friend WithEvents tbxten As TextBox
    Friend WithEvents tbxmand As TextBox
    Friend WithEvents btnthem As Button
    Friend WithEvents btnhuy As Button
End Class
