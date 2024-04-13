Imports CapaPersistencia

Public Class FormMostrarListaCliente
    Private dt As New DataTable
    Private Sub FormMostrarListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ClienteDAO
            dt = func.mostrar
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
            MsgBox(ex.Message)

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
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub ocultar_columnas()


        dataListaCliente.Columns(4).Visible = False
        dataListaCliente.Columns(5).Visible = False
        dataListaCliente.Columns(6).Visible = False
        'dataListaCliente.Columns(7).Visible = False
        dataListaCliente.Columns(8).Visible = False
        dataListaCliente.Columns(9).Visible = False
        dataListaCliente.Columns(10).Visible = False

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dataListaCliente_DoubleClick(sender As Object, e As EventArgs) Handles dataListaCliente.DoubleClick
        If txtflag.Text = "1" Then
            FormVenta.txtCodigoCliente.Text = dataListaCliente.SelectedCells.Item(0).Value.ToString
            FormVenta.txtNombreCliente.Text = dataListaCliente.SelectedCells.Item(1).Value.ToString
            Me.Close()
        End If

    End Sub

    Private Sub dataListaCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class