Imports System.Data.SqlClient
Public Class Proveedor
    Inherits conexion

    Function listadoProveedor() As DataTable
        Dim strSql As String
        Dim dt As New DataTable

        Try
            conectado()
            strSql = ("Select * from Proveedor  where Baja = 1")
            Dim da As New SqlDataAdapter(strSql, cnn)
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
        desconectado()
    End Function

    Function AltaProveedor(ByVal Cuit As Double, ByVal RazonSocial As String, ByVal Tel As Integer, ByVal Email As String, ByVal Direccion As String) As Boolean


        Dim strSql As String
        Dim cmd As New SqlCommand
        Dim auxAlta As Boolean = False
        'agregar en la base de datos de proveerdor el campo contacto como id_contacto por pedido de la empresa'
        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = " INSERT INTO Proveedor (Cuit,Razon_Soc,Tel,Email,Direccion,Baja) VALUES (  " & Cuit & ",'" & RazonSocial & "'," & Tel & ",'" & Email & "','" & Direccion & "', " & 1 & " )"

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


    Function modificarProveedor(ByVal Cuit As Double, ByVal RazonSocial As String, ByVal Tel As Integer, ByVal Email As String, ByVal Direccion As String) As Boolean

        Dim strSql As String
        Dim auxMod As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("UPDATE Proveedor SET Cuit=" & Cuit & ", Razon_Soc='" & RazonSocial & "', Tel= " & Tel & ", Email='" & Email & "', Direccion= '" & Direccion & "' WHERE Cuit=" & Cuit & "") ' para los datos string hay que anteponer '' (comillas simples)
            cmd.CommandText = strSql

            If cmd.ExecuteNonQuery() Then
                auxMod = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return auxMod
        desconectado()

    End Function


    Function eliminarProveedor(ByVal Cuit As Double) As Boolean

        Dim strSql As String
        Dim auxBaja As Boolean = False
        Dim cmd As New SqlCommand

        Try
            conectado()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            strSql = ("UPDATE Proveedor set Baja=" & 2 & " WHERE Cuit=" & Cuit & "") ' para los datos string hay que anteponer '' (comillas simples)
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
