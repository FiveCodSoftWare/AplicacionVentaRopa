Imports CapaPersistencia
Imports MaterialSkin

Public Class FormListaCategoria

    Private dt As New DataTable
    Private Sub FormListaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)
        Me.mostrar()
    End Sub
    Public Sub mostrar()
        Try
            Dim func As New CategoriaDAO
            dt = func.mostrarCategoria
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
            MsgBox(ex.Message)
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
                dataListadoCategoria.DataSource = dv

            Else
                inexistente.Visible = True
                dataListadoCategoria.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dataListadoCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles dataListadoCategoria.MouseClick
        If txtflag.Text = "1" Then
            FormProducto.txtidcategoria.Text = dataListadoCategoria.SelectedCells.Item(0).Value
            FormProducto.txtNombreCategoria.Text = dataListadoCategoria.SelectedCells.Item(1).Value
            Me.Close()
        End If
    End Sub
End Class