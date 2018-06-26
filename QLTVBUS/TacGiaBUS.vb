Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TacGiaBUS
    Private tacgiaDAL As TacGiaDAL
    Public Sub New()
        tacgiaDAL = New TacGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        tacgiaDAL = New TacGiaDAL(connectionString)
    End Sub
    'Public Function isValidName(sach As SachDTO) As Boolean

    '    If (sach.Tensach.Length < 1) Then
    '        Return False
    '    End If

    '    Return True

    'End Function
    Public Function insert(s As TacGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tacgiaDAL.insert(s)
    End Function

    Public Function buildMaTG(ByRef nextID As String) As Result
        Return tacgiaDAL.getNextID(nextID)
    End Function
    Public Function selectALL(ByRef tg As List(Of TacGiaDTO)) As Result
        Return tacgiaDAL.selectALL(tg)
    End Function


End Class
