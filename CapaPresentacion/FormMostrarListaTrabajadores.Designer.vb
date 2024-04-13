<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMostrarListaTrabajadores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datlistaTrabajadores = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.groupBox3.SuspendLayout()
        CType(Me.datlistaTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtflag)
        Me.groupBox3.Controls.Add(Me.cboBuscar)
        Me.groupBox3.Controls.Add(Me.inexistente)
        Me.groupBox3.Controls.Add(Me.datlistaTrabajadores)
        Me.groupBox3.Controls.Add(Me.txtBuscar)
        Me.groupBox3.Location = New System.Drawing.Point(12, 66)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(832, 234)
        Me.groupBox3.TabIndex = 7
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Listado"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(662, 12)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(49, 20)
        Me.txtflag.TabIndex = 28
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Nombre", "NDocumento"})
        Me.cboBuscar.Location = New System.Drawing.Point(62, 12)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(132, 21)
        Me.cboBuscar.TabIndex = 27
        Me.cboBuscar.Text = "Nombre"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(353, 129)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(140, 13)
        Me.inexistente.TabIndex = 20
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
        Me.datlistaTrabajadores.EnableHeadersVisualStyles = False
        Me.datlistaTrabajadores.GridColor = System.Drawing.Color.White
        Me.datlistaTrabajadores.Location = New System.Drawing.Point(17, 47)
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
        Me.datlistaTrabajadores.Size = New System.Drawing.Size(798, 176)
        Me.datlistaTrabajadores.TabIndex = 13
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
        Me.txtBuscar.Location = New System.Drawing.Point(231, 7)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(404, 28)
        Me.txtBuscar.TabIndex = 11
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'FormMostrarListaTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 308)
        Me.Controls.Add(Me.groupBox3)
        Me.Name = "FormMostrarListaTrabajadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".................................... :: FORMULARIO DE SELECCIONAR UN TRABAJADOR :" &
    ": ........................."
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.datlistaTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox3 As GroupBox
    Friend WithEvents txtflag As TextBox
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents inexistente As LinkLabel
    Private WithEvents datlistaTrabajadores As DataGridView
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
End Class
