Public Class Recuperar_Password
    Dim posicion As Integer
    Dim numeroFilas As Integer
    Dim filaencontrada As DataRow
    

    Private Sub Recuperar_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSetRecuperarP().Clear()
        Me.OleDbDataAdapterRecuperarP().Fill(Me.DataSetRecuperarP)
        numeroFilas = BindingContext(Me.DataSetRecuperarP, "dbo_Usuario").Count
        filaencontrada = Me.DataSetRecuperarP.dbo_Usuario.Rows.Find(codigo)
        If Not filaencontrada Is Nothing Then
            Me.TextBoxLogin.Text = filaencontrada(2)
            Me.TextBoxPregunta.Text = filaencontrada(4)
            posicion = posicionFila()
        End If
    End Sub
    Private Function posicionFila() As Integer
        Dim nombre As String
        Dim p As Integer
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetRecuperarP, "dbo_Usuario").Position() = p
            nombre = Me.DataSetRecuperarP.dbo_Usuario(p).Codigo
            If nombre = Me.TextBoxLogin.Text Then
                Exit For
            End If
        Next
        Return p
    End Function

    Private Sub ButtonRecuperarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRecuperarC.Click
        Dim existe As Boolean
        existe = BuscarRepta(Me.TextBoxRespuesta.Text)
        If existe Then
            filaencontrada = Me.DataSetRecuperarP.dbo_Usuario.Rows.Find(codigo)
            MsgBox("Password recuperado", MsgBoxStyle.Information, "Recuperado")
            If Not filaencontrada Is Nothing Then
                Me.TextBoxPassword.Text = filaencontrada(3)
                posicion = posicionFila()
            End If
        Else
            MsgBox("La respuesta " & Me.TextBoxRespuesta.Text & "  es incorrecta", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    ''*********FUNCION BUSCAR la respuesta***************
    Private Function BuscarRepta(ByVal ReptaBuscada As String) As Boolean
        Dim p As Integer
        Dim Repta As String
        For p = 0 To (numeroFilas - 1)
            Me.BindingContext(Me.DataSetRecuperarP, "dbo_Usuario").Position() = p
            Repta = Me.DataSetRecuperarP.dbo_Usuario(p).Respuesta
            If Repta = ReptaBuscada Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ButtonVolverI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolverI.Click
        Me.Close()
        Me.TextBoxLogin.Text = ""
        Me.TextBoxPassword.Text = ""
        Me.TextBoxPregunta.Text = ""
        Me.TextBoxRespuesta.Text = ""
    End Sub
End Class