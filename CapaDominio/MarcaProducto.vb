Public Class MarcaProducto
    Dim _MarcaProductoCodigo, _MarcaProductoNombre, _MarcaProductoDescripcion, _MarcaProductoEstado As String

    Public Property MarcaProductoCodigo As String
        Get
            Return _MarcaProductoCodigo
        End Get
        Set(value As String)
            _MarcaProductoCodigo = value
        End Set
    End Property

    Public Property MarcaProductoDescripcion As String
        Get
            Return _MarcaProductoDescripcion
        End Get
        Set(value As String)
            _MarcaProductoDescripcion = value
        End Set
    End Property

    Public Property MarcaProductoEstado As String
        Get
            Return _MarcaProductoEstado
        End Get
        Set(value As String)
            _MarcaProductoEstado = value
        End Set
    End Property

    Public Property MarcaProductoNombre As String
        Get
            Return _MarcaProductoNombre
        End Get
        Set(value As String)
            _MarcaProductoNombre = value
        End Set
    End Property
End Class
