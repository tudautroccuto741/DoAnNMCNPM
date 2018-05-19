Imports QLTVBUS
Imports QLTVDTO
Imports Utility


Public Class frmTheDocGia

    Private hsBus As TheDocGiaBUS


    Private Sub frmTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hsBus = New TheDocGiaBUS()
        ''   lhsBus = New LoaiHocSinhBUS()

        '' Load LoaiDocGia list
        'Dim listLoaiHocSinh = New List(Of LoaiHocSinhDTO)
        'Dim result As Result
        'result = lhsBus.selectAll(listLoaiHocSinh)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cbLoaiHS.DataSource = New BindingSource(listLoaiHocSinh, String.Empty)
        'cbLoaiHS.DisplayMember = "TenLoai"
        'cbLoaiHS.ValueMember = "MaLoaiHS"

        'set MSSH auto
        Dim nextMshs = "1"
        Dim result As Result
        result = hsBus.buildMadocgia(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Thẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tbxmathe.Text = nextMshs


    End Sub

    Private Sub btNhap_Click(sender As Object, e As EventArgs) Handles btNhap.Click
        Dim docgia As TheDocGiaDTO
        docgia = New TheDocGiaDTO()

        '1. Mapping data from GUI control
        docgia.Mathe = tbxmathe.Text
        docgia.hovaten = tbxHoTen.Text
        docgia.diachi = tbxDiaChi.Text
        docgia.email = tbxEmail.Text
        docgia.ngaylapthe = datiNgaylapthe.Value
        docgia.ngaysinh = datingaysinh.Value
        docgia.maloaidocgia = Convert.ToInt32(tbxloaidocgia.Text)

        ''2. Business .....
        'If (hsBus.isValidName(hocsinh) = False) Then
        '    MessageBox.Show("Họ tên học sinh không đúng")
        '    txtHoTen.Focus()
        '    Return
        'End If
        ''3. Insert to DB
        Dim result As Result
        result = hsBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = hsBus.buildMadocgia(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            tbxmathe.Text = nextMshs
            tbxDiaChi.Text = String.Empty
            tbxHoTen.Text = String.Empty
            tbxEmail.Text = String.Empty
            tbxloaidocgia.Text = String.Empty


        Else
            MessageBox.Show("Thêm Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub datiNgaylapthe_ValueChanged(sender As Object, e As EventArgs) Handles datiNgaylapthe.ValueChanged

    End Sub

    Private Sub datiHansudung_ValueChanged(sender As Object, e As EventArgs) Handles datiHansudung.ValueChanged

    End Sub
End Class
