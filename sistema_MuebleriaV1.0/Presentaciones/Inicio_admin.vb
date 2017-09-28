Public Class Inicio_admin

    Private Sub VendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_vendedor.Click
        fmr_vendedorAdmin.ShowDialog()
    End Sub

    Private Sub menu_productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_productos.Click
        fmr_productoAdmin.ShowDialog()
    End Sub

    Private Sub Inicio_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        fmr_proveedoresAdmin.ShowDialog()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        fmr_categoriaAdmin.ShowDialog()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub
End Class