Public Class Servicio
    Dim accion As String
    Dim posicion As Integer
    Dim numeroFilas As Integer

    Private Sub Servicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
        If e.KeyCode = 118 Then
            Call ButtonSalir_Click(ButtonSalir, e)
        End If
    End Sub
    Private Sub Servicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetServicio511.Clear()
        Me.OleDbDataAdapter11.Fill(Me.DataSetServicio511)
        numeroFilas = BindingContext(Me.DataSetServicio511, "dbo_Servicio").Count
        Me.Text = "Registro de Servicio                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
        Me.KeyPreview = True
    End Sub
    Private Function posicionFila() As Integer
        Dim p As Integer
        Dim codigo As String
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetServicio511, "dbo_Servicio").Position() = p
            codigo = Me.DataSetServicio511.dbo_Servicio(p).Codigo
            If codigo = Me.TextBoxCodigo.Text Then
                Exit For
            End If
        Next
        Return p
    End Function
    Private Function BuscarNombre(ByVal NombreBuscado As String) As Boolean
        Dim p As Integer
        Dim Descripcion As String
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetServicio511, "dbo_Servicio").Position() = p
            Descripcion = Me.DataSetServicio511.dbo_Servicio(p).Descripcion
            If Descripcion = NombreBuscado Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click
        accion = "Agregar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxCodigo.Clear()
        Me.TextBoxDescripcion.Clear()
        Me.TextBoxPrecio.Clear()
        'Me.TextBoxCodigo.Enabled = True
        'Me.TextBoxCodigo.Focus()
        Me.TextBoxDescripcion.Enabled = True
        Me.TextBoxDescripcion.Focus()
    End Sub
    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        accion = "Buscar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.TextBoxCodigo.Clear()
        Me.TextBoxDescripcion.Clear()
        Me.TextBoxPrecio.Clear()
        Me.TextBoxCodigo.Enabled = True
        Me.TextBoxCodigo.Focus()
    End Sub
    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        accion = "Modificar"
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxDescripcion.Enabled = True
        Me.TextBoxPrecio.Enabled = True
        Me.TextBoxDescripcion.Focus()
    End Sub
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCodigo.Clear()
        Me.TextBoxDescripcion.Clear()
        Me.TextBoxPrecio.Clear()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxDescripcion.Enabled = False
        Me.TextBoxPrecio.Enabled = False
    End Sub
    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Dim resp As DialogResult
        resp = MsgBox("¿Seguro que desea eliminar este Servicio?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar")
        If resp = DialogResult.Yes Then
            Try
                Me.DataSetServicio511.dbo_Servicio.Rows(posicion).Delete()
                Me.OleDbDataAdapter11.Update(Me.DataSetServicio511, "dbo_Servicio")
                Me.DataSetServicio511.dbo_Servicio.AcceptChanges()
                numeroFilas = Me.BindingContext(Me.DataSetServicio511, "dbo_Servicio").Count
                MsgBox("El Servicio ha sido eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminado")
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        Else
            MsgBox("El Servicio no ha sido eliminado", MsgBoxStyle.Information, "Cancelar")
        End If
        Call Me.ButtonCancelar_Click(ButtonCancelar, e)
    End Sub

    Private Sub TextBoxCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCodigo.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            If Me.TextBoxCodigo.Text <> "" Then
                Dim codigobuscado As String
                codigobuscado = (Me.TextBoxCodigo.Text)
                Dim res As DataRow
                res = Me.DataSetServicio511.dbo_Servicio.Rows.Find(codigobuscado)
                If Not (res Is Nothing) Then
                    Me.TextBoxCodigo.Enabled = False
                    Me.TextBoxDescripcion.Text = res(1)
                    Me.TextBoxPrecio.Text = res(2)
                    posicion = posicionFila()
                    Me.ButtonModificar.Enabled = True
                    Me.ButtonEliminar.Enabled = True
                    Me.ButtonCancelar.Enabled = True
                Else
                    MsgBox("No se ha encontrado un Servicio con el Código " & codigobuscado, MsgBoxStyle.Information, "Buscar")
                    Me.TextBoxCodigo.Clear()
                    Me.TextBoxCodigo.Enabled = False
                    Me.ButtonNuevo.Enabled = True
                    Me.ButtonBuscar.Enabled = True
                    Me.ButtonCancelar.Enabled = False
                End If
            Else
                MsgBox("Por favor ingrese un Código", MsgBoxStyle.Exclamation, "Campo Vacio")
            End If
        End If
    End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        If Me.TextBoxDescripcion.Text <> "" And Me.TextBoxPrecio.Text <> "" Then
            If accion = "Agregar" Then
                Dim Fila As DataRow
                Fila = Me.DataSetServicio511.dbo_Servicio.NewRow
                'Fila(0) = Me.TextBoxCodigo.Text
                Fila(1) = Me.TextBoxDescripcion.Text
                Fila(2) = Me.TextBoxPrecio.Text
                Try
                    Me.DataSetServicio511.dbo_Servicio.Rows.Add(Fila)
                    Me.OleDbDataAdapter11.Update(Me.DataSetServicio511, "dbo_Servicio")
                    Me.DataSetServicio511.dbo_Servicio.AcceptChanges()
                Catch ex As Exception
                    MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                End Try
            Else
                If accion = "Modificar" Then
                    Dim x As Decimal
                    x = Me.TextBoxPrecio.Text
                    'Try
                    'Me.DataSetServicio.Servicio(posicion).Codigo = Me.TextBoxCodigo.Text
                    Me.DataSetServicio511.dbo_Servicio(posicion).Descripcion = Me.TextBoxDescripcion.Text
                    Me.DataSetServicio511.dbo_Servicio(posicion).Precio = Me.TextBoxPrecio.Text
                    'Me.DataSetServicio51.dbo_Servicio(posicion).Precio = x
                    Me.OleDbDataAdapter11.Update(Me.DataSetServicio511, "dbo_Servicio")
                    Me.DataSetServicio511.dbo_Servicio.AcceptChanges()
                    'Catch ex As Exception
                    '    MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                    'End Try
                End If
            End If
            Me.DataSetServicio511.Clear()
            Me.OleDbDataAdapter11.Fill(Me.DataSetServicio511)
            numeroFilas = Me.BindingContext(Me.DataSetServicio511, "dbo_Servicio").Count
            If accion = "Agregar" Then
                Me.TextBoxCodigo.Text = Me.DataSetServicio511.dbo_Servicio(numeroFilas - 1).Codigo
                MsgBox("Servicio agregado satisfactoriamente con el Código " & Convert.ToString(Me.TextBoxCodigo.Text), MsgBoxStyle.Information, "Agregado")
            Else
                MsgBox("Servicio modificado satisfactoriamente", MsgBoxStyle.Information, "Modificado")
            End If
            Me.ButtonNuevo.Enabled = True
            Me.ButtonBuscar.Enabled = True
            Me.ButtonModificar.Enabled = False
            Me.ButtonGuardar.Enabled = False
            Me.ButtonEliminar.Enabled = False
            Me.ButtonCancelar.Enabled = False
            Me.TextBoxCodigo.Clear()
            Me.TextBoxDescripcion.Clear()
            Me.TextBoxPrecio.Clear()
            Me.TextBoxCodigo.Enabled = False
            Me.TextBoxDescripcion.Enabled = False
            Me.TextBoxPrecio.Enabled = False
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information, "Campos Vacìos")
        End If
    End Sub

    Private Sub TextBoxCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCodigo.TextChanged
        Me.TextBoxCodigo.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCodigo.Clear()
        Me.TextBoxDescripcion.Clear()
        Me.TextBoxPrecio.Clear()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxDescripcion.Enabled = False
        Me.TextBoxPrecio.Enabled = False
        Me.Close()
    End Sub
    Private Sub TextBoxPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxPrecio.LostFocus
        Me.TextBoxPrecio.Text = Replace(Me.TextBoxPrecio.Text, ".", ",")
    End Sub

    Private Sub TextBoxPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPrecio.TextChanged
    End Sub

    Private Sub TextBoxDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDescripcion.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            If Me.TextBoxDescripcion.Text <> "" Then
                Dim existe As Boolean
                existe = BuscarNombre(Me.TextBoxDescripcion.Text)
                If existe Then
                    MsgBox("El servicio " & Me.TextBoxDescripcion.Text & "  ya existe, por favor cambie el nombre", MsgBoxStyle.Exclamation, "Error")
                    Me.TextBoxDescripcion.Clear()
                    Me.TextBoxDescripcion.Focus()
                Else
                    Me.TextBoxPrecio.Enabled = True
                    Me.TextBoxPrecio.Focus()
                End If
            Else
                MsgBox("Escriba una descripción y presione la tecla Enter", MsgBoxStyle.Information, "Campo Vacio")
            End If
        End If
    End Sub
End Class