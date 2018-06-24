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
        query &= "SELECT TOP 1 [MACTBAOCAOTON] "
        query &= "FROM [tblCTBaoCaoTon] "
        query &= "ORDER BY [MACTBAOCAOTON] DESC "

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
                            idOnDB = reader("MACTBAOCAOTON")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(ctBCT As CHITIETBAOCAOTONDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTBaoCaoTon] ([MACTBAOCAOTON], [MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])"
        query &= "VALUES (@machitiet,@masach,@mabaocao,@tondau,@phatsinh,@toncuoi)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ctBCT.Imachitietphieubaocaoton = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitiet", ctBCT.Imachitietphieubaocaoton)
                    .Parameters.AddWithValue("@masach", ctBCT.Imasach)
                    .Parameters.AddWithValue("@mabaocao", ctBCT.Strmabaocaoton)
                    .Parameters.AddWithValue("@tondau", ctBCT.Itoncuoi)
                    .Parameters.AddWithValue("@phatsinh", ctBCT.Itonphatsinh)
                    .Parameters.AddWithValue("@toncuoi", ctBCT.Itoncuoi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function update(mact As Integer, tonDau As Integer, phatSinh As Integer, tonCuoi As Integer, listCTBCT As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblCTBaoCaoTon] SET"
        query &= "[SoLuongTonDau] = @tondau"
        query &= ",[PhatSinh] = @phatsinh"
        query &= ",[SoLuongTonCuoi] = @toncuoi"
        query &= " WHERE "
        query &= " [MACTBAOCAOTON] = @machitietbaocao "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tondau", tonDau)
                    .Parameters.AddWithValue("@phatsinh", phatSinh)
                    .Parameters.AddWithValue("@toncuoi", tonCuoi)
                    .Parameters.AddWithValue("@machitietbaocao", mact)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listCTBCT As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblCTBaoCaoTon]"


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
                        listCTBCT.Clear()
                        While reader.Read()
                            listCTBCT.Add(New CHITIETBAOCAOTONDTO(reader("MACTBAOCAOTON"), reader("MASACH"), reader("MABAOCAOTON"), reader("SoLuongTonDau"), reader("PhatSinh"), reader("SoLuongTonCuoi")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaBaoCaoTon(maBaoCao As Integer, ByRef listCTPhieuNhap As List(Of CHITIETBAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblCTBaoCaoTon] "
        query &= "WHERE [MABAOCAOTON] = @mabaocao "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", maBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTPhieuNhap.Clear()
                        While reader.Read()
                            listCTPhieuNhap.Add(New CHITIETBAOCAOTONDTO(reader("MACTBAOCAOTON"), reader("MASACH"), reader("MABAOCAOTON"), reader("SoLuongTonDau"), reader("PhatSinh"), reader("SoLuongTonCuoi")))
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
        query &= " DELETE FROM [tblCTBaoCaoTon] "
        query &= " WHERE "
        query &= " [MACTBAOCAOTON] = @MACTBAOCAOTON "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MACTBAOCAOTON", maCTBCT)
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
