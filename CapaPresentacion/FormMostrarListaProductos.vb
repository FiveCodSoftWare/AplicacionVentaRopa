Imports CapaPersistencia

Public Class FormMostrarListaProductos

    Private dt As New DataTable
    Private Sub FormMostrarListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()

        Try
            Dim func As New ProductoDAO
            dt = func.mostrar
            dataListadoProducto.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListadoProducto.DataSource = dt
                txtBuscar.Enabled = True
                dataListadoProducto.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dataListadoProducto.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListadoProducto.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception


            MessageBox.Show("Error al intentar mostrar", "Sistema Venta de Ropa" + ex.Message)



        End Try

        buscar()
    End Sub

    Private Sub buscar()


        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                dataListadoProducto.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                dataListadoProducto.DataSource = Nothing
            End If

        Catch ex As Exception

            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)


        End Try


    End Sub
    Private Sub ocultar_columnas()

        dataListadoProducto.Columns(2).Visible = False


        dataListadoProducto.Columns(4).Visible = False
        dataListadoProducto.Columns(5).Visible = False
        'dataListadoProducto.Columns(6).Visible = False
        ' dataListadoProducto.Columns(7).Visible = False
        ' dataListadoProducto.Columns(8).Visible = False
        dataListadoProducto.Columns(9).Visible = False
        ' dataListadoProducto.Columns(10).Visible = False
        dataListadoProducto.Columns(11).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dataListadoProducto_DoubleClick(sender As Object, e As EventArgs) Handles dataListadoProducto.DoubleClick
        If txtflag.Text = "1" Then
            FormDetalleVentaProducto.txtCodigoProducto.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Codigo").Value)
            FormDetalleVentaProducto.txtNombreProducto.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Nombre").Value)
            FormDetalleVentaProducto.txtStock.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Stock").Value)
            FormDetalleVentaProducto.txtPrecio.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Precio Venta").Value)
            Me.Close()
        End If
    End Sub
End Class