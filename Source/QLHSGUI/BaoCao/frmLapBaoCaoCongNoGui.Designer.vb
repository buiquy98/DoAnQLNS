<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoCongNoGui
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvkh = New System.Windows.Forms.DataGridView()
        Me.nudnam = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudthang = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudnam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudthang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(363, 58)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(408, 39)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "LẬP BÁO CÁO CÔNG NỢ"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(96, 218)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(871, 340)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvkh)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(863, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh sách khách hàng"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvkh
        '
        Me.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkh.Location = New System.Drawing.Point(0, 0)
        Me.dgvkh.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvkh.MultiSelect = False
        Me.dgvkh.Name = "dgvkh"
        Me.dgvkh.ReadOnly = True
        Me.dgvkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkh.Size = New System.Drawing.Size(861, 304)
        Me.dgvkh.TabIndex = 0
        '
        'nudnam
        '
        Me.nudnam.Location = New System.Drawing.Point(679, 156)
        Me.nudnam.Margin = New System.Windows.Forms.Padding(4)
        Me.nudnam.Name = "nudnam"
        Me.nudnam.Size = New System.Drawing.Size(83, 22)
        Me.nudnam.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(576, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Năm báo cáo"
        '
        'nudthang
        '
        Me.nudthang.Location = New System.Drawing.Point(420, 154)
        Me.nudthang.Margin = New System.Windows.Forms.Padding(4)
        Me.nudthang.Name = "nudthang"
        Me.nudthang.Size = New System.Drawing.Size(83, 22)
        Me.nudthang.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Chọn tháng báo cáo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(101, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(865, 100)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BÁO CÁO TỒN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(689, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Lập báo cáo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLapBaoCaoCongNoGui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.nudnam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudthang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLapBaoCaoCongNoGui"
        Me.Text = "frmLapBaoCaoCongNoGui"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudnam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudthang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvkh As DataGridView
    Friend WithEvents nudnam As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nudthang As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
End Class
