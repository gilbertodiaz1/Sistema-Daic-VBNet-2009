Public Class Registro_Empleado
    Dim accion As String
    Dim posicion As Integer
    Dim numeroFilas As Integer
    Dim controlError As ErrorProvider


    Private Sub Registro_Empleado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then
            If Me.ButtonNuevo.Enabled = True Then
                Call ButtonNuevo_Click(ButtonNuevo, e)
            Else
            End If
        End If
        If e.KeyCode = 113 Then
            If Me.ButtonBuscar.Enabled = True Then
                Call ButtonBuscar_Click(ButtonBuscar, e)
            Else
            End If
        End If
        If e.KeyCode = 114 Then
            If Me.ButtonGuardar.Enabled = True Then
                Call ButtonGuardar_Click(ButtonGuardar, e)
            Else
            End If
        End If
        If e.KeyCode = 115 Then
            If Me.ButtonModificar.Enabled = True Then
                Call ButtonModificar_Click(ButtonModificar, e)
            Else
            End If
        End If
        If e.KeyCode = 116 Then
            If Me.ButtonEliminar.Enabled = True Then
                Call ButtonEliminar_Click(ButtonEliminar, e)
            Else
            End If
        End If
        If e.KeyCode = 117 Then
            If ButtonCancelar.Enabled = True Then
                Call ButtonCancelar_Click(ButtonCancelar, e)
            Else
            End If
        End If
        If e.KeyCode = 27 Then
            If ButtonSalir.Enabled = True Then
                Call ButtonSalir_Click(ButtonSalir, e)
            Else
            End If
        End If
    End Sub
    Private Sub Registro_Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetEmpleado.Clear()
        Me.OleDbDataAdapter1.Fill(Me.DataSetEmpleado)
        numeroFilas = BindingContext(Me.DataSetEmpleado, "dbo_Empleado").Count
        Me.Text = "Registro de  Empleado                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
        Me.KeyPreview = True
        controlError = New ErrorProvider(Me)
    End Sub
    Private Function posicionFila() As Integer
        Dim p, codigo As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetEmpleado, "dbo_Empleado").Position() = p
            codigo = Me.DataSetEmpleado.dbo_Empleado(p).Cedula
            If codigo = Me.TextBoxCedula.Text Then
                Exit For
            End If
        Next
        Return p
    End Function
    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click
        accion = "Agregar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxFecha_Nac.Text = ""
        Me.TextBoxFecha_Ing.Text = ""
        Me.TextBoxCelular.Clear()
        Me.TextBoxCasa.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxCedula.Focus()
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxApellido.Enabled = True
        Me.TextBoxFecha_Nac.Enabled = True
        Me.TextBoxFecha_Ing.Enabled = True
        Me.TextBoxCelular.Enabled = True
        Me.TextBoxCasa.Enabled = True
        Me.TextBoxDireccion.Enabled = True
    End Sub
    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        accion = "Buscar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxFecha_Nac.Text = ""
        Me.TextBoxFecha_Ing.Text = ""
        Me.TextBoxCelular.Clear()
        Me.TextBoxCasa.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxCedula.Focus()
        controlError.SetError(Me.TextBoxCedula, "")
        controlError.SetError(Me.TextBoxNombre, "")
        controlError.SetError(Me.TextBoxApellido, "")
        controlError.SetError(Me.TextBoxCasa, "")
        controlError.SetError(Me.TextBoxCelular, "")
        controlError.SetError(Me.TextBoxDireccion, "")
    End Sub
    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        accion = "Modificar"
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxApellido.Enabled = True
        Me.TextBoxFecha_Nac.Enabled = True
        Me.TextBoxFecha_Ing.Enabled = True
        Me.TextBoxCelular.Enabled = True
        Me.TextBoxCasa.Enabled = True
        Me.TextBoxDireccion.Enabled = True
        Me.TextBoxCedula.Focus()
    End Sub
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxFecha_Nac.Text = ""
        Me.TextBoxFecha_Ing.Text = ""
        Me.TextBoxCelular.Clear()
        Me.TextBoxCasa.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxApellido.Enabled = False
        Me.TextBoxFecha_Nac.Enabled = False
        Me.TextBoxFecha_Ing.Enabled = False
        Me.TextBoxCelular.Enabled = False
        Me.TextBoxCasa.Enabled = False
        Me.TextBoxDireccion.Enabled = False
        'controlError.SetError(Me.TextBoxCedula, "")
        'controlError.SetError(Me.TextBoxNombre, "")
        'controlError.SetError(Me.TextBoxApellido, "")
        'controlError.SetError(Me.TextBoxCasa, "")
        'controlError.SetError(Me.TextBoxCelular, "")
        'controlError.SetError(Me.TextBoxDireccion, "")

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Dim resp As DialogResult
        resp = MsgBox("¿Seguro que desea eliminar este empleado?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar")
        If resp = DialogResult.Yes Then
            Try
                Me.DataSetEmpleado.dbo_Empleado.Rows(posicion).Delete()
                Me.OleDbDataAdapter1.Update(Me.DataSetEmpleado, "dbo_Empleado")
                Me.DataSetEmpleado.dbo_Empleado.AcceptChanges()
                numeroFilas = Me.BindingContext(Me.DataSetEmpleado, "dbo_Empleado").Count
                MsgBox("El empleado ha sido eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminado")
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        End If
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxFecha_Nac.Text = ""
        Me.TextBoxFecha_Ing.Text = ""
        Me.TextBoxCelular.Clear()
        Me.TextBoxCasa.Clear()
        Me.TextBoxDireccion.Clear()
        'controlError.SetError(Me.TextBoxCedula, "")
        'controlError.SetError(Me.TextBoxNombre, "")
        'controlError.SetError(Me.TextBoxApellido, "")
        'controlError.SetError(Me.TextBoxCasa, "")
        'controlError.SetError(Me.TextBoxCelular, "")
        'controlError.SetError(Me.TextBoxDireccion, "")
    End Sub
    Private Sub TextBoxCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCedula.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            If accion = "Buscar" Then
                If Me.TextBoxCedula.Text <> "" Then
                    Dim codigobuscado As String
                    codigobuscado = Convert.ToInt32(Me.TextBoxCedula.Text)
                    Dim res As DataRow
                    res = Me.DataSetEmpleado.dbo_Empleado.Rows.Find(codigobuscado)
                    If Not (res Is Nothing) Then
                        Me.TextBoxCedula.Enabled = False
                        Me.TextBoxNombre.Text = res(1)
                        Me.TextBoxApellido.Text = res(2)
                        Me.TextBoxFecha_Nac.Text = res(3)
                        Me.TextBoxFecha_Ing.Text = res(4)
                        Me.TextBoxCasa.Text = res(5)
                        Me.TextBoxCelular.Text = res(6)
                        Me.TextBoxDireccion.Text = res(7)
                        posicion = posicionFila()
                        Me.ButtonModificar.Enabled = True
                        Me.ButtonEliminar.Enabled = True
                        Me.ButtonCancelar.Enabled = True
                    Else
                        MsgBox("No se ha encontrado el empleado con la cedula " & codigobuscado, MsgBoxStyle.Information, "Buscar")
                        Me.TextBoxCedula.Clear()
                        Me.TextBoxCedula.Enabled = False
                        Me.ButtonNuevo.Enabled = True
                        Me.ButtonBuscar.Enabled = True
                        Me.ButtonCancelar.Enabled = False
                    End If
                Else
                    MsgBox("Por favor ingrese una Cédula", MsgBoxStyle.Exclamation, "Campo Vacio")
                End If
            Else
                Me.TextBoxNombre.Focus()
            End If
        End If
    End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        If Me.TextBoxCedula.Text <> "" And Me.TextBoxNombre.Text <> "" And Me.TextBoxApellido.Text <> "" And Me.TextBoxFecha_Nac.Text <> "" And Me.TextBoxFecha_Ing.Text <> "" And Me.TextBoxCasa.Text <> "" And Me.TextBoxCelular.Text <> "" And Me.TextBoxDireccion.Text <> "" Then
            If accion = "Agregar" Then
                Dim Fila As DataRow
                Fila = Me.DataSetEmpleado.dbo_Empleado.NewRow
                Fila(0) = Me.TextBoxCedula.Text
                Fila(1) = Me.TextBoxNombre.Text
                Fila(2) = Me.TextBoxApellido.Text
                Fila(3) = Me.TextBoxFecha_Nac.Text
                Fila(4) = Me.TextBoxFecha_Ing.Text
                Fila(5) = Me.TextBoxCasa.Text
                Fila(6) = Me.TextBoxCelular.Text
                Fila(7) = Me.TextBoxDireccion.Text
                Try
                    Me.DataSetEmpleado.dbo_Empleado.Rows.Add(Fila)
                    Me.OleDbDataAdapter1.Update(Me.DataSetEmpleado, "dbo_Empleado")
                    Me.DataSetEmpleado.dbo_Empleado.AcceptChanges()
                Catch ex As Exception
                    MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                End Try
            Else
                If accion = "Modificar" Then
                    Try
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Cedula = Me.TextBoxCedula.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Nombre = Me.TextBoxNombre.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Apellidio = Me.TextBoxApellido.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Fecha_Nac = Me.TextBoxFecha_Nac.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Fecha_Ing = Me.TextBoxFecha_Ing.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Telefono = Me.TextBoxCasa.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Movil = Me.TextBoxCelular.Text
                        Me.DataSetEmpleado.dbo_Empleado(posicion).Direccion = Me.TextBoxDireccion.Text
                        Me.OleDbDataAdapter1.Update(Me.DataSetEmpleado, "dbo_Empleado")
                        Me.DataSetEmpleado.dbo_Empleado.AcceptChanges()
                    Catch ex As Exception
                        MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                    End Try
                End If
            End If

            Me.DataSetEmpleado.Clear()
            Me.OleDbDataAdapter1.Fill(Me.DataSetEmpleado)
            numeroFilas = Me.BindingContext(Me.DataSetEmpleado, "dbo_Empleado").Count
            If accion = "Agregar" Then
                Me.TextBoxCedula.Text = Me.DataSetEmpleado.dbo_Empleado(numeroFilas - 1).Cedula
                MsgBox("Empleado agregado satisfactoriamente", MsgBoxStyle.Information, "Agregado")
            Else
                MsgBox("Empleado modificado satisfactoriamente", MsgBoxStyle.Information, "Modificado")
            End If
            Me.ButtonNuevo.Enabled = True
            Me.ButtonBuscar.Enabled = True
            Me.ButtonModificar.Enabled = False
            Me.ButtonGuardar.Enabled = False
            Me.ButtonEliminar.Enabled = False
            Me.TextBoxCedula.Clear()
            Me.TextBoxNombre.Clear()
            Me.TextBoxApellido.Clear()
            Me.TextBoxFecha_Nac.Text = ""
            Me.TextBoxFecha_Ing.Text = ""
            Me.TextBoxCelular.Clear()
            Me.TextBoxCasa.Clear()
            Me.TextBoxDireccion.Clear()
            Me.TextBoxCedula.Enabled = False
            Me.TextBoxNombre.Enabled = False
            Me.TextBoxApellido.Enabled = False
            Me.TextBoxFecha_Nac.Enabled = False
            Me.TextBoxFecha_Ing.Enabled = False
            Me.TextBoxCelular.Enabled = False
            Me.TextBoxCasa.Enabled = False
            Me.TextBoxDireccion.Enabled = False
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information, "Campos Vacìos")
            'controlError.SetError(Me.TextBoxCedula, "La Cedula es obligatoria")
            'controlError.SetError(Me.TextBoxNombre, "El Nombre es obligatorio")
            'controlError.SetError(Me.TextBoxApellido, "El Apellido es obligatorio")
            'controlError.SetError(Me.TextBoxCasa, "El N° de casa es obligatorio")
            'controlError.SetError(Me.TextBoxCelular, "El N° de celular es obligatorio")
            'controlError.SetError(Me.TextBoxDireccion, "La Dirección es obligatoria")

        End If
    End Sub
    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxFecha_Nac.Text = ""
        Me.TextBoxFecha_Ing.Text = ""
        Me.TextBoxCelular.Clear()
        Me.TextBoxCasa.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxApellido.Enabled = False
        Me.TextBoxFecha_Nac.Enabled = False
        Me.TextBoxFecha_Ing.Enabled = False
        Me.TextBoxCelular.Enabled = False
        Me.TextBoxCasa.Enabled = False
        Me.TextBoxDireccion.Enabled = False
        Me.Close()
    End Sub
    Private Sub TextBoxNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNombre.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxApellido.Focus()
        End If
    End Sub
    Private Sub TextBoxApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxApellido.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxFecha_Nac.Focus()
        End If
    End Sub
    Private Sub TextBoxFecha_Nac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxFecha_Ing.Focus()
        End If
    End Sub
    Private Sub TextBoxFecha_Ing_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxCelular.Focus()
        End If
    End Sub

    Private Sub TextBoxCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCelular.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxCasa.Focus()
        End If
    End Sub
    Private Sub TextBoxCasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCasa.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.TextBoxDireccion.Focus()
        End If
    End Sub
    Private Sub TextBoxDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDireccion.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Me.ButtonGuardar.Focus()
        End If
    End Sub

    Private Sub TextBoxCedula_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCedula.MarginChanged

    End Sub
    'Private Sub Controles(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxApellido.LostFocus, TextBoxNombre.LostFocus, TextBoxCedula.LostFocus, TextBoxCasa.LostFocus, TextBoxCelular.LostFocus, TextBoxDireccion.LostFocus
    '    If sender.text.trim = "" Then
    '    Else
    '        controlError.SetError(sender, "")
    '    End If
    'End Sub

    Private Sub TextBoxCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCedula.TextChanged

    End Sub
End Class