<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuSach
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
        Me.dgvListSach = New System.Windows.Forms.DataGridView()
        Me.cbbTheLoaiSach = New System.Windows.Forms.ComboBox()
        Me.txbTenSach = New System.Windows.Forms.TextBox()
        Me.txbMaSach = New System.Windows.Forms.TextBox()
        Me.txbTinhTrang = New System.Windows.Forms.TextBox()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.cbbTacGia = New System.Windows.Forms.ComboBox()
        Me.btntim = New System.Windows.Forms.Button()
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sách: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tác Giả: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã Sách: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thể Loại:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tình Trạng: "
        '
        'dgvListSach
        '
        Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSach.Location = New System.Drawing.Point(43, 107)
        Me.dgvListSach.Name = "dgvListSach"
        Me.dgvListSach.Size = New System.Drawing.Size(669, 220)
        Me.dgvListSach.TabIndex = 5
        '
        'cbbTheLoaiSach
        '
        Me.cbbTheLoaiSach.FormattingEnabled = True
        Me.cbbTheLoaiSach.Location = New System.Drawing.Point(119, 12)
        Me.cbbTheLoaiSach.Name = "cbbTheLoaiSach"
        Me.cbbTheLoaiSach.Size = New System.Drawing.Size(187, 21)
        Me.cbbTheLoaiSach.TabIndex = 6
        '
        'txbTenSach
        '
        Me.txbTenSach.Location = New System.Drawing.Point(119, 56)
        Me.txbTenSach.Name = "txbTenSach"
        Me.txbTenSach.Size = New System.Drawing.Size(207, 20)
        Me.txbTenSach.TabIndex = 7
        '
        'txbMaSach
        '
        Me.txbMaSach.Location = New System.Drawing.Point(115, 342)
        Me.txbMaSach.Name = "txbMaSach"
        Me.txbMaSach.ReadOnly = True
        Me.txbMaSach.Size = New System.Drawing.Size(172, 20)
        Me.txbMaSach.TabIndex = 9
        '
        'txbTinhTrang
        '
        Me.txbTinhTrang.Location = New System.Drawing.Point(395, 342)
        Me.txbTinhTrang.Name = "txbTinhTrang"
        Me.txbTinhTrang.Size = New System.Drawing.Size(221, 20)
        Me.txbTinhTrang.TabIndex = 10
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(165, 390)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(141, 33)
        Me.btCapNhat.TabIndex = 11
        Me.btCapNhat.Text = "Cập nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(395, 390)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(141, 33)
        Me.btXoa.TabIndex = 12
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'cbbTacGia
        '
        Me.cbbTacGia.FormattingEnabled = True
        Me.cbbTacGia.Location = New System.Drawing.Point(395, 12)
        Me.cbbTacGia.Name = "cbbTacGia"
        Me.cbbTacGia.Size = New System.Drawing.Size(218, 21)
        Me.cbbTacGia.TabIndex = 13
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(637, 10)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 14
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'frmTraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 432)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.cbbTacGia)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.txbTinhTrang)
        Me.Controls.Add(Me.txbMaSach)
        Me.Controls.Add(Me.txbTenSach)
        Me.Controls.Add(Me.cbbTheLoaiSach)
        Me.Controls.Add(Me.dgvListSach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTraCuuSach"
        Me.Text = "Tra cứu sách"
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvListSach As DataGridView
    Friend WithEvents cbbTheLoaiSach As ComboBox
    Friend WithEvents txbTenSach As TextBox
    Friend WithEvents txbMaSach As TextBox
    Friend WithEvents txbTinhTrang As TextBox
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents cbbTacGia As ComboBox
    Friend WithEvents btntim As Button
End Class
