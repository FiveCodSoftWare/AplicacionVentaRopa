Public Class Usuario
    Dim _UsuarioCodigo, _TrabajadorCodigo, _UsuarioUsuario, _UsuarioUserNombre, _UsuarioContraseña, _UsuarioEstado As String

    Public Property TrabajadorCodigo As String
        Get
            Return _TrabajadorCodigo
        End Get
        Set(value As String)
            _TrabajadorCodigo = value
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

    Public Property UsuarioContraseña As String
        Get
            Return _UsuarioContraseña
        End Get
        Set(value As String)
            _UsuarioContraseña = value
        End Set
    End Property

    Public Property UsuarioUserNombre As String
        Get
            Return _UsuarioUserNombre
        End Get
        Set(value As String)
            _UsuarioUserNombre = value
        End Set
    End Property

    Public Property UsuarioUsuario As String
        Get
            Return _UsuarioUsuario
        End Get
        Set(value As String)
            _UsuarioUsuario = value
        End Set
    End Property

    Public Property UsuarioEstado As String
        Get
            Return _UsuarioEstado
        End Get
        Set(value As String)
            _UsuarioEstado = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal codigous As String, ByVal codigotr As String, ByVal usuariousuario As String,
                   ByVal nombr As String, ByVal contra As String, ByVal usuariestado As String)
        Me.UsuarioCodigo = codigous
        Me.TrabajadorCodigo = codigotr
        Me.UsuarioUsuario = usuariousuario
        Me.UsuarioUserNombre = nombr
        Me.UsuarioContraseña = contra
        Me.UsuarioEstado = UsuarioEstado
    End Sub
End Class
