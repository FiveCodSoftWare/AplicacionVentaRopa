Imports CapaPersistencia
Imports MaterialSkin

Public Class FormListaMarcaProducto

    Private dt As New DataTable
    Private Sub FormListaMarcaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        Me.mostrar()
    End Sub
    Public Sub mostrar()
        Try
            Dim func As New MarcaProductoDAO
            dt = func.mostrarMarca
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

            Else
                inexistente.Visible = True
                dataListado.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar buscar", "Sistema Venta de Ropa" + ex.Message)

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dataListado_DoubleClick(sender As Object, e As EventArgs) Handles dataListado.DoubleClick
        If txtflag.Text = "1" Then
            FormProducto.txtidMarca.Text = dataListado.SelectedCells.Item(0).Value
            FormProducto.txtNombreMarca.Text = dataListado.SelectedCells.Item(1).Value
            Me.Close()
        End If
    End Sub
End Class