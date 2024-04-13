Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormTrabajador
    Private dt As New DataTable
    Dim objeto As New TrabajadorDAO
    Private Sub FormTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objeto.generarcodigo
        mostrardatos()
        Botones(True, False, False, True)
        habilitarcampos(False)
    End Sub
    Private Sub mostrardatos()
        Try
            Dim func As New TrabajadorDAO
            dt = func.mostrar
            datlistaTrabajadores.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datlistaTrabajadores.DataSource = dt
                txtBuscar.Enabled = True
                datlistaTrabajadores.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datlistaTrabajadores.DataSource = Nothing
                txtBuscar.Enabled = False
                datlistaTrabajadores.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar mostrar", "Sistema Venta de Ropa" + ex.Message)

        End Try
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cboBuscar.Text & " like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datlistaTrabajadores.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datlistaTrabajadores.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)

        End Try

    End Sub

    Private Sub ocultar_columnas()
        datlistaTrabajadores.Columns(0).Visible = False
    End Sub

    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, Editar As Boolean, Cancelar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
    End Sub

    Sub habilitarcampos(a As Boolean)
        txtNombre.Enabled = a
        txtCodigo.Enabled = False
        txtDireccion.Enabled = a
        txtTelefono.Enabled = a
        dtFechaNacimiento.Enabled = a
        dtfechaRegistro.Enabled = a
        txtNumeroDocumento.Enabled = a
        txtApellidoMaterno.Enabled = a
        txtApellidoPaterno.Enabled = a
        txtEmail.Enabled = a
        cboGenero.Enabled = a
        cboEstado.Enabled = a

    End Sub



    Private Sub limpiar()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtNumeroDocumento.Text = ""
        txtApellidoMaterno.Text = ""
        txtApellidoPaterno.Text = ""
        txtEmail.Text = ""
        cboGenero.SelectedIndex = -1
        cboEstado.SelectedIndex = -1
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And cboEstado.Text <> "" And cboGenero.Text <> "" And txtNumeroDocumento.Text <> "" Then

            Try
                Dim dts As New Trabajador
                Dim func As New TrabajadorDAO

                dts.TrabajadorCodigo = txtCodigo.Text
                dts.TrabajadorPaterno = txtApellidoPaterno.Text
                dts.TrabajadorMaterno = txtApellidoMaterno.Text
                dts.TrabajadorNombre = txtNombre.Text
                dts.TrabajadorGenero = Convert.ToString(cboGenero.SelectedItem)
                dts.TrabajadorFechaNacimiento = dtFechaNacimiento.Value
                dts.TrabajadorNumeroDocumento = txtNumeroDocumento.Text
                dts.TrabajadorDireccion = txtDireccion.Text
                dts.TrabajadorTelefono = txtTelefono.Text
                dts.TrabajadorEmail = txtEmail.Text
                dts.TrabajadorFechaRegistrado = dtfechaRegistro.Text
                dts.TrabajadorEstado = Convert.ToString(cboEstado.SelectedItem)
                If func.insertar(dts) Then
                    MessageBox.Show("Trabajador registrado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrardatos()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                    errorIcono.Clear()
                Else
                    MessageBox.Show("Trabajador no fue registrado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrardatos()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                    errorIcono.Clear()
                End If
                errorIcono.Clear()
            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
                errorIcono.Clear()
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" And cboEstado.Text <> "" And cboGenero.Text <> "" And txtNumeroDocumento.Text <> "" Then
                Try
                    Dim dts As New Trabajador
                    Dim func As New TrabajadorDAO

                    dts.TrabajadorCodigo = txtCodigo.Text
                    dts.TrabajadorPaterno = txtApellidoPaterno.Text
                    dts.TrabajadorMaterno = txtApellidoMaterno.Text
                    dts.TrabajadorNombre = txtNombre.Text
                    dts.TrabajadorGenero = cboGenero.Text
                    dts.TrabajadorFechaNacimiento = dtFechaNacimiento.Value
                    dts.TrabajadorNumeroDocumento = txtNumeroDocumento.Text
                    dts.TrabajadorDireccion = txtDireccion.Text
                    dts.TrabajadorTelefono = txtTelefono.Text
                    dts.TrabajadorEmail = txtEmail.Text
                    dts.TrabajadorFechaRegistrado = dtfechaRegistro.Text
                    dts.TrabajadorEstado = cboEstado.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Trabajador Modificado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrardatos()
                        txtCodigo.Text = objeto.generarcodigo
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()
                    Else
                        MessageBox.Show("Trabajador no fue modifcado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrardatos()
                        txtCodigo.Text = objeto.generarcodigo
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()

                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al intentar Modificar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        txtBuscar.Focus()
        errorIcono.Clear()
        Botones(True, False, False, True)
        habilitarcampos(False)
        mostrardatos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        habilitarcampos(True)
        txtApellidoPaterno.Focus()
        Botones(True, True, False, True)
        mostrardatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If chkEliminar.CheckState = CheckState.Checked Then


            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then

                Try
                    For Each row As DataGridViewRow In datlistaTrabajadores.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If marcado Then
                            Dim onekey As String = Convert.ToString(row.Cells("Codigo").Value)
                            Dim vdb As New Trabajador
                            Dim func As New TrabajadorDAO
                            vdb.TrabajadorCodigo = onekey
                            If func.eliminar(vdb) Then
                            Else
                                MessageBox.Show("Producto no fue Eliminado", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            MessageBox.Show("Se eliminaron los registros", "Sistema Venta de Ropa")
                            chkEliminar.Checked = CheckState.Unchecked
                        End If
                    Next
                    Call mostrardatos()
                Catch ex As Exception
                    MessageBox.Show("Error al intentar eliminar", "Sistema Venta de Ropa" + ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminacion", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkEliminar.Checked = CheckState.Unchecked
                Call mostrardatos()
            End If
        Else
            MessageBox.Show("Primero debe Hablitar el Selecionar/ Seleccionar una Fila a Eliminar", "Sistema Venta de Ropa")
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            datlistaTrabajadores.Columns.Item("Eliminar").Visible = True
        Else
            datlistaTrabajadores.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub datlistaTrabajadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datlistaTrabajadores.CellContentClick
        If e.ColumnIndex = Me.datlistaTrabajadores.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datlistaTrabajadores.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datlistaTrabajadores_DoubleClick(sender As Object, e As EventArgs) Handles datlistaTrabajadores.DoubleClick
        Botones(True, False, True, True)
        habilitarcampos(True)
        Me.txtCodigo.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Codigo").Value)
        Me.txtApellidoPaterno.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("A. Paterno").Value)
        Me.txtApellidoMaterno.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("A. Materno").Value)
        Me.txtNombre.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Nombre").Value)

        Me.cboGenero.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Genero").Value)
        Me.dtFechaNacimiento.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Fecha Nacimiento").Value)

        Me.txtNumeroDocumento.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("NDocumento").Value)
        Me.txtDireccion.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Direccion").Value)
        Me.txtTelefono.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Telefono").Value)
        Me.txtEmail.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Email").Value)
        Me.dtfechaRegistro.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Fecha Registro").Value)
        Me.cboEstado.Text = Convert.ToString(Me.datlistaTrabajadores.CurrentRow.Cells("Estado").Value)


    End Sub

    Private Sub txtApellidoPaterno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidoPaterno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtApellidoMaterno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidoMaterno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNumeroDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDocumento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub cboGenero_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboGenero.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar El Estado del Trabajador")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub cboEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboEstado.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar El Estado del Trabajador")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim reporte As New FormReporteTrabajador
        reporte.ShowDialog()
    End Sub
End Class