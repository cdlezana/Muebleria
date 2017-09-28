<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbVendedor = New System.Windows.Forms.RadioButton()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBusuario = New System.Windows.Forms.PictureBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.PBadmin = New System.Windows.Forms.PictureBox()
        CType(Me.PBusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbVendedor
        '
        Me.rbVendedor.AutoSize = True
        Me.rbVendedor.BackColor = System.Drawing.Color.Transparent
        Me.rbVendedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbVendedor.Location = New System.Drawing.Point(295, 29)
        Me.rbVendedor.Name = "rbVendedor"
        Me.rbVendedor.Size = New System.Drawing.Size(77, 19)
        Me.rbVendedor.TabIndex = 0
        Me.rbVendedor.TabStop = True
        Me.rbVendedor.Text = "Vendedor"
        Me.rbVendedor.UseVisualStyleBackColor = False
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.rbAdmin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAdmin.Location = New System.Drawing.Point(415, 31)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(102, 19)
        Me.rbAdmin.TabIndex = 1
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Administrador"
        Me.rbAdmin.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(295, 80)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(295, 124)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(193, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(193, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(193, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña"
        '
        'PBusuario
        '
        Me.PBusuario.BackgroundImage = Global.Inicio.My.Resources.Resources.vendedor
        Me.PBusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBusuario.Location = New System.Drawing.Point(3, 12)
        Me.PBusuario.Name = "PBusuario"
        Me.PBusuario.Size = New System.Drawing.Size(147, 167)
        Me.PBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBusuario.TabIndex = 10
        Me.PBusuario.TabStop = False
        '
        'btSalir
        '
        Me.btSalir.Image = Global.Inicio.My.Resources.Resources.exit_48
        Me.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalir.Location = New System.Drawing.Point(362, 166)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(89, 49)
        Me.btSalir.TabIndex = 9
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btIngresar
        '
        Me.btIngresar.Image = Global.Inicio.My.Resources.Resources.log_out_32
        Me.btIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btIngresar.Location = New System.Drawing.Point(225, 166)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(89, 49)
        Me.btIngresar.TabIndex = 8
        Me.btIngresar.Text = "Ingresar"
        Me.btIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'PBadmin
        '
        Me.PBadmin.BackgroundImage = Global.Inicio.My.Resources.Resources.admin1
        Me.PBadmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBadmin.Image = Global.Inicio.My.Resources.Resources.admin
        Me.PBadmin.Location = New System.Drawing.Point(3, 12)
        Me.PBadmin.Name = "PBadmin"
        Me.PBadmin.Size = New System.Drawing.Size(147, 167)
        Me.PBadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBadmin.TabIndex = 7
        Me.PBadmin.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(529, 227)
        Me.Controls.Add(Me.PBusuario)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.PBadmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.rbVendedor)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBusuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PBadmin As System.Windows.Forms.PictureBox
    Friend WithEvents btIngresar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents PBusuario As System.Windows.Forms.PictureBox

End Class
