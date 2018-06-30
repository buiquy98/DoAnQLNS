Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility
Public Class NGUOIDUNGDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function getallUser(ByRef userlist As List(Of NguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblNguoiDung]"


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
                        userlist.Clear()
                        While reader.Read()
                            userlist.Add(New NguoiDungDTO(reader("maNguoiDung"), reader("hoTenNguoiDung"), reader("tenDangNhap"), reader("matKhau"), reader("maLoaiNguoiDUng")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function



    Public Function getallUser_bytdn(tdn As String, ByRef userlist As List(Of NguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblNguoiDung]"
        query &= " WHERE [tenDangNhap]=@tdn"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tdn", tdn)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        userlist.Clear()
                        While reader.Read()
                            userlist.Add(New NguoiDungDTO(reader("maNguoiDung"), reader("hoTenNguoiDung"), reader("tenDangNhap"), reader("matKhau"), reader("maLoaiNguoiDUng")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy danh sách người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function





    Public Function NextMS(ByRef inextMS As Integer)
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maNguoiDung] "
        query &= "FROM [tblNguoiDung] "
        query &= "ORDER BY [maNguoiDung] DESC "

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
                            idOnDB = reader("maNguoiDung")
                        End While
                    End If
                    ' new ID = current ID + 1
                    inextMS = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    inextMS = 1
                    Return New Result(False, "Lấy ID kế tiếp của người dùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function



    Public Function insert(nd As NguoiDungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblNguoiDung] ([maNguoiDung], [hoTenNguoiDung], [tenDangNhap], [matKhau],[maLoaiNguoiDUng])"
        query &= "VALUES (@mand,@hoten,@tendangnhap,@matkhau,@maloaind)"

        'get nextms
        Dim inextMS = 0
        Dim result As Result
        result = NextMS(inextMS)
        If (result.FlagResult = False) Then
            Return result
        End If
        nd.StrMaNguoiDung = inextMS
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mand", nd.StrMaNguoiDung)
                    .Parameters.AddWithValue("@hoten", nd.StrHoTenNguoiDung)
                    .Parameters.AddWithValue("@tendangnhap", nd.StrTenDangNhap)
                    .Parameters.AddWithValue("@matkhau", nd.StrMatKhau)
                    .Parameters.AddWithValue("@maloaind", nd.StrMaLoaiNguoiDung)


                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
