<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMostrarListaProductos
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
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.dataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Nombre_Categoria"})
        Me.cbocampo.Location = New System.Drawing.Point(30, 72)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(106, 21)
        Me.cbocampo.TabIndex = 21
        Me.cbocampo.Text = "Nombre"
        '
        'dataListadoProducto
        '
        Me.dataListadoProducto.AllowUserToAddRows = False
        Me.dataListadoProducto.AllowUserToDeleteRows = False
        Me.dataListadoProducto.AllowUserToOrderColumns = True
        Me.dataListadoProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListadoProducto.ColumnHeadersHeight = 25
        Me.dataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListadoProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoProducto.EnableHeadersVisualStyles = False
        Me.dataListadoProducto.Location = New System.Drawing.Point(16, 107)
        Me.dataListadoProducto.MultiSelect = False
        Me.dataListadoProducto.Name = "dataListadoProducto"
        Me.dataListadoProducto.ReadOnly = True
        Me.dataListadoProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataListadoProducto.RowHeadersVisible = False
        Me.dataListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoProducto.Size = New System.Drawing.Size(851, 210)
        Me.dataListadoProducto.TabIndex = 20
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
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
        Me.txtBuscar.Location = New System.Drawing.Point(177, 70)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(484, 28)
        Me.txtBuscar.TabIndex = 19
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBuscar.WatermarkText = "Search"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(381, 226)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 22
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos no existen "
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(707, 73)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(55, 20)
        Me.txtflag.TabIndex = 37
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'FormMostrarListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 331)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.cbocampo)
        Me.Controls.Add(Me.dataListadoProducto)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "FormMostrarListaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                           ..................... FORMULARIO DE SELECCIONAR UN PRO" &
    "DUCTO :: ..............................."
        CType(Me.dataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbocampo As ComboBox
    Private WithEvents dataListadoProducto As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Private WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtflag As TextBox
End Class
