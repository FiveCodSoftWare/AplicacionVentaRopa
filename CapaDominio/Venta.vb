Public Class Venta
    Dim _VentaCodigo, _ClienteCodigo As String
    Dim _VentaFecha As Date
    Dim _VentaTipoComprobante As String
    Dim _VentaNumeroComprobante As String
    Dim _UsuarioCodigo As String

    Public Property VentaCodigo As String
        Get
            Return _VentaCodigo
        End Get
        Set(value As String)
            _VentaCodigo = value
        End Set
    End Property

    Public Property ClienteCodigo As String
        Get
            Return _ClienteCodigo
        End Get
        Set(value As String)
            _ClienteCodigo = value
        End Set
    End Property

    Public Property VentaFecha As Date
        Get
            Return _VentaFecha
        End Get
        Set(value As Date)
            _VentaFecha = value
        End Set
    End Property

    Public Property VentaTipoComprobante As String
        Get
            Return _VentaTipoComprobante
        End Get
        Set(value As String)
            _VentaTipoComprobante = value
        End Set
    End Property

    Public Property VentaNumeroComprobante As Double
        Get
            Return _VentaNumeroComprobante
        End Get
        Set(value As Double)
            _VentaNumeroComprobante = value
        End Set
    End Property

    Public Property UsuarioCodigo As String
        Get
            Return _UsuarioCodigo
        End Get
        Set(value As String)
            _UsuarioCodigo = value
        End Set
    End Property


    Public Sub New()

    End Sub


    Public Sub New(ByVal ventco As String, ByVal clienteco As String, ByVal fechave As Date, ByVal tipocon As String, ByVal num As String, ByVal usuari As String)

        Me.VentaCodigo = ventco
        Me.ClienteCodigo = clienteco
        Me.VentaFecha = fechave
        Me.VentaTipoComprobante = tipocon
        Me.VentaNumeroComprobante = num
        Me.UsuarioCodigo = usuari

    End Sub
End Class
