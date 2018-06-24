Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class PHIEUNHAPDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function getNextID(ByRef StrMaphieu As String) As Result 'ex: 18222229

        StrMaphieu = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        StrMaphieu = x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaPhieuNhap] "
        query &= "From [tblPhieuNhapSach] "
        query &= "Order By [MaPhieuNhap] DESC "

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
                            msOnDB = reader("MaPhieuNhap")
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
                        StrMaphieu = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        StrMaphieu = StrMaphieu + tmp
                        System.Console.WriteLine(StrMaphieu)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã phiếu nhập kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(pn As PHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuNhapSach] ([MaPhieuNhap], [NgayNhapSach], [SoLuongNhap], [TenSach], [TheLoai], [TacGia])"
        query &= "VALUES (@MaPhieuNhap,@NgayNhapSach,@SoLuongNhap,@TenSach,@TheLoai,@TacGia)"

        'get madocgia
        Dim nextmadocgia = "1"
        getNextID(nextmadocgia)
        pn.Imaphieunhap = nextmadocgia

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuNhap", pn.Imaphieunhap)
                    .Parameters.AddWithValue("@NgayNhapSach", pn.Datengaynhap)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listHocSinh As List(Of PHIEUNHAPDTO)) As Result

    End Function

    Public Function selectALL_ByType(maLoai As Integer, ByRef listPhieuNhap As List(Of PHIEUNHAPDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblPhieuNhap]"


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
                        listPhieuNhap.Clear()
                        While reader.Read()
                            listPhieuNhap.Add(New PHIEUNHAPDTO(reader("MAPHIEUNHAP"), reader("NgayNhap")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function update(pn As PHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuNhap] SET"
        query &= " [NgayNhap] = @ngaynhap "
        query &= "WHERE "
        query &= " [MAPHIEUNHAP] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", pn.Imaphieunhap)
                    .Parameters.AddWithValue("@ngaynhap", pn.Datengaynhap)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phiếu lập nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maPhieu As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuNhap] "
        query &= " WHERE "
        query &= " [MAPHIEUNHAP] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", maPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
