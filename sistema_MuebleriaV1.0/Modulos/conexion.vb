Imports System.Data.SqlClient
Public Class conexion

    Public cnn As New SqlConnection

    'funcion de conexion a la base de datos
    Public Function conectado()
        Try
            cnn = New SqlConnection("data source=NOTEBOOK-PC\SQLEXPRESS;initial catalog=sistemaMuebleria;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'funcion desconexion conexion a la base de datos
    Public Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then  ' verifica el estado de la conexion, si esta conectada la cierra
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
