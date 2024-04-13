Imports System.Runtime.InteropServices

Public Class FormMenuPrincipalSV

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub MostrarMenu_Tick(sender As Object, e As EventArgs) Handles MostrarMenu.Tick
        If panelmenu.Width >= 220 Then
            Me.MostrarMenu.Enabled = False
        Else
            Me.panelmenu.Width = panelmenu.Width + 20

        End If
    End Sub
    Sub obtnerdatos()
        Dim a As New FormVenta
        a.txtNombreUsuario.Text = lblNombre.Text
        a.txtCodigoUsuario.Text = lblDni.Text
    End Sub
    Private Sub OcultarMenu_Tick(sender As Object, e As EventArgs) Handles OcultarMenu.Tick
        If panelmenu.Width <= 60 Then
            Me.OcultarMenu.Enabled = False
        Else
            Me.panelmenu.Width = panelmenu.Width - 20
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Dim d As New FormLogin
        d.Show()
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.btnMaximizar.Visible = True
        Me.btnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.btnMaximizar.Visible = False
        Me.btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuDeslizar_Click(sender As Object, e As EventArgs) Handles menuDeslizar.Click
        If panelmenu.Width = 220 Then
            OcultarMenu.Enabled = True
        ElseIf panelmenu.Width = 60 Then
            MostrarMenu.Enabled = True


        End If
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        If panelMovimientos.Visible = True Then
            panelMovimientos.Visible = False
        Else
            panelMovimientos.Visible = True
        End If


        btnMovimientos.Location = New Point(0, 57)
        '98
        panelMovimientos.Location = New Point(0, 96)
        btnProcesos.Location = New Point(0, 254)
        'btnpermisos
        btnPermisos.Location = New Point(0, 290)
        btnReportes.Location = New Point(0, 329)
        panelProcesos.Hide()
        panelPermisos.Hide()

        If panelMovimientos.Visible = False Then
            btnMovimientos.Location = New Point(0, 57)
            btnProcesos.Location = New Point(0, 96)
            '136
            btnPermisos.Location = New Point(0, 134)
            btnReportes.Location = New Point(0, 173)

        End If
    End Sub
    Private Sub abrirformualrio(ByVal forhija As Object)
        If (Me.panelContenedor.Controls.Count > 0) Then
            Me.panelContenedor.Controls.RemoveAt(0)

        End If
        Dim fh As Form = CType(forhija, Form)
        fh.TopLevel = False

        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Location = New Point(100, 50)
        '  fh.Left += 100
        fh.Show()

    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        abrirformualrio(New FormMarcaProducto())
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        abrirformualrio(New FormCategoria())
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirformualrio(FormProducto)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirformualrio(New FormCliente())
    End Sub

    Private Sub btnProcesos_Click(sender As Object, e As EventArgs) Handles btnProcesos.Click
        If panelProcesos.Visible = True Then
            panelProcesos.Visible = False
        Else
            panelProcesos.Visible = True
        End If

        btnMovimientos.Location = New Point(0, 57)
        btnProcesos.Location = New Point(0, 96)
        '215
        btnPermisos.Location = New Point(0, 215)
        btnReportes.Location = New Point(0, 252)
        '143
        panelProcesos.Location = New Point(0, 135)
        '
        panelPermisos.Location = New Point(0, 415)
        panelMovimientos.Hide()
        panelPermisos.Hide()

        If panelProcesos.Visible = False Then
            btnMovimientos.Location = New Point(0, 57)
            '96
            btnProcesos.Location = New Point(0, 96)
            '136
            btnPermisos.Location = New Point(0, 135)
            btnReportes.Location = New Point(0, 174)

        End If
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim a As New FormVenta
        a.txtNombreUsuario.Text = lblAdmin.Text
        a.txtCodigoUsuario.Text = lblDni.Text
        abrirformualrio(a)
    End Sub

    Private Sub btnPermisos_Click(sender As Object, e As EventArgs) Handles btnPermisos.Click
        If panelPermisos.Visible = True Then
            panelPermisos.Visible = False
        Else
            panelPermisos.Visible = True
        End If
        btnMovimientos.Location = New Point(0, 57)
        btnProcesos.Location = New Point(0, 96)
        btnPermisos.Location = New Point(0, 135)
        btnReportes.Location = New Point(0, 254)
        '172
        panelPermisos.Location = New Point(0, 174)

        panelMovimientos.Hide()
        panelProcesos.Hide()

        If panelPermisos.Visible = False Then
            btnMovimientos.Location = New Point(0, 57)
            '96
            btnProcesos.Location = New Point(0, 96)
            '136
            btnPermisos.Location = New Point(0, 135)
            btnReportes.Location = New Point(0, 174)

        End If
    End Sub

    Private Sub FormMenuPrincipalSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMovimientos.Location = New Point(0, 57)
        btnProcesos.Location = New Point(0, 96)
        '134
        btnPermisos.Location = New Point(0, 135)
        btnReportes.Location = New Point(0, 174)
        panelMovimientos.Hide()
        panelPermisos.Hide()
        panelProcesos.Hide()
        ' mostra()
        obtnerdatos()

    End Sub
    Private Sub mostra()
        '   lblNombre.Text = Login.Nombre
        'lblAdmin.Text = Login.Cargo

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelmenu.Width = 60 Then
            MostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub FormMenuPrincipalSV_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF0112&, 0)

    End Sub

    Private Sub panelCabezera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabezera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnDetalleVenta.Click
        abrirformualrio(New FormDetalleVentaProducto())
    End Sub

    Private Sub btnTrabajadores_Click(sender As Object, e As EventArgs) Handles btnTrabajadores.Click
        abrirformualrio(New FormTrabajador())
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        abrirformualrio(FormUsuario)
    End Sub
End Class