﻿Imports QLTVBUS
Imports QLTVDTO
Imports Utility


Public Class frmTheDocGia

    Private ldgBus As LoaiDocGiaBUS


    Private hsBus As TheDocGiaBUS


    Private Sub frmTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hsBus = New TheDocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()
        ''   lhsBus = New LoaiHocSinhBUS()

        '' Load LoaiDocGia list
        'Dim listLoaiDocGia = New List(Of LoaiHocSinhDTO)
        'Dim result As Result
        'result = lhsBus.selectAll(listLoaiDocGia)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        'cbLoaiDG.DisplayMember = "TenLoai"
        'cbLoaiDG.ValueMember = "MaLoaiHS"

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
        docgia.maloaidocgia = Convert.ToInt32(cbbLoaidocgia.Text)

        ''2. Business .....
        'If (hsBus.isValidName(docgia) = False) Then
        '    MessageBox.Show("Họ tên độc giả không đúng")
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
            cbbLoaidocgia.Text = String.Empty


        Else
            MessageBox.Show("Thêm Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load LoaiHocSinh list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbbLoaidocgia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbbLoaidocgia.DisplayMember = "TenLoai"
        cbbLoaidocgia.ValueMember = "MaLoaiDG"

    End Sub

End Class
