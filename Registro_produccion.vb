Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Registro_prodcuccion
    Public connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb")
    Dim posicion As Integer
    Dim numeroFilas As Integer
    Dim filaencontrada As DataRow
    Dim dt As DataRow

    Private Sub ComboBoxEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmpleado.SelectedIndexChanged
        Me.TextBoxEmpleado.Text = Me.ComboBoxEmpleado.SelectedValue
    End Sub

    Private Sub ComboBoxServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Registro_prodcuccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then
            If Me.ButtonAgregar.Enabled = True Then
                Call ButtonAgregar_Click(ButtonAgregar, e)
            Else
            End If
        End If
        If e.KeyCode = 113 Then
            If Me.ButtonGuardar.Enabled = True Then
                Call ButtonGuardar_Click(ButtonGuardar, e)
            Else
            End If
        End If
        If e.KeyCode = 114 Then
            If Me.ButtonCancelar.Enabled = True Then
                Call ButtonCancelar_Click(ButtonCancelar, e)
            Else
            End If
        End If
        If e.KeyCode = 27 Then
            If Me.ButtonSalir.Enabled = True Then
                Call ButtonSalir_Click(ButtonSalir, e)
            Else
            End If
        End If
    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetEmpleado().Clear()
        Me.OleDbDataAdapterEmpleado().Fill(Me.DataSetEmpleado)
        Me.DataSetServicio5().Clear()
        Me.OleDbDataAdapterServicio().Fill(Me.DataSetServicio5)
        Me.DataSetProduccion().Clear()
        Me.OleDbDataAdapterProduccion().Fill(Me.DataSetProduccion)
        numeroFilas = BindingContext(Me.DataSetServicio5, "dbo_Servicio").Count
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        Me.TextBoxCantidad.Text = ""
        Me.TextBoxEmpleado.Text = ""
        Me.TextBoxServicio.Text = ""
        Me.Text = "Registro de Producción                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
    End Sub
    Private Sub TextBoxServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxServicio.TextChanged
        Try
            filaencontrada = Me.DataSetServicio5.dbo_Servicio.Rows.Find(Me.TextBoxServicio.Text)
            If Not filaencontrada Is Nothing Then
                Me.TextBoxPrecio.Text = filaencontrada(2)
                ' posicion = posicionFila()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function posicionFila() As Integer
        Dim codigo As String
        Dim p As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetServicio, "dbo_Servicio").Position() = p
            codigo = Me.DataSetServicio5.dbo_Servicio(p).Codigo
            If codigo = Me.TextBoxServicio.Text Then
                Exit For
            End If
        Next
        Return p
    End Function

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        If Me.ComboBoxEmpleado.Text <> "" And Me.ComboBoxServicio.Text <> "" And Me.TextBoxCantidad.Text <> "" And Me.ComboBoxTipo_Pago.Text <> "" Then
            Me.DataGridView1.Rows.Add(Me.TextBoxEmpleado.Text, Me.DateTimePickerFecha.Value.ToShortDateString, Me.TextBoxServicio.Text, Me.ComboBoxServicio.Text, Me.TextBoxPrecio.Text, Me.TextBoxCantidad.Text, Me.TextBoxTotal.Text, Me.TextBoxGanancia_E.Text, Me.TextBoxGanancia_N.Text, Me.ComboBoxTipo_Pago.Text)
            Me.ComboBoxEmpleado.Text = ""
            Me.ComboBoxServicio.Text = ""
            Me.TextBoxCantidad.Text = ""
            Me.TextBoxEmpleado.Text = ""
            Me.TextBoxServicio.Text = ""
            Me.TextBoxPrecio.Text = ""
            Me.TextBoxTotal.Text = ""
            Me.TextBoxGanancia_E.Text = ""
            Me.TextBoxGanancia_N.Text = ""
            Me.ComboBoxTipo_Pago.Text = ""
            For i As Integer = 0 To Me.DataGridView2.RowCount - 1
                Me.DataGridView2.Rows.Remove(Me.DataGridView2.CurrentRow)
            Next
            Me.ButtonAgregar.Enabled = False
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Campos Vacios")
        End If
    End Sub

    Private Sub TextBoxCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            If Me.TextBoxCantidad.Text = "" Then

            Else
                If Me.ComboBoxEmpleado.Text <> "" And Me.ComboBoxServicio.Text <> "" And Me.ComboBoxTipo_Pago.Text <> "" Then
                    '  Try
                    Dim da As New OleDbDataAdapter("SELECT Cedula_E, Codigo_S, Por_Ganancia, Por_Ganancia_N FROM dbo_Empleado_Ganancias where Cedula_E = '" & Me.TextBoxEmpleado.Text & "' and Codigo_S =" & Me.TextBoxServicio.Text & "", Me.OleDbConnection4)
                    da.Fill(Me.DataSetEmpleado_Ganancias, "dbo_Empleado_Ganancias")
                    Me.DataGridView2.DataSource = DataSetEmpleado_Ganancias.Tables(0)
                    Me.ButtonAgregar.Enabled = True
                    If Me.DataGridView2.Rows.Count = 0 Then
                        MsgBox("No existe un porcentaje de ganancia establecido para el empleado en el servicio", MsgBoxStyle.Critical, "No existe")
                        Me.ButtonAgregar.Enabled = False
                        Dim resp As DialogResult
                        resp = MsgBox("¿Desea agregarle el porcentaje de ganancia al empleado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar Ganancia")
                        If resp = DialogResult.Yes Then
                            respuestaX = 1
                            ButtonCancelar_Click(ButtonCancelar, e)
                            Empleado_Ganancias.Show()
                            Me.Close()
                        End If
                    Else
                        For GE As Integer = 0 To DataGridView2.Rows.Count - 1
                            ganancia_E = Me.DataGridView2.Rows(GE).Cells(2).Value.ToString
                            ganancia_N = Me.DataGridView2.Rows(GE).Cells(3).Value.ToString
                            Me.TextBoxTotal.Text = (Me.TextBoxPrecio.Text * Me.TextBoxCantidad.Text)
                            Me.TextBoxGanancia_E.Text = (Replace(Me.TextBoxTotal.Text, ".", ",") * ganancia_E) / 100
                            Me.TextBoxGanancia_N.Text = (Replace(Me.TextBoxTotal.Text, ".", ",") * ganancia_N) / 100
                        Next
                        'Sumar()
                    End If
                    'Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    '  End Try
                    Me.ButtonAgregar.Focus()
                Else
                    MsgBox("Debe llenar los campos correspondientes", MsgBoxStyle.Exclamation, "Campos Vacios")
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCantidad.LostFocus
        Try
            Me.TextBoxTotal.Text = (Me.TextBoxPrecio.Text * Me.TextBoxCantidad.Text)
            Me.TextBoxGanancia_E.Text = (Replace(Me.TextBoxTotal.Text, ".", ",") * ganancia_E) / 100
            Me.TextBoxGanancia_N.Text = (Replace(Me.TextBoxTotal.Text, ".", ",") * ganancia_N) / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "ColumnEliminar" Then
            DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
    Public Function Abrir_Conexion() As Boolean
        Dim X As Boolean = False
        Try
            connection.Open()
            X = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return X
    End Function
    Public Function Cerrar_Conexion() As Boolean
        Dim X As Boolean = False
        Try
            connection.Close()
            X = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return X
    End Function
    Public Function Ejecutar_Transaccion(ByVal ListaSentencias As ArrayList) As Boolean
        Dim X As Boolean = False
        If Abrir_Conexion() Then
            Dim command As OleDbCommand = connection.CreateCommand()
            Dim transact As OleDbTransaction
            Dim StrSentencias As Object
            Dim Sentencias As String = ""
            transact = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = transact
            Try
                For Each StrSentencias In ListaSentencias
                    Sentencias = StrSentencias.ToString()
                    command.CommandText = Sentencias.ToString()
                    command.ExecuteNonQuery()
                Next
                transact.Commit()
                X = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Try
                    transact.Rollback()
                Catch ez As Exception
                    MessageBox.Show(ez.Message)
                End Try
            Finally
                Cerrar_Conexion()
            End Try
        End If
        Return X
    End Function

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Dim resp As DialogResult
        resp = MsgBox("¿Esta seguro de guardar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar")
        If resp = DialogResult.Yes Then
            If DataGridView1.Rows.Count > 0 Then
                Dim sqlstring As String = ""
                Dim listsqlstring As New ArrayList
                For GE As Integer = 0 To DataGridView1.Rows.Count - 1
                    sqlstring = "INSERT INTO dbo_Registro_Produccion (Cedula_E,Fecha,Codigo_S,Cantidad,Total,TGE,TGN,Tipo_Pago) VALUES ('" + DataGridView1.Rows(GE).Cells(0).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(1).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(2).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(5).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(6).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(7).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(8).Value.ToString() + "','" + DataGridView1.Rows(GE).Cells(9).Value.ToString() + "')"
                    'sqlstring = "INSERT INTO `dbo_Registro_Produccion` VALUES ('" + DataGridView1.Rows(GE).Cells(0).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(1).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(2).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(5).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(6).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(7).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(8).Value.ToString() + "', '" + DataGridView1.Rows(GE).Cells(9).Value.ToString() + "')"
                    listsqlstring.Add(sqlstring)
                Next
                If Ejecutar_Transaccion(listsqlstring) Then
                    MsgBox("Registro(s) guardado(s) satisfactoriamente", MsgBoxStyle.Information, "Guardar")
                    DataGridView1.Rows.Clear()
                    DataGridView2.DataSource = Nothing
                    Me.ComboBoxEmpleado.Text = ""
                    Me.ComboBoxServicio.Text = ""
                    Me.TextBoxCantidad.Text = ""
                    Me.TextBoxEmpleado.Text = ""
                    Me.TextBoxServicio.Text = ""
                    Me.TextBoxPrecio.Text = ""
                    Me.TextBoxTotal.Text = ""
                    Me.TextBoxGanancia_E.Text = ""
                    Me.TextBoxGanancia_N.Text = ""
                    Me.ComboBoxTipo_Pago.Text = ""
                    Me.GroupBox1.Enabled = False
                Else
                    MsgBox("Registro(s) no guardado(s)", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("No hay registros para guardar", MsgBoxStyle.Information, "Vacio")
            End If
        Else
            MsgBox("No se guardo el registro", MsgBoxStyle.Information, "No Guardado")
        End If

    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        Me.TextBoxEmpleado.Text = ""
        Me.TextBoxServicio.Text = ""
        Me.TextBoxPrecio.Text = ""
        Me.TextBoxGanancia_E.Text = ""
        Me.TextBoxGanancia_N.Text = ""
        Me.TextBoxTotal.Text = ""
        Me.TextBoxCantidad.Text = ""
        Me.ComboBoxTipo_Pago.Text = ""
        Me.DataGridView1.Rows.Clear()
        Me.Close()
    End Sub


    Private Sub ComboBoxServicio_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxServicio.SelectedIndexChanged
        Me.TextBoxServicio.Text = Me.ComboBoxServicio.SelectedValue
    End Sub

    Private Sub TextBoxTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTotal.TextChanged
        Me.TextBoxTotal.Text = Replace(TextBoxTotal.Text, ",", ".")
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim total As Double
    '    Dim itotal As Integer = Me.DataGridView1.Rows.Count
    '    For i = 0 To itotal - 1
    '        total = total + Replace(Me.DataGridView1(6, i).Value, ".", ",")
    '    Next
    '    Label4.Text = total
    'End Sub

    Private Sub TextBoxGanancia_E_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGanancia_E.TextChanged
        Me.TextBoxGanancia_E.Text = Replace(TextBoxGanancia_E.Text, ",", ".")
    End Sub

    Private Sub TextBoxGanancia_N_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGanancia_N.TextChanged
        Me.TextBoxGanancia_N.Text = Replace(TextBoxGanancia_N.Text, ",", ".")
    End Sub

    Private Sub DateTimePickerFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerFecha.ValueChanged
        Me.GroupBox1.Enabled = True
        Me.ComboBoxEmpleado.Focus()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        DataGridView1.Rows.Clear()
        DataGridView2.DataSource = Nothing
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        Me.TextBoxCantidad.Text = ""
        Me.TextBoxEmpleado.Text = ""
        Me.TextBoxServicio.Text = ""
        Me.TextBoxPrecio.Text = ""
        Me.TextBoxTotal.Text = ""
        Me.TextBoxGanancia_E.Text = ""
        Me.TextBoxGanancia_N.Text = ""
        Me.ComboBoxTipo_Pago.Text = ""
        Me.GroupBox1.Enabled = False
    End Sub
End Class