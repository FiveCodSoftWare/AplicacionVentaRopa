<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipalSV
    Inherits System.Windows.Forms.Form

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
        Me.panelCabezera = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.panelProcesos = New System.Windows.Forms.Panel()
        Me.panelMovimientos = New System.Windows.Forms.Panel()
        Me.panelPermisos = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblNombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblDni = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblAdmin = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.btnMovimientos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnVentas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDetalleVenta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnReportes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMarcas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCategorias = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnProductos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClientes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTrabajadores = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUsuarios = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnProcesos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPermisos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuDeslizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRestaurar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panelCabezera.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        Me.panelProcesos.SuspendLayout()
        Me.panelMovimientos.SuspendLayout()
        Me.panelPermisos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuDeslizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCabezera
        '
        Me.panelCabezera.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.panelCabezera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelCabezera.Controls.Add(Me.label1)
        Me.panelCabezera.Controls.Add(Me.labelX1)
        Me.panelCabezera.Controls.Add(Me.btnRestaurar)
        Me.panelCabezera.Controls.Add(Me.btnMinimizar)
        Me.panelCabezera.Controls.Add(Me.btnCerrar)
        Me.panelCabezera.Controls.Add(Me.btnMaximizar)
        Me.panelCabezera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabezera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabezera.Name = "panelCabezera"
        Me.panelCabezera.Size = New System.Drawing.Size(1110, 40)
        Me.panelCabezera.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(46, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "<< CoSOFT>>"
        '
        'labelX1
        '
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX1.ForeColor = System.Drawing.Color.White
        Me.labelX1.Location = New System.Drawing.Point(7, 1)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.SingleLineColor = System.Drawing.Color.White
        Me.labelX1.Size = New System.Drawing.Size(184, 22)
        Me.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.labelX1.TabIndex = 5
        Me.labelX1.Text = "Sistema Venta de Ropa"
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.btnMovimientos)
        Me.panelmenu.Controls.Add(Me.panelProcesos)
        Me.panelmenu.Controls.Add(Me.btnReportes)
        Me.panelmenu.Controls.Add(Me.panelMovimientos)
        Me.panelmenu.Controls.Add(Me.panelPermisos)
        Me.panelmenu.Controls.Add(Me.BunifuSeparator1)
        Me.panelmenu.Controls.Add(Me.btnProcesos)
        Me.panelmenu.Controls.Add(Me.lblNombre)
        Me.panelmenu.Controls.Add(Me.btnPermisos)
        Me.panelmenu.Controls.Add(Me.lblDni)
        Me.panelmenu.Controls.Add(Me.lblAdmin)
        Me.panelmenu.Controls.Add(Me.PictureBox2)
        Me.panelmenu.Controls.Add(Me.PictureBox1)
        Me.panelmenu.Controls.Add(Me.menuDeslizar)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(220, 610)
        Me.panelmenu.TabIndex = 2
        '
        'panelProcesos
        '
        Me.panelProcesos.Controls.Add(Me.btnVentas)
        Me.panelProcesos.Controls.Add(Me.btnDetalleVenta)
        Me.panelProcesos.Location = New System.Drawing.Point(0, 293)
        Me.panelProcesos.Name = "panelProcesos"
        Me.panelProcesos.Size = New System.Drawing.Size(220, 79)
        Me.panelProcesos.TabIndex = 3
        '
        'panelMovimientos
        '
        Me.panelMovimientos.Controls.Add(Me.btnMarcas)
        Me.panelMovimientos.Controls.Add(Me.btnCategorias)
        Me.panelMovimientos.Controls.Add(Me.btnProductos)
        Me.panelMovimientos.Controls.Add(Me.btnClientes)
        Me.panelMovimientos.Location = New System.Drawing.Point(0, 96)
        Me.panelMovimientos.Name = "panelMovimientos"
        Me.panelMovimientos.Size = New System.Drawing.Size(219, 157)
        Me.panelMovimientos.TabIndex = 14
        '
        'panelPermisos
        '
        Me.panelPermisos.Controls.Add(Me.btnTrabajadores)
        Me.panelPermisos.Controls.Add(Me.btnUsuarios)
        Me.panelPermisos.Location = New System.Drawing.Point(0, 413)
        Me.panelPermisos.Name = "panelPermisos"
        Me.panelPermisos.Size = New System.Drawing.Size(220, 79)
        Me.panelPermisos.TabIndex = 14
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 53)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(220, 4)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNombre.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.lblNombre.Location = New System.Drawing.Point(61, 595)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDni
        '
        Me.lblDni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDni.AutoSize = True
        Me.lblDni.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDni.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblDni.Location = New System.Drawing.Point(61, 579)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(0, 13)
        Me.lblDni.TabIndex = 5
        Me.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdmin
        '
        Me.lblAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAdmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblAdmin.Location = New System.Drawing.Point(61, 563)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(27, 13)
        Me.lblAdmin.TabIndex = 4
        Me.lblAdmin.Text = "hola"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MostrarMenu
        '
        Me.MostrarMenu.Interval = 50
        '
        'OcultarMenu
        '
        Me.OcultarMenu.Interval = 50
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.White
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(890, 610)
        Me.panelContenedor.TabIndex = 3
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnMovimientos.BackColor = System.Drawing.Color.White
        Me.btnMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMovimientos.BorderRadius = 0
        Me.btnMovimientos.ButtonText = "Movimientos"
        Me.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMovimientos.DisabledColor = System.Drawing.Color.Gray
        Me.btnMovimientos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMovimientos.Iconimage = Global.CapaPresentacion.My.Resources.Resources.movement
        Me.btnMovimientos.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.movement
        Me.btnMovimientos.Iconimage_right_Selected = Nothing
        Me.btnMovimientos.Iconimage_Selected = Nothing
        Me.btnMovimientos.IconMarginLeft = 0
        Me.btnMovimientos.IconMarginRight = 0
        Me.btnMovimientos.IconRightVisible = True
        Me.btnMovimientos.IconRightZoom = 0R
        Me.btnMovimientos.IconVisible = True
        Me.btnMovimientos.IconZoom = 90.0R
        Me.btnMovimientos.IsTab = False
        Me.btnMovimientos.Location = New System.Drawing.Point(0, 56)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Normalcolor = System.Drawing.Color.White
        Me.btnMovimientos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnMovimientos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMovimientos.selected = False
        Me.btnMovimientos.Size = New System.Drawing.Size(220, 40)
        Me.btnMovimientos.TabIndex = 2
        Me.btnMovimientos.Text = "Movimientos"
        Me.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMovimientos.Textcolor = System.Drawing.Color.Black
        Me.btnMovimientos.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnVentas
        '
        Me.btnVentas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentas.BorderRadius = 0
        Me.btnVentas.ButtonText = "Ventas"
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.DisabledColor = System.Drawing.Color.Gray
        Me.btnVentas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVentas.Iconimage = Global.CapaPresentacion.My.Resources.Resources.ventapro
        Me.btnVentas.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.ventapro
        Me.btnVentas.Iconimage_right_Selected = Nothing
        Me.btnVentas.Iconimage_Selected = Nothing
        Me.btnVentas.IconMarginLeft = 0
        Me.btnVentas.IconMarginRight = 0
        Me.btnVentas.IconRightVisible = True
        Me.btnVentas.IconRightZoom = 0R
        Me.btnVentas.IconVisible = True
        Me.btnVentas.IconZoom = 90.0R
        Me.btnVentas.IsTab = False
        Me.btnVentas.Location = New System.Drawing.Point(0, 0)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVentas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnVentas.selected = True
        Me.btnVentas.Size = New System.Drawing.Size(220, 40)
        Me.btnVentas.TabIndex = 10
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnVentas.Textcolor = System.Drawing.Color.Black
        Me.btnVentas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDetalleVenta
        '
        Me.btnDetalleVenta.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDetalleVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnDetalleVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetalleVenta.BorderRadius = 0
        Me.btnDetalleVenta.ButtonText = "Detalle de la Venta"
        Me.btnDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetalleVenta.DisabledColor = System.Drawing.Color.Gray
        Me.btnDetalleVenta.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDetalleVenta.Iconimage = Global.CapaPresentacion.My.Resources.Resources.detalle
        Me.btnDetalleVenta.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.detalle
        Me.btnDetalleVenta.Iconimage_right_Selected = Nothing
        Me.btnDetalleVenta.Iconimage_Selected = Nothing
        Me.btnDetalleVenta.IconMarginLeft = 0
        Me.btnDetalleVenta.IconMarginRight = 0
        Me.btnDetalleVenta.IconRightVisible = True
        Me.btnDetalleVenta.IconRightZoom = 0R
        Me.btnDetalleVenta.IconVisible = True
        Me.btnDetalleVenta.IconZoom = 90.0R
        Me.btnDetalleVenta.IsTab = False
        Me.btnDetalleVenta.Location = New System.Drawing.Point(0, 39)
        Me.btnDetalleVenta.Name = "btnDetalleVenta"
        Me.btnDetalleVenta.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnDetalleVenta.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDetalleVenta.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDetalleVenta.selected = True
        Me.btnDetalleVenta.Size = New System.Drawing.Size(220, 40)
        Me.btnDetalleVenta.TabIndex = 11
        Me.btnDetalleVenta.Text = "Detalle de la Venta"
        Me.btnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDetalleVenta.Textcolor = System.Drawing.Color.Black
        Me.btnDetalleVenta.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnReportes
        '
        Me.btnReportes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReportes.BackColor = System.Drawing.Color.White
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.BorderRadius = 0
        Me.btnReportes.ButtonText = "Reportes"
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.DisabledColor = System.Drawing.Color.Gray
        Me.btnReportes.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReportes.Iconimage = Global.CapaPresentacion.My.Resources.Resources.reporte
        Me.btnReportes.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.reporte
        Me.btnReportes.Iconimage_right_Selected = Nothing
        Me.btnReportes.Iconimage_Selected = Nothing
        Me.btnReportes.IconMarginLeft = 0
        Me.btnReportes.IconMarginRight = 0
        Me.btnReportes.IconRightVisible = True
        Me.btnReportes.IconRightZoom = 0R
        Me.btnReportes.IconVisible = True
        Me.btnReportes.IconZoom = 90.0R
        Me.btnReportes.IsTab = False
        Me.btnReportes.Location = New System.Drawing.Point(0, 492)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Normalcolor = System.Drawing.Color.White
        Me.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnReportes.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReportes.selected = True
        Me.btnReportes.Size = New System.Drawing.Size(220, 40)
        Me.btnReportes.TabIndex = 13
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReportes.Textcolor = System.Drawing.Color.Black
        Me.btnReportes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnMarcas
        '
        Me.btnMarcas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMarcas.BorderRadius = 0
        Me.btnMarcas.ButtonText = "Marcas"
        Me.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarcas.DisabledColor = System.Drawing.Color.Gray
        Me.btnMarcas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMarcas.Iconimage = Global.CapaPresentacion.My.Resources.Resources.marca
        Me.btnMarcas.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.marca
        Me.btnMarcas.Iconimage_right_Selected = Nothing
        Me.btnMarcas.Iconimage_Selected = Nothing
        Me.btnMarcas.IconMarginLeft = 0
        Me.btnMarcas.IconMarginRight = 0
        Me.btnMarcas.IconRightVisible = True
        Me.btnMarcas.IconRightZoom = 0R
        Me.btnMarcas.IconVisible = True
        Me.btnMarcas.IconZoom = 90.0R
        Me.btnMarcas.IsTab = False
        Me.btnMarcas.Location = New System.Drawing.Point(0, 0)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMarcas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMarcas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMarcas.selected = True
        Me.btnMarcas.Size = New System.Drawing.Size(220, 40)
        Me.btnMarcas.TabIndex = 0
        Me.btnMarcas.Text = "Marcas"
        Me.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMarcas.Textcolor = System.Drawing.Color.Black
        Me.btnMarcas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCategorias
        '
        Me.btnCategorias.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategorias.BorderRadius = 0
        Me.btnCategorias.ButtonText = "Categorias"
        Me.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategorias.DisabledColor = System.Drawing.Color.Gray
        Me.btnCategorias.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCategorias.Iconimage = Global.CapaPresentacion.My.Resources.Resources.ropa
        Me.btnCategorias.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.ropa
        Me.btnCategorias.Iconimage_right_Selected = Nothing
        Me.btnCategorias.Iconimage_Selected = Nothing
        Me.btnCategorias.IconMarginLeft = 0
        Me.btnCategorias.IconMarginRight = 0
        Me.btnCategorias.IconRightVisible = True
        Me.btnCategorias.IconRightZoom = 0R
        Me.btnCategorias.IconVisible = True
        Me.btnCategorias.IconZoom = 90.0R
        Me.btnCategorias.IsTab = False
        Me.btnCategorias.Location = New System.Drawing.Point(0, 39)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCategorias.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategorias.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCategorias.selected = False
        Me.btnCategorias.Size = New System.Drawing.Size(220, 40)
        Me.btnCategorias.TabIndex = 7
        Me.btnCategorias.Text = "Categorias"
        Me.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCategorias.Textcolor = System.Drawing.Color.Black
        Me.btnCategorias.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnProductos
        '
        Me.btnProductos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProductos.BorderRadius = 0
        Me.btnProductos.ButtonText = "Productos"
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.DisabledColor = System.Drawing.Color.Gray
        Me.btnProductos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProductos.Iconimage = Global.CapaPresentacion.My.Resources.Resources.Producto
        Me.btnProductos.Iconimage_right = Nothing
        Me.btnProductos.Iconimage_right_Selected = Nothing
        Me.btnProductos.Iconimage_Selected = Nothing
        Me.btnProductos.IconMarginLeft = 0
        Me.btnProductos.IconMarginRight = 0
        Me.btnProductos.IconRightVisible = True
        Me.btnProductos.IconRightZoom = 0R
        Me.btnProductos.IconVisible = True
        Me.btnProductos.IconZoom = 90.0R
        Me.btnProductos.IsTab = False
        Me.btnProductos.Location = New System.Drawing.Point(0, 78)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnProductos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProductos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProductos.selected = True
        Me.btnProductos.Size = New System.Drawing.Size(220, 40)
        Me.btnProductos.TabIndex = 8
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProductos.Textcolor = System.Drawing.Color.Black
        Me.btnProductos.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClientes
        '
        Me.btnClientes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.BorderRadius = 0
        Me.btnClientes.ButtonText = "Clientes"
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.DisabledColor = System.Drawing.Color.Gray
        Me.btnClientes.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClientes.Iconimage = Global.CapaPresentacion.My.Resources.Resources.cliente
        Me.btnClientes.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.cliente
        Me.btnClientes.Iconimage_right_Selected = Nothing
        Me.btnClientes.Iconimage_Selected = Nothing
        Me.btnClientes.IconMarginLeft = 0
        Me.btnClientes.IconMarginRight = 0
        Me.btnClientes.IconRightVisible = True
        Me.btnClientes.IconRightZoom = 0R
        Me.btnClientes.IconVisible = True
        Me.btnClientes.IconZoom = 90.0R
        Me.btnClientes.IsTab = False
        Me.btnClientes.Location = New System.Drawing.Point(0, 117)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClientes.selected = False
        Me.btnClientes.Size = New System.Drawing.Size(220, 40)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClientes.Textcolor = System.Drawing.Color.Black
        Me.btnClientes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTrabajadores
        '
        Me.btnTrabajadores.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTrabajadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnTrabajadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTrabajadores.BorderRadius = 0
        Me.btnTrabajadores.ButtonText = "Trabajadores"
        Me.btnTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrabajadores.DisabledColor = System.Drawing.Color.Gray
        Me.btnTrabajadores.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTrabajadores.Iconimage = Global.CapaPresentacion.My.Resources.Resources.equipo
        Me.btnTrabajadores.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.equipo
        Me.btnTrabajadores.Iconimage_right_Selected = Nothing
        Me.btnTrabajadores.Iconimage_Selected = Nothing
        Me.btnTrabajadores.IconMarginLeft = 0
        Me.btnTrabajadores.IconMarginRight = 0
        Me.btnTrabajadores.IconRightVisible = True
        Me.btnTrabajadores.IconRightZoom = 0R
        Me.btnTrabajadores.IconVisible = True
        Me.btnTrabajadores.IconZoom = 90.0R
        Me.btnTrabajadores.IsTab = False
        Me.btnTrabajadores.Location = New System.Drawing.Point(0, 0)
        Me.btnTrabajadores.Name = "btnTrabajadores"
        Me.btnTrabajadores.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnTrabajadores.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTrabajadores.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTrabajadores.selected = False
        Me.btnTrabajadores.Size = New System.Drawing.Size(220, 40)
        Me.btnTrabajadores.TabIndex = 12
        Me.btnTrabajadores.Text = "Trabajadores"
        Me.btnTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTrabajadores.Textcolor = System.Drawing.Color.Black
        Me.btnTrabajadores.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuarios.BorderRadius = 0
        Me.btnUsuarios.ButtonText = "Usuarios"
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.DisabledColor = System.Drawing.Color.Gray
        Me.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUsuarios.Iconimage = Global.CapaPresentacion.My.Resources.Resources.user
        Me.btnUsuarios.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.user
        Me.btnUsuarios.Iconimage_right_Selected = Nothing
        Me.btnUsuarios.Iconimage_Selected = Nothing
        Me.btnUsuarios.IconMarginLeft = 0
        Me.btnUsuarios.IconMarginRight = 0
        Me.btnUsuarios.IconRightVisible = True
        Me.btnUsuarios.IconRightZoom = 0R
        Me.btnUsuarios.IconVisible = True
        Me.btnUsuarios.IconZoom = 90.0R
        Me.btnUsuarios.IsTab = False
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 39)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUsuarios.selected = False
        Me.btnUsuarios.Size = New System.Drawing.Size(220, 40)
        Me.btnUsuarios.TabIndex = 13
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUsuarios.Textcolor = System.Drawing.Color.Black
        Me.btnUsuarios.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnProcesos
        '
        Me.btnProcesos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProcesos.BackColor = System.Drawing.Color.White
        Me.btnProcesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProcesos.BorderRadius = 0
        Me.btnProcesos.ButtonText = "Procesos"
        Me.btnProcesos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcesos.DisabledColor = System.Drawing.Color.Gray
        Me.btnProcesos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProcesos.Iconimage = Global.CapaPresentacion.My.Resources.Resources.venta
        Me.btnProcesos.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.venta
        Me.btnProcesos.Iconimage_right_Selected = Nothing
        Me.btnProcesos.Iconimage_Selected = Nothing
        Me.btnProcesos.IconMarginLeft = 0
        Me.btnProcesos.IconMarginRight = 0
        Me.btnProcesos.IconRightVisible = True
        Me.btnProcesos.IconRightZoom = 0R
        Me.btnProcesos.IconVisible = True
        Me.btnProcesos.IconZoom = 90.0R
        Me.btnProcesos.IsTab = False
        Me.btnProcesos.Location = New System.Drawing.Point(0, 254)
        Me.btnProcesos.Name = "btnProcesos"
        Me.btnProcesos.Normalcolor = System.Drawing.Color.White
        Me.btnProcesos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnProcesos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProcesos.selected = True
        Me.btnProcesos.Size = New System.Drawing.Size(220, 40)
        Me.btnProcesos.TabIndex = 12
        Me.btnProcesos.Text = "Procesos"
        Me.btnProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProcesos.Textcolor = System.Drawing.Color.Black
        Me.btnProcesos.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPermisos
        '
        Me.btnPermisos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPermisos.BackColor = System.Drawing.Color.White
        Me.btnPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPermisos.BorderRadius = 0
        Me.btnPermisos.ButtonText = "Permisos"
        Me.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPermisos.DisabledColor = System.Drawing.Color.Gray
        Me.btnPermisos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPermisos.Iconimage = Global.CapaPresentacion.My.Resources.Resources.seguridad
        Me.btnPermisos.Iconimage_right = Global.CapaPresentacion.My.Resources.Resources.seguridad
        Me.btnPermisos.Iconimage_right_Selected = Nothing
        Me.btnPermisos.Iconimage_Selected = Nothing
        Me.btnPermisos.IconMarginLeft = 0
        Me.btnPermisos.IconMarginRight = 0
        Me.btnPermisos.IconRightVisible = True
        Me.btnPermisos.IconRightZoom = 0R
        Me.btnPermisos.IconVisible = True
        Me.btnPermisos.IconZoom = 90.0R
        Me.btnPermisos.IsTab = False
        Me.btnPermisos.Location = New System.Drawing.Point(0, 373)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Normalcolor = System.Drawing.Color.White
        Me.btnPermisos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPermisos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPermisos.selected = True
        Me.btnPermisos.Size = New System.Drawing.Size(220, 40)
        Me.btnPermisos.TabIndex = 9
        Me.btnPermisos.Text = "Permisos"
        Me.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPermisos.Textcolor = System.Drawing.Color.Black
        Me.btnPermisos.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.prubea
        Me.PictureBox2.Location = New System.Drawing.Point(1, 565)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 45)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.icono
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'menuDeslizar
        '
        Me.menuDeslizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menuDeslizar.BackColor = System.Drawing.Color.Transparent
        Me.menuDeslizar.Image = Global.CapaPresentacion.My.Resources.Resources.menuBarra
        Me.menuDeslizar.ImageActive = Nothing
        Me.menuDeslizar.Location = New System.Drawing.Point(172, 0)
        Me.menuDeslizar.Name = "menuDeslizar"
        Me.menuDeslizar.Size = New System.Drawing.Size(49, 33)
        Me.menuDeslizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.menuDeslizar.TabIndex = 0
        Me.menuDeslizar.TabStop = False
        Me.menuDeslizar.Zoom = 10
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.ImageActive = Nothing
        Me.btnRestaurar.Location = New System.Drawing.Point(1030, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        Me.btnRestaurar.Zoom = 10
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.ImageActive = Nothing
        Me.btnMinimizar.Location = New System.Drawing.Point(990, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.Zoom = 10
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.ImageActive = Nothing
        Me.btnCerrar.Location = New System.Drawing.Point(1070, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Zoom = 10
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximizar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.ImageActive = Nothing
        Me.btnMaximizar.Location = New System.Drawing.Point(1030, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        Me.btnMaximizar.Zoom = 10
        '
        'FormMenuPrincipalSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 650)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.panelCabezera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMenuPrincipalSV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuPrincipalSV"
        Me.panelCabezera.ResumeLayout(False)
        Me.panelCabezera.PerformLayout()
        Me.panelmenu.ResumeLayout(False)
        Me.panelmenu.PerformLayout()
        Me.panelProcesos.ResumeLayout(False)
        Me.panelMovimientos.ResumeLayout(False)
        Me.panelPermisos.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuDeslizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCabezera As Panel
    Private WithEvents label1 As Label
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRestaurar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelmenu As Panel
    Friend WithEvents btnMovimientos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelProcesos As Panel
    Friend WithEvents btnVentas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDetalleVenta As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnReportes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelMovimientos As Panel
    Friend WithEvents btnMarcas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCategorias As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnProductos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClientes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelPermisos As Panel
    Friend WithEvents btnTrabajadores As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUsuarios As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnProcesos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblNombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnPermisos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblDni As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblAdmin As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menuDeslizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents MostrarMenu As Timer
    Friend WithEvents OcultarMenu As Timer
End Class
