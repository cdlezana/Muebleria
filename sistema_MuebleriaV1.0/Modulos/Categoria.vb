Imports System.Data.SqlClient
Public Class Categoria
    Inherits conexion

    Function listadoCategoria() As DataTable
        Dim strSql As String
        Dim dt As New DataTable

        Try
            conectado()
            strSql = ("Select * from Categoria ")
            Dim da As New SqlDataAdapter(strSql, cnn)
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
        desconectado()
    End Function

    Function AltaCategoria(ByVal Descripcion As String) As Boolean


        Dim strSql As String
        Dim cmd As New SqlCommand
        Dim auxAlta As Boolean = False

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = " INSERT INTO Categoria (Descripcion) VALUES ( '" & Descripcion & "' )"

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


    Function modificarCategoria(ByVal Id As Integer, ByVal Descripcion As String) As Boolean

        Dim strSql As String
        Dim auxMod As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("UPDATE Categoria SET Descripcion= '" & Descripcion & "' WHERE IdCategoria=" & Id & "") ' para los datos string hay que anteponer '' (comillas simples)
            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxMod = True
            End If


        Catch ex As Exception

        End Try
        Return auxMod
        desconectado()

    End Function

    Function eliminarCategoria(ByVal Id As Integer) As Boolean

        Dim strSql As String
        Dim auxMod As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("DELETE  FROM Categoria  WHERE IdCategoria=" & Id & "") ' para los datos string hay que anteponer '' (comillas simples)
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

