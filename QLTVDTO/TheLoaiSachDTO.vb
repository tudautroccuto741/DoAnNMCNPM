Public Class TheLoaiSachDTO
    Private strMaTheLoaiSach As Integer
    Private strTenTheLoaiSach As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        strMaTheLoaiSach = ml
        strTenTheLoaiSach = tl
    End Sub
    Public Property MaTheLoaiSach As String
        Get
            Return strMaTheLoaiSach
        End Get
        Set(value As String)
            strMaTheLoaiSach = value
        End Set
    End Property
    Property TenTheLoaiSach() As String
        Get
            Return strTenTheLoaiSach
        End Get
        Set(ByVal Value As String)
            strTenTheLoaiSach = Value
        End Set
    End Property

End Class
