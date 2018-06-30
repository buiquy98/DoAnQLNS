Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility
Public Class LOAINGUOIDUNGDAL
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
        query &= "SELECT TOP 1 [maLoaiNguoiDung] "
        query &= "FROM [QLNS].[dbo].[tblLoaiNguoiDung] "
        query &= "ORDER BY [maLoaiNguoiDung] DESC "

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
                            idOnDB = reader("maLoaiNguoiDung")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của loại người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef listloainguoidung As List(Of LoaiNguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblLoaiNguoiDung]"


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
                        listloainguoidung.Clear()
                        While reader.Read()
                            listloainguoidung.Add(New LoaiNguoiDungDTO(reader("maLoaiNguoiDung"), reader("tenLoaiNguoiDung")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
