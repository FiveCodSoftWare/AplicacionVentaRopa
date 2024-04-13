Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class ProductoDAO
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarProducto")
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


    Public Function insertar(ByVal dts As Producto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoCodigoBarras", dts.ProductoCodigoBarras)
            cmd.Parameters.AddWithValue("@ProductoNombre", dts.ProductoNombre)
            cmd.Parameters.AddWithValue("@ProductoDescripcion", dts.ProductoDescripcion)
            cmd.Parameters.AddWithValue("@ProductoImagen", dts.ProductoImagen)
            cmd.Parameters.AddWithValue("@ProductoStock", dts.ProductoStock)
            cmd.Parameters.AddWithValue("@ProductoPrecioCompra", dts.ProductoPrecioCompra)
            cmd.Parameters.AddWithValue("@ProductoPrecioVenta", dts.ProductoPrecioVenta)
            cmd.Parameters.AddWithValue("@CategoriaCodigo", dts.CategoriaCodigo)
            cmd.Parameters.AddWithValue("@MarcaProductoCodigo", dts.MarcaProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoEstado", dts.ProductoEstado)
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



    Public Function editar(ByVal dts As Producto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEditarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoCodigoBarras", dts.ProductoCodigoBarras)
            cmd.Parameters.AddWithValue("@ProductoNombre", dts.ProductoNombre)
            cmd.Parameters.AddWithValue("@ProductoDescripcion", dts.ProductoDescripcion)
            cmd.Parameters.AddWithValue("@ProductoImagen", dts.ProductoImagen)
            cmd.Parameters.AddWithValue("@ProductoStock", dts.ProductoStock)
            cmd.Parameters.AddWithValue("@ProductoPrecioCompra", dts.ProductoPrecioCompra)
            cmd.Parameters.AddWithValue("@ProductoPrecioVenta", dts.ProductoPrecioVenta)
            cmd.Parameters.AddWithValue("@CategoriaCodigo", dts.CategoriaCodigo)
            cmd.Parameters.AddWithValue("@MarcaProductoCodigo", dts.MarcaProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoEstado", dts.ProductoEstado)
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
    Public Function eliminar(ByVal dts As Producto) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@ProductoCodigo", SqlDbType.NChar, 10).Value = dts.ProductoCodigo
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
            cmd = New SqlCommand("select count(*) as total from TiendaVentas.Producto", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "PR-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "PR-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "PR-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "PR-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try

        Return codigo
    End Function

    Public Function generarcodigoCodigoBarras()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(ProductoCodigoBarras) as total from TiendaVentas.Producto", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If
            dr.Close()
            If total < 10 Then
                codigo = "00-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "00-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "00-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "00-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try

        Return codigo
    End Function

End Class
