Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class UsuarioDAO

    Inherits Conexion

    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter
    Public respuesta As SqlDataReader
    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt

            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar mostrar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return Nothing

        Finally
            ConexionCerrada()
        End Try
    End Function

    Public Function insertar(ByVal ca As Usuario) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spUsuarioInsertar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@UsuarioCodigo", ca.UsuarioCodigo)
            cmd.Parameters.AddWithValue("@TrabajadorCodigo", ca.TrabajadorCodigo)
            cmd.Parameters.AddWithValue("@UsuarioUserNombre", ca.UsuarioUserNombre)
            cmd.Parameters.AddWithValue("@UsuarioUsuario", ca.UsuarioUsuario)
            cmd.Parameters.AddWithValue("@UsuarioContraseña", ca.UsuarioContraseña)
            cmd.Parameters.AddWithValue("@UsuarioEstado", ca.UsuarioEstado)


            If cmd.ExecuteNonQuery = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar insertar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function editar(ByVal ca As Usuario) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spUsuarioEditar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@UsuarioCodigo", ca.UsuarioCodigo)
            cmd.Parameters.AddWithValue("@TrabajadorCodigo", ca.TrabajadorCodigo)
            cmd.Parameters.AddWithValue("@UsuarioUserNombre", ca.UsuarioUserNombre)
            cmd.Parameters.AddWithValue("@UsuarioUsuario", ca.UsuarioUsuario)
            cmd.Parameters.AddWithValue("@UsuarioContraseña", ca.UsuarioContraseña)
            cmd.Parameters.AddWithValue("@UsuarioEstado", ca.UsuarioEstado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function eliminar(ByVal ca As Usuario) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spUsuarioEliminar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@UsuarioCodigo", SqlDbType.NChar, 10).Value = ca.UsuarioCodigo

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function

    Public Function accederSistema(ByVal ca As Usuario)
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spAccederSistemaLogin")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@UsuarioNombre", ca.UsuarioUsuario)
            cmd.Parameters.AddWithValue("@UsuarioPassword", ca.UsuarioContraseña)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function
    Function usuarioRegistrado(ByVal nombreUsuario As Usuario) As Boolean
        Dim resultado As Boolean = False
        Try
            ConexionAbierta()
            cmd = New SqlCommand("Select * from Personal.Usuario where UsuarioUsuario='" & nombreUsuario.UsuarioUsuario & "'")
            cmd.Connection = cn
            respuesta = cmd.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show("Error al intentar acceder en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

        End Try
        Return resultado
    End Function
    Function contrasena(ByVal nombreUsuario As Usuario) As String
        Dim resultado As String = ""
        Try
            ConexionAbierta()
            cmd = New SqlCommand("Select UsuarioContraseña from Personal.Usuario where UsuarioUsuario='" & nombreUsuario.UsuarioUsuario & "'")
            cmd.Connection = cn
            respuesta = cmd.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("UsuarioContraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show("Error al intentar acceder en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As Usuario) As String
        Dim resultado As String = ""
        Try
            ConexionAbierta()
            cmd = New SqlCommand("Select UsuarioUserNombre from Personal.Usuario where UsuarioUsuario='" & nombreUsuario.UsuarioUsuario & "'")
            cmd.Connection = cn
            respuesta = cmd.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("UsuarioUserNombre")
            End If
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show("Error al intentar acceder en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)
        End Try
        Return resultado
    End Function

    Function Consultarcodigo(ByVal nombreUsuario As Usuario) As String
        Dim resultado As String = ""
        Try
            ConexionAbierta()
            cmd = New SqlCommand("Select UsuarioCodigo from Personal.Usuario where UsuarioUsuario='" & nombreUsuario.UsuarioUsuario & "'")
            cmd.Connection = cn
            respuesta = cmd.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("UsuarioCodigo")
            End If
            respuesta.Close()
        Catch ex As Exception
            MessageBox.Show("Error al intentar acceder en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)
        End Try
        Return resultado
    End Function
    Public Function generarcodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(*) as total from Personal.Usuario", cn)

            respuesta = cmd.ExecuteReader

            If respuesta.Read Then
                total = CInt(respuesta.Item("total"))
            End If

            respuesta.Close()
            If total < 10 Then
                codigo = "US-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "US-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "US-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "US-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try
        Return codigo
    End Function
End Class
