Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormDetalleVentaProducto
    Dim dt As New DataTable
    Dim objeto As New DetalleVentaDAO
    Private Sub FormDetalleVentaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        mostrar()
        txtCodigoDetalle.Text = objeto.generarcodigo
        inhabilitar(False)
        habilitar(False)
        Botones(True, False, True, True, False)
    End Sub



    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, quitar As Boolean, Cancelar As Boolean, buscar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnQuitar.Enabled = quitar
        btnCancelar.Enabled = Cancelar
        btnAgregarProducto.Enabled = buscar
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New DetalleVentaDAO
            dt = func.mostrar
            dataListadoVentas.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListadoVentas.DataSource = dt
                dataListadoVentas.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dataListadoVentas.DataSource = Nothing
                dataListadoVentas.ColumnHeadersVisible = False
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

            dv.RowFilter = "Codigo='" & txtCodigo.Text & "'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                dataListadoVentas.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                dataListadoVentas.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)

        End Try


    End Sub



    Private Sub ocultar_columnas()

        dataListadoVentas.Columns(0).Visible = False
        'dataListadoVentas.Columns().Visible = False
        dataListadoVentas.Columns(2).Visible = False
    End Sub
    Private Sub limpiar()
        txtCantidad.Value = 0
        txtPrecio.Text = ""
        txtCodigoProducto.Text = ""
        txtNombreProducto.Text = ""
        txtStock.Value = 0
    End Sub


    Private Sub inhabilitar(sw As Boolean)
        txtCodigo.Enabled = sw
        txtCodigoCliente.Enabled = sw
        txtNombreCliente.Enabled = sw
        dtFechaVenta.Enabled = sw
        cboTipoComprobante.Enabled = sw
        txtNumeroComprobante.Enabled = sw
        txtCodigoUsuario.Enabled = sw
        txtNombreUsuario.Enabled = sw
    End Sub

    Private Sub habilitar(sw As Boolean)
        txtCodigoDetalle.Enabled = False
        txtCantidad.Enabled = sw
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtCantidad.Text <> "" Then
            Try
                Dim dts As New DetalleVenta
                Dim func As New DetalleVentaDAO
                dts.DetalleVentaCodigo = txtCodigoDetalle.Text
                dts.VentaCodigo = txtCodigo.Text
                dts.ProductoCodigo = txtCodigoProducto.Text
                dts.DetalleVentaPrecio = txtPrecio.Text
                dts.DetalleVentaCantidad = txtCantidad.Text


                If func.insertar(dts) Then
                    If func.disminuirStock(dts) Then
                    End If
                    MessageBox.Show("La Venta Se ha Completado Correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigoDetalle.Text = objeto.generarcodigo
                    limpiar()
                    habilitar(False)
                    Botones(True, False, True, True, False)
                Else
                    MessageBox.Show("Venta no fue registrado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitar(False)
                    Botones(True, False, True, True, False)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If chkEliminar.CheckState = CheckState.Checked Then
            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar los Ventas seleccionadas?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataListadoVentas.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If marcado Then
                            Dim codigoEliminar As String = Convert.ToString(row.Cells("Codigo Detalle").Value)
                            Dim vdb As New DetalleVenta
                            Dim func As New DetalleVentaDAO
                            vdb.DetalleVentaCodigo = codigoEliminar
                            vdb.VentaCodigo = Convert.ToString(dataListadoVentas.SelectedCells.Item(2).Value)
                            vdb.ProductoCodigo = Convert.ToString(dataListadoVentas.SelectedCells.Item(3).Value)
                            vdb.DetalleVentaCantidad = Convert.ToString(dataListadoVentas.SelectedCells.Item(6).Value)
                            If func.eliminar(vdb) Then
                                If func.aumentarStock(vdb) Then
                                End If
                            Else
                                MessageBox.Show("Venta no fue eliminado", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            MessageBox.Show("Se eliminaron los registros", "Sistema Venta de Ropa")
                            chkEliminar.Checked = CheckState.Unchecked
                        End If
                    Next
                    Call mostrar()
                Catch ex As Exception
                    MessageBox.Show("Error al intentar Quitar", "Sistema Venta de Ropa" + ex.StackTrace)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkEliminar.Checked = CheckState.Unchecked
                Call mostrar()
            End If
            Call limpiar()
        Else
            MessageBox.Show("Primero debe Hablitar el Selecionar/ Seleccionar una Fila a Eliminar", "Sistema Venta de Ropa")
        End If
    End Sub


    Private Sub dataListadoVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoVentas.CellContentClick
        If e.ColumnIndex = Me.dataListadoVentas.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListadoVentas.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListadoVentas.Columns.Item("Eliminar").Visible = True
        Else
            dataListadoVentas.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigoDetalle.Text = objeto.generarcodigo
        limpiar()
        Botones(True, False, True, True, False)
        habilitar(False)
        mostrar()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        FormMostrarListaProductos.txtflag.Text = "1"
        FormMostrarListaProductos.ShowDialog()

    End Sub
    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Botones(True, True, False, True, True)
        Try
            Dim cant As String
            cant = txtCantidad.Value
            If txtCantidad.Value > txtStock.Value Then
                MessageBox.Show("No existe Stock suficiente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnGuardar.Enabled = False
                txtCantidad.Value = txtStock.Value
            Else
                btnGuardar.Enabled = True
            End If
            If txtCantidad.Value = 0 Then
                btnGuardar.Enabled = False
            Else
                btnGuardar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
        End Try
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnComprobante.Click
        FormReporteComprobanteVenta.txtReporteCodigo.Text = Me.txtCodigo.Text
        FormReporteComprobanteVenta.ShowDialog()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigoDetalle.Text = objeto.generarcodigo
        Me.mostrar()
        limpiar()
        habilitar(True)
        Botones(True, False, False, True, True)

    End Sub
End Class