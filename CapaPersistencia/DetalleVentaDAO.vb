Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class DetalleVentaDAO
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarDeatlleVenta")
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
            MessageBox.Show("Error al intentar mostrar de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return Nothing
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function insertar(ByVal dts As DetalleVenta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarDetalleVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@DetalleVentaCodigo", dts.DetalleVentaCodigo)
            cmd.Parameters.AddWithValue("@VentaCodigo", dts.VentaCodigo)
            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@DetalleVentaPrecio", dts.DetalleVentaPrecio)
            cmd.Parameters.AddWithValue("@DetalleVentaCantidad", dts.DetalleVentaCantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar insetar de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function



    Public Function editar(ByVal dts As DetalleVenta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEditarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@DetalleVentaCodigo", dts.DetalleVentaCodigo)
            cmd.Parameters.AddWithValue("@VentaCodigo", dts.VentaCodigo)
            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@DetalleVentaPrecio", dts.DetalleVentaPrecio)
            cmd.Parameters.AddWithValue("@DetalleVentaCantidad", dts.DetalleVentaCantidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar editar de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try
    End Function
    Public Function eliminar(ByVal dts As DetalleVenta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarDetalleVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@DetalleVentaCodigo", SqlDbType.NChar, 10).Value = dts.DetalleVentaCodigo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        End Try
    End Function

    Public Function aumentarStock(ByVal dts As DetalleVenta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spAumentarStockProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoCantidad", dts.DetalleVentaCantidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar aumentar en la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
            Return False
        Finally
            ConexionCerrada()
        End Try

    End Function

    Public Function disminuirStock(ByVal dts As DetalleVenta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spDisminuirStockProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ProductoCodigo", dts.ProductoCodigo)
            cmd.Parameters.AddWithValue("@ProductoCantidad", dts.DetalleVentaCantidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al intentar disminuir en la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
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
            cmd = New SqlCommand("select count(*) as total from TiendaVentas.DetalleVenta", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "DV-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "DV-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "DV-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "DV-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try
        Return codigo
    End Function
End Class
