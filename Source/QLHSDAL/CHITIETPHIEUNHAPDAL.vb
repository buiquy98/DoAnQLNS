Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class CTPhieuNhapDAL
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
        query &= "SELECT TOP 1 [MACTPHIEUNHAP] "
        query &= "FROM [tblCTPhieuNhap] "
        query &= "ORDER BY [MACTPHIEUNHAP] DESC "

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
                            idOnDB = reader("MACTPHIEUNHAP")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(ct As CHITIETPHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTPhieuNhap] ([MACTPHIEUNHAP], [MAPHIEUNHAP],[MASACH],[SoLuongNhap])"
        query &= "VALUES (@mactpn,@mapn,@masach,@soluongnhap)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ct.Imachitietphieunhap = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mactpn", ct.Imachitietphieunhap)
                    .Parameters.AddWithValue("@mapn", ct.Imaphieunhap)
                    .Parameters.AddWithValue("@masach", ct.Imasach)
                    .Parameters.AddWithValue("@soluongnhap", ct.Isoluongnhap)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ctpn As CHITIETPHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblCTPhieuNhap] SET"
        query &= " [SoLuongNhap] = @soluongnhap "
        query &= "WHERE "
        query &= " [MACTPHIEUNHAP] = @mactphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mactphieunhap", ctpn.Imachitietphieunhap)
                    .Parameters.AddWithValue("@soluongnhap", ctpn.Isoluongnhap)
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

    Public Function selectALL(ByRef listCt As List(Of CHITIETPHIEUNHAPDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTPhieuNhap]"


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
                        listCt.Clear()
                        While reader.Read()
                            listCt.Add(New CHITIETPHIEUNHAPDTO(reader("MACTPHIEUNHAP"), reader("MAPHIEUNHAP"), reader("MASACH"), reader("SoLuongNhap")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả chi tiết phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByType(maPhieuNhap As Integer, ByRef listCTPhieuNhap As List(Of CHITIETPHIEUNHAPDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblCTPhieuNhap] "
        query &= "WHERE [MAPHIEUNHAP] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", maPhieuNhap)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTPhieuNhap.Clear()
                        While reader.Read()
                            listCTPhieuNhap.Add(New CHITIETPHIEUNHAPDTO(reader("MACTPHIEUNHAP"), reader("MAPHIEUNHAP"), reader("MASACH"), reader("SoLuongNhap")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết phiếu nhập theo phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(mactpn As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblCTPhieuNhap] "
        query &= " WHERE "
        query &= " [MACTPHIEUNHAP] = @mactpn "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mactpn", mactpn)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa chi tiết phiếu nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
