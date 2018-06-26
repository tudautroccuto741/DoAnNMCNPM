<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuMuonSach
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
        Me.dgvMuonsach = New System.Windows.Forms.DataGridView()
        Me.txbHoTenDG = New System.Windows.Forms.TextBox()
        Me.btnIN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbMaThe = New System.Windows.Forms.TextBox()
        Me.datiNgayMuon = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvMuonsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ Tên Độc Giả: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ngày Mượn: "
        '
        'dgvMuonsach
        '
        Me.dgvMuonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuonsach.Location = New System.Drawing.Point(71, 79)
        Me.dgvMuonsach.Name = "dgvMuonsach"
        Me.dgvMuonsach.Size = New System.Drawing.Size(509, 190)
        Me.dgvMuonsach.TabIndex = 2
        '
        'txbHoTenDG
        '
        Me.txbHoTenDG.Location = New System.Drawing.Point(100, 4)
        Me.txbHoTenDG.Name = "txbHoTenDG"
        Me.txbHoTenDG.Size = New System.Drawing.Size(244, 20)
        Me.txbHoTenDG.TabIndex = 3
        '
        'btnIN
        '
        Me.btnIN.Location = New System.Drawing.Point(224, 278)
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(147, 44)
        Me.btnIN.TabIndex = 5
        Me.btnIN.Text = "IN"
        Me.btnIN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã Thẻ: "
        '
        'txbMaThe
        '
        Me.txbMaThe.Location = New System.Drawing.Point(425, 5)
        Me.txbMaThe.Name = "txbMaThe"
        Me.txbMaThe.ReadOnly = True
        Me.txbMaThe.Size = New System.Drawing.Size(173, 20)
        Me.txbMaThe.TabIndex = 7
        '
        'datiNgayMuon
        '
        Me.datiNgayMuon.Location = New System.Drawing.Point(82, 39)
        Me.datiNgayMuon.Name = "datiNgayMuon"
        Me.datiNgayMuon.Size = New System.Drawing.Size(261, 20)
        Me.datiNgayMuon.TabIndex = 8
        '
        'frmPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 334)
        Me.Controls.Add(Me.datiNgayMuon)
        Me.Controls.Add(Me.txbMaThe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIN)
        Me.Controls.Add(Me.txbHoTenDG)
        Me.Controls.Add(Me.dgvMuonsach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPhieuMuonSach"
        Me.Text = "frmPhieuMuonSach"
        CType(Me.dgvMuonsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMuonsach As DataGridView
    Friend WithEvents txbHoTenDG As TextBox
    Friend WithEvents btnIN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txbMaThe As TextBox
    Friend WithEvents datiNgayMuon As DateTimePicker
End Class
