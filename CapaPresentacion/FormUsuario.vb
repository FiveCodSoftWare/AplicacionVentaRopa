Imports System.Runtime.InteropServices
Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormUsuario
    Private dt As New DataTable
    Dim objeto As New UsuarioDAO
    Private Sub FormUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objeto.generarcodigo
        Botones(True, False, False, True)

        habilitar(False)
        Me.mostrar()
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = objeto.generarcodigo
        Me.limpiar()
        habilitar(True)
        Botones(True, True, False, True)
        Me.mostrar()
        txtNombre.Focus()
    End Sub

    Private Sub mostrar()

        Try
            Dim func As New UsuarioDAO
            dt = func.mostrar
            dataListadoCategoria.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                dataListadoCategoria.DataSource = dt
                dataListadoCategoria.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                dataListadoCategoria.DataSource = Nothing
                dataListadoCategoria.ColumnHeadersVisible = True
                inexistente.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar mostrar", "Sistema Venta de Ropa" + ex.Message)
        End Try
    End Sub

    Public Sub ocultarColumna()
        dataListadoCategoria.Columns(0).Visible = False
        dataListadoCategoria.Columns(1).Visible = False
    End Sub



    Public Sub limpiar()
        txtCodigoTrabajador.Text = ""
        txtNombre.Text = ""
        txtContraseña.Text = ""
        txtNombre.Text = ""
        cboEstado.SelectedIndex = -1
    End Sub

    Public Sub habilitar(ws As Boolean)
        txtContraseña.Enabled = ws
        txtCodigo.Enabled = False
        txtNombre.Enabled = False
        txtCodigoTrabajador.Enabled = False
        cboAcceso.Enabled = ws

    End Sub
    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, Editar As Boolean, Cancelar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And Me.txtNombre.Text <> "" And Me.txtContraseña.Text <> "" And Convert.ToString(Me.cboEstado.SelectedItem) <> "" Then


            Try
                Dim dts As New Usuario
                Dim func As New UsuarioDAO
                dts.UsuarioCodigo = txtCodigo.Text
                dts.TrabajadorCodigo = txtCodigoTrabajador.Text
                dts.UsuarioUsuario = txtNombre.Text
                dts.UsuarioUserNombre = Convert.ToString(cboAcceso.SelectedItem)
                dts.UsuarioContraseña = txtContraseña.Text
                dts.UsuarioEstado = Convert.ToString(cboEstado.SelectedItem)
                If func.insertar(dts) Then
                    MessageBox.Show("Usuario registrada correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    limpiar()
                    habilitar(False)
                    Botones(True, False, False, True)
                Else
                    MessageBox.Show("Usuario no fue registrada correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                End If

            Catch ex As Exception
                MessageBox.Show("Error al intentar insertar", "Sistema Venta de Ropa" + ex.Message)
            End Try
        Else

            MessageBox.Show("Faltan ingresar algunos datos", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del Usuario?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" Then
                Try
                    Dim dts As New Usuario
                    Dim func As New UsuarioDAO

                    dts.UsuarioCodigo = txtCodigo.Text
                    dts.TrabajadorCodigo = txtCodigoTrabajador.Text
                    dts.UsuarioUsuario = txtNombre.Text
                    dts.UsuarioUserNombre = Convert.ToString(cboAcceso.SelectedItem)
                    dts.UsuarioContraseña = txtContraseña.Text
                    dts.UsuarioEstado = Convert.ToString(cboEstado.SelectedItem)


                    If func.editar(dts) Then
                        MessageBox.Show("Usuario Modificado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        habilitar(False)
                        Botones(True, False, False, True)
                        limpiar()
                    Else
                        MessageBox.Show("Usuario no fue modifcado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
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

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        FormMostrarListaTrabajadores.txtflag.Text = "1"
        FormMostrarListaTrabajadores.ShowDialog()
    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub dataListadoCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoCategoria.CellDoubleClick
        Botones(True, False, True, True)

        habilitar(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Codigo").Value)
        Me.txtCodigoTrabajador.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Codigo Trabajador").Value)
        Me.txtNombre.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Nombre").Value)

        Me.cboAcceso.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Acceso").Value)
        Me.txtContraseña.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Contraseña").Value)

        Me.cboEstado.Text = Convert.ToString(Me.dataListadoCategoria.CurrentRow.Cells("Estado").Value)

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If chkEliminar.CheckState = CheckState.Checked Then

            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataListadoCategoria.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim codigoEliminar As String = Convert.ToString(row.Cells("Codigo").Value)
                            Dim dts As New Usuario
                            Dim func As New UsuarioDAO
                            dts.UsuarioCodigo = codigoEliminar

                            If func.eliminar(dts) Then

                            Else
                                MessageBox.Show("Usuario no fue eliminado", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub FormUsuario_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    End Sub

    Private Sub SlidePanel1_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub BunifuCards5_MouseMove(sender As Object, e As MouseEventArgs) Handles BunifuCards5.MouseMove

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Botones(True, False, False, True)
        habilitar(False)
        mostrar()
        txtCodigo.Text = objeto.generarcodigo
    End Sub
End Class