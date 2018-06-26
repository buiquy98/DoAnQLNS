Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class CHITIETBAOCAOTONDAL
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
        query &= "SELECT TOP 1 [maChiTietBaoCaoTon]"
        query &= " FROM [QLNS].[dbo].[tblChiTietBaoCaoTon]"
        query &= "ORDER BY [maChiTietBaoCaoTon] DESC "

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
                            idOnDB = reader("maChiTietBaoCaoTon")
                        End While
                    End If
                    'new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()

                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function insert(ctbct As CHITIETBAOCAOTONDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblChiTietBaoCaoTon]([maChiTietBaoCaoTon],[maSach],[maBaoCaoTon],[tonDau],[tonPhatSinh],[tonCuoi])"
        query &= "VALUES (@maChiTietBaoCaoTon,@maSach,@maBaoCaoTon,@tonDau,@tonPhatSinh,@tonCuoi)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ctbct.MaChiTietBaoCaoTon1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoTon", ctbct.MaChiTietBaoCaoTon1)
                    .Parameters.AddWithValue("@maSach", ctbct.MaSach1)
                    .Parameters.AddWithValue("@maBaoCaoTon", ctbct.MaBaoCaoTon1)
                    .Parameters.AddWithValue("@tonDau", ctbct.TonDau1)
                    .Parameters.AddWithValue("@tonPhatSinh", ctbct.TonPhatSinh1)
                    .Parameters.AddWithValue("@tonCuoi", ctbct.TonCuoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(mact As Integer, tonDau As Integer, phatSinh As Integer, tonCuoi As Integer, listCTBCT As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [dbo].[tblChiTietBaoCaoTon] SET "
        query &= " ,[tonDau] = @tonDau"
        query &= " ,[tonPhatSinh] = @tonPhatSinh"
        query &= " ,[tonCuoi] = @tonCuoi"
        query &= " WHERE "
        query &= " [maChiTietBaoCaoTon] = @maChiTietBaoCaoTon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoTon", mact)
                    .Parameters.AddWithValue("@tonDau", tonDau)
                    .Parameters.AddWithValue("@tonPhatSinh", phatSinh)
                    .Parameters.AddWithValue("@tonCuoi", tonCuoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo chi tiết cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoTon As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [QLNS].[dbo].[tblChiTietBaoCaoTon]"


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
                        listBaoCaoTon.Clear()
                        While reader.Read()
                            listBaoCaoTon.Add(New CHITIETBAOCAOTONDTO(reader("maChiTietBaoCaoTon"), reader("maSach"), reader("maBaoCaoTon"), reader("tonDau"), reader("tonPhatSinh"), reader("tonCuoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaBaoCaoTon(maBaoCao As Integer, ByRef listCTPhieuNhap As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [dbo].[tblChiTietBaoCaoTon] "
        query &= "WHERE [maChiTietBaoCaoTon] = @maChiTietBaoCaoTon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoTon", maBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTPhieuNhap.Clear()
                        While reader.Read()
                            listCTPhieuNhap.Add(New CHITIETBAOCAOTONDTO(reader("maChiTietBaoCaoTon"), reader("maSach"), reader("maBaoCaoTon"), reader("tonDau"), reader("tonPhatSinh"), reader("tonCuoi")))
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

    Public Function delete(maCTBCT As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblChiTietBaoCaoTon] "
        query &= " WHERE "
        query &= " [maChiTietBaoCaoTon] = @maChiTietBaoCaoTon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoTon", maCTBCT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
