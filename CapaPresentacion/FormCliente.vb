Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormCliente
    Private dt As New DataTable
    Dim objeto As New ClienteDAO
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objeto.generarcodigo
        Botones(True, False, False, True)
        habilitarcampos(False)
        Me.mostrar()
        mostrarAyuda()
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
        txtDireccion.Enabled = a
        txtTelefono.Enabled = a
        txtNumeroDocumento.Enabled = a
        txtApellidoMaterno.Enabled = a
        txtApellidoPaterno.Enabled = a
        cboDocumento.Enabled = a
        cboGenero.Enabled = a
        cboEstado.Enabled = a
        txtEmail.Enabled = a
        dtFechaNacimiento.Enabled = a
    End Sub

    Private Sub limpiar()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtNumeroDocumento.Text = ""
        txtApellidoMaterno.Text = ""
        txtApellidoPaterno.Text = ""
        cboDocumento.SelectedIndex = -1
        cboGenero.SelectedIndex = -1
        cboEstado.SelectedIndex = -1
        txtEmail.Text = ""
    End Sub


    Private Sub mostrarAyuda()
        Me.ttMensaje.SetSuperTooltip(Me.txtNombre, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar  Nombre del Cliente", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.txtApellidoPaterno, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar el Apellido Paterno del Cliente ", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
        Me.ttMensaje.SetSuperTooltip(Me.txtApellidoMaterno, New DevComponents.DotNetBar.SuperTooltipInfo(" Debe Ingresar el Apellido Materno del Cliente ", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Apple))
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ClienteDAO
            dt = func.mostrar
            dataListaCliente.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListaCliente.DataSource = dt
                txtBuscar.Enabled = True
                dataListaCliente.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dataListaCliente.DataSource = Nothing
                txtBuscar.Enabled = False
                dataListaCliente.ColumnHeadersVisible = False
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
                dataListaCliente.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                dataListaCliente.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()

        dataListaCliente.Columns(0).Visible = False

    End Sub
    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListaCliente.Columns.Item("Eliminar").Visible = True
        Else
            dataListaCliente.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If chkEliminar.CheckState = CheckState.Checked Then


            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataListaCliente.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim codigoEliminar As String = Convert.ToString(row.Cells("Codigo").Value)
                            Dim vdb As New Cliente
                            Dim func As New ClienteDAO
                            vdb.ClienteCodigo = codigoEliminar
                            If func.eliminar(vdb) Then
                            Else
                                MessageBox.Show("Cliente no fue eliminado", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MessageBox.Show("Cancelando eliminación de registros", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkEliminar.Checked = CheckState.Unchecked
                Call mostrar()
            End If
        Else
            MessageBox.Show("Primero debe Hablitar el Selecionar/ Seleccionar una Fila a Eliminar", "Sistema Venta de Ropa")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = objeto.generarcodigo

        limpiar()
        habilitarcampos(True)
        txtApellidoPaterno.Focus()
        Botones(True, True, False, True)
        mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellidoPaterno.Text <> "" And txtNumeroDocumento.Text <> "" And Convert.ToString(cboEstado.SelectedItem) <> "" And cboDocumento.Text <> "" And Convert.ToString(cboGenero.SelectedItem) <> "" Then
            Try
                Dim dts As New Cliente
                Dim func As New ClienteDAO
                dts.ClienteCodigo = txtCodigo.Text
                dts.ClientePaterno = txtApellidoPaterno.Text
                dts.ClienteMaterno = txtApellidoMaterno.Text
                dts.ClienteNombre = txtNombre.Text 'SelectedText'SelectedIndex
                dts.ClienteGenero = Convert.ToString(cboGenero.SelectedItem)
                dts.ClienteFechaNacimiento = dtFechaNacimiento.Value
                dts.ClienteTipoDocumento = cboDocumento.Text
                dts.ClienteNumeroDocumento = txtNumeroDocumento.Text
                dts.ClienteDireccion = txtDireccion.Text
                dts.ClienteTelefono = txtTelefono.Text
                dts.ClienteEmail = txtEmail.Text
                dts.ClienteEstado = cboEstado.Text
                If func.insertar(dts) Then
                    MessageBox.Show("cliente registrado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                Else
                    MessageBox.Show("cliente no fue registrado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellidoPaterno.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtNumeroDocumento.Text <> "" And txtApellidoMaterno.Text <> "" Then
                Try
                    Dim dts As New Cliente
                    Dim func As New ClienteDAO

                    dts.ClienteCodigo = txtCodigo.Text
                    dts.ClientePaterno = txtApellidoPaterno.Text
                    dts.ClienteMaterno = txtApellidoMaterno.Text
                    dts.ClienteNombre = txtNombre.Text
                    dts.ClienteGenero = Convert.ToString(cboGenero.SelectedItem)
                    dts.ClienteFechaNacimiento = dtFechaNacimiento.Value
                    dts.ClienteTipoDocumento = cboDocumento.Text
                    dts.ClienteNumeroDocumento = txtNumeroDocumento.Text
                    dts.ClienteDireccion = txtDireccion.Text
                    dts.ClienteTelefono = txtTelefono.Text
                    dts.ClienteEmail = txtEmail.Text
                    dts.ClienteEstado = cboEstado.Text


                    If func.editar(dts) Then
                        MessageBox.Show("cliente Modificado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()
                    Else
                        MessageBox.Show("cliente no fue modifcado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        habilitarcampos(False)
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigo.Text = objeto.generarcodigo
        limpiar()
        Botones(True, False, False, True)
        habilitarcampos(False)
        mostrar()
    End Sub

    Private Sub dataListaCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListaCliente.CellContentClick
        If e.ColumnIndex = Me.dataListaCliente.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListaCliente.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub dataListaCliente_DoubleClick(sender As Object, e As EventArgs) Handles dataListaCliente.DoubleClick
        Botones(True, False, True, True)
        habilitarcampos(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Codigo").Value)
        Me.txtApellidoPaterno.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("A. Paterno").Value)
        Me.txtApellidoMaterno.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("A. Materno").Value)
        Me.txtNombre.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Nombre").Value)
        Me.cboGenero.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Generó").Value)
        Me.dtFechaNacimiento.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Fecha Nacimiento").Value)
        Me.cboDocumento.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Tipo Documento").Value)
        Me.txtNumeroDocumento.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("NDocumento").Value)
        Me.txtDireccion.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Dirección").Value)
        Me.txtTelefono.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Telefono").Value)
        Me.txtEmail.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Email").Value)
        Me.cboEstado.Text = Convert.ToString(Me.dataListaCliente.CurrentRow.Cells("Estado").Value)
    End Sub

    Private Sub txtApellidoPaterno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidoPaterno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Apellido Paterno del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub txtApellidoMaterno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidoMaterno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Apellido Materno del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub txtNumeroDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDocumento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el DNI del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim a As New FormReporteCliente
        a.ShowDialog()
    End Sub

    Private Sub cboDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboDocumento.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub cboGenero_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboGenero.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub txtApellidoPaterno_TextChanged(sender As Object, e As EventArgs) Handles txtApellidoPaterno.TextChanged
        errorIcono.Clear()
    End Sub

    Private Sub txtApellidoMaterno_TextChanged(sender As Object, e As EventArgs) Handles txtApellidoMaterno.TextChanged
        errorIcono.Clear()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
End Class