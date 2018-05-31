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
    'Public Function isValidName(sach As SachDTO) As Boolean

    '    If (sach.Tensach.Length < 1) Then
    '        Return False
    '    End If

    '    Return True

    'End Function
    Public Function insert(s As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAl.insert(s)
    End Function

    Public Function buildMaSach(ByRef nextID As String) As Result
        Return sachDAl.getNextID(nextID)
    End Function


End Class
