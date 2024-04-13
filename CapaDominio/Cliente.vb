Public Class Cliente


    Dim _ClienteCodigo, _ClientePaterno, _ClienteMaterno, _ClienteNombre, _ClienteGenero, _ClienteTipoDocumento, _ClienteNumeroDocumento,
_ClienteDireccion, _ClienteTelefono, _ClienteEmail, _ClienteEstado As String
    Dim _ClienteFechaNacimiento As DateTime

    Public Property ClienteCodigo As String
        Get
            Return _ClienteCodigo
        End Get
        Set(value As String)
            _ClienteCodigo = value
        End Set
    End Property

    Public Property ClienteDireccion As String
        Get
            Return _ClienteDireccion
        End Get
        Set(value As String)
            _ClienteDireccion = value
        End Set
    End Property

    Public Property ClienteEmail As String
        Get
            Return _ClienteEmail
        End Get
        Set(value As String)
            _ClienteEmail = value
        End Set
    End Property

    Public Property ClienteEstado As String
        Get
            Return _ClienteEstado
        End Get
        Set(value As String)
            _ClienteEstado = value
        End Set
    End Property

    Public Property ClienteGenero As String
        Get
            Return _ClienteGenero
        End Get
        Set(value As String)
            _ClienteGenero = value
        End Set
    End Property

    Public Property ClienteMaterno As String
        Get
            Return _ClienteMaterno
        End Get
        Set(value As String)
            _ClienteMaterno = value
        End Set
    End Property

    Public Property ClienteNombre As String
        Get
            Return _ClienteNombre
        End Get
        Set(value As String)
            _ClienteNombre = value
        End Set
    End Property

    Public Property ClienteNumeroDocumento As String
        Get
            Return _ClienteNumeroDocumento
        End Get
        Set(value As String)
            _ClienteNumeroDocumento = value
        End Set
    End Property

    Public Property ClientePaterno As String
        Get
            Return _ClientePaterno
        End Get
        Set(value As String)
            _ClientePaterno = value
        End Set
    End Property

    Public Property ClienteTelefono As String
        Get
            Return _ClienteTelefono
        End Get
        Set(value As String)
            _ClienteTelefono = value
        End Set
    End Property

    Public Property ClienteTipoDocumento As String
        Get
            Return _ClienteTipoDocumento
        End Get
        Set(value As String)
            _ClienteTipoDocumento = value
        End Set
    End Property

    Public Property ClienteFechaNacimiento As Date
        Get
            Return _ClienteFechaNacimiento
        End Get
        Set(value As Date)
            _ClienteFechaNacimiento = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal codigocliente As String, ByVal apellidopa As String, ByVal apellidomate As String, ByVal nombre As String,
                   ByVal genero As String, ByVal fechanaci As DateTime, ByVal tipodocumento As String, ByVal numerodoc As String, ByVal direcion As String, ByVal telefono As String, ByVal email As String, ByVal estado As String)
        Me.ClienteCodigo = codigocliente
        Me.ClientePaterno = apellidopa
        Me.ClienteMaterno = apellidomate
        Me.ClienteNombre = nombre
        Me.ClienteGenero = genero
        Me.ClienteFechaNacimiento = fechanaci
        Me.ClienteTipoDocumento = tipodocumento
        Me.ClienteNumeroDocumento = numerodoc
        Me.ClienteDireccion = direcion
        Me.ClienteTelefono = telefono
        Me.ClienteEmail = email
        Me.ClienteEstado = estado
    End Sub


End Class
