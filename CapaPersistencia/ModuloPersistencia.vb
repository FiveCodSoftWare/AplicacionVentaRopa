Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module ModuloPersistencia
    Public conen As SqlConnection
    Sub New()
        Try
            conen = New SqlConnection("Data Source=.;Initial Catalog=SistemaVentaRopaTrujillo;Integrated Security=True")
            conen.Open()
        Catch ex As Exception
            MessageBox.Show("Error el la conexion de la capa persistencia", "Sistema Venta de Ropa")
        End Try


    End Sub

End Module
