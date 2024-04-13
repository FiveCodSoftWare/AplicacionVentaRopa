Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CapaDominio

Public Class VentaDAO

    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public Function mostrar() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarVenta")
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
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionCerrada()
        End Try
    End Function


    Public Function insertar(ByVal dts As Venta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@VentaCodigo", dts.VentaCodigo)
            cmd.Parameters.AddWithValue("@ClienteCodigo", dts.ClienteCodigo)
            cmd.Parameters.AddWithValue("@VentaFecha", dts.VentaFecha)
            cmd.Parameters.AddWithValue("@VentaTipoComprobante", dts.VentaTipoComprobante)
            cmd.Parameters.AddWithValue("@VentaNumeroComprobante", dts.VentaNumeroComprobante)
            cmd.Parameters.AddWithValue("@UsuarioCodigo", dts.UsuarioCodigo)

            If cmd.ExecuteNonQuery Then
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



    Public Function editar(ByVal dts As Venta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEditarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@VentaCodigo", dts.VentaCodigo)
            cmd.Parameters.AddWithValue("@ClienteCodigo", dts.ClienteCodigo)
            cmd.Parameters.AddWithValue("@VentaFecha", dts.VentaFecha)
            cmd.Parameters.AddWithValue("@VentaTipoComprobante", dts.VentaTipoComprobante)
            cmd.Parameters.AddWithValue("@VentaNumeroComprobante", dts.VentaNumeroComprobante)
            cmd.Parameters.AddWithValue("@UsuarioCodigo", dts.UsuarioCodigo)

            If cmd.ExecuteNonQuery Then
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
    Public Function eliminar(ByVal dts As Venta) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spEliminarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@VentaCodigo", SqlDbType.NChar, 10).Value = dts.VentaCodigo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Public Function generarcodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(*) as total from TiendaVentas.Venta", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "VE-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "VE-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "VE-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "VE-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try
        Return codigo
    End Function

    Public Function generarcodigoBoletaFactura()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            ConexionAbierta()
            cmd = New SqlCommand("select count(VentaNumeroComprobante) as total from TiendaVentas.Venta", cn)

            dr = cmd.ExecuteReader

            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If

            dr.Close()
            If total < 10 Then
                codigo = "N-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "N-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "N-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "N-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        Finally
            ConexionCerrada()
        End Try
        Return codigo
    End Function
End Class
