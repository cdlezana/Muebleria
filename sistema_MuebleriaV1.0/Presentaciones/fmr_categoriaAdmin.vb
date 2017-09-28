Public Class fmr_categoriaAdmin

    Private func As New Categoria
    Private dt As New DataTable

    Private Sub fmr_categoriaAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        ' Me.CategoriaTableAdapter.Fill(Me.SistemaMuebleriaDataSet.Categoria)

        txt_idCategoria.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        mostrar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            mostrar()
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "Descripcion" & " like '" & txt_buscaCat.Text & "%'"

            
            If dv.Count <> 0 Then

                dg_categoria.DataSource = dv

            Else

                dg_categoria.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub mostrar()
        'btn_eliminar.Enabled = False
        ' btn_modificar.Enabled = False
        Try

            dt = func.listadoCategoria
            dg_categoria.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub txt_buscaCat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscaCat.TextChanged
        buscar()
    End Sub

    Private Sub rellenarTexbox()
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
        txt_idCategoria.Text = (dg_categoria.CurrentRow.Cells(0).Value)
        txt_descripcion.Text = (dg_categoria.CurrentRow.Cells(1).Value)
    End Sub


    Private Sub dg_categoria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_categoria.CellContentClick

    End Sub

    Private Sub dg_categoria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_categoria.Click
        rellenarTexbox()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        If txt_descripcion.Text = "" Then
            MsgBox("Debe completar el campo Descripcion", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro que desea insertar una Nueva Categoria?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Insercion") = MsgBoxResult.Yes Then 'si la opcion elegida es el boton SI 
                If func.AltaCategoria(txt_descripcion.Text) = True Then
                    MsgBox("Se inserto correctamente", MsgBoxStyle.Information, "Guardar")
                    mostrar()
                    limpiar()
                End If

            End If
        End If

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If MsgBox("¿Seguro que desea Modificar al Vendedor?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
            If func.modificarCategoria(txt_idCategoria.Text, txt_descripcion.Text) = True Then
                mostrar()
                limpiar()
                MsgBox("Se Modifico correctamente", MsgBoxStyle.Information, "Modificar")
            End If

        End If
    End Sub


    Private Sub limpiar()

        txt_idCategoria.Clear()
        txt_descripcion.Clear()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click

        If txt_descripcion.Text = "" Then
            MsgBox("No hay Categorias para eliminar", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro desea Eliminar ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
                If func.eliminarCategoria(txt_idCategoria.Text) = True Then
                    MsgBox("Se Elimino correctamente", MsgBoxStyle.Information, "Eliminar")
                    mostrar()
                End If
            End If

        End If

    End Sub
End Class