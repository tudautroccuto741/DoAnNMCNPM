Public Class TacGiaDTO
    Private iMaTacGia As Integer
    Private strTenTacGia As String

    Public Property MaTacGia As Integer
        Get
            Return iMaTacGia
        End Get
        Set(value As Integer)
            iMaTacGia = value
        End Set
    End Property

    Public Property TenTacGia As String
        Get
            Return strTenTacGia
        End Get
        Set(value As String)
            strTenTacGia = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(matg As Integer, tentg As String)
        Me.iMaTacGia = matg
        Me.strTenTacGia = tentg
    End Sub
End Class
