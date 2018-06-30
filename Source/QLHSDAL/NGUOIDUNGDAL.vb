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
End Class
