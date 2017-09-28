Public Class fmr_productoVendedor
    Private func As New Producto
    Private dt As New DataTable
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fmr_productoVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet13.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.SistemaMuebleriaDataSet13.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet6.TipoProducto' Puede moverla o quitarla según sea necesario.
        Me.TipoProductoTableAdapter.Fill(Me.SistemaMuebleriaDataSet6.TipoProducto)
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet11.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.SistemaMuebleriaDataSet11.Categoria)
        mostrar()
        inabilitar_opcion()
    End Sub

    Private Sub dg_productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_productos.CellContentClick

    End Sub

    Private Sub rellenarTextbox()
        ' EP_error.Clear()

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

    Private Sub mostrar()
        Try
            dt = func.listadoProductos
            dg_productos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub inabilitar_opcion()
        txt_idProducto.Enabled = False
        cb_categoria.Enabled = False
        txt_descripcion.Enabled = False
        txt_stock.Enabled = False
        txt_precio.Enabled = False
        cb_CuitProveedor.Enabled = False
        cb_tipoProd.Enabled = False
        txt_rutaImg.Enabled = False

    End Sub
    
    Private Sub txt_buscaProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscaProd.TextChanged
        buscar()
    End Sub




    Private Sub buscar()
        Dim ds As New DataSet

        Try
            mostrar()
            ds.Tables.Add(dt.Copy)

            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "Descripcion" & " like '" & txt_buscaProd.Text & "%'"

            If dv.Count <> 0 Then

                dg_productos.DataSource = dv

            Else

                dg_productos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


End Class