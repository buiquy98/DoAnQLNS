<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPhieuNhapSach
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.tbxmaphieunhap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbxquidinh2 = New System.Windows.Forms.TextBox()
        Me.tbxquidinh1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbxsoluongnhap = New System.Windows.Forms.TextBox()
        Me.tbxmasach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(300, 44)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(325, 31)
        Me.lblMain.TabIndex = 58
        Me.lblMain.Text = "LẬP PHIẾU NHẬP SÁCH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpngaynhap)
        Me.GroupBox1.Controls.Add(Me.tbxmaphieunhap)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 100)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu nhập"
        '
        'dtpngaynhap
        '
        Me.dtpngaynhap.Location = New System.Drawing.Point(117, 66)
        Me.dtpngaynhap.Name = "dtpngaynhap"
        Me.dtpngaynhap.Size = New System.Drawing.Size(224, 20)
        Me.dtpngaynhap.TabIndex = 3
        '
        'tbxmaphieunhap
        '
        Me.tbxmaphieunhap.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxmaphieunhap.Enabled = False
        Me.tbxmaphieunhap.Location = New System.Drawing.Point(117, 32)
        Me.tbxmaphieunhap.Name = "tbxmaphieunhap"
        Me.tbxmaphieunhap.Size = New System.Drawing.Size(224, 20)
        Me.tbxmaphieunhap.TabIndex = 2
        Me.tbxmaphieunhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ngày Nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Nhập:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.tbxquidinh2)
        Me.GroupBox2.Controls.Add(Me.tbxquidinh1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 100)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quy Định"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Thay đổi qui định"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbxquidinh2
        '
        Me.tbxquidinh2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxquidinh2.Enabled = False
        Me.tbxquidinh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxquidinh2.Location = New System.Drawing.Point(167, 63)
        Me.tbxquidinh2.Name = "tbxquidinh2"
        Me.tbxquidinh2.Size = New System.Drawing.Size(224, 22)
        Me.tbxquidinh2.TabIndex = 3
        '
        'tbxquidinh1
        '
        Me.tbxquidinh1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbxquidinh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxquidinh1.Location = New System.Drawing.Point(167, 32)
        Me.tbxquidinh1.Name = "tbxquidinh1"
        Me.tbxquidinh1.Size = New System.Drawing.Size(224, 22)
        Me.tbxquidinh1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Số lượng tồn tối đa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số lượng nhập tối thiểu"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(58, 313)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(744, 191)
        Me.TabControl2.TabIndex = 61
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvsach)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(736, 165)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Chi tiết phiếu nhập"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvsach
        '
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(6, 6)
        Me.dgvsach.MultiSelect = False
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.Size = New System.Drawing.Size(724, 153)
        Me.dgvsach.TabIndex = 19
        '
        'btnluu
        '
        Me.btnluu.Location = New System.Drawing.Point(306, 645)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(75, 23)
        Me.btnluu.TabIndex = 63
        Me.btnluu.Text = "Lưu"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(426, 645)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "In"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(58, 510)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 65
        Me.btnthem.Text = "Thêm sách"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbxsoluongnhap)
        Me.GroupBox3.Controls.Add(Me.tbxmasach)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 562)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(740, 77)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin nhập"
        '
        'tbxsoluongnhap
        '
        Me.tbxsoluongnhap.Location = New System.Drawing.Point(205, 44)
        Me.tbxsoluongnhap.Name = "tbxsoluongnhap"
        Me.tbxsoluongnhap.Size = New System.Drawing.Size(267, 20)
        Me.tbxsoluongnhap.TabIndex = 3
        '
        'tbxmasach
        '
        Me.tbxmasach.Enabled = False
        Me.tbxmasach.Location = New System.Drawing.Point(205, 17)
        Me.tbxmasach.Name = "tbxmasach"
        Me.tbxmasach.Size = New System.Drawing.Size(267, 20)
        Me.tbxmasach.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Số lượng nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã sách"
        '
        'FrmPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(956, 728)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnluu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "FrmPhieuNhapSach"
        Me.Text = "FrmPhieuNhapSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpngaynhap As DateTimePicker
    Friend WithEvents tbxmaphieunhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbxquidinh2 As TextBox
    Friend WithEvents tbxquidinh1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents btnluu As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbxsoluongnhap As TextBox
    Friend WithEvents tbxmasach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
