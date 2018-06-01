<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpThẻĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.KháchHàngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1216, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'QuảnLíToolStripMenuItem
        '
        Me.QuảnLíToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpThẻĐọcGiảToolStripMenuItem})
        Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
        Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.QuảnLíToolStripMenuItem.Text = "Quản Lý Sách"
        '
        'LậpThẻĐọcGiảToolStripMenuItem
        '
        Me.LậpThẻĐọcGiảToolStripMenuItem.Name = "LậpThẻĐọcGiảToolStripMenuItem"
        Me.LậpThẻĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.LậpThẻĐọcGiảToolStripMenuItem.Text = "Lập Phiếu Nhập Sách"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmToolStripMenuItem, Me.QuảnLíKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'ThêmToolStripMenuItem
        '
        Me.ThêmToolStripMenuItem.Name = "ThêmToolStripMenuItem"
        Me.ThêmToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.ThêmToolStripMenuItem.Text = "Thêm Khách Hàng Mới"
        '
        'QuảnLíKháchHàngToolStripMenuItem
        '
        Me.QuảnLíKháchHàngToolStripMenuItem.Name = "QuảnLíKháchHàngToolStripMenuItem"
        Me.QuảnLíKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.QuảnLíKháchHàngToolStripMenuItem.Text = "Quản Lí Khách Hàng"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 799)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpThẻĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíKháchHàngToolStripMenuItem As ToolStripMenuItem
End Class
