<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnIngresar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtUsuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblErroalAcceder = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPassword = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSingup = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ttMensaje = New DevComponents.DotNetBar.SuperTooltip()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblHora = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtcodigotrabajador = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnUsuario = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassordRegsitro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cboAcceso = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnCancelar)
        Me.panel1.Controls.Add(Me.btnIngresar)
        Me.panel1.Controls.Add(Me.txtUsuario)
        Me.panel1.Controls.Add(Me.txtPassword)
        Me.panel1.Controls.Add(Me.lblErroalAcceder)
        Me.panel1.Controls.Add(Me.lblPassword)
        Me.panel1.Controls.Add(Me.lblUsuario)
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Location = New System.Drawing.Point(0, 154)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(319, 296)
        Me.panel1.TabIndex = 22
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 7
        Me.btnCancelar.ButtonText = "Cancel"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = CType(resources.GetObject("btnCancelar.Iconimage"), System.Drawing.Image)
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
        Me.btnCancelar.Location = New System.Drawing.Point(166, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(133, 42)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancel"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Textcolor = System.Drawing.Color.White
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnIngresar
        '
        Me.btnIngresar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresar.BorderRadius = 7
        Me.btnIngresar.ButtonText = "Login"
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.DisabledColor = System.Drawing.Color.Gray
        Me.btnIngresar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnIngresar.Iconimage = CType(resources.GetObject("btnIngresar.Iconimage"), System.Drawing.Image)
        Me.btnIngresar.Iconimage_right = Nothing
        Me.btnIngresar.Iconimage_right_Selected = Nothing
        Me.btnIngresar.Iconimage_Selected = Nothing
        Me.btnIngresar.IconMarginLeft = 0
        Me.btnIngresar.IconMarginRight = 0
        Me.btnIngresar.IconRightVisible = True
        Me.btnIngresar.IconRightZoom = 0R
        Me.btnIngresar.IconVisible = True
        Me.btnIngresar.IconZoom = 90.0R
        Me.btnIngresar.IsTab = False
        Me.btnIngresar.Location = New System.Drawing.Point(15, 249)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnIngresar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnIngresar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnIngresar.selected = False
        Me.btnIngresar.Size = New System.Drawing.Size(133, 42)
        Me.btnIngresar.TabIndex = 22
        Me.btnIngresar.Text = "Login"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Textcolor = System.Drawing.Color.White
        Me.btnIngresar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUsuario
        '
        Me.txtUsuario.Depth = 0
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUsuario.Hint = "Usuario"
        Me.txtUsuario.Location = New System.Drawing.Point(65, 98)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.Size = New System.Drawing.Size(224, 23)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TabStop = False
        Me.txtUsuario.UseSystemPasswordChar = False
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.Hint = "Password"
        Me.txtPassword.Location = New System.Drawing.Point(65, 163)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(224, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TabStop = False
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblErroalAcceder
        '
        Me.lblErroalAcceder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblErroalAcceder.Location = New System.Drawing.Point(34, 221)
        Me.lblErroalAcceder.Name = "lblErroalAcceder"
        Me.lblErroalAcceder.Size = New System.Drawing.Size(250, 15)
        Me.lblErroalAcceder.TabIndex = 22
        Me.lblErroalAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(9, 189)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(280, 15)
        Me.lblPassword.TabIndex = 21
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsuario
        '
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(15, 124)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(274, 15)
        Me.lblUsuario.TabIndex = 13
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox3
        '
        Me.pictureBox3.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.PasswordBloqueado
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox3.Location = New System.Drawing.Point(9, 146)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(55, 40)
        Me.pictureBox3.TabIndex = 19
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.User1
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox2.Location = New System.Drawing.Point(9, 79)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(55, 42)
        Me.pictureBox2.TabIndex = 18
        Me.pictureBox2.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label4.Location = New System.Drawing.Point(88, 51)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "BIENVENIDO AL SISTEMA"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label5.Location = New System.Drawing.Point(109, 5)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(91, 33)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSingup)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 30)
        Me.Panel3.TabIndex = 26
        '
        'btnSingup
        '
        Me.btnSingup.AutoSize = True
        Me.btnSingup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSingup.Location = New System.Drawing.Point(270, 8)
        Me.btnSingup.Name = "btnSingup"
        Me.btnSingup.Size = New System.Drawing.Size(43, 13)
        Me.btnSingup.TabIndex = 19
        Me.btnSingup.Text = "Sign up"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(114, 13)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "Olvido su Contraseña?"
        '
        'bunifuSeparator2
        '
        Me.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bunifuSeparator2.LineThickness = 1
        Me.bunifuSeparator2.Location = New System.Drawing.Point(147, 10)
        Me.bunifuSeparator2.Name = "bunifuSeparator2"
        Me.bunifuSeparator2.Size = New System.Drawing.Size(105, 3)
        Me.bunifuSeparator2.TabIndex = 28
        Me.bunifuSeparator2.Transparency = 255
        Me.bunifuSeparator2.Vertical = False
        '
        'bunifuSeparator1
        '
        Me.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bunifuSeparator1.LineThickness = 2
        Me.bunifuSeparator1.Location = New System.Drawing.Point(42, 11)
        Me.bunifuSeparator1.Name = "bunifuSeparator1"
        Me.bunifuSeparator1.Size = New System.Drawing.Size(105, 3)
        Me.bunifuSeparator1.TabIndex = 27
        Me.bunifuSeparator1.Transparency = 255
        Me.bunifuSeparator1.Vertical = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'lblHora
        '
        Me.errorIcono.SetIconAlignment(Me.lblHora, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.lblHora.Location = New System.Drawing.Point(104, 19)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(114, 13)
        Me.lblHora.TabIndex = 29
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        Me.Tiempo.Interval = 10
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.Window
        Me.panel2.Controls.Add(Me.BunifuFlatButton4)
        Me.panel2.Controls.Add(Me.BunifuFlatButton3)
        Me.panel2.Controls.Add(Me.PictureBox7)
        Me.panel2.Controls.Add(Me.PictureBox6)
        Me.panel2.Controls.Add(Me.PictureBox5)
        Me.panel2.Controls.Add(Me.PictureBox4)
        Me.panel2.Controls.Add(Me.txtcodigotrabajador)
        Me.panel2.Controls.Add(Me.btnUsuario)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.txtPassordRegsitro)
        Me.panel2.Controls.Add(Me.cboAcceso)
        Me.panel2.Controls.Add(Me.txtCodigo)
        Me.panel2.Controls.Add(Me.txtNombre)
        Me.panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(319, 154)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(319, 296)
        Me.panel2.TabIndex = 23
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 7
        Me.BunifuFlatButton4.ButtonText = "Cancel"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(153, 251)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(110, 40)
        Me.BunifuFlatButton4.TabIndex = 26
        Me.BunifuFlatButton4.Text = "Cancel"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 7
        Me.BunifuFlatButton3.ButtonText = "Login"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(27, 251)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(110, 40)
        Me.BunifuFlatButton3.TabIndex = 26
        Me.BunifuFlatButton3.Text = "Login"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.paswordk
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(43, 196)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 37)
        Me.PictureBox7.TabIndex = 48
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.accesousuario
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(43, 147)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(54, 37)
        Me.PictureBox6.TabIndex = 47
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.nomnreuser
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(42, 100)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 35)
        Me.PictureBox5.TabIndex = 46
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.CodigoUser
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(42, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 37)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'txtcodigotrabajador
        '
        Me.txtcodigotrabajador.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtcodigotrabajador.Location = New System.Drawing.Point(287, 115)
        Me.txtcodigotrabajador.Name = "txtcodigotrabajador"
        Me.txtcodigotrabajador.Size = New System.Drawing.Size(17, 20)
        Me.txtcodigotrabajador.TabIndex = 45
        Me.txtcodigotrabajador.Visible = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.Image = Global.CapaPresentacion.My.Resources.Resources.buscar
        Me.btnUsuario.ImageActive = Nothing
        Me.btnUsuario.Location = New System.Drawing.Point(256, 115)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(25, 20)
        Me.btnUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUsuario.TabIndex = 44
        Me.btnUsuario.TabStop = False
        Me.btnUsuario.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(102, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ACCESO AL SISITEMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(75, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Registrarse"
        '
        'txtPassordRegsitro
        '
        Me.txtPassordRegsitro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassordRegsitro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassordRegsitro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassordRegsitro.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassordRegsitro.HintText = "Password:"
        Me.txtPassordRegsitro.isPassword = False
        Me.txtPassordRegsitro.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtPassordRegsitro.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtPassordRegsitro.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtPassordRegsitro.LineThickness = 3
        Me.txtPassordRegsitro.Location = New System.Drawing.Point(101, 206)
        Me.txtPassordRegsitro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassordRegsitro.Name = "txtPassordRegsitro"
        Me.txtPassordRegsitro.Size = New System.Drawing.Size(142, 27)
        Me.txtPassordRegsitro.TabIndex = 43
        Me.txtPassordRegsitro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cboAcceso
        '
        Me.cboAcceso.AutoCompleteCustomSource.AddRange(New String() {"Administrador", "Empleado"})
        Me.cboAcceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboAcceso.BackColor = System.Drawing.Color.Silver
        Me.cboAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAcceso.ForeColor = System.Drawing.Color.Black
        Me.cboAcceso.FormattingEnabled = True
        Me.cboAcceso.Items.AddRange(New Object() {"Administrador", "Empleado"})
        Me.cboAcceso.Location = New System.Drawing.Point(103, 156)
        Me.cboAcceso.Name = "cboAcceso"
        Me.cboAcceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAcceso.Size = New System.Drawing.Size(142, 26)
        Me.cboAcceso.TabIndex = 41
        Me.cboAcceso.Text = "Acceso"
        '
        'txtCodigo
        '
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.HintForeColor = System.Drawing.Color.Empty
        Me.txtCodigo.HintText = "Codigo:"
        Me.txtCodigo.isPassword = False
        Me.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtCodigo.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtCodigo.LineThickness = 3
        Me.txtCodigo.Location = New System.Drawing.Point(103, 64)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(140, 27)
        Me.txtCodigo.TabIndex = 39
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.HintForeColor = System.Drawing.Color.Empty
        Me.txtNombre.HintText = "Nombre:"
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(105, 108)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(140, 27)
        Me.txtNombre.TabIndex = 35
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.CapaPresentacion.My.Resources.Resources.close
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(295, 1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(24, 22)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.TabStop = False
        Me.btnSalir.Zoom = 10
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.logosistemaRopa
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.Location = New System.Drawing.Point(0, 34)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(319, 115)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 24
        Me.pictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(319, 480)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bunifuSeparator2)
        Me.Controls.Add(Me.bunifuSeparator1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSalir As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents panel1 As Panel
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnIngresar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtUsuario As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Private WithEvents lblErroalAcceder As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents lblPassword As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents lblUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSingup As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents bunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents bunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Timer1 As Timer
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents ttMensaje As DevComponents.DotNetBar.SuperTooltip
    Private WithEvents errorIcono As ErrorProvider
    Friend WithEvents lblHora As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents panel2 As Panel
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents PictureBox7 As PictureBox
    Private WithEvents PictureBox6 As PictureBox
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtcodigotrabajador As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnUsuario As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents txtPassordRegsitro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents cboAcceso As ComboBox
    Private WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents Tiempo As Timer
End Class
