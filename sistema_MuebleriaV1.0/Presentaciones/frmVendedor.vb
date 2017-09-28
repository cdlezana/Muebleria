Public Class frmVendedor
    Dim Source As String 'Variable global para traer la ruta de la imagen
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) 'Obtiene la ruta del direcotiro donde esta el proyecto

        Source = OpenFileDialog1.FileName.ToString() 'Obtiene el nombre copleto de la ruta donde esta el archivo que vamos a copiar


        txt_rutaImg.Text = Source
    End Sub

    Private Sub txt_dni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dni.KeyPress
        ' vamos a validar que el campo del texbox DNI sea de tipo entero
        If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
            e.Handled = False 'hablita la escritura 
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = True 'se habilita el ingreso de texto
        Else
            'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
            e.Handled = True
        End If
    End Sub

    Private Sub txt_dni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_dni.TextChanged

    End Sub

    Private Sub txt_dni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dni.Validating
        ' metodo de validacion para el campo DNI
        If DirectCast(sender, TextBox).Text.Length = 8 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Formato D.N.I incorrecto")
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = False 'se habilita el ingreso de texto
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub txt_nombre_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.Validated
        ' metodo de validacion para el campo NOMBRE
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Debe Ingresar Nombre")
        End If
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = False 'se habilita el ingreso de texto
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub txt_apellido_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_apellido.Validated
        ' metodo de validacion para el campo APELLIDO
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Debe Ingresar Apellido")
        End If
    End Sub

    Private Sub txt_telfCarac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telfCarac.KeyPress
        ' vamos a validar que el campo del texbox DNI sea de tipo entero
        If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
            e.Handled = False 'hablita la escritura 
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = True 'se habilita el ingreso de texto
        Else
            'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_telfCarac.TextChanged

    End Sub

    Private Sub txt_telfCarac_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_telfCarac.Validating
        ' metodo de validacion para el campo CARACTERISTICA DE TELEFONO
        If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length < 4 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Caracteristica Incorrecta")
        End If
    End Sub

    Private Sub txt_telfNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telfNum.KeyPress
        ' vamos a validar que el campo del texbox DNI sea de tipo entero
        If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
            e.Handled = False 'hablita la escritura 
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = True 'se habilita el ingreso de texto
        Else
            'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telfNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_telfNum.TextChanged

    End Sub

    Private Sub txt_telfNum_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_telfNum.Validated
        ' metodo de validacion para el campo NUMERO DE TELEFONO
        If DirectCast(sender, TextBox).Text.Length = 7 Or DirectCast(sender, TextBox).Text.Length = 9 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Numero Incorrecto")
        End If
    End Sub

    Private Sub btn_examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_examinar.Click

        OpenFileDialog1.Title = "SELECCIONAR UNA IMAGEN" ' titulo de la ventana del buscador de imagenes
        OpenFileDialog1.InitialDirectory = "D:\taller II\" ' carpeta de inicio de busqueda de imagenes
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png" 'Permite filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub frmVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowDialog()

    End Sub

    Private Sub rb_dni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_dni.CheckedChanged
        
    End Sub

    Private Sub txt_buscaVend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscaVend.KeyPress
        If rb_dni.Checked = True Then

            ' vamos a validar que el campo del texbox DNI sea de tipo entero
            If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
                e.Handled = False 'hablita la escritura 
            ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
                e.Handled = False 'hablita la escritura

            ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
                e.Handled = True 'se habilita el ingreso de texto
            Else
                'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
                e.Handled = True
                Me.EP_error.SetError(sender, "Debe ingresar solo datos numericos")
            End If

        Else
            Me.EP_error.Clear()
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
                e.Handled = False 'hablita la escritura

            ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
                e.Handled = False 'se habilita el ingreso de texto
            Else
                e.Handled = True
                Me.EP_error.SetError(sender, "Debe ingresar solo datos alfabeticos")
            End If
        End If
    End Sub

    Private Sub txt_buscaVend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscaVend.TextChanged
       
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_dni.Text = "" Or txt_apellido.Text = "" Or txt_nombre.Text = "" Or txt_telfCarac.Text = "" Or txt_telfNum.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro que desea insertar un nuevo Vendedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Insercion") = MsgBoxResult.Yes Then 'si la opcion elegida es el boton SI 
                MsgBox("Se inserto correctamente", MsgBoxStyle.Information, "Guardar")
                txt_dni.Clear()
                txt_apellido.Clear()
                txt_nombre.Clear()
                txt_telfCarac.Clear()
                txt_telfNum.Clear()
                txt_email.Clear()
                txt_direccion.Clear()
                txt_rutaImg.Clear()
                PictureBox1.Visible = False



            End If
        End If

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If txt_dni.Text <> "" Or txt_apellido.Text <> "" Or txt_nombre.Text <> "" Or txt_telfCarac.Text <> "" Or txt_telfNum.Text <> "" Then
            'el valor 256 es para que haga foco en la segunda opcion en este caso es en la opcion NO----> 0 para el primer boton, 256 para el segundo y 512 para el tercero
            If MsgBox("¿Seguro que desea Eliminar al Vendedor?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
                MsgBox("Se Elimino correctamente", MsgBoxStyle.Information, "Eliminar")
            End If
        Else
            MsgBox("No hay registros para eliminar")
        End If
    End Sub
End Class