Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility


Public Class TheDocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function insert(hs As TheDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTheDocGia] ([mathe], [maloaidocgia], [hoten], [diachi], [ngaysinh], [email], [ngaylapthe])"
        query &= "VALUES (@mathe,@maloaidocgia,@hoten,@diachi,@ngaysinh,@email, @ngaylapthe)"

        'get MSHS
        Dim nextMaDg = "1"
        buildMaDocGia(nextMaDg)
        hs.Mathe = nextMaDg

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mathe", hs.Mathe)
                    .Parameters.AddWithValue("@maloaidocgia", hs.maloaidocgia)
                    .Parameters.AddWithValue("@hoten", hs.hovaten)
                    .Parameters.AddWithValue("@diachi", hs.diachi)
                    .Parameters.AddWithValue("@ngaysinh", hs.ngaysinh)
                    .Parameters.AddWithValue("@email", hs.email)
                    .Parameters.AddWithValue("@ngaylapthe", hs.ngaylapthe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function buildMaDocGia(ByRef nextMaDG As String) As Result 'ex: 18222229

        nextMaDG = String.Empty

        nextMaDG = "DG"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [mathe] "
        query &= "FROM [tblTheDocGia] "
        query &= "ORDER BY [mathe] DESC "

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
                            msOnDB = reader("mathe")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMaDG = nextMaDG + tmp
                        System.Console.WriteLine(nextMaDG)
                    Else
                        nextMaDG = nextMaDG + "000001"
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
