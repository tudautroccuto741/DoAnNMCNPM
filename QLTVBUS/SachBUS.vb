Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class SachBUS
    Private sachDAl As SachDAL
    Public Sub New()
        sachDAl = New SachDAL()
    End Sub
    Public Sub New(connectionString As String)
        sachDAl = New SachDAL(connectionString)
    End Sub
    Public Function isValidName(sach As SachDTO) As Boolean

        If (sach.TenSach.Length < 1) Then
            Return False
        End If

        Return True

    End Function
    Public Function insert(s As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.insert(s)
    End Function

    Public Function update(hs As SachDTO ) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.update(hs)
    End Function

    Public Function buildMaSach(ByRef nextID As String) As Result
        Return sachDAl.getNextID(nextID)
    End Function

    Public Function selectAll(ByRef listTheLoaiSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.selectALL(listTheLoaiSach)
    End Function

    Public Function selectALL_ByMaLoai(maloai As Integer, ByRef listTheLoaiSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.selectALL_ByMaLoai(maloai, listTheLoaiSach)
    End Function
    Public Function selectALL_ByMaSach(masach As String, ByRef listTheLoaiSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.selectALL_ByMaSach(masach, listTheLoaiSach)
    End Function
    Public Function selectALL_ByMaTG(matg As String, ByRef listTheLoaiSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.selectALL_ByMaTG(matg, listTheLoaiSach)
    End Function
    Public Function selectALL_ByTinhTrang(tinhtrang As Integer, ByRef listTheLoaiSach As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.selectALL_ByTinhTrang(tinhtrang, listTheLoaiSach)
    End Function
End Class
