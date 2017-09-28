<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmr_vendedorAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_rutaImg = New System.Windows.Forms.TextBox()
        Me.btn_examinar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EP_error = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_permAdmin = New System.Windows.Forms.RadioButton()
        Me.rb_permVendedor = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_telfNum = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telfCarac = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_idVendedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dg_vendedor = New System.Windows.Forms.DataGridView()
        Me.IdVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelcaracDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelfnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaUsuario = New Inicio.tablaUsuario()
        Me.txt_buscaVend = New System.Windows.Forms.TextBox()
        Me.rb_apellido = New System.Windows.Forms.RadioButton()
        Me.rb_dni = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet2 = New Inicio.SistemaMuebleriaDataSet2()
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet = New Inicio.SistemaMuebleriaDataSet()
        Me.VendedorTableAdapter = New Inicio.SistemaMuebleriaDataSetTableAdapters.VendedorTableAdapter()
        Me.UsuarioTableAdapter = New Inicio.SistemaMuebleriaDataSet2TableAdapters.UsuarioTableAdapter()
        Me.UsuarioTableAdapter1 = New Inicio.tablaUsuarioTableAdapters.UsuarioTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_vendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_rutaImg
        '
        Me.txt_rutaImg.Enabled = False
        Me.txt_rutaImg.Location = New System.Drawing.Point(101, 14)
        Me.txt_rutaImg.Name = "txt_rutaImg"
        Me.txt_rutaImg.Size = New System.Drawing.Size(195, 20)
        Me.txt_rutaImg.TabIndex = 47
        '
        'btn_examinar
        '
        Me.btn_examinar.Location = New System.Drawing.Point(327, 11)
        Me.btn_examinar.Name = "btn_examinar"
        Me.btn_examinar.Size = New System.Drawing.Size(75, 23)
        Me.btn_examinar.TabIndex = 2
        Me.btn_examinar.Text = "Examinar"
        Me.btn_examinar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Foto:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btn_examinar)
        Me.Panel2.Controls.Add(Me.txt_rutaImg)
        Me.Panel2.Location = New System.Drawing.Point(498, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 395)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Global.Inicio.My.Resources.Resources.sinImagen
        Me.EP_error.SetIconAlignment(Me.PictureBox1, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EP_error
        '
        Me.EP_error.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rb_permAdmin)
        Me.Panel1.Controls.Add(Me.rb_permVendedor)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txt_contraseña)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_modificar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_telfNum)
        Me.Panel1.Controls.Add(Me.txt_direccion)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_telfCarac)
        Me.Panel1.Controls.Add(Me.txt_apellido)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.txt_dni)
        Me.Panel1.Controls.Add(Me.txt_idVendedor)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 399)
        Me.Panel1.TabIndex = 0
        '
        'rb_permAdmin
        '
        Me.rb_permAdmin.AutoSize = True
        Me.rb_permAdmin.Location = New System.Drawing.Point(220, 329)
        Me.rb_permAdmin.Name = "rb_permAdmin"
        Me.rb_permAdmin.Size = New System.Drawing.Size(88, 17)
        Me.rb_permAdmin.TabIndex = 56
        Me.rb_permAdmin.TabStop = True
        Me.rb_permAdmin.Text = "Administrador"
        Me.rb_permAdmin.UseVisualStyleBackColor = True
        '
        'rb_permVendedor
        '
        Me.rb_permVendedor.AutoSize = True
        Me.rb_permVendedor.Location = New System.Drawing.Point(128, 329)
        Me.rb_permVendedor.Name = "rb_permVendedor"
        Me.rb_permVendedor.Size = New System.Drawing.Size(71, 17)
        Me.rb_permVendedor.TabIndex = 55
        Me.rb_permVendedor.TabStop = True
        Me.rb_permVendedor.Text = "Vendedor"
        Me.rb_permVendedor.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(34, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Permiso:"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(128, 181)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(148, 20)
        Me.txt_contraseña.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(34, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Contraseña:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Image = Global.Inicio.My.Resources.Resources.remove_32
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(337, 275)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(93, 45)
        Me.btn_eliminar.TabIndex = 50
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.Inicio.My.Resources.Resources.editar_icono_7412_32
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_modificar.Location = New System.Drawing.Point(339, 161)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(91, 45)
        Me.btn_modificar.TabIndex = 49
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = Global.Inicio.My.Resources.Resources.agregar_editar_icono_6607_32
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(339, 61)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(91, 45)
        Me.btn_agregar.TabIndex = 48
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "-"
        '
        'txt_telfNum
        '
        Me.txt_telfNum.Location = New System.Drawing.Point(187, 207)
        Me.txt_telfNum.Name = "txt_telfNum"
        Me.txt_telfNum.Size = New System.Drawing.Size(89, 20)
        Me.txt_telfNum.TabIndex = 42
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(128, 268)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(148, 48)
        Me.txt_direccion.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(34, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Direccion:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(128, 237)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(148, 20)
        Me.txt_email.TabIndex = 43
        '
        'txt_telfCarac
        '
        Me.txt_telfCarac.Location = New System.Drawing.Point(128, 207)
        Me.txt_telfCarac.Name = "txt_telfCarac"
        Me.txt_telfCarac.Size = New System.Drawing.Size(39, 20)
        Me.txt_telfCarac.TabIndex = 41
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(128, 152)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(148, 20)
        Me.txt_apellido.TabIndex = 39
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(128, 124)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(148, 20)
        Me.txt_nombre.TabIndex = 38
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(128, 93)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(148, 20)
        Me.txt_dni.TabIndex = 37
        '
        'txt_idVendedor
        '
        Me.txt_idVendedor.Enabled = False
        Me.txt_idVendedor.Location = New System.Drawing.Point(128, 67)
        Me.txt_idVendedor.Name = "txt_idVendedor"
        Me.txt_idVendedor.Size = New System.Drawing.Size(148, 20)
        Me.txt_idVendedor.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(37, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(34, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(34, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(34, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(37, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "D.N.I:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Id Vendedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(105, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Vendedor"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dg_vendedor)
        Me.Panel3.Controls.Add(Me.txt_buscaVend)
        Me.Panel3.Controls.Add(Me.rb_apellido)
        Me.Panel3.Controls.Add(Me.rb_dni)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 417)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(960, 242)
        Me.Panel3.TabIndex = 2
        '
        'dg_vendedor
        '
        Me.dg_vendedor.AllowUserToAddRows = False
        Me.dg_vendedor.AllowUserToDeleteRows = False
        Me.dg_vendedor.AutoGenerateColumns = False
        Me.dg_vendedor.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dg_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_vendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_vendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVendedorDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.TelcaracDataGridViewTextBoxColumn, Me.TelfnumDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.PermisosDataGridViewTextBoxColumn, Me.BajaDataGridViewTextBoxColumn, Me.ImagenDataGridViewTextBoxColumn})
        Me.dg_vendedor.DataSource = Me.UsuarioBindingSource1
        Me.dg_vendedor.Location = New System.Drawing.Point(16, 75)
        Me.dg_vendedor.Name = "dg_vendedor"
        Me.dg_vendedor.ReadOnly = True
        Me.dg_vendedor.Size = New System.Drawing.Size(924, 150)
        Me.dg_vendedor.TabIndex = 49
        '
        'IdVendedorDataGridViewTextBoxColumn
        '
        Me.IdVendedorDataGridViewTextBoxColumn.DataPropertyName = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.HeaderText = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.Name = "IdVendedorDataGridViewTextBoxColumn"
        Me.IdVendedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdVendedorDataGridViewTextBoxColumn.Width = 80
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "Dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "Dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        Me.DniDataGridViewTextBoxColumn.Width = 70
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelcaracDataGridViewTextBoxColumn
        '
        Me.TelcaracDataGridViewTextBoxColumn.DataPropertyName = "Tel_carac"
        Me.TelcaracDataGridViewTextBoxColumn.HeaderText = "Tel_carac"
        Me.TelcaracDataGridViewTextBoxColumn.Name = "TelcaracDataGridViewTextBoxColumn"
        Me.TelcaracDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelcaracDataGridViewTextBoxColumn.Width = 50
        '
        'TelfnumDataGridViewTextBoxColumn
        '
        Me.TelfnumDataGridViewTextBoxColumn.DataPropertyName = "Telf_num"
        Me.TelfnumDataGridViewTextBoxColumn.HeaderText = "Telf_num"
        Me.TelfnumDataGridViewTextBoxColumn.Name = "TelfnumDataGridViewTextBoxColumn"
        Me.TelfnumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PermisosDataGridViewTextBoxColumn
        '
        Me.PermisosDataGridViewTextBoxColumn.DataPropertyName = "Permisos"
        Me.PermisosDataGridViewTextBoxColumn.HeaderText = "Permisos"
        Me.PermisosDataGridViewTextBoxColumn.Name = "PermisosDataGridViewTextBoxColumn"
        Me.PermisosDataGridViewTextBoxColumn.ReadOnly = True
        Me.PermisosDataGridViewTextBoxColumn.Visible = False
        '
        'BajaDataGridViewTextBoxColumn
        '
        Me.BajaDataGridViewTextBoxColumn.DataPropertyName = "Baja"
        Me.BajaDataGridViewTextBoxColumn.HeaderText = "Baja"
        Me.BajaDataGridViewTextBoxColumn.Name = "BajaDataGridViewTextBoxColumn"
        Me.BajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BajaDataGridViewTextBoxColumn.Visible = False
        '
        'ImagenDataGridViewTextBoxColumn
        '
        Me.ImagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.Name = "ImagenDataGridViewTextBoxColumn"
        Me.ImagenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImagenDataGridViewTextBoxColumn.Width = 150
        '
        'UsuarioBindingSource1
        '
        Me.UsuarioBindingSource1.DataMember = "Usuario"
        Me.UsuarioBindingSource1.DataSource = Me.TablaUsuario
        '
        'TablaUsuario
        '
        Me.TablaUsuario.DataSetName = "tablaUsuario"
        Me.TablaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_buscaVend
        '
        Me.txt_buscaVend.Location = New System.Drawing.Point(504, 28)
        Me.txt_buscaVend.Name = "txt_buscaVend"
        Me.txt_buscaVend.Size = New System.Drawing.Size(226, 20)
        Me.txt_buscaVend.TabIndex = 48
        '
        'rb_apellido
        '
        Me.rb_apellido.AutoSize = True
        Me.rb_apellido.Location = New System.Drawing.Point(350, 28)
        Me.rb_apellido.Name = "rb_apellido"
        Me.rb_apellido.Size = New System.Drawing.Size(62, 17)
        Me.rb_apellido.TabIndex = 47
        Me.rb_apellido.Text = "Apellido"
        Me.rb_apellido.UseVisualStyleBackColor = True
        '
        'rb_dni
        '
        Me.rb_dni.AutoSize = True
        Me.rb_dni.Checked = True
        Me.rb_dni.Location = New System.Drawing.Point(259, 28)
        Me.rb_dni.Name = "rb_dni"
        Me.rb_dni.Size = New System.Drawing.Size(41, 17)
        Me.rb_dni.TabIndex = 46
        Me.rb_dni.TabStop = True
        Me.rb_dni.Text = "Dni"
        Me.rb_dni.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(100, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 22)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Buscar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.SistemaMuebleriaDataSet2
        '
        'SistemaMuebleriaDataSet2
        '
        Me.SistemaMuebleriaDataSet2.DataSetName = "SistemaMuebleriaDataSet2"
        Me.SistemaMuebleriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.SistemaMuebleriaDataSetBindingSource
        '
        'SistemaMuebleriaDataSetBindingSource
        '
        Me.SistemaMuebleriaDataSetBindingSource.DataSource = Me.SistemaMuebleriaDataSet
        Me.SistemaMuebleriaDataSetBindingSource.Position = 0
        '
        'SistemaMuebleriaDataSet
        '
        Me.SistemaMuebleriaDataSet.DataSetName = "SistemaMuebleriaDataSet"
        Me.SistemaMuebleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter1
        '
        Me.UsuarioTableAdapter1.ClearBeforeFill = True
        '
        'fmr_vendedorAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(983, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "fmr_vendedorAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_vendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telfCarac As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_idVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_rutaImg As System.Windows.Forms.TextBox
    Friend WithEvents btn_examinar As System.Windows.Forms.Button
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents EP_error As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_telfNum As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_buscaVend As System.Windows.Forms.TextBox
    Friend WithEvents rb_apellido As System.Windows.Forms.RadioButton
    Friend WithEvents rb_dni As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dg_vendedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents SistemaMuebleriaDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SistemaMuebleriaDataSet As Inicio.SistemaMuebleriaDataSet
    Friend WithEvents VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendedorTableAdapter As Inicio.SistemaMuebleriaDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet2 As Inicio.SistemaMuebleriaDataSet2
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As Inicio.SistemaMuebleriaDataSet2TableAdapters.UsuarioTableAdapter
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rb_permAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rb_permVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents TablaUsuario As Inicio.tablaUsuario
    Friend WithEvents UsuarioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter1 As Inicio.tablaUsuarioTableAdapters.UsuarioTableAdapter
    Friend WithEvents IdVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelcaracDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelfnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermisosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
