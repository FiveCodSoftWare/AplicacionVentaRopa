Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports CapaDominio
Imports CapaPersistencia

Public Class FormLogin
    Dim loguear As SqlDataReader
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Dim tipoAdministrado As String = "Administrador"
    Dim tipoEmpleado As String = "Empleado"





    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim nombreusuario As New Usuario
            Dim fun As New UsuarioDAO
            nombreusuario.UsuarioUsuario = txtUsuario.Text
            If fun.usuarioRegistrado(nombreusuario) = True Then

                Dim contra As String = fun.contrasena(nombreusuario)
                If contra.Equals(txtPassword.Text) = True Then
                    Me.Hide()
                    If fun.ConsultarTipoUsuario(nombreusuario) = tipoAdministrado Then
                        If (tipoAdministrado = "Administrador") Then
                            Dim s As New FormMenuPrincipalSV
                            s.Show()
                            s.lblDni.Text = fun.Consultarcodigo(nombreusuario)

                            s.lblNombre.Text = txtUsuario.Text
                            s.lblAdmin.Text = tipoAdministrado
                        End If
                    ElseIf fun.ConsultarTipoUsuario(nombreusuario) = tipoEmpleado Then
                        If (tipoEmpleado = "Empleado") Then
                            Dim d As New FormMenuPrincipalSV
                            d.btnClientes.Enabled = False
                            d.btnMarcas.Enabled = False
                            d.btnCategorias.Enabled = False
                            d.btnProductos.Enabled = False
                            d.btnDetalleVenta.Enabled = False
                            d.btnTrabajadores.Enabled = False
                            d.btnUsuarios.Enabled = False
                            d.Show()
                            d.lblDni.Text = fun.Consultarcodigo(nombreusuario)
                            d.lblNombre.Text = txtUsuario.Text
                            d.lblAdmin.Text = tipoEmpleado
                        End If
                    Else
                        FormMenuPrincipalSV.Show()
                    End If
                Else
                    lblPassword.Text = ("Contraseña Invalida")

                End If
            Else
                lblUsuario.Text = ("El Usuario: " + txtUsuario.Text + " no se encuentra registrado")
            End If
















            'Dim dts As New Usuario

            'Dim fun As New UsuarioDAO
            'dts.UsuarioUsuario = txtUsuario.Text
            'dts.UsuarioContraseña = txtPassword.Text


            'If fun.accederSistema(dts) = True Then

            '    Me.Hide()
            '    Dim f As New FormMenuPrincipalSV


            '    f.Show()
            '    '   Login.Cargo = loguear("UsuarioUserNombre").ToString



            'ElseIf (txtUsuario.Text = "") Then
            '    lblUsuario.Text = "Ingrese Usuario"

            'ElseIf (txtPassword.Text = "") Then

            '    lblPassword.Text = "Ingrese Password"
            'Else
            '    lblErroalAcceder.Text = "Los Datos Ingresados Son Incorrectos"
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        lblPassword.Text = ""
        lblErroalAcceder.Text = ""
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        lblUsuario.Text = ""
        lblErroalAcceder.Text = ""
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        If (btnSingup.Text = "Sign in") Then
            panel1.Left -= 10
            panel2.Left -= 10
            line1()
            If (panel1.Left <= -310) Then
                Tiempo.Stop()


            End If
        ElseIf (btnSingup.Text = "Sign up") Then
            panel1.Left += 10
            panel2.Left += 10
            line2()
            If (panel1.Left >= 0) Then
                Tiempo.Stop()
            End If
        End If
    End Sub
    Public Sub line1()
        If (panel1.Left = 0) Then

            bunifuSeparator2.LineThickness = 2
            bunifuSeparator2.LineColor = Color.FromArgb(31, 143, 15)
            bunifuSeparator1.LineThickness = 1
            bunifuSeparator1.LineColor = Color.Silver
        End If
    End Sub
    Public Sub line2()

        If (panel1.Left = 0) Then
            bunifuSeparator2.LineThickness = 1
            bunifuSeparator2.LineColor = Color.Silver
            bunifuSeparator1.LineThickness = 2
            bunifuSeparator1.LineColor = Color.FromArgb(0, 122, 204)
        End If
    End Sub
    Private Sub btnSingup_Click(sender As Object, e As EventArgs) Handles btnSingup.Click
        If (btnSingup.Text = "Sign up") Then
            btnSingup.Text = "Sign in"
            Tiempo.Start()
            Panel3.BackColor = Color.FromArgb(31, 143, 15)

        ElseIf (btnSingup.Text = "Sign in") Then
            btnSingup.Text = "Sign up"
            Tiempo.Start()
            Panel3.BackColor = Color.FromArgb(0, 122, 204)
        End If
    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
