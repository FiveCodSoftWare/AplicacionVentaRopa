Imports CapaPersistencia
Imports MaterialSkin

Public Class FormMostrarListaTrabajadores
    Dim dt As New DataTable
    Private Sub FormMostrarListaTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Red500, Primary.Green900, Accent.Red700, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow700, Primary.Red500, Primary.Lime900, Accent.Red700, TextShade.WHITE)

        mostrarBontones()
    End Sub
    Private Sub mostrarBontones()
        Try
            Dim func As New TrabajadorDAO
            dt = func.mostrar
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
            MsgBox(ex.Message)

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
                ocultarColumna()

            Else
                inexistente.Visible = True
                datlistaTrabajadores.DataSource = Nothing
                ocultarColumna()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub ocultarColumna()
        datlistaTrabajadores.Columns(5).Visible = False
        datlistaTrabajadores.Columns(7).Visible = False
        datlistaTrabajadores.Columns(8).Visible = False
        datlistaTrabajadores.Columns(9).Visible = False
    End Sub

    Private Sub datlistaTrabajadores_DoubleClick(sender As Object, e As EventArgs) Handles datlistaTrabajadores.DoubleClick
        If txtflag.Text = "1" Then
            FormUsuario.txtCodigoTrabajador.Text = datlistaTrabajadores.SelectedCells.Item(0).Value
            FormUsuario.txtNombre.Text = datlistaTrabajadores.SelectedCells.Item(3).Value
            Me.Close()

        End If
    End Sub
End Class