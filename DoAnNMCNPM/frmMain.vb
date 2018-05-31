Public Class frmMain
    Private Sub btnThemdocgia_Click(sender As Object, e As EventArgs) Handles btThemdocgia.Click
        Dim newform = New frmTheDocGia()
        newform.ShowDialog(Me)
    End Sub

    Private Sub btnThemthongtinsach_Click(sender As Object, e As EventArgs) Handles btThemthongtinsach.Click
        Dim newform = New frmThongTinSach()
        newform.ShowDialog(Me)
    End Sub
End Class