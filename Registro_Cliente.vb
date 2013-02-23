Public Class Registro_Cliente
    Dim accion As String
    Dim posicion As Integer
    Dim numeroFilas As Integer

    Private Sub Registro_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetCliente.Clear()
        Me.SqlDataAdapterCliente.Fill(Me.DataSetCliente)
        numeroFilas = BindingContext(Me.DataSetCliente, "Cliente").Count
        Me.Text = "Registro de Cliente                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
    End Sub
    Private Function posicionFila() As Integer
        Dim p, codigo As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetCliente, "Cliente").Position() = p
            codigo = Me.DataSetCliente.Cliente(p).Cedula_Rif
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
        Me.TextBoxCiudad.Clear()
        Me.TextBoxTelefono.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxCedula.Focus()
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxApellido.Enabled = True
        Me.TextBoxCiudad.Enabled = True
        Me.TextBoxTelefono.Enabled = True
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
        Me.TextBoxCiudad.Clear()
        Me.TextBoxTelefono.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxCedula.Focus()
    End Sub
    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        accion = "Modificar"
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxCedula.Enabled = True
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxApellido.Enabled = True
        Me.TextBoxCiudad.Enabled = True
        Me.TextBoxTelefono.Enabled = True
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
        Me.TextBoxCiudad.Clear()
        Me.TextBoxTelefono.Clear()
        Me.TextBoxDireccion.Clear()
        Me.TextBoxCedula.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxApellido.Enabled = False
        Me.TextBoxCiudad.Enabled = False
        Me.TextBoxTelefono.Enabled = False
        Me.TextBoxDireccion.Enabled = False
    End Sub
    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Dim resp As DialogResult
        resp = MsgBox("¿Seguro que desea eliminar este cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar")
        If resp = DialogResult.Yes Then
            Try
                Me.DataSetCliente.Cliente.Rows(posicion).Delete()
                Me.SqlDataAdapterCliente.Update(Me.DataSetCliente, "Cliente")
                Me.DataSetCliente.Cliente.AcceptChanges()
                numeroFilas = Me.BindingContext(Me.DataSetCliente, "Cliente").Count
                MsgBox("El cliente ha sido eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminado")
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        End If
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.TextBoxCedula.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxApellido.Clear()
        Me.TextBoxCiudad.Clear()
        Me.TextBoxTelefono.Clear()
        Me.TextBoxDireccion.Clear()
    End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        If Me.TextBoxCedula.Text <> "" And Me.TextBoxNombre.Text <> "" And Me.TextBoxApellido.Text <> "" And Me.TextBoxCiudad.Text <> "" And Me.TextBoxTelefono.Text <> "" And Me.TextBoxDireccion.Text <> "" Then
            If accion = "Agregar" Then

                Dim Fila As DataRow
                Fila = Me.DataSetCliente.Cliente.NewRow
                Fila(0) = Me.TextBoxCedula.Text
                Fila(1) = Me.TextBoxNombre.Text
                Fila(2) = Me.TextBoxApellido.Text
                Fila(3) = Me.TextBoxCiudad.Text
                Fila(4) = Me.TextBoxTelefono.Text
                Fila(5) = Me.TextBoxDireccion.Text
                Try
                    Me.DataSetCliente.Cliente.Rows.Add(Fila)
                    Me.SqlDataAdapterCliente.Update(Me.DataSetCliente, "Cliente")
                    Me.DataSetCliente.Cliente.AcceptChanges()
                Catch ex As Exception
                    MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                End Try
            Else
                If accion = "Modificar" Then
                    Try
                        Me.DataSetCliente.Cliente(posicion).Cedula_Rif = Me.TextBoxCedula.Text
                        Me.DataSetCliente.Cliente(posicion).Nombre = Me.TextBoxNombre.Text
                        Me.DataSetCliente.Cliente(posicion).Apellido = Me.TextBoxApellido.Text
                        Me.DataSetCliente.Cliente(posicion).Ciudad = Me.TextBoxCiudad.Text
                        Me.DataSetCliente.Cliente(posicion).Telefono = Me.TextBoxTelefono.Text
                        Me.DataSetCliente.Cliente(posicion).Direccion = Me.TextBoxDireccion.Text
                        Me.SqlDataAdapterCliente.Update(Me.DataSetCliente, "Cliente")
                        Me.DataSetCliente.Cliente.AcceptChanges()
                    Catch ex As Exception
                        MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                    End Try
                End If
            End If

            Me.DataSetCliente.Clear()
            Me.SqlDataAdapterCliente.Fill(Me.DataSetCliente)
            numeroFilas = Me.BindingContext(Me.DataSetCliente, "Cliente").Count
            If accion = "Agregar" Then
                Me.TextBoxCedula.Text = Me.DataSetCliente.Cliente(numeroFilas - 1).Cedula_Rif
                MsgBox("Cliente agregado satisfactoriamente", MsgBoxStyle.Information, "Agregado")
            Else
                MsgBox("Cliente modificado satisfactoriamente", MsgBoxStyle.Information, "Modificado")
            End If
            Me.ButtonNuevo.Enabled = True
            Me.ButtonBuscar.Enabled = True
            Me.ButtonModificar.Enabled = False
            Me.ButtonGuardar.Enabled = False
            Me.ButtonEliminar.Enabled = False
            Me.ButtonCancelar.Enabled = False
            Me.TextBoxCedula.Clear()
            Me.TextBoxNombre.Clear()
            Me.TextBoxApellido.Clear()
            Me.TextBoxCiudad.Clear()
            Me.TextBoxTelefono.Clear()
            Me.TextBoxDireccion.Clear()
            Me.TextBoxCedula.Enabled = False
            Me.TextBoxNombre.Enabled = False
            Me.TextBoxApellido.Enabled = False
            Me.TextBoxCiudad.Enabled = False
            Me.TextBoxTelefono.Enabled = False
            Me.TextBoxDireccion.Enabled = False
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information, "Campos Vacìos")
        End If
    End Sub

    Private Sub TextBoxCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCedula.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Dim codigobuscado As String
            codigobuscado = Convert.ToInt32(Me.TextBoxCedula.Text)
            Dim res As DataRow
            res = Me.DataSetCliente.Cliente.Rows.Find(codigobuscado)
            If Not (res Is Nothing) Then
                Me.TextBoxCedula.Enabled = False
                Me.TextBoxNombre.Text = res(1)
                Me.TextBoxApellido.Text = res(2)
                Me.TextBoxCiudad.Text = res(3)
                Me.TextBoxTelefono.Text = res(4)
                Me.TextBoxDireccion.Text = res(5)
                posicion = posicionFila()
                Me.ButtonModificar.Enabled = True
                Me.ButtonEliminar.Enabled = True
                Me.ButtonCancelar.Enabled = True
            Else
                MsgBox("No se ha encontrado el cliente con la cedula " & codigobuscado, MsgBoxStyle.Information, "Buscar")
                Me.TextBoxCedula.Clear()
                Me.TextBoxCedula.Enabled = False
                Me.ButtonNuevo.Enabled = True
                Me.ButtonBuscar.Enabled = True
                Me.ButtonCancelar.Enabled = False
            End If
        End If
    End Sub
End Class