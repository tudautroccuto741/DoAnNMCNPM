Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As String) As Result
        nextID = "SA"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [masach] "
        query &= "FROM [tblSach] "
        query &= "ORDER BY [masach] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("masach")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextID = nextID + tmp
                        System.Console.WriteLine(nextID)
                    Else
                        nextID = nextID + "000001"
                    End If
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(s As SachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach] ([masach],[matacgia], [tensach],[matheloai],[namxuatban],[nhaxuatban],[ngaynhap],[trigia],[tinhtrang])"
        query &= "VALUES (@masach,@tensach,@matheloai,@matacgia,@namxuatban,@nhaxuatban,@ngaynhap,@trigia,@tinhtrang)"

        Dim nextID = "0"
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        s.MaSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", s.MaSach)
                    .Parameters.AddWithValue("@tensach", s.TenSach)
                    .Parameters.AddWithValue("@matheloai", s.MaTheLoai)
                    .Parameters.AddWithValue("@matacgia", s.MaTacGia)
                    .Parameters.AddWithValue("@namxuatban", s.NamXuatBan)
                    .Parameters.AddWithValue("@nhaxuatban", s.NhaXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", s.NgayNhap)
                    .Parameters.AddWithValue("@trigia", s.TriGia)
                    .Parameters.AddWithValue("@tinhtrang", s.TinhTrang)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(sach As SachDTO) As Result
        Dim query As String = String.Empty
        query &= "UPDATE [tblsach] SET"
        query &= " [tensach] = @tensach "
        query &= " ,[matheloai] = @matheloai "
        query &= " ,[nhaxuatban] = @nhaxuatban "
        query &= " ,[namxuatban] = @namxuatban "
        query &= " ,[ngaynhap] = @ngaynhap "
        query &= " ,[trigia] = @trigia "
        query &= " ,[matacgia] = @matacgia "
        query &= "[tinhtrang]=@tinhtrang"
        query &= "WHERE "
        query &= " [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", sach.MaSach)
                    .Parameters.AddWithValue("@ngaynhap", sach.NgayNhap)
                    .Parameters.AddWithValue("@nhaxuatban", sach.NhaXuatBan)
                    .Parameters.AddWithValue("@namxuatban", sach.NamXuatBan)
                    .Parameters.AddWithValue("@tensach", sach.TenSach)
                    .Parameters.AddWithValue("@matheloai", sach.MaTheLoai)
                    .Parameters.AddWithValue("@matacgia", sach.MaTacGia)
                    .Parameters.AddWithValue("@tinhtrang", sach.TinhTrang)
                    .Parameters.AddWithValue("@trigia", sach.TriGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function selectALL(ByRef listsach As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [masach], [tensach], [matacgia], [matheloai],[tinhtrang],[namxuatban],[nhaxuatban],[ngaynhap],[trigia]"
        query &= " FROM [tblsach]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("matacgia"), reader("matheloai"), reader("tinhtrang"), reader("namxuatban"), reader("nhaxuatban"), reader("trigia"), reader("ngaynhap")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef ListSach As List(Of SachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [masach], [matheloaisach], [tensach], [matacgia], [ngaynhap], [trigia], [mamxuatban], [nhaxuatban], [tinhtrang] "
        query &= "FROM [tblSach] "
        query &= "WHERE [matheloaisach] = @matheloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matheloaisach", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        ListSach.Clear()
                        While reader.Read()
                            ListSach.Add(New SachDTO(reader("masach"), reader("matheloaisach"), reader("tensach"), reader("matacgia"), reader("ngaynhap"), reader("trigia"), reader("namxuatban"), reader("nhaxuatban"), reader("tinhtrang")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
