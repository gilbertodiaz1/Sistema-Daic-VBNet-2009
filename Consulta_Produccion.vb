Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Data.OleDb
Public Class Consulta_Produccion
    Dim posicion As Integer
    Dim numeroFilas As Integer
    Private carrito As New DataTable("Registro_Produccion")
    Private dr As DataRow
    Private fila As Byte

    Private Sub Consulta_Produccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Call ButtonRegresar_Click(ButtonRegresar, e)
        End If
    End Sub

    Private Sub Consulta_Produccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetEmpleadoCO().Clear()
        Me.OleDbDataAdapterEmpleadoCO().Fill(Me.DataSetEmpleadoCO)
        Me.DataSetRegistroProduccion().Clear()
        ' Me.SqlDataAdapterRegistroProduccion().Fill(Me.DataSetRegistroProduccion)
        Me.DataSetServicioCO().Clear()
        Me.OleDbDataAdapterServicioCO().Fill(Me.DataSetServicioCO)
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        Me.ComboBoxTipo_C.Text = ""
        Me.Text = "Consulta de Producción                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
        Me.DataGridViewConsulta.DataSource = carrito
        Me.KeyPreview = True
    End Sub

    Private Sub ComboBoxTipo_C_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipo_C.SelectedIndexChanged
        Tipo_Consulta()
    End Sub
    Private Sub Tipo_Consulta()
        Select Case Me.ComboBoxTipo_C.Text
            Case ""
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
            Case "Por Dia"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.DateTimePickerDesde.Enabled = True
            Case "Por Empleado"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxEmpleado.Enabled = True
            Case "Por Empleado y Dia"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxEmpleado.Enabled = True
                Me.DateTimePickerDesde.Enabled = True
            Case "Por Empleado y Servicio"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxEmpleado.Enabled = True
                Me.ComboBoxServicio.Enabled = True
            Case "Por Empleado y Semana"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxEmpleado.Enabled = True
                Me.DateTimePickerDesde.Enabled = True
                Me.DateTimePickerHasta.Enabled = True
            Case "Por Semana"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.DateTimePickerDesde.Enabled = True
                Me.DateTimePickerHasta.Enabled = True
            Case "Por Servicio"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxServicio.Enabled = True
            Case "Por Servicio y Dia"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxServicio.Enabled = True
                Me.DateTimePickerDesde.Enabled = True
            Case "Por Servicio y Semana"
                Me.ComboBoxEmpleado.Enabled = False
                Me.DateTimePickerDesde.Enabled = False
                Me.DateTimePickerHasta.Enabled = False
                Me.ComboBoxServicio.Enabled = False
                Me.ComboBoxServicio.Enabled = True
                Me.DateTimePickerDesde.Enabled = True
                Me.DateTimePickerHasta.Enabled = True
        End Select
    End Sub

    Private Sub ComboBoxTipo_C_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipo_C.TextChanged
        Me.ComboBoxEmpleado.Enabled = False
        Me.DateTimePickerDesde.Enabled = False
        Me.DateTimePickerHasta.Enabled = False
        Me.ComboBoxServicio.Enabled = False
    End Sub

    Private Sub ButtonConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConsulta.Click
        Me.ComboBoxTipo_C.Enabled = False
        Me.ComboBoxTipo_Pago.Enabled = False
        Me.ComboBoxEmpleado.Enabled = False
        Me.DateTimePickerDesde.Enabled = False
        Me.DateTimePickerHasta.Enabled = False
        Me.ComboBoxServicio.Enabled = False
        Me.ButtonConsulta.Enabled = False
        Me.ButtonNueva_C.Enabled = True
        Select Case Me.ComboBoxTipo_C.Text
            Case "Por Dia"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "'", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "'and Tipo_Pago = 'Efectivo'", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "'and Tipo_Pago = 'Débito'", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Empleado"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "'and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Empleado y Dia"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and Cedula_E='" + Me.TextBoxCE.Text + "'Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and Cedula_E='" + Me.TextBoxCE.Text + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha = '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and Cedula_E='" + Me.TextBoxCE.Text + "' and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Empleado y Servicio"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "' and Codigo_S=" + Me.TextBoxCS.Text + " Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "' and Codigo_S=" + Me.TextBoxCS.Text + " and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Cedula_E = '" + Me.TextBoxCE.Text + "' and Codigo_S=" + Me.TextBoxCS.Text + " and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Empleado y Semana"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "'and Cedula_E='" + Me.TextBoxCE.Text + "' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "'and Cedula_E='" + Me.TextBoxCE.Text + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "'and Cedula_E='" + Me.TextBoxCE.Text + "' and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Semana"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "'Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Fecha between '" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and '" + Me.DateTimePickerHasta.Value.ToShortDateString + "' and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Servicio"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Servicio y Dia"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " and Fecha='" + Me.DateTimePickerDesde.Value.ToShortDateString + "'Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " and Fecha='" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S=" + Me.TextBoxCS.Text + " and Fecha='" + Me.DateTimePickerDesde.Value.ToShortDateString + "' and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
            Case "Por Servicio y Semana"
                Select Case Me.ComboBoxTipo_Pago.Text
                    Case "Efectivo y Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S= " + Me.TextBoxCS.Text + " and Fecha between'" + Me.DateTimePickerDesde.Value.ToShortDateString + "'and'" + Me.DateTimePickerHasta.Value.ToShortDateString + "'Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            ' Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Efectivo"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S= " + Me.TextBoxCS.Text + " and Fecha between'" + Me.DateTimePickerDesde.Value.ToShortDateString + "'and'" + Me.DateTimePickerHasta.Value.ToShortDateString + "' and Tipo_Pago = 'Efectivo' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case "Solo Débito"
                        Try
                            Dim da As New OleDbDataAdapter("SELECT * FROM dbo_Registro_Produccion where Codigo_S= " + Me.TextBoxCS.Text + " and Fecha between'" + Me.DateTimePickerDesde.Value.ToShortDateString + "'and'" + Me.DateTimePickerHasta.Value.ToShortDateString + "' and Tipo_Pago = 'Débito' Order By Fecha", Me.OleDbConnection1)
                            da.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                            Me.DataGridViewConsulta.DataSource = DataSetRegistroProduccionCO.Tables(0)
                            'Me.DataGridViewConsulta.Columns(0).Visible = False
                            Cambiar_Nombre()
                            If Me.DataGridViewConsulta.Rows.Count = 0 Then
                                MsgBox("No se encontro registros")
                                Me.ButtonExportar.Enabled = False
                            Else
                                Sumar()
                                Me.ButtonExportar.Enabled = True
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
        End Select
    End Sub

    Private Sub ComboBoxEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmpleado.SelectedIndexChanged
        Me.TextBoxCE.Text = Me.ComboBoxEmpleado.SelectedValue
    End Sub

    Private Sub ComboBoxServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxServicio.SelectedIndexChanged
        Me.TextBoxCS.Text = Me.ComboBoxServicio.SelectedValue
    End Sub

    Private Sub ButtonNueva_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNueva_C.Click
        Me.ButtonEliminarRegistro.Enabled = False
        Me.ButtonNueva_C.Enabled = False
        Me.ComboBoxTipo_Pago.Text = ""
        Me.ComboBoxTipo_Pago.Enabled = True
        Me.ComboBoxTipo_C.Enabled = True
        Me.ButtonConsulta.Enabled = True
        Me.ButtonExportar.Enabled = False
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        If Me.DataGridViewConsulta.RowCount >= 1 Then
            For i As Integer = 0 To Me.DataGridViewConsulta.RowCount - 1
                Me.DataGridViewConsulta.Rows.Remove(Me.DataGridViewConsulta.CurrentRow)
            Next
        End If
        Me.TextBoxCE.Clear()
        Me.TextBoxCS.Clear()
        Me.TextBoxTGE.Clear()
        Me.TextBoxTGN.Clear()
        Me.TextBoxTotal.Clear()
        Me.ComboBoxTipo_C.Text = ""
        Me.TextBox1.Text = ""
    End Sub

    Private Sub Sumar()
        Dim total As Double = 0
        Dim total2 As Double = 0
        Dim total3 As Double = 0
        Dim itotal As Integer = Me.DataGridViewConsulta.Rows.Count
        Dim itotal2 As Integer = Me.DataGridViewConsulta.Rows.Count
        Dim i, i2 As Integer
        For i = 0 To itotal - 1
            total = total + (Me.DataGridViewConsulta(6, i).Value)
        Next
        Me.TextBoxTGE.Text = total

        For i2 = 0 To itotal2 - 1
            total2 = total2 + (Me.DataGridViewConsulta(7, i2).Value)
        Next
        Me.TextBoxTGN.Text = total2

        total3 = total + total2
        Me.TextBoxTotal.Text = total3
    End Sub
    Private Sub Cambiar_Nombre()
        Me.DataGridViewConsulta.Columns(0).Width = 50
        Me.DataGridViewConsulta.Columns(1).HeaderText = "Cedula"
        Me.DataGridViewConsulta.Columns(2).HeaderText = "Fecha"
        Me.DataGridViewConsulta.Columns(3).HeaderText = "Servicio"
        Me.DataGridViewConsulta.Columns(4).HeaderText = "Cantidad de Servicios"
        Me.DataGridViewConsulta.Columns(4).Width = 140
        Me.DataGridViewConsulta.Columns(5).HeaderText = "Total"
        Me.DataGridViewConsulta.Columns(6).HeaderText = "Total Ganancia Empleado"
        Me.DataGridViewConsulta.Columns(6).Width = 155
        Me.DataGridViewConsulta.Columns(7).HeaderText = "Total Ganancia Negocio"
        Me.DataGridViewConsulta.Columns(7).Width = 150
        Me.DataGridViewConsulta.Columns(8).HeaderText = "Tipo de Pago"
        Me.DataGridViewConsulta.Columns(0).ReadOnly = True
        Me.DataGridViewConsulta.Columns(1).ReadOnly = True
        Me.DataGridViewConsulta.Columns(2).ReadOnly = True
        Me.DataGridViewConsulta.Columns(3).ReadOnly = True
        Me.DataGridViewConsulta.Columns(4).ReadOnly = True
        Me.DataGridViewConsulta.Columns(5).ReadOnly = True
        Me.DataGridViewConsulta.Columns(6).ReadOnly = True
        Me.DataGridViewConsulta.Columns(7).ReadOnly = True
    End Sub

    Private Sub pdt_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdt.PrintPage
        Dim i As Integer
        Dim stb, stbnombre, stbnombre2, stbfecha, stbsuperior, stbsalto, stbpago, stbigv, stbpagot As New StringBuilder()
        Dim Texto, texto2, texto3, texto4, texto5, texto6, texto7, texto8, texto9 As String
        Dim Fuente As New Font("Courier New", 10)
        Dim Brocha As Brush = Brushes.Blue
        Dim X As Integer = e.MarginBounds.Left
        Dim Y As Integer = e.MarginBounds.Top
        '///
        stbsalto.Append("")
        texto3 = stbsalto.ToString
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '///
        stbnombre.Append("Tipo de Consulta : " & Me.ComboBoxTipo_C.Text)
        texto7 = stbnombre.ToString
        e.Graphics.DrawString(texto7, Fuente, Brocha, 250, Y)
        Y = Y + Fuente.GetHeight
        stbpago.Length = 0
        '///
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '///
        stbnombre2.Append("Fecha Desde: " & Me.DateTimePickerDesde.Value.ToShortDateString & " Hasta: " & Me.DateTimePickerHasta.Value.ToShortDateString)
        texto9 = stbnombre2.ToString
        e.Graphics.DrawString(texto9, Fuente, Brocha, 250, Y)
        Y = Y + Fuente.GetHeight
        stbpago.Length = 0
        '///
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '///
        stbfecha.Append("Fecha del Pedido   : ")
        texto8 = stbfecha.ToString
        e.Graphics.DrawString(texto8, Fuente, Brocha, 250, Y)
        Y = Y + Fuente.GetHeight
        stbpago.Length = 0
        '///
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '///
        stbsuperior.Append("Cedula    Fecha               Servicio    Cantidad    Ganancia Empleado    Ganancia Negocio    Total ")
        texto2 = stbsuperior.ToString
        e.Graphics.DrawString(texto2, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsuperior.Length = 0
        '///
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        For i = 0 To DataGridViewConsulta.DataSource.Rows.Count - 1
            'stb.Append(DataGridViewConsulta.DataSource.Rows(i)(0).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(1).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(2).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(3).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(4).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(5).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(6).ToString.PadRight(10))
            stb.Append(DataGridViewConsulta.DataSource.Rows(i)(7).ToString.PadRight(10))
            'stb.Append(DataGridViewConsulta.DataSource.Rows(i)(8).ToString.PadRight(10))
            Texto = stb.ToString
            e.Graphics.DrawString(Texto, Fuente, Brocha, X, Y)
            Y = Y + Fuente.GetHeight
            stb.Length = 0
        Next
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '/////
        stbpago.Append("Ganancia Empleado : " & Me.TextBoxTGE.Text)
        texto4 = stbpago.ToString
        e.Graphics.DrawString(texto4, Fuente, Brocha, 350, Y)
        Y = Y + Fuente.GetHeight
        stbpago.Length = 0
        '//
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '//
        stbigv.Append("Ganancia Negocio  : " & Me.TextBoxTGN.Text)
        texto5 = stbigv.ToString
        e.Graphics.DrawString(texto5, Fuente, Brocha, 350, Y)
        Y = Y + Fuente.GetHeight
        stbigv.Length = 0
        '///
        e.Graphics.DrawString(texto3, Fuente, Brocha, X, Y)
        Y = Y + Fuente.GetHeight
        stbsalto.Length = 0
        '///
        stbpagot.Append("Total  : " & Me.TextBoxTotal.Text)
        texto6 = stbpagot.ToString
        e.Graphics.DrawString(texto6, Fuente, Brocha, 350, Y)
        Y = Y + Fuente.GetHeight
        stbpagot.Length = 0
        '///





    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        With pdg 'Dialogo de Print
            .Document = pdt
            .AllowPrintToFile = False
            .AllowSelection = True
            .AllowSomePages = True
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                pdt.PrinterSettings = .PrinterSettings
                pdt.Print()
            End If
        End With
    End Sub
    Private Sub BtnCHoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCHoja.Click
        With psdPagina 'Dialogo de Page Setup
            .Document = pdt
            .ShowDialog()
        End With
    End Sub
    Private Sub btnvp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvp.Click
        With ppd 'Dialogo de Preview
            .Document = pdt
            .Text = "Lista de Productos..."
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminarRegistro.Click
        Dim resp As DialogResult
        resp = MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar registro")
        If resp = DialogResult.Yes Then
            Try
                Dim daa As New OleDbDataAdapter("DELETE from dbo_Registro_Produccion where Codigo = " + Me.TextBox1.Text + "", Me.OleDbConnection1)
                daa.Fill(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                Me.OleDbDataAdapterRegistroProduccion.Update(Me.DataSetRegistroProduccionCO, "dbo_Registro_Produccion")
                Me.DataSetRegistroProduccionCO.dbo_Registro_Produccion.AcceptChanges()
                If Me.DataGridViewConsulta.RowCount >= 1 Then
                    For i As Integer = 0 To Me.DataGridViewConsulta.RowCount - 1
                        Me.DataGridViewConsulta.Rows.Remove(Me.DataGridViewConsulta.CurrentRow)
                    Next
                End If
                Me.ButtonConsulta_Click(Me.ButtonConsulta, e)
                Me.TextBox1.Text = ""
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        End If
    End Sub

    Private Sub DataGridViewConsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewConsulta.Click
        Try
            TextBox1.Text = DataGridViewConsulta.Item(0, DataGridViewConsulta.CurrentRow.Index).Value
            Me.ButtonEliminarRegistro.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewConsulta_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewConsulta.CellMouseEnter
        If e.RowIndex >= 0 Then
            Me.DataGridViewConsulta.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightSkyBlue
        End If

    End Sub
    Private Sub DataGridViewConsulta_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewConsulta.CellMouseLeave
        If e.RowIndex >= 0 Then
            Me.DataGridViewConsulta.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub ButtonExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExportar.Click
        Dim oExcel As Excel.ApplicationClass
        Dim oBooks As Excel.Workbooks
        Dim oBook As Excel.WorkbookClass
        Dim oSheet As Excel.Worksheet
        Try
            ' Inicia Excel y abre el workbook
            oExcel = CreateObject("Excel.Application")
            oExcel.Visible = True
            oBooks = oExcel.Workbooks
            'oBook = oExcel.Workbooks.Add
            oBook = oBooks.Open( _
               "C:\Sistema DiVal\Reportes\Data.xlsx")

            oSheet = oBook.Sheets(1)

           
            Const ROW_FIRST = 10
            Const ROW_COnsulta = 6
            Const ROW_Pago = 7
            'Const ROW_Empleado = 44
            'Const ROW_Negocio = 45
            'Const ROW_Total = 46
            Const ROW_Desde = 6
            Const ROW_Hasta = 6
            Dim iRow As Int64 = 1

            ' Loop que almacena los datos
            Dim rowCustomer As DataSetRegistroProduccionCO.dbo_Registro_ProduccionRow
            For Each rowCustomer In Me.DataSetRegistroProduccionCO.dbo_Registro_Produccion
                Dim iCurrRow As Int64 = ROW_FIRST + iRow
                oSheet.Cells(iCurrRow, 1) = rowCustomer.Cedula_E
                oSheet.Cells(iCurrRow, 2) = rowCustomer.Fecha
                oSheet.Cells(iCurrRow, 3) = rowCustomer.Codigo_S
                oSheet.Cells(iCurrRow, 4) = rowCustomer.Cantidad
                oSheet.Cells(iCurrRow, 5) = rowCustomer.Total
                oSheet.Cells(iCurrRow, 6) = rowCustomer.TGE
                oSheet.Cells(iCurrRow, 7) = rowCustomer.TGN
                oSheet.Cells(iCurrRow, 8) = rowCustomer.Tipo_Pago
                iRow += 1
            Next

            oSheet.Cells(ROW_COnsulta, 2) = Me.ComboBoxTipo_C.Text
            oSheet.Cells(ROW_Pago, 2) = Me.ComboBoxTipo_Pago.Text
            oSheet.Cells(ROW_FIRST + iRow + 1, 6).font.bold = True
            oSheet.Cells(ROW_FIRST + iRow + 1, 7).font.bold = True
            oSheet.Cells(ROW_FIRST + iRow + 1, 5).font.bold = True

            oSheet.Cells(ROW_FIRST + iRow + 2, 6).font.bold = True
            oSheet.Cells(ROW_FIRST + iRow + 2, 7).font.bold = True
            oSheet.Cells(ROW_FIRST + iRow + 2, 5).font.bold = True

            oSheet.Cells(ROW_FIRST + iRow + 1, 6) = "Total"
            oSheet.Cells(ROW_FIRST + iRow + 1, 7) = "Total"
            oSheet.Cells(ROW_FIRST + iRow + 1, 5) = "Total"

            oSheet.Cells(ROW_FIRST + iRow + 2, 6) = "Empleado"
            oSheet.Cells(ROW_FIRST + iRow + 2, 7) = "LIDYA´S"
            oSheet.Cells(ROW_FIRST + iRow + 2, 5) = "General"

            oSheet.Cells(ROW_FIRST + iRow + 3, 6) = Me.TextBoxTGE.Text
            oSheet.Cells(ROW_FIRST + iRow + 3, 7) = Me.TextBoxTGN.Text
            oSheet.Cells(ROW_FIRST + iRow + 3, 5) = Me.TextBoxTotal.Text

            If Me.ComboBoxTipo_C.Text = "Por Semana" Or Me.ComboBoxTipo_C.Text = "Por Empleado y Semana" Or Me.ComboBoxTipo_C.Text = "Por Servicio y Semana" Then
                oSheet.Cells(ROW_Desde, 4) = Me.DateTimePickerDesde.Value.ToShortDateString
                oSheet.Cells(ROW_Hasta, 6) = Me.DateTimePickerHasta.Value.ToShortDateString
            End If
            If Me.ComboBoxTipo_C.Text = "Por Dia" Or Me.ComboBoxTipo_C.Text = "Por Empleado y Dia" Or Me.ComboBoxTipo_C.Text = "Por Servicio y Dia" Then
                oSheet.Cells(ROW_Desde, 4) = Me.DateTimePickerDesde.Value.ToShortDateString
                oSheet.Cells(ROW_Hasta, 6) = Me.DateTimePickerDesde.Value.ToShortDateString
            End If
            ' eso es la fila y el numero es la columna
            '' Fórmula
            'oSheet.Cells(ROW_FIRST + iRow + 1, 1) = "=counta(R" & (ROW_FIRST + 1) & "C1:R" & (ROW_FIRST + iRow - 1).ToString & "C1)"

            ' '' Cierra todo
            ''oBook.Close(True)
            ''System.Runtime.InteropServices.Marshal. _
            ''    ReleaseComObject(oBook)
            ''oBook = Nothing

            ''System.Runtime.InteropServices.Marshal. _
            ''    ReleaseComObject(oBooks)
            ''oBooks = Nothing

            ''oExcel.Quit()
            ''System.Runtime.InteropServices.Marshal. _
            ''    ReleaseComObject(oExcel)
            ''oExcel = Nothing

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegresar.Click
        Me.ButtonEliminarRegistro.Enabled = False
        Me.ButtonNueva_C.Enabled = False
        Me.ComboBoxTipo_Pago.Text = ""
        Me.ComboBoxTipo_Pago.Enabled = True
        Me.ComboBoxTipo_C.Enabled = True
        Me.ButtonConsulta.Enabled = True
        Me.ButtonExportar.Enabled = False
        Me.ComboBoxEmpleado.Text = ""
        Me.ComboBoxServicio.Text = ""
        If Me.DataGridViewConsulta.RowCount >= 1 Then
            For i As Integer = 0 To Me.DataGridViewConsulta.RowCount - 1
                Me.DataGridViewConsulta.Rows.Remove(Me.DataGridViewConsulta.CurrentRow)
            Next
        End If
        Me.TextBoxCE.Clear()
        Me.TextBoxCS.Clear()
        Me.TextBoxTGE.Clear()
        Me.TextBoxTGN.Clear()
        Me.TextBoxTotal.Clear()
        Me.ComboBoxTipo_C.Text = ""
        Me.TextBox1.Text = ""
        Me.Close()
    End Sub
End Class