<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListaCategoria
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
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.cboComBuscar = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dataListadoCategoria = New System.Windows.Forms.DataGridView()
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(356, 238)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 30
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos no existen "
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(625, 77)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(49, 20)
        Me.txtflag.TabIndex = 29
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'cboComBuscar
        '
        Me.cboComBuscar.FormattingEnabled = True
        Me.cboComBuscar.Items.AddRange(New Object() {"Nombre"})
        Me.cboComBuscar.Location = New System.Drawing.Point(146, 80)
        Me.cboComBuscar.Name = "cboComBuscar"
        Me.cboComBuscar.Size = New System.Drawing.Size(117, 21)
        Me.cboComBuscar.TabIndex = 28
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
        Me.txtBuscar.Location = New System.Drawing.Point(283, 76)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(336, 28)
        Me.txtBuscar.TabIndex = 27
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'dataListadoCategoria
        '
        Me.dataListadoCategoria.AllowUserToAddRows = False
        Me.dataListadoCategoria.AllowUserToDeleteRows = False
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
        Me.dataListadoCategoria.EnableHeadersVisualStyles = False
        Me.dataListadoCategoria.GridColor = System.Drawing.Color.White
        Me.dataListadoCategoria.Location = New System.Drawing.Point(12, 110)
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
        Me.dataListadoCategoria.Size = New System.Drawing.Size(781, 218)
        Me.dataListadoCategoria.TabIndex = 26
        '
        'FormListaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 343)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.cboComBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dataListadoCategoria)
        Me.Name = "FormListaCategoria"
        Me.Text = "                                .................. :: FORMULARIO DE SELECCIONAR U" &
    "NA CATEGORIA :: ..............."
        Me.TransparencyKey = System.Drawing.Color.DimGray
        CType(Me.dataListadoCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtflag As TextBox
    Friend WithEvents cboComBuscar As ComboBox
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dataListadoCategoria As DataGridView
End Class
