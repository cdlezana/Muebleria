Public Class fmr_proveedoresAdmin
    Private func As New Proveedor
    Private dt As New DataTable

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        'Me.ProveedorTableAdapter.Fill(Me.SistemaMuebleriaDataSet.Proveedor)
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        mostrar()
    End Sub


    Private Sub txt_buscaVend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscaProv.TextChanged
        buscar()
    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            mostrar()
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If rb_cuit.Checked = True Then
                dv.RowFilter = "Cuit" & " like '" & txt_buscaProv.Text & "%'"

            ElseIf rb_razonSocial.Checked = True Then
                dv.RowFilter = "Razon_Soc" & " like '" & txt_buscaProv.Text & "%'"
            End If

            If dv.Count <> 0 Then

                dg_proveedor.DataSource = dv

            Else

                dg_proveedor.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub mostrar()
        'btn_eliminar.Enabled = False
        ' btn_modificar.Enabled = False
        Try

            dt = func.listadoProveedor
            dg_proveedor.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub rellenarTexbox()
        ' EP_error.Clear()
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True

        txt_cuit.Text = (dg_proveedor.CurrentRow.Cells(0).Value)
        txt_razonSocial.Text = (dg_proveedor.CurrentRow.Cells(1).Value)
        txt_telfNum.Text = (dg_proveedor.CurrentRow.Cells(2).Value)
        txt_email.Text = (dg_proveedor.CurrentRow.Cells(3).Value)
        txt_direccion.Text = (dg_proveedor.CurrentRow.Cells(4).Value)
       
    End Sub


    Private Sub dg_proveedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_proveedor.CellContentClick

    End Sub

    Private Sub dg_proveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_proveedor.Click
        rellenarTexbox()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If MsgBox("¿Seguro que desea Modificar un Proveedor?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + 256, "Confirmar Seleccion") = MsgBoxResult.Yes Then
            If func.modificarProveedor(txt_cuit.Text, txt_razonSocial.Text, txt_telfNum.Text, txt_email.Text, txt_direccion.Text) = True Then
                mostrar()
                limpiar()
                MsgBox("Se Modifico correctamente", MsgBoxStyle.Information, "Modificar")
            End If

        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_cuit.Text = "" Or txt_razonSocial.Text = "" Or txt_email.Text = "" Or txt_telfNum.Text = "" Or txt_direccion.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Seguro que desea insertar un Proveedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Insercion") = MsgBoxResult.Yes Then 'si la opcion elegida es el boton SI 
                If func.AltaProveedor(txt_cuit.Text, txt_razonSocial.Text, txt_telfNum.Text, txt_email.Text, txt_direccion.Text) = True Then
                    MsgBox("Se inserto correctamente", MsgBoxStyle.Information, "Guardar")
                    mostrar()

                Else
                    MsgBox("Error en la modificacion", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub


    Private Sub limpiar()

        txt_cuit.Clear()
        txt_razonSocial.Clear()
        txt_email.Clear()
        txt_telfNum.Clear()
        txt_direccion.Clear()

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click

        If func.eliminarProveedor(txt_cuit.Text) = True Then
            mostrar()

        End If


    End Sub
End Class
