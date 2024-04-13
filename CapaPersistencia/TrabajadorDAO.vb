Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class TrabajadorDAO
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarTrabajador")
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


    Public Function insertar(ByVal dts As Trabajador) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarTrabajador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@TrabajadorCodigo", dts.TrabajadorCodigo)
            cmd.Parameters.AddWithValue("@TrabajadorPaterno", dts.TrabajadorPaterno)
            cmd.Parameters.AddWithValue("@TrabajadorMaterno", dts.TrabajadorMaterno)
            cmd.Parameters.AddWithValue("@TrabajadorNombre", dts.TrabajadorNombre)
            cmd.Parameters.AddWithValue("@TrabajadorGenero", dts.TrabajadorGenero)
            cmd.Parameters.AddWithValue("@TrabajadorFechaNacimiento", dts.TrabajadorFechaNacimiento)
            cmd.Parameters.AddWithValue("@TrabajadorNumeroDocumento", dts.TrabajadorNumeroDocumento)
            cmd.Parameters.AddWithValue("@TrabajadorDireccion", dts.TrabajadorDireccion)
            cmd.Parameters.AddWithValue("@TrabajadorTelefono", dts.TrabajadorTelefono)
            cmd.Parameters.AddWithValue("@TrabajadorEmail", dts.TrabajadorEmail)
            cmd.Parameters.AddWithValue("@TrabajadorFechaRegistrado", dts.TrabajadorFechaRegistrado)
            cmd.Parameters.AddWithValue("@TrabajadorEstado", dts.TrabajadorEstado)

            If cmd.ExecuteNonQuery Then
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



    Public Function editar(ByVal dts As Trabajador) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEditarTrabajador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@TrabajadorCodigo", dts.TrabajadorCodigo)
            cmd.Parameters.AddWithValue("@TrabajadorPaterno", dts.TrabajadorPaterno)
            cmd.Parameters.AddWithValue("@TrabajadorMaterno", dts.TrabajadorMaterno)
            cmd.Parameters.AddWithValue("@TrabajadorNombre", dts.TrabajadorNombre)
            cmd.Parameters.AddWithValue("@TrabajadorGenero", dts.TrabajadorGenero)
            cmd.Parameters.AddWithValue("@TrabajadorFechaNacimiento", dts.TrabajadorFechaNacimiento)
            cmd.Parameters.AddWithValue("@TrabajadorNumeroDocumento", dts.TrabajadorNumeroDocumento)
            cmd.Parameters.AddWithValue("@TrabajadorDireccion", dts.TrabajadorDireccion)
            cmd.Parameters.AddWithValue("@TrabajadorTelefono", dts.TrabajadorTelefono)
            cmd.Parameters.AddWithValue("@TrabajadorEmail", dts.TrabajadorEmail)
            cmd.Parameters.AddWithValue("@TrabajadorFechaRegistrado", dts.TrabajadorFechaRegistrado)
            cmd.Parameters.AddWithValue("@TrabajadorEstado", dts.TrabajadorEstado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar modificar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function
    Public Function eliminar(ByVal dts As Trabajador) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarTrabajador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@TrabajadorCodigo", SqlDbType.NChar, 10).Value = dts.TrabajadorCodigo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar en la capa persistencia", "Sistema Venta de Ropa" + ex.Message)

            Return False

        End Try
    End Function

    Public Function generarcodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(*) as total from Personal.Trabajador", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "TR-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "TR-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "TR-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "TR-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try
        Return codigo
    End Function
End Class
