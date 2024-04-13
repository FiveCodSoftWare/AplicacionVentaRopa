Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class MarcaProductoDAO
    Inherits Conexion
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand

    Public Function mostrarMarca() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarMarcaProducto")
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
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return Nothing

        Finally
            ConexionCerrada()
        End Try
    End Function

    Public Function insertarMarca(ByVal ma As MarcaProducto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarMarcaProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@MarcaProductoCodigo", ma.MarcaProductoCodigo)
            cmd.Parameters.AddWithValue("@MarcaProductoNombre", ma.MarcaProductoNombre)
            cmd.Parameters.AddWithValue("@MarcaProductoDescripcion", ma.MarcaProductoDescripcion)
            cmd.Parameters.AddWithValue("@MarcaProductoEstado", ma.MarcaProductoEstado)



            If cmd.ExecuteNonQuery = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function editarMarca(ByVal ma As MarcaProducto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spModificarMarcaProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("MarcaProductoCodigo", SqlDbType.NChar, 10).Value = ma.MarcaProductoCodigo
            cmd.Parameters.Add("@MarcaProductoNombre", SqlDbType.NVarChar, 50).Value = ma.MarcaProductoNombre
            cmd.Parameters.Add("@MarcaProductoDescripcion", SqlDbType.NVarChar, 150).Value = ma.MarcaProductoDescripcion
            cmd.Parameters.Add("@MarcaProductoEstado", SqlDbType.NChar, 1).Value = ma.MarcaProductoEstado

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function
    Public Function eliminarMarca(ByVal ma As MarcaProducto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarMarcaProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@MarcaProductoCodigo", SqlDbType.NChar, 10).Value = ma.MarcaProductoCodigo

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function generarcodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(*) as total from TiendaVentas.MarcaProducto", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "MA-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "MA-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "MA-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "MA-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try

        Return codigo
    End Function


End Class
