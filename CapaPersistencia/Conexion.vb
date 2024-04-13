Imports System.Data.SqlClient

Public Class Conexion
    Protected cn As New SqlConnection

    Public CodigoUsuario As String

    Protected Function ConexionAbierta()
        Try

            cn = New SqlConnection("Data Source=.;Initial Catalog=SistemaVentaRopaTrujillo;Integrated Security=True")
            cn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Protected Function ConexionCerrada()
        Try

            If cn.State = ConnectionState.Open Then
                cn.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
