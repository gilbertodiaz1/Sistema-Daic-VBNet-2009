Imports Excel = Microsoft.Office.Interop.Excel
Imports Sistema_de_Inventario_y_Facturación._DivalI_FDataSet
Imports Sistema_de_Inventario_y_Facturación._DivalI_FDataSet1
Imports Sistema_de_Inventario_y_Facturación._DivalI_FDataSet2
Imports Sistema_de_Inventario_y_Facturación._DivalI_FDataSet3

Public Class Reportes

    Private Sub Reportes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Call Button1_Click(Button1, e)
        End If
    End Sub

    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet4.dbo_Empleado_Ganancias' Puede moverla o quitarla según sea necesario.
        Me.Dbo_Empleado_GananciasTableAdapter.Fill(Me._DivalI_FDataSet4.dbo_Empleado_Ganancias)
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet3.dbo_Servicio' Puede moverla o quitarla según sea necesario.
        Me.Dbo_ServicioTableAdapter.Fill(Me.DataSetServicio.dbo_Servicio)
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet2.dbo_Producto' Puede moverla o quitarla según sea necesario.
        Me.Dbo_ProductoTableAdapter.Fill(Me.DataSetProducto.dbo_Producto)
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet1.dbo_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Dbo_EmpleadoTableAdapter.Fill(Me.DataSetEmpleadoR.dbo_Empleado)
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet1.dbo_Empleado' Puede moverla o quitarla según sea necesario.
        'Me.Dbo_EmpleadoTableAdapter.Fill(Me.DataSetEmpleado.dbo_Empleado)
        'TODO: esta línea de código carga datos en la tabla '_DivalI_FDataSet.dbo_Muebles' Puede moverla o quitarla según sea necesario.
        Me.Dbo_MueblesTableAdapter.Fill(Me.DataSetArticulo.dbo_Muebles)

    End Sub

    Private Sub ButtonArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonArticulo.Click
        Dim oExcel As Excel.ApplicationClass
        Dim oBooks As Excel.Workbooks
        Dim oBook As Excel.WorkbookClass
        Dim oSheet As Excel.Worksheet
        Try
            ' Inicia Excel y abre el workbook
            oExcel = CreateObject("Excel.Application")
            oExcel.Visible = True
            oBooks = oExcel.Workbooks
            oBook = oBooks.Open( _
               "C:\Sistema DiVal\Reportes\ReporteA.xlsx")
            oSheet = oBook.Sheets(1)
            Const ROW_FIRST = 10
            Dim iRow As Int64 = 1
            ' Loop que almacena los datos
            Dim rowCustomer As dbo_MueblesRow
            For Each rowCustomer In Me.DataSetArticulo.dbo_Muebles
                Dim iCurrRow As Int64 = ROW_FIRST + iRow
                oSheet.Cells(iCurrRow, 1) = rowCustomer.Codigo
                oSheet.Cells(iCurrRow, 2) = rowCustomer.Nombre
                oSheet.Cells(iCurrRow, 3) = rowCustomer.Descripcion
                oSheet.Cells(iCurrRow, 4) = rowCustomer.Cantidad
                oSheet.Cells(iCurrRow, 5) = rowCustomer.Precio
                iRow += 1
            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEmpleado.Click
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
               "C:\Sistema DiVal\Reportes\ReporteE.xlsx")
            oSheet = oBook.Sheets(1)
            Const ROW_FIRST = 10
            Dim iRow As Int64 = 1
            ' Loop que almacena los datos
            Dim rowCustomer As dbo_EmpleadoRow
            For Each rowCustomer In Me.DataSetEmpleadoR.dbo_Empleado
                Dim iCurrRow As Int64 = ROW_FIRST + iRow
                oSheet.Cells(iCurrRow, 1) = rowCustomer.Cedula
                oSheet.Cells(iCurrRow, 2) = rowCustomer.Nombre
                oSheet.Cells(iCurrRow, 3) = rowCustomer.Apellidio
                oSheet.Cells(iCurrRow, 4) = rowCustomer.Fecha_Nac
                oSheet.Cells(iCurrRow, 5) = rowCustomer.Fecha_Ing
                oSheet.Cells(iCurrRow, 6) = rowCustomer.Telefono
                oSheet.Cells(iCurrRow, 7) = rowCustomer.Movil
                oSheet.Cells(iCurrRow, 8) = rowCustomer.Direccion
                iRow += 1
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProducto.Click
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
               "C:\Sistema DiVal\Reportes\ReporteP.xlsx")

            oSheet = oBook.Sheets(1)


            Const ROW_FIRST = 10
            Dim iRow As Int64 = 1

            ' Loop que almacena los datos
            Dim rowCustomer As dbo_ProductoRow
            For Each rowCustomer In Me.DataSetProducto.dbo_Producto
                Dim iCurrRow As Int64 = ROW_FIRST + iRow
                oSheet.Cells(iCurrRow, 1) = rowCustomer.Codigo
                oSheet.Cells(iCurrRow, 2) = rowCustomer.Nombre
                oSheet.Cells(iCurrRow, 3) = rowCustomer.Descripcion
                oSheet.Cells(iCurrRow, 4) = rowCustomer.Cantidad
                oSheet.Cells(iCurrRow, 5) = rowCustomer.Precio
                iRow += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonServicio.Click
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
               "C:\Sistema DiVal\Reportes\ReporteS.xlsx")
            oSheet = oBook.Sheets(1)
            Const ROW_FIRST = 10
            Dim iRow As Int64 = 1

            ' Loop que almacena los datos
            Dim rowCustomer As dbo_ServicioRow
            For Each rowCustomer In Me.DataSetServicio.dbo_Servicio
                Dim iCurrRow As Int64 = ROW_FIRST + iRow
                oSheet.Cells(iCurrRow, 1) = rowCustomer.Codigo
                oSheet.Cells(iCurrRow, 2) = rowCustomer.Descripcion
                oSheet.Cells(iCurrRow, 3) = rowCustomer.Precio
                iRow += 1
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class