<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuario
    '  Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.abrirListaTrabajadores = New System.Windows.Forms.OpenFileDialog()
        Me.dataListadoCategoria = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.cboAcceso = New System.Windows.Forms.ComboBox()
        Me.txtCodigoTrabajador = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.nuevo = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtContraseña = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cboEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.comboItem1 = New DevComponents.Editors.ComboItem()
        Me.comboItem2 = New DevComponents.Editors.ComboItem()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.btnUsuario = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards6.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards5.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'abrirListaTrabajadores
        '
        Me.abrirListaTrabajadores.FileName = "OpenFileDialog1"
        '
        'dataListadoCategoria
        '
        Me.dataListadoCategoria.AllowUserToAddRows = False
        Me.dataListadoCategoria.AllowUserToDeleteRows = False
        Me.dataListadoCategoria.AllowUserToOrderColumns = True
        Me.dataListadoCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListadoCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataListadoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListadoCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListadoCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataListadoCategoria.ColumnHeadersHeight = 25
        Me.dataListadoCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListadoCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoCategoria.EnableHeadersVisualStyles = False
        Me.dataListadoCategoria.GridColor = System.Drawing.Color.White
        Me.dataListadoCategoria.Location = New System.Drawing.Point(12, 12)
        Me.dataListadoCategoria.MultiSelect = False
        Me.dataListadoCategoria.Name = "dataListadoCategoria"
        Me.dataListadoCategoria.ReadOnly = True
        Me.dataListadoCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListadoCategoria.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dataListadoCategoria.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataListadoCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoCategoria.Size = New System.Drawing.Size(487, 141)
        Me.dataListadoCategoria.TabIndex = 9
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.White
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = True
        Me.BunifuCards6.color = System.Drawing.Color.Tomato
        Me.BunifuCards6.Controls.Add(Me.inexistente)
        Me.BunifuCards6.Controls.Add(Me.dataListadoCategoria)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(26, 400)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = True
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(519, 167)
        Me.BunifuCards6.TabIndex = 23
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(463, 18)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(55, 20)
        Me.txtflag.TabIndex = 37
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'cboAcceso
        '
        Me.cboAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAcceso.FormattingEnabled = True
        Me.cboAcceso.Items.AddRange(New Object() {"Administrador", "Empleado", "Invitado"})
        Me.cboAcceso.Location = New System.Drawing.Point(131, 115)
        Me.cboAcceso.Name = "cboAcceso"
        Me.cboAcceso.Size = New System.Drawing.Size(182, 28)
        Me.cboAcceso.TabIndex = 20
        '
        'txtCodigoTrabajador
        '
        '
        '
        '
        Me.txtCodigoTrabajador.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoTrabajador.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoTrabajador.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoTrabajador.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoTrabajador.Border.Class = "TextBoxBorder"
        Me.txtCodigoTrabajador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoTrabajador.Location = New System.Drawing.Point(131, 74)
        Me.txtCodigoTrabajador.Name = "txtCodigoTrabajador"
        Me.txtCodigoTrabajador.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoTrabajador.TabIndex = 19
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 8
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.nuevo)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(38, 70)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 25
        Me.BunifuCards1.Size = New System.Drawing.Size(90, 68)
        Me.BunifuCards1.TabIndex = 14
        '
        'nuevo
        '
        Me.nuevo.AutoSize = True
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.nuevo.Location = New System.Drawing.Point(17, 10)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(54, 20)
        Me.nuevo.TabIndex = 3
        Me.nuevo.Text = "Nuevo"
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
        Me.txtNombre.Location = New System.Drawing.Point(197, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(116, 20)
        Me.txtNombre.TabIndex = 18
        '
        'txtContraseña
        '
        '
        '
        '
        Me.txtContraseña.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtContraseña.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtContraseña.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtContraseña.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtContraseña.Border.Class = "TextBoxBorder"
        Me.txtContraseña.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContraseña.Location = New System.Drawing.Point(131, 160)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(182, 20)
        Me.txtContraseña.TabIndex = 17
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
        Me.txtCodigo.Location = New System.Drawing.Point(131, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(182, 20)
        Me.txtCodigo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Contraseña:"
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 8
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Tomato
        Me.BunifuCards2.Controls.Add(Me.Label1)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(160, 70)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 25
        Me.BunifuCards2.Size = New System.Drawing.Size(90, 68)
        Me.BunifuCards2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Guardar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Acceso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre:"
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.White
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.Tomato
        Me.BunifuCards5.Controls.Add(Me.chkEliminar)
        Me.BunifuCards5.Controls.Add(Me.btnEliminar)
        Me.BunifuCards5.Controls.Add(Me.cboEstado)
        Me.BunifuCards5.Controls.Add(Me.labelX5)
        Me.BunifuCards5.Controls.Add(Me.txtflag)
        Me.BunifuCards5.Controls.Add(Me.btnUsuario)
        Me.BunifuCards5.Controls.Add(Me.cboAcceso)
        Me.BunifuCards5.Controls.Add(Me.txtCodigoTrabajador)
        Me.BunifuCards5.Controls.Add(Me.txtNombre)
        Me.BunifuCards5.Controls.Add(Me.txtContraseña)
        Me.BunifuCards5.Controls.Add(Me.txtCodigo)
        Me.BunifuCards5.Controls.Add(Me.Label7)
        Me.BunifuCards5.Controls.Add(Me.Label6)
        Me.BunifuCards5.Controls.Add(Me.Label5)
        Me.BunifuCards5.Controls.Add(Me.Label4)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(22, 164)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(523, 230)
        Me.BunifuCards5.TabIndex = 22
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Depth = 0
        Me.chkEliminar.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEliminar.Location = New System.Drawing.Point(341, 189)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(95, 30)
        Me.chkEliminar.TabIndex = 41
        Me.chkEliminar.Text = "Selecionar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Image = Global.CapaPresentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.ImageActive = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(463, 187)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(54, 32)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminar.TabIndex = 40
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Zoom = 10
        '
        'cboEstado
        '
        Me.cboEstado.DisplayMember = "Text"
        Me.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.ItemHeight = 18
        Me.cboEstado.Items.AddRange(New Object() {Me.comboItem1, Me.comboItem2})
        Me.cboEstado.Location = New System.Drawing.Point(131, 195)
        Me.cboEstado.MaxLength = 1
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(169, 24)
        Me.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboEstado.TabIndex = 39
        Me.cboEstado.WatermarkText = "Seleccione..."
        '
        'comboItem1
        '
        Me.comboItem1.Text = "A"
        '
        'comboItem2
        '
        Me.comboItem2.Text = "I"
        '
        'labelX5
        '
        Me.labelX5.AutoSize = True
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX5.Location = New System.Drawing.Point(70, 195)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(48, 17)
        Me.labelX5.TabIndex = 38
        Me.labelX5.Text = "Estado:"
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.Image = Global.CapaPresentacion.My.Resources.Resources.buscar
        Me.btnUsuario.ImageActive = Nothing
        Me.btnUsuario.Location = New System.Drawing.Point(319, 74)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(25, 20)
        Me.btnUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUsuario.TabIndex = 21
        Me.btnUsuario.TabStop = False
        Me.btnUsuario.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Codigo:"
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 8
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.Tomato
        Me.BunifuCards3.Controls.Add(Me.Label2)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(287, 70)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 25
        Me.BunifuCards3.Size = New System.Drawing.Size(90, 68)
        Me.BunifuCards3.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Editar"
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 8
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.Tomato
        Me.BunifuCards4.Controls.Add(Me.Label3)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(410, 70)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 25
        Me.BunifuCards4.Size = New System.Drawing.Size(90, 68)
        Me.BunifuCards4.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Silver
        Me.btnCancelar.Image = Global.CapaPresentacion.My.Resources.Resources.desactivar
        Me.btnCancelar.ImageActive = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(419, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 53)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Zoom = 10
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Silver
        Me.btnEditar.Image = Global.CapaPresentacion.My.Resources.Resources.Editar
        Me.btnEditar.ImageActive = Nothing
        Me.btnEditar.Location = New System.Drawing.Point(296, 105)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 53)
        Me.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditar.TabIndex = 19
        Me.btnEditar.TabStop = False
        Me.btnEditar.Zoom = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Silver
        Me.btnGuardar.Image = Global.CapaPresentacion.My.Resources.Resources.gua
        Me.btnGuardar.ImageActive = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(169, 105)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 53)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Zoom = 10
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Silver
        Me.btnNuevo.Image = Global.CapaPresentacion.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageActive = Nothing
        Me.btnNuevo.Location = New System.Drawing.Point(47, 105)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 53)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.TabStop = False
        Me.btnNuevo.Zoom = 10
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(180, 75)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(149, 13)
        Me.inexistente.TabIndex = 33
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen datos para Mostrar"
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 574)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BunifuCards6)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards5)
        Me.Controls.Add(Me.BunifuCards3)
        Me.Controls.Add(Me.BunifuCards4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "................. :: FORMULARIO DE REGISTRO DE USUARIOS :: ......................" &
    "...."
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards5.PerformLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents abrirListaTrabajadores As OpenFileDialog
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEditar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents dataListadoCategoria As DataGridView
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtflag As TextBox
    Friend WithEvents btnUsuario As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cboAcceso As ComboBox
    Friend WithEvents txtCodigoTrabajador As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents nuevo As Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtContraseña As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Private WithEvents cboEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents comboItem1 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem2 As DevComponents.Editors.ComboItem
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents inexistente As LinkLabel
End Class
