Imports System.Data.SqlClient
Imports System.Data
Public Class Producto

    Inherits conexion


    Function listadoProductos() As DataTable
        Dim strSql As String
        Dim dt As New DataTable

        Try
            conectado()
            strSql = ("Select * from Producto ")
            Dim da As New SqlDataAdapter(strSql, cnn)
            da.Fill(dt)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
        desconectado()
    End Function


    Function AltaProducto(ByVal IdCat As Integer, ByVal Descripcion As String, ByVal Stock As Integer, ByVal PrecioUnitario As Decimal, ByVal CuitProv As String, ByVal IdTipo As Integer, ByVal Imagen As String) As Boolean


        Dim strSql As String
        Dim cmd As New SqlCommand
        Dim auxAlta As Boolean = False

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = " INSERT INTO Producto (IdCategoria,Descripcion,Stock,PrecioUnitario,CuitProveedor,IdTipoProducto,Imagen) VALUES (" & IdCat & ",'" & Descripcion & "' ," & Stock & ", " & PrecioUnitario & " , '" & CuitProv & "', " & IdTipo & " ,'" & Imagen & "' )"

            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxAlta = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return auxAlta
        desconectado()


    End Function


    Function eliminarUsuario(ByVal id As Integer) As Boolean

        Dim strSql As String
        Dim cmd As New SqlCommand
        Dim auxBaja As Boolean = False

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = "DELETE FROM Producto WHERE IdProducto= " & id & " "

            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxBaja = True
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return auxBaja
        desconectado()

    End Function


    Function modificarProducto(ByVal id As Integer, ByVal descripcion As String, ByVal stock As Integer, ByVal Precio As Double, ByVal Imagen As String) As Boolean

        Dim strSql As String
        Dim auxMod As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("UPDATE Producto SET Descripcion= '" & descripcion & "', Stock=" & stock & ", PrecioUnitario= " & Precio & ", Imagen= '" & Imagen & "' WHERE IdProducto=" & id & "") ' para los datos string hay que anteponer '' (comillas simples)
            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxMod = True
            End If


        Catch ex As Exception

        End Try
        Return auxMod
        desconectado()
    End Function


End Class

