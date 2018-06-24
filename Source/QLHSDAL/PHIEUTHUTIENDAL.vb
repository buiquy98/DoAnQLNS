Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class PhieuThuTienDAL
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
        query &= "SELECT TOP 1 [MAPHIEUTHU] "
        query &= "FROM [tblPhieuThuTien] "
        query &= "ORDER BY [MAPHIEUTHU] DESC "

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
                            idOnDB = reader("MAPHIEUTHU")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(phieuthutien As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuThuTien] ([MAPHIEUTHU], [MAKH], [NgayThuTien], [SoTienThu])"
        query &= "VALUES (@maphieu,@makh,@ngaythu,@sotien)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieuthutien.MaPhieuThu1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieu", phieuthutien.MaPhieuThu1)
                    .Parameters.AddWithValue("@makh", phieuthutien.MaKH1)
                    .Parameters.AddWithValue("@ngaythu", phieuthutien.NgayThuTien1)
                    .Parameters.AddWithValue("@sotien", phieuthutien.SoTienThu1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(phieuthutien As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuThuTien] SET"
        query &= " [NgayThuTien] = @NgayThuTien "
        query &= " ,[SoTienThu] = @SoTienThu"
        query &= " WHERE "
        query &= " [MAPHIEUTHU] = @maphieu"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@NgayThuTien", phieuthutien.NgayThuTien1)
                    .Parameters.AddWithValue("@SoTienThu", phieuthutien.SoTienThu1)
                    .Parameters.AddWithValue("@maphieu", phieuthutien.MaPhieuThu1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phiếu thu tiền nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listPhieuThuTien As List(Of PhieuThuTienDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblPhieuThuTien]"


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
                        listPhieuThuTien.Clear()
                        While reader.Read()
                            listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MAPHIEUTHU"), reader("MAKH"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_byMaPhieu(maPhieu As Integer, ByRef listPhieuThuTien As List(Of PhieuThuTienDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblPhieuThuTien]"
        query &= "WHERE [MAPHIEUTHU] = @maPhieu"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieu", maPhieu)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThuTien.Clear()
                        While reader.Read()
                            listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MAPHIEUTHU"), reader("MAKH"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maphieu As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuThuTien] "
        query &= " WHERE "
        query &= " [MAPHIEUTHU] = @MAPHIEUTHU "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MAPHIEUTHU", maphieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
