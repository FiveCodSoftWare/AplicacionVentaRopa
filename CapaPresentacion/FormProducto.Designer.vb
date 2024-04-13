<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
    ' Inherits System.Windows.Forms.Form
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
        Me.txtNombreMarca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombreCategoria = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtStock = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPrecioVenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPrecioCompra = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoBarras = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtidMarca = New System.Windows.Forms.TextBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.dataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnQuitar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnImportar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.materialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.materialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.materialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.materialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSelecionarMa = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSelecionarca = New Bunifu.Framework.UI.BunifuImageButton()
        Me.materialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.pImagen = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.materialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.materialTabControl1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnSelecionarMa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelecionarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreMarca.Border.Class = "TextBoxBorder"
        Me.txtNombreMarca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreMarca.ForeColor = System.Drawing.Color.Black
        Me.txtNombreMarca.Location = New System.Drawing.Point(502, 224)
        Me.txtNombreMarca.Multiline = True
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreMarca.Size = New System.Drawing.Size(182, 30)
        Me.txtNombreMarca.TabIndex = 57
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreCategoria.Border.Class = "TextBoxBorder"
        Me.txtNombreCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCategoria.Location = New System.Drawing.Point(502, 165)
        Me.txtNombreCategoria.Multiline = True
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreCategoria.Size = New System.Drawing.Size(182, 30)
        Me.txtNombreCategoria.TabIndex = 56
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtStock.Border.Class = "TextBoxBorder"
        Me.txtStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.ForeColor = System.Drawing.Color.Black
        Me.txtStock.Location = New System.Drawing.Point(442, 280)
        Me.txtStock.Multiline = True
        Me.txtStock.Name = "txtStock"
        Me.txtStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStock.Size = New System.Drawing.Size(186, 30)
        Me.txtStock.TabIndex = 55
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPrecioVenta.Border.Class = "TextBoxBorder"
        Me.txtPrecioVenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.ForeColor = System.Drawing.Color.Black
        Me.txtPrecioVenta.Location = New System.Drawing.Point(140, 327)
        Me.txtPrecioVenta.Multiline = True
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrecioVenta.Size = New System.Drawing.Size(186, 30)
        Me.txtPrecioVenta.TabIndex = 54
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPrecioCompra.Border.Class = "TextBoxBorder"
        Me.txtPrecioCompra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrecioCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCompra.ForeColor = System.Drawing.Color.Black
        Me.txtPrecioCompra.Location = New System.Drawing.Point(140, 272)
        Me.txtPrecioCompra.Multiline = True
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrecioCompra.Size = New System.Drawing.Size(186, 30)
        Me.txtPrecioCompra.TabIndex = 53
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCodigoBarras.Border.Class = "TextBoxBorder"
        Me.txtCodigoBarras.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoBarras.Location = New System.Drawing.Point(140, 70)
        Me.txtCodigoBarras.Multiline = True
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoBarras.Size = New System.Drawing.Size(186, 30)
        Me.txtCodigoBarras.TabIndex = 52
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(140, 125)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(186, 30)
        Me.txtNombre.TabIndex = 51
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(140, 18)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo.Size = New System.Drawing.Size(186, 30)
        Me.txtCodigo.TabIndex = 50
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(378, 287)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(52, 19)
        Me.MaterialLabel10.TabIndex = 48
        Me.MaterialLabel10.Text = "Stock:"
        '
        'txtidMarca
        '
        Me.txtidMarca.Location = New System.Drawing.Point(442, 230)
        Me.txtidMarca.Name = "txtidMarca"
        Me.txtidMarca.Size = New System.Drawing.Size(54, 20)
        Me.txtidMarca.TabIndex = 45
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(442, 170)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(54, 20)
        Me.txtidcategoria.TabIndex = 40
        '
        'dataListadoProducto
        '
        Me.dataListadoProducto.AllowUserToAddRows = False
        Me.dataListadoProducto.AllowUserToDeleteRows = False
        Me.dataListadoProducto.AllowUserToOrderColumns = True
        Me.dataListadoProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListadoProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListadoProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListadoProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListadoProducto.ColumnHeadersHeight = 25
        Me.dataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListadoProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoProducto.EnableHeadersVisualStyles = False
        Me.dataListadoProducto.GridColor = System.Drawing.Color.White
        Me.dataListadoProducto.Location = New System.Drawing.Point(10, 86)
        Me.dataListadoProducto.MultiSelect = False
        Me.dataListadoProducto.Name = "dataListadoProducto"
        Me.dataListadoProducto.ReadOnly = True
        Me.dataListadoProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListadoProducto.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dataListadoProducto.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoProducto.Size = New System.Drawing.Size(955, 239)
        Me.dataListadoProducto.TabIndex = 17
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(23, 333)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(99, 19)
        Me.MaterialLabel9.TabIndex = 38
        Me.MaterialLabel9.Text = "Precio Venta:"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(10, 278)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(113, 19)
        Me.MaterialLabel8.TabIndex = 36
        Me.MaterialLabel8.Text = "Precio Compra:"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(716, 19)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(55, 20)
        Me.txtflag.TabIndex = 35
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.btnQuitar)
        Me.panel2.Controls.Add(Me.btnImportar)
        Me.panel2.Location = New System.Drawing.Point(545, 18)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(151, 115)
        Me.panel2.TabIndex = 34
        '
        'btnQuitar
        '
        Me.btnQuitar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitar.BorderRadius = 0
        Me.btnQuitar.ButtonText = "Quitar"
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.DisabledColor = System.Drawing.Color.Gray
        Me.btnQuitar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnQuitar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.quitar
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
        Me.btnQuitar.Location = New System.Drawing.Point(15, 59)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnQuitar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnQuitar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuitar.selected = False
        Me.btnQuitar.Size = New System.Drawing.Size(124, 38)
        Me.btnQuitar.TabIndex = 32
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnQuitar.Textcolor = System.Drawing.Color.Black
        Me.btnQuitar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnImportar
        '
        Me.btnImportar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.BorderRadius = 0
        Me.btnImportar.ButtonText = "Importar"
        Me.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportar.DisabledColor = System.Drawing.Color.Gray
        Me.btnImportar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnImportar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.importar
        Me.btnImportar.Iconimage_right = Nothing
        Me.btnImportar.Iconimage_right_Selected = Nothing
        Me.btnImportar.Iconimage_Selected = Nothing
        Me.btnImportar.IconMarginLeft = 0
        Me.btnImportar.IconMarginRight = 0
        Me.btnImportar.IconRightVisible = False
        Me.btnImportar.IconRightZoom = 0R
        Me.btnImportar.IconVisible = True
        Me.btnImportar.IconZoom = 70.0R
        Me.btnImportar.IsTab = False
        Me.btnImportar.Location = New System.Drawing.Point(15, 11)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnImportar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnImportar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImportar.selected = False
        Me.btnImportar.Size = New System.Drawing.Size(124, 38)
        Me.btnImportar.TabIndex = 33
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImportar.Textcolor = System.Drawing.Color.Black
        Me.btnImportar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(466, 196)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(149, 13)
        Me.inexistente.TabIndex = 19
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen datos para Mostrar"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.inexistente)
        Me.groupBox2.Controls.Add(Me.cbocampo)
        Me.groupBox2.Controls.Add(Me.dataListadoProducto)
        Me.groupBox2.Controls.Add(Me.chkEliminar)
        Me.groupBox2.Controls.Add(Me.txtBuscar)
        Me.groupBox2.Controls.Add(Me.btnEliminar)
        Me.groupBox2.Location = New System.Drawing.Point(6, 16)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(981, 379)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Listado de Productos"
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Nombre_Categoria"})
        Me.cbocampo.Location = New System.Drawing.Point(24, 44)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(106, 21)
        Me.cbocampo.TabIndex = 18
        Me.cbocampo.Text = "Nombre"
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Depth = 0
        Me.chkEliminar.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEliminar.Location = New System.Drawing.Point(10, 337)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(102, 30)
        Me.chkEliminar.TabIndex = 16
        Me.chkEliminar.Text = "Seleccionar "
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
        Me.txtBuscar.Location = New System.Drawing.Point(171, 39)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(484, 28)
        Me.txtBuscar.TabIndex = 15
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.Icon = Global.CapaPresentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(671, 35)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Primary = True
        Me.btnEliminar.Size = New System.Drawing.Size(111, 36)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'materialLabel7
        '
        Me.materialLabel7.AutoSize = True
        Me.materialLabel7.Depth = 0
        Me.materialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel7.Location = New System.Drawing.Point(375, 233)
        Me.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel7.Name = "materialLabel7"
        Me.materialLabel7.Size = New System.Drawing.Size(55, 19)
        Me.materialLabel7.TabIndex = 28
        Me.materialLabel7.Text = "Marca:"
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.groupBox2)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(977, 401)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Lista Productos"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'materialLabel6
        '
        Me.materialLabel6.AutoSize = True
        Me.materialLabel6.Depth = 0
        Me.materialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel6.Location = New System.Drawing.Point(352, 173)
        Me.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel6.Name = "materialLabel6"
        Me.materialLabel6.Size = New System.Drawing.Size(78, 19)
        Me.materialLabel6.TabIndex = 27
        Me.materialLabel6.Text = "Categoria:"
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.White
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"A", "I"})
        Me.cboEstado.Location = New System.Drawing.Point(442, 336)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstado.Size = New System.Drawing.Size(186, 26)
        Me.cboEstado.TabIndex = 18
        '
        'materialLabel2
        '
        Me.materialLabel2.AutoSize = True
        Me.materialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.materialLabel2.Depth = 0
        Me.materialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel2.Location = New System.Drawing.Point(370, 339)
        Me.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel2.Name = "materialLabel2"
        Me.materialLabel2.Size = New System.Drawing.Size(60, 19)
        Me.materialLabel2.TabIndex = 12
        Me.materialLabel2.Text = "Estado:"
        '
        'materialTabSelector1
        '
        Me.materialTabSelector1.BaseTabControl = Me.materialTabControl1
        Me.materialTabSelector1.Depth = 0
        Me.materialTabSelector1.Location = New System.Drawing.Point(3, 67)
        Me.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialTabSelector1.Name = "materialTabSelector1"
        Me.materialTabSelector1.Size = New System.Drawing.Size(987, 34)
        Me.materialTabSelector1.TabIndex = 66
        Me.materialTabSelector1.Text = "materialTabSelector1"
        '
        'materialTabControl1
        '
        Me.materialTabControl1.Controls.Add(Me.tabPage1)
        Me.materialTabControl1.Controls.Add(Me.tabPage2)
        Me.materialTabControl1.Depth = 0
        Me.materialTabControl1.Location = New System.Drawing.Point(5, 107)
        Me.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialTabControl1.Name = "materialTabControl1"
        Me.materialTabControl1.SelectedIndex = 0
        Me.materialTabControl1.Size = New System.Drawing.Size(985, 427)
        Me.materialTabControl1.TabIndex = 67
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.groupBox1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(977, 401)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Registro"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Panel1)
        Me.groupBox1.Controls.Add(Me.btnSelecionarMa)
        Me.groupBox1.Controls.Add(Me.btnSelecionarca)
        Me.groupBox1.Controls.Add(Me.txtNombreMarca)
        Me.groupBox1.Controls.Add(Me.txtNombreCategoria)
        Me.groupBox1.Controls.Add(Me.txtStock)
        Me.groupBox1.Controls.Add(Me.txtPrecioVenta)
        Me.groupBox1.Controls.Add(Me.txtPrecioCompra)
        Me.groupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtCodigo)
        Me.groupBox1.Controls.Add(Me.MaterialLabel10)
        Me.groupBox1.Controls.Add(Me.txtidMarca)
        Me.groupBox1.Controls.Add(Me.txtidcategoria)
        Me.groupBox1.Controls.Add(Me.MaterialLabel9)
        Me.groupBox1.Controls.Add(Me.MaterialLabel8)
        Me.groupBox1.Controls.Add(Me.txtflag)
        Me.groupBox1.Controls.Add(Me.panel2)
        Me.groupBox1.Controls.Add(Me.materialLabel7)
        Me.groupBox1.Controls.Add(Me.materialLabel6)
        Me.groupBox1.Controls.Add(Me.materialLabel1)
        Me.groupBox1.Controls.Add(Me.cboEstado)
        Me.groupBox1.Controls.Add(Me.materialLabel2)
        Me.groupBox1.Controls.Add(Me.pImagen)
        Me.groupBox1.Controls.Add(Me.txtDescripcion)
        Me.groupBox1.Controls.Add(Me.materialLabel3)
        Me.groupBox1.Controls.Add(Me.materialLabel4)
        Me.groupBox1.Controls.Add(Me.materialLabel5)
        Me.groupBox1.Location = New System.Drawing.Point(6, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(959, 376)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(-3, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(33, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 20)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(351, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(351, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(332, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(356, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 20)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Location = New System.Drawing.Point(774, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 271)
        Me.Panel1.TabIndex = 74
        '
        'btnEditar
        '
        Me.btnEditar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.Silver
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.BorderRadius = 4
        Me.btnEditar.ButtonText = "Editar"
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEditar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEditar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.modificar
        Me.btnEditar.Iconimage_right = Nothing
        Me.btnEditar.Iconimage_right_Selected = Nothing
        Me.btnEditar.Iconimage_Selected = Nothing
        Me.btnEditar.IconMarginLeft = 0
        Me.btnEditar.IconMarginRight = 0
        Me.btnEditar.IconRightVisible = False
        Me.btnEditar.IconRightZoom = 0R
        Me.btnEditar.IconVisible = True
        Me.btnEditar.IconZoom = 80.0R
        Me.btnEditar.IsTab = False
        Me.btnEditar.Location = New System.Drawing.Point(10, 139)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Normalcolor = System.Drawing.Color.Silver
        Me.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEditar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEditar.selected = False
        Me.btnEditar.Size = New System.Drawing.Size(145, 47)
        Me.btnEditar.TabIndex = 76
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditar.Textcolor = System.Drawing.Color.Black
        Me.btnEditar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.Silver
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 4
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.DisabledColor = System.Drawing.Color.Gray
        Me.btnNuevo.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnNuevo.IconZoom = 80.0R
        Me.btnNuevo.IsTab = False
        Me.btnNuevo.Location = New System.Drawing.Point(10, 17)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.Silver
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(145, 46)
        Me.btnNuevo.TabIndex = 73
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Textcolor = System.Drawing.Color.Black
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.Silver
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 4
        Me.btnGuardar.ButtonText = "G&uardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnGuardar.IconZoom = 80.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(10, 74)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.Silver
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(145, 46)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.Text = "G&uardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.Black
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Silver
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 4
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.desactivar
        Me.btnCancelar.Iconimage_right = Nothing
        Me.btnCancelar.Iconimage_right_Selected = Nothing
        Me.btnCancelar.Iconimage_Selected = Nothing
        Me.btnCancelar.IconMarginLeft = 0
        Me.btnCancelar.IconMarginRight = 0
        Me.btnCancelar.IconRightVisible = False
        Me.btnCancelar.IconRightZoom = 0R
        Me.btnCancelar.IconVisible = True
        Me.btnCancelar.IconZoom = 80.0R
        Me.btnCancelar.IsTab = False
        Me.btnCancelar.Location = New System.Drawing.Point(10, 207)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.Silver
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(145, 48)
        Me.btnCancelar.TabIndex = 75
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSelecionarMa
        '
        Me.btnSelecionarMa.BackColor = System.Drawing.Color.Transparent
        Me.btnSelecionarMa.Image = Global.CapaPresentacion.My.Resources.Resources.buscarmarca
        Me.btnSelecionarMa.ImageActive = Nothing
        Me.btnSelecionarMa.Location = New System.Drawing.Point(690, 224)
        Me.btnSelecionarMa.Name = "btnSelecionarMa"
        Me.btnSelecionarMa.Size = New System.Drawing.Size(52, 32)
        Me.btnSelecionarMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSelecionarMa.TabIndex = 59
        Me.btnSelecionarMa.TabStop = False
        Me.btnSelecionarMa.Zoom = 10
        '
        'btnSelecionarca
        '
        Me.btnSelecionarca.BackColor = System.Drawing.Color.Transparent
        Me.btnSelecionarca.Image = Global.CapaPresentacion.My.Resources.Resources.buscarcategoria
        Me.btnSelecionarca.ImageActive = Nothing
        Me.btnSelecionarca.Location = New System.Drawing.Point(690, 164)
        Me.btnSelecionarca.Name = "btnSelecionarca"
        Me.btnSelecionarca.Size = New System.Drawing.Size(52, 32)
        Me.btnSelecionarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSelecionarca.TabIndex = 58
        Me.btnSelecionarca.TabStop = False
        Me.btnSelecionarca.Zoom = 10
        '
        'materialLabel1
        '
        Me.materialLabel1.AutoSize = True
        Me.materialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.materialLabel1.Depth = 0
        Me.materialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel1.Location = New System.Drawing.Point(61, 21)
        Me.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel1.Name = "materialLabel1"
        Me.materialLabel1.Size = New System.Drawing.Size(61, 19)
        Me.materialLabel1.TabIndex = 11
        Me.materialLabel1.Text = "Codigo:"
        '
        'pImagen
        '
        Me.pImagen.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources._new
        Me.pImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pImagen.Location = New System.Drawing.Point(374, 11)
        Me.pImagen.Name = "pImagen"
        Me.pImagen.Size = New System.Drawing.Size(148, 134)
        Me.pImagen.TabIndex = 21
        Me.pImagen.TabStop = False
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
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 181)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(186, 61)
        Me.txtDescripcion.TabIndex = 17
        Me.txtDescripcion.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'materialLabel3
        '
        Me.materialLabel3.AutoSize = True
        Me.materialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.materialLabel3.Depth = 0
        Me.materialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel3.Location = New System.Drawing.Point(29, 197)
        Me.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel3.Name = "materialLabel3"
        Me.materialLabel3.Size = New System.Drawing.Size(93, 19)
        Me.materialLabel3.TabIndex = 13
        Me.materialLabel3.Text = "Descripción:"
        '
        'materialLabel4
        '
        Me.materialLabel4.AutoSize = True
        Me.materialLabel4.Depth = 0
        Me.materialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel4.Location = New System.Drawing.Point(55, 127)
        Me.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel4.Name = "materialLabel4"
        Me.materialLabel4.Size = New System.Drawing.Size(67, 19)
        Me.materialLabel4.TabIndex = 14
        Me.materialLabel4.Text = "Nombre:"
        '
        'materialLabel5
        '
        Me.materialLabel5.AutoSize = True
        Me.materialLabel5.BackColor = System.Drawing.Color.Transparent
        Me.materialLabel5.Depth = 0
        Me.materialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel5.Location = New System.Drawing.Point(56, 72)
        Me.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel5.Name = "materialLabel5"
        Me.materialLabel5.Size = New System.Drawing.Size(66, 19)
        Me.materialLabel5.TabIndex = 19
        Me.materialLabel5.Text = "CBarras:"
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 537)
        Me.Controls.Add(Me.materialTabSelector1)
        Me.Controls.Add(Me.materialTabControl1)
        Me.Name = "FormProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                        ........................ :: FORMULARIO DE" &
    " REGISTRO DE PRODUCTOS :: ..................."
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.tabPage1.ResumeLayout(False)
        Me.materialTabControl1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnSelecionarMa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelecionarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionarMa As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSelecionarca As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtNombreMarca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNombreCategoria As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtStock As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtPrecioVenta As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtPrecioCompra As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtCodigoBarras As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtidMarca As TextBox
    Private WithEvents errorIcono As ErrorProvider
    Public WithEvents btnEditar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents materialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Private WithEvents materialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents groupBox2 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents cbocampo As ComboBox
    Private WithEvents dataListadoProducto As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents btnEliminar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents tabPage2 As TabPage
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txtidcategoria As TextBox
    Private WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtflag As TextBox
    Private WithEvents panel2 As Panel
    Public WithEvents btnQuitar As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents btnImportar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents materialLabel7 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel6 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel1 As MaterialSkin.Controls.MaterialLabel
    Public WithEvents cboEstado As ComboBox
    Private WithEvents materialLabel2 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents pImagen As PictureBox
    Public WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents materialLabel3 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel4 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel5 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
