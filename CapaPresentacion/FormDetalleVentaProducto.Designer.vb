<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetalleVentaProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnComprobante = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQuitar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtNombreUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNumeroComprobante = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoComprobante = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.comboItem3 = New DevComponents.Editors.ComboItem()
        Me.comboItem4 = New DevComponents.Editors.ComboItem()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStock = New System.Windows.Forms.NumericUpDown()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtCodigoDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPrecio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAgregarProducto = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtNombreProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dataListadoVentas = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnComprobante)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtflag)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 476)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de Opciones"
        '
        'btnComprobante
        '
        Me.btnComprobante.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnComprobante.BackColor = System.Drawing.Color.Transparent
        Me.btnComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnComprobante.BorderRadius = 0
        Me.btnComprobante.ButtonText = " Comprobante"
        Me.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComprobante.DisabledColor = System.Drawing.Color.Silver
        Me.btnComprobante.Iconcolor = System.Drawing.Color.Transparent
        Me.btnComprobante.Iconimage = Global.CapaPresentacion.My.Resources.Resources.imprimir
        Me.btnComprobante.Iconimage_right = Nothing
        Me.btnComprobante.Iconimage_right_Selected = Nothing
        Me.btnComprobante.Iconimage_Selected = Nothing
        Me.btnComprobante.IconMarginLeft = 0
        Me.btnComprobante.IconMarginRight = 0
        Me.btnComprobante.IconRightVisible = False
        Me.btnComprobante.IconRightZoom = 0R
        Me.btnComprobante.IconVisible = True
        Me.btnComprobante.IconZoom = 60.0R
        Me.btnComprobante.IsTab = False
        Me.btnComprobante.Location = New System.Drawing.Point(3, 414)
        Me.btnComprobante.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnComprobante.Name = "btnComprobante"
        Me.btnComprobante.Normalcolor = System.Drawing.Color.Transparent
        Me.btnComprobante.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnComprobante.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnComprobante.selected = False
        Me.btnComprobante.Size = New System.Drawing.Size(150, 43)
        Me.btnComprobante.TabIndex = 14
        Me.btnComprobante.Text = " Comprobante"
        Me.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprobante.Textcolor = System.Drawing.Color.Black
        Me.btnComprobante.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQuitar
        '
        Me.btnQuitar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnQuitar.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitar.BorderRadius = 0
        Me.btnQuitar.ButtonText = "Quitar Producto "
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.DisabledColor = System.Drawing.Color.Silver
        Me.btnQuitar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnQuitar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.borrar
        Me.btnQuitar.Iconimage_right = Nothing
        Me.btnQuitar.Iconimage_right_Selected = Nothing
        Me.btnQuitar.Iconimage_Selected = Nothing
        Me.btnQuitar.IconMarginLeft = 0
        Me.btnQuitar.IconMarginRight = 0
        Me.btnQuitar.IconRightVisible = False
        Me.btnQuitar.IconRightZoom = 0R
        Me.btnQuitar.IconVisible = True
        Me.btnQuitar.IconZoom = 70.0R
        Me.btnQuitar.IsTab = False
        Me.btnQuitar.Location = New System.Drawing.Point(9, 329)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(13, 8, 13, 8)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnQuitar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnQuitar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnQuitar.selected = False
        Me.btnQuitar.Size = New System.Drawing.Size(131, 55)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "Quitar Producto "
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnQuitar.Textcolor = System.Drawing.Color.Black
        Me.btnQuitar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 0
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Silver
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.desactivara
        Me.btnCancelar.Iconimage_right = Nothing
        Me.btnCancelar.Iconimage_right_Selected = Nothing
        Me.btnCancelar.Iconimage_Selected = Nothing
        Me.btnCancelar.IconMarginLeft = 0
        Me.btnCancelar.IconMarginRight = 0
        Me.btnCancelar.IconRightVisible = False
        Me.btnCancelar.IconRightZoom = 0R
        Me.btnCancelar.IconVisible = True
        Me.btnCancelar.IconZoom = 70.0R
        Me.btnCancelar.IsTab = False
        Me.btnCancelar.Location = New System.Drawing.Point(8, 259)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(137, 56)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 0
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Silver
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.gua
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 0
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = False
        Me.btnGuardar.IconRightZoom = 0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 70.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(13, 177)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(127, 45)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.Black
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 0
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.DisabledColor = System.Drawing.Color.Silver
        Me.btnNuevo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.Iconimage = Global.CapaPresentacion.My.Resources.Resources.nuevo
        Me.btnNuevo.Iconimage_right = Nothing
        Me.btnNuevo.Iconimage_right_Selected = Nothing
        Me.btnNuevo.Iconimage_Selected = Nothing
        Me.btnNuevo.IconMarginLeft = 0
        Me.btnNuevo.IconMarginRight = 0
        Me.btnNuevo.IconRightVisible = False
        Me.btnNuevo.IconRightZoom = 0R
        Me.btnNuevo.IconVisible = True
        Me.btnNuevo.IconZoom = 70.0R
        Me.btnNuevo.IsTab = False
        Me.btnNuevo.Location = New System.Drawing.Point(13, 94)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(127, 45)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Textcolor = System.Drawing.Color.Black
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(90, 13)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(55, 24)
        Me.txtflag.TabIndex = 36
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Depth = 0
        Me.chkEliminar.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEliminar.Location = New System.Drawing.Point(11, 145)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(102, 30)
        Me.chkEliminar.TabIndex = 13
        Me.chkEliminar.Text = "Seleccionar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        '
        '
        '
        Me.txtNombreUsuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreUsuario.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreUsuario.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreUsuario.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreUsuario.Border.Class = "TextBoxBorder"
        Me.txtNombreUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreUsuario.Location = New System.Drawing.Point(648, 116)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(147, 24)
        Me.txtNombreUsuario.TabIndex = 30
        '
        'txtCodigoUsuario
        '
        '
        '
        '
        Me.txtCodigoUsuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoUsuario.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoUsuario.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoUsuario.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoUsuario.Border.Class = "TextBoxBorder"
        Me.txtCodigoUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(584, 116)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(58, 24)
        Me.txtCodigoUsuario.TabIndex = 29
        '
        'txtNombreCliente
        '
        '
        '
        '
        Me.txtNombreCliente.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreCliente.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreCliente.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreCliente.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreCliente.Border.Class = "TextBoxBorder"
        Me.txtNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreCliente.Location = New System.Drawing.Point(182, 74)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(124, 24)
        Me.txtNombreCliente.TabIndex = 28
        '
        'txtCodigoCliente
        '
        '
        '
        '
        Me.txtCodigoCliente.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoCliente.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoCliente.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoCliente.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoCliente.Border.Class = "TextBoxBorder"
        Me.txtCodigoCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoCliente.Location = New System.Drawing.Point(124, 74)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(42, 24)
        Me.txtCodigoCliente.TabIndex = 27
        '
        'txtNumeroComprobante
        '
        '
        '
        '
        Me.txtNumeroComprobante.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroComprobante.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroComprobante.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroComprobante.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNumeroComprobante.Border.Class = "TextBoxBorder"
        Me.txtNumeroComprobante.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(584, 79)
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(211, 24)
        Me.txtNumeroComprobante.TabIndex = 26
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
        Me.txtCodigo.Location = New System.Drawing.Point(124, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(182, 24)
        Me.txtCodigo.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtFechaVenta)
        Me.GroupBox2.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox2.Controls.Add(Me.txtCodigoUsuario)
        Me.GroupBox2.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox2.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox2.Controls.Add(Me.txtNumeroComprobante)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.cboTipoComprobante)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(176, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(801, 151)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro de Productos a la Venta"
        '
        'dtFechaVenta
        '
        Me.dtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVenta.Location = New System.Drawing.Point(124, 116)
        Me.dtFechaVenta.Name = "dtFechaVenta"
        Me.dtFechaVenta.Size = New System.Drawing.Size(140, 24)
        Me.dtFechaVenta.TabIndex = 52
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.DisplayMember = "Text"
        Me.cboTipoComprobante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.ItemHeight = 18
        Me.cboTipoComprobante.Items.AddRange(New Object() {Me.comboItem3, Me.comboItem4})
        Me.cboTipoComprobante.Location = New System.Drawing.Point(584, 36)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(211, 24)
        Me.cboTipoComprobante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipoComprobante.TabIndex = 23
        Me.cboTipoComprobante.WatermarkText = "Seleccione..."
        '
        'comboItem3
        '
        Me.comboItem3.Text = "Factura"
        '
        'comboItem4
        '
        Me.comboItem4.Text = "Boleta"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(506, 118)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(72, 18)
        Me.BunifuCustomLabel6.TabIndex = 5
        Me.BunifuCustomLabel6.Text = "Usuario:"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(398, 79)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(180, 18)
        Me.BunifuCustomLabel5.TabIndex = 4
        Me.BunifuCustomLabel5.Text = "Numero Comprobante:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(425, 36)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(153, 18)
        Me.BunifuCustomLabel4.TabIndex = 3
        Me.BunifuCustomLabel4.Text = "Tipo Comprobante:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(8, 116)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(106, 18)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "Fecha Venta:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(42, 76)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(65, 18)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Cliente:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(42, 36)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(67, 18)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Código:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(670, 59)
        Me.txtStock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 22)
        Me.txtStock.TabIndex = 51
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(465, 59)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(105, 22)
        Me.txtCantidad.TabIndex = 50
        '
        'txtCodigoDetalle
        '
        '
        '
        '
        Me.txtCodigoDetalle.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoDetalle.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoDetalle.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoDetalle.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoDetalle.Border.Class = "TextBoxBorder"
        Me.txtCodigoDetalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoDetalle.Location = New System.Drawing.Point(535, 22)
        Me.txtCodigoDetalle.Name = "txtCodigoDetalle"
        Me.txtCodigoDetalle.Size = New System.Drawing.Size(182, 22)
        Me.txtCodigoDetalle.TabIndex = 48
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(406, 26)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(116, 16)
        Me.BunifuCustomLabel11.TabIndex = 47
        Me.BunifuCustomLabel11.Text = "Codigo Detalle:"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(607, 63)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(51, 16)
        Me.BunifuCustomLabel10.TabIndex = 45
        Me.BunifuCustomLabel10.Text = "Stock:"
        '
        'txtPrecio
        '
        '
        '
        '
        Me.txtPrecio.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPrecio.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPrecio.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPrecio.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPrecio.Border.Class = "TextBoxBorder"
        Me.txtPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(106, 58)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(161, 22)
        Me.txtPrecio.TabIndex = 43
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(380, 63)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(74, 16)
        Me.BunifuCustomLabel9.TabIndex = 42
        Me.BunifuCustomLabel9.Text = "Cantidad:"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(35, 59)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(57, 16)
        Me.BunifuCustomLabel8.TabIndex = 41
        Me.BunifuCustomLabel8.Text = "Precio:"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.Image = Global.CapaPresentacion.My.Resources.Resources.buscarproducto
        Me.btnAgregarProducto.ImageActive = Nothing
        Me.btnAgregarProducto.Location = New System.Drawing.Point(341, 22)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(44, 22)
        Me.btnAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregarProducto.TabIndex = 40
        Me.btnAgregarProducto.TabStop = False
        Me.btnAgregarProducto.Zoom = 10
        '
        'txtNombreProducto
        '
        '
        '
        '
        Me.txtNombreProducto.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreProducto.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreProducto.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreProducto.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtNombreProducto.Border.Class = "TextBoxBorder"
        Me.txtNombreProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(174, 22)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(161, 22)
        Me.txtNombreProducto.TabIndex = 39
        '
        'txtCodigoProducto
        '
        '
        '
        '
        Me.txtCodigoProducto.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoProducto.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoProducto.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoProducto.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtCodigoProducto.Border.Class = "TextBoxBorder"
        Me.txtCodigoProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Location = New System.Drawing.Point(106, 21)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(59, 22)
        Me.txtCodigoProducto.TabIndex = 38
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(18, 24)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(74, 16)
        Me.BunifuCustomLabel7.TabIndex = 37
        Me.BunifuCustomLabel7.Text = "Producto:"
        '
        'dataListadoVentas
        '
        Me.dataListadoVentas.AllowUserToAddRows = False
        Me.dataListadoVentas.AllowUserToDeleteRows = False
        Me.dataListadoVentas.AllowUserToOrderColumns = True
        Me.dataListadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListadoVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataListadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListadoVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListadoVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListadoVentas.ColumnHeadersHeight = 25
        Me.dataListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListadoVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoVentas.EnableHeadersVisualStyles = False
        Me.dataListadoVentas.GridColor = System.Drawing.Color.White
        Me.dataListadoVentas.Location = New System.Drawing.Point(6, 28)
        Me.dataListadoVentas.MultiSelect = False
        Me.dataListadoVentas.Name = "dataListadoVentas"
        Me.dataListadoVentas.ReadOnly = True
        Me.dataListadoVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListadoVentas.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dataListadoVentas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListadoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoVentas.Size = New System.Drawing.Size(781, 101)
        Me.dataListadoVentas.TabIndex = 28
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.inexistente)
        Me.GroupBox3.Controls.Add(Me.chkEliminar)
        Me.GroupBox3.Controls.Add(Me.dataListadoVentas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(177, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 194)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Registros"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(330, 78)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(144, 18)
        Me.inexistente.TabIndex = 30
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No existen Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(495, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Deslizar para agregar la cantidad"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox4.Controls.Add(Me.btnAgregarProducto)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel11)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.txtCodigoDetalle)
        Me.GroupBox4.Controls.Add(Me.txtStock)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel10)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox4.Controls.Add(Me.txtCodigoProducto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(177, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 120)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Agregar Productos"
        '
        'FormDetalleVentaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 559)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDetalleVentaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                  ..................... :: FORMUL" &
    "ARIO DE ITEM DE VENTA :: ............................"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtflag As TextBox
    Friend WithEvents txtNombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodigoCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents comboItem3 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents dataListadoVentas As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtNombreUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodigoUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNumeroComprobante As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboTipoComprobante As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtNombreProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodigoProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAgregarProducto As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtPrecio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnQuitar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtCodigoDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents btnComprobante As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtFechaVenta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
