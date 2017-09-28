Public Class fmr_ventasVendedor

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub fmr_ventasVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet16.Detalle' Puede moverla o quitarla según sea necesario.
        Me.DetalleTableAdapter2.Fill(Me.SistemaMuebleriaDataSet16.Detalle)
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet15.Detalle' Puede moverla o quitarla según sea necesario.
        Me.DetalleTableAdapter1.Fill(Me.SistemaMuebleriaDataSet15.Detalle)
        'TODO: esta línea de código carga datos en la tabla 'SistemaMuebleriaDataSet14.Detalle' Puede moverla o quitarla según sea necesario.
        Me.DetalleTableAdapter.Fill(Me.SistemaMuebleriaDataSet14.Detalle)

    End Sub

    
End Class