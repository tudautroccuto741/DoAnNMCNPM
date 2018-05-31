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
        Me.btThemdocgia = New System.Windows.Forms.Button()
        Me.btThemthongtinsach = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btThemdocgia
        '
        Me.btThemdocgia.Location = New System.Drawing.Point(123, 70)
        Me.btThemdocgia.Name = "btThemdocgia"
        Me.btThemdocgia.Size = New System.Drawing.Size(212, 56)
        Me.btThemdocgia.TabIndex = 0
        Me.btThemdocgia.Text = "Thêm độc giả"
        Me.btThemdocgia.UseVisualStyleBackColor = True
        '
        'btThemthongtinsach
        '
        Me.btThemthongtinsach.Location = New System.Drawing.Point(436, 69)
        Me.btThemthongtinsach.Name = "btThemthongtinsach"
        Me.btThemthongtinsach.Size = New System.Drawing.Size(212, 59)
        Me.btThemthongtinsach.TabIndex = 1
        Me.btThemthongtinsach.Text = "Thêm Thông Tin Sách"
        Me.btThemthongtinsach.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 337)
        Me.Controls.Add(Me.btThemthongtinsach)
        Me.Controls.Add(Me.btThemdocgia)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btThemdocgia As Button
    Friend WithEvents btThemthongtinsach As Button
End Class
