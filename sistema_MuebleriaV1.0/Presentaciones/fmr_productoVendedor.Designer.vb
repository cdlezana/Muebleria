<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmr_productoVendedor
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
        Me.cb_CuitProveedor = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet9 = New Inicio.SistemaMuebleriaDataSet9()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_tipoProd = New System.Windows.Forms.ComboBox()
        Me.TipoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet6 = New Inicio.SistemaMuebleriaDataSet6()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaMuebleriaDataSet11 = New Inicio.SistemaMuebleriaDataSet11()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_examinar = New System.Windows.Forms.Button()
        Me.txt_rutaImg = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_descripcionProd = New System.Windows.Forms.Label()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscaProd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CategoriaTableAdapter = New Inicio.SistemaMuebleriaDataSet11TableAdapters.CategoriaTableAdapter()
        Me.SistemaMuebleriaDataSet1 = New Inicio.SistemaMuebleriaDataSet()
        Me.TipoProductoTableAdapter = New Inicio.SistemaMuebleriaDataSet6TableAdapters.TipoProductoTableAdapter()
        Me.SistemaMuebleriaDataSet13 = New Inicio.SistemaMuebleriaDataSet13()
        Me.ProveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New Inicio.SistemaMuebleriaDataSet13TableAdapters.ProveedorTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaMuebleriaDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cb_CuitProveedor)
        Me.Panel1.Controls.Add(Me.cb_tipoProd)
        Me.Panel1.Controls.Add(Me.cb_categoria)
        Me.Panel1.Controls.Add(Me.txt_precio)
        Me.Panel1.Controls.Add(Me.Label12)
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
        Me.Panel1.Size = New System.Drawing.Size(398, 359)
        Me.Panel1.TabIndex = 2
        '
        'cb_CuitProveedor
        '
        Me.cb_CuitProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "IdProducto", True))
        Me.cb_CuitProveedor.DataSource = Me.ProveedorBindingSource1
        Me.cb_CuitProveedor.DisplayMember = "Razon_Soc"
        Me.cb_CuitProveedor.FormattingEnabled = True
        Me.cb_CuitProveedor.Location = New System.Drawing.Point(130, 257)
        Me.cb_CuitProveedor.Name = "cb_CuitProveedor"
        Me.cb_CuitProveedor.Size = New System.Drawing.Size(121, 21)
        Me.cb_CuitProveedor.TabIndex = 41
        Me.cb_CuitProveedor.ValueMember = "Cuit"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.SistemaMuebleriaDataSet9
        '
        'SistemaMuebleriaDataSet9
        '
        Me.SistemaMuebleriaDataSet9.DataSetName = "SistemaMuebleriaDataSet9"
        Me.SistemaMuebleriaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_tipoProd
        '
        Me.cb_tipoProd.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "IdProducto", True))
        Me.cb_tipoProd.DataSource = Me.TipoProductoBindingSource
        Me.cb_tipoProd.DisplayMember = "Descripcion"
        Me.cb_tipoProd.FormattingEnabled = True
        Me.cb_tipoProd.Location = New System.Drawing.Point(130, 299)
        Me.cb_tipoProd.Name = "cb_tipoProd"
        Me.cb_tipoProd.Size = New System.Drawing.Size(146, 21)
        Me.cb_tipoProd.TabIndex = 42
        Me.cb_tipoProd.ValueMember = "id_TipoProducto"
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
        Me.cb_categoria.DataSource = Me.CategoriaBindingSource
        Me.cb_categoria.DisplayMember = "Descripcion"
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(129, 110)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(146, 21)
        Me.cb_categoria.TabIndex = 37
        Me.cb_categoria.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.SistemaMuebleriaDataSet11
        '
        'SistemaMuebleriaDataSet11
        '
        Me.SistemaMuebleriaDataSet11.DataSetName = "SistemaMuebleriaDataSet11"
        Me.SistemaMuebleriaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta Producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btn_examinar)
        Me.Panel2.Controls.Add(Me.txt_rutaImg)
        Me.Panel2.Location = New System.Drawing.Point(458, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(453, 359)
        Me.Panel2.TabIndex = 3
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
        Me.PictureBox1.Size = New System.Drawing.Size(340, 245)
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
        Me.Panel3.Location = New System.Drawing.Point(12, 384)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 242)
        Me.Panel3.TabIndex = 4
        '
        'lbl_descripcionProd
        '
        Me.lbl_descripcionProd.AutoSize = True
        Me.lbl_descripcionProd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descripcionProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcionProd.Location = New System.Drawing.Point(212, 36)
        Me.lbl_descripcionProd.Name = "lbl_descripcionProd"
        Me.lbl_descripcionProd.Size = New System.Drawing.Size(92, 18)
        Me.lbl_descripcionProd.TabIndex = 52
        Me.lbl_descripcionProd.Text = "Descripcion"
        '
        'dg_productos
        '
        Me.dg_productos.AllowUserToAddRows = False
        Me.dg_productos.AllowUserToDeleteRows = False
        Me.dg_productos.AllowUserToResizeColumns = False
        Me.dg_productos.AllowUserToResizeRows = False
        Me.dg_productos.AutoGenerateColumns = False
        Me.dg_productos.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.CuitProveedorDataGridViewTextBoxColumn, Me.IdTipoProductoDataGridViewTextBoxColumn, Me.ImagenDataGridViewTextBoxColumn})
        Me.dg_productos.DataSource = Me.ProductoBindingSource
        Me.dg_productos.Location = New System.Drawing.Point(181, 74)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.ReadOnly = True
        Me.dg_productos.Size = New System.Drawing.Size(521, 150)
        Me.dg_productos.TabIndex = 49
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitProveedorDataGridViewTextBoxColumn
        '
        Me.CuitProveedorDataGridViewTextBoxColumn.DataPropertyName = "CuitProveedor"
        Me.CuitProveedorDataGridViewTextBoxColumn.HeaderText = "CuitProveedor"
        Me.CuitProveedorDataGridViewTextBoxColumn.Name = "CuitProveedorDataGridViewTextBoxColumn"
        Me.CuitProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuitProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'IdTipoProductoDataGridViewTextBoxColumn
        '
        Me.IdTipoProductoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoProducto"
        Me.IdTipoProductoDataGridViewTextBoxColumn.HeaderText = "IdTipoProducto"
        Me.IdTipoProductoDataGridViewTextBoxColumn.Name = "IdTipoProductoDataGridViewTextBoxColumn"
        Me.IdTipoProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTipoProductoDataGridViewTextBoxColumn.Visible = False
        '
        'ImagenDataGridViewTextBoxColumn
        '
        Me.ImagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewTextBoxColumn.Name = "ImagenDataGridViewTextBoxColumn"
        Me.ImagenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImagenDataGridViewTextBoxColumn.Visible = False
        '
        'txt_buscaProd
        '
        Me.txt_buscaProd.Location = New System.Drawing.Point(350, 33)
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
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'SistemaMuebleriaDataSet1
        '
        Me.SistemaMuebleriaDataSet1.DataSetName = "SistemaMuebleriaDataSet"
        Me.SistemaMuebleriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoProductoTableAdapter
        '
        Me.TipoProductoTableAdapter.ClearBeforeFill = True
        '
        'SistemaMuebleriaDataSet13
        '
        Me.SistemaMuebleriaDataSet13.DataSetName = "SistemaMuebleriaDataSet13"
        Me.SistemaMuebleriaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource1
        '
        Me.ProveedorBindingSource1.DataMember = "Proveedor"
        Me.ProveedorBindingSource1.DataSource = Me.SistemaMuebleriaDataSet13
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'fmr_productoVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(933, 640)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmr_productoVendedor"
        Me.Text = "fmr_productoVendedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaMuebleriaDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_CuitProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_examinar As System.Windows.Forms.Button
    Friend WithEvents txt_rutaImg As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_descripcionProd As System.Windows.Forms.Label
    Friend WithEvents txt_buscaProd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dg_productos As System.Windows.Forms.DataGridView
    Friend WithEvents SistemaMuebleriaDataSet11 As Inicio.SistemaMuebleriaDataSet11
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As Inicio.SistemaMuebleriaDataSet11TableAdapters.CategoriaTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet1 As Inicio.SistemaMuebleriaDataSet
    Friend WithEvents SistemaMuebleriaDataSet9 As Inicio.SistemaMuebleriaDataSet9
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuitProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SistemaMuebleriaDataSet6 As Inicio.SistemaMuebleriaDataSet6
    Friend WithEvents TipoProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoProductoTableAdapter As Inicio.SistemaMuebleriaDataSet6TableAdapters.TipoProductoTableAdapter
    Friend WithEvents SistemaMuebleriaDataSet13 As Inicio.SistemaMuebleriaDataSet13
    Friend WithEvents ProveedorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As Inicio.SistemaMuebleriaDataSet13TableAdapters.ProveedorTableAdapter
End Class
