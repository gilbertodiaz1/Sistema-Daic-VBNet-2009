<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_prodcuccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_prodcuccion))
        Me.TextBoxGanancia_N = New System.Windows.Forms.TextBox
        Me.TextBoxGanancia_E = New System.Windows.Forms.TextBox
        Me.TextBoxTotal = New System.Windows.Forms.TextBox
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox
        Me.TextBoxServicio = New System.Windows.Forms.TextBox
        Me.TextBoxEmpleado = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ColumnCedula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1CodigoS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnTGE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnTGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnT_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnEliminar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ComboBoxEmpleado = New System.Windows.Forms.ComboBox
        Me.DataSetEmpleado = New Sistema_de_Inventario_y_Facturación.DataSetEmpleado
        Me.ComboBoxServicio = New System.Windows.Forms.ComboBox
        Me.DataSetServicio5 = New Sistema_de_Inventario_y_Facturación.DataSetServicio5
        Me.ButtonAgregar = New System.Windows.Forms.Button
        Me.ButtonGuardar = New System.Windows.Forms.Button
        Me.ButtonSalir = New System.Windows.Forms.Button
        Me.ComboBoxTipo_Pago = New System.Windows.Forms.ComboBox
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterEmpleado = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterServicio = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection3 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterProduccion = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSetProduccion = New Sistema_de_Inventario_y_Facturación.DataSetProduccion
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection4 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterEmpleado_Ganancias = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSetEmpleado_Ganancias = New Sistema_de_Inventario_y_Facturación.DataSetEmpleado_Ganancias
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ButtonCancelar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetServicio5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEmpleado_Ganancias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxGanancia_N
        '
        Me.TextBoxGanancia_N.Location = New System.Drawing.Point(754, 398)
        Me.TextBoxGanancia_N.Name = "TextBoxGanancia_N"
        Me.TextBoxGanancia_N.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGanancia_N.TabIndex = 37
        Me.TextBoxGanancia_N.Visible = False
        '
        'TextBoxGanancia_E
        '
        Me.TextBoxGanancia_E.Location = New System.Drawing.Point(627, 398)
        Me.TextBoxGanancia_E.Name = "TextBoxGanancia_E"
        Me.TextBoxGanancia_E.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGanancia_E.TabIndex = 36
        Me.TextBoxGanancia_E.Visible = False
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(499, 398)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 35
        Me.TextBoxTotal.Visible = False
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(367, 398)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecio.TabIndex = 34
        Me.TextBoxPrecio.Visible = False
        '
        'TextBoxServicio
        '
        Me.TextBoxServicio.Location = New System.Drawing.Point(205, 398)
        Me.TextBoxServicio.Name = "TextBoxServicio"
        Me.TextBoxServicio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxServicio.TabIndex = 33
        Me.TextBoxServicio.Visible = False
        '
        'TextBoxEmpleado
        '
        Me.TextBoxEmpleado.Location = New System.Drawing.Point(67, 398)
        Me.TextBoxEmpleado.Name = "TextBoxEmpleado"
        Me.TextBoxEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmpleado.TabIndex = 32
        Me.TextBoxEmpleado.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(30, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 24)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Registro de Producción por Empleado"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(766, 29)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFecha.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.DateTimePickerFecha, "Seleccione la fecha del dia de la producción.")
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCedula, Me.ColumnFecha, Me.Column1CodigoS, Me.ColumnServicio, Me.ColumnPrecio, Me.ColumnCantidad, Me.ColumnTotal, Me.ColumnTGE, Me.ColumnTGN, Me.ColumnT_Pago, Me.ColumnEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(34, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 216)
        Me.DataGridView1.TabIndex = 29
        '
        'ColumnCedula
        '
        Me.ColumnCedula.HeaderText = "Cedula Empleado"
        Me.ColumnCedula.Name = "ColumnCedula"
        '
        'ColumnFecha
        '
        Me.ColumnFecha.HeaderText = "Fecha"
        Me.ColumnFecha.Name = "ColumnFecha"
        '
        'Column1CodigoS
        '
        Me.Column1CodigoS.HeaderText = "Codigo de Servicio"
        Me.Column1CodigoS.Name = "Column1CodigoS"
        '
        'ColumnServicio
        '
        Me.ColumnServicio.HeaderText = "Servicio"
        Me.ColumnServicio.Name = "ColumnServicio"
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.HeaderText = "Precio"
        Me.ColumnPrecio.Name = "ColumnPrecio"
        '
        'ColumnCantidad
        '
        Me.ColumnCantidad.HeaderText = "Cantidad"
        Me.ColumnCantidad.Name = "ColumnCantidad"
        '
        'ColumnTotal
        '
        Me.ColumnTotal.HeaderText = "Total "
        Me.ColumnTotal.Name = "ColumnTotal"
        '
        'ColumnTGE
        '
        Me.ColumnTGE.HeaderText = "TGE"
        Me.ColumnTGE.Name = "ColumnTGE"
        Me.ColumnTGE.Visible = False
        '
        'ColumnTGN
        '
        Me.ColumnTGN.HeaderText = "TGN"
        Me.ColumnTGN.Name = "ColumnTGN"
        Me.ColumnTGN.Visible = False
        '
        'ColumnT_Pago
        '
        Me.ColumnT_Pago.HeaderText = "Tipo de Pago"
        Me.ColumnT_Pago.Name = "ColumnT_Pago"
        Me.ColumnT_Pago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnT_Pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnEliminar
        '
        Me.ColumnEliminar.HeaderText = "Eliminar"
        Me.ColumnEliminar.Name = "ColumnEliminar"
        Me.ColumnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnEliminar.Text = "Eliminar"
        Me.ColumnEliminar.UseColumnTextForButtonValue = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Location = New System.Drawing.Point(279, 236)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(387, 43)
        Me.DataGridView2.TabIndex = 38
        '
        'ComboBoxEmpleado
        '
        Me.ComboBoxEmpleado.DataSource = Me.DataSetEmpleado
        Me.ComboBoxEmpleado.DisplayMember = "dbo_Empleado.Nombre"
        Me.ComboBoxEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEmpleado.FormattingEnabled = True
        Me.ComboBoxEmpleado.Location = New System.Drawing.Point(26, 43)
        Me.ComboBoxEmpleado.Name = "ComboBoxEmpleado"
        Me.ComboBoxEmpleado.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxEmpleado.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.ComboBoxEmpleado, "Seleccione un empleado.")
        Me.ComboBoxEmpleado.ValueMember = "dbo_Empleado.Cedula"
        '
        'DataSetEmpleado
        '
        Me.DataSetEmpleado.DataSetName = "DataSetEmpleado"
        Me.DataSetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxServicio
        '
        Me.ComboBoxServicio.DataSource = Me.DataSetServicio5
        Me.ComboBoxServicio.DisplayMember = "dbo_Servicio.Descripcion"
        Me.ComboBoxServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxServicio.FormattingEnabled = True
        Me.ComboBoxServicio.Location = New System.Drawing.Point(176, 41)
        Me.ComboBoxServicio.Name = "ComboBoxServicio"
        Me.ComboBoxServicio.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxServicio.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.ComboBoxServicio, "Seleccione un servicio.")
        Me.ComboBoxServicio.ValueMember = "dbo_Servicio.Codigo"
        '
        'DataSetServicio5
        '
        Me.DataSetServicio5.DataSetName = "DataSetServicio5"
        Me.DataSetServicio5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Enabled = False
        Me.ButtonAgregar.Location = New System.Drawing.Point(11, 33)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 42
        Me.ButtonAgregar.Text = "&Agregar"
        Me.ToolTip1.SetToolTip(Me.ButtonAgregar, "Haga clic o presione la tecla (F1) para agregar a la tabla.")
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(92, 33)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardar.TabIndex = 43
        Me.ButtonGuardar.Text = "&Guardar"
        Me.ToolTip1.SetToolTip(Me.ButtonGuardar, "Haga clic o presione la tecla (F2) para guardar los datos.")
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(254, 33)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 44
        Me.ButtonSalir.Text = "&Regresar"
        Me.ToolTip1.SetToolTip(Me.ButtonSalir, "Haga clic o presione la tecla (Esc) para regresar al menú principal.")
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ComboBoxTipo_Pago
        '
        Me.ComboBoxTipo_Pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipo_Pago.FormattingEnabled = True
        Me.ComboBoxTipo_Pago.Items.AddRange(New Object() {"", "Efectivo", "Débito"})
        Me.ComboBoxTipo_Pago.Location = New System.Drawing.Point(325, 41)
        Me.ComboBoxTipo_Pago.Name = "ComboBoxTipo_Pago"
        Me.ComboBoxTipo_Pago.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxTipo_Pago.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.ComboBoxTipo_Pago, "Seleccione un tipo de pago.")
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidad.Location = New System.Drawing.Point(476, 41)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCantidad.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.TextBoxCantidad, "Ingrese la cantidad de la producción y luego presione Enter.")
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        dbo_Empleado.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Empleado"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb;Pers" & _
            "ist Security Info=True"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `dbo_Empleado` (`Cedula`, `Nombre`, `Apellidio`, `Fecha_Nac`, `Fecha_" & _
            "Ing`, `Telefono`, `Movil`, `Direccion`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula"), New System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"), New System.Data.OleDb.OleDbParameter("Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, "Apellidio"), New System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Nac"), New System.Data.OleDb.OleDbParameter("Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Ing"), New System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"), New System.Data.OleDb.OleDbParameter("Movil", System.Data.OleDb.OleDbType.VarWChar, 0, "Movil"), New System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula"), New System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"), New System.Data.OleDb.OleDbParameter("Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, "Apellidio"), New System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Nac"), New System.Data.OleDb.OleDbParameter("Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Ing"), New System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"), New System.Data.OleDb.OleDbParameter("Movil", System.Data.OleDb.OleDbType.VarWChar, 0, "Movil"), New System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"), New System.Data.OleDb.OleDbParameter("Original_Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Apellidio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Ing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Movil", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Movil", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Apellidio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Ing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Movil", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Movil", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterEmpleado
        '
        Me.OleDbDataAdapterEmpleado.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapterEmpleado.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapterEmpleado.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapterEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Apellidio", "Apellidio"), New System.Data.Common.DataColumnMapping("Fecha_Nac", "Fecha_Nac"), New System.Data.Common.DataColumnMapping("Fecha_Ing", "Fecha_Ing"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("Movil", "Movil"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion")})})
        Me.OleDbDataAdapterEmpleado.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT        dbo_Servicio.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Servicio"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb;Pers" & _
            "ist Security Info=True"
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO `dbo_Servicio` (`Descripcion`, `Precio`) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion"), New System.Data.OleDb.OleDbParameter("Precio", System.Data.OleDb.OleDbType.VarWChar, 0, "Precio")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE `dbo_Servicio` SET `Descripcion` = ?, `Precio` = ? WHERE ((`Codigo` = ?) A" & _
            "ND ((? = 1 AND `Descripcion` IS NULL) OR (`Descripcion` = ?)) AND ((? = 1 AND `P" & _
            "recio` IS NULL) OR (`Precio` = ?)))"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion"), New System.Data.OleDb.OleDbParameter("Precio", System.Data.OleDb.OleDbType.VarWChar, 0, "Precio"), New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Precio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Precio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM `dbo_Servicio` WHERE ((`Codigo` = ?) AND ((? = 1 AND `Descripcion` IS" & _
            " NULL) OR (`Descripcion` = ?)) AND ((? = 1 AND `Precio` IS NULL) OR (`Precio` = " & _
            "?)))"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Precio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Precio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterServicio
        '
        Me.OleDbDataAdapterServicio.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapterServicio.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapterServicio.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapterServicio.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Servicio", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Precio", "Precio")})})
        Me.OleDbDataAdapterServicio.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT        dbo_Registro_Produccion.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Registro_Produccion"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection3
        '
        'OleDbConnection3
        '
        Me.OleDbConnection3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb;Pers" & _
            "ist Security Info=True"
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO `dbo_Registro_Produccion` (`Cedula_E`, `Fecha`, `Codigo_S`, `Cantidad" & _
            "`, `Total`, `TGE`, `TGN`, `Tipo_Pago`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection3
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.[Date], 0, "Fecha"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, "Cantidad"), New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, "Tipo_Pago")})
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = resources.GetString("OleDbUpdateCommand3.CommandText")
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection3
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.[Date], 0, "Fecha"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, "Cantidad"), New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, "Tipo_Pago"), New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Cantidad", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Total", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Tipo_Pago", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = resources.GetString("OleDbDeleteCommand3.CommandText")
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection3
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Cantidad", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Total", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Tipo_Pago", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterProduccion
        '
        Me.OleDbDataAdapterProduccion.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapterProduccion.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapterProduccion.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapterProduccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Registro_Produccion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Cedula_E", "Cedula_E"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Codigo_S", "Codigo_S"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("TGE", "TGE"), New System.Data.Common.DataColumnMapping("TGN", "TGN"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago")})})
        Me.OleDbDataAdapterProduccion.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'DataSetProduccion
        '
        Me.DataSetProduccion.DataSetName = "DataSetProduccion"
        Me.DataSetProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT        Cedula_E, Codigo_S, Por_Ganancia, Por_Ganancia_N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            d" & _
            "bo_Empleado_Ganancias"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection4
        '
        'OleDbConnection4
        '
        Me.OleDbConnection4.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb;Pers" & _
            "ist Security Info=True"
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO `dbo_Empleado_Ganancias` (`Cedula_E`, `Codigo_S`, `Por_Ganancia`, `Po" & _
            "r_Ganancia_N`) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection4
        Me.OleDbInsertCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia"), New System.Data.OleDb.OleDbParameter("Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia_N")})
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = resources.GetString("OleDbUpdateCommand4.CommandText")
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection4
        Me.OleDbUpdateCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia"), New System.Data.OleDb.OleDbParameter("Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia_N"), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = resources.GetString("OleDbDeleteCommand4.CommandText")
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection4
        Me.OleDbDeleteCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterEmpleado_Ganancias
        '
        Me.OleDbDataAdapterEmpleado_Ganancias.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapterEmpleado_Ganancias.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDbDataAdapterEmpleado_Ganancias.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapterEmpleado_Ganancias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Empleado_Ganancias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula_E", "Cedula_E"), New System.Data.Common.DataColumnMapping("Codigo_S", "Codigo_S"), New System.Data.Common.DataColumnMapping("Por_Ganancia", "Por_Ganancia"), New System.Data.Common.DataColumnMapping("Por_Ganancia_N", "Por_Ganancia_N")})})
        Me.OleDbDataAdapterEmpleado_Ganancias.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'DataSetEmpleado_Ganancias
        '
        Me.DataSetEmpleado_Ganancias.DataSetName = "DataSetEmpleado_Ganancias"
        Me.DataSetEmpleado_Ganancias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(322, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Tipo de pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(173, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(473, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBoxEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxServicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipo_Pago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(29, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 83)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox2.Controls.Add(Me.ButtonSalir)
        Me.GroupBox2.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox2.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox2.Location = New System.Drawing.Point(640, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 83)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(173, 33)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 45
        Me.ButtonCancelar.Text = "&Cancelar"
        Me.ToolTip1.SetToolTip(Me.ButtonCancelar, "Haga clic o presione la tecla (F3) para cancelar la cción actual.")
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(763, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Fecha:"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Registro_prodcuccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_de_Inventario_y_Facturación.My.Resources.Resources.Fondo4
        Me.ClientSize = New System.Drawing.Size(1003, 414)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxGanancia_N)
        Me.Controls.Add(Me.TextBoxGanancia_E)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxServicio)
        Me.Controls.Add(Me.TextBoxEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_prodcuccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ca"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetServicio5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEmpleado_Ganancias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxGanancia_N As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGanancia_E As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxServicio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1CodigoS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTGE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnT_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTipo_Pago As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterEmpleado As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetEmpleado As Sistema_de_Inventario_y_Facturación.DataSetEmpleado
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterServicio As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetServicio As Sistema_de_Inventario_y_Facturación.DataSetServicio5
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection3 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterProduccion As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetProduccion As Sistema_de_Inventario_y_Facturación.DataSetProduccion
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection4 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterEmpleado_Ganancias As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetEmpleado_Ganancias As Sistema_de_Inventario_y_Facturación.DataSetEmpleado_Ganancias
    Friend WithEvents DataSetServicio5 As Sistema_de_Inventario_y_Facturación.DataSetServicio5
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
