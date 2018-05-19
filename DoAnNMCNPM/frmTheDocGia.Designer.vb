<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheDocGia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxHoTen = New System.Windows.Forms.TextBox()
        Me.tbxDiaChi = New System.Windows.Forms.TextBox()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.datingaysinh = New System.Windows.Forms.DateTimePicker()
        Me.datiHansudung = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datiNgaylapthe = New System.Windows.Forms.DateTimePicker()
        Me.btNhap = New System.Windows.Forms.Button()
        Me.tbxloaidocgia = New System.Windows.Forms.TextBox()
        Me.tbxmathe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tbxHoTen
        '
        resources.ApplyResources(Me.tbxHoTen, "tbxHoTen")
        Me.tbxHoTen.Name = "tbxHoTen"
        '
        'tbxDiaChi
        '
        resources.ApplyResources(Me.tbxDiaChi, "tbxDiaChi")
        Me.tbxDiaChi.Name = "tbxDiaChi"
        '
        'tbxEmail
        '
        resources.ApplyResources(Me.tbxEmail, "tbxEmail")
        Me.tbxEmail.Name = "tbxEmail"
        '
        'datingaysinh
        '
        resources.ApplyResources(Me.datingaysinh, "datingaysinh")
        Me.datingaysinh.MaxDate = New Date(2055, 12, 31, 0, 0, 0, 0)
        Me.datingaysinh.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.datingaysinh.Name = "datingaysinh"
        '
        'datiHansudung
        '
        resources.ApplyResources(Me.datiHansudung, "datiHansudung")
        Me.datiHansudung.Name = "datiHansudung"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'datiNgaylapthe
        '
        resources.ApplyResources(Me.datiNgaylapthe, "datiNgaylapthe")
        Me.datiNgaylapthe.Name = "datiNgaylapthe"
        '
        'btNhap
        '
        resources.ApplyResources(Me.btNhap, "btNhap")
        Me.btNhap.Name = "btNhap"
        Me.btNhap.UseVisualStyleBackColor = True
        '
        'tbxloaidocgia
        '
        resources.ApplyResources(Me.tbxloaidocgia, "tbxloaidocgia")
        Me.tbxloaidocgia.Name = "tbxloaidocgia"
        '
        'tbxmathe
        '
        resources.ApplyResources(Me.tbxmathe, "tbxmathe")
        Me.tbxmathe.Name = "tbxmathe"
        Me.tbxmathe.ReadOnly = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'frmTheDocGia
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbxmathe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btNhap)
        Me.Controls.Add(Me.datiNgaylapthe)
        Me.Controls.Add(Me.datiHansudung)
        Me.Controls.Add(Me.datingaysinh)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.tbxDiaChi)
        Me.Controls.Add(Me.tbxloaidocgia)
        Me.Controls.Add(Me.tbxHoTen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTheDocGia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxHoTen As TextBox
    Friend WithEvents tbxDiaChi As TextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents datingaysinh As DateTimePicker
    Friend WithEvents datiHansudung As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents datiNgaylapthe As DateTimePicker
    Friend WithEvents btNhap As Button
    Friend WithEvents tbxloaidocgia As TextBox
    Friend WithEvents tbxmathe As TextBox
    Friend WithEvents Label8 As Label
End Class
