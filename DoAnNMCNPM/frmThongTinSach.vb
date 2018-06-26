Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThongTinSach
    Private lsBus As TheLoaiSachBUS
    Private tgBus As TacGiaBUS
    Private sbus As SachBUS
    Private Sub frmThongTinSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sbus = New SachBUS()
        lsBus = New TheLoaiSachBUS()


        Dim nextMshs = "1"
        Dim result As Result
        result = sbus.buildMaSach(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tbxMasach.Text = nextMshs
    End Sub

    Private Sub btNhap_Click(sender As Object, e As EventArgs) Handles btNhap.Click
        Dim sach As SachDTO
        sach = New SachDTO()

        '1. Mapping data from GUI control
        sach.MaSach = tbxMasach.Text
        sach.TenSach = tbxTensach.Text
        sach.MaTacGia = Convert.ToString(cbbTacGia.Text)
        sach.NamXuatBan = tbxNamxuatban.Text
        sach.NgayNhap = datiNgaynhap.Value
        sach.NhaXuatBan = tbxNhaxuatban.Text
        sach.TriGia = tbxTrigia.Text
        sach.TinhTrang = 1
        sach.MaTheLoai = Convert.ToString(cbbTheLoai.Text)

        ''2. Business .....
        'If (hsBus.isValidName(docgia) = False) Then
        '    MessageBox.Show("Họ tên độc giả không đúng")
        '    txtHoTen.Focus()
        '    Return
        'End If
        ''3. Insert to DB
        Dim result As Result
        result = sbus.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMsS = "1"
            result = sbus.buildMaSach(nextMsS)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            tbxMasach.Text = nextMsS
            tbxTensach.Text = String.Empty
            cbbTacGia.Text = String.Empty
            tbxNhaxuatban.Text = String.Empty
            cbbTheLoai.Text = String.Empty
            tbxTrigia.Text = String.Empty
            tbxNamxuatban.Text = String.Empty

        Else
            MessageBox.Show("Thêm Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load TheLoaiSach list
        Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
        Dim result As Result
        result = lsBus.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        cbbTheLoai.DisplayMember = "TenTheLoaiSach"
        cbbTheLoai.ValueMember = "MaTheLoaiSach"

    End Sub

    Private Sub frmTacGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim listTacGia = New List(Of TacGiaDTO)

        Dim result As Result
        result = tgBus.selectALL(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        cbbTacGia.DisplayMember = "TenTacGia"
        cbbTacGia.ValueMember = "MaTacGia"

    End Sub
End Class