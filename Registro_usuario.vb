Public Class Registro_usuario
    Dim accion As String
    Dim posicion As Integer
    Dim numeroFilas As Integer

    Private Sub Registro_usuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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


    Private Sub Registro_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetRegistroUsuario.Clear()
        Me.OleDbDataAdapterRegistroUsuario.Fill(Me.DataSetRegistroUsuario)
        numeroFilas = BindingContext(Me.DataSetRegistroUsuario, "dbo_Usuario").Count
        Me.Text = "Registro de Usuario                    DiVal I&F                  *** Sesion Iniciada: " + UsuarioIniciado
        Me.KeyPreview = True
    End Sub
    '**********FUNCION BUSCAR CODIGO******************
    Private Function BuscarCodigo(ByVal codigobuscado As String) As Boolean
        Dim p, codigo As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetRegistroUsuario, "dbo_Usuario").Position() = p
            codigo = Me.DataSetRegistroUsuario.dbo_Usuario(p).Codigo
            If codigo = codigobuscado Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function posicionFila() As Integer
        Dim nombre As String
        Dim p As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetRegistroUsuario, "dbo_Usuario").Position() = p
            nombre = Me.DataSetRegistroUsuario.dbo_Usuario(p).Nombre
            If nombre = Me.TextBoxNombre.Text Then
                Exit For
            End If
        Next
        Return p
    End Function

    '************BUSCAR EL CODIGO EN EL TEXTBOXCODIGO***************
    Private Sub TextBoxCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCodigo.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Dim codigobuscado As String
            codigobuscado = Convert.ToInt32(Me.TextBoxCodigo.Text)
            Dim res As DataRow
            res = Me.DataSetRegistroUsuario.dbo_Usuario.Rows.Find(codigobuscado)
            If Not (res Is Nothing) Then
                Me.TextBoxCodigo.Enabled = False
                Me.TextBoxNombre.Text = res(1)
                Me.TextBoxLogin.Text = res(2)
                Me.TextBoxPassword.Text = res(3)
                Me.TextBoxConfirmarPassword.Text = res(3)
                Me.TextBoxPregunta.Text = res(4)
                Me.TextBoxRespuesta.Text = res(5)
                posicion = posicionFila()
                Me.ButtonModificar.Enabled = True
                Me.ButtonEliminar.Enabled = True
                Me.ButtonCancelar.Enabled = True
            Else
                MsgBox("No se ha encontrado el usuario con el codigo " & codigobuscado, MsgBoxStyle.Information, "Buscar")
                Me.TextBoxCodigo.Clear()
                Me.TextBoxCodigo.Enabled = False
                Me.ButtonNuevo.Enabled = True
                Me.ButtonBuscar.Enabled = True
                Me.ButtonCancelar.Enabled = False
            End If
        End If
    End Sub

    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click
        accion = "Agregar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxNombre.Clear()
        Me.TextBoxLogin.Clear()
        Me.TextBoxPassword.Clear()
        Me.TextBoxConfirmarPassword.Clear()
        Me.TextBoxPregunta.Clear()
        Me.TextBoxRespuesta.Clear()
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxNombre.Focus()
        Me.TextBoxLogin.Enabled = True
        Me.TextBoxPassword.Enabled = True
        Me.TextBoxConfirmarPassword.Enabled = True
        Me.TextBoxPregunta.Enabled = True
        Me.TextBoxRespuesta.Enabled = True
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        accion = "Buscar"
        Me.ButtonNuevo.Enabled = False
        Me.ButtonBuscar.Enabled = False
        Me.ButtonCancelar.Enabled = True
        Me.TextBoxNombre.Clear()
        Me.TextBoxLogin.Clear()
        Me.TextBoxPassword.Clear()
        Me.TextBoxConfirmarPassword.Clear()
        Me.TextBoxPregunta.Clear()
        Me.TextBoxRespuesta.Clear()
        Me.TextBoxCodigo.Enabled = True
        Me.TextBoxCodigo.Focus()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        If Me.TextBoxNombre.Text <> "" And Me.TextBoxLogin.Text <> "" And Me.TextBoxPassword.Text <> "" And Me.TextBoxPregunta.Text <> "" And Me.TextBoxRespuesta.Text <> "" Then
            If Me.TextBoxPassword.Text = Me.TextBoxConfirmarPassword.Text Then
                If accion = "Agregar" Then

                    Dim Fila As DataRow
                    Fila = Me.DataSetRegistroUsuario.dbo_Usuario.NewRow
                    Fila(1) = Me.TextBoxNombre.Text
                    Fila(2) = Me.TextBoxLogin.Text
                    Fila(3) = Me.TextBoxPassword.Text
                    Fila(4) = Me.TextBoxPregunta.Text
                    Fila(5) = Me.TextBoxRespuesta.Text
                    Try
                        Me.DataSetRegistroUsuario.dbo_Usuario.Rows.Add(Fila)
                        Me.OleDbDataAdapterRegistroUsuario.Update(Me.DataSetRegistroUsuario, "dbo_Usuario")
                        Me.DataSetRegistroUsuario.dbo_Usuario.AcceptChanges()
                    Catch ex As Exception
                        MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                    End Try
                Else
                    If accion = "Modificar" Then
                        Try
                            Me.DataSetRegistroUsuario.dbo_Usuario(posicion).Nombre = Me.TextBoxNombre.Text
                            Me.DataSetRegistroUsuario.dbo_Usuario(posicion).Login = Me.TextBoxLogin.Text
                            Me.DataSetRegistroUsuario.dbo_Usuario(posicion).Password = Me.TextBoxPassword.Text
                            Me.DataSetRegistroUsuario.dbo_Usuario(posicion).Pregunta = Me.TextBoxPregunta.Text
                            Me.DataSetRegistroUsuario.dbo_Usuario(posicion).Respuesta = Me.TextBoxRespuesta.Text
                            Me.OleDbDataAdapterRegistroUsuario.Update(Me.DataSetRegistroUsuario, "dbo_Usuario")
                            Me.DataSetRegistroUsuario.dbo_Usuario.AcceptChanges()
                        Catch ex As Exception
                            MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Guardar")
                        End Try
                    End If
                End If

                Me.DataSetRegistroUsuario.Clear()
                Me.OleDbDataAdapterRegistroUsuario.Fill(Me.DataSetRegistroUsuario)
                numeroFilas = Me.BindingContext(Me.DataSetRegistroUsuario, "dbo_Usuario").Count
                If accion = "Agregar" Then
                    Me.TextBoxCodigo.Text = Me.DataSetRegistroUsuario.dbo_Usuario(numeroFilas - 1).Codigo
                    MsgBox("Usuario agregado satisfactoriamente con el Còdigo " & Convert.ToString(Me.TextBoxCodigo.Text), MsgBoxStyle.Information, "Agregado")
                Else
                    MsgBox("Usuario modificado satisfactoriamente", MsgBoxStyle.Information, "Modificado")
                End If
                Me.ButtonNuevo.Enabled = True
                Me.ButtonBuscar.Enabled = True
                Me.ButtonModificar.Enabled = False
                Me.ButtonGuardar.Enabled = False
                Me.ButtonEliminar.Enabled = False
                Me.ButtonCancelar.Enabled = False
                Me.TextBoxCodigo.Clear()
                Me.TextBoxNombre.Clear()
                Me.TextBoxLogin.Clear()
                Me.TextBoxPassword.Clear()
                Me.TextBoxConfirmarPassword.Clear()
                Me.TextBoxPregunta.Clear()
                Me.TextBoxRespuesta.Clear()
                Me.TextBoxCodigo.Enabled = False
                Me.TextBoxNombre.Enabled = False
                Me.TextBoxLogin.Enabled = False
                Me.TextBoxPassword.Enabled = False
                Me.TextBoxConfirmarPassword.Enabled = False
                Me.TextBoxPregunta.Enabled = False
                Me.TextBoxRespuesta.Enabled = False
            Else
                MsgBox("La confirmación de la contraseña no coincide", MsgBoxStyle.Critical, "Error")
                Me.TextBoxPassword.Clear()
                Me.TextBoxConfirmarPassword.Clear()
                Me.TextBoxPassword.Focus()
            End If
        Else
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information, "Campos Vacìos")
        End If
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        accion = "Modificar"
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = True
        Me.TextBoxNombre.Enabled = True
        Me.TextBoxLogin.Enabled = True
        Me.TextBoxPassword.Enabled = True
        Me.TextBoxConfirmarPassword.Enabled = True
        Me.TextBoxPregunta.Enabled = True
        Me.TextBoxRespuesta.Enabled = True
        Me.TextBoxNombre.Focus()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCodigo.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxLogin.Clear()
        Me.TextBoxPassword.Clear()
        Me.TextBoxConfirmarPassword.Clear()
        Me.TextBoxPregunta.Clear()
        Me.TextBoxRespuesta.Clear()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxLogin.Enabled = False
        Me.TextBoxPassword.Enabled = False
        Me.TextBoxConfirmarPassword.Enabled = False
        Me.TextBoxPregunta.Enabled = False
        Me.TextBoxRespuesta.Enabled = False
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Me.ButtonEliminar.Enabled = False
        Me.ButtonModificar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Dim resp As DialogResult
        resp = MsgBox("¿Seguro que desea eliminar este usuario?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar")
        If resp = DialogResult.Yes Then
            Try
                Me.DataSetRegistroUsuario.dbo_Usuario.Rows(posicion).Delete()
                Me.OleDbDataAdapterRegistroUsuario.Update(Me.DataSetRegistroUsuario, "dbo_Usuario")
                Me.DataSetRegistroUsuario.dbo_Usuario.AcceptChanges()
                numeroFilas = Me.BindingContext(Me.DataSetRegistroUsuario, "dbo_Usuario").Count
                MsgBox("El usuario ha sido eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminado")
            Catch ex As Exception
                MsgBox("Error: " & Convert.ToString(ex), MsgBoxStyle.Information, "Eliminar")
            End Try
        End If
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.TextBoxCodigo.Clear()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxNombre.Clear()
        Me.TextBoxLogin.Clear()
        Me.TextBoxPassword.Clear()
        Me.TextBoxConfirmarPassword.Clear()
        Me.TextBoxPregunta.Clear()
        Me.TextBoxRespuesta.Clear()
    End Sub

    Private Sub TextBoxPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxPassword.TextChanged
        Me.TextBoxConfirmarPassword.Text = ""
    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Me.ButtonNuevo.Enabled = True
        Me.ButtonBuscar.Enabled = True
        Me.ButtonModificar.Enabled = False
        Me.ButtonGuardar.Enabled = False
        Me.ButtonEliminar.Enabled = False
        Me.ButtonCancelar.Enabled = False
        Me.TextBoxCodigo.Clear()
        Me.TextBoxNombre.Clear()
        Me.TextBoxLogin.Clear()
        Me.TextBoxPassword.Clear()
        Me.TextBoxConfirmarPassword.Clear()
        Me.TextBoxPregunta.Clear()
        Me.TextBoxRespuesta.Clear()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxLogin.Enabled = False
        Me.TextBoxPassword.Enabled = False
        Me.TextBoxConfirmarPassword.Enabled = False
        Me.TextBoxPregunta.Enabled = False
        Me.TextBoxRespuesta.Enabled = False
        Me.Close()
    End Sub
End Class