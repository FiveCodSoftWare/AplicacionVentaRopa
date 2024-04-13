Public Class Categoria

    'El guion es para que no se duplique a la hora de encapsular
    'para la generacion de los Get y Set

    Dim _CategoriaCodigo As String
    Dim _CategoriaNombre As String
    Dim _CategoriaDescripcion As String
    Dim _CategoriaEstado As String

    Public Property CategoriaEstado As String
        Get
            Return _CategoriaEstado
        End Get
        Set(value As String)
            _CategoriaEstado = value
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

    Public Property CategoriaNombre As String
        Get
            Return _CategoriaNombre
        End Get
        Set(value As String)
            _CategoriaNombre = value
        End Set
    End Property

    Public Property CategoriaDescripcion As String
        Get
            Return _CategoriaDescripcion
        End Get
        Set(value As String)
            _CategoriaDescripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal codigo As String, ByVal nombre As String, ByVal Descripcion As String, Estado As String)
        CategoriaCodigo = CategoriaCodigo
        CategoriaNombre = nombre
        CategoriaDescripcion = Descripcion
        CategoriaEstado = Estado
    End Sub
End Class
