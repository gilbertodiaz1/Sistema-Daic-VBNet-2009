<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado_Ganancias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado_Ganancias))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxServicio = New System.Windows.Forms.ComboBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxGanancias_E = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEmpleado = New System.Windows.Forms.ComboBox()
        Me.DataGridViewGE = New System.Windows.Forms.DataGridView()
        Me.ColumnCedulaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCodigoS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxServicio = New System.Windows.Forms.TextBox()
        Me.TextBoxGanancias_N = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewCGE = New System.Windows.Forms.DataGridView()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ComboBoxEmpleadoo = New System.Windows.Forms.ComboBox()
        Me.DataSetEmpleado = New Sistema_de_Inventario_y_Facturación.DataSetEmpleadoo()
        Me.ComboBoxServicioo = New System.Windows.Forms.ComboBox()
        Me.DataSetServicio = New Sistema_de_Inventario_y_Facturación.DataSetServicioo()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapterGanancias_E = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSetGanancias_E = New Sistema_de_Inventario_y_Facturación.DataSetGanancias_E()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapterEmpleadoo = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection3 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapterServicio = New System.Data.OleDb.OleDbDataAdapter()
        Me.TextBoxEmpleadoo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridViewGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetGanancias_E, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(22, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(359, 24)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Registro de Ganancias por Empleado"
        '
        'ComboBoxServicio
        '
        Me.ComboBoxServicio.DisplayMember = "Servicio.Codigo"
        Me.ComboBoxServicio.FormattingEnabled = True
        Me.ComboBoxServicio.Location = New System.Drawing.Point(205, 90)
        Me.ComboBoxServicio.Name = "ComboBoxServicio"
        Me.ComboBoxServicio.Size = New System.Drawing.Size(159, 21)
        Me.ComboBoxServicio.TabIndex = 7
        Me.ComboBoxServicio.ValueMember = "Servicio.Codigo"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Enabled = False
        Me.ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAgregar.Location = New System.Drawing.Point(114, 97)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(90, 32)
        Me.ButtonAgregar.TabIndex = 4
        Me.ButtonAgregar.Text = "&Agregar"
        Me.ToolTip1.SetToolTip(Me.ButtonAgregar, "Haga clic para agregar el porcentaje de ganancia al empleado seleccionado.")
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(15, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Empleado"
        '
        'TextBoxGanancias_E
        '
        Me.TextBoxGanancias_E.Enabled = False
        Me.TextBoxGanancias_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGanancias_E.Location = New System.Drawing.Point(17, 54)
        Me.TextBoxGanancias_E.Name = "TextBoxGanancias_E"
        Me.TextBoxGanancias_E.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxGanancias_E.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TextBoxGanancias_E, "Ingrese el porcentaje de ganancia del empleado.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(175, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(29, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado"
        '
        'ComboBoxEmpleado
        '
        Me.ComboBoxEmpleado.DisplayMember = "Empleado.Cedula"
        Me.ComboBoxEmpleado.FormattingEnabled = True
        Me.ComboBoxEmpleado.Location = New System.Drawing.Point(32, 89)
        Me.ComboBoxEmpleado.Name = "ComboBoxEmpleado"
        Me.ComboBoxEmpleado.Size = New System.Drawing.Size(158, 21)
        Me.ComboBoxEmpleado.TabIndex = 0
        Me.ComboBoxEmpleado.ValueMember = "Empleado.Cedula"
        '
        'DataGridViewGE
        '
        Me.DataGridViewGE.AllowUserToAddRows = False
        Me.DataGridViewGE.AllowUserToDeleteRows = False
        Me.DataGridViewGE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCedulaE, Me.ColumnCodigoS, Me.ColumnServicio, Me.ColumnGE, Me.ColumnGN, Me.Column1})
        Me.DataGridViewGE.Location = New System.Drawing.Point(335, 55)
        Me.DataGridViewGE.Name = "DataGridViewGE"
        Me.DataGridViewGE.Size = New System.Drawing.Size(645, 330)
        Me.DataGridViewGE.TabIndex = 28
        '
        'ColumnCedulaE
        '
        Me.ColumnCedulaE.HeaderText = "Cedula Empleado"
        Me.ColumnCedulaE.Name = "ColumnCedulaE"
        '
        'ColumnCodigoS
        '
        Me.ColumnCodigoS.HeaderText = "Codigo Servicio"
        Me.ColumnCodigoS.Name = "ColumnCodigoS"
        '
        'ColumnServicio
        '
        Me.ColumnServicio.HeaderText = "Servicio"
        Me.ColumnServicio.Name = "ColumnServicio"
        '
        'ColumnGE
        '
        Me.ColumnGE.HeaderText = "% Ganancia Empleado"
        Me.ColumnGE.Name = "ColumnGE"
        '
        'ColumnGN
        '
        Me.ColumnGN.HeaderText = "% Ganancia Negocio"
        Me.ColumnGN.Name = "ColumnGN"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Eliminar"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "Eliminar"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "&Regresar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Haga clic o Presione la tecla (F6) para regresar el menú principal.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Enabled = False
        Me.ButtonCancelar.Location = New System.Drawing.Point(119, 330)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(86, 31)
        Me.ButtonCancelar.TabIndex = 42
        Me.ButtonCancelar.Text = "&Cancelar"
        Me.ToolTip1.SetToolTip(Me.ButtonCancelar, "Haga clic o Presione la tecla (F5) para cancelar la acción actual.")
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Enabled = False
        Me.ButtonEliminar.Location = New System.Drawing.Point(29, 330)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(86, 31)
        Me.ButtonEliminar.TabIndex = 41
        Me.ButtonEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.ButtonEliminar, "Haga clic o Presione la tecla (F4) para eliminar el registro.")
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Enabled = False
        Me.ButtonModificar.Location = New System.Drawing.Point(211, 293)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(86, 31)
        Me.ButtonModificar.TabIndex = 40
        Me.ButtonModificar.Text = "&Modificar"
        Me.ToolTip1.SetToolTip(Me.ButtonModificar, "Haga clic o Presione la tecla (F3) para modificar la ganancia del empleado.")
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Enabled = False
        Me.ButtonGuardar.Location = New System.Drawing.Point(121, 293)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(86, 31)
        Me.ButtonGuardar.TabIndex = 39
        Me.ButtonGuardar.Text = "&Guardar"
        Me.ToolTip1.SetToolTip(Me.ButtonGuardar, "Haga clic o Presione la tecla (F2) para guadar los datos.")
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(30, 293)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(86, 31)
        Me.ButtonBuscar.TabIndex = 38
        Me.ButtonBuscar.Text = "&Buscar"
        Me.ToolTip1.SetToolTip(Me.ButtonBuscar, "Haga clic o Presione la tecla (F1) para buscar.")
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxServicio
        '
        Me.TextBoxServicio.Location = New System.Drawing.Point(156, 389)
        Me.TextBoxServicio.Name = "TextBoxServicio"
        Me.TextBoxServicio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxServicio.TabIndex = 45
        Me.TextBoxServicio.Visible = False
        '
        'TextBoxGanancias_N
        '
        Me.TextBoxGanancias_N.Enabled = False
        Me.TextBoxGanancias_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGanancias_N.Location = New System.Drawing.Point(265, 389)
        Me.TextBoxGanancias_N.Name = "TextBoxGanancias_N"
        Me.TextBoxGanancias_N.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxGanancias_N.TabIndex = 46
        Me.TextBoxGanancias_N.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(262, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Negocio"
        Me.Label4.Visible = False
        '
        'DataGridViewCGE
        '
        Me.DataGridViewCGE.AllowUserToAddRows = False
        Me.DataGridViewCGE.AllowUserToDeleteRows = False
        Me.DataGridViewCGE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCGE.Location = New System.Drawing.Point(354, 327)
        Me.DataGridViewCGE.Name = "DataGridViewCGE"
        Me.DataGridViewCGE.ReadOnly = True
        Me.DataGridViewCGE.Size = New System.Drawing.Size(497, 55)
        Me.DataGridViewCGE.TabIndex = 48
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonNuevo.Location = New System.Drawing.Point(14, 97)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(90, 32)
        Me.ButtonNuevo.TabIndex = 49
        Me.ButtonNuevo.Text = "&Nuevo"
        Me.ToolTip1.SetToolTip(Me.ButtonNuevo, "Haga clic para hacer un nuevo registro de ganancia.")
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'ComboBoxEmpleadoo
        '
        Me.ComboBoxEmpleadoo.DataSource = Me.DataSetEmpleado
        Me.ComboBoxEmpleadoo.DisplayMember = "dbo_Empleado.Nombre"
        Me.ComboBoxEmpleadoo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEmpleadoo.FormattingEnabled = True
        Me.ComboBoxEmpleadoo.Location = New System.Drawing.Point(26, 93)
        Me.ComboBoxEmpleadoo.Name = "ComboBoxEmpleadoo"
        Me.ComboBoxEmpleadoo.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxEmpleadoo.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.ComboBoxEmpleadoo, "Seleccione el empleado.")
        Me.ComboBoxEmpleadoo.ValueMember = "dbo_Empleado.Cedula"
        '
        'DataSetEmpleado
        '
        Me.DataSetEmpleado.DataSetName = "DataSetEmpleadoo"
        Me.DataSetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxServicioo
        '
        Me.ComboBoxServicioo.DataSource = Me.DataSetServicio
        Me.ComboBoxServicioo.DisplayMember = "dbo_Servicio.Descripcion"
        Me.ComboBoxServicioo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxServicioo.FormattingEnabled = True
        Me.ComboBoxServicioo.Location = New System.Drawing.Point(178, 93)
        Me.ComboBoxServicioo.Name = "ComboBoxServicioo"
        Me.ComboBoxServicioo.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxServicioo.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.ComboBoxServicioo, "Seleccione un servicio.")
        Me.ComboBoxServicioo.ValueMember = "dbo_Servicio.Codigo"
        '
        'DataSetServicio
        '
        Me.DataSetServicio.DataSetName = "DataSetServicioo"
        Me.DataSetServicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        dbo_Empleado_Ganancias.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Empleado_Ganancias"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `dbo_Empleado_Ganancias` (`Cedula_E`, `Codigo_S`, `Por_Ganancia`, `Po" & _
            "r_Ganancia_N`) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia"), New System.Data.OleDb.OleDbParameter("Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia_N")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia"), New System.Data.OleDb.OleDbParameter("Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, "Por_Ganancia_N"), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Por_Ganancia_N", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Por_Ganancia_N", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterGanancias_E
        '
        Me.OleDbDataAdapterGanancias_E.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapterGanancias_E.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapterGanancias_E.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapterGanancias_E.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Empleado_Ganancias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula_E", "Cedula_E"), New System.Data.Common.DataColumnMapping("Codigo_S", "Codigo_S"), New System.Data.Common.DataColumnMapping("Por_Ganancia", "Por_Ganancia"), New System.Data.Common.DataColumnMapping("Por_Ganancia_N", "Por_Ganancia_N")})})
        Me.OleDbDataAdapterGanancias_E.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSetGanancias_E
        '
        Me.DataSetGanancias_E.DataSetName = "DataSetGanancias_E"
        Me.DataSetGanancias_E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT        dbo_Empleado.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Empleado"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb"
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO `dbo_Empleado` (`Cedula`, `Nombre`, `Apellidio`, `Fecha_Nac`, `Fecha_" & _
            "Ing`, `Telefono`, `Movil`, `Direccion`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula"), New System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"), New System.Data.OleDb.OleDbParameter("Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, "Apellidio"), New System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Nac"), New System.Data.OleDb.OleDbParameter("Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Ing"), New System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"), New System.Data.OleDb.OleDbParameter("Movil", System.Data.OleDb.OleDbType.VarWChar, 0, "Movil"), New System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula"), New System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"), New System.Data.OleDb.OleDbParameter("Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, "Apellidio"), New System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Nac"), New System.Data.OleDb.OleDbParameter("Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, "Fecha_Ing"), New System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"), New System.Data.OleDb.OleDbParameter("Movil", System.Data.OleDb.OleDbType.VarWChar, 0, "Movil"), New System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"), New System.Data.OleDb.OleDbParameter("Original_Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Apellidio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Ing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Movil", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Movil", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Apellidio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Apellidio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apellidio", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nac", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fecha_Ing", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha_Ing", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ing", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Movil", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Movil", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movil", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterEmpleadoo
        '
        Me.OleDbDataAdapterEmpleadoo.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapterEmpleadoo.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapterEmpleadoo.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapterEmpleadoo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Apellidio", "Apellidio"), New System.Data.Common.DataColumnMapping("Fecha_Nac", "Fecha_Nac"), New System.Data.Common.DataColumnMapping("Fecha_Ing", "Fecha_Ing"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("Movil", "Movil"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion")})})
        Me.OleDbDataAdapterEmpleadoo.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT        dbo_Servicio.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Servicio"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection3
        '
        'OleDbConnection3
        '
        Me.OleDbConnection3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb"
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO `dbo_Servicio` (`Descripcion`, `Precio`) VALUES (?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection3
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion"), New System.Data.OleDb.OleDbParameter("Precio", System.Data.OleDb.OleDbType.VarWChar, 0, "Precio")})
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE `dbo_Servicio` SET `Descripcion` = ?, `Precio` = ? WHERE ((`Codigo` = ?) A" & _
            "ND ((? = 1 AND `Descripcion` IS NULL) OR (`Descripcion` = ?)) AND ((? = 1 AND `P" & _
            "recio` IS NULL) OR (`Precio` = ?)))"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection3
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion"), New System.Data.OleDb.OleDbParameter("Precio", System.Data.OleDb.OleDbType.VarWChar, 0, "Precio"), New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Precio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Precio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM `dbo_Servicio` WHERE ((`Codigo` = ?) AND ((? = 1 AND `Descripcion` IS" & _
            " NULL) OR (`Descripcion` = ?)) AND ((? = 1 AND `Precio` IS NULL) OR (`Precio` = " & _
            "?)))"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection3
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Precio", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Precio", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterServicio
        '
        Me.OleDbDataAdapterServicio.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapterServicio.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapterServicio.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapterServicio.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Servicio", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Precio", "Precio")})})
        Me.OleDbDataAdapterServicio.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'TextBoxEmpleadoo
        '
        Me.TextBoxEmpleadoo.Location = New System.Drawing.Point(44, 389)
        Me.TextBoxEmpleadoo.Name = "TextBoxEmpleadoo"
        Me.TextBoxEmpleadoo.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxEmpleadoo.TabIndex = 52
        Me.TextBoxEmpleadoo.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBoxGanancias_E)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonNuevo)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(26, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 144)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "% Ganancia"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Empleado_Ganancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.Sistema_de_Inventario_y_Facturación.My.Resources.Resources.Fondo4
        Me.ClientSize = New System.Drawing.Size(1020, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxEmpleadoo)
        Me.Controls.Add(Me.TextBoxGanancias_N)
        Me.Controls.Add(Me.ComboBoxServicioo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxEmpleadoo)
        Me.Controls.Add(Me.DataGridViewGE)
        Me.Controls.Add(Me.DataGridViewCGE)
        Me.Controls.Add(Me.TextBoxServicio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Empleado_Ganancias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado Ganancias"
        CType(Me.DataGridViewGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewCGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetGanancias_E, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGanancias_E As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewGE As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents TextBoxServicio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGanancias_N As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCGE As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonNuevo As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEmpleadoo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxServicioo As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterGanancias_E As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetGanancias_E As Sistema_de_Inventario_y_Facturación.DataSetGanancias_E
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterEmpleadoo As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSetEmpleado As Sistema_de_Inventario_y_Facturación.DataSetEmpleadoo
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterServicio As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection3 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetServicio As Sistema_de_Inventario_y_Facturación.DataSetServicioo
    Friend WithEvents TextBoxEmpleadoo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnCedulaE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCodigoS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
