<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarcaProducto
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
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.cboComBuscar = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.expandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.materialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.materialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expandablePanel1.SuspendLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.White
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"A", "I"})
        Me.cboEstado.Location = New System.Drawing.Point(134, 200)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstado.Size = New System.Drawing.Size(216, 26)
        Me.cboEstado.TabIndex = 2
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(330, 445)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 32
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos no existen "
        '
        'cboComBuscar
        '
        Me.cboComBuscar.FormattingEnabled = True
        Me.cboComBuscar.Items.AddRange(New Object() {"Nombre"})
        Me.cboComBuscar.Location = New System.Drawing.Point(69, 331)
        Me.cboComBuscar.Name = "cboComBuscar"
        Me.cboComBuscar.Size = New System.Drawing.Size(117, 21)
        Me.cboComBuscar.TabIndex = 31
        Me.cboComBuscar.Text = "Nombre"
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
        Me.txtBuscar.Location = New System.Drawing.Point(214, 328)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(336, 28)
        Me.txtBuscar.TabIndex = 3
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.AllowUserToOrderColumns = True
        Me.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.ColumnHeadersHeight = 25
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListado.EnableHeadersVisualStyles = False
        Me.dataListado.GridColor = System.Drawing.Color.White
        Me.dataListado.Location = New System.Drawing.Point(8, 364)
        Me.dataListado.MultiSelect = False
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListado.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(726, 147)
        Me.dataListado.TabIndex = 29
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
        Me.chkEliminar.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEliminar.Location = New System.Drawing.Point(12, 519)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(80, 30)
        Me.chkEliminar.TabIndex = 28
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'expandablePanel1
        '
        Me.expandablePanel1.CanvasColor = System.Drawing.SystemColors.ButtonHighlight
        Me.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight
        Me.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.expandablePanel1.Controls.Add(Me.btnGuardar)
        Me.expandablePanel1.Controls.Add(Me.btnCancelar)
        Me.expandablePanel1.Controls.Add(Me.btnEditar)
        Me.expandablePanel1.Controls.Add(Me.btnNuevo)
        Me.expandablePanel1.Location = New System.Drawing.Point(377, 35)
        Me.expandablePanel1.Name = "expandablePanel1"
        Me.expandablePanel1.Size = New System.Drawing.Size(342, 167)
        Me.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.Silver
        Me.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.DarkGray
        Me.expandablePanel1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.expandablePanel1.Style.ForeColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expandablePanel1.Style.GradientAngle = 90
        Me.expandablePanel1.TabIndex = 11
        Me.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel1.TitleStyle.GradientAngle = 90
        Me.expandablePanel1.TitleText = "Botones de Opciones"
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.Silver
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 4
        Me.btnGuardar.ButtonText = "G&uardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.guardarc
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 0
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = True
        Me.btnGuardar.IconRightZoom = 0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 90.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(173, 100)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.Silver
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(154, 45)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "G&uardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Textcolor = System.Drawing.Color.Black
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.BackColor = System.Drawing.Color.Silver
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 4
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.desactivar
        Me.btnCancelar.Iconimage_right = Nothing
        Me.btnCancelar.Iconimage_right_Selected = Nothing
        Me.btnCancelar.Iconimage_Selected = Nothing
        Me.btnCancelar.IconMarginLeft = 0
        Me.btnCancelar.IconMarginRight = 0
        Me.btnCancelar.IconRightVisible = True
        Me.btnCancelar.IconRightZoom = 0R
        Me.btnCancelar.IconVisible = True
        Me.btnCancelar.IconZoom = 90.0R
        Me.btnCancelar.IsTab = False
        Me.btnCancelar.Location = New System.Drawing.Point(14, 100)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.Silver
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(153, 45)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEditar
        '
        Me.btnEditar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEditar.BackColor = System.Drawing.Color.Silver
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.BorderRadius = 4
        Me.btnEditar.ButtonText = "Editar"
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEditar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEditar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.modificar
        Me.btnEditar.Iconimage_right = Nothing
        Me.btnEditar.Iconimage_right_Selected = Nothing
        Me.btnEditar.Iconimage_Selected = Nothing
        Me.btnEditar.IconMarginLeft = 0
        Me.btnEditar.IconMarginRight = 0
        Me.btnEditar.IconRightVisible = True
        Me.btnEditar.IconRightZoom = 0R
        Me.btnEditar.IconVisible = True
        Me.btnEditar.IconZoom = 90.0R
        Me.btnEditar.IsTab = False
        Me.btnEditar.Location = New System.Drawing.Point(174, 38)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Normalcolor = System.Drawing.Color.Silver
        Me.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEditar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEditar.selected = False
        Me.btnEditar.Size = New System.Drawing.Size(153, 45)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Textcolor = System.Drawing.Color.Black
        Me.btnEditar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNuevo.BackColor = System.Drawing.Color.Silver
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 4
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.DisabledColor = System.Drawing.Color.Gray
        Me.btnNuevo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.Iconimage = Global.CapaPresentacion.My.Resources.Resources.nuevo
        Me.btnNuevo.Iconimage_right = Nothing
        Me.btnNuevo.Iconimage_right_Selected = Nothing
        Me.btnNuevo.Iconimage_Selected = Nothing
        Me.btnNuevo.IconMarginLeft = 0
        Me.btnNuevo.IconMarginRight = 0
        Me.btnNuevo.IconRightVisible = True
        Me.btnNuevo.IconRightZoom = 0R
        Me.btnNuevo.IconVisible = True
        Me.btnNuevo.IconZoom = 90.0R
        Me.btnNuevo.IsTab = False
        Me.btnNuevo.Location = New System.Drawing.Point(14, 35)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.Silver
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(154, 45)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Textcolor = System.Drawing.Color.Black
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 125)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(216, 57)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'materialLabel1
        '
        Me.materialLabel1.AutoSize = True
        Me.materialLabel1.Depth = 0
        Me.materialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel1.Location = New System.Drawing.Point(50, 35)
        Me.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel1.Name = "materialLabel1"
        Me.materialLabel1.Size = New System.Drawing.Size(61, 19)
        Me.materialLabel1.TabIndex = 0
        Me.materialLabel1.Text = "Codigo:"
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.HintForeColor = System.Drawing.Color.Empty
        Me.txtNombre.HintText = ""
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(134, 73)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(216, 34)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCodigo
        '
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.HintForeColor = System.Drawing.Color.Empty
        Me.txtCodigo.HintText = ""
        Me.txtCodigo.isPassword = False
        Me.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtCodigo.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtCodigo.LineThickness = 3
        Me.txtCodigo.Location = New System.Drawing.Point(134, 20)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(216, 34)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'materialLabel4
        '
        Me.materialLabel4.AutoSize = True
        Me.materialLabel4.Depth = 0
        Me.materialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel4.Location = New System.Drawing.Point(43, 89)
        Me.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel4.Name = "materialLabel4"
        Me.materialLabel4.Size = New System.Drawing.Size(67, 19)
        Me.materialLabel4.TabIndex = 3
        Me.materialLabel4.Text = "Nombre:"
        '
        'materialLabel3
        '
        Me.materialLabel3.AutoSize = True
        Me.materialLabel3.Depth = 0
        Me.materialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel3.Location = New System.Drawing.Point(19, 141)
        Me.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel3.Name = "materialLabel3"
        Me.materialLabel3.Size = New System.Drawing.Size(93, 19)
        Me.materialLabel3.TabIndex = 2
        Me.materialLabel3.Text = "Descripción:"
        '
        'materialLabel2
        '
        Me.materialLabel2.AutoSize = True
        Me.materialLabel2.Depth = 0
        Me.materialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel2.Location = New System.Drawing.Point(51, 201)
        Me.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel2.Name = "materialLabel2"
        Me.materialLabel2.Size = New System.Drawing.Size(60, 19)
        Me.materialLabel2.TabIndex = 1
        Me.materialLabel2.Text = "Estado:"
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.expandablePanel1)
        Me.groupBox1.Controls.Add(Me.cboEstado)
        Me.groupBox1.Controls.Add(Me.txtDescripcion)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtCodigo)
        Me.groupBox1.Controls.Add(Me.materialLabel4)
        Me.groupBox1.Controls.Add(Me.materialLabel3)
        Me.groupBox1.Controls.Add(Me.materialLabel2)
        Me.groupBox1.Controls.Add(Me.materialLabel1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 71)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(725, 245)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tipo Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(37, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(21, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "*"
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = True
        Me.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImprimir.Depth = 0
        Me.btnImprimir.Icon = Global.CapaPresentacion.My.Resources.Resources.imprimir
        Me.btnImprimir.Location = New System.Drawing.Point(576, 513)
        Me.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Primary = True
        Me.btnImprimir.Size = New System.Drawing.Size(158, 36)
        Me.btnImprimir.TabIndex = 33
        Me.btnImprimir.Text = "Imprimir Todos"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.Icon = Global.CapaPresentacion.My.Resources.Resources.basura
        Me.btnEliminar.Location = New System.Drawing.Point(576, 322)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Primary = True
        Me.btnEliminar.Size = New System.Drawing.Size(111, 36)
        Me.btnEliminar.TabIndex = 27
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FormMarcaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 557)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.cboComBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dataListado)
        Me.Controls.Add(Me.chkEliminar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormMarcaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ..................... :: FOMRULARIO DE REGISTRO DE MARCA DE PRODUCTO :: ........" &
    "........."
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expandablePanel1.ResumeLayout(False)
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents cboEstado As ComboBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents cboComBuscar As ComboBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dataListado As DataGridView
    Private WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents expandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Public WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnEditar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Public WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents materialLabel1 As MaterialSkin.Controls.MaterialLabel
    Public WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents materialLabel4 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel3 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel2 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents errorIcono As ErrorProvider
    Private WithEvents btnEliminar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnImprimir As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
