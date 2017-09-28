<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmr_productoAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cb_CuitProveedor = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet3 = New Inicio.SistemaMuebleriaDataSet3()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet8 = New Inicio.SistemaMuebleriaDataSet8()
        Me.cb_tipoProd = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet6 = New Inicio.SistemaMuebleriaDataSet6()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet1 = New Inicio.SistemaMuebleriaDataSet1()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_idProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet7 = New Inicio.SistemaMuebleriaDataSet7()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_examinar = New System.Windows.Forms.Button()
        Me.txt_rutaImg = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_descripcionProd = New System.Windows.Forms.Label()
        Me.txt_buscaProd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProductoTableAdapter = New Inicio.SistemaMuebleriaDataSet3TableAdapters.ProductoTableAdapter()
        Me.SistemaMuebleriaDataSet4 = New Inicio.SistemaMuebleriaDataSet4()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New Inicio.SistemaMuebleriaDataSet4TableAdapters.CategoriaTableAdapter()
        Me.SistemaMuebleriaDataSet5 = New Inicio.SistemaMuebleriaDataSet5()
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter1 = New Inicio.SistemaMuebleriaDataSet5TableAdapters.CategoriaTableAdapter()
        Me.CategoriaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoProductoTableAdapter = New Inicio.SistemaMuebleriaDataSet6TableAdapters.TipoProductoTableAdapter()
        Me.ProductoTableAdapter1 = New Inicio.SistemaMuebleriaDataSet7TableAdapters.ProductoTableAdapter()
        Me.CategoriaTableAdapter2 = New Inicio.SistemaMuebleriaDataSet1TableAdapters.CategoriaTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProveedorTableAdapter = New Inicio.SistemaMuebleriaDataSet8TableAdapters.ProveedorTableAdapter()
        Me.EP_error = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.SistemaMuebleriaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP_error, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.cb_CuitProveedor)
        Me.Panel1.Controls.Add(Me.cb_tipoProd)
        Me.Panel1.Controls.Add(Me.cb_categoria)
        Me.Panel1.Controls.Add(Me.txt_precio)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_modificar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.txt_stock)
        Me.Panel1.Controls.Add(Me.txt_descripcion)
        Me.Panel1.Controls.Add(Me.txt_idProducto)
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
        Me.Panel1.TabIndex = 1
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Image = Global.Inicio.My.Resources.Resources.remove_32
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(337, 275)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(93, 45)
        Me.btn_cancelar.TabIndex = 52
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cb_CuitProveedor
        '
        Me.cb_CuitProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource1, "IdProducto", True))
        Me.cb_CuitProveedor.DataSource = Me.ProveedorBindingSource
        Me.cb_CuitProveedor.DisplayMember = "Razon_Soc"
        Me.cb_CuitProveedor.FormattingEnabled = True
        Me.cb_CuitProveedor.Location = New System.Drawing.Point(130, 257)
        Me.cb_CuitProveedor.Name = "cb_CuitProveedor"
        Me.cb_CuitProveedor.Size = New System.Drawing.Size(121, 21)
        Me.cb_CuitProveedor.TabIndex = 41
        Me.cb_CuitProveedor.ValueMember = "Cuit"
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me.SistemaMuebleriaDataSet3
        '
        'SistemaMuebleriaDataSet3
        '
        Me.SistemaMuebleriaDataSet3.DataSetName = "SistemaMuebleriaDataSet3"
        Me.SistemaMuebleriaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.SistemaMuebleriaDataSet8
        '
        'SistemaMuebleriaDataSet8
        '
        Me.SistemaMuebleriaDataSet8.DataSetName = "SistemaMuebleriaDataSet8"
        Me.SistemaMuebleriaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_tipoProd
        '
        Me.cb_tipoProd.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "IdTipoProducto", True))
        Me.cb_tipoProd.DataSource = Me.TipoProductoBindingSource
        Me.cb_tipoProd.DisplayMember = "Descripcion"
        Me.cb_tipoProd.FormattingEnabled = True
        Me.cb_tipoProd.Location = New System.Drawing.Point(130, 299)
        Me.cb_tipoProd.Name = "cb_tipoProd"
        Me.cb_tipoProd.Size = New System.Drawing.Size(146, 21)
        Me.cb_tipoProd.TabIndex = 42
        Me.cb_tipoProd.ValueMember = "id_TipoProducto"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.SistemaMuebleriaDataSet3
        '
        'TipoProductoBindingSource
        '
        Me.TipoProductoBindingSource.DataMember = "TipoProducto"
        Me.TipoProductoBindingSource.DataSource = Me.SistemaMuebleriaDataSet6
        '
        'SistemaMuebleriaDataSet6
        '
        Me.SistemaMuebleriaDataSet6.DataSetName = "SistemaMuebleriaDataSet6"
        Me.SistemaMuebleriaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_categoria
        '
        Me.cb_categoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource1, "IdProducto", True))
        Me.cb_categoria.DataSource = Me.CategoriaBindingSource3
        Me.cb_categoria.DisplayMember = "Descripcion"
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(129, 110)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(146, 21)
        Me.cb_categoria.TabIndex = 37
        Me.cb_categoria.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource3
        '
        Me.CategoriaBindingSource3.DataMember = "Categoria"
        Me.CategoriaBindingSource3.DataSource = Me.SistemaMuebleriaDataSet1
        '
        'SistemaMuebleriaDataSet1
        '
        Me.SistemaMuebleriaDataSet1.DataSetName = "SistemaMuebleriaDataSet1"
        Me.SistemaMuebleriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(128, 223)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(71, 20)
        Me.txt_precio.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(34, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Precio Unitario:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Image = Global.Inicio.My.Resources.Resources.remove_32
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(339, 207)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(93, 45)
        Me.btn_eliminar.TabIndex = 47
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.Inicio.My.Resources.Resources.editar_icono_7412_32
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_modificar.Location = New System.Drawing.Point(339, 136)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(91, 45)
        Me.btn_modificar.TabIndex = 46
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = Global.Inicio.My.Resources.Resources.agregar_editar_icono_6607_32
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(339, 74)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(91, 45)
        Me.btn_agregar.TabIndex = 45
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(128, 186)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(71, 20)
        Me.txt_stock.TabIndex = 39
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(127, 149)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(148, 20)
        Me.txt_descripcion.TabIndex = 38
        '
        'txt_idProducto
        '
        Me.txt_idProducto.Enabled = False
        Me.txt_idProducto.Location = New System.Drawing.Point(127, 74)
        Me.txt_idProducto.Name = "txt_idProducto"
        Me.txt_idProducto.Size = New System.Drawing.Size(148, 20)
        Me.txt_idProducto.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(34, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Id Tipo Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(36, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Cuit Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(36, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Stock:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(33, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(36, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Id Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Id Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(105, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Producto"
        '
        'ProductoBindingSource2
        '
        Me.ProductoBindingSource2.DataMember = "Producto"
        Me.ProductoBindingSource2.DataSource = Me.SistemaMuebleriaDataSet7
        '
        'SistemaMuebleriaDataSet7
        '
        Me.SistemaMuebleriaDataSet7.DataSetName = "SistemaMuebleriaDataSet7"
        Me.SistemaMuebleriaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btn_examinar)
        Me.Panel2.Controls.Add(Me.txt_rutaImg)
        Me.Panel2.Location = New System.Drawing.Point(491, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 395)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Global.Inicio.My.Resources.Resources.sinImagen
        Me.PictureBox1.Location = New System.Drawing.Point(55, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
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
        'btn_examinar
        '
        Me.btn_examinar.Location = New System.Drawing.Point(327, 11)
        Me.btn_examinar.Name = "btn_examinar"
        Me.btn_examinar.Size = New System.Drawing.Size(75, 23)
        Me.btn_examinar.TabIndex = 44
        Me.btn_examinar.Text = "Examinar"
        Me.btn_examinar.UseVisualStyleBackColor = True
        '
        'txt_rutaImg
        '
        Me.txt_rutaImg.Enabled = False
        Me.txt_rutaImg.Location = New System.Drawing.Point(101, 14)
        Me.txt_rutaImg.Name = "txt_rutaImg"
        Me.txt_rutaImg.Size = New System.Drawing.Size(195, 20)
        Me.txt_rutaImg.TabIndex = 43
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lbl_descripcionProd)
        Me.Panel3.Controls.Add(Me.dg_productos)
        Me.Panel3.Controls.Add(Me.txt_buscaProd)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 417)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(953, 242)
        Me.Panel3.TabIndex = 3
        '
        'lbl_descripcionProd
        '
        Me.lbl_descripcionProd.AutoSize = True
        Me.lbl_descripcionProd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descripcionProd.Location = New System.Drawing.Point(577, 29)
        Me.lbl_descripcionProd.Name = "lbl_descripcionProd"
        Me.lbl_descripcionProd.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcionProd.TabIndex = 52
        Me.lbl_descripcionProd.Text = "Descripcion"
        '
        'txt_buscaProd
        '
        Me.txt_buscaProd.Location = New System.Drawing.Point(698, 29)
        Me.txt_buscaProd.Name = "txt_buscaProd"
        Me.txt_buscaProd.Size = New System.Drawing.Size(226, 20)
        Me.txt_buscaProd.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 22)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Buscar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'SistemaMuebleriaDataSet4
        '
        Me.SistemaMuebleriaDataSet4.DataSetName = "SistemaMuebleriaDataSet4"
        Me.SistemaMuebleriaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.SistemaMuebleriaDataSet4
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'SistemaMuebleriaDataSet5
        '
        Me.SistemaMuebleriaDataSet5.DataSetName = "SistemaMuebleriaDataSet5"
        Me.SistemaMuebleriaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataMember = "Categoria"
        Me.CategoriaBindingSource1.DataSource = Me.SistemaMuebleriaDataSet5
        '
        'CategoriaTableAdapter1
        '
        Me.CategoriaTableAdapter1.ClearBeforeFill = True
        '
        'CategoriaBindingSource2
        '
        Me.CategoriaBindingSource2.DataMember = "Categoria"
        Me.CategoriaBindingSource2.DataSource = Me.SistemaMuebleriaDataSet5
        '
        'TipoProductoTableAdapter
        '
        Me.TipoProductoTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter1
        '
        Me.ProductoTableAdapter1.ClearBeforeFill = True
        '
        'CategoriaTableAdapter2
        '
        Me.CategoriaTableAdapter2.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'EP_error
        '
        Me.EP_error.ContainerControl = Me
        '
        'ImagenDataGridViewTextBoxColumn
        '
        Me.ImagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.Name = "ImagenDataGridViewTextBoxColumn"
        Me.ImagenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoProductoDataGridViewTextBoxColumn
        '
        Me.IdTipoProductoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoProducto"
        Me.IdTipoProductoDataGridViewTextBoxColumn.HeaderText = "IdTipoProducto"
        Me.IdTipoProductoDataGridViewTextBoxColumn.Name = "IdTipoProductoDataGridViewTextBoxColumn"
        Me.IdTipoProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitProveedorDataGridViewTextBoxColumn
        '
        Me.CuitProveedorDataGridViewTextBoxColumn.DataPropertyName = "CuitProveedor"
        Me.CuitProveedorDataGridViewTextBoxColumn.HeaderText = "CuitProveedor"
        Me.CuitProveedorDataGridViewTextBoxColumn.Name = "CuitProveedorDataGridViewTextBoxColumn"
        Me.CuitProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dg_productos
        '
        Me.dg_productos.AllowUserToAddRows = False
        Me.dg_productos.AllowUserToDeleteRows = False
        Me.dg_productos.AutoGenerateColumns = False
        Me.dg_productos.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.CuitProveedorDataGridViewTextBoxColumn, Me.IdTipoProductoDataGridViewTextBoxColumn, Me.ImagenDataGridViewTextBoxColumn})
        Me.dg_productos.DataSource = Me.ProductoBindingSource
        Me.dg_productos.Location = New System.Drawing.Point(49, 76)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.ReadOnly = True
        Me.dg_productos.Size = New System.Drawing.Size(848, 150)
        Me.dg_productos.TabIndex = 49
        '
        'fmr_productoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(977, 667)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmr_productoAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmr_prodcutoAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.SistemaMuebleriaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP_error, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_idProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_examinar As System.Windows.Forms.Button
    Friend WithEvents txt_rutaImg As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_buscaProd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcionProd As System.Windows.Forms.Label
    Friend WithEvents SistemaMuebleriaDataSet3 As Inicio.SistemaMuebleriaDataSet3
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As Inicio.SistemaMuebleriaDataSet3TableAdapters.ProductoTableAdapter
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents SistemaMuebleriaDataSet4 As Inicio.SistemaMuebleriaDataSet4
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As Inicio.SistemaMuebleriaDataSet4TableAdapters.CategoriaTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet5 As Inicio.SistemaMuebleriaDataSet5
    Friend WithEvents CategoriaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter1 As Inicio.SistemaMuebleriaDataSet5TableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SistemaMuebleriaDataSet6 As Inicio.SistemaMuebleriaDataSet6
    Friend WithEvents TipoProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoProductoTableAdapter As Inicio.SistemaMuebleriaDataSet6TableAdapters.TipoProductoTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet7 As Inicio.SistemaMuebleriaDataSet7
    Friend WithEvents ProductoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter1 As Inicio.SistemaMuebleriaDataSet7TableAdapters.ProductoTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet1 As Inicio.SistemaMuebleriaDataSet1
    Friend WithEvents CategoriaBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter2 As Inicio.SistemaMuebleriaDataSet1TableAdapters.CategoriaTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cb_CuitProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents SistemaMuebleriaDataSet8 As Inicio.SistemaMuebleriaDataSet8
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As Inicio.SistemaMuebleriaDataSet8TableAdapters.ProveedorTableAdapter
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents EP_error As System.Windows.Forms.ErrorProvider
    Friend WithEvents dg_productos As System.Windows.Forms.DataGridView
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuitProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
