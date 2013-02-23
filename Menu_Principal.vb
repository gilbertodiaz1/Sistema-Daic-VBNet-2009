Public Class Menu_Principal
    Private Sub ToolTip1_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles ToolTipCliente.Draw
        e.DrawBackground()
        e.DrawBorder()
        Using sf As New StringFormat()
            sf.Alignment = StringAlignment.Near
            sf.LineAlignment = StringAlignment.Center
            Dim rect As New Rectangle(50, 0, e.Bounds.Width - 50, e.Bounds.Height)
            e.Graphics.DrawString(e.ToolTipText, e.Font, Brushes.Green, rect, sf)
        End Using
        e.Graphics.DrawImage(My.Resources.Cliente, 9, 9)
    End Sub
    Private Sub ToolTip1_Popup(ByVal sender As Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTipCliente.Popup
        Dim wid As Integer = e.ToolTipSize.Width + 80
        Dim hgt As Integer = e.ToolTipSize.Height
        If hgt < 80 Then hgt = 80
        e.ToolTipSize = New Size(wid, hgt)
    End Sub

    Private Sub Menu_Principal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.Refresh()
    End Sub

    Private Sub Menu_Principal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then
            Call Button7_Click(Button7, e)
        End If
        If e.KeyCode = 113 Then
            Call Button1_Click(Button1, e)
        End If
        If e.KeyCode = 114 Then
            Call Button3_Click(Button3, e)
        End If
        If e.KeyCode = 115 Then
            Call Button4_Click(Button4, e)
        End If
        If e.KeyCode = 116 Then
            Call Button5_Click(Button5, e)
        End If
        If e.KeyCode = 117 Then
            Call Button2_Click(Button2, e)
        End If
        If e.KeyCode = 118 Then
            Call Button6_Click(Button6, e)
        End If
    End Sub
    Private Sub Menu_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = "Usuario Iniciado: " + UsuarioIniciado
        Me.Timer1.Start()
        Me.ToolStripStatusLabel5.Text = "Fecha: " + System.DateTime.Now.ToLongDateString
        Me.Text = "Menú Principal                         DiVal I&F                     *** Sesion Iniciada: " + UsuarioIniciado
        Me.KeyPreview = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel3.Text = "Hora Actual: " + System.DateTime.Now.ToLongTimeString
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registro_Cliente.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Producto.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        Servicio.ShowDialog()
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónToolStripMenuItem.Click
        Registro_prodcuccion.ShowDialog()
    End Sub

    Private Sub ProducciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónToolStripMenuItem1.Click
        Consulta_Produccion.ShowDialog()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reporte_E.ShowDialog()
    End Sub

    Private Sub RegistroDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeUsuarioToolStripMenuItem.Click
        Registro_usuario.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resp As DialogResult
        resp = MsgBox("¿Desea salir realmente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If resp = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reporte_P.ShowDialog()
    End Sub

    Private Sub MueblesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MueblesToolStripMenuItem1.Click
        Muebles.ShowDialog()
    End Sub

    Private Sub MueblesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reporte_A.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Registro_Empleado.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Producto.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Registro_prodcuccion.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Servicio.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Muebles.ShowDialog()
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reporte_Servicio.ShowDialog()
    End Sub

    Private Sub GananciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GananciasToolStripMenuItem.Click
        Empleado_Ganancias.ShowDialog()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroToolStripMenuItem.Click
        Registro_Empleado.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Empleado_Ganancias.ShowDialog()
    End Sub

    Private Sub BlockDeNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockDeNotasToolStripMenuItem.Click
        Call Shell("C:\WINDOWS\NOTEPAD.EXE", AppWinStyle.NormalFocus)
    End Sub

    Private Sub MicrosoftOfficeWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MicrosoftOfficeWordToolStripMenuItem.Click
        Call Shell("C:\Archivos de programa\Microsoft Office\Office12\WINWORD.EXE", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub MicrosoftOfficeExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MicrosoftOfficeExcelToolStripMenuItem.Click
        Call Shell("C:\Archivos de programa\Microsoft Office\Office12\EXCEL.EXE", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Call Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub InternetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetToolStripMenuItem.Click
        Call Shell("C:\Archivos de programa\Internet Explorer\IEXPLORE.EXE", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Consulta_Produccion.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        Reportes.ShowDialog()
    End Sub
End Class