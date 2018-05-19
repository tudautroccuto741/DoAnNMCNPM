Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheDocGiaBUS
    Private dgDAL As TheDocGiaDAL
    Public Sub New()
        dgDAL = New TheDocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New TheDocGiaDAL(connectionString)
    End Sub

    Public Function isValidName(dg As TheDocGiaDTO) As Boolean

        If (dg.hovaten.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(dg As TheDocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function

    Public Function buildMadocgia(ByRef nextMaDg As String) As Result
        Return dgDAL.buildMaDocGia(nextMaDg)
    End Function
End Class
