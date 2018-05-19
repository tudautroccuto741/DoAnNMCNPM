Public Class LoaiDocGiaDTO
    Private iMaLoaiDG As Integer
    Private strTenLoai As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        iMaLoaiDG = ml
        strTenLoai = tl
    End Sub
    Property MaLoaiDG() As Integer
        Get
            Return iMaLoaiDG
        End Get
        Set(ByVal Value As Integer)
            iMaLoaiDG = Value
        End Set
    End Property
    Property TenLoai() As String
        Get
            Return strTenLoai
        End Get
        Set(ByVal Value As String)
            strTenLoai = Value
        End Set
    End Property

End Class
