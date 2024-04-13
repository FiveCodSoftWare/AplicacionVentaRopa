Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormMarcaProducto
    Dim objecto As New MarcaProductoDAO
    Private dt As New DataTable
    Private Sub FormMarcaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objecto.generarcodigo
        Botones(True, False, False, True)
        habilitarcampos(False)
        mostrarAyuda()
        Me.mostrar()
    End Sub

    Public Sub limpiar()
        txtCodigo.Enabled = False
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        cboEstado.SelectedIndex = -1
    End Sub

    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, Editar As Boolean, Cancelar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
    End Sub

    Sub habilitarcampos(a As Boolean)
        txtCodigo.Enabled = False
        txtNombre.Enabled = a
        txtDescripcion.Enabled = a
        cboEstado.Enabled = a
    End Sub
    Private Sub mostrarAyuda()

        Me.ttMensaje.SetSuperTooltip(Me.txtNombre, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar un Nombre Para la Marca Producto", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.txtDescripcion, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar una Descripcion Para la Marca producto", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))

    End Sub

    Public Sub OcultarColumnas()
        Me.dataListado.Columns(0).Visible = False

    End Sub


    Public Sub mostrar()
        Try
            Dim func As New MarcaProductoDAO
            dt = func.mostrarMarca
            dataListado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                dataListado.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar mostrar", "Sistema Venta de Ropa" + ex.Message)
        End Try
        buscar()
    End Sub


    Public Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cboComBuscar.Text & " like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                dataListado.DataSource = dv
                OcultarColumnas()
            Else
                inexistente.Visible = True
                dataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiar()
        habilitarcampos(True)
        Botones(True, True, False, True)
        Me.mostrar()
        txtNombre.Focus()
        txtCodigo.Text = objecto.generarcodigo
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And Me.txtNombre.Text <> "" And Me.cboEstado.Text <> "" Then


            Try
                Dim dts As New MarcaProducto
                Dim func As New MarcaProductoDAO
                dts.MarcaProductoCodigo = txtCodigo.Text
                dts.MarcaProductoNombre = txtNombre.Text
                dts.MarcaProductoDescripcion = txtDescripcion.Text
                dts.MarcaProductoEstado = cboEstado.SelectedItem

                If func.insertarMarca(dts) Then
                    MessageBox.Show("Marca de Producto  registrada correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboComBuscar.Focus()
                    mostrar()
                    txtCodigo.Text = objecto.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                Else
                    MessageBox.Show("Marca de Producto no fue registrada", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cboComBuscar.Focus()
                End If
                cboComBuscar.Focus()
            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
            End Try
        Else

            MessageBox.Show("Faltan ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboComBuscar.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cboComBuscar.Focus()
        errorIcono.Clear()
        limpiar()
        Botones(True, False, False, True)
        habilitarcampos(False)
        mostrar()
        txtCodigo.Text = objecto.generarcodigo
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la Marca de Producto?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And Me.txtNombre.Text <> "" And txtDescripcion.Text <> "" Then

                Try
                    Dim dts As New MarcaProducto
                    Dim func As New MarcaProductoDAO
                    dts.MarcaProductoCodigo = txtCodigo.Text
                    dts.MarcaProductoNombre = txtNombre.Text
                    dts.MarcaProductoDescripcion = txtDescripcion.Text
                    dts.MarcaProductoEstado = cboEstado.SelectedItem

                    If func.editarMarca(dts) Then
                        MessageBox.Show("Marca del Producto modificada   correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objecto.generarcodigo
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()
                    Else
                        MessageBox.Show("Marca no fue modificada ", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objecto.generarcodigo
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()

                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al intentar editar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If chkEliminar.CheckState = CheckState.Checked Then
            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataListado.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If marcado Then
                            Dim onekey As String = Convert.ToString(row.Cells("Código").Value)
                            Dim vdb As New MarcaProducto
                            Dim func As New MarcaProductoDAO
                            vdb.MarcaProductoCodigo = onekey
                            If func.eliminarMarca(vdb) Then
                            Else
                                MessageBox.Show("La Marca de Prodcuto no fue eliminada", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            MessageBox.Show("Se eliminaron los registros", "Sistema Venta de Ropa")
                            chkEliminar.Checked = CheckState.Unchecked
                        End If
                    Next
                    Call mostrar()
                Catch ex As Exception
                    MessageBox.Show("Error al intentar eliminar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminacion", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkEliminar.Checked = CheckState.Unchecked
                Call mostrar()
            End If
        Else
            MessageBox.Show("Primero debe Hablitar el Selecionar/ Seleccionar una Fila a Eliminar", "Sistema Venta de Ropa")
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
    Private Sub dataListado_DoubleClick(sender As Object, e As EventArgs) Handles dataListado.DoubleClick
        Botones(True, False, True, True)
        habilitarcampos(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListado.CurrentRow.Cells("Código").Value)
        Me.txtNombre.Text = Convert.ToString(Me.dataListado.CurrentRow.Cells("Nombre").Value)
        Me.txtDescripcion.Text = Convert.ToString(Me.dataListado.CurrentRow.Cells("Descripcion").Value)
        Me.cboEstado.Text = Convert.ToString(Me.dataListado.CurrentRow.Cells("Estado").Value)
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
        Else
            dataListado.Columns.Item("Eliminar").Visible = False

        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim report As New FormReporteMarcaProducto
        report.ShowDialog()

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, Bunifu.Framework.UI.BunifuMaterialTextbox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese Nombre de la Marca de Producto, este campo es obligatorio")
        End If
    End Sub

    Private Sub cboEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboEstado.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        errorIcono.Clear()
    End Sub
End Class