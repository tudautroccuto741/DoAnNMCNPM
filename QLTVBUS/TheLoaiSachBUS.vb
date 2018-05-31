Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheLoaiSachBUS
    Private lsDAL As TheLoaiSachDAL
    Public Sub New()
        lsDAL = New TheLoaiSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        lsDAL = New TheLoaiSachDAL(connectionString)
    End Sub
    Public Function isValidName(ls As TheLoaiSachDTO) As Boolean

        If (ls.TenTheLoaiSach.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(ls As TheLoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.insert(ls)
    End Function
    Public Function update(ls As TheLoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.update(ls)
    End Function
    Public Function delete(maTheLoaiSach As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.delete(maTheLoaiSach)
    End Function
    Public Function selectAll(ByRef listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.selectALL(listTheLoaiSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lsDAL.getNextID(nextID)
    End Function

End Class
