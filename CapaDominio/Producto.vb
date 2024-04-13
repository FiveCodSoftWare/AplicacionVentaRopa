Public Class Producto

    Dim _ProductoCodigo As String
    Dim _ProductoCodigoBarras As String
    Dim _ProductoNombre As String
    Dim _ProductoDescripcion As String
    Dim _ProductoImagen() As Byte
    Dim _ProductoStock As Integer
    Dim _ProductoPrecioCompra As Double
    Dim _ProductoPrecioVenta As Double
    Dim _CategoriaCodigo As String
    Dim _MarcaProductoCodigo As String
    Dim _ProductoEstado As String

    Public Property ProductoCodigo As String
        Get
            Return _ProductoCodigo
        End Get
        Set(value As String)
            _ProductoCodigo = value
        End Set
    End Property

    Public Property ProductoCodigoBarras As String
        Get
            Return _ProductoCodigoBarras
        End Get
        Set(value As String)
            _ProductoCodigoBarras = value
        End Set
    End Property

    Public Property ProductoNombre As String
        Get
            Return _ProductoNombre
        End Get
        Set(value As String)
            _ProductoNombre = value
        End Set
    End Property

    Public Property ProductoDescripcion As String
        Get
            Return _ProductoDescripcion
        End Get
        Set(value As String)
            _ProductoDescripcion = value
        End Set
    End Property

    Public Property ProductoImagen As Byte()
        Get
            Return _ProductoImagen
        End Get
        Set(value As Byte())
            _ProductoImagen = value
        End Set
    End Property

    Public Property ProductoStock As Double
        Get
            Return _ProductoStock
        End Get
        Set(value As Double)
            _ProductoStock = value
        End Set
    End Property

    Public Property ProductoPrecioCompra As Double
        Get
            Return _ProductoPrecioCompra
        End Get
        Set(value As Double)
            _ProductoPrecioCompra = value
        End Set
    End Property

    Public Property ProductoPrecioVenta As Double
        Get
            Return _ProductoPrecioVenta
        End Get
        Set(value As Double)
            _ProductoPrecioVenta = value
        End Set
    End Property

    Public Property CategoriaCodigo As String
        Get
            Return _CategoriaCodigo
        End Get
        Set(value As String)
            _CategoriaCodigo = value
        End Set
    End Property

    Public Property MarcaProductoCodigo As String
        Get
            Return _MarcaProductoCodigo
        End Get
        Set(value As String)
            _MarcaProductoCodigo = value
        End Set
    End Property

    Public Property ProductoEstado As String
        Get
            Return _ProductoEstado
        End Get
        Set(value As String)
            _ProductoEstado = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal codiproducto As String, ByVal codigobarras As String,
                   ByVal nombre As String, ByVal descripcion As String,
                   ByVal imagen() As Byte, ByVal stock As Integer,
                   ByVal preciocompra As Double, ByVal precioventa As Double,
                   ByVal codigocate As String, ByVal codigomar As String,
                   ByVal estado As String)

        Me.CategoriaCodigo = codiproducto
        Me.ProductoCodigoBarras = codigobarras
        Me.ProductoNombre = nombre
        Me.ProductoDescripcion = descripcion
        Me.ProductoImagen = imagen
        Me.ProductoStock = stock
        Me.ProductoPrecioCompra = preciocompra
        Me.ProductoPrecioVenta = precioventa
        Me.CategoriaCodigo = codigocate
        Me.MarcaProductoCodigo = codigomar



    End Sub
End Class
