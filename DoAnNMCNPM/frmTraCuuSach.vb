Imports System.Configuration
Imports QLTVBUS
Imports QLTVDTO
Imports Utility
Public Class frmTraCuuSach
    Private sachBus As SachBUS
    Private tlsachBus As TheLoaiSachBUS
    Private tgBus As TacGiaBUS
    Private listsach As List(Of SachDTO)
    Private listtheloai As List(Of TheLoaiSachDTO)
    Private listtacgia As List(Of TacGiaDTO)

    'Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
    '    ' Get the current cell location.
    '    Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected


    '    'Verify that indexing OK
    '    If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
    '        Try

    '            Dim sach As SachDTO
    '            sach = New SachDTO()

    '            '1. Mapping data from GUI control
    '            sach.MaSach = txbMaSach.Text
    '            sach.TenSach = txbTenSach.Text
    '            sach.TinhTrang = txbTinhTrang.Text
    '            sach.MaTacGia = txbTacGia.Text
    '            sach.MaTheLoai = Convert.ToInt32(cbbTheLoaiSach.SelectedValue)
    '            '2. Business .....
    '            If (sachBus.isValidName(sach) = False) Then
    '                MessageBox.Show("Tên sách không đúng.")
    '                txbTenSach.Focus()
    '                Return
    '            End If
    '            '3. Insert to DB
    '            Dim result As Result
    '            result = sachBus.update(sach)
    '            If (result.FlagResult = True) Then
    '                ' Re-Load Sach list
    '                LoadListSach(cbbTheLoaiSach.SelectedValue)
    '                ' Hightlight the row has been updated on table
    '                dgvListSach.Rows(currentRowIndex).Selected = True

    '                MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                System.Console.WriteLine(result.SystemMessage)
    '            End If
    '        Catch ex As Exception
    '            Console.WriteLine(ex.StackTrace)
    '        End Try

    '    End If
    'End Sub

    Private Sub LoadListSach()
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBus.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListSach.SuspendLayout()
        dgvListSach.Columns.Clear()
        dgvListSach.DataSource = Nothing

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.DataSource = listSach

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaSach"
        clMa.HeaderText = "Mã Sách"
        clMa.DataPropertyName = "MaSach"
        dgvListSach.Columns.Add(clMa)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiSach.Name = "LoaiSach"
        'clLoaiSach.HeaderText = "Tên Loại"
        'clLoaiSach.DataPropertyName = "LoaiSach"
        'dgvListSach.Columns.Add(clLoaiSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "TenSach"
        clTenSach.HeaderText = "Tên Sách"
        clTenSach.DataPropertyName = "TenSach"
        dgvListSach.Columns.Add(clTenSach)

        Dim clTheLoai = New DataGridViewTextBoxColumn()
        clTheLoai.Name = "TheLoaiSach"
        clTheLoai.HeaderText = "Thể Loại"
        clTheLoai.DataPropertyName = "TheLoaiSach"
        dgvListSach.Columns.Add(clTheLoai)

        Dim clTinhTrang = New DataGridViewTextBoxColumn()
        clTinhTrang.Name = "TinhTrang"
        clTinhTrang.HeaderText = "Tình trạng"
        clTinhTrang.DataPropertyName = "TinhTrang"
        dgvListSach.Columns.Add(clTinhTrang)
        'dgvListSach.ResumeLayout()

        Dim clTenTG = New DataGridViewTextBoxColumn()
        clTenTG.Name = "MaTacGia"
        clTenTG.HeaderText = "Tác Giả"
        clTenTG.DataPropertyName = "MaTacGia"
        dgvListSach.Columns.Add(clTenTG)
    End Sub

    'Private Sub cbLoaiHS_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbbTheLoaiSach.SelectedIndexChanged

    '    Try
    '        Dim matg = Convert.ToInt32(cbbTheLoaiSach.SelectedValue)
    '        LoadListSach(matg)

    '    Catch ex As Exception

    '    End Try


    'End Sub

    'Private Sub LoadListSach(matg As String)
    '    Throw New NotImplementedException()
    'End Sub


    Private Sub frmTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlsachBus = New TheLoaiSachBUS()
        listtheloai = New List(Of TheLoaiSachDTO)
        listtacgia = New List(Of TacGiaDTO)
        tgBus = New TacGiaBUS()


        Dim result As Result
        result = tlsachBus.selectAll(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lỗi")
            Return
            Me.Close()
        End If

        cbbTheLoaiSach.DataSource = listtheloai
        cbbTheLoaiSach.DisplayMember = "TenTheLoaiSach"
        cbbTheLoaiSach.ValueMember = "MaTheLoaiSach"

        result = tgBus.selectALL(listtacgia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lỗi")
            Return
            Me.Close()
        End If

        cbbTacGia.DataSource = listtacgia
        cbbTacGia.DisplayMember = "TenTacGia"
        cbbTacGia.ValueMember = "MaTacGia"

    End Sub


    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click

    End Sub

    Private Sub cbbTheLoaiSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTheLoaiSach.SelectedIndexChanged
        Dim theloai = New TheLoaiSachDTO()
        theloai = cbbTheLoaiSach.SelectedItem

    End Sub

    Private Sub cbbTacGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTacGia.SelectedIndexChanged
        Dim tg = New TacGiaDTO()
        tg = cbbTacGia.SelectedItem

    End Sub

    Private Function buildgv(listsach As List(Of TraCuuDTO)) As Boolean

        ' dgv.DataSource = Nothing
        dgvListSach.Columns.Clear()

        dgvListSach.AutoGenerateColumns = False
        dgvListSach.AllowUserToAddRows = False
        dgvListSach.Enabled = True
        dgvListSach.DataSource = listsach

        Dim clmasach = New DataGridViewTextBoxColumn()
        clmasach.Name = "masach"
        clmasach.HeaderText = "Mã Sách"
        clmasach.DataPropertyName = "masach"
        dgvListSach.Columns.Add(clmasach)
        clmasach.ReadOnly = True

        Dim cltensach = New DataGridViewTextBoxColumn()
        cltensach.Name = "tensach"
        cltensach.HeaderText = "Tên Sách"
        cltensach.DataPropertyName = "tensach"
        dgvListSach.Columns.Add(cltensach)
        cltensach.ReadOnly = True

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "theloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "theloai"
        dgvListSach.Columns.Add(cltheloai)
        cltheloai.ReadOnly = True

        Dim cltacgia = New DataGridViewTextBoxColumn()
        cltacgia.Name = "tacgia"
        cltacgia.HeaderText = "Tác giả"
        cltacgia.DataPropertyName = "tacgia"
        dgvListSach.Columns.Add(cltacgia)
        cltacgia.ReadOnly = True

        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "tinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "tinhtrang"
        dgvListSach.Columns.Add(cltinhtrang)
        cltinhtrang.ReadOnly = True

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListSach.DataSource)
        myCurrencyManager.Refresh()


        Return True
    End Function

End Class