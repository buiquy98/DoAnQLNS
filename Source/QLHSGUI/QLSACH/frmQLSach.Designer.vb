<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSach
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxtheloai = New System.Windows.Forms.ComboBox()
        Me.lbmasach = New System.Windows.Forms.Label()
        Me.tbxmasach = New System.Windows.Forms.TextBox()
        Me.tbxtensach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxtacgia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxdongia = New System.Windows.Forms.TextBox()
        Me.tbxsoluong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 178)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(735, 220)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvsach)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(727, 194)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh sách đầu sách"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvsach
        '
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(0, 0)
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.Size = New System.Drawing.Size(727, 194)
        Me.dgvsach.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(275, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "QUẢN LÝ SÁCH"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnhuy)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.Controls.Add(Me.btncapnhat)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxtheloai)
        Me.GroupBox2.Controls.Add(Me.lbmasach)
        Me.GroupBox2.Controls.Add(Me.tbxmasach)
        Me.GroupBox2.Controls.Add(Me.tbxtensach)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbxtacgia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbxdongia)
        Me.GroupBox2.Controls.Add(Me.tbxsoluong)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 197)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm kiếm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(502, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "VNĐ"
        '
        'cbxtheloai
        '
        Me.cbxtheloai.FormattingEnabled = True
        Me.cbxtheloai.Location = New System.Drawing.Point(284, 61)
        Me.cbxtheloai.Name = "cbxtheloai"
        Me.cbxtheloai.Size = New System.Drawing.Size(212, 21)
        Me.cbxtheloai.TabIndex = 27
        '
        'lbmasach
        '
        Me.lbmasach.AutoSize = True
        Me.lbmasach.Location = New System.Drawing.Point(189, 16)
        Me.lbmasach.Name = "lbmasach"
        Me.lbmasach.Size = New System.Drawing.Size(50, 13)
        Me.lbmasach.TabIndex = 16
        Me.lbmasach.Text = "Mã Sách"
        Me.lbmasach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxmasach
        '
        Me.tbxmasach.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbxmasach.Location = New System.Drawing.Point(284, 9)
        Me.tbxmasach.Name = "tbxmasach"
        Me.tbxmasach.Size = New System.Drawing.Size(212, 20)
        Me.tbxmasach.TabIndex = 22
        Me.tbxmasach.Text = "<tự động>"
        Me.tbxmasach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxtensach
        '
        Me.tbxtensach.Location = New System.Drawing.Point(284, 35)
        Me.tbxtensach.Name = "tbxtensach"
        Me.tbxtensach.Size = New System.Drawing.Size(212, 20)
        Me.tbxtensach.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tên Sách"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxtacgia
        '
        Me.tbxtacgia.Location = New System.Drawing.Point(284, 88)
        Me.tbxtacgia.Name = "tbxtacgia"
        Me.tbxtacgia.Size = New System.Drawing.Size(212, 20)
        Me.tbxtacgia.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Thể Loại"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Đơn giá"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tác Giả"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxdongia
        '
        Me.tbxdongia.Location = New System.Drawing.Point(284, 114)
        Me.tbxdongia.Name = "tbxdongia"
        Me.tbxdongia.Size = New System.Drawing.Size(212, 20)
        Me.tbxdongia.TabIndex = 25
        '
        'tbxsoluong
        '
        Me.tbxsoluong.Location = New System.Drawing.Point(284, 213)
        Me.tbxsoluong.Name = "tbxsoluong"
        Me.tbxsoluong.Size = New System.Drawing.Size(212, 20)
        Me.tbxsoluong.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Số Lượng"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(440, 154)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 31
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(348, 154)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 30
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Location = New System.Drawing.Point(247, 154)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btncapnhat.TabIndex = 29
        Me.btncapnhat.Text = "Cập nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tên Sách"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Thể Loại"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmQLSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(760, 643)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQLSach"
        Me.Text = "frmQLSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxtheloai As ComboBox
    Friend WithEvents lbmasach As Label
    Friend WithEvents tbxmasach As TextBox
    Friend WithEvents tbxtensach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxtacgia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxdongia As TextBox
    Friend WithEvents tbxsoluong As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnhuy As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btncapnhat As Button
End Class
