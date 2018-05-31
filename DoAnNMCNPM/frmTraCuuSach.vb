Imports System.Configuration
Imports QLTVBUS
Imports QLTVDTO
Imports Utility
Public Class frmTraCuuSach
    Private sachBus As SachBUS
    Private tlsachBus As TheLoaiSachBUS

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
            Try

                Dim sach As SachDTO
                sach = New SachDTO()

                '1. Mapping data from GUI control
                sach.MaSach = txbMaSach.Text
                sach.TenSach = txbTenSach.Text
                sach.TinhTrang = txbTinhTrang.Text
                sach.NgaySinh = dtpNgaySinh.Value
                sach.LoaiHS = Convert.ToInt32(cbLoaiHSCapNhat.SELECTedValue)
                '2. Business .....
                If (hsBus.isValidName(hocsinh) = False) Then
                    MessageBox.Show("Họ tên Học sinh không đúng.")
                    txtHoTen.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = hsBus.update(hocsinh)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListHocSinh(cbLoaiHS.SELECTedValue)
                    ' Hightlight the row has been updated on table
                    dgvListHS.Rows(currentRowIndex).SELECTed = True

                    MessageBox.Show("Cập nhật Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class