<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheLoai
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
        Me.tbxmatheloai = New System.Windows.Forms.TextBox()
        Me.tbxtentheloai = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã thể loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Thể Loại"
        '
        'tbxmatheloai
        '
        Me.tbxmatheloai.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbxmatheloai.Location = New System.Drawing.Point(129, 32)
        Me.tbxmatheloai.Name = "tbxmatheloai"
        Me.tbxmatheloai.Size = New System.Drawing.Size(100, 20)
        Me.tbxmatheloai.TabIndex = 2
        Me.tbxmatheloai.Text = "<Tự động>"
        Me.tbxmatheloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxtentheloai
        '
        Me.tbxtentheloai.Location = New System.Drawing.Point(129, 69)
        Me.tbxtentheloai.Name = "tbxtentheloai"
        Me.tbxtentheloai.Size = New System.Drawing.Size(100, 20)
        Me.tbxtentheloai.TabIndex = 3
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(129, 124)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thể loại"
        '
        'frmTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(303, 177)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.tbxtentheloai)
        Me.Controls.Add(Me.tbxmatheloai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTheLoai"
        Me.Text = "frmTheLoai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxmatheloai As TextBox
    Friend WithEvents tbxtentheloai As TextBox
    Friend WithEvents btnthem As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
