<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCHONSACH
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnall = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxtensach = New System.Windows.Forms.TextBox()
        Me.btnchon = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(87, 222)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(735, 220)
        Me.TabControl1.TabIndex = 13
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
        Me.dgvsach.MultiSelect = False
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.ReadOnly = True
        Me.dgvsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsach.Size = New System.Drawing.Size(727, 194)
        Me.dgvsach.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnall)
        Me.GroupBox1.Controls.Add(Me.btntim)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbxtensach)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 88)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'btnall
        '
        Me.btnall.Location = New System.Drawing.Point(205, 47)
        Me.btnall.Name = "btnall"
        Me.btnall.Size = New System.Drawing.Size(122, 23)
        Me.btnall.TabIndex = 37
        Me.btnall.Text = "Lấy tất cả đầu sách"
        Me.btnall.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(115, 47)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 36
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
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
        'tbxtensach
        '
        Me.tbxtensach.Location = New System.Drawing.Point(115, 21)
        Me.tbxtensach.Name = "tbxtensach"
        Me.tbxtensach.Size = New System.Drawing.Size(212, 20)
        Me.tbxtensach.TabIndex = 34
        '
        'btnchon
        '
        Me.btnchon.Location = New System.Drawing.Point(308, 459)
        Me.btnchon.Name = "btnchon"
        Me.btnchon.Size = New System.Drawing.Size(75, 23)
        Me.btnchon.TabIndex = 14
        Me.btnchon.Text = "Chọn sách"
        Me.btnchon.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(527, 458)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(75, 23)
        Me.btndong.TabIndex = 15
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(378, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 31)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CHỌN SÁCH"
        '
        'frmCHONSACH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(963, 527)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btnchon)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCHONSACH"
        Me.Text = "frmCHONSACH"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxtensach As TextBox
    Friend WithEvents btnchon As Button
    Friend WithEvents btndong As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btntim As Button
    Friend WithEvents btnall As Button
End Class
