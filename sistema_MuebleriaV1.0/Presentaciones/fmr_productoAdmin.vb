Public Class fmr_productoAdmin
    Private func As New Producto
    Private dt As New DataTable
    Dim Source As String 'Variable global para traer la ruta de la imagen
    Private Sub txt_buscaVend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscaProd.TextChanged
        buscar()
    End Sub

    Private Sub fmr_prodcutoAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet8.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.SistemaMuebleriaDataSet8.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter2.Fill(Me.SistemaMuebleriaDataSet1.Categoria)
   
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet6.TipoProducto' Puede moverla o quitarla según sea necesario.
        Me.TipoProductoTableAdapter.Fill(Me.SistemaMuebleriaDataSet6.TipoProducto)
       
        
        txt_idProducto.Enabled = False
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False
        mostrar()

    End Sub


    Private Sub mostrar()
        Try
            dt = func.listadoProductos
            dg_productos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged

    End Sub

    Private Sub rellenarTextbox()
        ' EP_error.Clear()
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True


        cb_categoria.SelectedValue = dg_productos.CurrentRow.Cells(0).Value ' vincula el codigo de categoria con el codigo del producto y trae la descripcion de la catgoria
        txt_idProducto.Text = (dg_productos.CurrentRow.Cells(1).Value)
        txt_descripcion.Text = (dg_productos.CurrentRow.Cells(2).Value)
        txt_stock.Text = (dg_productos.CurrentRow.Cells(3).Value)
        txt_precio.Text = (dg_productos.CurrentRow.Cells(4).Value)
        cb_CuitProveedor.SelectedValue = (dg_productos.CurrentRow.Cells(5).Value)
        cb_tipoProd.SelectedValue = dg_productos.CurrentRow.Cells(6).Value
        txt_rutaImg.Text = dg_productos.CurrentRow.Cells(7).Value
        PictureBox1.ImageLocation = dg_productos.Item(7, dg_productos.CurrentRow.Index).Value 'carga la imagen en el picture box
        PictureBox1.Visible = True
    End Sub

    Private Sub dg_productos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_productos.Click
        rellenarTextbox()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        If cb_categoria.Text = "" Or txt_descripcion.Text = "" Or txt_stock.Text = "" Or txt_precio.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro que desea insertar un nuevo Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Insercion") = MsgBoxResult.Yes Then 'si la opcion elegida es el boton SI 

                If func.AltaProducto(cb_categoria.SelectedValue, txt_descripcion.Text, txt_stock.Text, txt_precio.Text, cb_CuitProveedor.SelectedValue, cb_tipoProd.SelectedValue, txt_rutaImg.Text) = True Then
                    MsgBox("Se inserto correctamente", MsgBoxStyle.Information, "Guardar")
                    'limpiar()
                    mostrar()

                End If

            End If

        End If

    End Sub



    Private Sub btn_examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_examinar.Click
        OpenFileDialog1.Title = "SELECCIONAR UNA IMAGEN" ' titulo de la ventana del buscador de imagenes
        OpenFileDialog1.InitialDirectory = "D:\taller II\" ' carpeta de inicio de busqueda de imagenes
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png" 'Permite filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName

    End Sub

    Private Sub buscar()
        Dim ds As New DataSet

        Try
            mostrar()
            ds.Tables.Add(dt.Copy)

            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = lbl_descripcionProd.Text & " like '" & txt_buscaProd.Text & "%'"

            If dv.Count <> 0 Then

                dg_productos.DataSource = dv

            Else

                dg_productos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub



    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If MsgBox("¿Seguro desea Modificar ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
            If func.modificarProducto(txt_idProducto.Text, txt_descripcion.Text, txt_stock.Text, txt_precio.Text, txt_rutaImg.Text) = True Then
                MsgBox("Se Modifico correctamente", MsgBoxStyle.Information, "Modificar")
                mostrar()
            End If
        End If

    End Sub


    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click

        If txt_descripcion.Text = "" Or txt_precio.Text = "" Or txt_precio.Text = "" Then
            MsgBox("No hay campos para eliminar", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro desea Eliminar ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
                If func.eliminarUsuario(txt_idProducto.Text) = True Then

                    MsgBox("Se Elimino correctamente", MsgBoxStyle.Information, "Eliminar")
                    mostrar()
                End If
            End If

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) 'Obtiene la ruta del direcotiro donde esta el proyecto
        Source = OpenFileDialog1.FileName.ToString() 'Obtiene el nombre copleto de la ruta donde esta el archivo que vamos a copiar
        txt_rutaImg.Text = Source
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If MsgBox("¿Seguro Cancelar La Operacion ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
            limpiar()
        End If
    End Sub

    'agregar a limpiar() txt_prod_origen.Clear() para limpiar el nuevo campo agregado
    Public Sub limpiar()
        txt_idProducto.Clear()
        txt_descripcion.Clear()
        txt_stock.Clear()
        txt_precio.Clear()
        PictureBox1.Visible = False
        txt_rutaImg.Text = ""
    End Sub

    Private Sub txt_stock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_stock.KeyPress
        ' vamos a validar que el campo del texbox DNI sea de tipo entero
        If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
            e.Handled = False 'hablita la escritura 
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = True   'se habilita el ingreso de texto
        Else
            'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_stock.Validated
        ' metodo de validacion para el campo APELLIDO
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Debe Ingresar Valores")
        End If
    End Sub



    Private Sub txt_descripcion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_descripcion.Validated
        ' metodo de validacion para el campo APELLIDO
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Debe Ingresar Valores")
        End If
    End Sub

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        ' vamos a validar que el campo del texbox DNI sea de tipo entero
        If Char.IsNumber(e.KeyChar) Then ' si lo que ingresa es un valor numerico 
            e.Handled = False 'hablita la escritura 
        ElseIf Char.IsControl(e.KeyChar) Then 'si tambien es una tecla de control 
            e.Handled = False 'hablita la escritura

        ElseIf Char.IsSeparator(e.KeyChar) Then ' si se presiona la tecla de espacio tambien
            e.Handled = True   'se habilita el ingreso de texto
        Else
            'si ingresa datos alfabeticos se almacena en el Label un mgs de error y se desabilita el control de ingreso
            e.Handled = True
        End If
    End Sub


    Private Sub txt_precio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_precio.Validated
        ' metodo de validacion para el campo APELLIDO
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.EP_error.SetError(sender, "")
        Else
            Me.EP_error.SetError(sender, "Debe Ingresar Valores")
        End If
    End Sub


    Private Sub dg_productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_productos.CellContentClick

    End Sub
End Class