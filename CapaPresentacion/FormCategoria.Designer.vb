<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCategoria
    Inherits MaterialSkin.Controls.MaterialForm

    ' Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.materialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.materialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.btnImprimir = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboComBuscar = New System.Windows.Forms.ComboBox()
        Me.chkEliminar = New MaterialSkin.Controls.MaterialCheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.dataListadoCategoria = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnNuevo = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnCancelar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnEditar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.materialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.materialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.materialTabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'materialTabSelector1
        '
        Me.materialTabSelector1.BaseTabControl = Me.materialTabControl1
        Me.materialTabSelector1.Depth = 0
        Me.materialTabSelector1.Location = New System.Drawing.Point(12, 68)
        Me.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialTabSelector1.Name = "materialTabSelector1"
        Me.materialTabSelector1.Size = New System.Drawing.Size(786, 42)
        Me.materialTabSelector1.TabIndex = 6
        Me.materialTabSelector1.Text = "materialTabSelector1"
        '
        'materialTabControl1
        '
        Me.materialTabControl1.Controls.Add(Me.tabPage1)
        Me.materialTabControl1.Controls.Add(Me.tabPage2)
        Me.materialTabControl1.Depth = 0
        Me.materialTabControl1.Location = New System.Drawing.Point(12, 116)
        Me.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialTabControl1.Name = "materialTabControl1"
        Me.materialTabControl1.SelectedIndex = 0
        Me.materialTabControl1.Size = New System.Drawing.Size(786, 335)
        Me.materialTabControl1.TabIndex = 7
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.btnImprimir)
        Me.tabPage1.Controls.Add(Me.txtBuscar)
        Me.tabPage1.Controls.Add(Me.cboComBuscar)
        Me.tabPage1.Controls.Add(Me.chkEliminar)
        Me.tabPage1.Controls.Add(Me.inexistente)
        Me.tabPage1.Controls.Add(Me.dataListadoCategoria)
        Me.tabPage1.Controls.Add(Me.btnEliminar)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(778, 309)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Listado"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = True
        Me.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImprimir.Depth = 0
        Me.btnImprimir.Icon = Global.CapaPresentacion.My.Resources.Resources.imprimir
        Me.btnImprimir.Location = New System.Drawing.Point(601, 259)
        Me.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Primary = True
        Me.btnImprimir.Size = New System.Drawing.Size(158, 36)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir Todos"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.txtBuscar.Location = New System.Drawing.Point(175, 16)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(336, 28)
        Me.txtBuscar.TabIndex = 13
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'cboComBuscar
        '
        Me.cboComBuscar.FormattingEnabled = True
        Me.cboComBuscar.Items.AddRange(New Object() {"Nombre"})
        Me.cboComBuscar.Location = New System.Drawing.Point(41, 22)
        Me.cboComBuscar.Name = "cboComBuscar"
        Me.cboComBuscar.Size = New System.Drawing.Size(117, 21)
        Me.cboComBuscar.TabIndex = 12
        Me.cboComBuscar.Text = "Nombre"
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.BackColor = System.Drawing.Color.Transparent
        Me.chkEliminar.Depth = 0
        Me.chkEliminar.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkEliminar.Location = New System.Drawing.Point(13, 263)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEliminar.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Ripple = True
        Me.chkEliminar.Size = New System.Drawing.Size(95, 30)
        Me.chkEliminar.TabIndex = 7
        Me.chkEliminar.Text = "Selecionar"
        Me.chkEliminar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(352, 140)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 11
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos no existen "
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListadoCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListadoCategoria.ColumnHeadersHeight = 25
        Me.dataListadoCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListadoCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoCategoria.EnableHeadersVisualStyles = False
        Me.dataListadoCategoria.GridColor = System.Drawing.Color.White
        Me.dataListadoCategoria.Location = New System.Drawing.Point(24, 65)
        Me.dataListadoCategoria.MultiSelect = False
        Me.dataListadoCategoria.Name = "dataListadoCategoria"
        Me.dataListadoCategoria.ReadOnly = True
        Me.dataListadoCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListadoCategoria.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dataListadoCategoria.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListadoCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoCategoria.Size = New System.Drawing.Size(735, 181)
        Me.dataListadoCategoria.TabIndex = 8
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.Icon = Global.CapaPresentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(627, 13)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Primary = True
        Me.btnEliminar.Size = New System.Drawing.Size(111, 36)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.groupBox1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(778, 309)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Registro Categoria"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtDescripcion)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtCodigo)
        Me.groupBox1.Controls.Add(Me.panel1)
        Me.groupBox1.Controls.Add(Me.cboEstado)
        Me.groupBox1.Controls.Add(Me.materialLabel6)
        Me.groupBox1.Controls.Add(Me.materialLabel5)
        Me.groupBox1.Controls.Add(Me.materialLabel4)
        Me.groupBox1.Controls.Add(Me.materialLabel3)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(8, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupBox1.Size = New System.Drawing.Size(764, 280)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Categorias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(17, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "*"
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
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 147)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(211, 57)
        Me.txtDescripcion.TabIndex = 19
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
        Me.txtNombre.Location = New System.Drawing.Point(124, 81)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(211, 30)
        Me.txtNombre.TabIndex = 18
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
        Me.txtCodigo.Location = New System.Drawing.Point(124, 25)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo.Size = New System.Drawing.Size(211, 30)
        Me.txtCodigo.TabIndex = 17
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.btnGuardar)
        Me.panel1.Controls.Add(Me.btnNuevo)
        Me.panel1.Controls.Add(Me.btnCancelar)
        Me.panel1.Controls.Add(Me.btnEditar)
        Me.panel1.Location = New System.Drawing.Point(441, 57)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(171, 179)
        Me.panel1.TabIndex = 13
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowDrop = True
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGuardar.Depth = 0
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Icon = Global.CapaPresentacion.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(30, 71)
        Me.btnGuardar.MaximumSize = New System.Drawing.Size(100, 36)
        Me.btnGuardar.MinimumSize = New System.Drawing.Size(121, 36)
        Me.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Primary = True
        Me.btnGuardar.Size = New System.Drawing.Size(121, 36)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = True
        Me.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Depth = 0
        Me.btnNuevo.Icon = Global.CapaPresentacion.My.Resources.Resources.nuevo
        Me.btnNuevo.Location = New System.Drawing.Point(30, 13)
        Me.btnNuevo.MaximumSize = New System.Drawing.Size(120, 36)
        Me.btnNuevo.MinimumSize = New System.Drawing.Size(121, 36)
        Me.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Primary = True
        Me.btnNuevo.Size = New System.Drawing.Size(121, 36)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar.Depth = 0
        Me.btnCancelar.Icon = Global.CapaPresentacion.My.Resources.Resources.cancelar
        Me.btnCancelar.Location = New System.Drawing.Point(30, 128)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(119, 36)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(121, 36)
        Me.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Primary = True
        Me.btnCancelar.Size = New System.Drawing.Size(121, 36)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditar.Depth = 0
        Me.btnEditar.Icon = Global.CapaPresentacion.My.Resources.Resources.modificar
        Me.btnEditar.Location = New System.Drawing.Point(30, 71)
        Me.btnEditar.MaximumSize = New System.Drawing.Size(121, 36)
        Me.btnEditar.MinimumSize = New System.Drawing.Size(121, 36)
        Me.btnEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Primary = True
        Me.btnEditar.Size = New System.Drawing.Size(121, 36)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"A", "I"})
        Me.cboEstado.Location = New System.Drawing.Point(124, 233)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEstado.Size = New System.Drawing.Size(211, 28)
        Me.cboEstado.TabIndex = 8
        '
        'materialLabel6
        '
        Me.materialLabel6.AutoSize = True
        Me.materialLabel6.Depth = 0
        Me.materialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel6.Location = New System.Drawing.Point(33, 235)
        Me.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel6.Name = "materialLabel6"
        Me.materialLabel6.Size = New System.Drawing.Size(60, 19)
        Me.materialLabel6.TabIndex = 3
        Me.materialLabel6.Text = ":Estado"
        '
        'materialLabel5
        '
        Me.materialLabel5.AutoSize = True
        Me.materialLabel5.Depth = 0
        Me.materialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel5.Location = New System.Drawing.Point(32, 85)
        Me.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel5.Name = "materialLabel5"
        Me.materialLabel5.Size = New System.Drawing.Size(67, 19)
        Me.materialLabel5.TabIndex = 2
        Me.materialLabel5.Text = ":Nombre"
        '
        'materialLabel4
        '
        Me.materialLabel4.AutoSize = True
        Me.materialLabel4.Depth = 0
        Me.materialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel4.Location = New System.Drawing.Point(6, 166)
        Me.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel4.Name = "materialLabel4"
        Me.materialLabel4.Size = New System.Drawing.Size(93, 19)
        Me.materialLabel4.TabIndex = 1
        Me.materialLabel4.Text = ":Descripcion"
        '
        'materialLabel3
        '
        Me.materialLabel3.AutoSize = True
        Me.materialLabel3.Depth = 0
        Me.materialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.materialLabel3.Location = New System.Drawing.Point(32, 27)
        Me.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.materialLabel3.Name = "materialLabel3"
        Me.materialLabel3.Size = New System.Drawing.Size(61, 19)
        Me.materialLabel3.TabIndex = 0
        Me.materialLabel3.Text = ":Código"
        '
        'FormCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 463)
        Me.Controls.Add(Me.materialTabSelector1)
        Me.Controls.Add(Me.materialTabControl1)
        Me.Name = "FormCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                   ................................ :: FORMULARIO DE REGISTRO CAT" &
    "EGORIAS :: ............................."
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.materialTabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents errorIcono As ErrorProvider
    Private WithEvents materialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Private WithEvents materialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboComBuscar As ComboBox
    Private WithEvents chkEliminar As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents inexistente As LinkLabel
    Private WithEvents dataListadoCategoria As DataGridView
    Private WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents btnEliminar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents tabPage2 As TabPage
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents panel1 As Panel
    Private WithEvents btnGuardar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents btnNuevo As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents btnCancelar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents btnEditar As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents cboEstado As ComboBox
    Private WithEvents materialLabel6 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel5 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel4 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents materialLabel3 As MaterialSkin.Controls.MaterialLabel
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Private WithEvents btnImprimir As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As Label
End Class
