Public Class TheDocGiaDTO
    Private strmathe As String
    Private strhovaten As String
    Private imaloaidocgia As Integer
    Private dtngaysinh As DateTime
    Private strdiachi As String
    Private stremail As String
    Private dtngaylapthe As DateTime



    Public Property Mathe As String
        Get
            Return strmathe
        End Get
        Set(value As String)
            strmathe = value
        End Set
    End Property

    Public Property hovaten As String
        Get
            Return strhovaten
        End Get
        Set(value As String)
            strhovaten = value
        End Set
    End Property

    Public Property maloaidocgia As Integer
        Get
            Return imaloaidocgia
        End Get
        Set(value As Integer)
            imaloaidocgia = value
        End Set
    End Property

    Public Property ngaysinh As Date
        Get
            Return dtngaysinh
        End Get
        Set(value As Date)
            dtngaysinh = value
        End Set
    End Property

    Public Property diachi As String
        Get
            Return strdiachi
        End Get
        Set(value As String)
            strdiachi = value
        End Set
    End Property

    Public Property email As String
        Get
            Return stremail
        End Get
        Set(value As String)
            stremail = value
        End Set
    End Property

    Public Property ngaylapthe As Date
        Get
            Return dtngaylapthe
        End Get
        Set(value As Date)
            dtngaylapthe = value
        End Set
    End Property
End Class
