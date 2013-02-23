Public Class Inicio_Sesion
    Dim Posicion As Integer
    Dim NumeroFilas As Integer

    Private Sub Inicio_Sesion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Call ButtonCancelar_Click(ButtonCancelar, e)
        End If
    End Sub
    ' Dim menup As New Menu_Principal
    'Dim rec As New Recuperar_Password
    Private Sub Inicio_Sesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetInicioSesion().Clear()
        Me.OleDbDataAdapterInicioSesion().Fill(Me.DataSetInicioSesion)
        NumeroFilas = BindingContext(Me.DataSetInicioSesion, "dbo_Usuario").Count
        Me.ComboBoxLogin.Text = ""
        Me.KeyPreview = True
    End Sub
    '**********FUNCION POSICION FILA**************
    Private Function PosicionFila() As Integer
        Dim codigo, p As Integer
        For p = 0 To (NumeroFilas - 1)
            Me.BindingContext(Me.DataSetInicioSesion, "dbo_Usuario").Position() = p
            codigo = Me.DataSetInicioSesion.dbo_Usuario(p).Password
            If codigo = Me.TextBoxPassword.Text Then
                Exit For
            End If
        Next
        Return p
    End Function
    ''*********FUNCION BUSCAR EL LOGIN***************
    'Private Function BuscarLogin(ByVal LoginBuscado As String) As Boolean
    '    Dim p As Integer
    '    Dim Login As String
    '    For p = 0 To (NumeroFilas - 1)
    '        Me.BindingContext(Me.DataSetInicioSesion, "Usuario").Position() = p
    '        Login = Me.DataSetInicioSesion.Usuario(p).Login
    '        If Login = LoginBuscado Then
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function

    '*********FUNCION BUSCAR PASSWORD*****************
    Private Function BuscarPass(ByVal PassBuscado As String) As Boolean
        Dim p As Integer
        Dim pass As String
        For p = 0 To (NumeroFilas - 1)
            Me.BindingContext(Me.DataSetInicioSesion, "dbo_Usuario").Position() = p
            pass = Me.DataSetInicioSesion.dbo_Usuario(p).Password
            If pass = PassBuscado Then
                Return True
            End If
        Next
        Return False
    End Function

    '**********KEYPRESS CAJA LOGIN*************
    

    '***********KEYPRESS CAJA PASSWORD***********
    Private Sub TextBoxPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            Dim existe As Boolean
            existe = BuscarPass(Me.TextBoxPassword.Text)
            If existe Then
                Me.TextBoxPassword.Enabled = False
                Me.ButtonEntrar.Enabled = True
                Me.ButtonEntrar.Focus()
            Else
                MsgBox("El password es incorrecto", MsgBoxStyle.Critical, "Error password")
                Me.TextBoxPassword.Clear()
                Me.ComboBoxLogin.Text = ""
                Me.ComboBoxLogin.Focus()
                'Me.TextBoxPassword.Focus()
            End If
        End If
    End Sub

    Private Sub ButtonEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEntrar.Click
        MsgBox("Bienvenido " & Me.ComboBoxLogin.Text & " al Sistema", MsgBoxStyle.Exclamation, "Bienvenido")
        UsuarioIniciado = Me.ComboBoxLogin.Text
        Menu_Principal.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        If Me.ComboBoxLogin.Text = "" Then
            MsgBox("Debe seleccionar primero un usuario para recuperar la contraseña", MsgBoxStyle.Critical, "Error: Seleccione usuario")
            Me.ComboBoxLogin.Focus()
        Else
            Dim resp As DialogResult
            resp = MsgBox("¿Desea recuperar el password?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Recuperar Password")
            If resp = DialogResult.Yes Then
                codigo = 0
                codigo = Me.TextBoxCodigo.Text
                Recuperar_Password.ShowDialog()
            End If
        End If
       
    End Sub

    Private Sub ComboBoxLogin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxLogin.SelectedIndexChanged
        Me.TextBoxCodigo.Text = Me.ComboBoxLogin.SelectedValue
        Me.TextBoxPassword.Enabled = True
        Me.TextBoxPassword.Focus()

    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Dim resp As DialogResult
        resp = MsgBox("¿Desea salir realmente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If resp = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPassword.TextChanged

    End Sub
End Class
