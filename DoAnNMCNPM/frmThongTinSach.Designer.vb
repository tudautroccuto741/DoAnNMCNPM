<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongTinSach
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
        Me.tbxTensach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxTrigia = New System.Windows.Forms.TextBox()
        Me.tbxNhaxuatban = New System.Windows.Forms.TextBox()
        Me.datiNgaynhap = New System.Windows.Forms.DateTimePicker()
        Me.btNhap = New System.Windows.Forms.Button()
        Me.tbxMasach = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxNamxuatban = New System.Windows.Forms.TextBox()
        Me.cbbTheLoai = New System.Windows.Forms.ComboBox()
        Me.cbbTacGia = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên sách: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tác giả: "
        '
        'tbxTensach
        '
        Me.tbxTensach.Location = New System.Drawing.Point(131, 58)
        Me.tbxTensach.Name = "tbxTensach"
        Me.tbxTensach.Size = New System.Drawing.Size(170, 20)
        Me.tbxTensach.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Thể loại: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nhà xuất bản"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ngày nhập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Năm xuất bản: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(356, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Trị giá: "
        '
        'tbxTrigia
        '
        Me.tbxTrigia.Location = New System.Drawing.Point(131, 279)
        Me.tbxTrigia.Name = "tbxTrigia"
        Me.tbxTrigia.Size = New System.Drawing.Size(170, 20)
        Me.tbxTrigia.TabIndex = 13
        '
        'tbxNhaxuatban
        '
        Me.tbxNhaxuatban.Location = New System.Drawing.Point(131, 172)
        Me.tbxNhaxuatban.Name = "tbxNhaxuatban"
        Me.tbxNhaxuatban.Size = New System.Drawing.Size(170, 20)
        Me.tbxNhaxuatban.TabIndex = 14
        '
        'datiNgaynhap
        '
        Me.datiNgaynhap.Location = New System.Drawing.Point(131, 240)
        Me.datiNgaynhap.Name = "datiNgaynhap"
        Me.datiNgaynhap.Size = New System.Drawing.Size(170, 20)
        Me.datiNgaynhap.TabIndex = 16
        '
        'btNhap
        '
        Me.btNhap.Location = New System.Drawing.Point(225, 326)
        Me.btNhap.Name = "btNhap"
        Me.btNhap.Size = New System.Drawing.Size(135, 57)
        Me.btNhap.TabIndex = 18
        Me.btNhap.Text = "Nhập"
        Me.btNhap.UseVisualStyleBackColor = True
        '
        'tbxMasach
        '
        Me.tbxMasach.Location = New System.Drawing.Point(131, 23)
        Me.tbxMasach.Name = "tbxMasach"
        Me.tbxMasach.ReadOnly = True
        Me.tbxMasach.Size = New System.Drawing.Size(170, 20)
        Me.tbxMasach.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mã Sách"
        '
        'tbxNamxuatban
        '
        Me.tbxNamxuatban.Location = New System.Drawing.Point(131, 204)
        Me.tbxNamxuatban.Name = "tbxNamxuatban"
        Me.tbxNamxuatban.Size = New System.Drawing.Size(170, 20)
        Me.tbxNamxuatban.TabIndex = 21
        '
        'cbbTheLoai
        '
        Me.cbbTheLoai.FormattingEnabled = True
        Me.cbbTheLoai.Location = New System.Drawing.Point(132, 131)
        Me.cbbTheLoai.Name = "cbbTheLoai"
        Me.cbbTheLoai.Size = New System.Drawing.Size(168, 21)
        Me.cbbTheLoai.TabIndex = 22
        '
        'cbbTacGia
        '
        Me.cbbTacGia.FormattingEnabled = True
        Me.cbbTacGia.Location = New System.Drawing.Point(130, 93)
        Me.cbbTacGia.Name = "cbbTacGia"
        Me.cbbTacGia.Size = New System.Drawing.Size(170, 21)
        Me.cbbTacGia.TabIndex = 23
        '
        'frmThongTinSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 408)
        Me.Controls.Add(Me.cbbTacGia)
        Me.Controls.Add(Me.cbbTheLoai)
        Me.Controls.Add(Me.tbxNamxuatban)
        Me.Controls.Add(Me.tbxMasach)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btNhap)
        Me.Controls.Add(Me.datiNgaynhap)
        Me.Controls.Add(Me.tbxNhaxuatban)
        Me.Controls.Add(Me.tbxTrigia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxTensach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThongTinSach"
        Me.Text = "Thông Tin Sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxTensach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxTrigia As TextBox
    Friend WithEvents tbxNhaxuatban As TextBox
    Friend WithEvents datiNgaynhap As DateTimePicker
    Friend WithEvents btNhap As Button
    Friend WithEvents tbxMasach As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxNamxuatban As TextBox
    Friend WithEvents cbbTheLoai As ComboBox
    Friend WithEvents cbbTacGia As ComboBox
End Class
