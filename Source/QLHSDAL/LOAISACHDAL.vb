Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class LOAISACHDAL
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
        query &= "SELECT TOP 1 [maLoaiSach] "
        query &= "FROM [QLNS].[dbo].[tblLoaiSach] "
        query &= "ORDER BY [maLoaiSach] DESC "

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
                            idOnDB = reader("maLoaiSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(ls As LOAISACHDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblLoaiSach] ([maLoaiSach], [tenLoaiSach])"
        query &= "VALUES (@maLoaiSach,@tenLoaiSach)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ls.Imaloaisach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLoaiSach", ls.Imaloaisach)
                    .Parameters.AddWithValue("@tenLoaiSach", ls.Strtenloaisach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ls As LOAISACHDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [dbo].[tblLoaiSach] SET"
        query &= " [tenLoaiSach] = @tenLoaiSach "
        query &= "WHERE "
        query &= " [maLoaiSach] = @maLoaiSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLoaiSach", ls.Imaloaisach)
                    .Parameters.AddWithValue("@tenLoaiSach", ls.Strtenloaisach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblLoaiSach]"


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
                        listLoaiSach.Clear()
                        While reader.Read()
                            listLoaiSach.Add(New LOAISACHDTO(reader("maLoaiSach"), reader("tenLoaiSach")))
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


    Public Function selectALL_ByName(name As String, ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblLoaiSach]"
        query &= " WHERE "
        query &= " [tenLoaiSach] = @tenLoaiSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenLoaiSach", name)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiSach.Clear()
                        While reader.Read()
                            listLoaiSach.Add(New LOAISACHDTO(reader("maLoaiSach"), reader("tenLoaiSach")))
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

    Public Function selectALL_ByMaLoaiSach(maLoai As Integer, ByRef listLoaiSach As List(Of LOAISACHDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblLoaiSach]"
        query &= " WHERE "
        query &= " [maLoaiSach] = @maLoaiSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLoaiSach", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiSach.Clear()
                        While reader.Read()
                            listLoaiSach.Add(New LOAISACHDTO(reader("maLoaiSach"), reader("tenLoaiSach")))
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

    Public Function delete(maLoaiSach As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblLoaiSach] "
        query &= " WHERE "
        query &= " [maLoaiSach] = @maLoaiSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLoaiSach", maLoaiSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
