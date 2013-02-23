Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Empleado_Ganancias
    Dim accion As String
    Dim posicion As Integer
    Dim numeroFilas As Integer
    Public connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DivalI&F.accdb")
    Dim filaencontrada As DataRow
    Private fila As Byte

    Private Sub Empleado_Ganancias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then
            If Me.ButtonBuscar.Enabled = True Then
                Call ButtonBuscar_Click(ButtonBuscar, e)
            Else
            End If
        End If
        If e.KeyCode = 113 Then
            If Me.ButtonGuardar.Enabled = True Then
                Call Button2_Click(ButtonGuardar, e)
            Else
            End If
        End If
        If e.KeyCode = 114 Then
            If Me.ButtonModificar.Enabled = True Then
                Call ButtonModificar_Click(ButtonModificar, e)
            Else
            End If
        End If
        If e.KeyCode = 115 Then
            If Me.ButtonEliminar.Enabled = True Then
                Call ButtonEliminar_Click(ButtonEliminar, e)
            Else
            End If
        End If
        If e.KeyCode = 116 Then
            If ButtonCancelar.Enabled = True Then
                Call ButtonCancelar_Click(ButtonCancelar, e)
            Else
            End If
        End If
        If e.KeyCode = 27 Then
            If Button1.Enabled = True Then
                Call Button1_Click(Button1, e)
            Else
            End If
        End If
    End Sub

    Private Sub Empleado_Ganancias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetServicio.Clear()
        Me.OleDbDataAdapterServicio.Fill(Me.DataSetServicio)
        numeroFilas = BindingContext(Me.DataSetServicio, "dbo_Servicio").Count
        Me.Text = "Ganancias Empleado     DiVal I&F     *** Sesion Iniciada: " + UsuarioIniciado

        Me.DataSetEmpleado.Clear()
        Me.OleDbDataAdapterEmpleadoo.Fill(Me.DataSetEmpleado)
        numeroFilas = BindingContext(Me.DataSetEmpleado, "dbo_Empleado").Count

        Me.ComboBoxEmpleadoo.Text = ""
        Me.ComboBoxServicioo.Text = ""
        Me.KeyPreview = True
    End Sub

    Private Sub ComboBoxEmpleadoo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmpleadoo.SelectedIndexChanged
        Me.TextBoxEmpleadoo.Text = Me.ComboBoxEmpleadoo.SelectedValue
    End Sub

    Private Sub ComboBoxServicioo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxServicioo.SelectedIndexChanged
        Me.TextBoxServicio.Text = Me.ComboBoxServicioo.SelectedValue
    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        accion = "Agregar"
        If Me.ComboBoxEmpleadoo.Text <> "" And Me.ComboBoxServicioo.Text <> "" And Me.TextBoxGanancias_E.Text <> "" Then
            Me.ButtonAgregar.Enabled = False
            Me.ButtonNuevo.Enabled = True
            Me.ButtonBuscar.Enabled = False
            Me.ButtonCancelar.Enabled = True
            Me.ButtonGuardar.Enabled = True
            Me.TextBoxGanancias_N.Text = 100 - (Me.TextBoxGanancias_E.Text)
            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Empleado_Ganancias where Cedula_E = '" + Me.TextBoxEmpleadoo.Text + "' and Codigo_S =" + Me.TextBoxServicio.Text + "", Me.OleDbConnection1)
            da.Fill(Me.DataSetGanancias_E, "dbo_Empleado_Ganancias")
            Me.DataGridViewCGE.DataSource = DataSetGanancias_E.Tables(0)
            If Me.DataGridViewCGE.Rows.Count = 0 Then
                Me.DataGridViewGE.Rows.Add(Me.TextBoxEmpleadoo.Text, Me.TextBoxServicio.Text, Me.ComboBoxServicioo.Text, Me.TextBoxGanancias_E.Text, Me.TextBoxGanancias_N.Text)
                Me.ComboBoxEmpleadoo.Text = ""
                Me.ComboBoxServicioo.Text = ""
                Me.TextBoxGanancias_E.Text = ""
                Me.TextBoxGanancias_N.Text = ""
                Me.TextBoxEmpleadoo.Text = ""
                Me.TextBoxServicio.Text = ""
                Me.TextBoxGanancias_E.Enabled = False
            Else
                MsgBox("Ya existe un porcentaje de ganancia para el empleado en este servicio", MsgBoxStyle.Information, "Ya existe el registro")
            End If
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Campos Vacios")
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


    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        If Me.ComboBoxEmpleadoo.Text <> "" And Me.ComboBoxServicioo.Text <> "" Then
            Me.ButtonAgregar.Enabled = False
            Me.ButtonBuscar.Enabled = False
            Me.ButtonModificar.Enabled = True
            Me.ButtonEliminar.Enabled = True
            Me.ButtonCancelar.Enabled = True
            Try
                Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Empleado_Ganancias where Cedula_E = '" + Me.TextBoxEmpleadoo.Text + "' and Codigo_S =" + Me.TextBoxServicio.Text + "", Me.OleDbConnection1)
                da.Fill(Me.DataSetGanancias_E, "dbo_Empleado_Ganancias")
                Me.DataGridViewCGE.DataSource = DataSetGanancias_E.Tables(0)
           
                If Me.DataGridViewCGE.Rows.Count = 0 Then
                    MsgBox("No se encontro registros")
                    Me.ButtonNuevo.Enabled = True
                    Me.ButtonAgregar.Enabled = False
                    Me.ButtonBuscar.Enabled = True
                    Me.ButtonEliminar.Enabled = False
                    Me.ButtonGuardar.Enabled = False
                    Me.ButtonModificar.Enabled = False
                    Me.ButtonCancelar.Enabled = False
                    Me.TextBoxEmpleadoo.Clear()
                    Me.TextBoxServicio.Clear()
                    Me.TextBoxGanancias_E.Clear()
                    Me.TextBoxGanancias_N.Clear()
                    Me.ComboBoxEmpleadoo.Text = ""
                    Me.ComboBoxServicioo.Text = ""
                    Me.DataGridViewGE.Rows.Clear()

                Else
                    For GE As Integer = 0 To DataGridViewCGE.Rows.Count - 1
                        Me.TextBoxGanancias_E.Text = Me.DataGridViewCGE.Rows(GE).Cells(2).Value.ToString
                        Me.TextBoxGanancias_N.Text = Me.DataGridViewCGE.Rows(GE).Cells(3).Value.ToString
                    Next

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Debe llenar los campos correspondientes", MsgBoxStyle.Exclamation, "Campos Vacios")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        If accion = "Agregar" Then
            Me.ButtonAgregar.Enabled = False
            If DataGridViewGE.Rows.Count > 0 Then
                Dim sqlstring As String = ""
                Dim listsqlstring As New ArrayList
                For GE As Integer = 0 To DataGridViewGE.Rows.Count - 1
                    sqlstring = "INSERT INTO dbo_Empleado_Ganancias (Cedula_E,Codigo_S,Por_Ganancia,Por_Ganancia_N) VALUES ('" + DataGridViewGE.Rows(GE).Cells(0).Value.ToString() + "','" + DataGridViewGE.Rows(GE).Cells(1).Value.ToString() + "','" + DataGridViewGE.Rows(GE).Cells(3).Value.ToString() + "','" + DataGridViewGE.Rows(GE).Cells(4).Value.ToString() + "')"
                    listsqlstring.Add(sqlstring)
                Next
                If Ejecutar_Transaccion(listsqlstring) Then
                    MsgBox("Registro(s) guardado(s) satisfactoriamente", MsgBoxStyle.Information, "Guardar")
                    DataGridViewGE.Rows.Clear()
                    Me.ComboBoxEmpleadoo.Text = ""
                    Me.ComboBoxServicioo.Text = ""
                    Me.TextBoxGanancias_E.Text = ""
                    Me.TextBoxGanancias_N.Text = ""
                    Me.TextBoxEmpleadoo.Text = ""
                    Me.TextBoxServicio.Text = ""
                Else
                    MsgBox("Registro(s) no guardado(s)", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("No hay registros para guardar", MsgBoxStyle.Information, "Vacio")
            End If
        Else
            If accion = "Modificar" Then
                Me.TextBoxGanancias_N.Text = 100 - Me.TextBoxGanancias_E.Text
                Try
                    Me.DataSetGanancias_E.dbo_Empleado_Ganancias(posicion).Cedula_E = Me.TextBoxEmpleadoo.Text
                    Me.DataSetGanancias_E.dbo_Empleado_Ganancias(posicion).Codigo_S = Me.TextBoxServicio.Text
                    Me.DataSetGanancias_E.dbo_Empleado_Ganancias(posicion).Por_Ganancia = Me.TextBoxGanancias_E.Text
                    Me.DataSetGanancias_E.dbo_Empleado_Ganancias(posicion).Por_Ganancia_N = Me.TextBoxGanancias_N.Text
                    Me.OleDbDataAdapterGanancias_E.Update(Me.DataSetGanancias_E, "dbo_Empleado_Ganancias")
                    Me.DataSetGanancias_E.dbo_Empleado_Ganancias.AcceptChanges()
                    MsgBox("Ganancias de empleado modificada satisfactoriamente", MsgBoxStyle.Information, "Modificado")
                   
                Catch ex As Exception
                    MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "dbo_Empleado_Ganancias")
                End Try
            End If
        End If
        Cerrar_Conexion()
        
        Me.ButtonAgregar.Enabled = False
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxGanancias_E.Enabled = False
        Me.ComboBoxEmpleadoo.Text = ""
        Me.ComboBoxServicioo.Text = ""
        Me.TextBoxEmpleadoo.Clear()
        Me.TextBoxServicio.Clear()
        Me.TextBoxGanancias_E.Clear()
        Me.TextBoxGanancias_N.Clear()
        Me.DataGridViewGE.Rows.Clear()
        Me.TextBoxGanancias_E.Enabled = False
        If Me.DataGridViewCGE.RowCount >= 1 Then
            For i As Integer = 0 To Me.DataGridViewCGE.RowCount - 1
                Me.DataGridViewCGE.Rows.Remove(Me.DataGridViewCGE.CurrentRow)
            Next
        End If
  
    End Sub

    Private Sub DataGridViewCGE_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If DataGridViewGE.Columns(e.ColumnIndex).Name = "ColumnEliminar" Then
            DataGridViewGE.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub ButtonBuscarE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fila = Me.DataGridViewGE.CurrentCell.RowIndex

    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        accion = "Modificar"
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = True
        Me.ButtonCancelar.Enabled = True
        Me.TextBoxGanancias_E.Enabled = True
        Me.TextBoxGanancias_E.Focus()
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Dim resp As DialogResult
        resp = MsgBox("¿Seguro que desea eliminar este Servicio a el Empleado?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar")
        If resp = DialogResult.Yes Then
            Try
                Me.DataSetGanancias_E.dbo_Empleado_Ganancias.Rows(posicion).Delete()
                Me.OleDbDataAdapterGanancias_E.Update(Me.DataSetGanancias_E, "dbo_Empleado_Ganancias")
                Me.DataSetGanancias_E.dbo_Empleado_Ganancias.AcceptChanges()
                numeroFilas = Me.BindingContext(Me.DataSetGanancias_E, "dbo_Empleado_Ganancias").Count
                MsgBox("El Servicio ha sido eliminado satisfactoriamente a el Empleado", MsgBoxStyle.Information, "Eliminado")
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        Else
            MsgBox("El Servicio no ha sido eliminado a el Empleado", MsgBoxStyle.Information, "Cancelar")
        End If
        Me.ButtonNuevo.Enabled = True
        Me.ButtonAgregar.Enabled = False
        Me.ButtonBuscar.Enabled = True
        Me.ButtonEliminar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxEmpleadoo.Clear()
        Me.TextBoxServicio.Clear()
        Me.TextBoxGanancias_E.Clear()
        Me.TextBoxGanancias_N.Clear()
        Me.ComboBoxEmpleadoo.Text = ""
        Me.ComboBoxServicioo.Text = ""
        Me.DataGridViewGE.Rows.Clear()
        For i As Integer = 0 To Me.DataGridViewCGE.RowCount - 1
            Me.DataGridViewCGE.Rows.Remove(Me.DataGridViewCGE.CurrentRow)
        Next
    End Sub

    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click
        Me.ButtonNuevo.Enabled = False
        Me.TextBoxGanancias_E.Enabled = True
        Me.TextBoxGanancias_E.Focus()
        Me.ButtonAgregar.Enabled = True
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonAgregar.Enabled = False
        Me.ButtonBuscar.Enabled = True
        Me.ButtonEliminar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxEmpleadoo.Clear()
        Me.TextBoxServicio.Clear()
        Me.TextBoxGanancias_E.Clear()
        Me.TextBoxGanancias_E.Enabled = False
        Me.TextBoxGanancias_N.Clear()
        Me.ComboBoxEmpleadoo.Text = ""
        Me.ComboBoxServicioo.Text = ""
        Me.DataGridViewGE.Rows.Clear()

        For i As Integer = 0 To Me.DataGridViewCGE.RowCount - 1
            Me.DataGridViewCGE.Rows.Remove(Me.DataGridViewCGE.CurrentRow)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If respuestaX = 1 Then
            Registro_prodcuccion.Show()
            respuestaX = 0
            Me.ComboBoxEmpleadoo.Text = ""
            Me.ComboBoxServicioo.Text = ""
            Me.ButtonNuevo.Enabled = True
            Me.ButtonAgregar.Enabled = False
            Me.ButtonBuscar.Enabled = True
            Me.ButtonEliminar.Enabled = False
            Me.ButtonGuardar.Enabled = False
            Me.ButtonModificar.Enabled = False
            Me.ButtonCancelar.Enabled = False
            Me.TextBoxEmpleadoo.Clear()
            Me.TextBoxServicio.Clear()
            Me.TextBoxGanancias_E.Clear()
            Me.TextBoxGanancias_N.Clear()
            Me.DataGridViewGE.Rows.Clear()
            'Me.DataGridViewCGE.Rows.Clear()
            For i As Integer = 0 To Me.DataGridViewCGE.RowCount - 1
                Me.DataGridViewCGE.Rows.Remove(Me.DataGridViewCGE.CurrentRow)
            Next
            Me.Close()
        Else
            Me.ComboBoxEmpleadoo.Text = ""
            Me.ComboBoxServicioo.Text = ""
            Me.ButtonNuevo.Enabled = True
            Me.ButtonAgregar.Enabled = False
            Me.ButtonBuscar.Enabled = True
            Me.ButtonEliminar.Enabled = False
            Me.ButtonGuardar.Enabled = False
            Me.ButtonModificar.Enabled = False
            Me.ButtonCancelar.Enabled = False
            Me.TextBoxEmpleadoo.Clear()
            Me.TextBoxServicio.Clear()
            Me.TextBoxGanancias_E.Clear()
            Me.TextBoxGanancias_N.Clear()
            Me.DataGridViewGE.Rows.Clear()

            For i As Integer = 0 To Me.DataGridViewCGE.RowCount - 1
                Me.DataGridViewCGE.Rows.Remove(Me.DataGridViewCGE.CurrentRow)
            Next
            Me.Close()
        End If
    End Sub

    Private Sub DataGridViewGE_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewGE.CellContentClick
        If DataGridViewGE.Columns(e.ColumnIndex).Name = "Column1" Then
            DataGridViewGE.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class