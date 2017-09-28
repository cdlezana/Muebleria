Imports System.Data.SqlClient
Imports System.Data

Public Class Usuario

    Inherits conexion


    Function verificar_usuario(ByVal usuario As String, ByVal contraseña As String, ByVal tipo As Integer) As Boolean

        Dim strSQL As String
        Dim permiso As Boolean = False

        Try
            conectado()

            strSQL = "SELECT Dni,Contraseña,Permisos FROM Usuario WHERE Dni=" & usuario & "and Contraseña='" & contraseña & "' and Permisos=" & tipo & ""
            Dim da As New SqlDataAdapter(strSQL, cnn)
            Dim ds As New DataSet

            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then  ' cuenta la cantidad de registro y si encontro alguno devuelve true
                permiso = True
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return permiso
    End Function

    Function listadoVendedor() As DataTable
        Dim strSql As String
        Dim dt As New DataTable

        Try
            conectado()
            strSql = ("Select * from Usuario WHERE Baja = 1 ")
            Dim da As New SqlDataAdapter(strSql, cnn)
            da.Fill(dt)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
        desconectado()
    End Function


    Function modificarUsuario(ByVal id As Integer, ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal contraseña As String, ByVal caract As String, ByVal num As String, ByVal email As String, ByVal dir As String, ByVal ruta As String, ByVal permiso As Integer) As Boolean

        Dim strSql As String
        Dim auxMod As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("UPDATE Usuario SET Dni=" & dni & ", Nombre='" & nombre & "', Contraseña= '" & contraseña & "', Tel_carac=" & caract & ",Email='" & email & "', Direccion='" & dir & "',  Apellido='" & apellido & "' , Telf_num=" & num & " , Imagen='" & ruta & "', Permisos=" & permiso & " WHERE IdVendedor=" & id & "") ' para los datos string hay que anteponer '' (comillas simples)
            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxMod = True
            End If


        Catch ex As Exception

        End Try
        Return auxMod
        desconectado()
    End Function


    Function AltaUsuario(ByVal dni As Integer, ByVal nombre As String, ByVal caract As String, ByVal email As String, ByVal dir As String, ByVal apellido As String, ByVal num As String, ByVal permiso As Integer, ByVal baja As Integer, ByVal contraseña As String, ByVal ruta As String) As Boolean


        Dim strSql As String
        Dim cmd As New SqlCommand
        Dim auxAlta As Boolean = False

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = " INSERT INTO Usuario (Dni,Nombre,Tel_carac,Email,Direccion,Apellido,Telf_num,Permisos,Baja,Contraseña,Imagen) VALUES (  " & dni & ",'" & nombre & "'," & caract & ",'" & email & "','" & dir & "','" & apellido & "'," & num & "," & permiso & "," & baja & ", '" & contraseña & "', '" & ruta & "' )"

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
            strSql = "UPDATE Usuario SET Baja= " & 2 & " WHERE IdVendedor= " & id & " "

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



End Class
