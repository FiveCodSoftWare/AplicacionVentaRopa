<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
    Inherits MaterialSkin.Controls.MaterialForm
    'Inherits System.Windows.Forms.Form
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
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dataListadoVentas = New System.Windows.Forms.DataGridView()
        Me.comboItem4 = New DevComponents.Editors.ComboItem()
        Me.comboItem3 = New DevComponents.Editors.ComboItem()
        Me.dtFechaVenta = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.txtNombreUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigoCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNumeroComprobante = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboTipoComprobante = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnModificar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(330, 110)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(251, 18)
        Me.inexistente.TabIndex = 30
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No existen Ventas para Mostrar "
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Nombre", "NDocumento"})
        Me.cboBuscar.Location = New System.Drawing.Point(123, 23)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(132, 26)
        Me.cboBuscar.TabIndex = 29
        Me.cboBuscar.Text = "Nombre"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(288, 23)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(387, 25)
        Me.txtBuscar.TabIndex = 26
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.inexistente)
        Me.GroupBox3.Controls.Add(Me.cboBuscar)
        Me.GroupBox3.Controls.Add(Me.dataListadoVentas)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(146, 254)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(875, 229)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Registros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(228, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(313, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Seleccionar un fila para Agregar Productos a la Venta"
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
        Me.dataListadoVentas.EnableHeadersVisualStyles = False
        Me.dataListadoVentas.GridColor = System.Drawing.Color.White
        Me.dataListadoVentas.Location = New System.Drawing.Point(8, 60)
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
        Me.dataListadoVentas.Size = New System.Drawing.Size(861, 143)
        Me.dataListadoVentas.TabIndex = 28
        '
        'comboItem4
        '
        Me.comboItem4.Text = "Boleta"
        '
        'comboItem3
        '
        Me.comboItem3.Text = "Factura"
        '
        'dtFechaVenta
        '
        Me.dtFechaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtFechaVenta.BorderRadius = 0
        Me.dtFechaVenta.ForeColor = System.Drawing.Color.Black
        Me.dtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVenta.FormatCustom = Nothing
        Me.dtFechaVenta.Location = New System.Drawing.Point(584, 119)
        Me.dtFechaVenta.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtFechaVenta.Name = "dtFechaVenta"
        Me.dtFechaVenta.Size = New System.Drawing.Size(182, 26)
        Me.dtFechaVenta.TabIndex = 30
        Me.dtFechaVenta.Value = New Date(2018, 6, 15, 10, 18, 27, 612)
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
        Me.txtNombreUsuario.Location = New System.Drawing.Point(158, 121)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(171, 24)
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
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(85, 121)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(67, 24)
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
        Me.txtNombreCliente.Location = New System.Drawing.Point(85, 80)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(244, 24)
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
        Me.txtCodigoCliente.Location = New System.Drawing.Point(85, 80)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(67, 24)
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
        Me.txtNumeroComprobante.MaxLength = 50
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(182, 24)
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
        Me.txtCodigo.Location = New System.Drawing.Point(85, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(221, 24)
        Me.txtCodigo.TabIndex = 24
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.DisplayMember = "Text"
        Me.cboTipoComprobante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.ItemHeight = 18
        Me.cboTipoComprobante.Items.AddRange(New Object() {Me.comboItem3, Me.comboItem4})
        Me.cboTipoComprobante.Location = New System.Drawing.Point(584, 36)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(182, 24)
        Me.cboTipoComprobante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipoComprobante.TabIndex = 23
        Me.cboTipoComprobante.WatermarkText = "Seleccione..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboCliente)
        Me.GroupBox2.Controls.Add(Me.txtflag)
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
        Me.GroupBox2.Location = New System.Drawing.Point(146, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(875, 178)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(0, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(412, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(382, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "*"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(85, 79)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(244, 26)
        Me.cboCliente.TabIndex = 37
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(318, 11)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(55, 24)
        Me.txtflag.TabIndex = 36
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(5, 123)
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
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(470, 119)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(106, 18)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "Fecha Venta:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 85)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(65, 18)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Cliente:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 36)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(67, 18)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Código:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 413)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 0
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.desactivara
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
        Me.btnCancelar.Location = New System.Drawing.Point(7, 271)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(116, 48)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnModificar
        '
        Me.btnModificar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.BorderRadius = 0
        Me.btnModificar.ButtonText = "Modificar"
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.DisabledColor = System.Drawing.Color.Gray
        Me.btnModificar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnModificar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.modificar
        Me.btnModificar.Iconimage_right = Nothing
        Me.btnModificar.Iconimage_right_Selected = Nothing
        Me.btnModificar.Iconimage_Selected = Nothing
        Me.btnModificar.IconMarginLeft = 0
        Me.btnModificar.IconMarginRight = 0
        Me.btnModificar.IconRightVisible = True
        Me.btnModificar.IconRightZoom = 0R
        Me.btnModificar.IconVisible = True
        Me.btnModificar.IconZoom = 90.0R
        Me.btnModificar.IsTab = False
        Me.btnModificar.Location = New System.Drawing.Point(7, 198)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnModificar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnModificar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnModificar.selected = False
        Me.btnModificar.Size = New System.Drawing.Size(114, 40)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Textcolor = System.Drawing.Color.Black
        Me.btnModificar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 0
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Global.CapaPresentacion.My.Resources.Resources.gua
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
        Me.btnGuardar.Location = New System.Drawing.Point(7, 123)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(116, 44)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnNuevo.Location = New System.Drawing.Point(7, 50)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(116, 47)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Textcolor = System.Drawing.Color.Black
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                          ............................. :: FORMUL" &
    "ARIO DE REGISTRO DE VENTAS :: ......................"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents cboBuscar As ComboBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents dataListadoVentas As DataGridView
    Private WithEvents comboItem4 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents dtFechaVenta As Bunifu.Framework.UI.BunifuDatepicker
    Private WithEvents txtNumeroComprobante As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents cboTipoComprobante As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnModificar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents txtflag As TextBox
    Friend WithEvents txtNombreUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodigoUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents txtCodigoCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents txtNombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboCliente As ComboBox
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Private WithEvents errorIcono As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
