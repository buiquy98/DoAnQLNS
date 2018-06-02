<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSach
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
        Me.lbmasach = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxmasach = New System.Windows.Forms.TextBox()
        Me.tbxtensach = New System.Windows.Forms.TextBox()
        Me.tbxtacgia = New System.Windows.Forms.TextBox()
        Me.tbxdongia = New System.Windows.Forms.TextBox()
        Me.tbxsoluong = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxtheloai = New System.Windows.Forms.ComboBox()
        Me.btnnhapdong = New System.Windows.Forms.Button()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbmasach
        '
        Me.lbmasach.AutoSize = True
        Me.lbmasach.Location = New System.Drawing.Point(5, 26)
        Me.lbmasach.Name = "lbmasach"
        Me.lbmasach.Size = New System.Drawing.Size(50, 13)
        Me.lbmasach.TabIndex = 0
        Me.lbmasach.Text = "Mã Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tác Giả"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thể Loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Đơn giá"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Số Lượng"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxmasach
        '
        Me.tbxmasach.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbxmasach.Location = New System.Drawing.Point(63, 19)
        Me.tbxmasach.Name = "tbxmasach"
        Me.tbxmasach.Size = New System.Drawing.Size(100, 20)
        Me.tbxmasach.TabIndex = 6
        Me.tbxmasach.Text = "<tự động>"
        Me.tbxmasach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxtensach
        '
        Me.tbxtensach.Location = New System.Drawing.Point(63, 59)
        Me.tbxtensach.Name = "tbxtensach"
        Me.tbxtensach.Size = New System.Drawing.Size(100, 20)
        Me.tbxtensach.TabIndex = 7
        '
        'tbxtacgia
        '
        Me.tbxtacgia.Location = New System.Drawing.Point(63, 141)
        Me.tbxtacgia.Name = "tbxtacgia"
        Me.tbxtacgia.Size = New System.Drawing.Size(100, 20)
        Me.tbxtacgia.TabIndex = 9
        '
        'tbxdongia
        '
        Me.tbxdongia.Location = New System.Drawing.Point(63, 184)
        Me.tbxdongia.Name = "tbxdongia"
        Me.tbxdongia.Size = New System.Drawing.Size(100, 20)
        Me.tbxdongia.TabIndex = 10
        '
        'tbxsoluong
        '
        Me.tbxsoluong.Location = New System.Drawing.Point(63, 227)
        Me.tbxsoluong.Name = "tbxsoluong"
        Me.tbxsoluong.Size = New System.Drawing.Size(100, 20)
        Me.tbxsoluong.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxtheloai)
        Me.GroupBox1.Controls.Add(Me.btnnhapdong)
        Me.GroupBox1.Controls.Add(Me.btnnhap)
        Me.GroupBox1.Controls.Add(Me.lbmasach)
        Me.GroupBox1.Controls.Add(Me.tbxmasach)
        Me.GroupBox1.Controls.Add(Me.tbxtensach)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbxtacgia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbxdongia)
        Me.GroupBox1.Controls.Add(Me.tbxsoluong)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 288)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sách"
        '
        'cbxtheloai
        '
        Me.cbxtheloai.FormattingEnabled = True
        Me.cbxtheloai.Location = New System.Drawing.Point(63, 101)
        Me.cbxtheloai.Name = "cbxtheloai"
        Me.cbxtheloai.Size = New System.Drawing.Size(100, 21)
        Me.cbxtheloai.TabIndex = 14
        '
        'btnnhapdong
        '
        Me.btnnhapdong.Location = New System.Drawing.Point(133, 259)
        Me.btnnhapdong.Name = "btnnhapdong"
        Me.btnnhapdong.Size = New System.Drawing.Size(95, 23)
        Me.btnnhapdong.TabIndex = 13
        Me.btnnhapdong.Text = "Nhập và đóng"
        Me.btnnhapdong.UseVisualStyleBackColor = True
        '
        'btnnhap
        '
        Me.btnnhap.Location = New System.Drawing.Point(28, 259)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnnhap.TabIndex = 12
        Me.btnnhap.Text = "Nhập"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'frmSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(266, 315)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSach"
        Me.Text = "frmSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbmasach As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxmasach As TextBox
    Friend WithEvents tbxtensach As TextBox
    Friend WithEvents tbxtacgia As TextBox
    Friend WithEvents tbxdongia As TextBox
    Friend WithEvents tbxsoluong As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnnhapdong As Button
    Friend WithEvents btnnhap As Button
    Friend WithEvents cbxtheloai As ComboBox
End Class
