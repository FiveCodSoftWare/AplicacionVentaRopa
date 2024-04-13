Public Class Trabajador
    Dim _TrabajadorCodigo, _TrabajadorPaterno, _TrabajadorMaterno, _TrabajadorNombre, _TrabajadorGenero As String
    Dim _TrabajadorFechaNacimiento, _TrabajadorFechaRegistrado As DateTime
    Dim _TrabajadorNumeroDocumento, _TrabajadorDireccion, _TrabajadorTelefono, _TrabajadorEmail, _TrabajadorEstado As String

    Public Property TrabajadorCodigo As String
        Get
            Return _TrabajadorCodigo
        End Get
        Set(value As String)
            _TrabajadorCodigo = value
        End Set
    End Property

    Public Property TrabajadorEmail As String
        Get
            Return _TrabajadorEmail
        End Get
        Set(value As String)
            _TrabajadorEmail = value
        End Set
    End Property

    Public Property TrabajadorEstado As String
        Get
            Return _TrabajadorEstado
        End Get
        Set(value As String)
            _TrabajadorEstado = value
        End Set
    End Property

    Public Property TrabajadorFechaNacimiento As Date
        Get
            Return _TrabajadorFechaNacimiento
        End Get
        Set(value As Date)
            _TrabajadorFechaNacimiento = value
        End Set
    End Property

    Public Property TrabajadorFechaRegistrado As Date
        Get
            Return _TrabajadorFechaRegistrado
        End Get
        Set(value As Date)
            _TrabajadorFechaRegistrado = value
        End Set
    End Property

    Public Property TrabajadorGenero As String
        Get
            Return _TrabajadorGenero
        End Get
        Set(value As String)
            _TrabajadorGenero = value
        End Set
    End Property

    Public Property TrabajadorMaterno As String
        Get
            Return _TrabajadorMaterno
        End Get
        Set(value As String)
            _TrabajadorMaterno = value
        End Set
    End Property

    Public Property TrabajadorNombre As String
        Get
            Return _TrabajadorNombre
        End Get
        Set(value As String)
            _TrabajadorNombre = value
        End Set
    End Property

    Public Property TrabajadorNumeroDocumento As String
        Get
            Return _TrabajadorNumeroDocumento
        End Get
        Set(value As String)
            _TrabajadorNumeroDocumento = value
        End Set
    End Property

    Public Property TrabajadorPaterno As String
        Get
            Return _TrabajadorPaterno
        End Get
        Set(value As String)
            _TrabajadorPaterno = value
        End Set
    End Property

    Public Property TrabajadorTelefono As String
        Get
            Return _TrabajadorTelefono
        End Get
        Set(value As String)
            _TrabajadorTelefono = value
        End Set
    End Property

    Public Property TrabajadorDireccion As String
        Get
            Return _TrabajadorDireccion
        End Get
        Set(value As String)
            _TrabajadorDireccion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal codigotrabajador As String, ByVal apellidopa As String, ByVal apellidomate As String, ByVal nombre As String,
                   ByVal genero As String, ByVal fechanaci As DateTime, ByVal numerodoc As String, ByVal direcion As String, ByVal telefono As String, ByVal email As String, ByVal fechare As DateTime, ByVal estado As String)
        Me.TrabajadorCodigo = codigotrabajador
        Me.TrabajadorPaterno = apellidopa
        Me.TrabajadorMaterno = apellidomate
        Me.TrabajadorNombre = nombre
        Me.TrabajadorGenero = genero
        Me.TrabajadorFechaNacimiento = fechanaci
        Me.TrabajadorNumeroDocumento = numerodoc
        Me.TrabajadorDireccion = direcion
        Me.TrabajadorTelefono = telefono
        Me.TrabajadorEmail = email
        Me.TrabajadorFechaRegistrado = fechare
        Me.TrabajadorEstado = estado
    End Sub


End Class
