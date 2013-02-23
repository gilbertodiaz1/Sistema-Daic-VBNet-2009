<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.DataGridViewArticulo = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DboMueblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetArticulo = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet
        Me.DataGridViewEmpleado = New System.Windows.Forms.DataGridView
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaIngDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DboEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEmpleadoR = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet1
        Me.DataGridViewProducto = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DboProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProducto = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet2
        Me.DataGridViewServicio = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DboServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetServicio = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet3
        Me.ButtonArticulo = New System.Windows.Forms.Button
        Me.ButtonEmpleado = New System.Windows.Forms.Button
        Me.ButtonProducto = New System.Windows.Forms.Button
        Me.ButtonServicio = New System.Windows.Forms.Button
        Me.Dbo_MueblesTableAdapter = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSetTableAdapters.dbo_MueblesTableAdapter
        Me.Dbo_EmpleadoTableAdapter = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet1TableAdapters.dbo_EmpleadoTableAdapter
        Me.Dbo_ProductoTableAdapter = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet2TableAdapters.dbo_ProductoTableAdapter
        Me.Dbo_ServicioTableAdapter = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet3TableAdapters.dbo_ServicioTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewGanancia = New System.Windows.Forms.DataGridView
        Me.CedulaEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorGananciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorGananciaNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DboEmpleadoGananciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DivalI_FDataSet4 = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet4
        Me.Dbo_Empleado_GananciasTableAdapter = New Sistema_de_Inventario_y_Facturación._DivalI_FDataSet4TableAdapters.dbo_Empleado_GananciasTableAdapter
        CType(Me.DataGridViewArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboMueblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEmpleadoR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewGanancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboEmpleadoGananciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DivalI_FDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewArticulo
        '
        Me.DataGridViewArticulo.AutoGenerateColumns = False
        Me.DataGridViewArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArticulo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.DataGridViewArticulo.DataSource = Me.DboMueblesBindingSource
        Me.DataGridViewArticulo.Location = New System.Drawing.Point(269, 36)
        Me.DataGridViewArticulo.Name = "DataGridViewArticulo"
        Me.DataGridViewArticulo.Size = New System.Drawing.Size(38, 61)
        Me.DataGridViewArticulo.TabIndex = 0
        Me.DataGridViewArticulo.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'DboMueblesBindingSource
        '
        Me.DboMueblesBindingSource.DataMember = "dbo_Muebles"
        Me.DboMueblesBindingSource.DataSource = Me.DataSetArticulo
        '
        'DataSetArticulo
        '
        Me.DataSetArticulo.DataSetName = "_DivalI_FDataSet"
        Me.DataSetArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewEmpleado
        '
        Me.DataGridViewEmpleado.AutoGenerateColumns = False
        Me.DataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CedulaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn1, Me.ApellidioDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.FechaIngDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.MovilDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridViewEmpleado.DataSource = Me.DboEmpleadoBindingSource
        Me.DataGridViewEmpleado.Location = New System.Drawing.Point(313, 36)
        Me.DataGridViewEmpleado.Name = "DataGridViewEmpleado"
        Me.DataGridViewEmpleado.Size = New System.Drawing.Size(38, 61)
        Me.DataGridViewEmpleado.TabIndex = 1
        Me.DataGridViewEmpleado.Visible = False
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'ApellidioDataGridViewTextBoxColumn
        '
        Me.ApellidioDataGridViewTextBoxColumn.DataPropertyName = "Apellidio"
        Me.ApellidioDataGridViewTextBoxColumn.HeaderText = "Apellidio"
        Me.ApellidioDataGridViewTextBoxColumn.Name = "ApellidioDataGridViewTextBoxColumn"
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha_Nac"
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        '
        'FechaIngDataGridViewTextBoxColumn
        '
        Me.FechaIngDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ing"
        Me.FechaIngDataGridViewTextBoxColumn.HeaderText = "Fecha_Ing"
        Me.FechaIngDataGridViewTextBoxColumn.Name = "FechaIngDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'MovilDataGridViewTextBoxColumn
        '
        Me.MovilDataGridViewTextBoxColumn.DataPropertyName = "Movil"
        Me.MovilDataGridViewTextBoxColumn.HeaderText = "Movil"
        Me.MovilDataGridViewTextBoxColumn.Name = "MovilDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'DboEmpleadoBindingSource
        '
        Me.DboEmpleadoBindingSource.DataMember = "dbo_Empleado"
        Me.DboEmpleadoBindingSource.DataSource = Me.DataSetEmpleadoR
        '
        'DataSetEmpleadoR
        '
        Me.DataSetEmpleadoR.DataSetName = "_DivalI_FDataSet1"
        Me.DataSetEmpleadoR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewProducto
        '
        Me.DataGridViewProducto.AutoGenerateColumns = False
        Me.DataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn2, Me.DescripcionDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn1, Me.PrecioDataGridViewTextBoxColumn1})
        Me.DataGridViewProducto.DataSource = Me.DboProductoBindingSource
        Me.DataGridViewProducto.Location = New System.Drawing.Point(269, 103)
        Me.DataGridViewProducto.Name = "DataGridViewProducto"
        Me.DataGridViewProducto.Size = New System.Drawing.Size(38, 61)
        Me.DataGridViewProducto.TabIndex = 2
        Me.DataGridViewProducto.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        '
        'PrecioDataGridViewTextBoxColumn1
        '
        Me.PrecioDataGridViewTextBoxColumn1.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn1.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn1.Name = "PrecioDataGridViewTextBoxColumn1"
        '
        'DboProductoBindingSource
        '
        Me.DboProductoBindingSource.DataMember = "dbo_Producto"
        Me.DboProductoBindingSource.DataSource = Me.DataSetProducto
        '
        'DataSetProducto
        '
        Me.DataSetProducto.DataSetName = "_DivalI_FDataSet2"
        Me.DataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewServicio
        '
        Me.DataGridViewServicio.AutoGenerateColumns = False
        Me.DataGridViewServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn2, Me.DescripcionDataGridViewTextBoxColumn2, Me.PrecioDataGridViewTextBoxColumn2})
        Me.DataGridViewServicio.DataSource = Me.DboServicioBindingSource
        Me.DataGridViewServicio.Location = New System.Drawing.Point(48, 222)
        Me.DataGridViewServicio.Name = "DataGridViewServicio"
        Me.DataGridViewServicio.Size = New System.Drawing.Size(215, 192)
        Me.DataGridViewServicio.TabIndex = 3
        '
        'CodigoDataGridViewTextBoxColumn2
        '
        Me.CodigoDataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.Name = "CodigoDataGridViewTextBoxColumn2"
        '
        'DescripcionDataGridViewTextBoxColumn2
        '
        Me.DescripcionDataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn2.Name = "DescripcionDataGridViewTextBoxColumn2"
        '
        'PrecioDataGridViewTextBoxColumn2
        '
        Me.PrecioDataGridViewTextBoxColumn2.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn2.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn2.Name = "PrecioDataGridViewTextBoxColumn2"
        '
        'DboServicioBindingSource
        '
        Me.DboServicioBindingSource.DataMember = "dbo_Servicio"
        Me.DboServicioBindingSource.DataSource = Me.DataSetServicio
        '
        'DataSetServicio
        '
        Me.DataSetServicio.DataSetName = "_DivalI_FDataSet3"
        Me.DataSetServicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonArticulo
        '
        Me.ButtonArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonArticulo.Location = New System.Drawing.Point(26, 39)
        Me.ButtonArticulo.Name = "ButtonArticulo"
        Me.ButtonArticulo.Size = New System.Drawing.Size(109, 59)
        Me.ButtonArticulo.TabIndex = 4
        Me.ButtonArticulo.Text = "Inventario de Articulos"
        Me.ToolTip1.SetToolTip(Me.ButtonArticulo, "Haga clic para generar el inventario detallado de todos los articulos.")
        Me.ButtonArticulo.UseVisualStyleBackColor = True
        '
        'ButtonEmpleado
        '
        Me.ButtonEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonEmpleado.Location = New System.Drawing.Point(18, 39)
        Me.ButtonEmpleado.Name = "ButtonEmpleado"
        Me.ButtonEmpleado.Size = New System.Drawing.Size(109, 59)
        Me.ButtonEmpleado.TabIndex = 5
        Me.ButtonEmpleado.Text = "Reporte de Empleados"
        Me.ToolTip1.SetToolTip(Me.ButtonEmpleado, "Haga clic para generar un reporte detallado con todos los empleados.")
        Me.ButtonEmpleado.UseVisualStyleBackColor = True
        '
        'ButtonProducto
        '
        Me.ButtonProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonProducto.Location = New System.Drawing.Point(156, 39)
        Me.ButtonProducto.Name = "ButtonProducto"
        Me.ButtonProducto.Size = New System.Drawing.Size(109, 59)
        Me.ButtonProducto.TabIndex = 6
        Me.ButtonProducto.Text = "Inventario de Producto"
        Me.ToolTip1.SetToolTip(Me.ButtonProducto, "Haga clic para generar el inventario detallado de todos los productos.")
        Me.ButtonProducto.UseVisualStyleBackColor = True
        '
        'ButtonServicio
        '
        Me.ButtonServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonServicio.Location = New System.Drawing.Point(150, 39)
        Me.ButtonServicio.Name = "ButtonServicio"
        Me.ButtonServicio.Size = New System.Drawing.Size(109, 59)
        Me.ButtonServicio.TabIndex = 7
        Me.ButtonServicio.Text = "Reporte de Servicio"
        Me.ToolTip1.SetToolTip(Me.ButtonServicio, "Haga clic para generar un reporte detallado con todos los servicios.")
        Me.ButtonServicio.UseVisualStyleBackColor = True
        '
        'Dbo_MueblesTableAdapter
        '
        Me.Dbo_MueblesTableAdapter.ClearBeforeFill = True
        '
        'Dbo_EmpleadoTableAdapter
        '
        Me.Dbo_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Dbo_ProductoTableAdapter
        '
        Me.Dbo_ProductoTableAdapter.ClearBeforeFill = True
        '
        'Dbo_ServicioTableAdapter
        '
        Me.Dbo_ServicioTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonServicio)
        Me.GroupBox1.Controls.Add(Me.ButtonEmpleado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(30, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 127)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ButtonArticulo)
        Me.GroupBox2.Controls.Add(Me.ButtonProducto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(331, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 127)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(147, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Menú de inventarios y reportes"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(502, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Regresar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Haga clic o presione (Esc) para regresar al menú principal.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'DataGridViewGanancia
        '
        Me.DataGridViewGanancia.AutoGenerateColumns = False
        Me.DataGridViewGanancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGanancia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CedulaEDataGridViewTextBoxColumn, Me.CodigoSDataGridViewTextBoxColumn, Me.PorGananciaDataGridViewTextBoxColumn, Me.PorGananciaNDataGridViewTextBoxColumn})
        Me.DataGridViewGanancia.DataSource = Me.DboEmpleadoGananciasBindingSource
        Me.DataGridViewGanancia.Location = New System.Drawing.Point(269, 251)
        Me.DataGridViewGanancia.Name = "DataGridViewGanancia"
        Me.DataGridViewGanancia.Size = New System.Drawing.Size(235, 142)
        Me.DataGridViewGanancia.TabIndex = 12
        '
        'CedulaEDataGridViewTextBoxColumn
        '
        Me.CedulaEDataGridViewTextBoxColumn.DataPropertyName = "Cedula_E"
        Me.CedulaEDataGridViewTextBoxColumn.HeaderText = "Cedula_E"
        Me.CedulaEDataGridViewTextBoxColumn.Name = "CedulaEDataGridViewTextBoxColumn"
        '
        'CodigoSDataGridViewTextBoxColumn
        '
        Me.CodigoSDataGridViewTextBoxColumn.DataPropertyName = "Codigo_S"
        Me.CodigoSDataGridViewTextBoxColumn.HeaderText = "Codigo_S"
        Me.CodigoSDataGridViewTextBoxColumn.Name = "CodigoSDataGridViewTextBoxColumn"
        '
        'PorGananciaDataGridViewTextBoxColumn
        '
        Me.PorGananciaDataGridViewTextBoxColumn.DataPropertyName = "Por_Ganancia"
        Me.PorGananciaDataGridViewTextBoxColumn.HeaderText = "Por_Ganancia"
        Me.PorGananciaDataGridViewTextBoxColumn.Name = "PorGananciaDataGridViewTextBoxColumn"
        '
        'PorGananciaNDataGridViewTextBoxColumn
        '
        Me.PorGananciaNDataGridViewTextBoxColumn.DataPropertyName = "Por_Ganancia_N"
        Me.PorGananciaNDataGridViewTextBoxColumn.HeaderText = "Por_Ganancia_N"
        Me.PorGananciaNDataGridViewTextBoxColumn.Name = "PorGananciaNDataGridViewTextBoxColumn"
        '
        'DboEmpleadoGananciasBindingSource
        '
        Me.DboEmpleadoGananciasBindingSource.DataMember = "dbo_Empleado_Ganancias"
        Me.DboEmpleadoGananciasBindingSource.DataSource = Me._DivalI_FDataSet4
        '
        '_DivalI_FDataSet4
        '
        Me._DivalI_FDataSet4.DataSetName = "_DivalI_FDataSet4"
        Me._DivalI_FDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dbo_Empleado_GananciasTableAdapter
        '
        Me.Dbo_Empleado_GananciasTableAdapter.ClearBeforeFill = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_de_Inventario_y_Facturación.My.Resources.Resources.Fondo4
        Me.ClientSize = New System.Drawing.Size(639, 449)
        Me.Controls.Add(Me.DataGridViewGanancia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewServicio)
        Me.Controls.Add(Me.DataGridViewProducto)
        Me.Controls.Add(Me.DataGridViewEmpleado)
        Me.Controls.Add(Me.DataGridViewArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.DataGridViewArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboMueblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEmpleadoR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewGanancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboEmpleadoGananciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DivalI_FDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewArticulo As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewProducto As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewServicio As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonArticulo As System.Windows.Forms.Button
    Friend WithEvents ButtonEmpleado As System.Windows.Forms.Button
    Friend WithEvents ButtonProducto As System.Windows.Forms.Button
    Friend WithEvents ButtonServicio As System.Windows.Forms.Button
    Friend WithEvents DataSetArticulo As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet
    Friend WithEvents DboMueblesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dbo_MueblesTableAdapter As Sistema_de_Inventario_y_Facturación._DivalI_FDataSetTableAdapters.dbo_MueblesTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSetEmpleadoR As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet1
    Friend WithEvents DboEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dbo_EmpleadoTableAdapter As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet1TableAdapters.dbo_EmpleadoTableAdapter
    Friend WithEvents CedulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIngDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSetProducto As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet2
    Friend WithEvents DboProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dbo_ProductoTableAdapter As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet2TableAdapters.dbo_ProductoTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSetServicio As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet3
    Friend WithEvents DboServicioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dbo_ServicioTableAdapter As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet3TableAdapters.dbo_ServicioTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewGanancia As System.Windows.Forms.DataGridView
    Friend WithEvents _DivalI_FDataSet4 As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet4
    Friend WithEvents DboEmpleadoGananciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dbo_Empleado_GananciasTableAdapter As Sistema_de_Inventario_y_Facturación._DivalI_FDataSet4TableAdapters.dbo_Empleado_GananciasTableAdapter
    Friend WithEvents CedulaEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorGananciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorGananciaNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
