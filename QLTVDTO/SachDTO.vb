Public Class SachDTO
    Private strMaSach As String
    Private strTenSach As String
    Private strMaTheLoai As String
    Private strMaTacGia As String
    Private iNamXuatBan As Integer
    Private strNhaXuatBan As String
    Private dtNgayNhap As DateTime
    Private iTriGia As Integer
    Private iTinhTrang As Integer

    Public Sub New()

    End Sub

    Public Sub New(masach As String, tensach As String, matheloai As String, matacgia As String, namxb As Integer, nhaxb As String, ngaynhap As DateTime, trigia As Integer, tinhtrang As Integer)
        Me.strMaSach = masach
        Me.strTenSach = tensach
        Me.strMaTacGia = matacgia
        Me.strMaTheLoai = matheloai
        Me.iNamXuatBan = namxb
        Me.strNhaXuatBan = nhaxb
        Me.dtNgayNhap = ngaynhap
        Me.iTriGia = trigia
        Me.iTinhTrang = tinhtrang

    End Sub

    Public Property MaSach As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property MaTheLoai As String
        Get
            Return strMaTheLoai
        End Get
        Set(value As String)
            strMaTheLoai = value
        End Set
    End Property

    Public Property MaTacGia As String
        Get
            Return strMaTacGia
        End Get
        Set(value As String)
            strMaTacGia = value
        End Set
    End Property

    Public Property NamXuatBan As Integer
        Get
            Return iNamXuatBan
        End Get
        Set(value As Integer)
            iNamXuatBan = value
        End Set
    End Property

    Public Property NhaXuatBan As String
        Get
            Return strNhaXuatBan
        End Get
        Set(value As String)
            strNhaXuatBan = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return dtNgayNhap
        End Get
        Set(value As Date)
            dtNgayNhap = value
        End Set
    End Property

    Public Property TriGia As Integer
        Get
            Return iTriGia
        End Get
        Set(value As Integer)
            iTriGia = value
        End Set
    End Property

    Public Property TinhTrang As Integer
        Get
            Return iTinhTrang
        End Get
        Set(value As Integer)
            iTinhTrang = value
        End Set
    End Property
End Class
