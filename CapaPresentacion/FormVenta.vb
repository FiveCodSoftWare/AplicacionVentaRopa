Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin
Imports System.Data
Imports System.Data.SqlClient

Public Class FormVenta

    Dim dt As New DataTable
    Dim objeto As New VentaDAO
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objeto.generarcodigo
        '  txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
        mostrarAyuda()
        Botones(True, False, False, True)
        llenarCombo()
        mostrar()
        habilitar(False)
    End Sub

    Sub llenarCombo()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select (ClienteNombre+' '+ClientePaterno) as nombre,ClienteCodigo from personal.cliente where clienteestado='A'", Cadena)
            da.Fill(dt)
            cboCliente.DataSource = dt
            cboCliente.DisplayMember = "nombre"
            cboCliente.ValueMember = "ClienteCodigo"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, Editar As Boolean, Cancelar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnModificar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
    End Sub

    Private Sub mostrarAyuda()
        Me.ttMensaje.SetSuperTooltip(Me.txtNumeroComprobante, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar  Numero de Comprobante de la Venta", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.cboTipoComprobante, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar el Tipo de Comprobante", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.cboCliente, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar un Cliente ", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New VentaDAO
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                dataListadoVentas.DataSource = dt
                txtBuscar.Enabled = True
                txtBuscar.Focus()
                dataListadoVentas.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dataListadoVentas.DataSource = Nothing
                txtBuscar.Focus()
                txtBuscar.Enabled = False
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
            dv.RowFilter = cboBuscar.Text & " like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                dataListadoVentas.DataSource = dv
                ocultarcolumnas()

            Else
                inexistente.Visible = True
                dataListadoVentas.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)

        End Try


    End Sub
    Private Sub ocultarcolumnas()
        'dataListadoVentas.Columns(0).Visible = False
        ' dataListadoVentas.Columns(1).Visible = False

    End Sub
    Private Sub limpiar()
        txtNombreCliente.Text = ""
        txtCodigoCliente.Text = ""
        cboTipoComprobante.SelectedIndex = -1
        txtNumeroComprobante.Text = ""
        txtCodigoCliente.Visible = False
        txtNombreCliente.Visible = False
        cboCliente.Visible = True
    End Sub


    Private Sub habilitar(sw As Boolean)
        cboCliente.Enabled = sw
        txtCodigo.Enabled = False
        txtCodigoCliente.Enabled = False
        txtNombreCliente.Enabled = False
        dtFechaVenta.Enabled = sw
        cboTipoComprobante.Enabled = sw
        txtNumeroComprobante.Enabled = sw
        txtCodigoUsuario.Enabled = False
        txtNombreUsuario.Enabled = False

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = objeto.generarcodigo
        limpiar()
        habilitar(True)
        cboBuscar.Focus()
        Botones(True, True, False, True)
        mostrar()
    End Sub
    'VentaNumeroComprobante
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And cboTipoComprobante.Text <> "" And txtNumeroComprobante.Text <> "" Then
            Try
                Dim dts As New Venta
                Dim func As New VentaDAO
                dts.VentaCodigo = txtCodigo.Text
                dts.VentaFecha = dtFechaVenta.Value
                dts.ClienteCodigo = Convert.ToString(cboCliente.SelectedValue)
                dts.VentaTipoComprobante = (cboTipoComprobante.Text)
                dts.VentaNumeroComprobante = Convert.ToString(txtNumeroComprobante.Text)
                dts.UsuarioCodigo = txtCodigoUsuario.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Venta registrado correctamente se va proceder a registrar Productos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    enviarDatosaDetalleVentaProducto()
                    limpiar()

                    habilitar(False)
                    Botones(True, False, False, True)
                    txtCodigo.Text = objeto.generarcodigo
                    ' txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
                Else
                    MessageBox.Show("Venta no fue registrado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    ' txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
                    limpiar()
                    habilitar(False)
                    Botones(True, False, False, True)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub enviarDatosaDetalleVentaProducto()
        FormDetalleVentaProducto.txtCodigo.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Codigo").Value)
        FormDetalleVentaProducto.txtCodigoCliente.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Cliente").Value)
        FormDetalleVentaProducto.txtNombreCliente.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Nombre").Value)
        FormDetalleVentaProducto.txtNumeroComprobante.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Comprobante").Value)
        FormDetalleVentaProducto.cboTipoComprobante.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Tipo Comprobante").Value)
        FormDetalleVentaProducto.dtFechaVenta.Value = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Fecha Venta").Value)
        FormDetalleVentaProducto.txtCodigoUsuario.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Usuario").Value)
        FormDetalleVentaProducto.txtNombreUsuario.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Usuario").Value)
        FormDetalleVentaProducto.ShowDialog()


    End Sub
    Private Sub btnAgregarCliene_Click(sender As Object, e As EventArgs)
        FormMostrarListaCliente.txtflag.Text = "1"
        FormMostrarListaCliente.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la Venta?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNumeroComprobante.Text <> "" Then
                Try
                    Dim dts As New Venta
                    Dim func As New VentaDAO
                    dts.VentaCodigo = txtCodigo.Text
                    dts.VentaFecha = dtFechaVenta.Value
                    dts.ClienteCodigo = Convert.ToString(cboCliente.SelectedValue)
                    dts.VentaTipoComprobante = cboTipoComprobante.Text
                    dts.VentaNumeroComprobante = Convert.ToString(txtNumeroComprobante.Text)
                    dts.UsuarioCodigo = txtCodigoUsuario.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Venta Modificado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        ' txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
                        limpiar()
                        txtBuscar.Focus()
                        habilitar(False)
                        Botones(True, False, False, True)
                    Else
                        MessageBox.Show("Venta no fue modifcado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        '  txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
                        habilitar(False)
                        Botones(True, False, False, True)
                        limpiar()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al intentar editar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dataListadoVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoVentas.CellClick
        cboCliente.Visible = False
        txtNombreCliente.Visible = True
        Botones(True, False, True, True)
        habilitar(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Codigo").Value)
        Me.txtCodigoCliente.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Cliente").Value)
        Me.txtNombreCliente.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Nombre").Value)
        Me.txtNumeroComprobante.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Comprobante").Value)
        Me.cboTipoComprobante.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Tipo Comprobante").Value)
        Me.dtFechaVenta.Value = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Fecha Venta").Value)
        Me.txtCodigoUsuario.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("N° Usuario").Value)
        Me.txtNombreUsuario.Text = Convert.ToString(Me.dataListadoVentas.CurrentRow.Cells("Usuario").Value)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigo.Text = objeto.generarcodigo
        ' txtNumeroComprobante.Text = objeto.generarcodigoBoletaFactura
        limpiar()
        Botones(True, False, False, True)
        habilitar(False)
        mostrar()
    End Sub



    Private Sub dataListadoVentas_DoubleClick(sender As Object, e As EventArgs) Handles dataListadoVentas.DoubleClick
        enviarDatosaDetalleVentaProducto()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        errorIcono.Clear()
        buscar()
    End Sub

    Private Sub txtNumeroComprobante_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroComprobante.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Apellido Materno del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub cboTipoComprobante_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoComprobante.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub cboCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCliente.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub
End Class