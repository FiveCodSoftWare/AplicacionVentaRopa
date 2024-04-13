Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class ClienteDAO
    Inherits Conexion
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spClientesMostrar")
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


    Public Function insertar(ByVal dts As Cliente) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@ClienteCodigo", dts.ClienteCodigo)
            cmd.Parameters.AddWithValue("@ClientePaterno", dts.ClientePaterno)
            cmd.Parameters.AddWithValue("@ClienteMaterno", dts.ClienteMaterno)
            cmd.Parameters.AddWithValue("@ClienteNombre", dts.ClienteNombre)
            cmd.Parameters.AddWithValue("@ClienteGenero", dts.ClienteGenero)
            cmd.Parameters.AddWithValue("@ClienteFechaNacimiento", dts.ClienteFechaNacimiento)
            cmd.Parameters.AddWithValue("@ClienteTipoDocumento", dts.ClienteTipoDocumento)
            cmd.Parameters.AddWithValue("@ClienteNumeroDocumento", dts.ClienteNumeroDocumento)
            cmd.Parameters.AddWithValue("@ClienteDireccion", dts.ClienteDireccion)
            cmd.Parameters.AddWithValue("@ClienteTelefono", dts.ClienteTelefono)
            cmd.Parameters.AddWithValue("@ClienteEmail", dts.ClienteEmail)
            cmd.Parameters.AddWithValue("@ClienteEstado", dts.ClienteEstado)

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



    Public Function editar(ByVal dts As Cliente) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEditarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@ClienteCodigo", dts.ClienteCodigo)
            cmd.Parameters.AddWithValue("@ClientePaterno", dts.ClientePaterno)
            cmd.Parameters.AddWithValue("@ClienteMaterno", dts.ClienteMaterno)
            cmd.Parameters.AddWithValue("@ClienteNombre", dts.ClienteNombre)
            cmd.Parameters.AddWithValue("@ClienteGenero", dts.ClienteGenero)
            cmd.Parameters.AddWithValue("@ClienteFechaNacimiento", dts.ClienteFechaNacimiento)
            cmd.Parameters.AddWithValue("@ClienteTipoDocumento", dts.ClienteTipoDocumento)
            cmd.Parameters.AddWithValue("@ClienteNumeroDocumento", dts.ClienteNumeroDocumento)
            cmd.Parameters.AddWithValue("@ClienteDireccion", dts.ClienteDireccion)
            cmd.Parameters.AddWithValue("@ClienteTelefono", dts.ClienteTelefono)
            cmd.Parameters.AddWithValue("@ClienteEmail", dts.ClienteEmail)
            cmd.Parameters.AddWithValue("@ClienteEstado", dts.ClienteEstado)

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
    Public Function eliminar(ByVal dts As Cliente) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@ClienteCodigo", SqlDbType.NChar, 10).Value = dts.ClienteCodigo
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
            cmd = New SqlCommand("select count(*) as total from Personal.Cliente", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "CL-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "CL-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "CL-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "CL-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try

        Return codigo
    End Function


End Class
