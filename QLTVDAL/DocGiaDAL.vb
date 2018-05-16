Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility
Public Class DocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMSHS(ByRef nextMshs As String) As Result 'ex: 18222229

        nextMshs = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMshs = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDocGia] "
        query &= "FROM [QLTV].[dbo].[tblDocGia] "
        query &= "ORDER BY [MaDocGia] DESC "

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
                            msOnDB = reader("MaDocGia")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMshs = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMshs = nextMshs + tmp
                        System.Console.WriteLine(nextMshs)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã độc giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(hs As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblDocGia] ([MaDocGia],[TenDocGia],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[MaLoaiDocGia],[NguoiLap])"
        query &= "VALUES (@MaDocGia,@TenDocGia,@NgaySinh,@DiaChi,@Email,@NgayLapThe,@NgayHetHan,@MaLoaiDocGia,@NguoiLap)"

        'get MSHS
        Dim nextMshs = "1"
        buildMSHS(nextMshs)
        hs.Madg1 = nextMshs

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", hs.Madg1)
                    .Parameters.AddWithValue("@TenDocGia", hs.Hoten1)
                    .Parameters.AddWithValue("@NgaySinh", hs.Ngaysinh1)
                    .Parameters.AddWithValue("@DiaChi", hs.Diachi1)
                    .Parameters.AddWithValue("@Email", hs.Email1)
                    .Parameters.AddWithValue("@NgayLapThe", hs.Ngaylapthe1)
                    .Parameters.AddWithValue("@NgayHetHan", hs.Ngayhethan1)
                    .Parameters.AddWithValue("@MaLoaiDocGia", hs.Maloaidocgia1)
                    .Parameters.AddWithValue("@NguoiLap", hs.Nguoilap1)

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


End Class
