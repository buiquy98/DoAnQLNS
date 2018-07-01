<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoTonGUI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudthang = New System.Windows.Forms.NumericUpDown()
        Me.nudnam = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        CType(Me.nudthang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudnam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(293, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 31)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "LẬP BÁO CÁO TỒN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Chọn tháng báo cáo"
        '
        'nudthang
        '
        Me.nudthang.Location = New System.Drawing.Point(311, 120)
        Me.nudthang.Name = "nudthang"
        Me.nudthang.Size = New System.Drawing.Size(62, 20)
        Me.nudthang.TabIndex = 44
        '
        'nudnam
        '
        Me.nudnam.Location = New System.Drawing.Point(505, 122)
        Me.nudnam.Name = "nudnam"
        Me.nudnam.Size = New System.Drawing.Size(62, 20)
        Me.nudnam.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Năm báo cáo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 81)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BÁO CÁO TỒN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Lập báo cáo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(68, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(735, 276)
        Me.TabControl1.TabIndex = 48
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvsach)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(727, 250)
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
        Me.dgvsach.Size = New System.Drawing.Size(727, 247)
        Me.dgvsach.TabIndex = 0
        '
        'frmLapBaoCaoTonGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 476)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.nudnam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudthang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLapBaoCaoTonGUI"
        Me.Text = "frmLapBaoCaoTonGUI"
        CType(Me.nudthang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudnam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudthang As NumericUpDown
    Friend WithEvents nudnam As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvsach As DataGridView
End Class
