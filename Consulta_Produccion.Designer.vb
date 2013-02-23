<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Produccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Produccion))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxEmpleado = New System.Windows.Forms.ComboBox
        Me.DataSetEmpleadoCO = New Sistema_de_Inventario_y_Facturación.DataSetEmpleadoCO
        Me.ComboBoxServicio = New System.Windows.Forms.ComboBox
        Me.DataSetServicioCO = New Sistema_de_Inventario_y_Facturación.DataSetServicioCO
        Me.ButtonNueva_C = New System.Windows.Forms.Button
        Me.ButtonConsulta = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxTGE = New System.Windows.Forms.TextBox
        Me.TextBoxTGN = New System.Windows.Forms.TextBox
        Me.TextBoxTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBoxTipo_C = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBoxCE = New System.Windows.Forms.TextBox
        Me.TextBoxCS = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapterRegistroProduccion = New System.Data.SqlClient.SqlDataAdapter
        Me.DataSetRegistroProduccion = New Sistema_de_Inventario_y_Facturación.DataSetRegistroProduccion
        Me.DataGridViewConsulta = New System.Windows.Forms.DataGridView
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ppd = New System.Windows.Forms.PrintPreviewDialog
        Me.pdt = New System.Drawing.Printing.PrintDocument
        Me.pdg = New System.Windows.Forms.PrintDialog
        Me.psdPagina = New System.Windows.Forms.PageSetupDialog
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnvp = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.BtnCHoja = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboBoxTipo_Pago = New System.Windows.Forms.ComboBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterRegistroProduccion = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSetRegistroProduccionCO = New Sistema_de_Inventario_y_Facturación.DataSetRegistroProduccionCO
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterEmpleadoCO = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection3 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapterServicioCO = New System.Data.OleDb.OleDbDataAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ButtonEliminarRegistro = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ButtonExportar = New System.Windows.Forms.Button
        Me.ButtonRegresar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataSetEmpleadoCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetServicioCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSetRegistroProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataSetRegistroProduccionCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Enabled = False
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(18, 44)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDesde.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DateTimePickerDesde, "Seleccione la Fecha.")
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Enabled = False
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(241, 44)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerHasta.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DateTimePickerHasta, "Seleccione la Fecha")
        '
        'ComboBoxEmpleado
        '
        Me.ComboBoxEmpleado.DataSource = Me.DataSetEmpleadoCO
        Me.ComboBoxEmpleado.DisplayMember = "dbo_Empleado.Nombre"
        Me.ComboBoxEmpleado.Enabled = False
        Me.ComboBoxEmpleado.FormattingEnabled = True
        Me.ComboBoxEmpleado.Location = New System.Drawing.Point(17, 101)
        Me.ComboBoxEmpleado.Name = "ComboBoxEmpleado"
        Me.ComboBoxEmpleado.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxEmpleado.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ComboBoxEmpleado, "Seleccione un empleado.")
        Me.ComboBoxEmpleado.ValueMember = "dbo_Empleado.Cedula"
        '
        'DataSetEmpleadoCO
        '
        Me.DataSetEmpleadoCO.DataSetName = "DataSetEmpleadoCO"
        Me.DataSetEmpleadoCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxServicio
        '
        Me.ComboBoxServicio.DataSource = Me.DataSetServicioCO
        Me.ComboBoxServicio.DisplayMember = "dbo_Servicio.Descripcion"
        Me.ComboBoxServicio.Enabled = False
        Me.ComboBoxServicio.FormattingEnabled = True
        Me.ComboBoxServicio.Location = New System.Drawing.Point(241, 101)
        Me.ComboBoxServicio.Name = "ComboBoxServicio"
        Me.ComboBoxServicio.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxServicio.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ComboBoxServicio, "Selecione un servicio.")
        Me.ComboBoxServicio.ValueMember = "dbo_Servicio.Codigo"
        '
        'DataSetServicioCO
        '
        Me.DataSetServicioCO.DataSetName = "DataSetServicioCO"
        Me.DataSetServicioCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonNueva_C
        '
        Me.ButtonNueva_C.Enabled = False
        Me.ButtonNueva_C.Location = New System.Drawing.Point(99, 20)
        Me.ButtonNueva_C.Name = "ButtonNueva_C"
        Me.ButtonNueva_C.Size = New System.Drawing.Size(75, 34)
        Me.ButtonNueva_C.TabIndex = 5
        Me.ButtonNueva_C.Text = " Nueva Consulta"
        Me.ToolTip1.SetToolTip(Me.ButtonNueva_C, "Haga clic para realizar una nuena consulta.")
        Me.ButtonNueva_C.UseVisualStyleBackColor = True
        '
        'ButtonConsulta
        '
        Me.ButtonConsulta.Location = New System.Drawing.Point(9, 20)
        Me.ButtonConsulta.Name = "ButtonConsulta"
        Me.ButtonConsulta.Size = New System.Drawing.Size(75, 34)
        Me.ButtonConsulta.TabIndex = 6
        Me.ButtonConsulta.Text = "Consulta"
        Me.ToolTip1.SetToolTip(Me.ButtonConsulta, "Haga clic para realizar la consulta.")
        Me.ButtonConsulta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(17, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(238, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Servicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha (Desde)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(241, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha (Hasta)"
        '
        'TextBoxTGE
        '
        Me.TextBoxTGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTGE.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTGE.Location = New System.Drawing.Point(151, 12)
        Me.TextBoxTGE.Name = "TextBoxTGE"
        Me.TextBoxTGE.ReadOnly = True
        Me.TextBoxTGE.Size = New System.Drawing.Size(169, 29)
        Me.TextBoxTGE.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.TextBoxTGE, "Total de la ganancia del empleado(s).")
        '
        'TextBoxTGN
        '
        Me.TextBoxTGN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTGN.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTGN.Location = New System.Drawing.Point(151, 46)
        Me.TextBoxTGN.Name = "TextBoxTGN"
        Me.TextBoxTGN.ReadOnly = True
        Me.TextBoxTGN.Size = New System.Drawing.Size(169, 29)
        Me.TextBoxTGN.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.TextBoxTGN, "Total de ganacia de LIDYA'S Studios")
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTotal.Location = New System.Drawing.Point(151, 80)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(169, 29)
        Me.TextBoxTotal.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TextBoxTotal, "Total General de la consulta.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(9, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total Ganancia Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(17, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Ganancia Negocio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(98, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total"
        '
        'ComboBoxTipo_C
        '
        Me.ComboBoxTipo_C.FormattingEnabled = True
        Me.ComboBoxTipo_C.Items.AddRange(New Object() {"Por Dia", "Por Empleado", "Por Empleado y Dia", "Por Empleado y Servicio", "Por Empleado y Semana", "Por Semana", "Por Servicio", "Por Servicio y Dia", "Por Servicio y Semana", ""})
        Me.ComboBoxTipo_C.Location = New System.Drawing.Point(24, 33)
        Me.ComboBoxTipo_C.Name = "ComboBoxTipo_C"
        Me.ComboBoxTipo_C.Size = New System.Drawing.Size(173, 21)
        Me.ComboBoxTipo_C.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.ComboBoxTipo_C, "Seleccione un tipo de consulta.")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerDesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerHasta)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEmpleado)
        Me.GroupBox1.Controls.Add(Me.ComboBoxServicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(566, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 147)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox2.Controls.Add(Me.TextBoxTGE)
        Me.GroupBox2.Controls.Add(Me.TextBoxTGN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(622, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 115)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ComboBoxTipo_C)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(29, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 78)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Consulta"
        '
        'TextBoxCE
        '
        Me.TextBoxCE.Enabled = False
        Me.TextBoxCE.Location = New System.Drawing.Point(460, 3)
        Me.TextBoxCE.Name = "TextBoxCE"
        Me.TextBoxCE.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCE.TabIndex = 22
        Me.TextBoxCE.Visible = False
        '
        'TextBoxCS
        '
        Me.TextBoxCS.Enabled = False
        Me.TextBoxCS.Location = New System.Drawing.Point(460, 30)
        Me.TextBoxCS.Name = "TextBoxCS"
        Me.TextBoxCS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCS.TabIndex = 23
        Me.TextBoxCS.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Registro_Produccion.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Registro_Produccion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=Base_Dival_I&F;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula_E", System.Data.SqlDbType.[Char], 0, "Cedula_E"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Codigo_S", System.Data.SqlDbType.VarChar, 0, "Codigo_S"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.VarChar, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TGE", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TGN", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula_E", System.Data.SqlDbType.[Char], 0, "Cedula_E"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Codigo_S", System.Data.SqlDbType.VarChar, 0, "Codigo_S"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.VarChar, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TGE", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TGN", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_E", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Codigo_S", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Codigo_S", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Total", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TGE", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TGN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TGN", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula_E", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Codigo_S", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Codigo_S", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Total", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TGE", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_TGN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_TGN", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapterRegistroProduccion
        '
        Me.SqlDataAdapterRegistroProduccion.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapterRegistroProduccion.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapterRegistroProduccion.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapterRegistroProduccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Registro_Produccion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Cedula_E", "Cedula_E"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Codigo_S", "Codigo_S"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("TGE", "TGE"), New System.Data.Common.DataColumnMapping("TGN", "TGN")})})
        Me.SqlDataAdapterRegistroProduccion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSetRegistroProduccion
        '
        Me.DataSetRegistroProduccion.DataSetName = "DataSetRegistroProduccion"
        Me.DataSetRegistroProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewConsulta
        '
        Me.DataGridViewConsulta.AllowUserToAddRows = False
        Me.DataGridViewConsulta.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewConsulta.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewConsulta.Location = New System.Drawing.Point(29, 165)
        Me.DataGridViewConsulta.Name = "DataGridViewConsulta"
        Me.DataGridViewConsulta.Size = New System.Drawing.Size(996, 259)
        Me.DataGridViewConsulta.TabIndex = 25
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        '
        'ppd
        '
        Me.ppd.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd.Enabled = True
        Me.ppd.Icon = CType(resources.GetObject("ppd.Icon"), System.Drawing.Icon)
        Me.ppd.Name = "ppd"
        Me.ppd.Visible = False
        '
        'pdt
        '
        '
        'pdg
        '
        Me.pdg.UseEXDialog = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.btnvp)
        Me.GroupBox5.Controls.Add(Me.btnImprimir)
        Me.GroupBox5.Controls.Add(Me.BtnCHoja)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(537, 452)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(75, 68)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Impresion"
        Me.GroupBox5.Visible = False
        '
        'btnvp
        '
        Me.btnvp.Location = New System.Drawing.Point(183, 18)
        Me.btnvp.Name = "btnvp"
        Me.btnvp.Size = New System.Drawing.Size(75, 35)
        Me.btnvp.TabIndex = 5
        Me.btnvp.Text = "Vista Previa"
        Me.btnvp.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(21, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 35)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'BtnCHoja
        '
        Me.BtnCHoja.Location = New System.Drawing.Point(102, 16)
        Me.BtnCHoja.Name = "BtnCHoja"
        Me.BtnCHoja.Size = New System.Drawing.Size(75, 35)
        Me.BtnCHoja.TabIndex = 4
        Me.BtnCHoja.Text = "Conf.. Hoja"
        Me.BtnCHoja.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(24, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Consulta de Producción"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ComboBoxTipo_Pago)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(256, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 78)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Pago"
        '
        'ComboBoxTipo_Pago
        '
        Me.ComboBoxTipo_Pago.FormattingEnabled = True
        Me.ComboBoxTipo_Pago.Items.AddRange(New Object() {"Efectivo y Débito", "Solo Efectivo", "Solo Débito"})
        Me.ComboBoxTipo_Pago.Location = New System.Drawing.Point(24, 33)
        Me.ComboBoxTipo_Pago.Name = "ComboBoxTipo_Pago"
        Me.ComboBoxTipo_Pago.Size = New System.Drawing.Size(173, 21)
        Me.ComboBoxTipo_Pago.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.ComboBoxTipo_Pago, "Seleccione un tipo de pago para cosultar.")
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        dbo_Registro_Produccion.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dbo_Registro_Produccion"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `dbo_Registro_Produccion` (`Cedula_E`, `Fecha`, `Codigo_S`, `Cantidad" & _
            "`, `Total`, `TGE`, `TGN`, `Tipo_Pago`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.[Date], 0, "Fecha"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, "Cantidad"), New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, "Tipo_Pago")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, "Cedula_E"), New System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.[Date], 0, "Fecha"), New System.Data.OleDb.OleDbParameter("Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, "Codigo_S"), New System.Data.OleDb.OleDbParameter("Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, "Cantidad"), New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, "Tipo_Pago"), New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Cantidad", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Total", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Tipo_Pago", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Codigo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cedula_E", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula_E", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Codigo_S", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_S", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Cantidad", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cantidad", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Total", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGE", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TGN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TGN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TGN", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "TGN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Tipo_Pago", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Tipo_Pago", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapterRegistroProduccion
        '
        Me.OleDbDataAdapterRegistroProduccion.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapterRegistroProduccion.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapterRegistroProduccion.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapterRegistroProduccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Registro_Produccion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Cedula_E", "Cedula_E"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Codigo_S", "Codigo_S"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("TGE", "TGE"), New System.Data.Common.DataColumnMapping("TGN", "TGN"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago")})})
        Me.OleDbDataAdapterRegistroProduccion.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSetRegistroProduccionCO
        '
        Me.DataSetRegistroProduccionCO.DataSetName = "DataSetRegistroProduccionCO"
        Me.DataSetRegistroProduccionCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'OleDbDataAdapterEmpleadoCO
        '
        Me.OleDbDataAdapterEmpleadoCO.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapterEmpleadoCO.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapterEmpleadoCO.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapterEmpleadoCO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Apellidio", "Apellidio"), New System.Data.Common.DataColumnMapping("Fecha_Nac", "Fecha_Nac"), New System.Data.Common.DataColumnMapping("Fecha_Ing", "Fecha_Ing"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("Movil", "Movil"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion")})})
        Me.OleDbDataAdapterEmpleadoCO.UpdateCommand = Me.OleDbUpdateCommand2
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
        'OleDbDataAdapterServicioCO
        '
        Me.OleDbDataAdapterServicioCO.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapterServicioCO.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapterServicioCO.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapterServicioCO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_Servicio", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Precio", "Precio")})})
        Me.OleDbDataAdapterServicioCO.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 430)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(19, 13)
        Me.TextBox1.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Este es el número del codigo de la fila para eliminar el registro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nota: Selecci" & _
                "one haciendo clic la fila que desea eliminar de la base de datos")
        '
        'ButtonEliminarRegistro
        '
        Me.ButtonEliminarRegistro.Enabled = False
        Me.ButtonEliminarRegistro.Location = New System.Drawing.Point(188, 20)
        Me.ButtonEliminarRegistro.Name = "ButtonEliminarRegistro"
        Me.ButtonEliminarRegistro.Size = New System.Drawing.Size(75, 34)
        Me.ButtonEliminarRegistro.TabIndex = 31
        Me.ButtonEliminarRegistro.Text = "&Eliminar Registro"
        Me.ToolTip1.SetToolTip(Me.ButtonEliminarRegistro, "Haga clic para eliminar la fila seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nota: Al realizar esta acción no s" & _
                "e pueden recuperar los datos luego de haber borrado.")
        Me.ButtonEliminarRegistro.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(26, 427)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Codigo seleccionado:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.ButtonExportar)
        Me.GroupBox6.Controls.Add(Me.ButtonRegresar)
        Me.GroupBox6.Controls.Add(Me.ButtonConsulta)
        Me.GroupBox6.Controls.Add(Me.ButtonNueva_C)
        Me.GroupBox6.Controls.Add(Me.ButtonEliminarRegistro)
        Me.GroupBox6.Location = New System.Drawing.Point(47, 454)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(450, 66)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        '
        'ButtonExportar
        '
        Me.ButtonExportar.Enabled = False
        Me.ButtonExportar.Location = New System.Drawing.Point(273, 20)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(75, 34)
        Me.ButtonExportar.TabIndex = 34
        Me.ButtonExportar.Text = "&Generar reporte"
        Me.ToolTip1.SetToolTip(Me.ButtonExportar, "Haga clic para generar el reporte en Excel para imprimir.")
        Me.ButtonExportar.UseVisualStyleBackColor = True
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.Location = New System.Drawing.Point(359, 20)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(75, 34)
        Me.ButtonRegresar.TabIndex = 32
        Me.ButtonRegresar.Text = "&Regresar"
        Me.ToolTip1.SetToolTip(Me.ButtonRegresar, "Haga clic para regresar al menú principal.")
        Me.ButtonRegresar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Consulta_Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.Sistema_de_Inventario_y_Facturación.My.Resources.Resources.Fondo4
        Me.ClientSize = New System.Drawing.Size(1050, 557)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridViewConsulta)
        Me.Controls.Add(Me.TextBoxCS)
        Me.Controls.Add(Me.TextBoxCE)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Consulta_Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Produccion"
        CType(Me.DataSetEmpleadoCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetServicioCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataSetRegistroProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataSetRegistroProduccionCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonNueva_C As System.Windows.Forms.Button
    Friend WithEvents ButtonConsulta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTGE As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTGN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipo_C As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCE As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCS As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapterRegistroProduccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetRegistroProduccion As Sistema_de_Inventario_y_Facturación.DataSetRegistroProduccion
    Friend WithEvents DataGridViewConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ppd As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pdt As System.Drawing.Printing.PrintDocument
    Friend WithEvents pdg As System.Windows.Forms.PrintDialog
    Friend WithEvents psdPagina As System.Windows.Forms.PageSetupDialog
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnvp As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnCHoja As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxTipo_Pago As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterRegistroProduccion As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataSetEmpleadoCO As Sistema_de_Inventario_y_Facturación.DataSetEmpleadoCO
    Friend WithEvents DataSetServicioCO As Sistema_de_Inventario_y_Facturación.DataSetServicioCO
    Friend WithEvents DataSetRegistroProduccionCO As Sistema_de_Inventario_y_Facturación.DataSetRegistroProduccionCO
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterEmpleadoCO As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection3 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapterServicioCO As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEliminarRegistro As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonRegresar As System.Windows.Forms.Button
    Friend WithEvents ButtonExportar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
