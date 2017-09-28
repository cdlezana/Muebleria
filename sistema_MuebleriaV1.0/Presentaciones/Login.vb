Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PBadmin.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBadmin.Click

    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Application.Exit()
    End Sub

    Private Sub rbVendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVendedor.CheckedChanged
        If rbVendedor.Checked = True Then
            PBadmin.Visible = False
            PBusuario.Visible = True
        End If
    End Sub

    Private Sub rbAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdmin.CheckedChanged
        If rbAdmin.Checked = True Then
            PBadmin.Visible = True
            PBusuario.visible = False
        End If

    End Sub

    Private Sub btIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btIngresar.Click
        Dim func As New Usuario

        If rbVendedor.Checked = True Then

            If (func.verificar_usuario(txtUsuario.Text, txtpass.Text, 2)) = True Then
                Me.Hide()
                Inicio_vendendor.Show()

            End If

        ElseIf (func.verificar_usuario(txtUsuario.Text, txtpass.Text, 1)) = True Then

            Me.Hide()
            Inicio_admin.Show()
        Else
            MsgBox("USUARIO INCORRECTO")
        End If


    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
