Imports CapaDominio
Imports CapaPersistencia
Imports MaterialSkin

Public Class FormProducto
    Private dt As New DataTable
    Dim objeto As New ProductoDAO
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        txtCodigo.Text = objeto.generarcodigo
        txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
        Botones(True, False, False, True)
        habilitarcampos(False)
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

    Private Sub Botones(Nuevo As Boolean, Agregar As Boolean, Editar As Boolean, Cancelar As Boolean)
        btnNuevo.Enabled = Nuevo
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnCancelar.Enabled = Cancelar
    End Sub

    Sub habilitarcampos(a As Boolean)
        txtCodigo.Enabled = False
        txtNombre.Enabled = a
        txtNombre.Enabled = a
        txtDescripcion.Enabled = a
        txtStock.Enabled = a
        txtPrecioCompra.Enabled = a
        txtPrecioVenta.Enabled = a
        txtCodigoBarras.Enabled = False
        txtidcategoria.Enabled = False
        txtidMarca.Enabled = False
        txtNombreCategoria.Enabled = False
        txtNombreMarca.Enabled = False
        cboEstado.Enabled = a

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

        dataListadoProducto.Columns(0).Visible = False
        dataListadoProducto.Columns(9).Visible = False
        dataListadoProducto.Columns(11).Visible = False


    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtStock.Text = "0"
        txtPrecioCompra.Text = "0"
        txtPrecioVenta.Text = "0"
        'txtCodigoBarras.Text = ""
        txtidcategoria.Text = ""
        txtidMarca.Text = ""
        txtNombreCategoria.Text = ""
        txtNombreMarca.Text = ""
        pImagen.Image = Nothing
        pImagen.BackgroundImage = My.Resources._new
        pImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And cboEstado.Text <> "" And txtStock.Text <> "" And txtPrecioCompra.Text <> "" And txtPrecioVenta.Text <> "" Then
            Try
                Dim dts As New Producto
                Dim func As New ProductoDAO

                dts.ProductoCodigo = txtCodigo.Text
                dts.CategoriaCodigo = txtidcategoria.Text
                dts.MarcaProductoCodigo = txtidMarca.Text
                dts.ProductoNombre = txtNombre.Text
                dts.ProductoCodigoBarras = txtCodigoBarras.Text
                dts.ProductoDescripcion = txtDescripcion.Text
                dts.ProductoStock = txtStock.Text
                dts.ProductoPrecioCompra = txtPrecioCompra.Text
                dts.ProductoPrecioVenta = txtPrecioVenta.Text
                dts.ProductoEstado = cboEstado.Text
                Dim ms As New IO.MemoryStream()

                If Not pImagen.Image Is Nothing Then
                    pImagen.Image.Save(ms, pImagen.Image.RawFormat)
                Else
                    pImagen.Image = My.Resources._new
                    pImagen.Image.Save(ms, pImagen.Image.RawFormat)
                End If
                dts.ProductoImagen = ms.GetBuffer
                If func.insertar(dts) Then
                    MessageBox.Show("Se registro correctamente el Producto", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
                    limpiar()
                    habilitarcampos(False)
                    Botones(True, False, False, True)
                Else
                    MessageBox.Show("El producto no se registro", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    txtCodigo.Text = objeto.generarcodigo
                    txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
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

        result = MessageBox.Show("Realmente desea editar los datos del producto?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtDescripcion.Text <> "" And txtStock.Text <> "" And txtPrecioCompra.Text <> "" And txtPrecioVenta.Text <> "" And txtCodigo.Text <> "" Then
                Try
                    Dim dts As New Producto
                    Dim func As New ProductoDAO
                    dts.ProductoCodigo = txtCodigo.Text
                    dts.CategoriaCodigo = txtidcategoria.Text
                    dts.MarcaProductoCodigo = txtidMarca.Text
                    dts.ProductoNombre = txtNombre.Text
                    dts.ProductoCodigoBarras = txtCodigoBarras.Text
                    dts.ProductoDescripcion = txtDescripcion.Text
                    dts.ProductoStock = txtStock.Text
                    dts.ProductoPrecioCompra = txtPrecioCompra.Text
                    dts.ProductoPrecioVenta = txtPrecioVenta.Text
                    dts.ProductoEstado = cboEstado.Text


                    Dim ms As New IO.MemoryStream()

                    If Not pImagen.Image Is Nothing Then
                        pImagen.Image.Save(ms, pImagen.Image.RawFormat)
                    Else
                        pImagen.Image = My.Resources._new
                        pImagen.Image.Save(ms, pImagen.Image.RawFormat)
                    End If

                    dts.ProductoImagen = ms.GetBuffer


                    If func.editar(dts) Then
                        MessageBox.Show("Producto Modificado correctamente", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
                        habilitarcampos(False)
                        Botones(True, False, False, True)
                        limpiar()
                    Else
                        MessageBox.Show("Producto no fue Modificado intente de nuevo", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        txtCodigo.Text = objeto.generarcodigo
                        txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
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
        limpiar()
        txtCodigo.Text = objeto.generarcodigo
        txtCodigoBarras.Text = objeto.generarcodigoCodigoBarras
        Botones(True, False, False, True)
        habilitarcampos(False)
        mostrar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If chkEliminar.CheckState = CheckState.Checked Then


            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar?", "Sistema Venta de Ropa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then

                Try
                    For Each row As DataGridViewRow In dataListadoProducto.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                        If marcado Then
                            Dim onekey As String = Convert.ToString(row.Cells("Codigo").Value)
                            Dim vdb As New Producto
                            Dim func As New ProductoDAO
                            vdb.ProductoCodigo = onekey
                            If func.eliminar(vdb) Then
                            Else
                                MessageBox.Show("Producto no fue Eliminado", "Sistema Venta de Ropa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        btnEliminar.Enabled = True
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListadoProducto.Columns.Item("Eliminar").Visible = True
        Else
            dataListadoProducto.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            pImagen.BackgroundImage = Nothing
            pImagen.Image = New Bitmap(dlg.FileName)
            pImagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        pImagen.Image = Nothing
        pImagen.BackgroundImage = My.Resources._new
        pImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnSelecionarca_Click(sender As Object, e As EventArgs) Handles btnSelecionarca.Click
        FormListaCategoria.txtflag.Text = "1"
        FormListaCategoria.ShowDialog()
    End Sub

    Private Sub btnSelecionarMa_Click(sender As Object, e As EventArgs) Handles btnSelecionarMa.Click
        FormListaMarcaProducto.txtflag.Text = "1"
        FormListaMarcaProducto.ShowDialog()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        habilitarcampos(True)
        txtNombre.Focus()
        Botones(True, True, False, True)
        mostrar()
    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un nombre para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub



    Private Sub dataListadoProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProducto.CellContentClick
        If e.ColumnIndex = Me.dataListadoProducto.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListadoProducto.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub dataListadoProducto_DoubleClick(sender As Object, e As EventArgs) Handles dataListadoProducto.DoubleClick
        Botones(True, False, True, True)
        habilitarcampos(True)
        Me.txtCodigo.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Codigo").Value)
        Me.txtCodigoBarras.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Codigo Barras").Value)
        Me.txtNombre.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Nombre").Value)
        Me.txtDescripcion.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Descripcion").Value)
        pImagen.BackgroundImage = Nothing

        Dim b() As Byte = dataListadoProducto.SelectedCells.Item(5).Value
        Dim ms As New IO.MemoryStream(b)

        pImagen.Image = Image.FromStream(ms)
        pImagen.SizeMode = PictureBoxSizeMode.StretchImage

        Me.txtStock.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Stock").Value)
        Me.txtPrecioCompra.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Precio Compra").Value)
        Me.txtPrecioVenta.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Precio Venta").Value)
        Me.txtidcategoria.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("CategoriaCodigo").Value)
        Me.txtNombreCategoria.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Nombre_Categoria").Value)
        Me.txtidMarca.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("MarcaProductoCodigo").Value)
        Me.txtNombreMarca.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Nombre Marca").Value)
        Me.cboEstado.Text = Convert.ToString(Me.dataListadoProducto.CurrentRow.Cells("Estado").Value)
        materialTabControl1.SelectedIndex = 1
    End Sub



    Private Sub cboEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboEstado.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = -1 Then
            Me.errorIcono.SetError(sender, "Falta Seleccionar El Estado del Producto")
        Else
            Me.errorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub txtPrecioCompra_Validated(sender As Object, e As EventArgs) Handles txtPrecioCompra.Validated
        If DirectCast(sender, DevComponents.DotNetBar.Controls.TextBoxX).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese Precio Compra para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtStock_Validated(sender As Object, e As EventArgs) Handles txtStock.Validated
        If DirectCast(sender, DevComponents.DotNetBar.Controls.TextBoxX).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese Stock para el Producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtPrecioVenta_Validated(sender As Object, e As EventArgs) Handles txtPrecioVenta.Validated
        If DirectCast(sender, DevComponents.DotNetBar.Controls.TextBoxX).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese Precio de Venta para el Producto, este dato es obligatorio")
        End If
    End Sub
End Class