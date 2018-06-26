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
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MAPHIEUNHAP] "
        query &= "FROM [tblPhieuNhap] "
        query &= "ORDER BY [MAPHIEUNHAP] DESC "

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
                            idOnDB = reader("MAPHIEUNHAP")
                        End While
                    End If
                    ' new ID = current ID + 1
                    StrMaphieu = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    StrMaphieu = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại học sinh không thành công", ex.StackTrace)
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
