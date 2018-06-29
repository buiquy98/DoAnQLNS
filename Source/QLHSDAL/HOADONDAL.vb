Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class HoaDonDAL
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
        query &= "SELECT TOP 1 [maHoaDon] "
        query &= "FROM [tblHoaDon] "
        query &= "ORDER BY [maHoaDon] DESC "

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
                            idOnDB = reader("maHoaDon")
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

    Public Function insert(hd As HoaDonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD])"
        query &= "VALUES (@maHoaDon,@ngayhoadon,@MAKH,@trigia)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        hd.MaHoaDon = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHoaDon", hd.MaHoaDon)
                    .Parameters.AddWithValue("@ngayhoadon", hd.NgayHoaDon)
                    .Parameters.AddWithValue("@MAKH", hd.MaKhachHang)
                    .Parameters.AddWithValue("@trigia", hd.TongTriGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_TriGiaHoaDon(hoadon As HoaDonDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblHoaDon] SET "
        query &= " [TongTriGiaHD] = @trigia "
        query &= " WHERE [maHoaDon] = @maHoaDon"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@trigia", hoadon.TongTriGia)
                    .Parameters.AddWithValue("@maHoaDon", hoadon.MaHoaDon)
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

    Public Function update(hoadon As HoaDonDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblHoaDon] SET [NgayHoaDon] = @ngayhd, [TongTriGiaHD] = @trigia "
        query &= " WHERE [maHoaDon] = @maHoaDon"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngayhd", hoadon.NgayHoaDon)
                    .Parameters.AddWithValue("@trigia", hoadon.TongTriGia)
                    .Parameters.AddWithValue("@maHoaDon", hoadon.MaHoaDon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listHoaDon As List(Of HoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblHoaDon]"


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
                            listHoaDon.Add(New HoaDonDTO(reader("maHoaDon"), reader("NgayHoaDon"), reader("MAKH"), reader("TongTriGiaHD")))
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

    Public Function selectALL_ByNgayHD(ngayHD As DateTime, ByRef listHD As List(Of HoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblHoaDon]"
        query &= "WHERE "
        query &= "[NgayHoaDon] = @ngayhd"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngayhd", ngayHD)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHD.Clear()
                        While reader.Read()
                            listHD.Add(New HoaDonDTO(reader("maHoaDon"), reader("NgayHoaDon"), reader("MAKH"), reader("TongTriGiaHD")))
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

    Public Function selectALL_BymaHoaDon(maHoaDon As Integer, ByRef listHD As List(Of HoaDonDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblHoaDon]"
        query &= "WHERE "
        query &= "[maHoaDon] = @mahoadon"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahoadon", maHoaDon)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHD.Clear()
                        While reader.Read()
                            listHD.Add(New HoaDonDTO(reader("maHoaDon"), reader("NgayHoaDon"), reader("MAKH"), reader("TongTriGiaHD")))
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

    Public Function delete(maHoaDon As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblHoaDon] "
        query &= " WHERE "
        query &= " [maHoaDon] = @maHoaDon "

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
