Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormCategoria
    Private dt As New DataTable
    Dim obpas As New CategoriaDAO
    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = obpas.generarcodigo
        botones(False)
        mostrarAyuda()
        Me.mostrar()
        habilitarcampos(False)
    End Sub

    Public Sub botones(e As Boolean)
        btnGuardar.Enabled = e
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        cboEstado.SelectedIndex = -1

    End Sub

    Public Sub habilitarcampos(a As Boolean)
        txtCodigo.Enabled = False
        txtNombre.Enabled = a
        txtDescripcion.Enabled = a
        cboEstado.Enabled = a
    End Sub


    Private Sub MensajeConfirmacion(mensaje As String)
        MessageBox.Show(mensaje, "Sistema de Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub MensajeError(mensajeError As String)
        MessageBox.Show(mensajeError, "Sistema de Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
    Private Sub mostrarAyuda()
        Me.ttMensaje.SetSuperTooltip(Me.txtCodigo, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar un Codigo Para la Categoria", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.txtNombre, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar un Nombre Para la Categoria", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.txtDescripcion, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar una Descripcion Para la Categoria", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
    End Sub






    Public Sub OcultarColumnas()
        Me.dataListadoCategoria.Columns(0).Visible = False

    End Sub


    Public Sub mostrar()
        Try
            Dim func As New CategoriaDAO
            dt = func.mostrarCategoria
            dataListadoCategoria.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListadoCategoria.DataSource = dt
                txtBuscar.Enabled = True
                dataListadoCategoria.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                dataListadoCategoria.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListadoCategoria.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar mostrar", "Sistema Venta de Ropa" + ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False
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
                dataListadoCategoria.DataSource = dv
                OcultarColumnas()
            Else
                inexistente.Visible = True
                dataListadoCategoria.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)
        End Try

    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If chkEliminar.CheckState = CheckState.Checked Then

            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataListadoCategoria.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If marcado Then
                            Dim onekey As String = Convert.ToString(row.Cells("Código").Value)
                            Dim vdb As New Categoria
                            Dim func As New CategoriaDAO
                            vdb.CategoriaCodigo = onekey
                            If func.eliminarCategoria(vdb) Then
                            Else
                                MessageBox.Show("Categoria eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            MessageBox.Show("Se eliminaron los registros", "Sistema Venta de Ropa")
                            chkEliminar.Checked = CheckState.Unchecked
                        End If

                    Next
                    Call mostrar()
                Catch ex As Exception
                    MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
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

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListadoCategoria.Columns.Item("Eliminar").Visible = True
        Else
            dataListadoCategoria.Columns.Item("Eliminar").Visible = False

        End If
    End Sub

    Private Sub dataListadoCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoCategoria.CellContentClick
        If e.ColumnIndex = Me.dataListadoCategoria.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListadoCategoria.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiar()
        Me.mostrar()
        habilitarcampos(True)
        Me.txtCodigo.Focus()
        botones(True)
        txtCodigo.Text = obpas.generarcodigo
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And Me.txtNombre.Text <> "" And Me.cboEstado.Text <> "" Then
            Try
                Dim dts As New Categoria
                Dim func As New CategoriaDAO
                dts.CategoriaCodigo = txtCodigo.Text
                dts.CategoriaNombre = txtNombre.Text
                dts.CategoriaDescripcion = txtDescripcion.Text
                dts.CategoriaEstado = cboEstado.SelectedItem

                If func.insertarCategoria(dts) Then
                    MessageBox.Show("Categoria registrada correctamente", "Sistema Venta Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigo.Text = obpas.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                Else
                    MessageBox.Show("Categoria no fue registrada", "Sistema Venta Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigo.Text = obpas.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la categoria?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And Me.txtNombre.Text <> "" And cboEstado.Text <> "" Then
                Try
                    Dim dts As New Categoria
                    Dim func As New CategoriaDAO
                    dts.CategoriaCodigo = txtCodigo.Text
                    dts.CategoriaNombre = txtNombre.Text
                    dts.CategoriaDescripcion = txtDescripcion.Text
                    dts.CategoriaEstado = cboEstado.SelectedItem

                    If func.editarCategoria(dts) Then
                        MessageBox.Show("Editada   correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = obpas.generarcodigo
                        limpiar()
                    Else
                        MessageBox.Show("Categoria no fue editada ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = obpas.generarcodigo
                        limpiar()

                    End If



                Catch ex As Exception
                    MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else


                MessageBox.Show("Faltan ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        habilitarcampos(False)
        errorIcono.Clear()
        txtCodigo.Text = obpas.generarcodigo
    End Sub

    Private Sub dataListadoCategoria_DoubleClick(sender As Object, e As EventArgs) Handles dataListadoCategoria.DoubleClick
        habilitarcampos(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Código").Value)
        Me.txtNombre.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Nombre").Value)
        Me.txtDescripcion.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Descripción").Value)
        Me.cboEstado.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Estado").Value)
        materialTabControl1.SelectedIndex = 1
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim reporte As New FormReporteCategoria

        reporte.ShowDialog()

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese Nombre de la Categoria")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        errorIcono.Clear()
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