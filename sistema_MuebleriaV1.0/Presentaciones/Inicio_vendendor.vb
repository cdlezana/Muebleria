Public Class Inicio_vendendor


    Private Sub Inicio_vendendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub menu_productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_productos.Click
        fmr_productoAdmin.limpiar() ' llamo al metodo limpiar del formulario productos admin para que cuando se ingresa al formulario de productos del vendedor se limpien los campos correspondientes
        fmr_productoVendedor.ShowDialog()
    End Sub
End Class