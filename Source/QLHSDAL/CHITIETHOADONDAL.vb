Imports System.Configuration
Imports System.Data.SqlClient
Imports System
Imports Utility
Imports QLHSDTO

Public Class CTHoaDonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maChiTietHoaDon] "
        query &= "FROM [tblChiTietHoaDon] "
        query &= "ORDER BY [maChiTietHoaDon] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("maChiTietHoaDon")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(cthd As CHITIETHOADONDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [SoLuongBan], [DonGiaBan], [ThanhTien])"
        query &= "VALUES (@maChiTietHoaDon, @maHoaDon, @maSach, @soluongban, @dongia, @thanhtien)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        cthd.MaChiTietHoaDon1 = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietHoaDon", cthd.MaChiTietHoaDon1)
                    .Parameters.AddWithValue("@maHoaDon", cthd.MaHoaDon1)
                    .Parameters.AddWithValue("@maSach", cthd.MaSach1)
                    .Parameters.AddWithValue("@soluongban", cthd.SoLuongBan1)
                    .Parameters.AddWithValue("@dongia", cthd.DonGiaBan1)
                    .Parameters.AddWithValue("@thanhtien", cthd.ThanhTien1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(cthd As CHITIETHOADONDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblChiTietHoaDon] SET [maHoaDon] = @maHoaDon, [maSach] = @maSach, [SoLuongBan] = @soluongban, [DonGiaBan] = @dongia, [ThanhTien] = @thanhtien"
        query &= " WHERE "
        query &= " [maChiTietHoaDon] = @maChiTietHoaDon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietHoaDon", cthd.MaChiTietHoaDon1)
                    .Parameters.AddWithValue("@maHoaDon", cthd.MaHoaDon1)
                    .Parameters.AddWithValue("@maSach", cthd.MaSach1)
                    .Parameters.AddWithValue("@soluongban", cthd.SoLuongBan1)
                    .Parameters.AddWithValue("@dongia", cthd.DonGiaBan1)
                    .Parameters.AddWithValue("@thanhtien", cthd.ThanhTien1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phiếu hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listHoaDon As List(Of CHITIETHOADONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblChiTietHoaDon]"


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
                        listHoaDon.Clear()
                        While reader.Read()
                            listHoaDon.Add(New CHITIETHOADONDTO(reader("maChiTietHoaDon"), reader("maHoaDon"), reader("maSach"), reader("SoLuongBan"), reader("DonGiaBan"), reader("ThanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_bymaHoaDon(maHoaDon As Integer, ByRef listHoaDon As List(Of CHITIETHOADONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblChiTietHoaDon]"
        query &= "WHERE [maHoaDon] = @maHoaDon"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", maHoaDon)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHoaDon.Clear()
                        While reader.Read()
                            listHoaDon.Add(New CHITIETHOADONDTO(reader("maChiTietHoaDon"), reader("maHoaDon"), reader("maSach"), reader("SoLuongBan"), reader("DonGiaBan"), reader("ThanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maChiTietHoaDon As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblChiTietHoaDon] "
        query &= " WHERE "
        query &= " [maChiTietHoaDon] = @maChiTietHoaDon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietHoaDon", maChiTietHoaDon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
