<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrabajador
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtfechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX12 = New DevComponents.DotNetBar.LabelX()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtApellidoMaterno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX9 = New DevComponents.DotNetBar.LabelX()
        Me.labelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtApellidoPaterno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNumeroDocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTelefono = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX7 = New DevComponents.DotNetBar.LabelX()
        Me.labelX6 = New DevComponents.DotNetBar.LabelX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datlistaTrabajadores = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImprimir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.datlistaTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Label6)
        Me.groupBox2.Controls.Add(Me.Label5)
        Me.groupBox2.Controls.Add(Me.Label4)
        Me.groupBox2.Controls.Add(Me.Label3)
        Me.groupBox2.Controls.Add(Me.Label2)
        Me.groupBox2.Controls.Add(Me.Label1)
        Me.groupBox2.Controls.Add(Me.cboGenero)
        Me.groupBox2.Controls.Add(Me.cboEstado)
        Me.groupBox2.Controls.Add(Me.dtfechaRegistro)
        Me.groupBox2.Controls.Add(Me.LabelX3)
        Me.groupBox2.Controls.Add(Me.txtEmail)
        Me.groupBox2.Controls.Add(Me.labelX12)
        Me.groupBox2.Controls.Add(Me.dtFechaNacimiento)
        Me.groupBox2.Controls.Add(Me.labelX11)
        Me.groupBox2.Controls.Add(Me.txtNombre)
        Me.groupBox2.Controls.Add(Me.labelX10)
        Me.groupBox2.Controls.Add(Me.txtApellidoMaterno)
        Me.groupBox2.Controls.Add(Me.labelX9)
        Me.groupBox2.Controls.Add(Me.labelX8)
        Me.groupBox2.Controls.Add(Me.txtCodigo)
        Me.groupBox2.Controls.Add(Me.txtApellidoPaterno)
        Me.groupBox2.Controls.Add(Me.txtNumeroDocumento)
        Me.groupBox2.Controls.Add(Me.txtDireccion)
        Me.groupBox2.Controls.Add(Me.txtTelefono)
        Me.groupBox2.Controls.Add(Me.labelX7)
        Me.groupBox2.Controls.Add(Me.labelX6)
        Me.groupBox2.Controls.Add(Me.labelX5)
        Me.groupBox2.Controls.Add(Me.labelX4)
        Me.groupBox2.Controls.Add(Me.labelX2)
        Me.groupBox2.Controls.Add(Me.labelX1)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(6, 147)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(838, 247)
        Me.groupBox2.TabIndex = 9
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Trababajadores"
        '
        'dtfechaRegistro
        '
        Me.dtfechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaRegistro.Location = New System.Drawing.Point(507, 100)
        Me.dtfechaRegistro.Name = "dtfechaRegistro"
        Me.dtfechaRegistro.Size = New System.Drawing.Size(132, 24)
        Me.dtfechaRegistro.TabIndex = 8
        Me.dtfechaRegistro.Value = New Date(2018, 6, 10, 17, 35, 38, 0)
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(401, 100)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 17)
        Me.LabelX3.TabIndex = 25
        Me.LabelX3.Text = "Fecha Registro:"
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtEmail.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtEmail.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtEmail.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmail.Location = New System.Drawing.Point(470, 173)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 24)
        Me.txtEmail.TabIndex = 10
        '
        'labelX12
        '
        Me.labelX12.AutoSize = True
        '
        '
        '
        Me.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX12.Location = New System.Drawing.Point(423, 176)
        Me.labelX12.Name = "labelX12"
        Me.labelX12.Size = New System.Drawing.Size(40, 17)
        Me.labelX12.TabIndex = 23
        Me.labelX12.Text = "Email:"
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(507, 66)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(132, 24)
        Me.dtFechaNacimiento.TabIndex = 7
        '
        'labelX11
        '
        Me.labelX11.AutoSize = True
        '
        '
        '
        Me.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX11.Location = New System.Drawing.Point(386, 68)
        Me.labelX11.Name = "labelX11"
        Me.labelX11.Size = New System.Drawing.Size(115, 17)
        Me.labelX11.TabIndex = 20
        Me.labelX11.Text = "Fecha Nacimiento:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombre.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombre.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombre.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Location = New System.Drawing.Point(139, 139)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 24)
        Me.txtNombre.TabIndex = 2
        '
        'labelX10
        '
        Me.labelX10.AutoSize = True
        '
        '
        '
        Me.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX10.Location = New System.Drawing.Point(79, 143)
        Me.labelX10.Name = "labelX10"
        Me.labelX10.Size = New System.Drawing.Size(54, 17)
        Me.labelX10.TabIndex = 18
        Me.labelX10.Text = "Nombre:"
        '
        'txtApellidoMaterno
        '
        '
        '
        '
        Me.txtApellidoMaterno.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoMaterno.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoMaterno.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoMaterno.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoMaterno.Border.Class = "TextBoxBorder"
        Me.txtApellidoMaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(138, 103)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(182, 24)
        Me.txtApellidoMaterno.TabIndex = 1
        '
        'labelX9
        '
        Me.labelX9.AutoSize = True
        '
        '
        '
        Me.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX9.Location = New System.Drawing.Point(27, 107)
        Me.labelX9.Name = "labelX9"
        Me.labelX9.Size = New System.Drawing.Size(108, 17)
        Me.labelX9.TabIndex = 16
        Me.labelX9.Text = "Apellido Materno:"
        '
        'labelX8
        '
        Me.labelX8.AutoSize = True
        '
        '
        '
        Me.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX8.Location = New System.Drawing.Point(450, 34)
        Me.labelX8.Name = "labelX8"
        Me.labelX8.Size = New System.Drawing.Size(51, 17)
        Me.labelX8.TabIndex = 14
        Me.labelX8.Text = "Género:"
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigo.Location = New System.Drawing.Point(138, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(182, 24)
        Me.txtCodigo.TabIndex = 13
        '
        'txtApellidoPaterno
        '
        '
        '
        '
        Me.txtApellidoPaterno.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoPaterno.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoPaterno.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoPaterno.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtApellidoPaterno.Border.Class = "TextBoxBorder"
        Me.txtApellidoPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(139, 66)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(182, 24)
        Me.txtApellidoPaterno.TabIndex = 0
        '
        'txtNumeroDocumento
        '
        '
        '
        '
        Me.txtNumeroDocumento.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroDocumento.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroDocumento.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroDocumento.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroDocumento.Border.Class = "TextBoxBorder"
        Me.txtNumeroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(138, 177)
        Me.txtNumeroDocumento.MaxLength = 8
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(182, 24)
        Me.txtNumeroDocumento.TabIndex = 3
        '
        'txtDireccion
        '
        '
        '
        '
        Me.txtDireccion.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtDireccion.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtDireccion.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtDireccion.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtDireccion.Border.Class = "TextBoxBorder"
        Me.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDireccion.Location = New System.Drawing.Point(470, 136)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(227, 24)
        Me.txtDireccion.TabIndex = 9
        '
        'txtTelefono
        '
        '
        '
        '
        Me.txtTelefono.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtTelefono.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtTelefono.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtTelefono.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtTelefono.Border.Class = "TextBoxBorder"
        Me.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelefono.Location = New System.Drawing.Point(139, 216)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(182, 24)
        Me.txtTelefono.TabIndex = 4
        '
        'labelX7
        '
        Me.labelX7.AutoSize = True
        '
        '
        '
        Me.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX7.Location = New System.Drawing.Point(83, 181)
        Me.labelX7.Name = "labelX7"
        Me.labelX7.Size = New System.Drawing.Size(49, 17)
        Me.labelX7.TabIndex = 6
        Me.labelX7.Text = "N° Doc:"
        '
        'labelX6
        '
        Me.labelX6.AutoSize = True
        '
        '
        '
        Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX6.Location = New System.Drawing.Point(401, 140)
        Me.labelX6.Name = "labelX6"
        Me.labelX6.Size = New System.Drawing.Size(63, 17)
        Me.labelX6.TabIndex = 5
        Me.labelX6.Text = "Direccion:"
        '
        'labelX5
        '
        Me.labelX5.AutoSize = True
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX5.Location = New System.Drawing.Point(415, 214)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(48, 17)
        Me.labelX5.TabIndex = 4
        Me.labelX5.Text = "Estado:"
        '
        'labelX4
        '
        Me.labelX4.AutoSize = True
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX4.Location = New System.Drawing.Point(29, 70)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(106, 17)
        Me.labelX4.TabIndex = 3
        Me.labelX4.Text = "Apellido Paterno:"
        '
        'labelX2
        '
        Me.labelX2.AutoSize = True
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX2.Location = New System.Drawing.Point(73, 220)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(59, 17)
        Me.labelX2.TabIndex = 1
        Me.labelX2.Text = "Telefono:"
        '
        'labelX1
        '
        Me.labelX1.AutoSize = True
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX1.Location = New System.Drawing.Point(79, 30)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(49, 17)
        Me.labelX1.TabIndex = 0
        Me.labelX1.Text = "Codigo:"
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.cboBuscar)
        Me.groupBox3.Controls.Add(Me.inexistente)
        Me.groupBox3.Controls.Add(Me.btnImprimir)
        Me.groupBox3.Controls.Add(Me.btnEliminar)
        Me.groupBox3.Controls.Add(Me.datlistaTrabajadores)
        Me.groupBox3.Controls.Add(Me.chkEliminar)
        Me.groupBox3.Controls.Add(Me.txtBuscar)
        Me.groupBox3.Location = New System.Drawing.Point(6, 397)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(838, 239)
        Me.groupBox3.TabIndex = 10
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Listado"
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Nombre", "NDocumento"})
        Me.cboBuscar.Location = New System.Drawing.Point(17, 24)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(132, 21)
        Me.cboBuscar.TabIndex = 26
        Me.cboBuscar.Text = "Nombre"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(346, 113)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(140, 13)
        Me.inexistente.TabIndex = 19
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos No Existen en la Lista"
        '
        'datlistaTrabajadores
        '
        Me.datlistaTrabajadores.AllowUserToAddRows = False
        Me.datlistaTrabajadores.AllowUserToDeleteRows = False
        Me.datlistaTrabajadores.AllowUserToOrderColumns = True
        Me.datlistaTrabajadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datlistaTrabajadores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.datlistaTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datlistaTrabajadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datlistaTrabajadores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datlistaTrabajadores.ColumnHeadersHeight = 25
        Me.datlistaTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datlistaTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datlistaTrabajadores.EnableHeadersVisualStyles = False
        Me.datlistaTrabajadores.GridColor = System.Drawing.Color.White
        Me.datlistaTrabajadores.Location = New System.Drawing.Point(6, 62)
        Me.datlistaTrabajadores.MultiSelect = False
        Me.datlistaTrabajadores.Name = "datlistaTrabajadores"
        Me.datlistaTrabajadores.ReadOnly = True
        Me.datlistaTrabajadores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datlistaTrabajadores.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.datlistaTrabajadores.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datlistaTrabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datlistaTrabajadores.Size = New System.Drawing.Size(826, 139)
        Me.datlistaTrabajadores.TabIndex = 13
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Depth = 0
        Me.chkEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkEliminar.Location = New System.Drawing.Point(26, 206)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(102, 30)
        Me.chkEliminar.TabIndex = 12
        Me.chkEliminar.Text = "Seleccionar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(163, 23)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(360, 28)
        Me.txtBuscar.TabIndex = 11
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnCancelar)
        Me.groupBox1.Controls.Add(Me.btnNuevo)
        Me.groupBox1.Controls.Add(Me.btnEditar)
        Me.groupBox1.Controls.Add(Me.btnGuardar)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(6, 67)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox1.Size = New System.Drawing.Size(838, 80)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Controles "
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.White
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"A", "I"})
        Me.cboEstado.Location = New System.Drawing.Point(470, 209)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstado.Size = New System.Drawing.Size(186, 26)
        Me.cboEstado.TabIndex = 26
        '
        'cboGenero
        '
        Me.cboGenero.BackColor = System.Drawing.Color.White
        Me.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenero.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"M", "F"})
        Me.cboGenero.Location = New System.Drawing.Point(507, 29)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGenero.Size = New System.Drawing.Size(132, 26)
        Me.cboGenero.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(64, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(67, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 20)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(434, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(397, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 20)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "*"
        '
        'btnImprimir
        '
        Me.btnImprimir.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.BorderRadius = 4
        Me.btnImprimir.ButtonText = "Imprimir"
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.DisabledColor = System.Drawing.Color.Gray
        Me.btnImprimir.Iconcolor = System.Drawing.Color.Transparent
        Me.btnImprimir.Iconimage = Global.CapaPresentacion.My.Resources.Resources.imprimir
        Me.btnImprimir.Iconimage_right = Nothing
        Me.btnImprimir.Iconimage_right_Selected = Nothing
        Me.btnImprimir.Iconimage_Selected = Nothing
        Me.btnImprimir.IconMarginLeft = 2
        Me.btnImprimir.IconMarginRight = 0
        Me.btnImprimir.IconRightVisible = True
        Me.btnImprimir.IconRightZoom = 0R
        Me.btnImprimir.IconVisible = True
        Me.btnImprimir.IconZoom = 100.0R
        Me.btnImprimir.IsTab = False
        Me.btnImprimir.Location = New System.Drawing.Point(695, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Normalcolor = System.Drawing.Color.Transparent
        Me.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnImprimir.OnHoverTextColor = System.Drawing.Color.White
        Me.btnImprimir.selected = False
        Me.btnImprimir.Size = New System.Drawing.Size(108, 46)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Textcolor = System.Drawing.Color.Black
        Me.btnImprimir.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEliminar
        '
        Me.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.BorderRadius = 5
        Me.btnEliminar.ButtonText = "Elimnar"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEliminar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.Iconimage_right = Nothing
        Me.btnEliminar.Iconimage_right_Selected = Nothing
        Me.btnEliminar.Iconimage_Selected = Nothing
        Me.btnEliminar.IconMarginLeft = 2
        Me.btnEliminar.IconMarginRight = 0
        Me.btnEliminar.IconRightVisible = True
        Me.btnEliminar.IconRightZoom = 0R
        Me.btnEliminar.IconVisible = True
        Me.btnEliminar.IconZoom = 103.0R
        Me.btnEliminar.IsTab = False
        Me.btnEliminar.Location = New System.Drawing.Point(545, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEliminar.selected = False
        Me.btnEliminar.Size = New System.Drawing.Size(108, 46)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Elimnar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Textcolor = System.Drawing.Color.Black
        Me.btnEliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 5
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.desactivara
        Me.btnCancelar.Iconimage_right = Nothing
        Me.btnCancelar.Iconimage_right_Selected = Nothing
        Me.btnCancelar.Iconimage_Selected = Nothing
        Me.btnCancelar.IconMarginLeft = 3
        Me.btnCancelar.IconMarginRight = 0
        Me.btnCancelar.IconRightVisible = False
        Me.btnCancelar.IconRightZoom = 0R
        Me.btnCancelar.IconVisible = True
        Me.btnCancelar.IconZoom = 80.0R
        Me.btnCancelar.IsTab = False
        Me.btnCancelar.Location = New System.Drawing.Point(615, 19)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(15, 12, 15, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(153, 52)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.Silver
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 5
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.DisabledColor = System.Drawing.Color.Gray
        Me.btnNuevo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.Iconimage = Global.CapaPresentacion.My.Resources.Resources.agregarCliente
        Me.btnNuevo.Iconimage_right = Nothing
        Me.btnNuevo.Iconimage_right_Selected = Nothing
        Me.btnNuevo.Iconimage_Selected = Nothing
        Me.btnNuevo.IconMarginLeft = 4
        Me.btnNuevo.IconMarginRight = 0
        Me.btnNuevo.IconRightVisible = False
        Me.btnNuevo.IconRightZoom = 0R
        Me.btnNuevo.IconVisible = True
        Me.btnNuevo.IconZoom = 80.0R
        Me.btnNuevo.IsTab = False
        Me.btnNuevo.Location = New System.Drawing.Point(108, 19)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(124, 52)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Textcolor = System.Drawing.Color.Black
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEditar
        '
        Me.btnEditar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.BorderRadius = 5
        Me.btnEditar.ButtonText = "Editar"
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEditar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEditar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.Editar
        Me.btnEditar.Iconimage_right = Nothing
        Me.btnEditar.Iconimage_right_Selected = Nothing
        Me.btnEditar.Iconimage_Selected = Nothing
        Me.btnEditar.IconMarginLeft = 3
        Me.btnEditar.IconMarginRight = 0
        Me.btnEditar.IconRightVisible = False
        Me.btnEditar.IconRightZoom = 0R
        Me.btnEditar.IconVisible = True
        Me.btnEditar.IconZoom = 80.0R
        Me.btnEditar.IsTab = False
        Me.btnEditar.Location = New System.Drawing.Point(412, 19)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEditar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEditar.selected = False
        Me.btnEditar.Size = New System.Drawing.Size(144, 52)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditar.Textcolor = System.Drawing.Color.Black
        Me.btnEditar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 5
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.guardarc
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 3
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = False
        Me.btnGuardar.IconRightZoom = 0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 80.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(249, 19)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(129, 52)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.Black
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 648)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "             ......................... :: FORMULARIO DE REGISTRO DE TRABAJADORES " &
    ":: ........................"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.datlistaTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox2 As GroupBox
    Private WithEvents dtfechaRegistro As DateTimePicker
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX12 As DevComponents.DotNetBar.LabelX
    Private WithEvents dtFechaNacimiento As DateTimePicker
    Private WithEvents labelX11 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX10 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtApellidoMaterno As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX9 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtApellidoPaterno As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtNumeroDocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtTelefono As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents labelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dlg As OpenFileDialog
    Private WithEvents groupBox3 As GroupBox
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents inexistente As LinkLabel
    Private WithEvents btnImprimir As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnEliminar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents datlistaTrabajadores As DataGridView
    Private WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents errorIcono As ErrorProvider
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnEditar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Public WithEvents cboGenero As ComboBox
    Public WithEvents cboEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
