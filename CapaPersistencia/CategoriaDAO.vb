Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Windows.Forms
Imports CapaDominio

Public Class CategoriaDAO
    Inherits Conexion


    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter



    Public Function mostrarCategoria() As DataTable
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spMostrarCategoria")
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

    Public Function insertarCategoria(ByVal ca As Categoria) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spInsertarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@CategoriaCodigo", ca.CategoriaCodigo)
            cmd.Parameters.AddWithValue("@CategoriaNombre", ca.CategoriaNombre)
            cmd.Parameters.AddWithValue("@CategoriaDescripcion", ca.CategoriaDescripcion)
            cmd.Parameters.AddWithValue("@CategoriaEstado", ca.CategoriaEstado)



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


    Public Function editarCategoria(ByVal ca As Categoria) As Boolean
        Try
            ConexionAbierta()
            cmd = New SqlCommand("spModificarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@CategoriaCodigo", SqlDbType.NChar, 10).Value = ca.CategoriaCodigo
            cmd.Parameters.Add("@CategoriaNombre", SqlDbType.NVarChar, 50).Value = ca.CategoriaNombre
            cmd.Parameters.Add("@CategoriaDescripcion", SqlDbType.NVarChar, 100).Value = ca.CategoriaDescripcion
            cmd.Parameters.Add("@CategoriaEstado", SqlDbType.NChar, 1).Value = ca.CategoriaEstado

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
    Public Function eliminarCategoria(ByVal ca As Categoria) As Boolean
        Try

            ConexionAbierta()
            cmd = New SqlCommand("spEliminarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@CategoriaCodigo", SqlDbType.NChar, 10).Value = ca.CategoriaCodigo

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





    Public Function generarcodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            cmd = New SqlCommand("select count(*) as total from TiendaVentas.Categoria", conen)
            dr = cmd.ExecuteReader
            If dr.Read Then
                total = CInt(dr.Item("total"))
            End If
            dr.Close()
            If total < 10 Then
                codigo = "CA-0000" + total.ToString
            ElseIf total < 100 Then
                codigo = "CA-000" + total.ToString '10 C-00010
            ElseIf total < 1000 Then
                codigo = "CA-00" + total.ToString
            ElseIf total < 10000 Then
                codigo = "CA-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa" + ex.ToString)
        End Try
        Return codigo
    End Function
End Class
