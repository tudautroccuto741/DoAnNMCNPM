Public Class TraCuuDTO
    Private strMasach As String
    Private strTensach As String
    Private strTheloai As String
    Private strTacgia As String
    Private strtinhtrang As String
    Public Sub New()

    End Sub

    Public Sub New(ma As String, ten As String, theloai As String, tacgia As String, tinhtrang As String)
        Me.strMasach = ma
        Me.strTensach = ten
        Me.strTheloai = theloai
        Me.strTacgia = tacgia
        Me.strtinhtrang = tinhtrang

    End Sub

    Public Property Masach As String
        Get
            Return strMasach
        End Get
        Set(value As String)
            strMasach = value
        End Set
    End Property

    Public Property Tensach As String
        Get
            Return strTensach
        End Get
        Set(value As String)
            strTensach = value
        End Set
    End Property

    Public Property Theloai As String
        Get
            Return strTheloai
        End Get
        Set(value As String)
            strTheloai = value
        End Set
    End Property

    Public Property Tacgia As String
        Get
            Return strTacgia
        End Get
        Set(value As String)
            strTacgia = value
        End Set
    End Property

    Public Property tinhtrang As String
        Get
            Return strtinhtrang
        End Get
        Set(value As String)
            strtinhtrang = value
        End Set
    End Property
End Class
