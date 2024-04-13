Public Class DetalleVenta

    Dim _DetalleVentaCodigo, _VentaCodigo, _ProductoCodigo As String
    Dim _DetalleVentaPrecio As Double
    Dim _DetalleVentaCantidad As Integer
    Dim _DetalleVentaEstado As String

    Public Property DetalleVentaCantidad As Double
        Get
            Return _DetalleVentaCantidad
        End Get
        Set(value As Double)
            _DetalleVentaCantidad = value
        End Set
    End Property

    Public Property DetalleVentaCodigo As String
        Get
            Return _DetalleVentaCodigo
        End Get
        Set(value As String)
            _DetalleVentaCodigo = value
        End Set
    End Property

    Public Property DetalleVentaPrecio As Double
        Get
            Return _DetalleVentaPrecio
        End Get
        Set(value As Double)
            _DetalleVentaPrecio = value
        End Set
    End Property

    Public Property ProductoCodigo As String
        Get
            Return _ProductoCodigo
        End Get
        Set(value As String)
            _ProductoCodigo = value
        End Set
    End Property

    Public Property VentaCodigo As String
        Get
            Return _VentaCodigo
        End Get
        Set(value As String)
            _VentaCodigo = value
        End Set
    End Property

    Public Property DetalleVentaEstado As String
        Get
            Return _DetalleVentaEstado
        End Get
        Set(value As String)
            _DetalleVentaEstado = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal codigodetalle As String, ByVal ventacodi As String, ByVal procodigo As String, ByVal preciove As Double, ByVal cant As Integer, ByVal estado As String)
        Me.DetalleVentaCodigo = codigodetalle
        Me.VentaCodigo = ventacodi
        Me.ProductoCodigo = procodigo
        Me.DetalleVentaPrecio = preciove
        Me.DetalleVentaCantidad = cant
        Me.DetalleVentaEstado = estado
    End Sub
End Class
